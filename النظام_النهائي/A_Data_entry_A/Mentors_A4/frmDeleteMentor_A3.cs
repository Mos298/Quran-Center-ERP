using System;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmDeleteMentor_A3 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedMentorId = 0; // لتخزين ID الموجه الذي سيتم حذفه

        public frmDeleteMentor_A3()
        {
            InitializeComponent();
        }

        private void frmDeleteMentor_Load(object sender, EventArgs e)
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
      */  }

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
                            txtBirthDate.Text = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString();
                            txtResidency.Text = reader["Residency"].ToString();
                            txtQualification.Text = reader["Qualification"].ToString();
                            txtGender.Text = reader["Gender"].ToString();
                            txtAssignment.Text = reader["Assignment"].ToString();
                            txtRegistrationNum.Text = reader["RegistrationNumber"].ToString();

                            btnDelete.Enabled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMentorId == 0) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من حذف بيانات الموجه '{txtMentorName.Text}' بشكل نهائي؟",
                                                 "تأكيد الحذف",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // !!! هام: تأكد من أن اسم الجدول صحيح
                    string query = "DELETE FROM Mentors WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", _selectedMentorId);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم حذف بيانات الموجه بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                            LoadMentorsForAutoComplete(); // لتحديث قائمة البحث بعد الحذف
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("فشل حذف البيانات. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ClearFormFields()
        {
            _selectedMentorId = 0;
            txtSearch.Clear();
            txtMentorName.Clear();
            txtBirthDate.Clear();
            txtResidency.Clear();
            txtQualification.Clear();
            txtGender.Clear();
            txtAssignment.Clear();
            txtRegistrationNum.Clear();
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
