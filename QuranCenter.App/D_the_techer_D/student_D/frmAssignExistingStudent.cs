using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmAssignExistingStudent : Form
    {
        private string _connectionString;
        private string _currentTeacherName; // لتخزين اسم الشيخ الحالي
        private int _foundStudentId = -1; // لتخزين هوية الطالب بعد البحث

        public frmAssignExistingStudent(string dbConnectionString, string currentTeacherName)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _currentTeacherName = currentTeacherName;
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
                    // البحث عن طالب برقم القيد بشرط ألا يكون مسجلاً مع معلم آخر
                    string query = "SELECT ID, FullName FROM Students WHERE RegistrationNumber = @RegNumber AND (TeacherName IS NULL OR TeacherName = '')";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@RegNumber", regNumber);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        _foundStudentId = Convert.ToInt32(row["ID"]);
                        lblStudentName.Text = row["FullName"].ToString();

                        // تفعيل حقول عرض البيانات وزر الإضافة
                        grpStudentInfo.Enabled = true;
                        btnAssign.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على طالب بهذا الرقم، أو أن الطالب مسجل مع شيخ آخر.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpStudentInfo.Enabled = false;
                        btnAssign.Enabled = false;
                        _foundStudentId = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن الطالب: \n" + ex.Message);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (_foundStudentId == -1) return; // تأكيد وجود طالب للإضافة

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // تحديث بيانات الطالب لربطه بالشيخ الحالي
                    string query = "UPDATE Students SET TeacherName = @TeacherName WHERE ID = @StudentID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TeacherName", _currentTeacherName);
                    cmd.Parameters.AddWithValue("@StudentID", _foundStudentId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"تم إضافة الطالب '{lblStudentName.Text}' إلى حسابك بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // إشارة للنموذج الرئيسي بأن الإضافة تمت
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إضافة الطالب: \n" + ex.Message);
            }
        }
    }
}
