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
            btn_showPendingRequests_SRF = new Button();
            cb_showbyemp_SRF = new ComboBox();
            btn_back_SRF = new Button();
            btn_logout_SRF = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_showAllRequests_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_showrequests_SRF).BeginInit();
            SuspendLayout();
            // 
            // dgv_showrequests_SRF
            // 
            dgv_showrequests_SRF.BackgroundColor = Color.FromArgb(225, 223, 186);
            dgv_showrequests_SRF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_showrequests_SRF.Location = new Point(12, 205);
            dgv_showrequests_SRF.Name = "dgv_showrequests_SRF";
            dgv_showrequests_SRF.RowHeadersWidth = 51;
            dgv_showrequests_SRF.Size = new Size(554, 333);
            dgv_showrequests_SRF.TabIndex = 0;
            dgv_showrequests_SRF.RowHeaderMouseDoubleClick += dgv_showrequests_SRF_RowHeaderMouseDoubleClick;
            // 
            // btn_accept_SRF
            // 
            btn_accept_SRF.BackColor = Color.ForestGreen;
            btn_accept_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_accept_SRF.ForeColor = Color.Snow;
            btn_accept_SRF.Location = new Point(628, 261);
            btn_accept_SRF.Name = "btn_accept_SRF";
            btn_accept_SRF.Size = new Size(142, 54);
            btn_accept_SRF.TabIndex = 1;
            btn_accept_SRF.Text = "Accept";
            btn_accept_SRF.UseVisualStyleBackColor = false;
            btn_accept_SRF.Click += btn_accept_SRF_Click;
            // 
            // btn_reject_SRF
            // 
            btn_reject_SRF.BackColor = Color.FromArgb(208, 2, 27);
            btn_reject_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_reject_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_reject_SRF.Location = new Point(628, 373);
            btn_reject_SRF.Name = "btn_reject_SRF";
            btn_reject_SRF.Size = new Size(142, 54);
            btn_reject_SRF.TabIndex = 2;
            btn_reject_SRF.Text = "Reject";
            btn_reject_SRF.UseVisualStyleBackColor = false;
            btn_reject_SRF.Click += btn_reject_SRF_Click;
            // 
            // btn_showPendingRequests_SRF
            // 
            btn_showPendingRequests_SRF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showPendingRequests_SRF.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btn_showPendingRequests_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_showPendingRequests_SRF.Location = new Point(51, 40);
            btn_showPendingRequests_SRF.Name = "btn_showPendingRequests_SRF";
            btn_showPendingRequests_SRF.Size = new Size(235, 58);
            btn_showPendingRequests_SRF.TabIndex = 3;
            btn_showPendingRequests_SRF.Text = "Show Pending Requests";
            btn_showPendingRequests_SRF.UseVisualStyleBackColor = false;
            btn_showPendingRequests_SRF.Click += btn_showPendingRequests_SRF_Click;
            // 
            // cb_showbyemp_SRF
            // 
            cb_showbyemp_SRF.FormattingEnabled = true;
            cb_showbyemp_SRF.Location = new Point(291, 135);
            cb_showbyemp_SRF.Name = "cb_showbyemp_SRF";
            cb_showbyemp_SRF.Size = new Size(173, 28);
            cb_showbyemp_SRF.TabIndex = 4;
            cb_showbyemp_SRF.SelectedIndexChanged += cb_showbyemp_SRF_SelectedIndexChanged;
            // 
            // btn_back_SRF
            // 
            btn_back_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_back_SRF.Location = new Point(694, 494);
            btn_back_SRF.Name = "btn_back_SRF";
            btn_back_SRF.Size = new Size(116, 44);
            btn_back_SRF.TabIndex = 5;
            btn_back_SRF.Text = "Back";
            btn_back_SRF.UseVisualStyleBackColor = false;
            btn_back_SRF.Click += btn_back_SRF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.Control;
            btn_logout_SRF.Location = new Point(572, 494);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(116, 44);
            btn_logout_SRF.TabIndex = 6;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            btn_logout_SRF.Click += btn_logout_SRF_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(51, 131);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 8;
            label2.Text = "Show By Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // btn_showAllRequests_SRF
            // 
            btn_showAllRequests_SRF.BackColor = Color.FromArgb(53, 122, 189);
            btn_showAllRequests_SRF.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btn_showAllRequests_SRF.ForeColor = SystemColors.ButtonHighlight;
            btn_showAllRequests_SRF.Location = new Point(338, 40);
            btn_showAllRequests_SRF.Name = "btn_showAllRequests_SRF";
            btn_showAllRequests_SRF.Size = new Size(196, 58);
            btn_showAllRequests_SRF.TabIndex = 3;
            btn_showAllRequests_SRF.Text = "Show All Requests";
            btn_showAllRequests_SRF.UseVisualStyleBackColor = false;
            btn_showAllRequests_SRF.Click += btn_showAllRequests_SRF_Click;
            // 
            // ShowRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(822, 550);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_SRF);
            Controls.Add(cb_showbyemp_SRF);
            Controls.Add(btn_showAllRequests_SRF);
            Controls.Add(btn_showPendingRequests_SRF);
            Controls.Add(btn_reject_SRF);
            Controls.Add(btn_accept_SRF);
            Controls.Add(dgv_showrequests_SRF);
            Name = "ShowRequests";
            Text = "ShowRequests";
            Load += ShowRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_showrequests_SRF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_showrequests_SRF;
        private Button btn_accept_SRF;
        private Button btn_reject_SRF;
        private Button btn_showAllRequests_SRF;
        private ComboBox cb_showbyemp_SRF;
        private Button btn_back_SRF;
        private Button btn_logout_SRF;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btn_showPendingRequests_SRF;
    }
}