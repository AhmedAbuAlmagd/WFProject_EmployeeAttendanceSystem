namespace EF_Project.Forms
{
    partial class EmployeeWithFrequentAbsence
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
            dgv_empfrequentabsence_EFAF = new DataGridView();
            btn_showabsenceemployees_EFAF = new Button();
            lbl_stdate_EFAF = new Label();
            lbl_enddate_EFAF = new Label();
            dtp_startDate_EFA = new DateTimePicker();
            dtp_endDate_EFAF = new DateTimePicker();
            btn_exportpdf_EFAF = new Button();
            btn_back_EFAF = new Button();
            btn_logout_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_empfrequentabsence_EFAF).BeginInit();
            SuspendLayout();
            // 
            // dgv_empfrequentabsence_EFAF
            // 
            dgv_empfrequentabsence_EFAF.BackgroundColor = Color.FromArgb(225, 223, 186);
            dgv_empfrequentabsence_EFAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empfrequentabsence_EFAF.Location = new Point(12, 264);
            dgv_empfrequentabsence_EFAF.Name = "dgv_empfrequentabsence_EFAF";
            dgv_empfrequentabsence_EFAF.RowHeadersWidth = 51;
            dgv_empfrequentabsence_EFAF.Size = new Size(578, 274);
            dgv_empfrequentabsence_EFAF.TabIndex = 0;
            // 
            // btn_showabsenceemployees_EFAF
            // 
            btn_showabsenceemployees_EFAF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showabsenceemployees_EFAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showabsenceemployees_EFAF.ForeColor = SystemColors.ControlLightLight;
            btn_showabsenceemployees_EFAF.Location = new Point(169, 160);
            btn_showabsenceemployees_EFAF.Name = "btn_showabsenceemployees_EFAF";
            btn_showabsenceemployees_EFAF.Size = new Size(311, 75);
            btn_showabsenceemployees_EFAF.TabIndex = 1;
            btn_showabsenceemployees_EFAF.Text = "Show Employees with Frequent absence";
            btn_showabsenceemployees_EFAF.UseVisualStyleBackColor = false;
            btn_showabsenceemployees_EFAF.Click += btn_showabsenceemployees_EFAF_Click;
            // 
            // lbl_stdate_EFAF
            // 
            lbl_stdate_EFAF.AutoSize = true;
            lbl_stdate_EFAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_stdate_EFAF.Location = new Point(21, 33);
            lbl_stdate_EFAF.Name = "lbl_stdate_EFAF";
            lbl_stdate_EFAF.Size = new Size(110, 28);
            lbl_stdate_EFAF.TabIndex = 2;
            lbl_stdate_EFAF.Text = "Start Date";
            // 
            // lbl_enddate_EFAF
            // 
            lbl_enddate_EFAF.AutoSize = true;
            lbl_enddate_EFAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_enddate_EFAF.Location = new Point(27, 97);
            lbl_enddate_EFAF.Name = "lbl_enddate_EFAF";
            lbl_enddate_EFAF.Size = new Size(98, 28);
            lbl_enddate_EFAF.TabIndex = 3;
            lbl_enddate_EFAF.Text = "End Date";
            // 
            // dtp_startDate_EFA
            // 
            dtp_startDate_EFA.Location = new Point(154, 36);
            dtp_startDate_EFA.Name = "dtp_startDate_EFA";
            dtp_startDate_EFA.Size = new Size(250, 27);
            dtp_startDate_EFA.TabIndex = 4;
            // 
            // dtp_endDate_EFAF
            // 
            dtp_endDate_EFAF.Location = new Point(154, 100);
            dtp_endDate_EFAF.Name = "dtp_endDate_EFAF";
            dtp_endDate_EFAF.Size = new Size(250, 27);
            dtp_endDate_EFAF.TabIndex = 5;
            // 
            // btn_exportpdf_EFAF
            // 
            btn_exportpdf_EFAF.BackColor = Color.FromArgb(160, 120, 70);
            btn_exportpdf_EFAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_exportpdf_EFAF.ForeColor = SystemColors.ControlLightLight;
            btn_exportpdf_EFAF.Location = new Point(607, 33);
            btn_exportpdf_EFAF.Name = "btn_exportpdf_EFAF";
            btn_exportpdf_EFAF.Size = new Size(216, 64);
            btn_exportpdf_EFAF.TabIndex = 6;
            btn_exportpdf_EFAF.Text = "Export To PDF";
            btn_exportpdf_EFAF.UseVisualStyleBackColor = false;
            btn_exportpdf_EFAF.Click += btn_exportpdf_EFAF_Click;
            // 
            // btn_back_EFAF
            // 
            btn_back_EFAF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_EFAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_EFAF.ForeColor = SystemColors.ControlLightLight;
            btn_back_EFAF.Location = new Point(605, 497);
            btn_back_EFAF.Name = "btn_back_EFAF";
            btn_back_EFAF.Size = new Size(116, 44);
            btn_back_EFAF.TabIndex = 7;
            btn_back_EFAF.Text = "Back";
            btn_back_EFAF.UseVisualStyleBackColor = false;
            btn_back_EFAF.Click += btn_back_EFAF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.Control;
            btn_logout_SRF.Location = new Point(737, 497);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(116, 44);
            btn_logout_SRF.TabIndex = 43;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            // 
            // EmployeeWithFrequentAbsence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(865, 550);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_EFAF);
            Controls.Add(btn_exportpdf_EFAF);
            Controls.Add(dtp_endDate_EFAF);
            Controls.Add(dtp_startDate_EFA);
            Controls.Add(lbl_enddate_EFAF);
            Controls.Add(lbl_stdate_EFAF);
            Controls.Add(btn_showabsenceemployees_EFAF);
            Controls.Add(dgv_empfrequentabsence_EFAF);
            Name = "EmployeeWithFrequentAbsence";
            Text = "EmployeeWithFrequentAbsence";
            ((System.ComponentModel.ISupportInitialize)dgv_empfrequentabsence_EFAF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_empfrequentabsence_EFAF;
        private Button btn_showabsenceemployees_EFAF;
        private Label lbl_stdate_EFAF;
        private Label lbl_enddate_EFAF;
        private DateTimePicker dtp_startDate_EFA;
        private DateTimePicker dtp_endDate_EFAF;
        private Button btn_exportpdf_EFAF;
        private Button btn_back_EFAF;
        private Button btn_logout_SRF;
    }
}