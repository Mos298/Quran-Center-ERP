using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;   // مهم: للاتصال بقاعدة البيانات
using System.Data;
using System.Data.SqlClient;  // مهم: للتعامل مع SQL
using System.Drawing;
using System.IO;              // مهم: للتعامل مع ملفات الصور
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A;
using النظام_النهائي.B_Supervisors_B.Home_page_B;

namespace النظام_النهائي
{
    public partial class Form_B : Form
    {
        // 1. تعريف جملة الاتصال
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Form_B()
        {
            InitializeComponent();

            // تحميل الصفحة الرئيسية بشكل افتراضي
            LoadUserControl(new home_B());

            // 2. استدعاء دالة عرض بيانات المشرف (الاسم والصورة) فور تشغيل الفورم
            LoadHeaderUserInfo();
        }

        // --- دالة جديدة لجلب بيانات المشرف وعرضها في Form_B ---
        private void LoadHeaderUserInfo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // جلب الاسم والصورة بناءً على الـ ID المحفوظ في الجلسة
                    string query = "SELECT FullName, ProfileImage FROM Users WHERE UserId = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", Session.CurrentUserId); // نستخدم الـ ID من كلاس Session

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // عرض الاسم
                                if (userNameLabel != null) // نتأكد أن الليبل موجود لتجنب الأخطاء
                                    userNameLabel.Text = reader["FullName"].ToString();

                                // عرض الصورة
                                string imagePath = reader["ProfileImage"] != DBNull.Value ? reader["ProfileImage"].ToString() : "";

                                if (userAvatar != null) // نتأكد أن الـ PictureBox موجود
                                {
                                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                    {
                                        userAvatar.Image = Image.FromFile(imagePath);
                                    }
                                    else
                                    {
                                        // يمكن وضع صورة افتراضية هنا إذا لم توجد صورة
                                        // userAvatar.Image = Properties.Resources.DefaultUserImage;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات المستخدم: " + ex.Message);
            }
        }

        // --- دالة التنقل بين الواجهات ---
        private void LoadUserControl(UserControl userControl)
        {
            // اجعل الواجهة تملأ اللوحة بالكامل
            userControl.Dock = DockStyle.Fill;
            // نظّف اللوحة من أي محتوى قديم
            mainContentPanel.Controls.Clear();
            // أضف الواجهة الجديدة لعرضها
            mainContentPanel.Controls.Add(userControl);
        }

        // --- بقية الأزرار ---

        private void Form_C_Load(object sender, EventArgs e)
        {
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new student_C());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LoadUserControl(new tracking_C());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new eductional_level_C());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // LoadUserControl(new the_report_C());
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new centerl_user_B());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // LoadUserControl(new the_report_E());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new home_B());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close(); // زر الخروج
                          // يمكنك إضافة كود لإظهار شاشة تسجيل الدخول مرة أخرى
            new loginA().Show();
        }
    }
}