﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.Models;
using QRCoder;
using System.Drawing;
using Newtonsoft.Json;
using EmployeeAttendanceSystem.DataAccess.Models;

namespace EF_Project.Forms
{
    public partial class EmployeeAttendance : Form
    {
        AttendanceServices attendanceServices;
        AttendanceContext context;
        EmployeeServices employeeServices;
        Form prevForm;
        int employee_id;
        public EmployeeAttendance(int employee_id, Form prevForm)
        {
            InitializeComponent();
            this.context = new AttendanceContext();
            attendanceServices = new AttendanceServices(context);
            employeeServices = new EmployeeServices(context);
            this.prevForm = prevForm;
            this.employee_id = employee_id;
            LoadEmployees();
            Design_Dgv();
        }

        private void Design_Dgv()
        {
            dgv_empattend_EAF.BackgroundColor = Color.Ivory;
            dgv_empattend_EAF.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dgv_empattend_EAF.DefaultCellStyle.ForeColor = Color.Black;
            dgv_empattend_EAF.GridColor = Color.Gray;

            dgv_empattend_EAF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 128);
            dgv_empattend_EAF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_empattend_EAF.EnableHeadersVisualStyles = false;

            dgv_empattend_EAF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 192);
            dgv_empattend_EAF.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();
            if (employeeServices.GetById(employee_id).User.role.ToString() == "HR")
                employees = employeeServices.GetAllEmp();
            else
                employees = employeeServices.GetAllEmpAndHr();

            cb_showbyuser_EAF.DataSource = employees;
            cb_showbyuser_EAF.DisplayMember = "name";
            cb_showbyuser_EAF.ValueMember = "id";
        }


        private void btn_showbyuser_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbyuser_EAF.SelectedValue != null)
            {
                int employeeId = (int)cb_showbyuser_EAF.SelectedValue;
                var attendanceList = attendanceServices.GetAttendanceByEmployee(employeeId).Select(a => new
                {
                    a.id,
                    EmployeeName = a.Employee.name, 
                    a.Date,
                    a.checkInTime,
                    a.checkOutTime,
                    a.WorkingHours,
                    a.attendanceStatus,
                    a.IsLate,
                    a.IsEarlyDeparture,
                    a.Employee_id
                })
                  .ToList(); 
                dgv_empattend_EAF.DataSource = attendanceList;
                pbQrCode.Image = null;
            }
        }

        private void btn_showbydate_EAF_Click(object sender, EventArgs e)
        {
            DateOnly selectedDate = DateOnly.FromDateTime(date_EAF.Value.Date);
            var attendanceList = attendanceServices.GetAttendanceByDate(selectedDate).Select(a => new
            {
                a.id,
                EmployeeName = a.Employee.name,
                a.Date,
                a.checkInTime,
                a.checkOutTime,
                a.WorkingHours,
                a.attendanceStatus,
                a.IsLate,
                a.IsEarlyDeparture,
                a.Employee_id
            })
                  .ToList(); ;
            dgv_empattend_EAF.DataSource = attendanceList;
            pbQrCode.Image = null;

        }

        private void btn_back_EAF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        private string GenerateQrData(Attendance attendance)
        {
            if (attendance == null)
            {
                return "No attendance data available";
            }

            StringBuilder sb = new StringBuilder();
        
                sb.AppendLine($"Employee: {attendance.Employee.name}");
                sb.AppendLine($"Date: {attendance.Date.ToString("yyyy-MM-dd")}");
                sb.AppendLine($"Check In: {attendance.checkInTime}");
                sb.AppendLine($"Check Out: {attendance.checkOutTime}");
                sb.AppendLine($"Working Hours: {attendance.WorkingHours}");
                sb.AppendLine($"Status: {attendance.attendanceStatus}");
                sb.AppendLine($"Late: {(attendance.IsLate ? "Yes" : "No")}");
                sb.AppendLine($"Early Departure: {(attendance.IsEarlyDeparture ? "Yes" : "No")}");
            return sb.ToString();

        }

        private Bitmap GenerateQrCode(string data)
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }

        private void btn_showbyuseranddate_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbyuser_EAF.SelectedValue != null)
            {
                int employeeId = (int)cb_showbyuser_EAF.SelectedValue;
                DateOnly selectedDate = DateOnly.FromDateTime(date_EAF.Value.Date);

                var attendanceList = attendanceServices.GetAttendanceByEmpIdAndDateOnly(employeeId, selectedDate).Select(a => new
                {
                    a.id,
                    EmployeeName = a.Employee.name,
                    a.Date,
                    a.checkInTime,
                    a.checkOutTime,
                    a.WorkingHours,
                    a.attendanceStatus,
                    a.IsLate,
                    a.IsEarlyDeparture,
                    a.Employee_id
                }).ToList();

                dgv_empattend_EAF.DataSource = attendanceList;
                dgv_empattend_EAF.Columns["Employee_id"].Visible = false;
                string qrData = GenerateQrData(attendanceServices.getById(attendanceList[0].id));
                Bitmap qrCode = GenerateQrCode(qrData);
                pbQrCode.Image = qrCode;
            }
            else
            {
                MessageBox.Show("Please select an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_empattend_EAF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int employeeId = (int)dgv_empattend_EAF.SelectedRows[0].Cells["Employee_id"].Value;
            DateOnly selectedDate = (DateOnly)dgv_empattend_EAF.SelectedRows[0].Cells["Date"].Value;
            var attendanceList = attendanceServices.GetAttendanceByEmpIdAndDateOnly(employeeId, selectedDate);

            string qrData = GenerateQrData(attendanceList[0]);
            Bitmap qrCode = GenerateQrCode(qrData);
            pbQrCode.Image = qrCode;

        }

        private void btn_logout_SRF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }
    }
}
