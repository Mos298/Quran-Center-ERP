using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditCompetition : Form
    {
        // متغيرات
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private int _competitionId; // لتخزين رقم المسابقة

        // الـ Constructor يستقبل المعرف
        public frmEditCompetition(int competitionId)
        {
            InitializeComponent();
            _competitionId = competitionId;

            // عرض المعرف في التيكست بوكس (للعلم فقط)
            txtId.Text = _competitionId.ToString();

            // تعبئة الكومبوبوكس
            cmbType.Items.Clear();
            cmbType.Items.Add("حفظ القرآن الكريم");
            cmbType.Items.Add("تلاوة وتجويد");
            cmbType.Items.Add("السنة النبوية");

            // تحميل البيانات
            LoadCompetitionData();
        }

        private void LoadCompetitionData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetCompetitionById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CompetitionId", _competitionId);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["CompetitionName"].ToString();
                                txtLocation.Text = reader["Location"].ToString();
                                txtSponsor.Text = reader["Sponsor"] != DBNull.Value ? reader["Sponsor"].ToString() : "";
                                txtCriteria.Text = reader["Conditions"] != DBNull.Value ? reader["Conditions"].ToString() : "";

                                if (reader["CompetitionType"] != DBNull.Value)
                                    cmbType.SelectedItem = reader["CompetitionType"].ToString();

                                // التواريخ
                                if (reader["StartDate"] != DBNull.Value)
                                    dtpCompetitionDate_start_time.Value = Convert.ToDateTime(reader["StartDate"]);

                                if (reader["EndDate"] != DBNull.Value)
                                    dateTimePicker_end_time.Value = Convert.ToDateTime(reader["EndDate"]);

                                // معالجة نص اللجنة
                                string committeeFull = reader["SupervisionCommittee"] != DBNull.Value ? reader["SupervisionCommittee"].ToString() : "";
                                ParseCommitteeData(committeeFull);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }
        }

        private void ParseCommitteeData(string fullText)
        {
            if (string.IsNullOrEmpty(fullText)) return;
            try
            {
                string[] parts = fullText.Split('|');
                foreach (var part in parts)
                {
                    if (part.Trim().StartsWith("اللجنة:"))
                        txtCommitteeName.Text = part.Replace("اللجنة:", "").Trim();
                    else if (part.Trim().StartsWith("الأعضاء:"))
                        txtCommitteeMembers.Text = part.Replace("الأعضاء:", "").Trim();
                }
                if (string.IsNullOrEmpty(txtCommitteeName.Text) && string.IsNullOrEmpty(txtCommitteeMembers.Text))
                    txtCommitteeName.Text = fullText;
            }
            catch
            {
                txtCommitteeName.Text = fullText;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من صحة المدخلات
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المسابقة والمكان.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePicker_end_time.Value < dtpCompetitionDate_start_time.Value)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ النهاية قبل البداية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCompetition", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CompetitionId", _competitionId);
                        cmd.Parameters.AddWithValue("@CompetitionName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@StartDate", dtpCompetitionDate_start_time.Value);
                        cmd.Parameters.AddWithValue("@EndDate", dateTimePicker_end_time.Value);

                        string fullCommittee = $"اللجنة: {txtCommitteeName.Text.Trim()} | الأعضاء: {txtCommitteeMembers.Text.Trim()}";
                        cmd.Parameters.AddWithValue("@SupervisionCommittee", fullCommittee);

                        cmd.Parameters.AddWithValue("@CompetitionType", cmbType.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Sponsor", txtSponsor.Text.Trim());
                        cmd.Parameters.AddWithValue("@Criteria", txtCriteria.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("تم تعديل البيانات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // إغلاق النافذة وإخبار الشاشة الرئيسية أن العملية نجحت
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ:\n" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}