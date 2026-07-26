using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmRemoveStudent : Form
    {
        private string _connectionString;
        private string _teacherName; // اسم الشيخ الحالي
        private int _studentIdToRemove = -1; // هوية الطالب المراد إزالته

        public frmRemoveStudent(string dbConnectionString, string teacherName)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _teacherName = teacherName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string regNumber = txtSearchRegNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(regNumber))
            {
                MessageBox.Show("الرجاء إدخال رقم القيد للبحث.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // البحث عن طالب برقم القيد والتأكد من أنه يتبع للشيخ الحالي
                    string query = "SELECT ID, FullName FROM Students WHERE RegistrationNumber = @RegNumber AND TeacherName = @TeacherName";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@RegNumber", regNumber);
                    da.SelectCommand.Parameters.AddWithValue("@TeacherName", _teacherName);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        _studentIdToRemove = Convert.ToInt32(row["ID"]);

                        lblStudentName.Text = row["FullName"].ToString();

                        // تفعيل الواجهة
                        grpStudentInfo.Enabled = true;
                        btnRemove.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على طالب بهذا الرقم في حسابك.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن الطالب: \n" + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_studentIdToRemove == -1) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من إزالة الطالب '{lblStudentName.Text}' من حسابك؟", "تأكيد الإزالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(_connectionString))
                    {
                        con.Open();
                        // إزالة اسم الشيخ من سجل الطالب (جعله NULL)
                        string query = "UPDATE Students SET TeacherName = NULL WHERE ID = @StudentID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StudentID", _studentIdToRemove);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("تم إزالة الطالب من حسابك بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء إزالة الطالب: \n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// إعادة تعيين النموذج إلى حالته الأولية
        /// </summary>
        private void ResetForm()
        {
            lblStudentName.Text = "---";
            grpStudentInfo.Enabled = false;
            btnRemove.Enabled = false;
            _studentIdToRemove = -1;
        }
    }
}
