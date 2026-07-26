using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // ضروري للشارت

namespace النظام_النهائي
{
    public partial class ucDashboard : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // متغيرات لتخزين البيانات محلياً حتى لا نتصل بالقاعدة مع كل ضغطة
        private DataTable dtCompetitionsType;
        private DataTable dtActiveCompetitions;
        private DataTable dtStudentsCenters;

        public ucDashboard()
        {
            InitializeComponent();

            // تحسين جماليات الشارت عند البدء
            StyleChart();

            // ربط أحداث الضغط
            AttachClickEvents();

            // تحميل البيانات
            LoadDashboardData();
        }

        private void StyleChart()
        {
            // إعدادات جمالية للشارت
            chartCompetitions.BackColor = Color.White;
            chartCompetitions.ChartAreas[0].BackColor = Color.White;

            // إخفاء الخطوط الشبكية المزعجة
            chartCompetitions.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartCompetitions.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartCompetitions.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // تحسين الخطوط
            chartCompetitions.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            chartCompetitions.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            // الألوان
            chartCompetitions.Palette = ChartColorPalette.SeaGreen; // باليت ألوان قريب من الارتكوازي
        }

        private void AttachClickEvents()
        {
            // نربط الحدث بالبانل وبالليبل داخله لضمان الاستجابة أينما ضغط المستخدم

            // 1. كرت إجمالي المسابقات
            cardTotalCompetitions.Click += (s, e) => ShowChart_CompetitionsType();
            lblTotalCompetitions.Click += (s, e) => ShowChart_CompetitionsType();
            lblTotalCompetitionsTitle.Click += (s, e) => ShowChart_CompetitionsType();

            // إضافة تأثير المؤشر (يد)
            cardTotalCompetitions.Cursor = Cursors.Hand;
            lblTotalCompetitions.Cursor = Cursors.Hand;
            lblTotalCompetitionsTitle.Cursor = Cursors.Hand;

            // 2. كرت المسابقات النشطة
            cardActiveCompetitions.Click += (s, e) => ShowChart_ActiveCompetitions();
            lblActiveCompetitions.Click += (s, e) => ShowChart_ActiveCompetitions();
            lblActiveCompetitionsTitle.Click += (s, e) => ShowChart_ActiveCompetitions();

            cardActiveCompetitions.Cursor = Cursors.Hand;
            lblActiveCompetitions.Cursor = Cursors.Hand;
            lblActiveCompetitionsTitle.Cursor = Cursors.Hand;

            // 3. كرت إجمالي الطلاب
            cardTotalCandidates.Click += (s, e) => ShowChart_StudentsCenters();
            lblTotalCandidates.Click += (s, e) => ShowChart_StudentsCenters();
            lblTotalCandidatesTitle.Click += (s, e) => ShowChart_StudentsCenters();

            cardTotalCandidates.Cursor = Cursors.Hand;
            lblTotalCandidates.Cursor = Cursors.Hand;
            lblTotalCandidatesTitle.Cursor = Cursors.Hand;
        }

        public void LoadDashboardData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetDashboardData", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        // جلب الجداول الأربعة دفعة واحدة
                        da.Fill(ds);

                        // 1. تعبئة الأرقام (العدادات) - الجدول الأول
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            lblTotalCompetitions.Text = row["TotalCompetitions"].ToString();
                            lblActiveCompetitions.Text = row["ActiveCompetitions"].ToString();
                            lblTotalCandidates.Text = row["TotalCandidates"].ToString();
                        }

                        // 2. تخزين بيانات الشارتات في المتغيرات لاستخدامها عند الضغط
                        dtCompetitionsType = ds.Tables[1];   // توزيع أنواع المسابقات
                        dtActiveCompetitions = ds.Tables[2]; // الطلاب في المسابقات النشطة
                        dtStudentsCenters = ds.Tables[3];    // الطلاب في المراكز

                        // عرض الشارت الافتراضي (مثلاً: إجمالي المسابقات)
                        ShowChart_CompetitionsType();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل لوحة القيادة: " + ex.Message);
            }
        }

        // --- دوال عرض الشارتات ---

        private void ShowChart_CompetitionsType()
        {
            // تغيير العنوان
            chartCompetitions.Titles.Clear();
            chartCompetitions.Titles.Add("توزيع المسابقات حسب النوع").Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // إعداد البيانات
            chartCompetitions.Series.Clear();
            Series series = new Series("النوع");
            series.ChartType = SeriesChartType.Doughnut; // شكل دائري مجوف
            series.IsValueShownAsLabel = true;

            if (dtCompetitionsType != null)
            {
                foreach (DataRow row in dtCompetitionsType.Rows)
                {
                    series.Points.AddXY(row["CompetitionType"], row["Count"]);
                }
            }

            chartCompetitions.Series.Add(series);

            // تظليل الكرت المحدد (تجميلي)
            HighlightCard(cardTotalCompetitions);
        }

        private void ShowChart_ActiveCompetitions()
        {
            chartCompetitions.Titles.Clear();
            chartCompetitions.Titles.Add("أعلى المسابقات النشطة مشاركةً").Font = new Font("Segoe UI", 12, FontStyle.Bold);

            chartCompetitions.Series.Clear();
            Series series = new Series("الطلاب");
            series.ChartType = SeriesChartType.Column; // أعمدة
            series.IsValueShownAsLabel = true;
            series.Color = Color.FromArgb(0, 150, 136); // اللون الارتكوازي

            if (dtActiveCompetitions != null)
            {
                foreach (DataRow row in dtActiveCompetitions.Rows)
                {
                    series.Points.AddXY(row["CompetitionName"], row["StudentCount"]);
                }
            }

            chartCompetitions.Series.Add(series);
            HighlightCard(cardActiveCompetitions);
        }

        private void ShowChart_StudentsCenters()
        {
            chartCompetitions.Titles.Clear();
            chartCompetitions.Titles.Add("توزيع الطلاب على المراكز (الأكثر نشاطاً)").Font = new Font("Segoe UI", 12, FontStyle.Bold);

            chartCompetitions.Series.Clear();
            Series series = new Series("المراكز");
            series.ChartType = SeriesChartType.Bar; // أشرطة أفقية
            series.IsValueShownAsLabel = true;
            series.Color = Color.FromArgb(255, 152, 0); // برتقالي للتنويع

            if (dtStudentsCenters != null)
            {
                foreach (DataRow row in dtStudentsCenters.Rows)
                {
                    series.Points.AddXY(row["CenterName"], row["StudentCount"]);
                }
            }

            chartCompetitions.Series.Add(series);
            HighlightCard(cardTotalCandidates);
        }

        // دالة مساعدة لتغيير لون خلفية الكرت النشط
        private void HighlightCard(Panel activePanel)
        {
            // إعادة الألوان للوضع الطبيعي
            cardTotalCompetitions.BackColor = Color.White;
            cardActiveCompetitions.BackColor = Color.White;
            cardTotalCandidates.BackColor = Color.White;

            // تمييز الكرت النشط بلون خفيف جداً
            activePanel.BackColor = Color.FromArgb(230, 245, 240); // أخضر فاتح جداً
        }
    }
}