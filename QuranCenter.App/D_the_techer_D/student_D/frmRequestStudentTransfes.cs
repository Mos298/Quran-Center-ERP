using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي.D_the_techer_D.student_D
{
    public partial class frmRequestStudentTransfer : Form
    {
        private string _connectionString;
        private string _teacherName;
        private string _teacherRegNumber;
        private int _foundStudentId = -1; // لتخزين هوية الطالب بعد البحث

        public frmRequestStudentTransfer(string dbConnectionString, string teacherName, string teacherRegNumber)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _teacherName = teacherName;
            _teacherRegNumber = teacherRegNumber;
        }

        private void frmRequestStudentTransfer_Load(object sender, EventArgs e)
        {
            // تعبئة بيانات الشيخ تلقائياً
            txtTeacherName.Text = _teacherName;
            txtTeacherRegNumber.Text = _teacherRegNumber;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string studentRegNumber = txtStudentRegNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentRegNumber))
            {
                MessageBox.Show("الرجاء إدخال رقم قيد الطالب للبحث.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    da.SelectCommand.Parameters.AddWithValue("@RegNumber", studentRegNumber);
                    da.SelectCommand.Parameters.AddWithValue("@TeacherName", _teacherName);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        _foundStudentId = Convert.ToInt32(row["ID"]);
                        txtStudentName.Text = row["FullName"].ToString();

                        // تفعيل واجهة كتابة الطلب
                        grpRequestDetails.Enabled = true;
                        btnSubmitRequest.Enabled = true;
                        MessageBox.Show("تم العثور على الطالب. يمكنك الآن كتابة طلب النقل.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على طالب بهذا الرقم في حسابك.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن الطالب: \n" + ex.Message);
            }
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (_foundStudentId == -1 || string.IsNullOrWhiteSpace(txtRequestDetails.Text))
            {
                MessageBox.Show("الرجاء التأكد من العثور على طالب وكتابة تفاصيل طلب النقل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // حفظ الطلب في جدول الإشعارات أو الطلبات
                    // نفترض وجود جدول 'Requests'
                    string query = "INSERT INTO Requests (RequestType, Status, SubjectName, InitiatorName, RequestDate, Details) VALUES (@Type, @Status, @Subject, @Initiator, @Date, @Details)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Type", "StudentTransfer");
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.Parameters.AddWithValue("@Subject", "الطالب: " + txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@Initiator", "الشيخ: " + _teacherName);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Details", txtRequestDetails.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم إرسال طلب النقل بنجاح. سيتم مراجعته من قبل الإدارة.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إرسال الطلب: \n" + ex.Message);
            }
        }

        private void ResetForm()
        {
            txtStudentName.Clear();
            _foundStudentId = -1;
            grpRequestDetails.Enabled = false;
            btnSubmitRequest.Enabled = false;
        }
    }
}

