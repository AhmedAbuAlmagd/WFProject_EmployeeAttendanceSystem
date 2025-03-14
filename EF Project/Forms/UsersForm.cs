using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;


namespace EF_Project
{
    public partial class UsersForm : Form
    {
        UserServices userServices;
        EmployeeServices employeeServices;
        AttendanceContext attendanceContext;
        Form prevForm;
        public UsersForm(Form prevForm)
        {
            InitializeComponent();
            attendanceContext = new AttendanceContext();
            userServices = new UserServices(attendanceContext);
            employeeServices = new EmployeeServices(attendanceContext);
            this.prevForm = prevForm;

            Design_Dgv();
        }

        private void Design_Dgv()
        {
            dgv_users_UF.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgv_users_UF.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dgv_users_UF.DefaultCellStyle.ForeColor = Color.Black;
            dgv_users_UF.GridColor = Color.Gray;

            dgv_users_UF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 128);
            dgv_users_UF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_users_UF.EnableHeadersVisualStyles = false;

            dgv_users_UF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 192);
            dgv_users_UF.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            List<string> roles = Enum.GetNames(typeof(role)).ToList();

            combo_role_UF.DataSource = roles;
            combo_employee_UF.DataSource = employeeServices.GetAllEmp();
            combo_employee_UF.DisplayMember = "name";
            combo_employee_UF.ValueMember = "id";
            dgv_users_UF.DataSource = userServices.GetAll();
            dgv_users_UF.Columns["Employee"].Visible = false;

        }
        int user_id;
        private void dgv_users_UF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            user_id = (int)dgv_users_UF.SelectedRows[0].Cells[0].Value;
            txt_userName_UF.Text = dgv_users_UF.SelectedRows[0].Cells[1].Value.ToString();
            txt_password_UF.Text = dgv_users_UF.SelectedRows[0].Cells[2].Value.ToString();
            combo_role_UF.Text = dgv_users_UF.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_addUser_UF_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    userName = txt_userName_UF.Text,
                    password = txt_password_UF.Text,
                    role = (role)Enum.Parse(typeof(role), combo_role_UF.Text),
                    employeeId = (int)combo_employee_UF.SelectedValue
                };

                userServices.Add(user);
                resetInputs();
                MessageBox.Show("User Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void check_viewPass_UF_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_password_UF.UseSystemPasswordChar = false;
            else
                txt_password_UF.UseSystemPasswordChar = true;
        }

        private void btn_updateUser_UF_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    userName = txt_userName_UF.Text,
                    password = txt_password_UF.Text,
                    role = (role)Enum.Parse(typeof(role), combo_role_UF.Text),
                    employeeId = (int)combo_employee_UF.SelectedValue
                };
                userServices.Update(user_id, user);
                MessageBox.Show("User Updated successfully");
                resetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteUser_UF_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    userServices.Delete(user_id);
                    MessageBox.Show("User deleted successfully!");
                    resetInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void resetInputs()
        {
            txt_userName_UF.Text = txt_password_UF.Text = "";
            dgv_users_UF.DataSource = userServices.GetAll();
            dgv_users_UF.Columns["Employee"].Visible = false;
            check_viewPass_UF.Checked = false;
        }

        private void btn_back_UF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show(); 
        }
    }
}
