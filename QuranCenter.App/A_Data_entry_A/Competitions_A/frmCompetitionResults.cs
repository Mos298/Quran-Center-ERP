using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace النظام_النهائي.A_Data_entry_A.Competitions_A
{
    public partial class frmCompetitionResults : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // متغيرات لاستقبال البيانات من الشاشة السابقة
        private int _competitionId;
        private string _competitionName;
        private string _competitionType;
        private int _selectedParticipationId = 0; // لحفظ ID الطالب المحدد حالياً

        public frmCompetitionResults(int compId, string compName, string compType)
        {
            InitializeComponent();

            _competitionId = compId;
            _competitionName = compName;
            _competitionType = compType;

            // إعداد الشاشة عند الفتح
            SetupForm();
        }

        private void SetupForm()
        {
            lblTitle.Text = $"رصد درجات: {_competitionName} ({_competitionType})";

            // تهيئة الأحداث (Events)
            this.Load += FrmCompetitionResults_Load;
            dgvStudents.SelectionChanged += DgvStudents_SelectionChanged;
            btnSave.Click += BtnSave_Click;

            // منطق اختلاف نوع المسابقة
            if (_competitionType.Contains("سنة") || _competitionType.Contains("حديث"))
            {
                // إذا كانت سنة: أغلق التفاصيل وافتح المجموع للكتابة
                txtMemorization.Enabled = false;
                txtTajweed.Enabled = false;
                txtPerformance.Enabled = false;

                txtTotal.ReadOnly = false; // السماح بالكتابة اليدوية
                txtTotal.BackColor = Color.White;
            }
            else
            {
                // إذا كانت قرآن: فعل الحساب التلقائي
                txtMemorization.TextChanged += CalculateTotal_TextChanged;
                txtTajweed.TextChanged += CalculateTotal_TextChanged;
                txtPerformance.TextChanged += CalculateTotal_TextChanged;

                txtTotal.ReadOnly = true; // منع الكتابة اليدوية
            }
        }

        private void FrmCompetitionResults_Load(object sender, EventArgs e)
        {
            LoadStudentsData();
        }

        // 1. دالة تحميل الطلاب
        private void LoadStudentsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetStudentScoresDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CompetitionId", _competitionId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvStudents.DataSource = dt;

                        // إخفاء أعمدة المعرفات
                        if (dgvStudents.Columns["ParticipationId"] != null) dgvStudents.Columns["ParticipationId"].Visible = false;
                        if (dgvStudents.Columns["StudentId"] != null) dgvStudents.Columns["StudentId"].Visible = false;
                        if (dgvStudents.Columns["TeacherId"] != null) dgvStudents.Columns["TeacherId"].Visible = false;

                        // تسمية الأعمدة بالعربية
                        if (dgvStudents.Columns["StudentName"] != null) dgvStudents.Columns["StudentName"].HeaderText = "اسم الطالب";
                        if (dgvStudents.Columns["TeacherName"] != null) dgvStudents.Columns["TeacherName"].HeaderText = "اسم المحفظ";
                        if (dgvStudents.Columns["CenterName"] != null) dgvStudents.Columns["CenterName"].HeaderText = "المركز";
                        if (dgvStudents.Columns["TotalScore"] != null) dgvStudents.Columns["TotalScore"].HeaderText = "المجموع";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }
        }

        // 2. حدث تغيير الاختيار في الجدول (تعبئة الحقول)
        private void DgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];

                // حفظ ID المشاركة للتحديث لاحقاً
                _selectedParticipationId = Convert.ToInt32(row.Cells["ParticipationId"].Value);

                // تعبئة مربعات النص
                txtMemorization.Text = row.Cells["ScoreMemorization"].Value.ToString();
                txtTajweed.Text = row.Cells["ScoreTajweed"].Value.ToString();
                txtPerformance.Text = row.Cells["ScorePerformance"].Value.ToString();
                txtTotal.Text = row.Cells["TotalScore"].Value.ToString();

                // تفعيل زر الحفظ
                btnSave.Enabled = true;
            }
        }

        // 3. الحساب التلقائي (للقرآن فقط)
        private void CalculateTotal_TextChanged(object sender, EventArgs e)
        {
            double mem = 0, taj = 0, perf = 0;

            double.TryParse(txtMemorization.Text, out mem);
            double.TryParse(txtTajweed.Text, out taj);
            double.TryParse(txtPerformance.Text, out perf);

            // التحقق من القيم القصوى (Validation)
            if (mem > 75) { txtMemorization.ForeColor = Color.Red; } else { txtMemorization.ForeColor = Color.Black; }
            if (taj > 15) { txtTajweed.ForeColor = Color.Red; } else { txtTajweed.ForeColor = Color.Black; }
            if (perf > 10) { txtPerformance.ForeColor = Color.Red; } else { txtPerformance.ForeColor = Color.Black; }

            double total = mem + taj + perf;
            txtTotal.Text = total.ToString();
        }

        // 4. حفظ الدرجة
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_selectedParticipationId == 0) return;

            try
            {
                double mem = 0, taj = 0, perf = 0, total = 0;

                double.TryParse(txtMemorization.Text, out mem);
                double.TryParse(txtTajweed.Text, out taj);
                double.TryParse(txtPerformance.Text, out perf);
                double.TryParse(txtTotal.Text, out total);

                // تحقق نهائي قبل الحفظ
                if (_competitionType.Contains("قرآن") && (mem > 75 || taj > 15 || perf > 10))
                {
                    MessageBox.Show("تنبيه: إحدى الدرجات تتجاوز الحد المسموح!", "خطأ في الدرجات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateStudentScore", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ParticipationId", _selectedParticipationId);
                        cmd.Parameters.AddWithValue("@ScoreMemorization", mem);
                        cmd.Parameters.AddWithValue("@ScoreTajweed", taj);
                        cmd.Parameters.AddWithValue("@ScorePerformance", perf);
                        cmd.Parameters.AddWithValue("@TotalScore", total);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("تم حفظ الدرجة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تحديث الجدول لرؤية النتيجة الجديدة
                // نحفظ رقم السطر الحالي لنعود إليه بعد التحديث
                int currentRowIndex = dgvStudents.SelectedRows[0].Index;
                LoadStudentsData();
                if (currentRowIndex < dgvStudents.Rows.Count)
                    dgvStudents.Rows[currentRowIndex].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message);
            }
        }
        // تعريف متغيرات للطباعة
        private int _printRowIndex = 0;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printDoc.DefaultPageSettings.Landscape = true; // جعل الصفحة بالعرض لتستوعب الأعمدة

            PrintPreviewDialog previewDlg = new PrintPreviewDialog();
            previewDlg.Document = printDoc;
            previewDlg.WindowState = FormWindowState.Maximized; // تكبير نافذة المعاينة

            // محاولة تحسين مظهر نافذة المعاينة (اختياري)
            ((Form)previewDlg).StartPosition = FormStartPosition.CenterScreen;
            ((Form)previewDlg).Text = "معاينة كشف الدرجات";

            _printRowIndex = 0; // تصفير عداد الصفوف
            previewDlg.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // إعدادات الخطوط والأبعاد
            int startX = e.MarginBounds.Right; // نبدأ من اليمين لأننا عربي
            int startY = e.MarginBounds.Top;
            int tableWidth = e.MarginBounds.Width;
            int cellHeight = 40;

            Font fontTitle = new Font("Segoe UI", 18, FontStyle.Bold);
            Font fontHeader = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fontRow = new Font("Segoe UI", 11, FontStyle.Regular);

            // 1. رسم عنوان التقرير (فقط في الصفحة الأولى)
            if (_printRowIndex == 0)
            {
                string title = "كشف درجات: " + _competitionName;
                SizeF titleSize = e.Graphics.MeasureString(title, fontTitle);
                // توسيط العنوان
                e.Graphics.DrawString(title, fontTitle, Brushes.Black,
                    e.MarginBounds.Left + (tableWidth - titleSize.Width) / 2, startY);

                startY += 60; // ترك مسافة بعد العنوان
            }

            // تحديد أعمدة الجدول (سنحاول توزيعها بالتساوي)
            // الأعمدة التي نريد طباعتها (تجاهل المخفية)
            var visibleCols = dgvStudents.Columns.Cast<DataGridViewColumn>()
                                         .Where(c => c.Visible).ToList();

            if (visibleCols.Count == 0) return;

            int cellWidth = tableWidth / visibleCols.Count;
            int currentX = e.MarginBounds.Left + tableWidth; // نبدأ من أقصى اليمين

            // 2. رسم رأس الجدول (Header)
            int headerY = startY;

            // رسم خلفية للرأس (لون رمادي فاتح)
            e.Graphics.FillRectangle(Brushes.LightGray, e.MarginBounds.Left, headerY, tableWidth, cellHeight);
            e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left, headerY, tableWidth, cellHeight);

            foreach (var col in visibleCols)
            {
                currentX -= cellWidth; // نتحرك لليسار

                // رسم حدود الخلية
                e.Graphics.DrawRectangle(Pens.Black, currentX, headerY, cellWidth, cellHeight);

                // رسم النص (توسيط)
                StringFormat fmt = new StringFormat();
                fmt.Alignment = StringAlignment.Center;
                fmt.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(col.HeaderText, fontHeader, Brushes.Black,
                    new RectangleF(currentX, headerY, cellWidth, cellHeight), fmt);
            }

            startY += cellHeight; // الانتقال للسطر التالي

            // 3. رسم صفوف البيانات
            while (_printRowIndex < dgvStudents.Rows.Count)
            {
                DataGridViewRow row = dgvStudents.Rows[_printRowIndex];
                currentX = e.MarginBounds.Left + tableWidth; // إعادة تعيين X لليمين

                // التحقق من أننا لم نخرج عن الصفحة
                if (startY + cellHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // نحتاج صفحة جديدة
                    return;
                }

                foreach (var col in visibleCols)
                {
                    currentX -= cellWidth;

                    // قيمة الخلية
                    string cellValue = row.Cells[col.Name].Value?.ToString() ?? "";

                    // رسم الحدود
                    e.Graphics.DrawRectangle(Pens.Black, currentX, startY, cellWidth, cellHeight);

                    // رسم النص
                    StringFormat fmt = new StringFormat();
                    fmt.Alignment = StringAlignment.Center;
                    fmt.LineAlignment = StringAlignment.Center;

                    e.Graphics.DrawString(cellValue, fontRow, Brushes.Black,
                        new RectangleF(currentX, startY, cellWidth, cellHeight), fmt);
                }

                startY += cellHeight;
                _printRowIndex++;
            }

            // إذا انتهينا من كل الصفوف
            e.HasMorePages = false;

            // رسم التذييل (التاريخ ورقم الصفحة)
            string footer = $"تاريخ الطباعة: {DateTime.Now.ToString("yyyy/MM/dd")}";
            e.Graphics.DrawString(footer, new Font("Arial", 10), Brushes.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom + 10);
        }


    }


}