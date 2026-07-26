using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmEditEvaluation : Form
    {
        private string _connectionString;
        private int _evaluationIdToEdit;

        public frmEditEvaluation(string dbConnectionString, int evaluationId)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _evaluationIdToEdit = evaluationId;
        }

        private void frmEditEvaluation_Load(object sender, EventArgs e)
        {
            LoadEvaluationData();
        }

        /// <summary>
        /// تحميل بيانات التقييم المحدد من قاعدة البيانات
        /// </summary>
        private void LoadEvaluationData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // استخدام JOIN لجلب بيانات التقييم وبيانات الطالب معاً
                    string query = @"SELECT e.*, s.FullName, s.RegistrationNumber 
                                     FROM StudentEvaluations e
                                     JOIN Students s ON e.StudentID = s.ID
                                     WHERE e.EvaluationId = @EvaluationId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@EvaluationId", _evaluationIdToEdit);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // تعبئة بيانات الطالب
                        lblStudentName.Text = row["FullName"].ToString();
                        lblRegNumber.Text = row["RegistrationNumber"].ToString();

                        // تعبئة بيانات التقييم
                        cboCommitment.Text = row["Commitment"] != DBNull.Value ? row["Commitment"].ToString() : string.Empty;
                        numMemorizedAjza.Value = row["MemorizedAjza"] != DBNull.Value ? Convert.ToDecimal(row["MemorizedAjza"]) : 1;
                        numMemorizationLevel.Value = row["MemorizationLevel"] != DBNull.Value ? Convert.ToDecimal(row["MemorizationLevel"]) : 0;
                        numTajweedLevel.Value = row["TajweedLevel"] != DBNull.Value ? Convert.ToDecimal(row["TajweedLevel"]) : 0;
                        cboOverallLevel.Text = row["OverallLevel"] != DBNull.Value ? row["OverallLevel"].ToString() : string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على بيانات هذا التقييم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات التقييم: \n" + ex.Message);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCommitment.SelectedItem == null || cboOverallLevel.SelectedItem == null)
            {
                MessageBox.Show("الرجاء التأكد من تعبئة جميع حقول التقييم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = @"UPDATE StudentEvaluations SET 
                                        Commitment = @Commitment, 
                                        MemorizedAjza = @MemorizedAjza, 
                                        MemorizationLevel = @MemorizationLevel, 
                                        TajweedLevel = @TajweedLevel, 
                                        OverallLevel = @OverallLevel
                                     WHERE EvaluationId = @EvaluationId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Commitment", cboCommitment.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MemorizedAjza", numMemorizedAjza.Value);
                    cmd.Parameters.AddWithValue("@MemorizationLevel", numMemorizationLevel.Value);
                    cmd.Parameters.AddWithValue("@TajweedLevel", numTajweedLevel.Value);
                    cmd.Parameters.AddWithValue("@OverallLevel", cboOverallLevel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EvaluationId", _evaluationIdToEdit);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم حفظ التعديلات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // لإعلام الواجهة الرئيسية بالنجاح
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ التعديلات: \n" + ex.Message);
            }
        }
    }
}
