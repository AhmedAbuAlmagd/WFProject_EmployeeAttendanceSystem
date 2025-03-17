    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project.Forms
{
    public partial class HRDashboard : Form
    {
        private int hr_id;
        public HRDashboard(int hr_id)
        {
            InitializeComponent();
            this.hr_id = hr_id;
        }

        public HRDashboard()
        {
        }

        private void btn_myattend_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AttendanceForm(hr_id, this).Show();
        }

        private void btn_empmanage_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeManagement(hr_id, this).Show();
        }

        private void btn_showrequest_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowRequests(hr_id, this).Show();
        }

        private void btn_showreport_HRF_Click(object sender, EventArgs e)
        {
            new ShowReports(this).Show();
            this.Hide();
        }

        private void btn_empattend_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeAttendance(hr_id, this).Show();
        }

        private void btn_logout_HRDF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void btn_leaveRequest_HRD_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LeaveRequestForm(hr_id, this).Show();
        }

  
        private void btn_freqAttend_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeWithFrequentAbsence(this).Show();
        }
    }
}
