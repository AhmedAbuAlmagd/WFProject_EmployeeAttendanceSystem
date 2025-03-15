using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Bouncycastleconnector;
using Org.BouncyCastle.Crypto;

using iText.IO.Font;
using iText.Kernel.Font;


namespace EF_Project.Forms
{
    public partial class LogsForm : Form
    {
        LogsServices logServices;
        Form prevForm;
        public LogsForm()
        {
            InitializeComponent();

            logServices = new LogsServices(new AttendanceContext());
            cb_action_LF.DataSource = Enum.GetValues(typeof(EmployeeAttendanceSystem.DataAccess.Models.Action));
            cb_attendstatus_LF.DataSource = Enum.GetValues(typeof(Attendance_Status));
            this.prevForm = prevForm;
            Design_Dgv();
        }

        private void btn_getlogs_LF_Click(object sender, EventArgs e)
        {
            dgv_showlogs_LF.DataSource = logServices.GetAll()
                .Select(log => new
                {
                    log.id,
                    EmployeeName = log.Employee.name,
                    EmployeeDepartment = log.Employee.Department.name,
                    log.action,
                    log.actionTime,
                    log.attendance_Status,
                    LeaveTypes = log.Employee?.LeaveRequests?.Any() == true
                    ? string.Join(", ", log.Employee.LeaveRequests.Select(lr => lr.LeaveType.ToString()))
                        : "No Requests"
                }).ToList();


        }

        private void btn_add_LF_Click(object sender, EventArgs e)
        {
            try
            {
                Log log = new Log()
                {
                    action = (EmployeeAttendanceSystem.DataAccess.Models.Action)cb_action_LF.SelectedItem,
                    attendance_Status = (Attendance_Status)cb_attendstatus_LF.SelectedItem,
                    actionTime = actiontime_LF.Value.Date,
                };
                logServices.Add(log);
                MessageBox.Show("Added done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_showlogs_LF.DataSource = logServices.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportDGVtoPDF(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4.Rotate());
                using (Document document = new Document(pdf))
                {
                    document.Add(new Paragraph("Attendance Report").SetFontSize(20));

                    float[] columnWidths = new float[dgv_showlogs_LF.ColumnCount];
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        columnWidths[i] = 1;
                    }
                    Table table = new Table(UnitValue.CreatePercentArray(columnWidths)).UseAllAvailableWidth();
                    table.SetFontSize(8);
                    table.SetPadding(2);

                    foreach (DataGridViewColumn column in dgv_showlogs_LF.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));

                    }

                    foreach (DataGridViewRow row in dgv_showlogs_LF.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                            }
                        }


                    }
                    document.Add(table);


                }
            }
        }

        private void btn_exportpdf_LF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Choose Place"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDGVtoPDF(saveFileDialog.FileName);
                MessageBox.Show(" Report File Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_LF_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_logout_LF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void Design_Dgv()
        {
            dgv_showlogs_LF.BackgroundColor = Color.Ivory;
            dgv_showlogs_LF.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            dgv_showlogs_LF.DefaultCellStyle.ForeColor = Color.Black;
            dgv_showlogs_LF.GridColor = Color.Gray;

            dgv_showlogs_LF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 128);
            dgv_showlogs_LF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_showlogs_LF.EnableHeadersVisualStyles = false;

            dgv_showlogs_LF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 192);
            dgv_showlogs_LF.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}

