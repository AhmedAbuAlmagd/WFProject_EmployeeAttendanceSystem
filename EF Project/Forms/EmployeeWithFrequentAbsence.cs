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
using iText.Layout.Element;
using iText.Layout.Properties;

namespace EF_Project.Forms
{
    public partial class EmployeeWithFrequentAbsence : Form
    {
        AttendanceServices attendanceServices;
        AttendanceContext context;
        private int hr_id;
        public EmployeeWithFrequentAbsence()
        {
            InitializeComponent();
            context = new AttendanceContext();
            attendanceServices = new AttendanceServices(context);
        }

        private void btn_showabsenceemployees_EFAF_Click(object sender, EventArgs e)
        {
            var startDate = DateOnly.FromDateTime(dtp_endDate_EFAF.Value);
            var endDate = DateOnly.FromDateTime(dtp_endDate_EFAF.Value);
            int frequentAbsenceNo = 5;

            var absenteesEmployees = attendanceServices.GetFrequentAbsentees(startDate, endDate, frequentAbsenceNo);
            dgv_empfrequentabsence_EFAF.DataSource = absenteesEmployees
                .Select(e => new
                {
                    e.id,
                    e.name,
                    e.position,
                    e.email,
                    e.phone,
                    e.workSchedule,

                }).ToList();
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

                    float[] columnWidths = new float[dgv_empfrequentabsence_EFAF.ColumnCount];
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        columnWidths[i] = 1;
                    }
                    Table table = new Table(UnitValue.CreatePercentArray(columnWidths)).UseAllAvailableWidth();
                    table.SetFontSize(8);
                    table.SetPadding(2);

                    foreach (DataGridViewColumn column in dgv_empfrequentabsence_EFAF.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));

                    }

                    foreach (DataGridViewRow row in dgv_empfrequentabsence_EFAF.Rows)
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

        private void btn_exportpdf_EFAF_Click(object sender, EventArgs e)
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

        private void btn_back_EFAF_Click(object sender, EventArgs e)
        {
            HRDashboard hRDashboard = new HRDashboard(hr_id);
            hRDashboard.Show();
            this.Close();
        }
    }
}
