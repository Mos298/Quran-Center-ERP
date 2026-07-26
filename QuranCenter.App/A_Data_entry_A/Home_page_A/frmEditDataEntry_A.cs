using System;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditDataEntry_A : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int _selectedClerkId = 0; // لتخزين ID الموظف الذي سيتم تعديله

        public frmEditDataEntry_A()
        {
            InitializeComponent();
        }

        private void frmEditDataEntry_Load(object sender, EventArgs e)
        {
            LoadClerksForAutoComplete();
        }

        private void LoadClerksForAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
       /*     using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT FullName, RegistrationNumber FROM DataEntryClerks";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            autoCompleteCollection.Add(reader["FullName"].ToString());
                            autoCompleteCollection.Add(reader["RegistrationNumber"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل قائمة الموظفين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
    */    }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT * FROM DataEntryClerks WHERE FullName = @SearchTerm OR RegistrationNumber = @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                   
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            _selectedClerkId = Convert.ToInt32(reader["ID"]);
                            txtFullName.Text = reader["FullName"].ToString();
                            dtpBirthDate.Value = Convert.ToDateTime(reader["BirthDate"]);
                            txtQualification.Text = reader["Qualification"].ToString();
                            cmbGender.SelectedItem = reader["Gender"].ToString();
                            txtDepartment.Text = reader["Department"].ToString();
                            txtPosition.Text = reader["Position"].ToString();
                            txtRegistrationNum.Text = reader["RegistrationNumber"].ToString();
                            txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                            txtNationalId.Text = reader["NationalID"].ToString();

                            pnlMain.Enabled = true;
                            btnSave.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على موظف بهذا الاسم أو رقم القيد.", "غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل البحث عن الموظف. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedClerkId == 0) return;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtNationalId.Text))
            {
                MessageBox.Show("الرجاء التأكد من ملء حقلي الاسم والرقم الوطني.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = @"UPDATE DataEntryClerks SET 
                                FullName = @FullName, 
                                BirthDate = @BirthDate, 
                                Qualification = @Qualification, 
                                Gender = @Gender, 
                                Department = @Department, 
                                PhoneNumber = @PhoneNumber, 
                                NationalID = @NationalID 
                                WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", _selectedClerkId);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@NationalID", txtNationalId.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث بيانات الموظف بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحديث البيانات. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFormFields()
        {
            
            _selectedClerkId = 0;
            txtFullName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            txtQualification.Clear();
            cmbGender.SelectedIndex = -1;
            txtDepartment.Clear();
            txtRegistrationNum.Clear();
            txtPhoneNumber.Clear();
            txtNationalId.Clear();

            pnlMain.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
