using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmChangePassword_A : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private int _userId;

        public frmChangePassword_A(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // 1. استلام المدخلات وتجهيزها
            string currentPass = txtCurrentPassword.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            // 2. التحقق من المدخلات قبل الإرسال
            if (string.IsNullOrWhiteSpace(currentPass) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("كلمة المرور الجديدة وتأكيدها غير متطابقين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass == "0000")
            {
                MessageBox.Show("لا يمكنك استخدام كلمة المرور الافتراضية مرة أخرى لأسباب أمنية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. معالجة البيانات عبر SQL
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ChangeUserPassword", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // نرسل النصوص كما هي (Raw) لأن SQL سيتولى التشفير
                        cmd.Parameters.AddWithValue("@UserId", _userId);
                        cmd.Parameters.AddWithValue("@CurrentRawPassword", currentPass);
                        cmd.Parameters.AddWithValue("@NewRawPassword", newPass);

                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && Convert.ToInt32(result) == 1)
                        {
                            MessageBox.Show("تم تغيير كلمة المرور بنجاح! يمكنك الآن المتابعة.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; // إبلاغ شاشة الدخول بالنجاح
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("كلمة المرور الحالية التي أدخلتها غير صحيحة.", "فشل التغيير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في الاتصال: " + ex.Message, "خطأ تقني", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}