using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class frmAddTeacher_A4 : Form
    {
        // قراءة جملة الاتصال
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmAddTeacher_A4()
        {
            InitializeComponent();
        }

        private void frmAddTeacher_A4_Load(object sender, EventArgs e)
        {
            LoadCities();
            LoadCenters(); // تحميل المراكز في الكومبوبوكس
            dtpBirthDate.Value = DateTime.Now.AddYears(-25);
        }

        // 1. تحميل قائمة المدن (لغرض السكن وتوليد رقم القيد)
        private void LoadCities()
        {
            DataTable dtCities = new DataTable();
            dtCities.Columns.Add("CityName");
            dtCities.Columns.Add("CityCode");

            dtCities.Rows.Add("طرابلس", "094");
            dtCities.Rows.Add("مصراتة", "031");
            dtCities.Rows.Add("زليتن", "079");
            dtCities.Rows.Add("الخمس", "018");
            dtCities.Rows.Add("الزاوية", "023");
            dtCities.Rows.Add("بنغازي", "061");

            comboBoxcity.DataSource = dtCities; // انتبه لاسم الكومبوبوكس في تصميمك (comboBoxcity أو comboxAccommodation)
            comboBoxcity.DisplayMember = "CityName";
            comboBoxcity.ValueMember = "CityCode";
            comboBoxcity.SelectedIndex = -1;
        }

        // 2. تحميل قائمة المراكز (المهمة الجديدة)
        private void LoadCenters()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // استدعاء الإجراء البسيط لجلب المراكز
                    SqlDataAdapter da = new SqlDataAdapter("sp_GetAllCentersList", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboxCenter.DataSource = dt;
                    comboxCenter.DisplayMember = "CenterName"; // الاسم الظاهر
                    comboxCenter.ValueMember = "CenterId";     // القيمة المخزنة (ID)
                    comboxCenter.SelectedIndex = -1; // لا تختر شيئاً في البداية
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المراكز: " + ex.Message);
            }
        }

        // عند تغيير المدينة -> توليد رقم قيد جديد
        private void comboBoxcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxcity.SelectedValue != null && comboBoxcity.SelectedIndex != -1)
            {
                GenerateSmartID(comboBoxcity.SelectedValue.ToString());
            }
        }

        // توليد رقم القيد (كود المعلم 04)
        private void GenerateSmartID(string cityCode)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetNextRegistrationNumber", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CityCode", cityCode);
                    cmd.Parameters.AddWithValue("@ActorCode", "04"); // 04 = كود المحفظين

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null) label2.Text = result.ToString(); // عرض الرقم في label2
                }
            }
            catch (Exception ex) { }
        }

        // زر الحفظ
        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من المدخلات
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text) ||
                comboxCenter.SelectedIndex == -1 ||
                comboBoxcity.SelectedIndex == -1 ||
                label2.Text == "00000000000") // التأكد من توليد الرقم
            {
                MessageBox.Show("الرجاء إدخال الاسم، اختيار المدينة، واختيار المركز.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // استخدام الإجراء المخزن sp_AddTeacher
                using (SqlCommand cmd = new SqlCommand("sp_AddTeacher", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // تعبئة البيانات
                    cmd.Parameters.AddWithValue("@RegNum", label2.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtTeacherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);

                    // تنظيف الأرقام
                    string natId = National_number.Text.Replace("-", "").Trim();
                    string phone = phoonTextBox1.Text.Trim();
                    cmd.Parameters.AddWithValue("@NationalId", natId);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    cmd.Parameters.AddWithValue("@Qualification", comboBoxqualification.Text);
                    cmd.Parameters.AddWithValue("@Assignment", assignment.Text); // نوع التكليف (محفظ/مساعد)
                    cmd.Parameters.AddWithValue("@Residency", comboBoxcity.Text); // اسم المدينة

                    // أهم نقطة: إرسال رقم المركز المختار
                    cmd.Parameters.AddWithValue("@CenterId", comboxCenter.SelectedValue);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"تمت إضافة المحفظ بنجاح وتحديث بيانات المركز.\nرقم القيد: {label2.Text}", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // أحداث فرعية
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
    }
}