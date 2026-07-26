using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A; // تأكد من استدعاء الـ Namespace الذي يحتوي على Session

namespace النظام_النهائي
{
    public partial class loginA : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public loginA()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        // =========================================================
        // 1. أحداث التنقل (Enter Key)
        // =========================================================
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.PerformClick();
            }
        }

        // =========================================================
        // 2. حدث تسجيل الدخول (تم التعديل هنا)
        // =========================================================
        public void button1_Click(object sender, EventArgs e)
        {
            string regNum = textBox1.Text.Trim();
            string plainPassword = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(regNum) || regNum == "رقم القيد" || string.IsNullOrEmpty(plainPassword) || plainPassword == "كلمة المرور")
            {
                MessageBox.Show("الرجاء إدخال البيانات كاملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // 1. التحقق من المستخدم الأساسي
                    using (SqlCommand cmd = new SqlCommand("sp_LoginUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RegistrationNumber", regNum);
                        cmd.Parameters.AddWithValue("@RawPassword", plainPassword);

                        // متغيرات لحفظ البيانات مؤقتاً
                        int dbId = 0;
                        string dbName = "";
                        string dbType = "";
                        bool isInitialChanged = false;
                        bool loginSuccess = false;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                loginSuccess = true;
                                dbId = Convert.ToInt32(reader["UserId"]);
                                dbName = reader["FullName"].ToString();
                                dbType = reader["UserType"].ToString();
                                isInitialChanged = Convert.ToBoolean(reader["InitialPasswordChanged"]);
                            }
                        } // إغلاق الـ Reader هنا ضروري جداً للسماح باستعلامات أخرى بنفس الاتصال

                        if (loginSuccess)
                        {
                            // --- تعبئة بيانات الجلسة (Session) ---
                            Session.CurrentUserId = dbId;
                            Session.CurrentUserName = regNum; // رقم القيد كاسم مستخدم
                            Session.CurrentFullName = dbName; // الاسم الكامل للعرض
                            Session.CurrentUserType = dbType;

                            // تنظيف البيانات الإضافية السابقة لضمان عدم التداخل
                            Session.CurrentTeacherId = null;
                            Session.CurrentCenterId = null;

                            // --- جلب بيانات إضافية حسب الدور ---
                            if (dbType == "Teacher")
                            {
                                // جلب رقم المركز الخاص بالمعلم
                                using (SqlCommand cmdTeacher = new SqlCommand("SELECT CenterId FROM Teachers WHERE UserId = @UserId", con))
                                {
                                    cmdTeacher.Parameters.AddWithValue("@UserId", dbId);
                                    object result = cmdTeacher.ExecuteScalar();

                                    // في تصميمنا، UserId هو نفسه TeacherId في جدول التوصيل
                                    Session.CurrentTeacherId = dbId;

                                    if (result != null && result != DBNull.Value)
                                    {
                                        Session.CurrentCenterId = Convert.ToInt32(result);
                                    }
                                }
                            }
                            // يمكن إضافة شروط أخرى هنا (مثلاً للطالب Student) مستقبلاً

                            // --- التحقق من تغيير كلمة المرور ---
                            if (isInitialChanged == false)
                            {
                                MessageBox.Show($"مرحباً {dbName}. يجب تغيير كلمة المرور الافتراضية (0000) قبل المتابعة.", "تنبيه أمان", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                frmChangePassword_A frm = new frmChangePassword_A(dbId);
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    RedirectUser(dbType, dbId);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"تم الدخول بنجاح! مرحباً {dbName}", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RedirectUser(dbType, dbId);
                            }
                        }
                        else
                        {
                            MessageBox.Show("رقم القيد أو كلمة المرور غير صحيحة", "فشل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ تقني: " + ex.Message, "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // 3. التوجيه
        // =========================================================
        public void RedirectUser(string userType, int userId)
        {
            this.Hide();
            Form targetForm = null;

            switch (userType)
            {
                case "Teacher":
                    targetForm = new Form_D(); // شاشة المعلم
                    break;
                case "Student":
                    targetForm = new Form_C(); // شاشة الطالب
                    break;
                case "Supervisor":
                    targetForm = new Form_B(); // شاشة المشرف
                    break;
                case "Mentor":
                    targetForm = new Form_C();
                    break;
                case "DataEntry":
                case "Admin":
                    targetForm = new Form_A(); // شاشة الأدمن/مدخل البيانات
                    break;
                default:
                    MessageBox.Show("نوع المستخدم غير معروف في النظام.");
                    this.Show();
                    return;
            }

            if (targetForm != null)
            {
                targetForm.ShowDialog();
                Application.Exit();
            }
        }

        // =========================================================
        // 4. جماليات الواجهة
        // =========================================================
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "رقم القيد")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "كلمة المرور")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "كلمة المرور";
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = '\0';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "كلمة المرور")
            {
                textBox2.PasswordChar = (textBox2.PasswordChar == '*') ? '\0' : '*';
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 25;
                Rectangle rect = new Rectangle(0, 0, panel2.Width - 1, panel2.Height - 1);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panel2.Region = new Region(path);
            }
        }
    }
}