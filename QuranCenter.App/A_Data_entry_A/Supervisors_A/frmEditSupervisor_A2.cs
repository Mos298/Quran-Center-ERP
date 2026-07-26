using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditSupervisor_A2: Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedSupervisorId = 0; // لتخزين ID المشرف الذي تم اختياره

        public frmEditSupervisor_A2()
        {
            InitializeComponent();
        }

        private void frmEditSupervisor_Load(object sender, EventArgs e)
        {
            LoadSupervisorNamesForAutoComplete();
        }

        private void LoadSupervisorNamesForAutoComplete()
        {/*
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
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
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
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
                            txtSupervisorName.Text = reader["SupervisorName"].ToString();
                            dtpBirthDate.Value = Convert.ToDateTime(reader["BirthDate"]);
                            txtResidency.Text = reader["Residency"].ToString();
                            txtQualification.Text = reader["Qualification"].ToString();
                            cmbGender.SelectedItem = reader["Gender"].ToString();
                            txtAssignment.Text = reader["Assignment"].ToString();
                            txtRegistrationNum.Text = reader["RegistrationNumber"].ToString();

                            pnlMain.Enabled = true;
                            btnSaveChanges.Enabled = true;
                            btnResetPassword.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على مشرف بهذا الاسم أو رقم القيد.", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل البحث عن المشرف. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_selectedSupervisorId == 0) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = @"UPDATE Supervisors SET 
                                 SupervisorName = @SupervisorName, 
                                 BirthDate = @BirthDate, 
                                 Residency = @Residency, 
                                 Qualification = @Qualification, 
                                 Gender = @Gender, 
                                 Assignment = @Assignment, 
                                 RegistrationNumber = @RegistrationNumber 
                                 WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupervisorName", txtSupervisorName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Residency", txtResidency.Text);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Assignment", txtAssignment.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", txtRegistrationNum.Text);
                    cmd.Parameters.AddWithValue("@ID", _selectedSupervisorId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات المشرف بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
            if (_selectedSupervisorId == 0) return;

            var confirmResult = MessageBox.Show($"هل أنت متأكد من إعادة تعيين كلمة المرور للمشرف '{txtSupervisorName.Text}' إلى '0000'؟",
                                                 "تأكيد إعادة التعيين",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Supervisors SET Password = '0000' WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", _selectedSupervisorId);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تمت إعادة تعيين كلمة المرور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("فشل إعادة تعيين كلمة المرور. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
