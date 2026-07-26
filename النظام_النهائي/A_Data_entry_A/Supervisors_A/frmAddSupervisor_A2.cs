using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class frmAddSupervisor_A2 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmAddSupervisor_A2()
        {
            InitializeComponent();
            chklstTeachers.CheckOnClick = true;
        }

        private void frmAddSupervisor_A2_Load(object sender, EventArgs e)
        {
            LoadCities(); // تحميل المدن أولاً
            LoadAvailableCenters(); // تحميل المراكز
        }

        // 1. تحميل المدن (للحصول على كود المدينة)
        private void LoadCities()
        {
            // يفضل أن تكون هذه البيانات من جدول Cities في القاعدة
            // هنا مثال يدوي سريع للتجربة
            DataTable dtCities = new DataTable();
            dtCities.Columns.Add("CityName");
            dtCities.Columns.Add("CityCode");
            dtCities.Rows.Add("طرابلس", "021");
            dtCities.Rows.Add("بنغازي", "061");
            dtCities.Rows.Add("مصراتة", "051");
            dtCities.Rows.Add("البيضاء", "084");
            dtCities.Rows.Add("الزاوية", "023");
            dtCities.Rows.Add("غريان", "042");
            dtCities.Rows.Add("صبراتة", "024");
            dtCities.Rows.Add("سبها", "071");
            dtCities.Rows.Add("درنة", "081");
            dtCities.Rows.Add("طبرق", "087");
            dtCities.Rows.Add("إجدابيا", "064");
            dtCities.Rows.Add("سرت", "054");
            dtCities.Rows.Add("الخمس", "053");
            dtCities.Rows.Add("زليتن", "051");
            dtCities.Rows.Add("ترهونة", "053");
            dtCities.Rows.Add("بني وليد", "053");
            dtCities.Rows.Add("مسلاتة", "053");
            dtCities.Rows.Add("يفرن", "0421");
            dtCities.Rows.Add("نالوت", "048");
            dtCities.Rows.Add("غات", "073");
            dtCities.Rows.Add("أوباري", "073");
            dtCities.Rows.Add("مرزق", "073");
            dtCities.Rows.Add("الكفرة", "065");
            dtCities.Rows.Add("الجوف", "065");


            comboAlojamiento.DataSource = dtCities;
            comboAlojamiento.DisplayMember = "CityName";
            comboAlojamiento.ValueMember = "CityCode";
            comboAlojamiento.SelectedIndex = -1;
        }

        // 2. تحديث رقم القيد عند اختيار المدينة
        private void comboAlojamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAlojamiento.SelectedValue != null && comboAlojamiento.SelectedIndex != -1)
            {
                GenerateSmartID(comboAlojamiento.SelectedValue.ToString());
            }
        }

        private void GenerateSmartID(string cityCode)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetNextRegistrationNumber", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CityCode", cityCode);
                    cmd.Parameters.AddWithValue("@ActorCode", "02"); // كود المشرف

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        // سنفترض وجود TextBox لرقم القيد اسمه txtRegNum
                        // إذا لم يوجد، يجب إضافته في الديزاين كـ ReadOnly
                        label2.Text = result.ToString(); // عرض رقم القيد المولد
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في توليد رقم القيد: " + ex.Message); }
        }

        private void LoadAvailableCenters()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // استعلام لجلب المراكز التي ليس لها مشرف حالياً
                    string query = "SELECT CenterId, CenterName FROM Centers WHERE SupervisorId IS NULL";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    chklstTeachers.DataSource = dt;
                    chklstTeachers.DisplayMember = "CenterName";
                    chklstTeachers.ValueMember = "CenterId";
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل المراكز: " + ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من المدخلات الأساسية
            if (string.IsNullOrWhiteSpace(txtSupervisorName.Text) || comboAlojamiento.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى إدخال الاسم واختيار المدينة أولاً.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    int newSupervisorId = 0;

                    // أ) حفظ المشرف
                    using (SqlCommand cmd = new SqlCommand("sp_AddSupervisor", con, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RegNum", label2.Text);
                        cmd.Parameters.AddWithValue("@FullName", txtSupervisorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                        cmd.Parameters.AddWithValue("@NationalId", National_number.Text.Replace("-", ""));
                        cmd.Parameters.AddWithValue("@Phone", phoonTextBox1.Text);
                        cmd.Parameters.AddWithValue("@Qualification", comboAcademic_qualification.Text);
                        cmd.Parameters.AddWithValue("@Assignment", comboassignment.Text);
                        cmd.Parameters.AddWithValue("@Residency", comboAlojamiento.Text);

                        SqlParameter outId = new SqlParameter("@NewId", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        cmd.Parameters.Add(outId);

                        cmd.ExecuteNonQuery();
                        newSupervisorId = (int)outId.Value;
                    }

                    // ب) ربط المراكز المختارة
                    foreach (var item in chklstTeachers.CheckedItems)
                    {
                        DataRowView row = item as DataRowView;
                        int centerId = Convert.ToInt32(row["CenterId"]);

                        string updateQuery = "UPDATE Centers SET SupervisorId = @SupId WHERE CenterId = @CenId";
                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con, transaction))
                        {
                            cmdUpdate.Parameters.AddWithValue("@SupId", newSupervisorId);
                            cmdUpdate.Parameters.AddWithValue("@CenId", centerId);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show($"تم حفظ المشرف بنجاح.\nرقم القيد هو: {label2.Text}\nكلمة المرور الافتراضية: 0000");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("فشل الحفظ: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }

        private void comboAcademic_qualification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}