using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmPrintDataEntry_A : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmPrintDataEntry_A()
        {
            InitializeComponent();
        }

        private void btnPrintToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.Title = "حفظ تقرير مدخلي البيانات";
                sfd.FileName = $"تقرير مدخلي البيانات - {DateTime.Now:yyyy-MM-dd}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. جلب البيانات من قاعدة البيانات
                        string reportContent = GenerateReportContent();

                        // 2. كتابة البيانات إلى الملف المحدد مع دعم اللغة العربية
                        File.WriteAllText(sfd.FileName, reportContent, Encoding.UTF8);

                        MessageBox.Show("تم حفظ التقرير بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل حفظ التقرير. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GenerateReportContent()
        {
            StringBuilder sb = new StringBuilder();

            // إضافة عنوان للتقرير وتاريخ الطباعة
            sb.AppendLine("تقرير بيانات مدخلي البيانات");
            sb.AppendLine($"تاريخ الطباعة: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine("========================================");
            sb.AppendLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                // تم استثناء عمود كلمة المرور إذا كان موجوداً
                string query = "SELECT FullName, BirthDate, Qualification, City, Gender, Department, Position, RegistrationNumber, PhoneNumber, NationalID FROM DataEntryClerks";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sb.AppendLine($"الاسم: {reader["FullName"]}");
                        sb.AppendLine($"تاريخ الميلاد: {Convert.ToDateTime(reader["BirthDate"]):dd/MM/yyyy}");
                        sb.AppendLine($"المؤهل: {reader["Qualification"]}");
                        sb.AppendLine($"المدينة: {reader["City"]}");
                        sb.AppendLine($"الجنس: {reader["Gender"]}");
                        sb.AppendLine($"القسم: {reader["Department"]}");
                        sb.AppendLine($"المنصب: {reader["Position"]}");
                        sb.AppendLine($"رقم القيد: {reader["RegistrationNumber"]}");
                        sb.AppendLine($"رقم الهاتف: {reader["PhoneNumber"]}");
                        sb.AppendLine($"الرقم الوطني: {reader["NationalID"]}");
                        sb.AppendLine("----------------------------------------");
                    }
                }
            }

            return sb.ToString();
        }
    }
}
