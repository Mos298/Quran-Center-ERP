using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditStudent : Form
    {
       // private Student _studentToEdit;
      //  private string _connectionString;

        public frmEditStudent()
        {
            InitializeComponent();
          //  _studentToEdit = student;
          //  _connectionString = connectionString;
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            // تعبئة الحقول ببيانات الطالب
        /*    txtFullName.Text = _studentToEdit.FullName;*/
            // ... Populate all other textboxes and controls ...
        }

        private void btnSaveAndActivate_Click(object sender, EventArgs e)
        {
          /*  try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // تحديث بيانات الطالب وتغيير حالته إلى 'Active'
                    string query = @"UPDATE Students SET 
                                        FullName = @FullName, 
                                        -- GuardianName = @GuardianName, ... etc for all fields
                                        Status = N'Active' 
                                     WHERE ID = @StudentID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    // ... Add parameters for all other fields ...
                    cmd.Parameters.AddWithValue("@StudentID", _studentToEdit.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تم تنشيط الطالب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تنشيط الطالب: \n" + ex.Message);
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
