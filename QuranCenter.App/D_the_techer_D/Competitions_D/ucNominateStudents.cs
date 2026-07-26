using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using النظام_النهائي.D_the_techer_D.Competitions_D;

namespace النظام_النهائي
{
    // لاحظ التغيير هنا: قمنا بتحديد النوع بشكل كامل
    public partial class ucNominateStudents : System.Windows.Forms.UserControl
    {
        // خصائص عامة لاستقبال البيانات
        public string ConnectionString { get; set; }
        public int CurrentTeacherId { get; set; }

        // حدث لإعلام الواجهة الرئيسية عند إتمام الترشيح
        public event EventHandler NominationSubmitted;

        public ucNominateStudents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// دالة عامة لبدء تحميل البيانات عند عرض الواجهة
        /// </summary>
        public void LoadData()
        {
            LoadCompetitions();
            // تم تعطيل إخفاء الواجهة بناءً على طلبك
            // grpConditions.Visible = false;
            // grpNomination.Visible = false;
        }

        private void LoadCompetitions()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID, Name, Conditions FROM Competitions", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    var competitions = dt.AsEnumerable().Select(row => new NominationCompetition
                    {
                        Id = row.Field<int>("ID"),
                        Name = row.Field<string>("Name"),
                        Conditions = row.Field<string>("Conditions")
                    }).ToList();

                    competitions.Insert(0, new NominationCompetition { Id = 0, Name = "-- اختر مسابقة --" });

                    cboCompetitions.DataSource = competitions;
                    cboCompetitions.DisplayMember = "Name";
                    cboCompetitions.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المسابقات: \n" + ex.Message);
            }
        }

        private void cboCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCompetitions.SelectedIndex > 0)
            {
                var selectedCompetition = (NominationCompetition)cboCompetitions.SelectedItem;
                rtbConditions.Text = selectedCompetition.Conditions;
                grpConditions.Visible = true; // لا يزال من الجيد التحكم في الظهور هنا
            }
            else
            {
                grpConditions.Visible = false;
            }
            // عند تغيير المسابقة، قم بإخفاء قائمة الطلاب لضمان اختيار جديد
            grpNomination.Visible = false;
        }

        private void btnShowNominationList_Click(object sender, EventArgs e)
        {
            LoadTeacherStudents();
            grpNomination.Visible = true;
        }

        private void LoadTeacherStudents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID, FullName FROM Students WHERE SupervisorID = @TeacherId", con);
                    da.SelectCommand.Parameters.AddWithValue("@TeacherId", CurrentTeacherId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    var students = dt.AsEnumerable().Select(row => new NominationStudent
                    {
                        Id = row.Field<int>("ID"),
                        Name = row.Field<string>("FullName")
                    }).ToList();

                    clbStudents.DataSource = students;
                    clbStudents.DisplayMember = "Name";
                    clbStudents.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل قائمة الطلاب: \n" + ex.Message);
            }
        }

        private void btnSubmitNomination_Click(object sender, EventArgs e)
        {
            int competitionId = (int)cboCompetitions.SelectedValue;
            var selectedStudents = clbStudents.CheckedItems.OfType<NominationStudent>().ToList();

            if (selectedStudents.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل لترشيحه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    int successCount = 0;
                    foreach (var student in selectedStudents)
                    {
                        string query = "INSERT INTO Nominations (CompetitionID, StudentID, NominationDate) VALUES (@CompetitionID, @StudentID, @NominationDate)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@CompetitionID", competitionId);
                        cmd.Parameters.AddWithValue("@StudentID", student.Id);
                        cmd.Parameters.AddWithValue("@NominationDate", DateTime.Now);

                        successCount += cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"تم ترشيح {successCount} طالب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // إطلاق الحدث لإعلام الواجهة الرئيسية
                    NominationSubmitted?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ الترشيحات: \n" + ex.Message);
            }
        }

     
        private void button1_Click_1(object sender, EventArgs e)
        {
            ucViewNominations GG = new ucViewNominations();
            GG.ShowDialog();
        }

        private void ucNominateStudents_Load(object sender, EventArgs e)
        {

        }

        private void grpNomination_Enter(object sender, EventArgs e)
        {

        }
    }
}

