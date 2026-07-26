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
    public partial class frmTeacherEvaluation : Form
    {
        private string _connectionString;
        private int _supervisorId;

        // فئات مساعدة لتخزين بيانات القوائم المنسدلة
        private class Center { public int Id { get; set; } public string Name { get; set; } }
        private class Teacher { public int Id { get; set; } public string Name { get; set; } }

        public frmTeacherEvaluation(string dbConnectionString, int supervisorId)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _supervisorId = supervisorId;
        }


        private void frmTeacherEvaluation_Load(object sender, EventArgs e)
        {
            LoadAssignedCenters();
        }

        /// <summary>
        /// تحميل المراكز المكلف بها المشرف فقط
        /// </summary>
        private void LoadAssignedCenters()
        {
            /*  var centers = new List<Center>();
              try
              {
                  using (SqlConnection con = new SqlConnection(_connectionString))
                  {
                      con.Open();
                      string query = "SELECT c.ID, c.CenterName FROM Centers c JOIN SupervisorAssignments sa ON c.ID = sa.CenterID WHERE sa.SupervisorID = @SupervisorID";
                      SqlDataAdapter da = new SqlDataAdapter(query, con);
                      da.SelectCommand.Parameters.AddWithValue("@SupervisorID", _supervisorId);
                      DataTable dt = new DataTable();
                      da.Fill(dt);

                      foreach (DataRow row in dt.Rows)
                      {
                          centers.Add(new Center { Id = Convert.ToInt32(row["ID"]), Name = row["CenterName"].ToString() });
                      }

                      cmbCenters.DataSource = centers;
                      cmbCenters.DisplayMember = "Name";
                      cmbCenters.ValueMember = "Id";
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("حدث خطأ أثناء تحميل المراكز: \n" + ex.Message);
              }
          }
            */
        }

        /// <summary>
        /// عند اختيار مركز، يتم تحميل المحفظين التابعين له
        /// </summary>
        private void cmbCenters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedValue == null) return;

            int selectedCenterId = (int)cmbCenters.SelectedValue;
            LoadTeachersForCenter(selectedCenterId);
        }

        private void LoadTeachersForCenter(int centerId)
        {
         /*  var teachers = new List<Teacher>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = "SELECT t.ID, t.TeacherName FROM Teachers t JOIN CenterAssignments ca ON t.ID = ca.TeacherID WHERE ca.CenterID = @CenterID";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@CenterID", centerId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        teachers.Add(new Teacher { Id = Convert.ToInt32(row["ID"]), Name = row["TeacherName"].ToString() });
                    }

                    cmbTeachers.DataSource = teachers;
                    cmbTeachers.DisplayMember = "Name";
                    cmbTeachers.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المحفظين: \n" + ex.Message);
           } */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedValue == null || cmbTeachers.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المركز والمحفِّظ أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // يمكنك إضافة المزيد من التحققات هنا إذا لزم الأمر
/*
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // نفترض وجود جدول 'TeacherEvaluations' لتخزين سجلات التقييم
                    string query = @"INSERT INTO TeacherEvaluations 
                                     (TeacherID, CenterID, SupervisorID, TeacherClassification, Period, QuranMemorizationLevel, 
                                      RecitationAttention, CorrectionAttention, NarrationAdherence, StudentsPresent, StudentsAbsent, 
                                      OverallStudentLevel, OpinionOnTeacher, GeneralAppearance, VisitDate, RecordDate) 
                                     VALUES 
                                     (@TeacherID, @CenterID, @SupervisorID, @TeacherClassification, @Period, @QuranMemorizationLevel, 
                                      @RecitationAttention, @CorrectionAttention, @NarrationAdherence, @StudentsPresent, @StudentsAbsent, 
                                      @OverallStudentLevel, @OpinionOnTeacher, @GeneralAppearance, @VisitDate, @RecordDate)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TeacherID", (int)cmbTeachers.SelectedValue);
                    cmd.Parameters.AddWithValue("@CenterID", (int)cmbCenters.SelectedValue);
                    cmd.Parameters.AddWithValue("@SupervisorID", _supervisorId);

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
                    cmd.Parameters.AddWithValue("@RecordDate", DateTime.Now);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم حفظ التقييم بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات: \n" + ex.Message);
            }*/
        }
    }
}
