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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRDashboard));
            btn_myattend_HRF = new Button();
            btn_empattend_HRF = new Button();
            btn_empmanage_HRF = new Button();
            btn_showrequest_HRF = new Button();
            btn_showreport_HRF = new Button();
            btn_logout_HRDF = new Button();
            btn_leaveRequest_HRD = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_myattend_HRF
            // 
            btn_myattend_HRF.Location = new Point(209, 12);
            btn_myattend_HRF.Name = "btn_myattend_HRF";
            btn_myattend_HRF.Size = new Size(300, 50);
            btn_myattend_HRF.TabIndex = 0;
            btn_myattend_HRF.Text = "My Attendance";
            btn_myattend_HRF.UseVisualStyleBackColor = false;
            btn_myattend_HRF.Click += btn_myattend_HRF_Click;
            // 
            // btn_empattend_HRF
            // 
            btn_empattend_HRF.Location = new Point(209, 170);
            btn_empattend_HRF.Name = "btn_empattend_HRF";
            btn_empattend_HRF.Size = new Size(300, 50);
            btn_empattend_HRF.TabIndex = 1;
            btn_empattend_HRF.Text = "Employee Attendance";
            btn_empattend_HRF.UseVisualStyleBackColor = false;
            btn_empattend_HRF.Click += btn_empattend_HRF_Click;
            // 
            // btn_empmanage_HRF
            // 
            btn_empmanage_HRF.Location = new Point(209, 249);
            btn_empmanage_HRF.Name = "btn_empmanage_HRF";
            btn_empmanage_HRF.Size = new Size(300, 50);
            btn_empmanage_HRF.TabIndex = 2;
            btn_empmanage_HRF.Text = "Employee Managment";
            btn_empmanage_HRF.UseVisualStyleBackColor = false;
            btn_empmanage_HRF.Click += btn_empmanage_HRF_Click;
            // 
            // btn_showrequest_HRF
            // 
            btn_showrequest_HRF.Location = new Point(209, 328);
            btn_showrequest_HRF.Name = "btn_showrequest_HRF";
            btn_showrequest_HRF.Size = new Size(300, 50);
            btn_showrequest_HRF.TabIndex = 3;
            btn_showrequest_HRF.Text = "Show Requests";
            btn_showrequest_HRF.UseVisualStyleBackColor = false;
            btn_showrequest_HRF.Click += btn_showrequest_HRF_Click;
            // 
            // btn_showreport_HRF
            // 
            btn_showreport_HRF.Location = new Point(209, 407);
            btn_showreport_HRF.Name = "btn_showreport_HRF";
            btn_showreport_HRF.Size = new Size(300, 50);
            btn_showreport_HRF.TabIndex = 4;
            btn_showreport_HRF.Text = "Show Reports";
            btn_showreport_HRF.UseVisualStyleBackColor = false;
            btn_showreport_HRF.Click += btn_showreport_HRF_Click;
            // 
            // btn_logout_HRDF
            // 
            btn_logout_HRDF.Location = new Point(674, 435);
            btn_logout_HRDF.Name = "btn_logout_HRDF";
            btn_logout_HRDF.Size = new Size(121, 48);
            btn_logout_HRDF.TabIndex = 6;
            btn_logout_HRDF.Text = "Log Out";
            btn_logout_HRDF.UseVisualStyleBackColor = false;
            btn_logout_HRDF.Click += btn_logout_HRDF_Click;
            // 
            // btn_leaveRequest_HRD
            // 
            btn_leaveRequest_HRD.Location = new Point(209, 91);
            btn_leaveRequest_HRD.Name = "btn_leaveRequest_HRD";
            btn_leaveRequest_HRD.Size = new Size(300, 50);
            btn_leaveRequest_HRD.TabIndex = 0;
            btn_leaveRequest_HRD.Text = "Leave Request";
            btn_leaveRequest_HRD.UseVisualStyleBackColor = false;
            btn_leaveRequest_HRD.Click += btn_leaveRequest_HRD_Click;
            // 
            // HRDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 497);
            Controls.Add(btn_logout_HRDF);
            Controls.Add(btn_showreport_HRF);
            Controls.Add(btn_showrequest_HRF);
            Controls.Add(btn_empmanage_HRF);
            Controls.Add(btn_empattend_HRF);
            Controls.Add(btn_leaveRequest_HRD);
            Controls.Add(btn_myattend_HRF);
            Name = "HRDashboard";
            Text = "HRDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ISupportInitialize pictureBox1;
    }
}