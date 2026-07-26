using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // مكتبة الرسم البياني
using System.Configuration;
using System.Drawing.Printing;
using النظام_النهائي.A_Data_entry_A;
namespace النظام_النهائي
{
    public partial class Statistics : UserControl
    {
        // قراءة جملة الاتصال من ملف الإعدادات
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Statistics()
        {
            InitializeComponent();

            // تهيئة تصميم الشارت عند تشغيل الشاشة
            SetupChartDesign();
            PlotData("sp_Stats_StudentsPerCenter", "الطلاب", "أعداد الطلاب في كل مركز", SeriesChartType.Column);
            // عرض إحصائية افتراضية (مثلاً الطلاب) عند الفتح
            // PlotData("sp_Stats_StudentsPerCenter", "الطلاب", "أعداد الطلاب حسب كل مركز");
        }

        // --- دالة إعداد مظهر الرسم البياني ---
        private void SetupChartDesign()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // إضافة عنوان رئيسي
            chart1.Titles.Add("MainTitle");
            chart1.Titles[0].Font = new Font("Tahoma", 14, FontStyle.Bold);
            chart1.Titles[0].ForeColor = Color.DarkSlateGray;

            // تحسين المظهر العام
            chart1.ChartAreas[0].BackColor = Color.White;
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Tahoma", 9);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Tahoma", 9);
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.Interval = 1; // إظهار كل الأسماء
        }

        // --- الدالة الذكية لرسم البيانات (تستدعيها جميع الأزرار) ---
        private void PlotData(string procedureName, string seriesName, string chartTitle, SeriesChartType chartType = SeriesChartType.Column)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        con.Open(); // فتح الاتصال صراحة للتأكد
                        da.Fill(dt);
                    }
                }

                // تنظيف الشارت
                chart1.Series.Clear();
                chart1.Titles.Clear(); // مسح العناوين القديمة لمنع التكرار
                chart1.Titles.Add(chartTitle);
                chart1.Titles[0].Font = new Font("Tahoma", 14, FontStyle.Bold);

                // إنشاء السلسلة
                Series series = new Series(seriesName);
                series.ChartType = chartType;
                series.IsValueShownAsLabel = true;

                foreach (DataRow row in dt.Rows)
                {
                    // === التعديل الهام هنا: فحص القيمة قبل قراءتها ===
                    if (row[1] != DBNull.Value && row[0] != DBNull.Value)
                    {
                        string xValue = row[0].ToString();

                        // تحويل آمن للأرقام
                        double yValue = 0;
                        double.TryParse(row[1].ToString(), out yValue);

                        int pIndex = series.Points.AddXY(xValue, yValue);
                        series.Points[pIndex].Color = GetColor(pIndex);
                        series.Points[pIndex].ToolTip = $"{xValue}: {yValue}";
                    }
                }

                chart1.Series.Add(series);
            }
            catch (Exception ex)
            {
                // عرض الخطأ بالتفصيل لمعرفة السبب
                MessageBox.Show($"خطأ في عرض الإحصائيات: \n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // دالة مساعدة لاختيار الألوان
        private Color GetColor(int index)
        {
            Color[] palette = new Color[] {
                Color.FromArgb(0, 178, 148),  // التركواز (لون الهوية)
                Color.FromArgb(255, 128, 0),    // برتقالي
                Color.FromArgb(0, 122, 204),    // أزرق
                Color.FromArgb(220, 53, 69),    // أحمر
                Color.FromArgb(102, 16, 242),   // بنفسجي
                Color.FromArgb(23, 162, 184)    // سماوي
            };
            return palette[index % palette.Length];
        }

        // ==========================================
        // أحداث الأزرار (Events)
        // ==========================================

        // 1. زر عدد الطلاب
        private void buttonstudent_Click(object sender, EventArgs e)
        {
            PlotData("sp_Stats_StudentsPerCenter", "الطلاب", "أعداد الطلاب في كل مركز", SeriesChartType.Column);
        }

        // 2. زر عدد المحفظين
        private void buttonteacher_Click(object sender, EventArgs e)
        {
            PlotData("sp_Stats_TeachersPerCenter", "المحفظين", "أعداد المحفظين في كل مركز", SeriesChartType.Column);
        }

        // 3. زر الطلاب المتفوقين (التقييمات)
        private void buttonStudents_excelled_Click(object sender, EventArgs e)
        {
            // هنا نستخدم الإجراء الذي يحول النصوص لأرقام
            PlotData("sp_Stats_TopRatedCenters", "متوسط التقييم", "المراكز الأعلى في تقييمات الطلاب", SeriesChartType.Column);
        }

        // 4. زر التميز في المسابقات
        private void buttonCompetitions_excel_Click(object sender, EventArgs e)
        {
            // نستخدم Pie Chart للتنويع
            PlotData("sp_Stats_TopCompetitionCenters", "الفائزين", "نسبة تفوق المراكز في المسابقات", SeriesChartType.Pie);
        }

        // 5. زر التخزين (لم يتم تحديد وظيفته، تركته فارغاً)
        private void buttonstorage_Click(object sender, EventArgs e)
        {
            reregster_A ff = new reregster_A();
            ff.ShowDialog(); 
        }

        // بقية الأحداث التلقائية (لا تحذفها لتجنب الأخطاء في المصمم)
        private void contentTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            // 1. إنشاء كائن مستند الطباعة
        
        }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { } // زر الطباعة إذا وجد
        private void label2_Click(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }

        private void buttonStudents_excelled_Click_1(object sender, EventArgs e)
        {
            PlotData("sp_Stats_TopRatedCenters", "متوسط التقييم", "المراكز الأعلى في تقييمات الطلاب", SeriesChartType.Column);
        }

        private void btnPrintToFile_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            // جعل الصفحة بالعرض (Landscape) لأن الرسم البياني يظهر بشكل أفضل
            pd.DefaultPageSettings.Landscape = true;

            // 2. حدث الرسم على الصفحة
            pd.PrintPage += (s, args) =>
            {
                // تحديد مساحة الرسم (حدود الصفحة مع الهوامش)
                Rectangle marginBounds = args.MarginBounds;

                // أمر رسم الشارت داخل ورقة الطباعة وتمديده ليملأ الصفحة
                chart1.Printing.PrintPaint(args.Graphics, marginBounds);
            };

            // 3. إظهار نافذة اختيار الطابعة
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            // عند الضغط على موافق
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // هنا سيقوم النظام بالطباعة
                // إذا اختار المستخدم "Microsoft Print to PDF"، سيطلب منه مكان حفظ الملف
                pd.Print();
            }
        }
    }
}