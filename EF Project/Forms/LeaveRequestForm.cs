﻿using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
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
    public partial class LeaveRequestForm : Form
    {
        int employee_id;
        Form previousForm;
        LeaveRequestServices leaveRequestServices;
        LogsServices logsServices;
        AttendanceContext context;
        int request_id = -1;
        public LeaveRequestForm(int employee_id, Form previousForm)
        {
            InitializeComponent();
            this.employee_id = employee_id;
            this.previousForm = previousForm;
            btn_cancelRequest_LRF.Visible = false;
            context = new AttendanceContext();
            leaveRequestServices = new LeaveRequestServices(context);
            logsServices = new LogsServices(context);
        }

        private void btn_back_LRF_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btn_SendRequest_LRF_Click(object sender, EventArgs e)
        {
            btn_cancelRequest_LRF.Visible = false;
            btn_ShowRequests_LRF.Visible = true;

            LeaveRequest leaveRequest = new LeaveRequest();

            leaveRequest.requestDate = DateTime.Now;
            leaveRequest.LeaveStartTime = requestStartTime_LRF.Value.Date;
            leaveRequest.LeaveEndTime = requestEndTime_LRF.Value.Date;
            leaveRequest.LeaveType = (LeaveType)Enum.Parse(typeof(LeaveType), combo_leaveReason_LRF.Text, true);
            leaveRequest.EmployeeId = employee_id;
         

            leaveRequestServices.Add(leaveRequest);

            Log log = new Log()
            {
                action = EmployeeAttendanceSystem.DataAccess.Models.Action.leaveRequest,
                actionTime = DateTime.Now,
                empoloyeeId = employee_id
            };

            logsServices.Add(log);

            MessageBox.Show("Request Sent Successfully", "Leave Request", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_ShowRequests_LRF_Click(object sender, EventArgs e)
        {
            ShowLeaveRequests();
        }


        private void dgv_ShowRequests_LRF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            request_id = (int)dgv_ShowRequests_LRF.SelectedRows[0].Cells[0].Value;
            btn_cancelRequest_LRF.Visible = true;
            btn_ShowRequests_LRF.Visible = false;
        }

        private void btn_cancelRequest_LRF_Click(object sender, EventArgs e)
        {
            if (request_id != -1)
            {
                var result = MessageBox.Show("Are you sure you want to Cancel this request ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    leaveRequestServices.cancelRequest(request_id);
                    MessageBox.Show("Request Canceled successfully!", "Cancel Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowLeaveRequests();
                }

            }
            else
            {
                MessageBox.Show("No Requests Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowLeaveRequests()
        {
            dgv_ShowRequests_LRF.DataSource = leaveRequestServices.ShowRequestsByEmpId(employee_id);
            dgv_ShowRequests_LRF.Columns["EmployeeId"].Visible = false;
            dgv_ShowRequests_LRF.Columns["Employee"].Visible = false;
            btn_cancelRequest_LRF.Visible = false;
            btn_ShowRequests_LRF.Visible = true;
        }

        private void LeaveRequestForm_Load(object sender, EventArgs e)
        {
            combo_leaveReason_LRF.DataSource = Enum.GetValues(typeof(LeaveType));   
        }
    }
}
