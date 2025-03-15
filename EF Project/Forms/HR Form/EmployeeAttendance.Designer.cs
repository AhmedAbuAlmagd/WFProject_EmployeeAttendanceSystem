namespace EF_Project.Forms
{
    partial class EmployeeAttendance
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
            cb_showbyuser_EAF = new ComboBox();
            btn_showbydate_EAF = new Button();
            btn_showbyuser_EAF = new Button();
            dgv_empattend_EAF = new DataGridView();
            btn_back_EAF = new Button();
            date_EAF = new DateTimePicker();
            pbQrCode = new PictureBox();
            btn_showbyuseranddate_EAF = new Button();
            btn_logout_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_empattend_EAF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQrCode).BeginInit();
            SuspendLayout();
            // 
            // cb_showbyuser_EAF
            // 
            cb_showbyuser_EAF.FormattingEnabled = true;
            cb_showbyuser_EAF.Location = new Point(303, 40);
            cb_showbyuser_EAF.Name = "cb_showbyuser_EAF";
            cb_showbyuser_EAF.Size = new Size(151, 28);
            cb_showbyuser_EAF.TabIndex = 8;
            // 
            // btn_showbydate_EAF
            // 
            btn_showbydate_EAF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showbydate_EAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showbydate_EAF.ForeColor = SystemColors.ControlLightLight;
            btn_showbydate_EAF.Location = new Point(48, 95);
            btn_showbydate_EAF.Name = "btn_showbydate_EAF";
            btn_showbydate_EAF.Size = new Size(199, 49);
            btn_showbydate_EAF.TabIndex = 7;
            btn_showbydate_EAF.Text = "Show By Date";
            btn_showbydate_EAF.UseVisualStyleBackColor = false;
            btn_showbydate_EAF.Click += btn_showbydate_EAF_Click;
            // 
            // btn_showbyuser_EAF
            // 
            btn_showbyuser_EAF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showbyuser_EAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showbyuser_EAF.ForeColor = SystemColors.ControlLightLight;
            btn_showbyuser_EAF.Location = new Point(48, 28);
            btn_showbyuser_EAF.Name = "btn_showbyuser_EAF";
            btn_showbyuser_EAF.Size = new Size(214, 47);
            btn_showbyuser_EAF.TabIndex = 6;
            btn_showbyuser_EAF.Text = "Show By Employee";
            btn_showbyuser_EAF.UseVisualStyleBackColor = false;
            btn_showbyuser_EAF.Click += btn_showbyuser_EAF_Click;
            // 
            // dgv_empattend_EAF
            // 
            dgv_empattend_EAF.BackgroundColor = Color.Ivory;
            dgv_empattend_EAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empattend_EAF.Location = new Point(12, 170);
            dgv_empattend_EAF.Name = "dgv_empattend_EAF";
            dgv_empattend_EAF.RowHeadersWidth = 51;
            dgv_empattend_EAF.Size = new Size(500, 368);
            dgv_empattend_EAF.TabIndex = 5;
            dgv_empattend_EAF.RowHeaderMouseDoubleClick += dgv_empattend_EAF_RowHeaderMouseDoubleClick;
            // 
            // btn_back_EAF
            // 
            btn_back_EAF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_EAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_EAF.ForeColor = SystemColors.ButtonHighlight;
            btn_back_EAF.Location = new Point(555, 494);
            btn_back_EAF.Name = "btn_back_EAF";
            btn_back_EAF.Size = new Size(116, 44);
            btn_back_EAF.TabIndex = 10;
            btn_back_EAF.Text = "Back";
            btn_back_EAF.UseVisualStyleBackColor = false;
            btn_back_EAF.Click += btn_back_EAF_Click;
            // 
            // date_EAF
            // 
            date_EAF.Format = DateTimePickerFormat.Short;
            date_EAF.Location = new Point(686, 152);
            date_EAF.Name = "date_EAF";
            date_EAF.Size = new Size(151, 27);
            date_EAF.TabIndex = 11;
            // 
            // pbQrCode
            // 
            pbQrCode.Location = new Point(587, 251);
            pbQrCode.Name = "pbQrCode";
            pbQrCode.Size = new Size(200, 200);
            pbQrCode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQrCode.TabIndex = 13;
            pbQrCode.TabStop = false;
            // 
            // btn_showbyuseranddate_EAF
            // 
            btn_showbyuseranddate_EAF.BackColor = Color.DarkSlateBlue;
            btn_showbyuseranddate_EAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_showbyuseranddate_EAF.ForeColor = SystemColors.ButtonHighlight;
            btn_showbyuseranddate_EAF.Location = new Point(540, 183);
            btn_showbyuseranddate_EAF.Name = "btn_showbyuseranddate_EAF";
            btn_showbyuseranddate_EAF.Size = new Size(295, 52);
            btn_showbyuseranddate_EAF.TabIndex = 14;
            btn_showbyuseranddate_EAF.Text = "Show by Employee And Date";
            btn_showbyuseranddate_EAF.UseVisualStyleBackColor = false;
            btn_showbyuseranddate_EAF.Click += btn_showbyuseranddate_EAF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.Control;
            btn_logout_SRF.Location = new Point(710, 494);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(116, 44);
            btn_logout_SRF.TabIndex = 15;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            btn_logout_SRF.Click += btn_logout_SRF_Click;
            // 
            // EmployeeAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(865, 550);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_showbyuseranddate_EAF);
            Controls.Add(pbQrCode);
            Controls.Add(date_EAF);
            Controls.Add(btn_back_EAF);
            Controls.Add(cb_showbyuser_EAF);
            Controls.Add(btn_showbydate_EAF);
            Controls.Add(btn_showbyuser_EAF);
            Controls.Add(dgv_empattend_EAF);
            Name = "EmployeeAttendance";
            Text = "EmployeeAttendance";
            ((System.ComponentModel.ISupportInitialize)dgv_empattend_EAF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQrCode).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cb_showbyuser_EAF;
        private Button btn_showbydate_EAF;
        private Button btn_showbyuser_EAF;
        private DataGridView dgv_empattend_EAF;
        private Button btn_back_EAF;
        private DateTimePicker date_EAF;
        private PictureBox pbQrCode;
        private Button btn_showbyuseranddate_EAF;
        private Button btn_logout_SRF;
    }
}