using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class centerl_user_B : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // 1. تعريف جدول البيانات كمتغير عام لنتمكن من البحث فيه
        DataTable dtVisits = new DataTable();

        public centerl_user_B()
        {
            InitializeComponent();
            this.Load += new EventHandler(centerl_user_B_Load);

            // ربط حدث الكتابة في مربع البحث (تأكد أن اسم المربع لديك هو searchBox)
            if (searchBox != null) // تحقق بسيط لتجنب الأخطاء
            {
                this.searchBox.TextChanged += new EventHandler(this.searchBox_TextChanged);
            }
        }

        private void centerl_user_B_Load(object sender, EventArgs e)
        {
            LoadVisitsData();
            StyleDataGridView();
        }

        public void LoadVisitsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllSupervisorVisits", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        // تنظيف الجدول القديم وتعبئته من جديد
                        dtVisits.Clear();
                        da.Fill(dtVisits);

                        // ربط الجدول بالداتاجريد
                        dataGridView1.DataSource = dtVisits;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        // =========================================================
        // كود البحث: تصفية البيانات أثناء الكتابة
        // =========================================================
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // التحقق من أن الجدول يحتوي بيانات
            if (dtVisits.Rows.Count == 0) return;

            string searchValue = searchBox.Text.Trim();

            // إذا كان مربع البحث فارغاً، نعرض كل البيانات
            if (string.IsNullOrEmpty(searchValue))
            {
                dtVisits.DefaultView.RowFilter = "";
            }
            else
            {
                // تطبيق الفلتر على عمودي "اسم المركز" و "اسم المحفظ"
                // نستخدم الأسماء العربية لأننا أسميناها كذلك في SQL Stored Procedure
                dtVisits.DefaultView.RowFilter = string.Format("[اسم المركز] LIKE '%{0}%' OR [اسم المحفظ] LIKE '%{0}%'", searchValue);
            }
        }

        // ... (بقية دوال التنسيق والأزرار كما هي دون تغيير) ...

        private void StyleDataGridView()
        {
            // ... (نفس كود التنسيق السابق الذي اعتمدناه) ...
            // فقط تأكد من وضع الكود هنا
            // ...

            // إعادة نسخ كود التنسيق للتذكير فقط (اختياري، يمكنك تركه كما هو عندك)
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
          //  dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 255, 253);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 245, 238);
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            if (dataGridView1.Columns["VisitId"] != null) dataGridView1.Columns["VisitId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddTeacherVisit addForm = new frmAddTeacherVisit();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadVisitsData();
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "تقرير_الزيارات_" + DateTime.Now.ToString("yyyyMMdd");
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("لم يتمكن البرنامج من الكتابة على القرص: " + ex.Message);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            // =========================================================
                            // تصحيح 1: استخدام Rotate() كدالة وليس كخاصية
                            // =========================================================
                            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);

                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            pdfDoc.Open();

                            // إعداد الخط العربي
                            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                            // =========================================================
                            // تصحيح 2: كتابة الاسم الكامل (iTextSharp.text.Font) لمنع التعارض
                            // =========================================================
                            iTextSharp.text.Font arabicFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);

                            // إضافة العنوان
                            PdfPTable titleTable = new PdfPTable(1);
                            titleTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                            titleTable.WidthPercentage = 100;
                            PdfPCell titleCell = new PdfPCell(new Phrase("تقرير زيارات المشرفين", titleFont));
                            titleCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            titleCell.PaddingBottom = 20f;
                            titleTable.AddCell(titleCell);
                            pdfDoc.Add(titleTable);

                            // حساب الأعمدة الظاهرة
                            int visibleColumnsCount = 0;
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                if (col.Visible) visibleColumnsCount++;
                            }

                            PdfPTable pdfTable = new PdfPTable(visibleColumnsCount);
                            pdfTable.DefaultCell.Padding = 6;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // إضافة رؤوس الأعمدة
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                if (column.Visible)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                                    // استخدام BaseColor الخاص بـ PDF وليس Color الخاص بـ WinForms
                                    cell.BackgroundColor = new BaseColor(26, 188, 156);
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    cell.Padding = 8;
                                    pdfTable.AddCell(cell);
                                }
                            }

                            // إضافة البيانات
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (dataGridView1.Columns[cell.ColumnIndex].Visible)
                                    {
                                        string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                                        PdfPCell pdfCell = new PdfPCell(new Phrase(cellValue, arabicFont));
                                        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        pdfCell.Padding = 6;

                                        // تلوين الصفوف (اختياري)
                                        if (row.Index % 2 != 0)
                                        {
                                            pdfCell.BackgroundColor = new BaseColor(248, 255, 253);
                                        }

                                        pdfTable.AddCell(pdfCell);
                                    }
                                }
                            }

                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();

                            MessageBox.Show("تم تصدير البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // فتح الملف تلقائياً
                            System.Diagnostics.Process.Start(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("حدث خطأ أثناء التصدير: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("لا توجد بيانات للتصدير", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // بقية الأزرار...
        }
    }
}
