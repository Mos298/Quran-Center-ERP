using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmAddCompetition : Form
    {
        // جملة الاتصال
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmAddCompetition()
        {
            InitializeComponent();

            // تعبئة أنواع المسابقات (يمكنك تعديلها حسب الحاجة)
            cmbType.Items.Clear();
            cmbType.Items.Add("حفظ القرآن الكريم");
            cmbType.Items.Add("تلاوة وتجويد");
            cmbType.Items.Add("السنة النبوية");
            cmbType.SelectedIndex = 0;
        }

        // زر الحفظ
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من صحة المدخلات
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المسابقة والمكان على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التأكد من أن تاريخ النهاية بعد تاريخ البداية
            if (dateTimePicker_end_time.Value < dtpCompetitionDate_start_time.Value)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ النهاية قبل تاريخ البداية.", "خطأ في التاريخ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. الحفظ في قاعدة البيانات
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddCompetition", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // ربط البيانات من الـ TextBoxes إلى الـ SQL Parameters
                        cmd.Parameters.AddWithValue("@CompetitionName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim());

                        // التواريخ
                        cmd.Parameters.AddWithValue("@StartDate", dtpCompetitionDate_start_time.Value);
                        cmd.Parameters.AddWithValue("@EndDate", dateTimePicker_end_time.Value);

                        // دمج بيانات اللجنة (اسم اللجنة + الأعضاء)
                        string fullCommitteeInfo = $"اللجنة: {txtCommitteeName.Text.Trim()} | الأعضاء: {txtCommitteeMembers.Text.Trim()}";
                        cmd.Parameters.AddWithValue("@SupervisionCommittee", fullCommitteeInfo);

                        cmd.Parameters.AddWithValue("@CompetitionType", cmbType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Sponsor", txtSponsor.Text.Trim());
                        cmd.Parameters.AddWithValue("@Criteria", txtCriteria.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("تم إضافة المسابقة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK; // لإخبار الفورم الرئيسي بأن الإضافة تمت
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // زر الإلغاء
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // حدث عند تغيير نص اللجنة (كما كان في كودك)
        // ملاحظة: يُفضل عدم إظهار MessageBox عند كل حرف يكتب، لذا قمت بتعطيله مؤقتاً
        // يمكنك إرجاعه إذا كنت تريده بالضبط كما كان
        private void txtCommitteeName_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("لكتابة اسم لجنة و الراعي اكتب الاسم التلاتي 'الاسم , الاسم الاخر '");
        }
    }
}