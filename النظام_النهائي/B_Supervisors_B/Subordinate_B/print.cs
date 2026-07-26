using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;    
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace النظام_النهائي.B_Supervisors_B.Subordinate_B
{
    public partial class print : Form
    {
        private string _connectionString;
        private string _teacherName; // متغير جديد لتخزين اسم الشيخ
        Bitmap _bitmap;

        // تم تعديل المُنشئ ليقبل اسم الشيخ
        public print(string dbConnectionString, string teacherName)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _teacherName = teacherName; // تخزين اسم الشيخ المطلوب
        }

        private void frmPrintStudents_Load(object sender, EventArgs e)
        {
            LoadTeacherStudentsData();
        }

        /// <summary>
        /// تحميل بيانات الطلاب المسجلين لدى شيخ معين
        /// </summary>
        private void LoadTeacherStudentsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // تم تعديل الاستعلام ليقوم بالتصفية بناءً على اسم الشيخ
                    SqlDataAdapter da = new SqlDataAdapter("SELECT FullName, GuardianName, BirthDate, Nationality, Residence, Gender, NationalID, StudentPhone, GuardianPhone, RegistrationNumber FROM Students WHERE TeacherName = @TeacherName", con);
                    // إضافة اسم الشيخ كمعامل للاستعلام
                    da.SelectCommand.Parameters.AddWithValue("@TeacherName", _teacherName);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStudentsToPrint.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات الطلاب: \n" + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            _bitmap = new Bitmap(this.dgvStudentsToPrint.Width, this.dgvStudentsToPrint.Height);
            dgvStudentsToPrint.DrawToBitmap(_bitmap, new Rectangle(0, 0, this.dgvStudentsToPrint.Width, this.dgvStudentsToPrint.Height));
            e.Graphics.DrawImage(_bitmap, 10, 10);
        }
    }
}
