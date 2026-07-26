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

namespace النظام_النهائي
{
    public partial class frmEndCompetition : Form
    {
        private string connectionString;
        public int SelectedCompetitionId { get; private set; } = -1;

        public frmEndCompetition(string dbConnectionString)
        {
            InitializeComponent();
            this.connectionString = dbConnectionString;
        }

        private void frmEndCompetition_Load(object sender, EventArgs e)
        {
            LoadActiveCompetitions();
        }

        private void LoadActiveCompetitions()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // جلب المسابقات التي ليست "منتهية" فقط
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID, Name FROM Competitions WHERE Status <> 'منتهية' ORDER BY Name", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCompetitions.DataSource = dt;
                    cmbCompetitions.DisplayMember = "Name";
                    cmbCompetitions.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل قائمة المسابقات النشطة: \n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (cmbCompetitions.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار مسابقة لإنهاءها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string competitionName = cmbCompetitions.Text;
            DialogResult confirmResult = MessageBox.Show($"هل أنت متأكد من أنك تريد إنهاء المسابقة: '{competitionName}'؟\nسيتم تغيير حالتها إلى 'منتهية' ولن تظهر في قائمة المسابقات الحالية.",
                                                        "تأكيد الإنهاء",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                SelectedCompetitionId = (int)cmbCompetitions.SelectedValue;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
