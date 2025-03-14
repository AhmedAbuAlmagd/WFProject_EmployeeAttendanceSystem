﻿namespace EF_Project.Forms
{
    partial class LogsForm
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
            dgv_showlogs_LF = new DataGridView();
            btn_getlogs_LF = new Button();
            btn_add_LF = new Button();
            btn_exportpdf_LF = new Button();
            cb_action_LF = new ComboBox();
            cb_attendstatus_LF = new ComboBox();
            actiontime_LF = new DateTimePicker();
            lbl_action_LF = new Label();
            lbl_attendstatus_LLF = new Label();
            lbl_actiontime_LF = new Label();
            btn_back_LF = new Button();
            btn_logout_LF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_showlogs_LF).BeginInit();
            SuspendLayout();
            // 
            // dgv_showlogs_LF
            // 
            dgv_showlogs_LF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_showlogs_LF.Location = new Point(12, 310);
            dgv_showlogs_LF.Name = "dgv_showlogs_LF";
            dgv_showlogs_LF.RowHeadersWidth = 51;
            dgv_showlogs_LF.Size = new Size(776, 200);
            dgv_showlogs_LF.TabIndex = 0;
            // 
            // btn_getlogs_LF
            // 
            btn_getlogs_LF.Location = new Point(25, 233);
            btn_getlogs_LF.Name = "btn_getlogs_LF";
            btn_getlogs_LF.Size = new Size(165, 57);
            btn_getlogs_LF.TabIndex = 1;
            btn_getlogs_LF.Text = "Get Logs";
            btn_getlogs_LF.UseVisualStyleBackColor = true;
            btn_getlogs_LF.Click += btn_getlogs_LF_Click;
            // 
            // btn_add_LF
            // 
            btn_add_LF.Location = new Point(321, 233);
            btn_add_LF.Name = "btn_add_LF";
            btn_add_LF.Size = new Size(141, 57);
            btn_add_LF.TabIndex = 2;
            btn_add_LF.Text = "Add";
            btn_add_LF.UseVisualStyleBackColor = true;
            btn_add_LF.Click += btn_add_LF_Click;
            // 
            // btn_exportpdf_LF
            // 
            btn_exportpdf_LF.Location = new Point(586, 233);
            btn_exportpdf_LF.Name = "btn_exportpdf_LF";
            btn_exportpdf_LF.Size = new Size(202, 57);
            btn_exportpdf_LF.TabIndex = 3;
            btn_exportpdf_LF.Text = "Export To PDF";
            btn_exportpdf_LF.UseVisualStyleBackColor = true;
            btn_exportpdf_LF.Click += btn_exportpdf_LF_Click;
            // 
            // cb_action_LF
            // 
            cb_action_LF.FormattingEnabled = true;
            cb_action_LF.Location = new Point(230, 15);
            cb_action_LF.Name = "cb_action_LF";
            cb_action_LF.Size = new Size(151, 28);
            cb_action_LF.TabIndex = 4;
            // 
            // cb_attendstatus_LF
            // 
            cb_attendstatus_LF.FormattingEnabled = true;
            cb_attendstatus_LF.Location = new Point(239, 77);
            cb_attendstatus_LF.Name = "cb_attendstatus_LF";
            cb_attendstatus_LF.Size = new Size(151, 28);
            cb_attendstatus_LF.TabIndex = 5;
            // 
            // actiontime_LF
            // 
            actiontime_LF.Location = new Point(230, 142);
            actiontime_LF.Name = "actiontime_LF";
            actiontime_LF.Size = new Size(248, 27);
            actiontime_LF.TabIndex = 6;
            // 
            // lbl_action_LF
            // 
            lbl_action_LF.AutoSize = true;
            lbl_action_LF.Location = new Point(61, 18);
            lbl_action_LF.Name = "lbl_action_LF";
            lbl_action_LF.Size = new Size(52, 20);
            lbl_action_LF.TabIndex = 7;
            lbl_action_LF.Text = "Action";
            // 
            // lbl_attendstatus_LLF
            // 
            lbl_attendstatus_LLF.AutoSize = true;
            lbl_attendstatus_LLF.Location = new Point(61, 85);
            lbl_attendstatus_LLF.Name = "lbl_attendstatus_LLF";
            lbl_attendstatus_LLF.Size = new Size(129, 20);
            lbl_attendstatus_LLF.TabIndex = 8;
            lbl_attendstatus_LLF.Text = "Attendance Status";
            // 
            // lbl_actiontime_LF
            // 
            lbl_actiontime_LF.AutoSize = true;
            lbl_actiontime_LF.Location = new Point(74, 149);
            lbl_actiontime_LF.Name = "lbl_actiontime_LF";
            lbl_actiontime_LF.Size = new Size(89, 20);
            lbl_actiontime_LF.TabIndex = 9;
            lbl_actiontime_LF.Text = "Action Time";
            // 
            // btn_back_LF
            // 
            btn_back_LF.Location = new Point(12, 526);
            btn_back_LF.Name = "btn_back_LF";
            btn_back_LF.Size = new Size(151, 63);
            btn_back_LF.TabIndex = 10;
            btn_back_LF.Text = "Back";
            btn_back_LF.UseVisualStyleBackColor = true;
            btn_back_LF.Click += btn_back_LF_Click;
            // 
            // btn_logout_LF
            // 
            btn_logout_LF.Location = new Point(604, 526);
            btn_logout_LF.Name = "btn_logout_LF";
            btn_logout_LF.Size = new Size(166, 63);
            btn_logout_LF.TabIndex = 11;
            btn_logout_LF.Text = "Log out";
            btn_logout_LF.UseVisualStyleBackColor = true;
            btn_logout_LF.Click += btn_logout_LF_Click;
            // 
            // LogsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(btn_logout_LF);
            Controls.Add(btn_back_LF);
            Controls.Add(lbl_actiontime_LF);
            Controls.Add(lbl_attendstatus_LLF);
            Controls.Add(lbl_action_LF);
            Controls.Add(actiontime_LF);
            Controls.Add(cb_attendstatus_LF);
            Controls.Add(cb_action_LF);
            Controls.Add(btn_exportpdf_LF);
            Controls.Add(btn_add_LF);
            Controls.Add(btn_getlogs_LF);
            Controls.Add(dgv_showlogs_LF);
            Name = "LogsForm";
            Text = "LogsForm";
            ((System.ComponentModel.ISupportInitialize)dgv_showlogs_LF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_showlogs_LF;
        private Button btn_getlogs_LF;
        private Button btn_add_LF;
        private Button btn_exportpdf_LF;
        private ComboBox cb_action_LF;
        private ComboBox cb_attendstatus_LF;
        private DateTimePicker actiontime_LF;
        private Label lbl_action_LF;
        private Label lbl_attendstatus_LLF;
        private Label lbl_actiontime_LF;
        private Button btn_back_LF;
        private Button btn_logout_LF;
    }
}