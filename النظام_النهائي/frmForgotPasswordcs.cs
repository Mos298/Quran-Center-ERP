using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmForgotPasswordcs : Form
    {
        // !!! هام: يجب تغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmForgotPasswordcs()
        {
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = GetPasswordForUser(txtUsername.Text);

            if (password != null)
            {
                lblResult.Visible = true;
                txtPasswordResult.Text = password;
                txtPasswordResult.Visible = true;
            }
            else
            {
                MessageBox.Show("اسم المستخدم غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResult.Visible = false;
                txtPasswordResult.Visible = false;
            }
        }

        private string GetPasswordForUser(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: استبدل 'Users' باسم جدول المستخدمين
                // و 'Password' باسم حقل كلمة المرور
                // و 'Username' باسم حقل اسم المستخدم
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar(); // يرجع قيمة واحدة فقط

                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " + ex.Message);
                    }
                }
            }
            return null; // إرجاع null إذا لم يتم العثور على المستخدم
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
