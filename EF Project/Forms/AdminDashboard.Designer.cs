namespace EF_Project.Forms
{
    partial class AdminDashboard
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
            btn_logout_HRDF = new Button();
            btn_showreport_HRF = new Button();
            btn_showrequest_HRF = new Button();
            btn_empmanage_HRF = new Button();
            btn_empattend_HRF = new Button();
            btn_usersManagement_HRD = new Button();
            btn_deptsManagement_HRF = new Button();
            btn_showlogs_ADF = new Button();
            SuspendLayout();
            // 
            // btn_logout_HRDF
            // 
            btn_logout_HRDF.Location = new Point(697, 558);
            btn_logout_HRDF.Name = "btn_logout_HRDF";
            btn_logout_HRDF.Size = new Size(137, 50);
            btn_logout_HRDF.TabIndex = 13;
            btn_logout_HRDF.Text = "Log Out";
            btn_logout_HRDF.UseVisualStyleBackColor = true;
            btn_logout_HRDF.Click += btn_logout_HRDF_Click;
            // 
            // btn_showreport_HRF
            // 
            btn_showreport_HRF.Location = new Point(214, 424);
            btn_showreport_HRF.Name = "btn_showreport_HRF";
            btn_showreport_HRF.Size = new Size(397, 57);
            btn_showreport_HRF.TabIndex = 12;
            btn_showreport_HRF.Text = "Show Reports";
            btn_showreport_HRF.UseVisualStyleBackColor = true;
            btn_showreport_HRF.Click += btn_showreport_HRF_Click;
            // 
            // btn_showrequest_HRF
            // 
            btn_showrequest_HRF.Location = new Point(214, 339);
            btn_showrequest_HRF.Name = "btn_showrequest_HRF";
            btn_showrequest_HRF.Size = new Size(397, 57);
            btn_showrequest_HRF.TabIndex = 11;
            btn_showrequest_HRF.Text = "Show Requests";
            btn_showrequest_HRF.UseVisualStyleBackColor = true;
            btn_showrequest_HRF.Click += btn_showrequest_HRF_Click;
            // 
            // btn_empmanage_HRF
            // 
            btn_empmanage_HRF.Location = new Point(214, 177);
            btn_empmanage_HRF.Name = "btn_empmanage_HRF";
            btn_empmanage_HRF.Size = new Size(397, 57);
            btn_empmanage_HRF.TabIndex = 10;
            btn_empmanage_HRF.Text = "Employees Managment";
            btn_empmanage_HRF.UseVisualStyleBackColor = true;
            btn_empmanage_HRF.Click += btn_empmanage_HRF_Click;
            // 
            // btn_empattend_HRF
            // 
            btn_empattend_HRF.Location = new Point(214, 256);
            btn_empattend_HRF.Name = "btn_empattend_HRF";
            btn_empattend_HRF.Size = new Size(397, 57);
            btn_empattend_HRF.TabIndex = 9;
            btn_empattend_HRF.Text = "Employees Attendance";
            btn_empattend_HRF.UseVisualStyleBackColor = true;
            btn_empattend_HRF.Click += btn_empattend_HRF_Click;
            // 
            // btn_usersManagement_HRD
            // 
            btn_usersManagement_HRD.Location = new Point(214, 98);
            btn_usersManagement_HRD.Name = "btn_usersManagement_HRD";
            btn_usersManagement_HRD.Size = new Size(397, 57);
            btn_usersManagement_HRD.TabIndex = 7;
            btn_usersManagement_HRD.Text = "Users Management";
            btn_usersManagement_HRD.UseVisualStyleBackColor = true;
            btn_usersManagement_HRD.Click += btn_usersManagement_HRD_Click;
            // 
            // btn_deptsManagement_HRF
            // 
            btn_deptsManagement_HRF.Location = new Point(214, 19);
            btn_deptsManagement_HRF.Name = "btn_deptsManagement_HRF";
            btn_deptsManagement_HRF.Size = new Size(397, 57);
            btn_deptsManagement_HRF.TabIndex = 8;
            btn_deptsManagement_HRF.Text = "Departments Management ";
            btn_deptsManagement_HRF.UseVisualStyleBackColor = true;
            btn_deptsManagement_HRF.Click += btn_deptsManagement_HRF_Click;
            // 
            // btn_showlogs_ADF
            // 
            btn_showlogs_ADF.Location = new Point(214, 508);
            btn_showlogs_ADF.Name = "btn_showlogs_ADF";
            btn_showlogs_ADF.Size = new Size(397, 58);
            btn_showlogs_ADF.TabIndex = 14;
            btn_showlogs_ADF.Text = "Show Logs";
            btn_showlogs_ADF.UseVisualStyleBackColor = true;
            btn_showlogs_ADF.Click += btn_showlogs_ADF_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 634);
            Controls.Add(btn_showlogs_ADF);
            Controls.Add(btn_logout_HRDF);
            Controls.Add(btn_showreport_HRF);
            Controls.Add(btn_showrequest_HRF);
            Controls.Add(btn_empmanage_HRF);
            Controls.Add(btn_empattend_HRF);
            Controls.Add(btn_usersManagement_HRD);
            Controls.Add(btn_deptsManagement_HRF);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_logout_HRDF;
        private Button btn_showreport_HRF;
        private Button btn_showrequest_HRF;
        private Button btn_empmanage_HRF;
        private Button btn_empattend_HRF;
        private Button btn_usersManagement_HRD;
        private Button btn_deptsManagement_HRF;
        private Button btn_showlogs_ADF;
    }
}