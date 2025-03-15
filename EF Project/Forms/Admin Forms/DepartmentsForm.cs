using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project.Forms
{
    public partial class DepartmentsForm : Form
    {
        DepartmentServices departmentServices;
        Form prevForm;
        public DepartmentsForm(Form prevForm)
        {
            InitializeComponent();
            departmentServices = new DepartmentServices(new AttendanceContext());
            this.prevForm = prevForm;
            Design_Dgv();
        }
        private void Design_Dgv()
        {
            dgv_department.BackgroundColor = Color.Ivory;
            dgv_department.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dgv_department.DefaultCellStyle.ForeColor = Color.Black;
            dgv_department.GridColor = Color.Gray;

            dgv_department.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 128);
            dgv_department.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_department.EnableHeadersVisualStyles = false;

            dgv_department.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 192);
            dgv_department.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            dgv_department.DataSource = departmentServices.GetAll();
        }
        int dept_id;
        private void dgv_department_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dept_id = (int)dgv_department.SelectedRows[0].Cells[0].Value;
            txt_deptName_DF.Text = dgv_department.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_addDept_UF_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department()
                {
                    name = txt_deptName_DF.Text
                };
                departmentServices.Add(dept);
                MessageBox.Show("Department Added Successfully");
                resetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_updateDept_UF_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department()
                {
                    name = txt_deptName_DF.Text
                };
                departmentServices.Update(dept_id, dept);
                MessageBox.Show("Department Updated successfully");
                resetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_deleteDept_UF_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    departmentServices.Delete(dept_id);
                    MessageBox.Show("Department deleted successfully!");
                    resetInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetInputs()
        {
            dgv_department.DataSource = departmentServices.GetAll();
            txt_deptName_DF.Text = "";
        }

        private void btn_back_DF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        private void btn_logout_SRF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }
    }
}
