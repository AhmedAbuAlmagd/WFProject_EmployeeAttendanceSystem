namespace EF_Project.Forms
{
    partial class LeaveRequestForm
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
            label1 = new Label();
            label2 = new Label();
            requestStartTime_LRF = new DateTimePicker();
            requestEndTime_LRF = new DateTimePicker();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_SendRequest_LRF = new Button();
            btn_ShowRequests_LRF = new Button();
            btn_back_LRF = new Button();
            dgv_ShowRequests_LRF = new DataGridView();
            btn_cancelRequest_LRF = new Button();
            combo_leaveReason_LRF = new ComboBox();
            btn_logout_LF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowRequests_LRF).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(52, 104);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(64, 172);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "End Time";
            // 
            // requestStartTime_LRF
            // 
            requestStartTime_LRF.Format = DateTimePickerFormat.Short;
            requestStartTime_LRF.Location = new Point(182, 106);
            requestStartTime_LRF.Name = "requestStartTime_LRF";
            requestStartTime_LRF.Size = new Size(151, 27);
            requestStartTime_LRF.TabIndex = 2;
            // 
            // requestEndTime_LRF
            // 
            requestEndTime_LRF.Format = DateTimePickerFormat.Short;
            requestEndTime_LRF.Location = new Point(182, 173);
            requestEndTime_LRF.Name = "requestEndTime_LRF";
            requestEndTime_LRF.Size = new Size(151, 27);
            requestEndTime_LRF.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(77, 240);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 3;
            label3.Text = "Reason ";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_SendRequest_LRF
            // 
            btn_SendRequest_LRF.BackColor = Color.FromArgb(20, 120, 90);
            btn_SendRequest_LRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_SendRequest_LRF.ForeColor = SystemColors.ButtonHighlight;
            btn_SendRequest_LRF.Location = new Point(123, 328);
            btn_SendRequest_LRF.Name = "btn_SendRequest_LRF";
            btn_SendRequest_LRF.Size = new Size(190, 60);
            btn_SendRequest_LRF.TabIndex = 5;
            btn_SendRequest_LRF.Text = "Send Request";
            btn_SendRequest_LRF.UseVisualStyleBackColor = false;
            btn_SendRequest_LRF.Click += btn_SendRequest_LRF_Click;
            // 
            // btn_ShowRequests_LRF
            // 
            btn_ShowRequests_LRF.BackColor = Color.FromArgb(53, 122, 189);
            btn_ShowRequests_LRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_ShowRequests_LRF.ForeColor = SystemColors.ButtonHighlight;
            btn_ShowRequests_LRF.Location = new Point(525, 328);
            btn_ShowRequests_LRF.Name = "btn_ShowRequests_LRF";
            btn_ShowRequests_LRF.Size = new Size(190, 60);
            btn_ShowRequests_LRF.TabIndex = 5;
            btn_ShowRequests_LRF.Text = "Show Requests";
            btn_ShowRequests_LRF.UseVisualStyleBackColor = false;
            btn_ShowRequests_LRF.Click += btn_ShowRequests_LRF_Click;
            // 
            // btn_back_LRF
            // 
            btn_back_LRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_LRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_LRF.ForeColor = SystemColors.ControlLightLight;
            btn_back_LRF.Location = new Point(689, 428);
            btn_back_LRF.Name = "btn_back_LRF";
            btn_back_LRF.Size = new Size(121, 48);
            btn_back_LRF.TabIndex = 5;
            btn_back_LRF.Text = "Back";
            btn_back_LRF.UseVisualStyleBackColor = false;
            btn_back_LRF.Click += btn_back_LRF_Click;
            // 
            // dgv_ShowRequests_LRF
            // 
            dgv_ShowRequests_LRF.BackgroundColor = Color.Ivory;
            dgv_ShowRequests_LRF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowRequests_LRF.Location = new Point(448, 57);
            dgv_ShowRequests_LRF.Name = "dgv_ShowRequests_LRF";
            dgv_ShowRequests_LRF.RowHeadersWidth = 51;
            dgv_ShowRequests_LRF.Size = new Size(340, 233);
            dgv_ShowRequests_LRF.TabIndex = 6;
            dgv_ShowRequests_LRF.RowHeaderMouseDoubleClick += dgv_ShowRequests_LRF_RowHeaderMouseDoubleClick;
            // 
            // btn_cancelRequest_LRF
            // 
            btn_cancelRequest_LRF.BackColor = Color.FromArgb(208, 40, 80);
            btn_cancelRequest_LRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_cancelRequest_LRF.ForeColor = SystemColors.ButtonHighlight;
            btn_cancelRequest_LRF.Location = new Point(525, 328);
            btn_cancelRequest_LRF.Name = "btn_cancelRequest_LRF";
            btn_cancelRequest_LRF.Size = new Size(190, 60);
            btn_cancelRequest_LRF.TabIndex = 7;
            btn_cancelRequest_LRF.Text = "Cancel Request";
            btn_cancelRequest_LRF.UseVisualStyleBackColor = false;
            btn_cancelRequest_LRF.Click += btn_cancelRequest_LRF_Click;
            // 
            // combo_leaveReason_LRF
            // 
            combo_leaveReason_LRF.FormattingEnabled = true;
            combo_leaveReason_LRF.Location = new Point(182, 240);
            combo_leaveReason_LRF.Name = "combo_leaveReason_LRF";
            combo_leaveReason_LRF.Size = new Size(151, 28);
            combo_leaveReason_LRF.TabIndex = 8;
            // 
            // btn_logout_LF
            // 
            btn_logout_LF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_LF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_LF.ForeColor = SystemColors.ButtonHighlight;
            btn_logout_LF.Location = new Point(12, 432);
            btn_logout_LF.Name = "btn_logout_LF";
            btn_logout_LF.Size = new Size(116, 44);
            btn_logout_LF.TabIndex = 12;
            btn_logout_LF.Text = "Log out";
            btn_logout_LF.UseVisualStyleBackColor = false;
            btn_logout_LF.Click += btn_logout_LF_Click;
            // 
            // LeaveRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(822, 486);
            Controls.Add(btn_logout_LF);
            Controls.Add(combo_leaveReason_LRF);
            Controls.Add(btn_cancelRequest_LRF);
            Controls.Add(dgv_ShowRequests_LRF);
            Controls.Add(btn_back_LRF);
            Controls.Add(btn_ShowRequests_LRF);
            Controls.Add(btn_SendRequest_LRF);
            Controls.Add(label3);
            Controls.Add(requestEndTime_LRF);
            Controls.Add(requestStartTime_LRF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LeaveRequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leave Request Form";
            Load += LeaveRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ShowRequests_LRF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker requestStartTime_LRF;
        private DateTimePicker requestEndTime_LRF;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_SendRequest_LRF;
        private Button btn_ShowRequests_LRF;
        private Button btn_back_LRF;
        private DataGridView dgv_ShowRequests_LRF;
        private Button btn_cancelRequest_LRF;
        private ComboBox combo_leaveReason_LRF;
        private Button btn_logout_LF;
    }
}