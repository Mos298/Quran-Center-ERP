using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditMentor_A3 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedMentorId = 0; // لتخزين ID الموجه الذي يتم تعديله

        public frmEditMentor_A3()
        {
            InitializeComponent();
        }

        private void frmEditMentor_Load(object sender, EventArgs e)
        {
            LoadMentorsForAutoComplete();
        }

        private void LoadMentorsForAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
         /*   using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT MentorName, RegistrationNumber FROM Mentors";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            autoCompleteCollection.Add(reader["MentorName"].ToString());
                            autoCompleteCollection.Add(reader["RegistrationNumber"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل قائمة الموجهين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            txtSearch.AutoCompleteCustomSource = autoCompleteCollection;
   */     }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT * FROM Mentors WHERE MentorName = @SearchTerm OR RegistrationNumber = @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            _selectedMentorId = Convert.ToInt32(reader["ID"]);
                            txtMentorName.Text = reader["MentorName"].ToString();
                            dtpBirthDate.Value = Convert.ToDateTime(reader["BirthDate"]);
                            txtResidency.Text = reader["Residency"].ToString();
                            txtQualification.Text = reader["Qualification"].ToString();
                            cmbGender.SelectedItem = reader["Gender"].ToString();
                            txtAssignment.Text = reader["Assignment"].ToString();
                            txtRegistrationNum.Text = reader["RegistrationNumber"].ToString();

                            btnSave.Enabled = true;
                            btnResetPassword.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على موجه بهذا الاسم أو رقم القيد.", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل البحث عن الموجه. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedMentorId == 0) return;

            if (string.IsNullOrWhiteSpace(txtMentorName.Text) || string.IsNullOrWhiteSpace(txtRegistrationNum.Text) || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = @"UPDATE Mentors SET 
                                MentorName = @MentorName, 
                                BirthDate = @BirthDate, 
                                Residency = @Residency, 
                                Qualification = @Qualification, 
                                Gender = @Gender, 
                                Assignment = @Assignment, 
                                RegistrationNumber = @RegistrationNumber 
                                WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MentorName", txtMentorName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Residency", txtResidency.Text);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Assignment", txtAssignment.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", txtRegistrationNum.Text);
                    cmd.Parameters.AddWithValue("@ID", _selectedMentorId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات الموجه بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (_selectedMentorId == 0) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من إعادة تعيين كلمة المرور للموجه '{txtMentorName.Text}' إلى '0000'؟",
                                                 "تأكيد إعادة التعيين",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                    string query = "UPDATE Mentors SET Password = '0000' WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", _selectedMentorId);
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
            _selectedMentorId = 0;
            txtMentorName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            txtResidency.Clear();
            txtQualification.Clear();
            cmbGender.SelectedIndex = -1;
            txtAssignment.Clear();
            txtRegistrationNum.Clear();
            btnSave.Enabled = false;
            btnResetPassword.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
