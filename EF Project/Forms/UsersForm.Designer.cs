namespace EF_Project
{
    partial class UsersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dgv_users_UF = new DataGridView();
            txt_userName_UF = new TextBox();
            txt_password_UF = new TextBox();
            combo_role_UF = new ComboBox();
            btn_addUser_UF = new Button();
            btn_updateUser_UF = new Button();
            btn_deleteUser_UF = new Button();
            check_viewPass_UF = new CheckBox();
            label3 = new Label();
            combo_employee_UF = new ComboBox();
            label4 = new Label();
            btn_back_UF = new Button();
            btn_logout_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_users_UF).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(36, 94);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // dgv_users_UF
            // 
            dgv_users_UF.BackgroundColor = Color.FromArgb(225, 223, 186);
            dgv_users_UF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users_UF.Location = new Point(12, 163);
            dgv_users_UF.Name = "dgv_users_UF";
            dgv_users_UF.RowHeadersWidth = 51;
            dgv_users_UF.Size = new Size(575, 376);
            dgv_users_UF.TabIndex = 2;
            dgv_users_UF.RowHeaderMouseDoubleClick += dgv_users_UF_RowHeaderMouseDoubleClick;
            // 
            // txt_userName_UF
            // 
            txt_userName_UF.Location = new Point(160, 38);
            txt_userName_UF.Name = "txt_userName_UF";
            txt_userName_UF.Size = new Size(125, 27);
            txt_userName_UF.TabIndex = 3;
            // 
            // txt_password_UF
            // 
            txt_password_UF.Location = new Point(160, 94);
            txt_password_UF.Name = "txt_password_UF";
            txt_password_UF.Size = new Size(125, 27);
            txt_password_UF.TabIndex = 4;
            txt_password_UF.UseSystemPasswordChar = true;
            // 
            // combo_role_UF
            // 
            combo_role_UF.FormattingEnabled = true;
            combo_role_UF.Location = new Point(463, 37);
            combo_role_UF.Name = "combo_role_UF";
            combo_role_UF.Size = new Size(151, 28);
            combo_role_UF.TabIndex = 5;
            // 
            // btn_addUser_UF
            // 
            btn_addUser_UF.BackColor = Color.FromArgb(53, 122, 189);
            btn_addUser_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_addUser_UF.ForeColor = Color.White;
            btn_addUser_UF.Location = new Point(658, 177);
            btn_addUser_UF.Name = "btn_addUser_UF";
            btn_addUser_UF.Size = new Size(142, 54);
            btn_addUser_UF.TabIndex = 6;
            btn_addUser_UF.Text = "Add ";
            btn_addUser_UF.UseVisualStyleBackColor = false;
            btn_addUser_UF.Click += btn_addUser_UF_Click;
            // 
            // btn_updateUser_UF
            // 
            btn_updateUser_UF.BackColor = Color.FromArgb(245, 166, 35);
            btn_updateUser_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_updateUser_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_updateUser_UF.Location = new Point(658, 274);
            btn_updateUser_UF.Name = "btn_updateUser_UF";
            btn_updateUser_UF.Size = new Size(142, 54);
            btn_updateUser_UF.TabIndex = 7;
            btn_updateUser_UF.Text = "Update";
            btn_updateUser_UF.UseVisualStyleBackColor = false;
            btn_updateUser_UF.Click += btn_updateUser_UF_Click;
            // 
            // btn_deleteUser_UF
            // 
            btn_deleteUser_UF.BackColor = Color.FromArgb(208, 40, 80);
            btn_deleteUser_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_deleteUser_UF.ForeColor = Color.White;
            btn_deleteUser_UF.Location = new Point(658, 374);
            btn_deleteUser_UF.Name = "btn_deleteUser_UF";
            btn_deleteUser_UF.Size = new Size(142, 54);
            btn_deleteUser_UF.TabIndex = 8;
            btn_deleteUser_UF.Text = "Delete";
            btn_deleteUser_UF.UseVisualStyleBackColor = false;
            btn_deleteUser_UF.Click += btn_deleteUser_UF_Click;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.BackColor = Color.Transparent;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.Location = new Point(160, 127);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 38;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = false;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(383, 37);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 39;
            label3.Text = "Role";
            // 
            // combo_employee_UF
            // 
            combo_employee_UF.FormattingEnabled = true;
            combo_employee_UF.Location = new Point(463, 90);
            combo_employee_UF.Name = "combo_employee_UF";
            combo_employee_UF.Size = new Size(151, 28);
            combo_employee_UF.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(334, 86);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 39;
            label4.Text = "Employee";
            // 
            // btn_back_UF
            // 
            btn_back_UF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_UF.ForeColor = Color.White;
            btn_back_UF.Location = new Point(605, 494);
            btn_back_UF.Name = "btn_back_UF";
            btn_back_UF.Size = new Size(116, 44);
            btn_back_UF.TabIndex = 41;
            btn_back_UF.Text = "Back";
            btn_back_UF.UseVisualStyleBackColor = false;
            btn_back_UF.Click += btn_back_UF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.Control;
            btn_logout_SRF.Location = new Point(737, 495);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(116, 44);
            btn_logout_SRF.TabIndex = 42;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            btn_logout_SRF.Click += btn_logout_SRF_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(865, 550);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_UF);
            Controls.Add(combo_employee_UF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(check_viewPass_UF);
            Controls.Add(btn_deleteUser_UF);
            Controls.Add(btn_updateUser_UF);
            Controls.Add(btn_addUser_UF);
            Controls.Add(combo_role_UF);
            Controls.Add(txt_password_UF);
            Controls.Add(txt_userName_UF);
            Controls.Add(dgv_users_UF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsersForm";
            Text = "Users Form";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users_UF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgv_users_UF;
        private TextBox txt_userName_UF;
        private TextBox txt_password_UF;
        private ComboBox combo_role_UF;
        private Button btn_addUser_UF;
        private Button btn_updateUser_UF;
        private Button btn_deleteUser_UF;
        private CheckBox check_viewPass_UF;
        private Label label3;
        private ComboBox combo_employee_UF;
        private Label label4;
        private Button btn_back_UF;
        private Button btn_logout_SRF;
    }
}
