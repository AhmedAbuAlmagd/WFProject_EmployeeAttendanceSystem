using System;
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

namespace EF_Project.Forms
{
    public partial class EmployeeAttendance : Form
    {
        AttendanceServices attendanceServices;
        AttendanceContext context;
        EmployeeServices employeeServices;
        Form prevForm;
        int employee_id;
        public EmployeeAttendance(int employee_id,Form prevForm)
        {
            InitializeComponent();
            this.context = new AttendanceContext();
            attendanceServices = new AttendanceServices(context);
            employeeServices = new EmployeeServices(context);
            this.prevForm = prevForm;
            this.employee_id = employee_id;
            LoadEmployees();
            //LoadDates();
        }
        private void LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();
            if(employeeServices.GetById(employee_id).User.role.ToString() == "HR")
              employees = employeeServices.GetAllEmp();
            else
              employees = employeeServices.GetAllEmpAndHr();

            cb_showbyuser_EAF.DataSource = employees;
            cb_showbyuser_EAF.DisplayMember = "name";
            cb_showbyuser_EAF.ValueMember = "id";
        }
        //private void LoadDates()
        //{
        //    var dates = attendanceServices.GetAllDates();
        //    if(dates == null || dates.Count == 0)
        //    {
        //        MessageBox.Show("No Dates Recorded", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    //cb_showbydate_EAF.DataSource = dates;
        //}


        private void btn_showbyuser_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbyuser_EAF.SelectedValue != null)
            {
                int employeeId = (int)cb_showbyuser_EAF.SelectedValue;
                var attendanceList = attendanceServices.GetAttendanceByEmployee(employeeId);
                dgv_empattend_EAF.DataSource = attendanceList;
                dgv_empattend_EAF.Columns["Employee"].Visible = false;
            }
        }

        private void btn_showbydate_EAF_Click(object sender, EventArgs e)
        {
            DateOnly selectedDate = DateOnly.FromDateTime(date_EAF.Value.Date);
            var attendanceList = attendanceServices.GetAttendanceByDate(selectedDate);
            dgv_empattend_EAF.DataSource = attendanceList;
            dgv_empattend_EAF.Columns["Employee"].Visible = false;
        }

        private void btn_back_EAF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }
    }
}
