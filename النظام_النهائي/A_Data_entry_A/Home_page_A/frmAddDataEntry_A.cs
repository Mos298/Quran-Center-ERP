using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmAddDataEntry_A : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmAddDataEntry_A()
        {
            InitializeComponent();
        }

        private void frmAddDataEntry_Load(object sender, EventArgs e)
        {
            GenerateRegistrationNumber();
        }

        private void GenerateRegistrationNumber()
        {
            // !!! هام: قم بتعديل هذه الأكواد لتناسب نظام الترميز في منظمتك
            string yearCode = DateTime.Now.ToString("yy"); // آخر رقمين من السنة الحالية
            string cityCode = "06"; // مثال: كود المدينة
            string positionCode = "11"; // مثال: كود منصب "مدخل بيانات"

            string prefix = yearCode + cityCode + positionCode;
            int lastSequence = 0;

        /*    using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن اسم الجدول والعمود صحيح
                string query = "SELECT TOP 1 RegistrationNumber FROM DataEntryClerks WHERE RegistrationNumber LIKE @Prefix ORDER BY RegistrationNumber DESC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // استخلاص الرقم التسلسلي الأخير من رقم القيد الكامل
                            string lastRegNum = result.ToString();
                            lastSequence = int.Parse(lastRegNum.Substring(prefix.Length));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل في توليد رقم القيد. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
           }

            // زيادة الرقم التسلسلي وإنشاء الرقم الجديد
            int newSequence = lastSequence + 1;
            txtRegistrationNum.Text = prefix + newSequence.ToString("D4"); // D4 تضمن وجود 4 أرقام مثل 0001
      */    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من أن الحقول الأساسية ليست فارغة
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtNationalId.Text) ||
                cmbGender.SelectedItem == null)
            {
                MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة تطابق قاعدة بياناتك
                string query = @"INSERT INTO DataEntryClerks 
                                (FullName, BirthDate, Qualification, Gender, Department, Position, RegistrationNumber, PhoneNumber, NationalID) 
                                VALUES 
                                (@FullName, @BirthDate, @Qualification, @Gender, @Department, @Position, @RegistrationNumber, @PhoneNumber, @NationalID)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // استخدام Parameters لحماية قاعدة البيانات
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", txtRegistrationNum.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@NationalID", txtNationalId.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حفظ بيانات مدخل البيانات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل حفظ البيانات. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
