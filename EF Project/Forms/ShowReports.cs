using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Bouncycastleconnector;
using Org.BouncyCastle.Crypto;

using iText.IO.Font;
using iText.Kernel.Font;
using EmployeeAttendanceSystem.BusinessLogic.Services;
using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;

namespace EF_Project.Forms
{
    public partial class ShowReports : Form
    {
        AttendanceServices attendanceServices;
        EmployeeServices employeeServices;
        AttendanceContext context;
        Form prevForm;
        public ShowReports(Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            context = new AttendanceContext();
            attendanceServices = new AttendanceServices(context);
            employeeServices = new EmployeeServices(context);
            cb_showemp_SRF.DataSource = employeeServices.GetAllEmp();
            cb_showemp_SRF.DisplayMember = "name";
            cb_showemp_SRF.ValueMember = "id";
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            for (int i = 2020; i <= 2025; i++)
            {
                cb_year_SRF.Items.Add(i);

            }
            cb_year_SRF.SelectedItem = currentYear;
            for (int i = 0; i < 12; i++)
            {
                cb_month_SRF.Items.Add(i);
            }
            cb_month_SRF.SelectedItem = currentMonth;
            this.prevForm = prevForm;
        }

        private void btn_dailyreport_SRF_Click(object sender, EventArgs e)
        {

            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            var dailyAttendance = attendanceServices.GetDailyAttendance(date)
        .Select(a => new
        {
            EmployeeName = a.Employee != null ? a.Employee.name : "N/A",  
            a.Date,
            a.checkInTime,
            a.checkOutTime,
            a.WorkingHours,
            a.attendanceStatus
            ,a.IsLate,
            a.IsEarlyDeparture
        }).ToList();

            dgv_showreport_SRF.DataSource = dailyAttendance;

        }

        private void btn_showweekreport_SRF_Click(object sender, EventArgs e)
        {
            if (cb_showemp_SRF.SelectedValue == null)
            {
                MessageBox.Show("Please Choose Employee First!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
            DateTime startDate = DateTime.Now.AddDays(-7);

            var weeklyReport = attendanceServices.GetAttendanceByEmpIdAndDate(empId, DateOnly.FromDateTime(startDate))
       .Select(a => new
       {
           EmployeeName = a.Employee != null ? a.Employee.name : "N/A",
           a.Date,
           a.checkInTime,
           a.checkOutTime,
           a.WorkingHours,
           a.attendanceStatus,
           a.IsLate,
           a.IsEarlyDeparture
       }).ToList();

            dgv_showreport_SRF.DataSource = weeklyReport;

            
        }

        private void btn_showmonth_SRF_Click(object sender, EventArgs e)
        {

            if (cb_showemp_SRF.SelectedValue == null)
            {
                MessageBox.Show("Please Choose One Employee", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_year_SRF.SelectedItem == null && cb_month_SRF.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Year and Month", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)cb_showemp_SRF.SelectedValue;
            int year = (int)cb_year_SRF.SelectedItem;
            int month = (int)cb_month_SRF.SelectedItem;


            var monthlyReport = attendanceServices.GetMonthlyAttendance(empId, year, month)
        .Select(a => new
        {
            EmployeeName = a.Employee != null ? a.Employee.name : "N/A",
            a.Date,
            a.checkInTime,
            a.checkOutTime,
            a.WorkingHours,
            a.attendanceStatus,
            a.IsLate,
            a.IsEarlyDeparture
        }).ToList();

            dgv_showreport_SRF.DataSource = monthlyReport;
    
        }

        private void btn_back_SRF_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        private void btn_logout_SRF_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        //Reports

        BouncyCastleDefaultFactory factory = new BouncyCastleDefaultFactory();

        private void ExportDGVtoPDF(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4.Rotate());
                using (Document document = new Document(pdf))
                {
                    document.Add(new Paragraph("Attendance Report").SetFontSize(20));

                    float[] columnWidths = new float[dgv_showreport_SRF.ColumnCount];
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        columnWidths[i] = 1;
                    }
                    Table table = new Table(UnitValue.CreatePercentArray(columnWidths)).UseAllAvailableWidth();
                    table.SetFontSize(8);
                    table.SetPadding(2);

                    foreach (DataGridViewColumn column in dgv_showreport_SRF.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));

                    }

                    foreach (DataGridViewRow row in dgv_showreport_SRF.Rows)
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

        private void btn_exportPDF_SRF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Choose Place"
            };
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDGVtoPDF(saveFileDialog.FileName);
                MessageBox.Show(" Report File Saved Successfully" , "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
