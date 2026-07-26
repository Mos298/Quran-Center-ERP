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

namespace النظام_النهائي.A_Data_entry_A.Competitions_A
{
    public partial class frmAssignStudents : Form
    {
        private string connectionString;
        private List<Competition> allCompetitions;
        private List<Candidate> allCandidates;

        public frmAssignStudents(string connStr, List<Competition> competitions, List<Candidate> candidates)
        {
            InitializeComponent();
            this.connectionString = connStr;
            this.allCompetitions = competitions;
            this.allCandidates = candidates;
        }

        private void frmAssignStudents_Load(object sender, EventArgs e)
        {
            // تعبئة قائمة المسابقات
            cmbCompetitions.DataSource = allCompetitions.Where(c => c.Status != "منتهية").ToList();
            cmbCompetitions.DisplayMember = "Name";
            cmbCompetitions.ValueMember = "Id";

            // تعبئة قائمة جميع الطلاب
            lstAllCandidates.DataSource = allCandidates;
            lstAllCandidates.DisplayMember = "Name";
            lstAllCandidates.ValueMember = "Id";
        }

        private void cmbCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompetitions.SelectedItem == null) return;

            Competition selectedComp = cmbCompetitions.SelectedItem as Competition;

            // فلترة قائمة المشاركين
            var participants = allCandidates.Where(c => selectedComp.Participants.Contains(c.Id)).ToList();
            lstParticipants.DataSource = participants;
            lstParticipants.DisplayMember = "Name";
            lstParticipants.ValueMember = "Id";

            // فلترة قائمة جميع الطلاب (لإزالة المشاركين الحاليين)
            var nonParticipants = allCandidates.Except(participants).ToList();
            lstAllCandidates.DataSource = nonParticipants;
            lstAllCandidates.DisplayMember = "Name";
            lstAllCandidates.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstAllCandidates, lstParticipants);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstParticipants, lstAllCandidates);
        }

        private void MoveSelectedItems(ListBox source, ListBox destination)
        {
            var sourceList = (source.DataSource as List<Candidate>).ToList();
            var destList = (destination.DataSource as List<Candidate> ?? new List<Candidate>()).ToList();
            var selectedItems = source.SelectedItems.Cast<Candidate>().ToList();

            foreach (var item in selectedItems)
            {
                destList.Add(item);
                sourceList.Remove(item);
            }

            source.DataSource = null;
            source.DataSource = sourceList;
            source.DisplayMember = "Name";
            source.ValueMember = "Id";

            destination.DataSource = null;
            destination.DataSource = destList;
            destination.DisplayMember = "Name";
            destination.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCompetitions.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار مسابقة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int competitionId = (int)cmbCompetitions.SelectedValue;
            List<int> participantIds = (lstParticipants.DataSource as List<Candidate>).Select(c => c.Id).ToList();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // استخدام Transaction لضمان تنفيذ العمليتين معاً
                    SqlTransaction transaction = con.BeginTransaction();

                    // 1. حذف جميع المشاركين القدامى لهذه المسابقة
                    string deleteQuery = "DELETE FROM CompetitionParticipants WHERE CompetitionID = @CompID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con, transaction))
                    {
                        deleteCmd.Parameters.AddWithValue("@CompID", competitionId);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // 2. إضافة المشاركين الجدد
                    foreach (int candidateId in participantIds)
                    {
                        string insertQuery = "INSERT INTO CompetitionParticipants (CompetitionID, CandidateID) VALUES (@CompID, @CandID)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@CompID", competitionId);
                            insertCmd.Parameters.AddWithValue("@CandID", candidateId);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); // تأكيد العمليات
                }

                MessageBox.Show("تم حفظ المشاركين بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات: \n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
