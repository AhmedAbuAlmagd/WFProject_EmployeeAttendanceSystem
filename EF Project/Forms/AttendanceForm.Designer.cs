namespace EF_Project.Forms
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            btn_checkin_AF = new Button();
            btn_checkout_AF = new Button();
            btn_leaveRequest_AF = new Button();
            btn_logout_AF = new Button();
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_checkin_AF
            // 
            btn_checkin_AF.BackColor = Color.FromArgb(45, 106, 79);
            btn_checkin_AF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_checkin_AF.ForeColor = SystemColors.ControlLightLight;
            btn_checkin_AF.Location = new Point(610, 136);
            btn_checkin_AF.Name = "btn_checkin_AF";
            btn_checkin_AF.Size = new Size(181, 56);
            btn_checkin_AF.TabIndex = 0;
            btn_checkin_AF.Text = "Check In ";
            btn_checkin_AF.UseVisualStyleBackColor = false;
            btn_checkin_AF.Click += btn_checkin_AF_Click;
            // 
            // btn_checkout_AF
            // 
            btn_checkout_AF.BackColor = Color.FromArgb(217, 4, 41);
            btn_checkout_AF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_checkout_AF.ForeColor = SystemColors.ControlLightLight;
            btn_checkout_AF.Location = new Point(610, 243);
            btn_checkout_AF.Name = "btn_checkout_AF";
            btn_checkout_AF.Size = new Size(181, 56);
            btn_checkout_AF.TabIndex = 1;
            btn_checkout_AF.Text = "Check Out";
            btn_checkout_AF.UseVisualStyleBackColor = false;
            btn_checkout_AF.Click += btn_checkout_AF_Click;
            // 
            // btn_leaveRequest_AF
            // 
            btn_leaveRequest_AF.BackColor = Color.FromArgb(30, 58, 138);
            btn_leaveRequest_AF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_leaveRequest_AF.ForeColor = SystemColors.ControlLightLight;
            btn_leaveRequest_AF.Location = new Point(610, 350);
            btn_leaveRequest_AF.Name = "btn_leaveRequest_AF";
            btn_leaveRequest_AF.Size = new Size(181, 56);
            btn_leaveRequest_AF.TabIndex = 2;
            btn_leaveRequest_AF.Text = "Leave Request";
            btn_leaveRequest_AF.UseVisualStyleBackColor = false;
            btn_leaveRequest_AF.Click += btn_leaveRequest_AF_Click;
            // 
            // btn_logout_AF
            // 
            btn_logout_AF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_AF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_AF.ForeColor = SystemColors.ControlLightLight;
            btn_logout_AF.Location = new Point(737, 488);
            btn_logout_AF.Name = "btn_logout_AF";
            btn_logout_AF.Size = new Size(116, 44);
            btn_logout_AF.TabIndex = 3;
            btn_logout_AF.Text = "Log Out";
            btn_logout_AF.UseVisualStyleBackColor = false;
            btn_logout_AF.Click += btn_logout_AF_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 100;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipTitle = " You are Late !";
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 543);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(865, 544);
            Controls.Add(pictureBox1);
            Controls.Add(btn_logout_AF);
            Controls.Add(btn_leaveRequest_AF);
            Controls.Add(btn_checkout_AF);
            Controls.Add(btn_checkin_AF);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_checkin_AF;
        private Button btn_checkout_AF;
        private Button btn_leaveRequest_AF;
        private Button btn_logout_AF;
        private ToolTip toolTip1;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
    }
}