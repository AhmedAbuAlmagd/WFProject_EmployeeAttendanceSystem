namespace EF_Project.Forms
{
    partial class ShowRequests
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
            dgv_showrequests_SRF = new DataGridView();
            btn_accept_SRF = new Button();
            btn_reject_SRF = new Button();
            btn_showbyuser_SRF = new Button();
            cb_showbyemp_SRF = new ComboBox();
            btn_back_SRF = new Button();
            btn_logout_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_showrequests_SRF).BeginInit();
            SuspendLayout();
            // 
            // dgv_showrequests_SRF
            // 
            dgv_showrequests_SRF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_showrequests_SRF.Location = new Point(12, 178);
            dgv_showrequests_SRF.Name = "dgv_showrequests_SRF";
            dgv_showrequests_SRF.RowHeadersWidth = 51;
            dgv_showrequests_SRF.Size = new Size(563, 292);
            dgv_showrequests_SRF.TabIndex = 0;
            dgv_showrequests_SRF.RowHeaderMouseDoubleClick += dgv_showrequests_SRF_RowHeaderMouseDoubleClick;
            // 
            // btn_accept_SRF
            // 
            btn_accept_SRF.Location = new Point(644, 262);
            btn_accept_SRF.Name = "btn_accept_SRF";
            btn_accept_SRF.Size = new Size(94, 48);
            btn_accept_SRF.TabIndex = 1;
            btn_accept_SRF.Text = "Accept";
            btn_accept_SRF.UseVisualStyleBackColor = true;
            btn_accept_SRF.Click += btn_accept_SRF_Click;
            // 
            // btn_reject_SRF
            // 
            btn_reject_SRF.Location = new Point(644, 361);
            btn_reject_SRF.Name = "btn_reject_SRF";
            btn_reject_SRF.Size = new Size(94, 46);
            btn_reject_SRF.TabIndex = 2;
            btn_reject_SRF.Text = "Reject";
            btn_reject_SRF.UseVisualStyleBackColor = true;
            btn_reject_SRF.Click += btn_reject_SRF_Click;
            // 
            // btn_showbyuser_SRF
            // 
            btn_showbyuser_SRF.Location = new Point(23, 71);
            btn_showbyuser_SRF.Name = "btn_showbyuser_SRF";
            btn_showbyuser_SRF.Size = new Size(140, 58);
            btn_showbyuser_SRF.TabIndex = 3;
            btn_showbyuser_SRF.Text = "Show By User";
            btn_showbyuser_SRF.UseVisualStyleBackColor = true;
            //btn_showbyuser_SRF.Click += btn_showbyuser_SRF_Click;
            // 
            // cb_showbyemp_SRF
            // 
            cb_showbyemp_SRF.FormattingEnabled = true;
            cb_showbyemp_SRF.Location = new Point(209, 87);
            cb_showbyemp_SRF.Name = "cb_showbyemp_SRF";
            cb_showbyemp_SRF.Size = new Size(173, 28);
            cb_showbyemp_SRF.TabIndex = 4;
            cb_showbyemp_SRF.SelectedIndexChanged += cb_showbyemp_SRF_SelectedIndexChanged;
            // 
            // btn_back_SRF
            // 
            btn_back_SRF.Location = new Point(23, 517);
            btn_back_SRF.Name = "btn_back_SRF";
            btn_back_SRF.Size = new Size(94, 50);
            btn_back_SRF.TabIndex = 5;
            btn_back_SRF.Text = "Back";
            btn_back_SRF.UseVisualStyleBackColor = true;
            btn_back_SRF.Click += btn_back_SRF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.Location = new Point(644, 517);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(94, 50);
            btn_logout_SRF.TabIndex = 6;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = true;
            // 
            // ShowRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 588);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_SRF);
            Controls.Add(cb_showbyemp_SRF);
            Controls.Add(btn_showbyuser_SRF);
            Controls.Add(btn_reject_SRF);
            Controls.Add(btn_accept_SRF);
            Controls.Add(dgv_showrequests_SRF);
            Name = "ShowRequests";
            Text = "ShowRequests";
            Load += ShowRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_showrequests_SRF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_showrequests_SRF;
        private Button btn_accept_SRF;
        private Button btn_reject_SRF;
        private Button btn_showbyuser_SRF;
        private ComboBox cb_showbyemp_SRF;
        private Button btn_back_SRF;
        private Button btn_logout_SRF;
    }
}