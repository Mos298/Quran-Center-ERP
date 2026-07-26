using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class frmAddCenter_A : Form
    {
        // تأكد من وضع جملة الاتصال الصحيحة هنا
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private int centerId = 0;

        public frmAddCenter_A()
        {
            InitializeComponent();
            lblTitle.Text = "إضافة مركز جديد";
        }

        // Constructor للتعديل
        // تم تحديثه لاستقبال ساعات العمل كأرقام منفصلة
        public frmAddCenter_A(int id, string name, string city, string neighborhood, int teachers, int students, TimeSpan? timeFrom, TimeSpan? timeTo)
        {
            InitializeComponent();
            lblTitle.Text = "تعديل بيانات المركز";
            this.centerId = id;

            // تعبئة البيانات
            textBox3.Text = name;       // CenterName
            textBox2.Text = city;       // City
            textBox1.Text = neighborhood; // Neighborhood (المحلة)
         //   numTeachers.Value = teachers;
          //  numStudents.Value = students;

            // تعيين الأوقات
            if (timeFrom.HasValue)
                numericUpDown1.Value = timeFrom.Value.Hours; // من

            if (timeTo.HasValue)
                numericUpDown2.Value = timeTo.Value.Hours;   // إلى
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من المدخلات
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المركز.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("الرجاء إدخال المدينة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("الرجاء إدخال المحلة/الحي.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            // 2. الحفظ
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                if (centerId == 0)
                    cmd.CommandText = "sp_AddCenter";
                else
                {
                    cmd.CommandText = "sp_UpdateCenter";
                    cmd.Parameters.AddWithValue("@CenterId", centerId);
                }

                // إضافة الباراميترز حسب قاعدة البيانات QuranCenterDB
                cmd.Parameters.AddWithValue("@CenterName", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@City", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Neighborhood", textBox1.Text.Trim()); // لاحظ الاسم Neighborhood
           //     cmd.Parameters.AddWithValue("@TeacherCount", (int)numTeachers.Value);
            //    cmd.Parameters.AddWithValue("@StudentCount", (int)numStudents.Value);

                // تحويل الأرقام (الساعات) إلى صيغة TimeSpan ليقبلها عمود Time(0) في SQL
                TimeSpan tsFrom = new TimeSpan((int)numericUpDown1.Value, 0, 0);
                TimeSpan tsTo = new TimeSpan((int)numericUpDown2.Value, 0, 0);

                cmd.Parameters.AddWithValue("@WorkingHoursFrom", tsFrom);
                cmd.Parameters.AddWithValue("@WorkingHoursTo", tsTo);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم حفظ البيانات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // أحداث لا نحتاجها حالياً
        private void lblCity_Click(object sender, EventArgs e) { }
    }
}