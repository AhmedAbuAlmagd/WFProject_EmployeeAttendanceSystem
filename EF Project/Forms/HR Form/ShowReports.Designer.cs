namespace EF_Project.Forms
{
    partial class ShowReports
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
            dgv_showreport_SRF = new DataGridView();
            btn_dailyreport_SRF = new Button();
            btn_showweekreport_SRF = new Button();
            btn_showmonth_SRF = new Button();
            cb_showemp_SRF = new ComboBox();
            cb_year_SRF = new ComboBox();
            cb_month_SRF = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btn_back_SRF = new Button();
            btn_logout_SRF = new Button();
            btn_exportPDF_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_showreport_SRF).BeginInit();
            SuspendLayout();
            // 
            // dgv_showreport_SRF
            // 
            dgv_showreport_SRF.BackgroundColor = Color.Ivory;
            dgv_showreport_SRF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_showreport_SRF.Location = new Point(27, 291);
            dgv_showreport_SRF.Name = "dgv_showreport_SRF";
            dgv_showreport_SRF.RowHeadersWidth = 51;
            dgv_showreport_SRF.Size = new Size(526, 247);
            dgv_showreport_SRF.TabIndex = 0;
            // 
            // btn_dailyreport_SRF
            // 
            btn_dailyreport_SRF.BackColor = Color.FromArgb(53, 122, 189);
            btn_dailyreport_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_dailyreport_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_dailyreport_SRF.Location = new Point(27, 23);
            btn_dailyreport_SRF.Name = "btn_dailyreport_SRF";
            btn_dailyreport_SRF.Size = new Size(246, 64);
            btn_dailyreport_SRF.TabIndex = 1;
            btn_dailyreport_SRF.Text = "Get Employees Daily Reports";
            btn_dailyreport_SRF.UseVisualStyleBackColor = false;
            btn_dailyreport_SRF.Click += btn_dailyreport_SRF_Click;
            // 
            // btn_showweekreport_SRF
            // 
            btn_showweekreport_SRF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showweekreport_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showweekreport_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_showweekreport_SRF.Location = new Point(27, 113);
            btn_showweekreport_SRF.Name = "btn_showweekreport_SRF";
            btn_showweekreport_SRF.Size = new Size(246, 67);
            btn_showweekreport_SRF.TabIndex = 2;
            btn_showweekreport_SRF.Text = "Show Weekly Report Per Employee";
            btn_showweekreport_SRF.UseVisualStyleBackColor = false;
            btn_showweekreport_SRF.Click += btn_showweekreport_SRF_Click;
            // 
            // btn_showmonth_SRF
            // 
            btn_showmonth_SRF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showmonth_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showmonth_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_showmonth_SRF.Location = new Point(27, 199);
            btn_showmonth_SRF.Name = "btn_showmonth_SRF";
            btn_showmonth_SRF.Size = new Size(246, 64);
            btn_showmonth_SRF.TabIndex = 3;
            btn_showmonth_SRF.Text = "Show Monthly Report Per Employee";
            btn_showmonth_SRF.UseVisualStyleBackColor = false;
            btn_showmonth_SRF.Click += btn_showmonth_SRF_Click;
            // 
            // cb_showemp_SRF
            // 
            cb_showemp_SRF.FormattingEnabled = true;
            cb_showemp_SRF.Location = new Point(312, 136);
            cb_showemp_SRF.Name = "cb_showemp_SRF";
            cb_showemp_SRF.Size = new Size(187, 28);
            cb_showemp_SRF.TabIndex = 4;
            // 
            // cb_year_SRF
            // 
            cb_year_SRF.FormattingEnabled = true;
            cb_year_SRF.Location = new Point(387, 217);
            cb_year_SRF.Name = "cb_year_SRF";
            cb_year_SRF.Size = new Size(112, 28);
            cb_year_SRF.TabIndex = 5;
            // 
            // cb_month_SRF
            // 
            cb_month_SRF.FormattingEnabled = true;
            cb_month_SRF.Location = new Point(635, 217);
            cb_month_SRF.Name = "cb_month_SRF";
            cb_month_SRF.Size = new Size(102, 28);
            cb_month_SRF.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(312, 217);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 7;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(545, 217);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 8;
            label2.Text = "Month";
            // 
            // btn_back_SRF
            // 
            btn_back_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_back_SRF.Location = new Point(559, 493);
            btn_back_SRF.Name = "btn_back_SRF";
            btn_back_SRF.Size = new Size(122, 45);
            btn_back_SRF.TabIndex = 9;
            btn_back_SRF.Text = "Back";
            btn_back_SRF.UseVisualStyleBackColor = false;
            btn_back_SRF.Click += btn_back_SRF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_logout_SRF.Location = new Point(688, 493);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(122, 45);
            btn_logout_SRF.TabIndex = 10;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            btn_logout_SRF.Click += btn_logout_SRF_Click;
            // 
            // btn_exportPDF_SRF
            // 
            btn_exportPDF_SRF.BackColor = Color.DarkSlateBlue;
            btn_exportPDF_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_exportPDF_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_exportPDF_SRF.Location = new Point(545, 23);
            btn_exportPDF_SRF.Name = "btn_exportPDF_SRF";
            btn_exportPDF_SRF.Size = new Size(216, 64);
            btn_exportPDF_SRF.TabIndex = 11;
            btn_exportPDF_SRF.Text = "Export To PDF";
            btn_exportPDF_SRF.UseVisualStyleBackColor = false;
            btn_exportPDF_SRF.Click += btn_exportPDF_SRF_Click;
            // 
            // ShowReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(822, 550);
            Controls.Add(btn_exportPDF_SRF);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_SRF);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_month_SRF);
            Controls.Add(cb_year_SRF);
            Controls.Add(cb_showemp_SRF);
            Controls.Add(btn_showmonth_SRF);
            Controls.Add(btn_showweekreport_SRF);
            Controls.Add(btn_dailyreport_SRF);
            Controls.Add(dgv_showreport_SRF);
            Name = "ShowReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowReports";
            Load += ShowReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_showreport_SRF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgv_showreport_SRF;
        private Button btn_dailyreport_SRF;
        private Button btn_showweekreport_SRF;
        private Button btn_showmonth_SRF;
        private ComboBox cb_showemp_SRF;
        private ComboBox cb_year_SRF;
        private ComboBox cb_month_SRF;
        private Label label1;
        private Label label2;
        private Button btn_back_SRF;
        private Button btn_logout_SRF;
        private Button btn_exportPDF_SRF;


        #endregion

        // private NotifyIcon notifyIcon1;
    }
}