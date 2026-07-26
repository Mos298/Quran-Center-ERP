using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmStudentEvaluation : Form
    {
        private string _connectionString;
        private int _studentIdToEvaluate = -1; // لتخزين هوية الطالب بعد البحث

        public frmStudentEvaluation(string dbConnectionString)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string regNumber = txtSearchRegNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(regNumber))
            {
                MessageBox.Show("الرجاء إدخال رقم القيد للبحث.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // 1. البحث عن الطالب
                    string studentQuery = "SELECT ID, FullName, RegistrationNumber FROM Students WHERE RegistrationNumber = @RegNumber";
                    SqlDataAdapter daStudent = new SqlDataAdapter(studentQuery, con);
                    daStudent.SelectCommand.Parameters.AddWithValue("@RegNumber", regNumber);
                    DataTable dtStudent = new DataTable();
                    daStudent.Fill(dtStudent);

                    if (dtStudent.Rows.Count > 0)
                    {
                        DataRow row = dtStudent.Rows[0];
                        _studentIdToEvaluate = Convert.ToInt32(row["ID"]);

                        // تعبئة البيانات الثابتة للطالب
                        lblStudentName.Text = row["FullName"].ToString();
                        lblRegNumber.Text = row["RegistrationNumber"].ToString();

                        // 2. البحث عن تقييم محفوظ لليوم الحالي لهذا الطالب
                        string evalQuery = "SELECT * FROM StudentEvaluations WHERE StudentID = @StudentID AND EvaluationDate = @Today";
                        SqlDataAdapter daEval = new SqlDataAdapter(evalQuery, con);
                        daEval.SelectCommand.Parameters.AddWithValue("@StudentID", _studentIdToEvaluate);
                        daEval.SelectCommand.Parameters.AddWithValue("@Today", DateTime.Today);
                        DataTable dtEval = new DataTable();
                        daEval.Fill(dtEval);

                        if (dtEval.Rows.Count > 0)
                        {
                            // إذا وجد تقييم، قم بتحميل بياناته
                            DataRow evalRow = dtEval.Rows[0];

                            // --- التعديل هنا: طريقة آمنة لتعيين القيم ---
                            cboCommitment.Text = evalRow["Commitment"] != DBNull.Value ? evalRow["Commitment"].ToString() : string.Empty;
                            numMemorizedAjza.Value = evalRow["MemorizedAjza"] != DBNull.Value ? Convert.ToDecimal(evalRow["MemorizedAjza"]) : 1;
                            numMemorizationLevel.Value = evalRow["MemorizationLevel"] != DBNull.Value ? Convert.ToDecimal(evalRow["MemorizationLevel"]) : 0;
                            numTajweedLevel.Value = evalRow["TajweedLevel"] != DBNull.Value ? Convert.ToDecimal(evalRow["TajweedLevel"]) : 0;
                            cboOverallLevel.Text = evalRow["OverallLevel"] != DBNull.Value ? evalRow["OverallLevel"].ToString() : string.Empty;

                            MessageBox.Show("تم تحميل تقييم سابق لهذا اليوم.", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // إذا لم يوجد تقييم، قم بتصفير الحقول
                            cboCommitment.SelectedIndex = -1;
                            numMemorizedAjza.Value = 1;
                            numMemorizationLevel.Value = 0;
                            numTajweedLevel.Value = 0;
                            cboOverallLevel.SelectedIndex = -1;
                        }

                        // تفعيل حقول التقييم وزر الحفظ
                        grpEvaluation.Enabled = true;
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على طالب بهذا الرقم.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpEvaluation.Enabled = false;
                        btnSave.Enabled = false;
                        _studentIdToEvaluate = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن الطالب: \n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_studentIdToEvaluate == -1) return;

            // التحقق من أن الحقول الأساسية ليست فارغة
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
                    // استخدام MERGE للقيام بـ INSERT أو UPDATE في خطوة واحدة (UPSERT)
                    string query = @"
                        MERGE StudentEvaluations AS target
                        USING (SELECT @StudentID AS StudentID, @EvaluationDate AS EvaluationDate) AS source
                        ON (target.StudentID = source.StudentID AND target.EvaluationDate = source.EvaluationDate)
                        WHEN MATCHED THEN 
                            UPDATE SET Commitment = @Commitment, MemorizedAjza = @MemorizedAjza, MemorizationLevel = @MemorizationLevel, TajweedLevel = @TajweedLevel, OverallLevel = @OverallLevel
                        WHEN NOT MATCHED THEN
                            INSERT (StudentID, EvaluationDate, Commitment, MemorizedAjza, MemorizationLevel, TajweedLevel, OverallLevel)
                            VALUES (@StudentID, @EvaluationDate, @Commitment, @MemorizedAjza, @MemorizationLevel, @TajweedLevel, @OverallLevel);";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", _studentIdToEvaluate);
                    cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Commitment", cboCommitment.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MemorizedAjza", numMemorizedAjza.Value);
                    cmd.Parameters.AddWithValue("@MemorizationLevel", numMemorizationLevel.Value);
                    cmd.Parameters.AddWithValue("@TajweedLevel", numTajweedLevel.Value);
                    cmd.Parameters.AddWithValue("@OverallLevel", cboOverallLevel.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم حفظ التقييم بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ التقييم: \n" + ex.Message);
            }
        }
    }
}

