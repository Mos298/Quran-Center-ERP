using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmDeleteSupervisor_A2 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedSupervisorId = 0; // لتخزين ID المشرف الذي تم اختياره

        public frmDeleteSupervisor_A2()
        {
            InitializeComponent();
        }

        private void frmDeleteSupervisor_Load(object sender, EventArgs e)
        {
            LoadSupervisorNamesForAutoComplete();
        }

        private void LoadSupervisorNamesForAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            /*  using (SqlConnection con = new SqlConnection(connectionString))
              {
                  string query = "SELECT SupervisorName, RegistrationNumber FROM Supervisors";
                  using (SqlCommand cmd = new SqlCommand(query, con))
                  {
                      try
                      {
                          con.Open();
                          SqlDataReader reader = cmd.ExecuteReader();
                          while (reader.Read())
                          {
                              autoCompleteCollection.Add(reader["SupervisorName"].ToString());
                              autoCompleteCollection.Add(reader["RegistrationNumber"].ToString());
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("فشل تحميل قائمة المشرفين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                  }
             }
              txtSearch.AutoCompleteCustomSource = autoCompleteCollection;
          }
  */
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Supervisors WHERE SupervisorName = @SearchTerm OR RegistrationNumber = @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            _selectedSupervisorId = Convert.ToInt32(reader["ID"]);
                            lblSupervisorNameValue.Text = reader["SupervisorName"].ToString();
                            lblBirthDateValue.Text = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString();
                            lblResidencyValue.Text = reader["Residency"].ToString();
                            lblQualificationValue.Text = reader["Qualification"].ToString();
                            lblGenderValue.Text = reader["Gender"].ToString();
                            lblAssignmentValue.Text = reader["Assignment"].ToString();
                            lblRegistrationNumValue.Text = reader["RegistrationNumber"].ToString();

                            btnDelete.Enabled = true; // تفعيل زر الحذف
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على مشرف بهذا الاسم أو رقم القيد.", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearLabels();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل البحث عن المشرف. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSupervisorId == 0) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من حذف بيانات المشرف '{lblSupervisorNameValue.Text}' بشكل نهائي؟",
                                                 "تأكيد عملية الحذف",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Supervisors WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", _selectedSupervisorId);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم حذف بيانات المشرف بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("فشل حذف البيانات. قد يكون المشرف مرتبطاً ببيانات أخرى. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ClearLabels()
        {
            _selectedSupervisorId = 0;
            lblSupervisorNameValue.Text = "";
            lblBirthDateValue.Text = "";
            lblResidencyValue.Text = "";
            lblQualificationValue.Text = "";
            lblGenderValue.Text = "";
            lblAssignmentValue.Text = "";
            lblRegistrationNumValue.Text = "";
            btnDelete.Enabled = false;
        }

        private void ClearForm()
        {
            txtSearch.Clear();
            ClearLabels();
            LoadSupervisorNamesForAutoComplete(); // إعادة تحميل الأسماء في حال تغيرها
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAssignmentValue_Click(object sender, EventArgs e)
        {

        }
    }
}
