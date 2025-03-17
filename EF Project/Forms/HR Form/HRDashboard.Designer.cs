using System.ComponentModel;

namespace EF_Project.Forms
{
    partial class HRDashboard
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(HRDashboard));
            btn_myattend_HRF = new Button();
            btn_empattend_HRF = new Button();
            btn_empmanage_HRF = new Button();
            btn_showrequest_HRF = new Button();
            btn_showreport_HRF = new Button();
            btn_logout_HRDF = new Button();
            btn_leaveRequest_HRD = new Button();
            btn_freqAttend_HRF = new Button();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_myattend_HRF
            // 
            btn_myattend_HRF.BackColor = Color.Teal;
            btn_myattend_HRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_myattend_HRF.ForeColor = SystemColors.ButtonHighlight;
            btn_myattend_HRF.Location = new Point(513, 27);
            btn_myattend_HRF.Name = "btn_myattend_HRF";
            btn_myattend_HRF.Size = new Size(300, 50);
            btn_myattend_HRF.TabIndex = 0;
            btn_myattend_HRF.Text = "My Attendance";
            btn_myattend_HRF.UseVisualStyleBackColor = false;
            btn_myattend_HRF.Click += btn_myattend_HRF_Click;
            // 
            // btn_empattend_HRF
            // 
            btn_empattend_HRF.BackColor = Color.Teal;
            btn_empattend_HRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_empattend_HRF.ForeColor = SystemColors.ButtonHighlight;
            btn_empattend_HRF.Location = new Point(513, 157);
            btn_empattend_HRF.Name = "btn_empattend_HRF";
            btn_empattend_HRF.Size = new Size(300, 50);
            btn_empattend_HRF.TabIndex = 1;
            btn_empattend_HRF.Text = "Employee Attendance";
            btn_empattend_HRF.UseVisualStyleBackColor = false;
            btn_empattend_HRF.Click += btn_empattend_HRF_Click;
            // 
            // btn_empmanage_HRF
            // 
            btn_empmanage_HRF.BackColor = Color.Teal;
            btn_empmanage_HRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_empmanage_HRF.ForeColor = SystemColors.ButtonHighlight;
            btn_empmanage_HRF.Location = new Point(513, 287);
            btn_empmanage_HRF.Name = "btn_empmanage_HRF";
            btn_empmanage_HRF.Size = new Size(300, 50);
            btn_empmanage_HRF.TabIndex = 2;
            btn_empmanage_HRF.Text = "Employee Managment";
            btn_empmanage_HRF.UseVisualStyleBackColor = false;
            btn_empmanage_HRF.Click += btn_empmanage_HRF_Click;
            // 
            // btn_showrequest_HRF
            // 
            btn_showrequest_HRF.BackColor = Color.Teal;
            btn_showrequest_HRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showrequest_HRF.ForeColor = SystemColors.ButtonHighlight;
            btn_showrequest_HRF.Location = new Point(513, 352);
            btn_showrequest_HRF.Name = "btn_showrequest_HRF";
            btn_showrequest_HRF.Size = new Size(300, 50);
            btn_showrequest_HRF.TabIndex = 3;
            btn_showrequest_HRF.Text = "Show Requests";
            btn_showrequest_HRF.UseVisualStyleBackColor = false;
            btn_showrequest_HRF.Click += btn_showrequest_HRF_Click;
            // 
            // btn_showreport_HRF
            // 
            btn_showreport_HRF.BackColor = Color.Teal;
            btn_showreport_HRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showreport_HRF.ForeColor = SystemColors.ButtonHighlight;
            btn_showreport_HRF.Location = new Point(513, 417);
            btn_showreport_HRF.Name = "btn_showreport_HRF";
            btn_showreport_HRF.Size = new Size(300, 50);
            btn_showreport_HRF.TabIndex = 4;
            btn_showreport_HRF.Text = "Show Reports";
            btn_showreport_HRF.UseVisualStyleBackColor = false;
            btn_showreport_HRF.Click += btn_showreport_HRF_Click;
            // 
            // btn_logout_HRDF
            // 
            btn_logout_HRDF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_HRDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_HRDF.ForeColor = SystemColors.ButtonHighlight;
            btn_logout_HRDF.Location = new Point(737, 488);
            btn_logout_HRDF.Name = "btn_logout_HRDF";
            btn_logout_HRDF.Size = new Size(116, 44);
            btn_logout_HRDF.TabIndex = 6;
            btn_logout_HRDF.Text = "Log Out";
            btn_logout_HRDF.UseVisualStyleBackColor = false;
            btn_logout_HRDF.Click += btn_logout_HRDF_Click;
            // 
            // btn_leaveRequest_HRD
            // 
            btn_leaveRequest_HRD.BackColor = Color.Teal;
            btn_leaveRequest_HRD.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_leaveRequest_HRD.ForeColor = SystemColors.ButtonHighlight;
            btn_leaveRequest_HRD.Location = new Point(513, 92);
            btn_leaveRequest_HRD.Name = "btn_leaveRequest_HRD";
            btn_leaveRequest_HRD.Size = new Size(300, 50);
            btn_leaveRequest_HRD.TabIndex = 0;
            btn_leaveRequest_HRD.Text = "Leave Request";
            btn_leaveRequest_HRD.UseVisualStyleBackColor = false;
            btn_leaveRequest_HRD.Click += btn_leaveRequest_HRD_Click;
            // 
            // btn_freqAttend_HRF
            // 
            btn_freqAttend_HRF.BackColor = Color.Teal;
            btn_freqAttend_HRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_freqAttend_HRF.ForeColor = SystemColors.ButtonHighlight;
            btn_freqAttend_HRF.Location = new Point(513, 222);
            btn_freqAttend_HRF.Name = "btn_freqAttend_HRF";
            btn_freqAttend_HRF.Size = new Size(300, 50);
            btn_freqAttend_HRF.TabIndex = 1;
            btn_freqAttend_HRF.Text = "Employee Frequent Absence";
            btn_freqAttend_HRF.UseVisualStyleBackColor = false;
            btn_freqAttend_HRF.Click += btn_freqAttend_HRF_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 549);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // HRDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(865, 544);
            Controls.Add(pictureBox1);
            Controls.Add(btn_logout_HRDF);
            Controls.Add(btn_showreport_HRF);
            Controls.Add(btn_showrequest_HRF);
            Controls.Add(btn_empmanage_HRF);
            Controls.Add(btn_freqAttend_HRF);
            Controls.Add(btn_empattend_HRF);
            Controls.Add(btn_leaveRequest_HRD);
            Controls.Add(btn_myattend_HRF);
            Name = "HRDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRDashboard";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_myattend_HRF;
        private Button btn_empattend_HRF;
        private Button btn_empmanage_HRF;
        private Button btn_showrequest_HRF;
        private Button btn_showreport_HRF;
        private Button btn_logout_HRDF;
        private Button btn_leaveRequest_HRD;
        private Button btn_freqAttend_HRF;
        private PictureBox pictureBox1;
    }
}