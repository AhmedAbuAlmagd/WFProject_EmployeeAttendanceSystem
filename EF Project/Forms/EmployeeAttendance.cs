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

namespace EF_Project.Forms
{
    public partial class EmployeeAttendance : Form
    {
        AttendanceServices attendanceServices;
        AttendanceContext context;
        EmployeeServices employeeServices;
        Form prevForm;
        public EmployeeAttendance(Form prevForm)
        {
            InitializeComponent();
            this.context = new AttendanceContext();
            attendanceServices = new AttendanceServices(context);
            employeeServices = new EmployeeServices(context);
            this.prevForm = prevForm;
            LoadEmployees();
            LoadDates();
        }
        private void LoadEmployees()
        {
            var employees = employeeServices.GetAll();
            if(employees == null || employees.Count == 0 )
            {
                MessageBox.Show("No employees Found", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cb_showbyuser_EAF.DataSource = employees;
            cb_showbyuser_EAF.DisplayMember = "name";
            cb_showbyuser_EAF.ValueMember = "id";
        }
        private void LoadDates()
        {
            var dates = attendanceServices.GetAllDates();
            if(dates == null || dates.Count == 0)
            {
                MessageBox.Show("No Dates Recorded", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cb_showbydate_EAF.DataSource = dates;
        }


        private void btn_showbyuser_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbyuser_EAF.SelectedValue != null)
            {
                int employeeId = (int)cb_showbyuser_EAF.SelectedValue;
                var attendanceList = attendanceServices.GetAttendanceByEmployee(employeeId);
                dgv_empattend_EAF.DataSource = attendanceList;
            }
        }

        private void btn_showbydate_EAF_Click(object sender, EventArgs e)
        {
            if (cb_showbydate_EAF.SelectedItem != null)
            {
                DateOnly selectedDate = (DateOnly)cb_showbydate_EAF.SelectedItem;
                var attendanceList = attendanceServices.GetAttendanceByDate(selectedDate);
                dgv_empattend_EAF.DataSource = attendanceList;
            }
        }

        private void btn_back_EAF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }
    }
}
