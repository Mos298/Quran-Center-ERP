using System;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmDeleteTeacher_A4 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedTeacherId = 0; // لتخزين ID المحفّظ الذي سيتم حذفه

        public frmDeleteTeacher_A4()
        {
            InitializeComponent();
        }

        private void frmDeleteTeacher_Load(object sender, EventArgs e)
        {
            LoadTeachersForAutoComplete();
        }

        private void LoadTeachersForAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
          /*  using (SqlConnection con = new SqlConnection(connectionString))
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
      */   }

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
                            lblTeacherNameValue.Text = reader["TeacherName"].ToString();
                            lblBirthDateValue.Text = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString();
                            lblResidencyValue.Text = reader["Residency"].ToString();
                            lblQualificationValue.Text = reader["Qualification"].ToString();
                            lblGenderValue.Text = reader["Gender"].ToString();
                            lblAssignmentValue.Text = reader["Assignment"].ToString();
                      //      lblRegistrationNumValue.Text = reader["RegistrationNumber"].ToString();

                            btnDelete.Enabled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedTeacherId == 0) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من حذف بيانات المحفّظ '{lblTeacherNameValue.Text}' بشكل نهائي؟ لا يمكن التراجع عن هذا الإجراء.",
                                                 "تأكيد الحذف",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // !!! هام: تأكد من أن اسم الجدول صحيح
                    string query = "DELETE FROM Teachers WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", _selectedTeacherId);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم حذف بيانات المحفّظ بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                            LoadTeachersForAutoComplete(); // لتحديث قائمة البحث
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("فشل حذف البيانات. قد يكون المحفّظ مرتبطاً بسجلات أخرى. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ClearFormFields()
        {
            _selectedTeacherId = 0;
            txtSearch.Clear();
            lblTeacherNameValue.Text = "";
            lblBirthDateValue.Text = "";
            lblResidencyValue.Text = "";
            lblQualificationValue.Text = "";
            lblGenderValue.Text = "";
            lblAssignmentValue.Text = "";
       //     lblRegistrationNumValue.Text = "";

            btnDelete.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
