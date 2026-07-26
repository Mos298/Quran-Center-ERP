using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmPrintEvaluation : Form
    {
        private string _connectionString;
        private List<Student> _selectedStudentsToPrint;
        private int _currentStudentIndexToPrint;
        private DataTable _currentEvaluationData;

        public frmPrintEvaluation(string dbConnectionString)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
        }

        private void frmPrintEvaluation_Load(object sender, EventArgs e)
        {
            LoadStudentsList();
        }

        /// <summary>
        /// تحميل قائمة بجميع الطلاب لعرضها في القائمة
        /// </summary>
        private void LoadStudentsList()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID, FullName FROM Students ORDER BY FullName", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // استخدام كلاس Student لربط البيانات بشكل أفضل
                    var students = dt.AsEnumerable().Select(row => new Student
                    {
                        Id = row.Field<int>("ID"),
                        FullName = row.Field<string>("FullName")
                    }).ToList();

                    // ربط مصدر البيانات بالقائمة
                    clbStudents.DataSource = students;
                    clbStudents.DisplayMember = "FullName";
                    clbStudents.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل قائمة الطلاب: \n" + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // الحصول على قائمة الطلاب المحددين
            _selectedStudentsToPrint = clbStudents.CheckedItems.OfType<Student>().ToList();

            if (_selectedStudentsToPrint.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل للطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // إعادة تعيين مؤشر الطباعة والبدء
            _currentStudentIndexToPrint = 0;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // التأكد من وجود طلاب للطباعة
            if (_selectedStudentsToPrint == null || _currentStudentIndexToPrint >= _selectedStudentsToPrint.Count)
            {
                return;
            }

            // الحصول على الطالب الحالي
            Student currentStudent = _selectedStudentsToPrint[_currentStudentIndexToPrint];

            // جلب أحدث تقييم للطالب الحالي من قاعدة البيانات
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = @"SELECT TOP 1 e.*, s.FullName, s.RegistrationNumber 
                                     FROM StudentEvaluations e
                                     JOIN Students s ON e.StudentID = s.ID
                                     WHERE s.ID = @StudentID
                                     ORDER BY e.EvaluationDate DESC"; // جلب أحدث تقييم
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@StudentID", currentStudent.Id);
                    _currentEvaluationData = new DataTable();
                    da.Fill(_currentEvaluationData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب بيانات التقييم للطالب {currentStudent.FullName}: \n" + ex.Message);
                e.Cancel = true;
                return;
            }

            // التحقق من وجود تقييم للطالب
            if (_currentEvaluationData.Rows.Count == 0)
            {
                // إذا لم يوجد تقييم، ارسم رسالة بسيطة وانتقل للتالي
                e.Graphics.DrawString($"لا توجد تقييمات مسجلة للطالب: {currentStudent.FullName}", new Font("Segoe UI", 12), Brushes.Red, e.MarginBounds.Left, e.MarginBounds.Top);
            }
            else
            {
                // إذا وجد تقييم، قم برسمه
                DrawReport(e, _currentEvaluationData.Rows[0]);
            }

            // الانتقال إلى الطالب التالي
            _currentStudentIndexToPrint++;

            // التحقق إذا كان هناك المزيد من الصفحات (الطلاب) للطباعة
            if (_currentStudentIndexToPrint < _selectedStudentsToPrint.Count)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                // إعادة تعيين المؤشر بعد انتهاء الطباعة
                _currentStudentIndexToPrint = 0;
            }
        }

        /// <summary>
        /// دالة مساعدة لرسم محتوى التقرير
        /// </summary>
        private void DrawReport(System.Drawing.Printing.PrintPageEventArgs e, DataRow row)
        {
            Font titleFont = new Font("Segoe UI", 20, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 12, FontStyle.Regular);

            float yPos = 100;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            // 1. العنوان
            string title = "تقرير المستوى التعليمي";
            e.Graphics.DrawString(title, titleFont, Brushes.Black, rightMargin, yPos, format);
            yPos += titleFont.GetHeight() + 40;

            // 2. بيانات الطالب
            e.Graphics.DrawString("اسم الطالب:", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["FullName"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 150, yPos, format);
            yPos += headerFont.GetHeight() + 10;

            e.Graphics.DrawString("رقم القيد:", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["RegistrationNumber"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 150, yPos, format);
            yPos += headerFont.GetHeight() + 30;

            // 3. خط فاصل
            e.Graphics.DrawLine(Pens.Gray, leftMargin, yPos, rightMargin, yPos);
            yPos += 20;

            // 4. بيانات التقييم
            e.Graphics.DrawString("تاريخ التقييم:", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(Convert.ToDateTime(row["EvaluationDate"]).ToShortDateString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 200, yPos, format);
            yPos += headerFont.GetHeight() + 10;

            e.Graphics.DrawString("التزام الطالب:", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["Commitment"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 200, yPos, format);
            yPos += headerFont.GetHeight() + 10;

            e.Graphics.DrawString("عدد الأجزاء المحفوظة:", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["MemorizedAjza"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 200, yPos, format);
            yPos += headerFont.GetHeight() + 10;

            e.Graphics.DrawString("مستوى الحفظ (%):", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["MemorizationLevel"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 200, yPos, format);
            yPos += headerFont.GetHeight() + 10;

            e.Graphics.DrawString("مستوى الأحكام (%):", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["TajweedLevel"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 200, yPos, format);
            yPos += headerFont.GetHeight() + 10;

            e.Graphics.DrawString("المستوى العام:", headerFont, Brushes.Black, rightMargin, yPos, format);
            e.Graphics.DrawString(row["OverallLevel"].ToString(), bodyFont, Brushes.DarkSlateGray, rightMargin - 200, yPos, format);
        }
    }
}

