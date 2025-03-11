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
            cb_showemp_SRF.DataSource = employeeServices.GetAll();
            cb_showemp_SRF.DisplayMember = "name";
            cb_showemp_SRF.ValueMember = "id";
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            for (int i = 0; i < 2020; i++)
            {
                cb_year_SRF.Items.Add(i);

            }
            cb_year_SRF.SelectedItem = currentYear;
            for (int i = 0; i < 12; i++)
            {
                cb_month_SRF.Items.Add(i);
            }
            cb_month_SRF.SelectedItem = currentMonth;
            this.prevForm = prevForm;
        }

        private void btn_dailyreport_SRF_Click(object sender, EventArgs e)
        {

            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            dgv_showreport_SRF.DataSource = attendanceServices.GetDailyAttendance(date);

        }

        private void btn_showweekreport_SRF_Click(object sender, EventArgs e)
        {
            if (cb_showemp_SRF.SelectedValue == null)
            {
                MessageBox.Show("Please Choose Employee First!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
            DateTime startDate = DateTime.Now.AddDays(-7);

            List<Attendance> weeklyReport = attendanceServices.GetAttendanceByEmpIdAndDate(empId, DateOnly.FromDateTime(startDate));
            dgv_showreport_SRF.DataSource = weeklyReport;
        }

        private void btn_showmonth_SRF_Click(object sender, EventArgs e)
        {

            if (cb_showemp_SRF == null)
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
            MessageBox.Show("Please Choose One Employee", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            int year = (int)cb_year_SRF.SelectedItem;
            int month = (int)cb_month_SRF.SelectedItem;
            List<Attendance> monthlyReport = attendanceServices.GetMonthlyAttendance(empId, year, month);
            dgv_showreport_SRF.DataSource = monthlyReport;
        }

        private void btn_back_SRF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        private void btn_logout_SRF_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
