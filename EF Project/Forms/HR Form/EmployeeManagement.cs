using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.Models;

namespace EF_Project.Forms
{
    public partial class EmployeeManagement : Form
    {
        EmployeeServices employeeServices;
        DepartmentServices departmentServices;
        Form prevForm;
        AttendanceContext context;
        int employee_id;
        public EmployeeManagement(int employee_id, Form prevForm)
        {
            InitializeComponent();
            context = new AttendanceContext();
            employeeServices = new EmployeeServices(context);
            departmentServices = new DepartmentServices(context);
            this.prevForm = prevForm;
            this.employee_id = employee_id;
            Design_Dgv();
        }
        private void Design_Dgv()
        {
            dgv_emp_EMF.BackgroundColor = Color.Ivory;
            dgv_emp_EMF.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dgv_emp_EMF.DefaultCellStyle.ForeColor = Color.Black;
            dgv_emp_EMF.GridColor = Color.Gray;

            dgv_emp_EMF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 128);
            dgv_emp_EMF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_emp_EMF.EnableHeadersVisualStyles = false;

            dgv_emp_EMF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 192);
            dgv_emp_EMF.DefaultCellStyle.SelectionForeColor = Color.White;
        }
        private void btn_add_EMF_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee()
                {
                    name = txt_name_EMF.Text,
                    email = txt_email_EMF.Text,
                    phone = txt_phone_EMF.Text,
                    position = txt_position_EMF.Text,
                    deptId = (int)cb_dept_EMF.SelectedValue,
                    workSchedule = (workSchedule)cb_schedule_EMF.SelectedItem,

                };
                employeeServices.Add(emp);
                MessageBox.Show("Added Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_name_EMF.Text = txt_email_EMF.Text = txt_position_EMF.Text = txt_phone_EMF.Text = "";

        }
        int id;
        private void dgv_emp_EMF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_emp_EMF.SelectedRows[0].Cells[0].Value;
            Employee emp = employeeServices.GetById(id);
            txt_name_EMF.Text = emp.name;
            txt_phone_EMF.Text = emp.phone;
            txt_email_EMF.Text = emp.email;
            txt_position_EMF.Text = emp.position;
            cb_dept_EMF.SelectedValue = emp.deptId;
            cb_schedule_EMF.SelectedItem = emp.workSchedule;

        }

        private void btn_edit_EMF_Click(object sender, EventArgs e)
        {

            try
            {
                id = (int)dgv_emp_EMF.SelectedRows[0].Cells[0].Value;
                Employee emp = employeeServices.GetById((int)id);
                emp.name = txt_name_EMF.Text;
                emp.email = txt_phone_EMF.Text;
                emp.phone = txt_email_EMF.Text;
                emp.position = txt_position_EMF.Text;
                emp.deptId = (int)cb_dept_EMF.SelectedValue;
                emp.workSchedule = (workSchedule)cb_schedule_EMF.SelectedItem;
                employeeServices.Update(id, emp);
                MessageBox.Show("Updated Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                ResetView();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_name_EMF.Text = txt_email_EMF.Text = txt_phone_EMF.Text = txt_position_EMF.Text = "";

        }
  
        private void btn_delete_EMF_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Delete this Employee?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    employeeServices.Delete(id);
                    MessageBox.Show("Deleted success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ResetView();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EmployeeManagment_Load(object sender, EventArgs e)
        {
            ResetView();

            cb_dept_EMF.DataSource = departmentServices.GetAll();
            LoadEnumComboBox();
            cb_dept_EMF.ValueMember = "id";
            cb_dept_EMF.DisplayMember = "name";
        }
        private void LoadEnumComboBox()
        {
            cb_schedule_EMF.DataSource = Enum.GetValues(typeof(workSchedule));
        }

        private void btn_back_EMF_Click(object sender, EventArgs e)
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

        public void ResetView()
        {
            if (employeeServices.GetById(employee_id).User.role.ToString() == "HR")
                dgv_emp_EMF.DataSource = employeeServices.GetAllEmp();
            else
                dgv_emp_EMF.DataSource = employeeServices.GetAllEmpAndHr();

            dgv_emp_EMF.Columns["Department"].Visible = false;
            dgv_emp_EMF.Columns["User"].Visible = false;
            txt_name_EMF.Text = txt_email_EMF.Text = txt_phone_EMF.Text = txt_position_EMF.Text = "";
        }
    }
}
