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
    public partial class ucViewNominations : Form
    {
        public string ConnectionString { get; set; }
        private List<NominationView> _nominations;

        public ucViewNominations()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    // استعلام SQL معقد لجلب البيانات من عدة جداول
                    string query = @"SELECT 
                                        n.ID AS NominationId,
                                        c.Name AS CompetitionName,
                                        s.FullName AS StudentName,
                                        s.RegistrationNumber,
                                        n.NominationDate
                                     FROM Nominations n
                                     JOIN Competitions c ON n.CompetitionID = c.ID
                                     JOIN Students s ON n.StudentID = s.ID
                                     ORDER BY n.NominationDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    _nominations = dt.AsEnumerable().Select(row => new NominationView
                    {
                        NominationId = row.Field<int>("NominationId"),
                        CompetitionName = row.Field<string>("CompetitionName"),
                        StudentName = row.Field<string>("StudentName"),
                        RegistrationNumber = row.Field<string>("RegistrationNumber"),
                        NominationDate = row.Field<DateTime>("NominationDate")
                    }).ToList();

                    SetupDataGridView();
                    dgvNominations.DataSource = _nominations;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الترشيحات: \n" + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvNominations.AutoGenerateColumns = false;
            dgvNominations.Columns.Clear();

            dgvNominations.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "تحديد", Name = "colSelect", Width = 50 });
            dgvNominations.Columns.Add(new DataGridViewTextBoxColumn { Name = "CompetitionName", HeaderText = "اسم المسابقة", DataPropertyName = "CompetitionName", FillWeight = 150 });
            dgvNominations.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentName", HeaderText = "اسم الطالب", DataPropertyName = "StudentName", FillWeight = 150 });
            dgvNominations.Columns.Add(new DataGridViewTextBoxColumn { Name = "RegistrationNumber", HeaderText = "رقم القيد", DataPropertyName = "RegistrationNumber" });
            dgvNominations.Columns.Add(new DataGridViewTextBoxColumn { Name = "NominationDate", HeaderText = "تاريخ الترشيح", DataPropertyName = "NominationDate", DefaultCellStyle = { Format = "yyyy/MM/dd" } });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_nominations == null) return;
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvNominations.DataSource = _nominations;
            }
            else
            {
                dgvNominations.DataSource = _nominations.Where(n =>
                    n.CompetitionName.ToLower().Contains(searchText) ||
                    n.StudentName.ToLower().Contains(searchText) ||
                    n.RegistrationNumber.Contains(searchText)
                ).ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = GetSelectedNominationIds();
            if (selectedIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد ترشيح واحد على الأقل لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"هل أنت متأكد من حذف {selectedIds.Count} ترشيح؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        string query = $"DELETE FROM Nominations WHERE ID IN ({string.Join(",", selectedIds)})";
                        SqlCommand cmd = new SqlCommand(query, con);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"تم حذف {rowsAffected} ترشيح بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // إعادة تحميل البيانات
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حذف الترشيحات: \n" + ex.Message);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = GetSelectedNominationIds();
            if (selectedIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد ترشيح واحد على الأقل للطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // يمكنك هنا استبدال هذه الرسالة بكود الطباعة الفعلي
            string message = "سيتم طباعة بيانات الترشيحات التالية:\n" + string.Join(", ", selectedIds);
            MessageBox.Show(message, "عملية طباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<int> GetSelectedNominationIds()
        {
            List<int> selectedIds = new List<int>();
            foreach (DataGridViewRow row in dgvNominations.Rows)
            {
                if (row.Cells["colSelect"].Value != null && Convert.ToBoolean(row.Cells["colSelect"].Value))
                {
                    NominationView nomination = row.DataBoundItem as NominationView;
                    if (nomination != null)
                    {
                        selectedIds.Add(nomination.NominationId);
                    }
                }
            }
            return selectedIds;
        }
    }
}

