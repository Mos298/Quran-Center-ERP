using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditStudent_s : Form
    {
        private string connectionString;
        private int _studentIdToEdit = -1; // لتخزين هوية الطالب بعد البحث

        public frmEditStudent_s(string dbConnectionString)
        {
            InitializeComponent();
            connectionString = dbConnectionString;
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
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Students WHERE RegistrationNumber = @RegNumber";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@RegNumber", regNumber);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        _studentIdToEdit = Convert.ToInt32(row["ID"]);

                        // تعبئة حقول النموذج بالبيانات
                        txtFullName.Text = row["FullName"].ToString();
                        txtGuardianName.Text = row["GuardianName"].ToString();
                        dtpBirthDate.Value = Convert.ToDateTime(row["BirthDate"]);
                        txtTeacherName.Text = row["TeacherName"].ToString();
                        cboNationality.SelectedItem = row["Nationality"].ToString();
                        txtResidence.Text = row["Residence"].ToString();
                        cboGender.SelectedItem = row["Gender"].ToString();
                        txtNationalId.Text = row["NationalID"].ToString();
                        txtStudentPhone.Text = row["StudentPhone"].ToString();
                        txtGuardianPhone.Text = row["GuardianPhone"].ToString();

                        // كما طلبت، لا يتم تحميل أي ملاحظات من قاعدة البيانات
                        txtNotes.Clear();

                        // تفعيل حقول التعديل وأزرار التحكم
                        grpStudentData.Enabled = true;
                        btnSave.Enabled = true;
                        btnResetPassword.Enabled = true; // تفعيل زر إعادة التعيين
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على طالب بهذا الرقم.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpStudentData.Enabled = false;
                        btnSave.Enabled = false;
                        btnResetPassword.Enabled = false; // تعطيل زر إعادة التعيين
                        _studentIdToEdit = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن الطالب: \n" + ex.Message);
            }
        }

        private void cboNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNationality.SelectedItem != null && cboNationality.SelectedItem.ToString() == "ليبي/ة")
            {
                lblNationalId.Text = "الرقم الوطني:";
            }
            else
            {
                lblNationalId.Text = "رقم جواز السفر:";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_studentIdToEdit == -1) return;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtNationalId.Text))
            {
                MessageBox.Show("الرجاء التأكد من تعبئة جميع الحقول الأساسية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"UPDATE Students SET 
                                        FullName = @FullName, GuardianName = @GuardianName, BirthDate = @BirthDate, 
                                        TeacherName = @TeacherName, Nationality = @Nationality, Residence = @Residence, 
                                        Gender = @Gender, NationalID = @NationalID, StudentPhone = @StudentPhone, 
                                        GuardianPhone = @GuardianPhone, Notes = @Notes 
                                     WHERE ID = @StudentID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@GuardianName", txtGuardianName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@TeacherName", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@Nationality", cboNationality.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Residence", txtResidence.Text);
                    cmd.Parameters.AddWithValue("@Gender", cboGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NationalID", txtNationalId.Text);
                    cmd.Parameters.AddWithValue("@StudentPhone", txtStudentPhone.Text);
                    cmd.Parameters.AddWithValue("@GuardianPhone", txtGuardianPhone.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    cmd.Parameters.AddWithValue("@StudentID", _studentIdToEdit);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تم حفظ التعديلات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ التعديلات: \n" + ex.Message);
            }
        }

        // --- دالة جديدة ---
        /// <summary>
        /// يتم استدعاؤها عند الضغط على زر إعادة تعيين كلمة المرور
        /// </summary>
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (_studentIdToEdit == -1) return;

            var confirmResult = MessageBox.Show("هل أنت متأكد من إعادة تعيين كلمة المرور لهذا الطالب إلى '0000'؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE Students SET Password = @DefaultPassword WHERE ID = @StudentID";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@DefaultPassword", "0000"); // كلمة المرور الافتراضية
                        cmd.Parameters.AddWithValue("@StudentID", _studentIdToEdit);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("تم إعادة تعيين كلمة المرور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء إعادة تعيين كلمة المرور: \n" + ex.Message);
                }
            }
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
