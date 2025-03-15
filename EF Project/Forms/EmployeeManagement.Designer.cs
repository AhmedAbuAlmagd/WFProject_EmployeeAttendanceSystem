namespace EF_Project.Forms
{
    partial class EmployeeManagement
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
            dgv_emp_EMF = new DataGridView();
            txt_name_EMF = new TextBox();
            txt_position_EMF = new TextBox();
            txt_email_EMF = new TextBox();
            txt_phone_EMF = new TextBox();
            cb_schedule_EMF = new ComboBox();
            cb_dept_EMF = new ComboBox();
            btn_add_EMF = new Button();
            btn_edit_EMF = new Button();
            btn_delete_EMF = new Button();
            lbl_empname_EM = new Label();
            lbl_position_EMF = new Label();
            lbl_email_EMF = new Label();
            lbl_phone_EMF = new Label();
            lbl_schedule_EMF = new Label();
            lbl_dept_EMF = new Label();
            btn_back_EMF = new Button();
            btn_logout_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_emp_EMF).BeginInit();
            SuspendLayout();
            // 
            // dgv_emp_EMF
            // 
            dgv_emp_EMF.BackgroundColor = Color.FromArgb(225, 223, 186);
            dgv_emp_EMF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_emp_EMF.Location = new Point(12, 216);
            dgv_emp_EMF.Name = "dgv_emp_EMF";
            dgv_emp_EMF.RowHeadersWidth = 51;
            dgv_emp_EMF.Size = new Size(575, 322);
            dgv_emp_EMF.TabIndex = 0;
            dgv_emp_EMF.RowHeaderMouseDoubleClick += dgv_emp_EMF_RowHeaderMouseDoubleClick;
            // 
            // txt_name_EMF
            // 
            txt_name_EMF.Location = new Point(134, 31);
            txt_name_EMF.Name = "txt_name_EMF";
            txt_name_EMF.Size = new Size(125, 27);
            txt_name_EMF.TabIndex = 1;
            // 
            // txt_position_EMF
            // 
            txt_position_EMF.Location = new Point(134, 91);
            txt_position_EMF.Name = "txt_position_EMF";
            txt_position_EMF.Size = new Size(125, 27);
            txt_position_EMF.TabIndex = 2;
            // 
            // txt_email_EMF
            // 
            txt_email_EMF.Location = new Point(134, 156);
            txt_email_EMF.Name = "txt_email_EMF";
            txt_email_EMF.Size = new Size(125, 27);
            txt_email_EMF.TabIndex = 3;
            // 
            // txt_phone_EMF
            // 
            txt_phone_EMF.Location = new Point(541, 155);
            txt_phone_EMF.Name = "txt_phone_EMF";
            txt_phone_EMF.Size = new Size(125, 27);
            txt_phone_EMF.TabIndex = 4;
            // 
            // cb_schedule_EMF
            // 
            cb_schedule_EMF.FormattingEnabled = true;
            cb_schedule_EMF.Location = new Point(541, 31);
            cb_schedule_EMF.Name = "cb_schedule_EMF";
            cb_schedule_EMF.Size = new Size(151, 28);
            cb_schedule_EMF.TabIndex = 5;
            // 
            // cb_dept_EMF
            // 
            cb_dept_EMF.FormattingEnabled = true;
            cb_dept_EMF.Location = new Point(541, 93);
            cb_dept_EMF.Name = "cb_dept_EMF";
            cb_dept_EMF.Size = new Size(151, 28);
            cb_dept_EMF.TabIndex = 6;
            // 
            // btn_add_EMF
            // 
            btn_add_EMF.BackColor = Color.FromArgb(53, 122, 189);
            btn_add_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_add_EMF.ForeColor = SystemColors.ButtonHighlight;
            btn_add_EMF.Location = new Point(656, 239);
            btn_add_EMF.Name = "btn_add_EMF";
            btn_add_EMF.Size = new Size(142, 54);
            btn_add_EMF.TabIndex = 8;
            btn_add_EMF.Text = "Add";
            btn_add_EMF.UseVisualStyleBackColor = false;
            btn_add_EMF.Click += btn_add_EMF_Click;
            // 
            // btn_edit_EMF
            // 
            btn_edit_EMF.BackColor = Color.FromArgb(245, 166, 35);
            btn_edit_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_edit_EMF.ForeColor = SystemColors.ButtonHighlight;
            btn_edit_EMF.Location = new Point(656, 323);
            btn_edit_EMF.Name = "btn_edit_EMF";
            btn_edit_EMF.Size = new Size(142, 54);
            btn_edit_EMF.TabIndex = 9;
            btn_edit_EMF.Text = "Edit";
            btn_edit_EMF.UseVisualStyleBackColor = false;
            btn_edit_EMF.Click += btn_edit_EMF_Click;
            // 
            // btn_delete_EMF
            // 
            btn_delete_EMF.BackColor = Color.FromArgb(208, 40, 80);
            btn_delete_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_delete_EMF.ForeColor = SystemColors.ButtonHighlight;
            btn_delete_EMF.Location = new Point(656, 406);
            btn_delete_EMF.Name = "btn_delete_EMF";
            btn_delete_EMF.Size = new Size(142, 54);
            btn_delete_EMF.TabIndex = 10;
            btn_delete_EMF.Text = "Delete";
            btn_delete_EMF.UseVisualStyleBackColor = false;
            btn_delete_EMF.Click += btn_delete_EMF_Click;
            // 
            // lbl_empname_EM
            // 
            lbl_empname_EM.AutoSize = true;
            lbl_empname_EM.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_empname_EM.Location = new Point(46, 34);
            lbl_empname_EM.Name = "lbl_empname_EM";
            lbl_empname_EM.Size = new Size(68, 28);
            lbl_empname_EM.TabIndex = 11;
            lbl_empname_EM.Text = "Name";
            // 
            // lbl_position_EMF
            // 
            lbl_position_EMF.AutoSize = true;
            lbl_position_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_position_EMF.Location = new Point(34, 94);
            lbl_position_EMF.Name = "lbl_position_EMF";
            lbl_position_EMF.Size = new Size(90, 28);
            lbl_position_EMF.TabIndex = 12;
            lbl_position_EMF.Text = "Position";
            // 
            // lbl_email_EMF
            // 
            lbl_email_EMF.AutoSize = true;
            lbl_email_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_email_EMF.Location = new Point(49, 159);
            lbl_email_EMF.Name = "lbl_email_EMF";
            lbl_email_EMF.Size = new Size(65, 28);
            lbl_email_EMF.TabIndex = 13;
            lbl_email_EMF.Text = "Email";
            // 
            // lbl_phone_EMF
            // 
            lbl_phone_EMF.AutoSize = true;
            lbl_phone_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_phone_EMF.Location = new Point(441, 151);
            lbl_phone_EMF.Name = "lbl_phone_EMF";
            lbl_phone_EMF.Size = new Size(71, 28);
            lbl_phone_EMF.TabIndex = 14;
            lbl_phone_EMF.Text = "Phone";
            // 
            // lbl_schedule_EMF
            // 
            lbl_schedule_EMF.AutoSize = true;
            lbl_schedule_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_schedule_EMF.Location = new Point(361, 30);
            lbl_schedule_EMF.Name = "lbl_schedule_EMF";
            lbl_schedule_EMF.Size = new Size(151, 28);
            lbl_schedule_EMF.TabIndex = 15;
            lbl_schedule_EMF.Text = "Work Schedule";
            // 
            // lbl_dept_EMF
            // 
            lbl_dept_EMF.AutoSize = true;
            lbl_dept_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_dept_EMF.Location = new Point(393, 94);
            lbl_dept_EMF.Name = "lbl_dept_EMF";
            lbl_dept_EMF.Size = new Size(119, 28);
            lbl_dept_EMF.TabIndex = 16;
            lbl_dept_EMF.Text = "Dept Name";
            // 
            // btn_back_EMF
            // 
            btn_back_EMF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_EMF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_EMF.ForeColor = SystemColors.ButtonHighlight;
            btn_back_EMF.Location = new Point(605, 494);
            btn_back_EMF.Name = "btn_back_EMF";
            btn_back_EMF.Size = new Size(116, 44);
            btn_back_EMF.TabIndex = 17;
            btn_back_EMF.Text = "Back";
            btn_back_EMF.UseVisualStyleBackColor = false;
            btn_back_EMF.Click += btn_back_EMF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.Control;
            btn_logout_SRF.Location = new Point(737, 494);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(116, 44);
            btn_logout_SRF.TabIndex = 43;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            btn_logout_SRF.Click += btn_logout_SRF_Click;
            // 
            // EmployeeManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(865, 550);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_EMF);
            Controls.Add(lbl_dept_EMF);
            Controls.Add(lbl_schedule_EMF);
            Controls.Add(lbl_phone_EMF);
            Controls.Add(lbl_email_EMF);
            Controls.Add(lbl_position_EMF);
            Controls.Add(lbl_empname_EM);
            Controls.Add(btn_delete_EMF);
            Controls.Add(btn_edit_EMF);
            Controls.Add(btn_add_EMF);
            Controls.Add(cb_dept_EMF);
            Controls.Add(cb_schedule_EMF);
            Controls.Add(txt_phone_EMF);
            Controls.Add(txt_email_EMF);
            Controls.Add(txt_position_EMF);
            Controls.Add(txt_name_EMF);
            Controls.Add(dgv_emp_EMF);
            Name = "EmployeeManagment";
            Text = "EmployeeManagment";
            Load += EmployeeManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_emp_EMF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_emp_EMF;
        private TextBox txt_name_EMF;
        private TextBox txt_position_EMF;
        private TextBox txt_email_EMF;
        private TextBox txt_phone_EMF;
        private ComboBox cb_schedule_EMF;
        private ComboBox cb_dept_EMF;
        private Button btn_add_EMF;
        private Button btn_edit_EMF;
        private Button btn_delete_EMF;
        private Label lbl_empname_EM;
        private Label lbl_position_EMF;
        private Label lbl_email_EMF;
        private Label lbl_phone_EMF;
        private Label lbl_schedule_EMF;
        private Label lbl_dept_EMF;
        private Button btn_back_EMF;
        private Button btn_logout_SRF;
    }
}