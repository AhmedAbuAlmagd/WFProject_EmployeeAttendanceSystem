namespace EF_Project.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lbl_userName = new Label();
            lbl_password = new Label();
            txt_password_LF = new TextBox();
            btn_login_LF = new Button();
            txt_userName_LF = new TextBox();
            check_viewPass_UF = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.BackColor = Color.Transparent;
            lbl_userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_userName.Location = new Point(487, 156);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(115, 28);
            lbl_userName.TabIndex = 38;
            lbl_userName.Text = "User Name";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.Transparent;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_password.Location = new Point(499, 225);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(103, 28);
            lbl_password.TabIndex = 39;
            lbl_password.Text = "Password";
            // 
            // txt_password_LF
            // 
            txt_password_LF.Location = new Point(632, 226);
            txt_password_LF.Name = "txt_password_LF";
            txt_password_LF.Size = new Size(175, 27);
            txt_password_LF.TabIndex = 40;
            txt_password_LF.UseSystemPasswordChar = true;
            // 
            // btn_login_LF
            // 
            btn_login_LF.BackColor = Color.SaddleBrown;
            btn_login_LF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_login_LF.ForeColor = Color.Transparent;
            btn_login_LF.Location = new Point(570, 339);
            btn_login_LF.Name = "btn_login_LF";
            btn_login_LF.Size = new Size(155, 54);
            btn_login_LF.TabIndex = 41;
            btn_login_LF.Text = "Login";
            btn_login_LF.UseVisualStyleBackColor = false;
            btn_login_LF.Click += btn_login_LF_Click;
            // 
            // txt_userName_LF
            // 
            txt_userName_LF.Location = new Point(632, 156);
            txt_userName_LF.Name = "txt_userName_LF";
            txt_userName_LF.Size = new Size(175, 27);
            txt_userName_LF.TabIndex = 42;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.BackColor = Color.Transparent;
            check_viewPass_UF.Font = new Font("Segoe UI", 7F, FontStyle.Bold | FontStyle.Italic);
            check_viewPass_UF.Location = new Point(632, 259);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(116, 19);
            check_viewPass_UF.TabIndex = 43;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 505);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(832, 503);
            Controls.Add(pictureBox1);
            Controls.Add(check_viewPass_UF);
            Controls.Add(txt_userName_LF);
            Controls.Add(txt_password_LF);
            Controls.Add(btn_login_LF);
            Controls.Add(lbl_userName);
            Controls.Add(lbl_password);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lbl_userName;
        private Label lbl_password;
        private TextBox txt_password_LF;
        private Button btn_login_LF;
        private TextBox txt_userName_LF;
        private CheckBox check_viewPass_UF;
        private PictureBox pictureBox1;
    }
}