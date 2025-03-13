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
            ((System.ComponentModel.ISupportInitialize)dgv_empattend_EAF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQrCode).BeginInit();
            SuspendLayout();
            // 
            // cb_showbyuser_EAF
            // 
            cb_showbyuser_EAF.FormattingEnabled = true;
            cb_showbyuser_EAF.Location = new Point(686, 47);
            cb_showbyuser_EAF.Name = "cb_showbyuser_EAF";
            cb_showbyuser_EAF.Size = new Size(151, 28);
            cb_showbyuser_EAF.TabIndex = 8;
            // 
            // btn_showbydate_EAF
            // 
            btn_showbydate_EAF.Location = new Point(508, 147);
            btn_showbydate_EAF.Name = "btn_showbydate_EAF";
            btn_showbydate_EAF.Size = new Size(153, 40);
            btn_showbydate_EAF.TabIndex = 7;
            btn_showbydate_EAF.Text = "Show By Date";
            btn_showbydate_EAF.UseVisualStyleBackColor = true;
            btn_showbydate_EAF.Click += btn_showbydate_EAF_Click;
            // 
            // btn_showbyuser_EAF
            // 
            btn_showbyuser_EAF.Location = new Point(508, 40);
            btn_showbyuser_EAF.Name = "btn_showbyuser_EAF";
            btn_showbyuser_EAF.Size = new Size(153, 40);
            btn_showbyuser_EAF.TabIndex = 6;
            btn_showbyuser_EAF.Text = "Show By Employee";
            btn_showbyuser_EAF.UseVisualStyleBackColor = true;
            btn_showbyuser_EAF.Click += btn_showbyuser_EAF_Click;
            // 
            // dgv_empattend_EAF
            // 
            dgv_empattend_EAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empattend_EAF.Location = new Point(6, 20);
            dgv_empattend_EAF.Name = "dgv_empattend_EAF";
            dgv_empattend_EAF.RowHeadersWidth = 51;
            dgv_empattend_EAF.Size = new Size(487, 411);
            dgv_empattend_EAF.TabIndex = 5;
            dgv_empattend_EAF.RowHeaderMouseDoubleClick += dgv_empattend_EAF_RowHeaderMouseDoubleClick;
            // 
            // btn_back_EAF
            // 
            btn_back_EAF.Location = new Point(46, 467);
            btn_back_EAF.Name = "btn_back_EAF";
            btn_back_EAF.Size = new Size(94, 46);
            btn_back_EAF.TabIndex = 10;
            btn_back_EAF.Text = "Back";
            btn_back_EAF.UseVisualStyleBackColor = true;
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
            pbQrCode.Location = new Point(587, 289);
            pbQrCode.Name = "pbQrCode";
            pbQrCode.Size = new Size(200, 200);
            pbQrCode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQrCode.TabIndex = 13;
            pbQrCode.TabStop = false;
            // 
            // btn_showbyuseranddate_EAF
            // 
            btn_showbyuseranddate_EAF.Location = new Point(572, 218);
            btn_showbyuseranddate_EAF.Name = "btn_showbyuseranddate_EAF";
            btn_showbyuseranddate_EAF.Size = new Size(229, 40);
            btn_showbyuseranddate_EAF.TabIndex = 14;
            btn_showbyuseranddate_EAF.Text = "Show by Employee And Date";
            btn_showbyuseranddate_EAF.UseVisualStyleBackColor = true;
            btn_showbyuseranddate_EAF.Click += btn_showbyuseranddate_EAF_Click;
            // 
            // EmployeeAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 534);
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
    }
}