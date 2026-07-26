using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
// تأكد من اسم النيم سبيس الصحيح لمشروعك
using النظام_النهائي.A_Data_entry_A; 

namespace النظام_النهائي
{
    public partial class center : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // 1. تعريف نص الاتصال


        public event EventHandler<Image> PictureChanged;

        public center()
        {
            InitializeComponent();
            
            // ================================================================
            // الحل النهائي: ربط الحدث يدوياً هنا
            // ================================================================
            this.Load += center_Load;
        }

        private void center_Load(object sender, EventArgs e)
        {
            // رسالة فحص: هل اشتغل الكود؟
            // 1. جلب الرقم من الـ Session
            int userId = Session.CurrentUserId;

            // للتجربة والفحص:
            // MessageBox.Show("رقم المستخدم الحالي هو: " + userId);

            if (userId == 0) return;

            // 2. استدعاء دالة جلب البيانات
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_GetUserDetails", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@UserId", userId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // تعبئة البيانات
                                    lblSupervisorNameValue.Text = reader["FullName"].ToString();
                                    lblSupervisorIdValue.Text = reader["RegistrationNumber"].ToString();
                                    lblSupervisorGenderValue.Text = reader["Gender"].ToString();
                                    lblCenterPhoneValue.Text = reader["PhoneNumber"].ToString();

                                    lblCenterEmailValue.Text = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                                    // تأكد من اسم الليبل الخاص بالمدينة عندك
                                    label1.Text = reader["City"] != DBNull.Value ? reader["City"].ToString() : "";

                                    if (reader["BirthDate"] != DBNull.Value)
                                        lblSupervisorDobValue.Text = Convert.ToDateTime(reader["BirthDate"]).ToString("yyyy/MM/dd");
                                    else
                                        lblSupervisorDobValue.Text = "---";

                                    lblSupervisorDeptValue.Text = reader["Department"] != DBNull.Value ? reader["Department"].ToString() : "---";
                                    lblSupervisorPositionValue.Text = reader["Position"] != DBNull.Value ? reader["Position"].ToString() : "---";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ: " + ex.Message);
                }
                // MessageBox.Show("جاري تحميل البيانات... رقم المستخدم: " + Session.CurrentUserId);

            }
        }
        private void LoadUserData(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetUserDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // تعبئة البيانات
                                lblSupervisorNameValue.Text = reader["FullName"].ToString();
                                lblSupervisorIdValue.Text = reader["RegistrationNumber"].ToString();
                                lblSupervisorGenderValue.Text = reader["Gender"].ToString();
                                lblCenterPhoneValue.Text = reader["PhoneNumber"].ToString();

                                lblCenterEmailValue.Text = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                                // تأكد من اسم الليبل الخاص بالمدينة عندك
                                label1.Text = reader["City"] != DBNull.Value ? reader["City"].ToString() : "";

                                if (reader["BirthDate"] != DBNull.Value)
                                    lblSupervisorDobValue.Text = Convert.ToDateTime(reader["BirthDate"]).ToString("yyyy/MM/dd");
                                else
                                    lblSupervisorDobValue.Text = "---";

                                lblSupervisorDeptValue.Text = reader["Department"] != DBNull.Value ? reader["Department"].ToString() : "---";
                                lblSupervisorPositionValue.Text = reader["Position"] != DBNull.Value ? reader["Position"].ToString() : "---";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }
        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var selectedImage = new Bitmap(openFileDialog.FileName);
                        PictureChanged?.Invoke(this, selectedImage);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddDataEntry_A frmAddDataEntry_A = new frmAddDataEntry_A();
            frmAddDataEntry_A.ShowDialog();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            frmEditDataEntry_A frmEditDataEntry_A = new frmEditDataEntry_A();
            frmEditDataEntry_A.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPrintDataEntry_A frmPrintDataEntry_A = new frmPrintDataEntry_A();
            frmPrintDataEntry_A.ShowDialog();
        }
    }
}