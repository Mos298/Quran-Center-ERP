using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // ضروري لقراءة جملة الاتصال

namespace النظام_النهائي
{
    public partial class frmAddMentor_A3 : Form
    {
        // قراءة جملة الاتصال من ملف الإعدادات
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmAddMentor_A3()
        {
            InitializeComponent();
        }

        private void frmAddMentor_A3_Load(object sender, EventArgs e)
        {
            // عند فتح النافذة، نقوم بتحميل قائمة المدن
            LoadCities();

            // تعيين التاريخ الحالي
            dtpBirthDate.Value = DateTime.Now.AddYears(-25); // عمر افتراضي تقريبي
        }

        // 1. دالة تحميل المدن (يدوياً أو من قاعدة البيانات)
        private void LoadCities()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // نستخدم الإجراء الجديد لجلب المتاح فقط
                    SqlCommand cmd = new SqlCommand("sp_GetAvailableCenters", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // التحقق هل توجد مراكز متاحة؟
                    if (dt.Rows.Count > 0)
                    {
                        ((ListBox)chklstCenter).DataSource = dt;
                        ((ListBox)chklstCenter).DisplayMember = "CenterName";
                        ((ListBox)chklstCenter).ValueMember = "CenterId";
                        chklstCenter.Enabled = true;
                    }
                    else
                    {
                        // في حال لم توجد مراكز، نقوم بتنبيه بسيط أو تعطيل القائمة
                        // يمكنك إضافة عنصر وهمي يخبر المستخدم بذلك
                        chklstCenter.DataSource = null;
                        chklstCenter.Items.Add("لا توجد مراكز متاحة حالياً");
                        chklstCenter.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المراكز: " + ex.Message);
            }
            DataTable dtCities = new DataTable();
            dtCities.Columns.Add("CityName");
            dtCities.Columns.Add("CityCode");

            // إضافة المدن وأكوادها (تأكد أن هذه الأكواد ثابتة في نظامك)
            dtCities.Rows.Add("طرابلس", "094");
            dtCities.Rows.Add("مصراتة", "031");
            dtCities.Rows.Add("زليتن", "079");
            dtCities.Rows.Add("الخمس", "018");
            dtCities.Rows.Add("الزاوية", "023");
            dtCities.Rows.Add("بنغازي", "061");

            comboxAccommodation.DataSource = dtCities;
            comboxAccommodation.DisplayMember = "CityName";
            comboxAccommodation.ValueMember = "CityCode";

            // إلغاء الاختيار المبدئي
            comboxAccommodation.SelectedIndex = -1;
        }

        // 2. حدث تغيير المدينة -> لتوليد رقم القيد
        private void comboxAccommodation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxAccommodation.SelectedValue != null && comboxAccommodation.SelectedIndex != -1)
            {
                // استدعاء دالة التوليد بكود المدينة المختار
                GenerateSmartID(comboxAccommodation.SelectedValue.ToString());
            }
        }

        // 3. خوارزمية توليد رقم القيد (تتصل بـ SQL)
        private void GenerateSmartID(string cityCode)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // نستخدم نفس الإجراء المخزن العام، لكن نغير كود الفاعل
                    // 02 = مشرف | 03 = موجه
                    SqlCommand cmd = new SqlCommand("sp_GetNextRegistrationNumber", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CityCode", cityCode);
                    cmd.Parameters.AddWithValue("@ActorCode", "03"); // <-- كود الموجهين

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        // عرض الرقم في الليبل (Label2) كما في تصميمك
                        label2.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في توليد رقم القيد: " + ex.Message);
            }
        }

        // 4. زر الحفظ (يستدعي sp_AddMentor)
        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من البيانات الأساسية
            if (string.IsNullOrWhiteSpace(txtMentorName.Text) ||
                comboxAccommodation.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(label2.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم واختيار المدينة وتوليد رقم القيد.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // نبدأ معاملة (Transaction) لضمان حفظ البيانات في الجدولين معاً أو لا شيء
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddMentor", con, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // تمرير البيانات للإجراء المخزن
                        cmd.Parameters.AddWithValue("@RegNum", label2.Text); // رقم القيد المولد
                        cmd.Parameters.AddWithValue("@FullName", txtMentorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);

                        // تنظيف الرقم الوطني والهاتف من أي رموز إضافية
                        cmd.Parameters.AddWithValue("@NationalId", National_number.Text.Replace("-", "").Trim());
                        cmd.Parameters.AddWithValue("@Phone", phoonTextBox1.Text.Trim());

                        cmd.Parameters.AddWithValue("@Qualification", comboBoxqualification.Text);
                        cmd.Parameters.AddWithValue("@Assignment", comboBoxassignment.Text);
                        cmd.Parameters.AddWithValue("@Residency", comboxAccommodation.Text); // اسم المدينة كنص

                        // بارامتر لإرجاع الـ ID الجديد (مهم جداً)
                        SqlParameter outId = new SqlParameter("@NewId", SqlDbType.Int);
                        outId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outId);

                        // التنفيذ
                        cmd.ExecuteNonQuery();
                    }

                    // إذا وصلنا هنا يعني الحفظ تم بنجاح
                    transaction.Commit();

                    MessageBox.Show($"تمت إضافة الموجه بنجاح.\nرقم القيد: {label2.Text}\nكلمة المرور: 0000", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // لإخبار الشاشة الرئيسية بالتحديث
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // التراجع في حالة الخطأ
                    MessageBox.Show("فشل الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // أحداث فرعية يمكن تركها فارغة أو استخدامها للتنسيق
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
        private void lblMentorName_Click(object sender, EventArgs e) { }
        private void phoonTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
    }
}