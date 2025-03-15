namespace EF_Project.Forms
{
    partial class DepartmentsForm
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
            dgv_department = new DataGridView();
            txt_deptName_DF = new TextBox();
            label1 = new Label();
            btn_deleteDept_UF = new Button();
            btn_updateDept_UF = new Button();
            btn_addDept_UF = new Button();
            btn_back_DF = new Button();
            btn_logout_SRF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_department).BeginInit();
            SuspendLayout();
            // 
            // dgv_department
            // 
            dgv_department.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_department.BackgroundColor = Color.Ivory;
            dgv_department.ColumnHeadersHeight = 22;
            dgv_department.Location = new Point(90, 133);
            dgv_department.Name = "dgv_department";
            dgv_department.RowHeadersWidth = 70;
            dgv_department.Size = new Size(427, 346);
            dgv_department.TabIndex = 0;
            dgv_department.RowHeaderMouseDoubleClick += dgv_department_RowHeaderMouseDoubleClick;
            // 
            // txt_deptName_DF
            // 
            txt_deptName_DF.Location = new Point(322, 40);
            txt_deptName_DF.Name = "txt_deptName_DF";
            txt_deptName_DF.Size = new Size(163, 27);
            txt_deptName_DF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(103, 36);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 2;
            label1.Text = "Department Name";
            // 
            // btn_deleteDept_UF
            // 
            btn_deleteDept_UF.BackColor = Color.FromArgb(208, 40, 80);
            btn_deleteDept_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_deleteDept_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_deleteDept_UF.Location = new Point(647, 366);
            btn_deleteDept_UF.Name = "btn_deleteDept_UF";
            btn_deleteDept_UF.Size = new Size(142, 54);
            btn_deleteDept_UF.TabIndex = 11;
            btn_deleteDept_UF.Text = "Delete";
            btn_deleteDept_UF.UseVisualStyleBackColor = false;
            btn_deleteDept_UF.Click += btn_deleteDept_UF_Click;
            // 
            // btn_updateDept_UF
            // 
            btn_updateDept_UF.BackColor = Color.FromArgb(245, 166, 35);
            btn_updateDept_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_updateDept_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_updateDept_UF.Location = new Point(647, 267);
            btn_updateDept_UF.Name = "btn_updateDept_UF";
            btn_updateDept_UF.Size = new Size(142, 54);
            btn_updateDept_UF.TabIndex = 10;
            btn_updateDept_UF.Text = "Update";
            btn_updateDept_UF.UseVisualStyleBackColor = false;
            btn_updateDept_UF.Click += btn_updateDept_UF_Click;
            // 
            // btn_addDept_UF
            // 
            btn_addDept_UF.BackColor = Color.FromArgb(53, 122, 189);
            btn_addDept_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_addDept_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_addDept_UF.Location = new Point(647, 168);
            btn_addDept_UF.Name = "btn_addDept_UF";
            btn_addDept_UF.Size = new Size(142, 54);
            btn_addDept_UF.TabIndex = 9;
            btn_addDept_UF.Text = "Add ";
            btn_addDept_UF.UseVisualStyleBackColor = false;
            btn_addDept_UF.Click += btn_addDept_UF_Click;
            // 
            // btn_back_DF
            // 
            btn_back_DF.BackColor = Color.FromArgb(75, 75, 75);
            btn_back_DF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_DF.ForeColor = SystemColors.ButtonHighlight;
            btn_back_DF.Location = new Point(602, 494);
            btn_back_DF.Name = "btn_back_DF";
            btn_back_DF.Size = new Size(116, 44);
            btn_back_DF.TabIndex = 11;
            btn_back_DF.Text = "Back";
            btn_back_DF.UseVisualStyleBackColor = false;
            btn_back_DF.Click += btn_back_DF_Click;
            // 
            // btn_logout_SRF
            // 
            btn_logout_SRF.BackColor = Color.FromArgb(75, 75, 75);
            btn_logout_SRF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_logout_SRF.ForeColor = SystemColors.Control;
            btn_logout_SRF.Location = new Point(737, 494);
            btn_logout_SRF.Name = "btn_logout_SRF";
            btn_logout_SRF.Size = new Size(116, 44);
            btn_logout_SRF.TabIndex = 16;
            btn_logout_SRF.Text = "Log Out";
            btn_logout_SRF.UseVisualStyleBackColor = false;
            btn_logout_SRF.Click += btn_logout_SRF_Click;
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(865, 550);
            Controls.Add(btn_logout_SRF);
            Controls.Add(btn_back_DF);
            Controls.Add(btn_deleteDept_UF);
            Controls.Add(btn_updateDept_UF);
            Controls.Add(btn_addDept_UF);
            Controls.Add(label1);
            Controls.Add(txt_deptName_DF);
            Controls.Add(dgv_department);
            Name = "DepartmentsForm";
            Text = "DepartmentsForm";
            Load += DepartmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_department).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_department;
        private TextBox txt_deptName_DF;
        private Label label1;
        private Button btn_deleteDept_UF;
        private Button btn_updateDept_UF;
        private Button btn_addDept_UF;
        private Button btn_back_DF;
        private Button btn_logout_SRF;
    }
}