﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Bouncycastleconnector;
using Org.BouncyCastle.Crypto;

using iText.IO.Font;
using iText.Kernel.Font;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;

namespace EF_Project.Forms
{
    public partial class ShowReports : Form
    {
        AttendanceServices attendanceServices;
        EmployeeServices employeeServices;
        AttendanceContext context;
        Form prevForm;
        public ShowReports(Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            context = new AttendanceContext();
            attendanceServices = new AttendanceServices(context);
            employeeServices = new EmployeeServices(context);
            cb_showemp_SRF.DataSource = employeeServices.GetAllEmp();
            cb_showemp_SRF.DisplayMember = "name";
            cb_showemp_SRF.ValueMember = "id";
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            for (int i = 2020; i <= 2025; i++)
            {
                cb_year_SRF.Items.Add(i);

            }
            cb_year_SRF.SelectedItem = currentYear;
            for (int i = 1; i <= 12; i++)
            {
                cb_month_SRF.Items.Add(i);
            }
            cb_month_SRF.SelectedItem = currentMonth;
            this.prevForm = prevForm;

            Design_Dgv();
        }

        private void btn_dailyreport_SRF_Click(object sender, EventArgs e)
        {

            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            var dailyAttendance = attendanceServices.GetDailyAttendance(date)
        .Select(a => new
        {
            EmployeeName = a.Employee != null ? a.Employee.name : "N/A",
            a.Date,
            a.checkInTime,
            a.checkOutTime,
            a.WorkingHours,
            a.attendanceStatus
            ,
            a.IsLate,
            a.IsEarlyDeparture
        }).ToList();

            dgv_showreport_SRF.DataSource = dailyAttendance;

        }

        private void btn_showweekreport_SRF_Click(object sender, EventArgs e)
        {
            if (cb_showemp_SRF.SelectedValue == null)
            {
                MessageBox.Show("Please Choose Employee First!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
            DateOnly startDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-7));
            DateOnly endDate = DateOnly.FromDateTime(DateTime.Now);

            var weeklyReport = attendanceServices.GetAttendanceByEmpIdAndDate(empId,startDate,endDate)
       .Select(a => new
       {
           EmployeeName = a.Employee != null ? a.Employee.name : "N/A",
           a.Date,
           a.checkInTime,
           a.checkOutTime,
           a.WorkingHours,
           a.attendanceStatus,
           a.IsLate,
           a.IsEarlyDeparture
       }).ToList();
            if (weeklyReport.Count == 0)
            {
                MessageBox.Show("No attendance records found for this employee in the past week.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_showreport_SRF.DataSource = weeklyReport;
            }

            // dgv_showreport_SRF.DataSource = weeklyReport;


        }

        private void btn_showmonth_SRF_Click(object sender, EventArgs e)
        {

            if (cb_showemp_SRF.SelectedValue == null)
            {
                MessageBox.Show("Please Choose One Employee", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_year_SRF.SelectedItem == null && cb_month_SRF.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Year and Month", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
            int year = (int)cb_year_SRF.SelectedItem;
            int month = (int)cb_month_SRF.SelectedItem;


            var monthlyReport = attendanceServices.GetMonthlyAttendance(year,month,empId)
        .Select(a => new
        {
            EmployeeName = a.Employee != null ? a.Employee.name : "N/A",
            a.Date,
            a.checkInTime,
            a.checkOutTime,
            a.WorkingHours,
            a.attendanceStatus,
            a.IsLate,
            a.IsEarlyDeparture
        }).ToList();

            dgv_showreport_SRF.DataSource = monthlyReport;

        }

        private void btn_back_SRF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        private void btn_logout_SRF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new LoginForm().Show();
            }
        }

        //Reports

        BouncyCastleDefaultFactory factory = new BouncyCastleDefaultFactory();

        private void ExportDGVtoPDF(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4.Rotate());
                using (Document document = new Document(pdf))
                {
                    document.Add(new Paragraph("Attendance Report").SetFontSize(20));

                    float[] columnWidths = new float[dgv_showreport_SRF.ColumnCount];
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        columnWidths[i] = 1;
                    }
                    Table table = new Table(UnitValue.CreatePercentArray(columnWidths)).UseAllAvailableWidth();
                    table.SetFontSize(8);
                    table.SetPadding(2);

                    foreach (DataGridViewColumn column in dgv_showreport_SRF.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));

                    }

                    foreach (DataGridViewRow row in dgv_showreport_SRF.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                            }
                        }


                    }
                    document.Add(table);
                }


            }
        }

        private void btn_exportPDF_SRF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Choose Place"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDGVtoPDF(saveFileDialog.FileName);
                MessageBox.Show(" Report File Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowReports_Load(object sender, EventArgs e)
        {
            //if 
            cb_showemp_SRF.DataSource = employeeServices.GetAllEmp();
        }

        private void Design_Dgv()
        {
            dgv_showreport_SRF.BackgroundColor = Color.Ivory;
            dgv_showreport_SRF.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dgv_showreport_SRF.DefaultCellStyle.ForeColor = Color.Black;
            dgv_showreport_SRF.GridColor = Color.Gray;

            dgv_showreport_SRF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 128);
            dgv_showreport_SRF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_showreport_SRF.EnableHeadersVisualStyles = false;

            dgv_showreport_SRF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 192);
            dgv_showreport_SRF.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
