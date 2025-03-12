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
using EmployeeAttendanceSystem.Models;


namespace EF_Project.Forms
{
    public partial class ShowRequests : Form
    {
        LeaveRequestServices LeaveRequestServices;
        EmployeeServices EmployeeServices;
        AttendanceContext context;
        Form preForm;
        int selectedRequestId = -1;
        int employee_id;


        public ShowRequests(int employee_id, Form preForm)
        {
            InitializeComponent();
            context = new AttendanceContext();
            LeaveRequestServices = new LeaveRequestServices(context);
            EmployeeServices = new EmployeeServices(context);
            this.preForm = preForm;
            this.employee_id = employee_id;
        }

        private void ShowRequests_Load(object sender, EventArgs e)
        {
           try
           {
                if(EmployeeServices.GetById(employee_id).User.role.ToString() == "HR")
                {
                    dgv_showrequests_SRF.DataSource = LeaveRequestServices.GetAllPendingRequestsE();
                    dgv_showrequests_SRF.Columns["EmployeeId"].Visible = false;
                }
                else
                {
                    dgv_showrequests_SRF.DataSource = LeaveRequestServices.GetAllPendingRequestsA();
                    dgv_showrequests_SRF.Columns["EmployeeId"].Visible = false;
                }
                LoadEmployees();
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }

        private void LoadEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                if(EmployeeServices.GetById(employee_id).User.role.ToString() == "HR")
                 employees = EmployeeServices.GetAllEmp();
                else
                    employees = EmployeeServices.GetAllEmpAndHr();

                cb_showbyemp_SRF.SelectedIndexChanged -= cb_showbyemp_SRF_SelectedIndexChanged;

                cb_showbyemp_SRF.DataSource = employees;
                cb_showbyemp_SRF.DisplayMember = "name";
                cb_showbyemp_SRF.ValueMember = "id";

                cb_showbyemp_SRF.SelectedIndexChanged += cb_showbyemp_SRF_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cb_showbyemp_SRF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_showbyemp_SRF.SelectedValue != null)
            {
                selectedRequestId = Convert.ToInt32(cb_showbyemp_SRF.SelectedValue);

                var requests = LeaveRequestServices.ShowByEmployeeId(selectedRequestId);
                if (requests == null || requests.Count == 0)
                {
                    dgv_showrequests_SRF.DataSource = null;
                    MessageBox.Show("No leave requests found for this employee.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_showrequests_SRF.DataSource = requests;
                }
            }
        }


        private void dgv_showrequests_SRF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            if (dgv_showrequests_SRF.SelectedRows.Count > 0)
            {
                selectedRequestId = (int)dgv_showrequests_SRF.SelectedRows[0].Cells[0].Value;
                btn_accept_SRF.Enabled = true;
                btn_reject_SRF.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Choose one request");
            }
        }

        private void btn_accept_SRF_Click(object sender, EventArgs e)
        {
            if (selectedRequestId != -1)
            {
                LeaveRequestServices.ApproveLeaveRequest(selectedRequestId);
                MessageBox.Show("Request Approved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                showRefreshRequests();
                
            }
        }

        private void btn_reject_SRF_Click(object sender, EventArgs e)
        {
            if (selectedRequestId != -1)
            {
                LeaveRequestServices.UpdateRequestStatus(selectedRequestId, LeaverequestStatus.Rejected);
                MessageBox.Show("Request Rejected", "fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showRefreshRequests();
            }
        }


        private void showRefreshRequests()
        {
            if (cb_showbyemp_SRF.SelectedValue != null)
            {
                int selectedEmpId = (int)cb_showbyemp_SRF.SelectedValue;
                dgv_showrequests_SRF.DataSource = LeaveRequestServices.ShowRequestsByEmpId(selectedEmpId);
            }
        }

        private void btn_back_SRF_Click(object sender, EventArgs e)
        {
            this.Close();
            preForm.Show();
        }
    }
}
