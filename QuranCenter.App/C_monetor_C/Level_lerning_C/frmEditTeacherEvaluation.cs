using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace النظام_النهائي.C_monetor_C.Level_lerning_C
{
    public partial class frmEditTeacherEvaluation : Form
    {
        private string _connectionString;
        private int _evaluationIdToEdit;
        private string v1;
        private string v2;
        private int f;

        public frmEditTeacherEvaluation(string dbConnectionString, object v, int evaluationId)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _evaluationIdToEdit = evaluationId;
        }

        public frmEditTeacherEvaluation(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public frmEditTeacherEvaluation(string j)
        {
        }

        public frmEditTeacherEvaluation(string j, int f) : this(j)
        {
            this.f = f;
        }

        public frmEditTeacherEvaluation()
        {
        }

        private void frmEditTeacherEvaluation_Load(object sender, EventArgs e)
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
                    // استخدام JOIN لجلب بيانات التقييم وبيانات المحفظ والمركز معاً
                    string query = @"SELECT e.*, t.TeacherName, c.CenterName 
                                     FROM TeacherEvaluations e
                                     JOIN Teachers t ON e.TeacherID = t.ID
                                     JOIN Centers c ON e.CenterID = c.ID
                                     WHERE e.Id = @EvaluationId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@EvaluationId", _evaluationIdToEdit);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // تعبئة بيانات الرأس
                        lblCenterName.Text = row["CenterName"].ToString();
                        lblTeacherName.Text = row["TeacherName"].ToString();

                        // تعبئة بيانات التقييم
                        cboClassification.Text = row["TeacherClassification"] != DBNull.Value ? row["TeacherClassification"].ToString() : string.Empty;
                        cboPeriod.Text = row["Period"] != DBNull.Value ? row["Period"].ToString() : string.Empty;
                        cboQuranLevel.Text = row["QuranMemorizationLevel"] != DBNull.Value ? row["QuranMemorizationLevel"].ToString() : string.Empty;
                        cboRecitationAttention.Text = row["RecitationAttention"] != DBNull.Value ? row["RecitationAttention"].ToString() : string.Empty;
                        cboCorrectionAttention.Text = row["CorrectionAttention"] != DBNull.Value ? row["CorrectionAttention"].ToString() : string.Empty;
                        cboNarrationAdherence.Text = row["NarrationAdherence"] != DBNull.Value ? row["NarrationAdherence"].ToString() : string.Empty;

                        numStudentsPresent.Value = row["StudentsPresent"] != DBNull.Value ? Convert.ToDecimal(row["StudentsPresent"]) : 0;
                        numStudentsAbsent.Value = row["StudentsAbsent"] != DBNull.Value ? Convert.ToDecimal(row["StudentsAbsent"]) : 0;

                        cboOverallStudentLevel.Text = row["OverallStudentLevel"] != DBNull.Value ? row["OverallStudentLevel"].ToString() : string.Empty;
                        cboOpinionOnTeacher.Text = row["OpinionOnTeacher"] != DBNull.Value ? row["OpinionOnTeacher"].ToString() : string.Empty;
                        cboGeneralAppearance.Text = row["GeneralAppearance"] != DBNull.Value ? row["GeneralAppearance"].ToString() : string.Empty;

                        if (row["VisitDate"] != DBNull.Value) dtpVisitDate.Value = Convert.ToDateTime(row["VisitDate"]);
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
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = @"UPDATE TeacherEvaluations SET 
                                        TeacherClassification = @TeacherClassification, Period = @Period, QuranMemorizationLevel = @QuranMemorizationLevel, 
                                        RecitationAttention = @RecitationAttention, CorrectionAttention = @CorrectionAttention, NarrationAdherence = @NarrationAdherence, 
                                        StudentsPresent = @StudentsPresent, StudentsAbsent = @StudentsAbsent, 
                                        OverallStudentLevel = @OverallStudentLevel, OpinionOnTeacher = @OpinionOnTeacher, GeneralAppearance = @GeneralAppearance, 
                                        VisitDate = @VisitDate
                                     WHERE Id = @EvaluationId";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TeacherClassification", cboClassification.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Period", cboPeriod.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@QuranMemorizationLevel", cboQuranLevel.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RecitationAttention", cboRecitationAttention.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CorrectionAttention", cboCorrectionAttention.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NarrationAdherence", cboNarrationAdherence.SelectedItem?.ToString() ?? (object)DBNull.Value);

                    cmd.Parameters.AddWithValue("@StudentsPresent", numStudentsPresent.Value);
                    cmd.Parameters.AddWithValue("@StudentsAbsent", numStudentsAbsent.Value);

                    cmd.Parameters.AddWithValue("@OverallStudentLevel", cboOverallStudentLevel.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@OpinionOnTeacher", cboOpinionOnTeacher.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@GeneralAppearance", cboGeneralAppearance.SelectedItem?.ToString() ?? (object)DBNull.Value);

                    cmd.Parameters.AddWithValue("@VisitDate", dtpVisitDate.Value);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
