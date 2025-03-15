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
            btn_myattend_HRF = new Button();
            btn_empattend_HRF = new Button();
            btn_empmanage_HRF = new Button();
            btn_showrequest_HRF = new Button();
            btn_showreport_HRF = new Button();
            btn_logout_HRDF = new Button();
            btn_leaveRequest_HRD = new Button();
            btn_empabsence_HRDF = new Button();
            SuspendLayout();
            // 
            // btn_myattend_HRF
            // 
            btn_myattend_HRF.Location = new Point(234, 12);
            btn_myattend_HRF.Name = "btn_myattend_HRF";
            btn_myattend_HRF.Size = new Size(397, 57);
            btn_myattend_HRF.TabIndex = 0;
            btn_myattend_HRF.Text = "My Attendance";
            btn_myattend_HRF.UseVisualStyleBackColor = true;
            btn_myattend_HRF.Click += btn_myattend_HRF_Click;
            // 
            // btn_empattend_HRF
            // 
            btn_empattend_HRF.Location = new Point(234, 174);
            btn_empattend_HRF.Name = "btn_empattend_HRF";
            btn_empattend_HRF.Size = new Size(397, 57);
            btn_empattend_HRF.TabIndex = 1;
            btn_empattend_HRF.Text = "Employee Attendance";
            btn_empattend_HRF.UseVisualStyleBackColor = true;
            btn_empattend_HRF.Click += btn_empattend_HRF_Click;
            // 
            // btn_empmanage_HRF
            // 
            btn_empmanage_HRF.Location = new Point(234, 316);
            btn_empmanage_HRF.Name = "btn_empmanage_HRF";
            btn_empmanage_HRF.Size = new Size(397, 57);
            btn_empmanage_HRF.TabIndex = 2;
            btn_empmanage_HRF.Text = "Employee Managment";
            btn_empmanage_HRF.UseVisualStyleBackColor = true;
            btn_empmanage_HRF.Click += btn_empmanage_HRF_Click;
            // 
            // btn_showrequest_HRF
            // 
            btn_showrequest_HRF.Location = new Point(234, 379);
            btn_showrequest_HRF.Name = "btn_showrequest_HRF";
            btn_showrequest_HRF.Size = new Size(397, 57);
            btn_showrequest_HRF.TabIndex = 3;
            btn_showrequest_HRF.Text = "Show Requests";
            btn_showrequest_HRF.UseVisualStyleBackColor = true;
            btn_showrequest_HRF.Click += btn_showrequest_HRF_Click;
            // 
            // btn_showreport_HRF
            // 
            btn_showreport_HRF.Location = new Point(234, 451);
            btn_showreport_HRF.Name = "btn_showreport_HRF";
            btn_showreport_HRF.Size = new Size(397, 57);
            btn_showreport_HRF.TabIndex = 4;
            btn_showreport_HRF.Text = "Show Reports";
            btn_showreport_HRF.UseVisualStyleBackColor = true;
            btn_showreport_HRF.Click += btn_showreport_HRF_Click;
            // 
            // btn_logout_HRDF
            // 
            btn_logout_HRDF.Location = new Point(697, 501);
            btn_logout_HRDF.Name = "btn_logout_HRDF";
            btn_logout_HRDF.Size = new Size(137, 50);
            btn_logout_HRDF.TabIndex = 6;
            btn_logout_HRDF.Text = "Log Out";
            btn_logout_HRDF.UseVisualStyleBackColor = true;
            btn_logout_HRDF.Click += btn_logout_HRDF_Click;
            // 
            // btn_leaveRequest_HRD
            // 
            btn_leaveRequest_HRD.Location = new Point(234, 96);
            btn_leaveRequest_HRD.Name = "btn_leaveRequest_HRD";
            btn_leaveRequest_HRD.Size = new Size(397, 57);
            btn_leaveRequest_HRD.TabIndex = 0;
            btn_leaveRequest_HRD.Text = "Leave Request";
            btn_leaveRequest_HRD.UseVisualStyleBackColor = true;
            btn_leaveRequest_HRD.Click += btn_leaveRequest_HRD_Click;
            // 
            // btn_empabsence_HRDF
            // 
            btn_empabsence_HRDF.Location = new Point(234, 246);
            btn_empabsence_HRDF.Name = "btn_empabsence_HRDF";
            btn_empabsence_HRDF.Size = new Size(397, 52);
            btn_empabsence_HRDF.TabIndex = 7;
            btn_empabsence_HRDF.Text = "Employee Absence";
            btn_empabsence_HRDF.UseVisualStyleBackColor = true;
            btn_empabsence_HRDF.Click += btn_empabsence_HRDF_Click;
            // 
            // HRDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 563);
            Controls.Add(btn_empabsence_HRDF);
            Controls.Add(btn_logout_HRDF);
            Controls.Add(btn_showreport_HRF);
            Controls.Add(btn_showrequest_HRF);
            Controls.Add(btn_empmanage_HRF);
            Controls.Add(btn_empattend_HRF);
            Controls.Add(btn_leaveRequest_HRD);
            Controls.Add(btn_myattend_HRF);
            Name = "HRDashboard";
            Text = "HRDashboard";
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
        private Button btn_empabsence_HRDF;
    }
}