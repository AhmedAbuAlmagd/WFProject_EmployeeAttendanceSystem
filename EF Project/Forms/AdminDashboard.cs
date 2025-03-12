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
    public partial class AdminDashboard : Form
    {
        int admin_id;
        public AdminDashboard(int admin_id)
        {
            InitializeComponent();
            this.admin_id = admin_id;
        }

       
        private void btn_deptsManagement_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DepartmentsForm(this).Show();
        }

        private void btn_usersManagement_HRD_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersForm(this).Show();
        }

        private void btn_empmanage_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeManagment(admin_id,this).Show();
        }

        private void btn_showrequest_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowRequests(admin_id,this).Show();
        }


        private void btn_showreport_HRF_Click(object sender, EventArgs e)
        {
            new ShowReports(this).Show();
            this.Hide();
        }

        private void btn_empattend_HRF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeAttendance(admin_id,this).Show();
        }

        private void btn_logout_HRDF_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
