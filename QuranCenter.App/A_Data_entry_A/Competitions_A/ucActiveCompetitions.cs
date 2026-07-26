using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A.Competitions_A;

namespace النظام_النهائي
{// سلسلة الاتصال

    public partial class ucActiveCompetitions : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        // 1. تعريف الأحداث التي سيستمع إليها النموذج الرئيسي
        public event EventHandler<Scores> ScoreUpdated;
        public event EventHandler<int> FinishCompetitionClicked;
        public event EventHandler<int> PrintCompetitionClicked;


        public ucActiveCompetitions()
        {
            InitializeComponent();

            // 1. تطبيق التصميم الجميل فوراً
            StyleDataGridView();

            // 2. تحميل البيانات
            LoadCompetitionsData();
        }

        /// <summary>
        /// دالة عامة لاستقبال البيانات من النموذج الرئيسي وإنشاء الواجهة ديناميكياً
        /// </summary>
      // --- دالة التنسيق والجماليات (نفس التصميم السابق) ---
        private void StyleDataGridView()
        {
            dgvCompetitions.BorderStyle = BorderStyle.None;
            dgvCompetitions.BackgroundColor = Color.White;
            dgvCompetitions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCompetitions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCompetitions.EnableHeadersVisualStyles = false;

            // تنسيق الرأس (أخضر ارتكوازي)
            dgvCompetitions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvCompetitions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompetitions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            dgvCompetitions.ColumnHeadersHeight = 50;

            // تنسيق الصفوف
            dgvCompetitions.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvCompetitions.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvCompetitions.RowTemplate.Height = 40;

            // ألوان التحديد (فسفوري)
            dgvCompetitions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 230, 118);
            dgvCompetitions.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCompetitions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 250);

            // جعل الجدول يملأ المساحة
            dgvCompetitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompetitions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompetitions.ReadOnly = true;
        }

        // --- دالة تحميل البيانات من قاعدة البيانات ---
        public void LoadCompetitionsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // استدعاء الإجراء المخزن الجديد
                    using (SqlCommand cmd = new SqlCommand("sp_GetCompetitionsForScoring", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCompetitions.DataSource = dt;

                        // إخفاء الأعمدة غير الضرورية للعرض (مثل المعرف والتواريخ إذا أردت)
                        if (dgvCompetitions.Columns["CompetitionId"] != null)
                            dgvCompetitions.Columns["CompetitionId"].Visible = false;

                        // ترتيب الأعمدة (اختياري)
                        if (dgvCompetitions.Columns["CompetitionName"] != null) dgvCompetitions.Columns["CompetitionName"].HeaderText = "اسم المسابقة";
                        if (dgvCompetitions.Columns["CenterLocation"] != null) dgvCompetitions.Columns["CenterLocation"].HeaderText = "المكان";
                        if (dgvCompetitions.Columns["Status"] != null) dgvCompetitions.Columns["Status"].HeaderText = "الحالة";
                        if (dgvCompetitions.Columns["CompetitionType"] != null) dgvCompetitions.Columns["CompetitionType"].HeaderText = "نوع المسابقة";
                        if (dgvCompetitions.Columns["CommitteeName"] != null) dgvCompetitions.Columns["CommitteeName"].HeaderText = "اللجنة";

                        // إضافة زر التفاصيل (!)
                        AddDetailsButtonColumn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        // --- دالة إضافة زر التفاصيل ---
        private void AddDetailsButtonColumn()
        {
            if (dgvCompetitions.Columns["colDetails"] == null)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "colDetails";
                btn.HeaderText = "رصد الدرجات";
                btn.Text = "عرض الطلاب";
                btn.UseColumnTextForButtonValue = true;

                // تنسيق الزر
                btn.FlatStyle = FlatStyle.Flat;
                btn.DefaultCellStyle.BackColor = Color.FromArgb(255, 152, 0); // برتقالي
                btn.DefaultCellStyle.ForeColor = Color.White;
                btn.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                dgvCompetitions.Columns.Add(btn);
            }
        }

        // --- حدث الضغط على الزر ---
        private void dgvCompetitions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // في ucCandidates.cs
            if (e.RowIndex >= 0 && dgvCompetitions.Columns[e.ColumnIndex].Name == "colDetails")
            {
                int compId = Convert.ToInt32(dgvCompetitions.Rows[e.RowIndex].Cells["CompetitionId"].Value);
                string compName = dgvCompetitions.Rows[e.RowIndex].Cells["CompetitionName"].Value.ToString();
                string compType = dgvCompetitions.Rows[e.RowIndex].Cells["CompetitionType"].Value.ToString();

                // هنا يتم استدعاء الفورم الجديد
                frmCompetitionResults frm = new frmCompetitionResults(compId, compName, compType);
                frm.ShowDialog();
            }
        }

        // --- تلوين حالة المسابقة (أخضر للنشطة، أحمر للمنتهية) ---
        private void dgvCompetitions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCompetitions.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                if (e.Value.ToString() == "نشطة")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }
                else if (e.Value.ToString() == "منتهية")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
    }
}

