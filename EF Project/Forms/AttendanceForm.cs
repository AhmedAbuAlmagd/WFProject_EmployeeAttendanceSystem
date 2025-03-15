using System.Runtime.CompilerServices;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;

namespace EF_Project.Forms
{
    public partial class AttendanceForm : Form
    {
        private readonly int employee_id;
        private readonly AttendanceServices attendanceServices;
        private readonly LogsServices logsServices;
        private readonly EmployeeServices employeeServices;
        private readonly AttendanceContext context;
        Form prevForm;

        public AttendanceForm(int employee_id, Form prevForm)
        {
            InitializeComponent();
            context = new AttendanceContext();
            this.employee_id = employee_id;
            attendanceServices = new AttendanceServices(context);
            logsServices = new LogsServices(context);
            employeeServices = new EmployeeServices(context);
            this.prevForm = prevForm;
            toolTip.SetToolTip(btn_checkin_AF, "Click here to check-in.");
            toolTip.SetToolTip(btn_checkout_AF, "Click here to check-out.");
            toolTip.SetToolTip(btn_leaveRequest_AF, "Click here to request leave.");
            notifyIcon1.Visible = true;
        }
        //add tooltip to notify when emp is late for check-in
        private ToolTip toolTip = new ToolTip();

        private void ShowSystemNotification(string message)
        {
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipTitle = "You are Late!";
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(1000, "You are Late!", "You are Late for Check-in Time!", ToolTipIcon.Warning);

        }
        private void btn_checkin_AF_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceServices.CheckIn(employee_id);

                Log log = new Log
                {
                    empoloyeeId = employee_id,
                    action = EmployeeAttendanceSystem.DataAccess.Models.Action.checkIn,
                    actionTime = DateTime.Now
                };

                logsServices.Add(log);
                var attendanceList = attendanceServices.GetAttendanceByEmpIdAndDate(employee_id, DateOnly.FromDateTime(DateTime.Now));
                var attendance = attendanceList.FirstOrDefault();

                if (attendance != null && attendance.IsLate)
                {
                    MessageBox.Show($"Is LAte : {attendance.IsLate}");
                    toolTip.ToolTipTitle = "You Are Late !";
                    toolTip.IsBalloon = true;
                    toolTip.Show("You are Late !", this, 0, -50, 8000);
                    try
                    {
                        ShowSystemNotification("You are Late for Check-in Time!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error showing notification: {ex.Message}");
                    }
                }

                MessageBox.Show("Checked-In Successfully", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_checkout_AF_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceServices.CheckOut(employee_id);

                Log log = new Log
                {
                    empoloyeeId = employee_id,
                    action = EmployeeAttendanceSystem.DataAccess.Models.Action.checkOut,
                    actionTime = DateTime.Now
                };
                logsServices.Add(log);

                MessageBox.Show("Checked-Out Successfully", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_leaveRequest_AF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LeaveRequestForm(employee_id, this).Show();
        }

        private void btn_logout_AF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (employeeServices.GetById(employee_id).User.role.ToString() == "Employee")
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    prevForm.Show();
                }
            }

        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            if (employeeServices.GetById(employee_id).User.role.ToString() == "Admin" || employeeServices.GetById(employee_id).User.role.ToString() == "HR")
            {
                btn_logout_AF.Text = "Back";
            }
        }
    }
}