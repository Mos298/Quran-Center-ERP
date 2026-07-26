using System;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditTeacher_A4 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedTeacherId = 0; // لتخزين ID المحفّظ الذي سيتم تعديله

        public frmEditTeacher_A4()
        {
            InitializeComponent();
        }

        private void frmEditTeacher_Load(object sender, EventArgs e)
        {
            LoadTeachersForAutoComplete();
        }

        private void LoadTeachersForAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
       /*     using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT TeacherName, RegistrationNumber FROM Teachers";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            autoCompleteCollection.Add(reader["TeacherName"].ToString());
                            autoCompleteCollection.Add(reader["RegistrationNumber"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل قائمة المحفظين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            txtSearch.AutoCompleteCustomSource = autoCompleteCollection;
  */      }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT * FROM Teachers WHERE TeacherName = @SearchTerm OR RegistrationNumber = @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            _selectedTeacherId = Convert.ToInt32(reader["ID"]);
                            txtTeacherName.Text = reader["TeacherName"].ToString();
                            dtpBirthDate.Value = Convert.ToDateTime(reader["BirthDate"]);
                       /*     txtResidency.Text = reader["Residency"].ToString();
                            txtQualification.Text = reader["Qualification"].ToString();
                            cmbGender.SelectedItem = reader["Gender"].ToString();
                            txtAssignment.Text = reader["Assignment"].ToString();
                            txtRegistrationNum.Text = reader["RegistrationNumber"].ToString();
                       */
                            pnlMain.Enabled = true;
                            btnSaveChanges.Enabled = true;
                            btnResetPassword.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على محفّظ بهذا الاسم أو رقم القيد.", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل البحث عن المحفّظ. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == 0) return;

         /*   if (string.IsNullOrWhiteSpace(txtTeacherName.Text) || string.IsNullOrWhiteSpace(txtRegistrationNum.Text) || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         */
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = @"UPDATE Teachers SET 
                                TeacherName = @TeacherName, 
                                BirthDate = @BirthDate, 
                                Residency = @Residency, 
                                Qualification = @Qualification, 
                                Gender = @Gender, 
                                Assignment = @Assignment, 
                                RegistrationNumber = @RegistrationNumber 
                                WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", _selectedTeacherId);
                    cmd.Parameters.AddWithValue("@TeacherName", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
               /*     cmd.Parameters.AddWithValue("@Residency", txtResidency.Text);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Assignment", txtAssignment.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", txtRegistrationNum.Text);
               */
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات المحفّظ بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields();
                        LoadTeachersForAutoComplete(); // لتحديث قائمة البحث
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحديث البيانات. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == 0) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من إعادة تعيين كلمة المرور للمحفّظ '{txtTeacherName.Text}' إلى '0000'؟",
                                                 "تأكيد إعادة التعيين",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // !!! هام: تأكد من أن اسم الجدول صحيح
                    string query = "UPDATE Teachers SET Password = '0000' WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", _selectedTeacherId);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم إعادة تعيين كلمة المرور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("فشل إعادة تعيين كلمة المرور. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ClearFormFields()
        {
            _selectedTeacherId = 0;
            txtSearch.Clear();
            txtTeacherName.Clear();
            dtpBirthDate.Value = DateTime.Now;
        /*    txtResidency.Clear();
            txtQualification.Clear();
            cmbGender.SelectedIndex = -1;
            txtAssignment.Clear();
            txtRegistrationNum.Clear();
        */
            pnlMain.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnResetPassword.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
