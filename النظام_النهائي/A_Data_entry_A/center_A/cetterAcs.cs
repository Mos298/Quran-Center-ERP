using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class cetterAcs : UserControl
    {
        // متغيرات عامة
        // تأكد من أن جملة الاتصال صحيحة (يمكنك استبدالها بالنص المباشر إذا لم تستخدم ملف Config)
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        DataTable dtCenters = new DataTable();

        public cetterAcs()
        {
            InitializeComponent();

            // إعدادات أولية للجدول
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.RightToLeft = RightToLeft.Yes;

            // ربط حدث التحميل
            this.Load += CentersUC_Load;

            // ربط حدث البحث إذا كان موجوداً
            // if (searchBox != null) searchBox.TextChanged += SearchBox_TextChanged;
        }

        private void CentersUC_Load(object sender, EventArgs e)
        {
            LoadCentersData();
        }

        // =========================================================
        // 1. دالة جلب البيانات
        // =========================================================
        public void LoadCentersData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // نستخدم الإجراء الذي قمنا بتحديثه قبل قليل
                    using (SqlDataAdapter da = new SqlDataAdapter("sp_GetAllCenters", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        dtCenters.Clear();
                        da.Fill(dtCenters);

                        dataGridView1.DataSource = dtCenters;
                        FormatGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      //  =========================================================
        private void FormatGrid()
        {
            // أ) إعدادات المظهر العام
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            // نجعل الوضع الافتراضي ملء الشاشة، وسنعدل الأعمدة الصغيرة لاحقاً
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;

            // ب) تنسيق رأس الجدول (Header) - اللون الأخضر المستوحى من زر الحفظ
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156); // نفس لون زر الحفظ
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45; // زيادة الارتفاع قليلاً لجمالية أكثر
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // ج) تنسيق الصفوف
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 245, 238); // أخضر فاتح جداً عند التحديد
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black; // النص يبقى أسود عند التحديد للقراءة

            // تلوين الصفوف المتبادلة بلون أخضر خافت جداً
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 255, 253);

            dataGridView1.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowTemplate.Height = 35;

            // د) تعريب الأعمدة وتنسيق العرض
            if (dataGridView1.Columns.Contains("CenterName"))
            {
                dataGridView1.Columns["CenterName"].HeaderText = "اسم المركز";
                // نعطيه وزن أكبر في التمدد
                dataGridView1.Columns["CenterName"].FillWeight = 200;
            }

            if (dataGridView1.Columns.Contains("City"))
            {
                dataGridView1.Columns["City"].HeaderText = "المدينة";
            }

            if (dataGridView1.Columns.Contains("Neighborhood"))
            {
                dataGridView1.Columns["Neighborhood"].HeaderText = "الحي";
            }

            // --- تعديل حجم أعمدة الأعداد لتكون صغيرة ---
            if (dataGridView1.Columns.Contains("TeacherCount"))
            {
                dataGridView1.Columns["TeacherCount"].HeaderText = "عدد المعلمين";
                // نجعل العمود يأخذ حجم المحتوى فقط أو حجم العنوان أيهما أكبر
                dataGridView1.Columns["TeacherCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns["TeacherCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["TeacherCount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns.Contains("StudentCount"))
            {
                dataGridView1.Columns["StudentCount"].HeaderText = "عدد الطلاب";
                // نجعل العمود يأخذ حجم المحتوى فقط
                dataGridView1.Columns["StudentCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns["StudentCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["StudentCount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns.Contains("WorkingHoursFrom"))
            {
                dataGridView1.Columns["WorkingHoursFrom"].HeaderText = "بداية الدوام";
                dataGridView1.Columns["WorkingHoursFrom"].DefaultCellStyle.Format = @"hh\:mm"; // تنسيق الوقت ليكون أجمل
                dataGridView1.Columns["WorkingHoursFrom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            if (dataGridView1.Columns.Contains("WorkingHoursTo"))
            {
                dataGridView1.Columns["WorkingHoursTo"].HeaderText = "نهاية الدوام";
                dataGridView1.Columns["WorkingHoursTo"].DefaultCellStyle.Format = @"hh\:mm";
                dataGridView1.Columns["WorkingHoursTo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            // هـ) إخفاء الأعمدة غير الضرورية
            if (dataGridView1.Columns.Contains("CenterId")) dataGridView1.Columns["CenterId"].Visible = false;
            if (dataGridView1.Columns.Contains("CreatedDate")) dataGridView1.Columns["CreatedDate"].Visible = false;
        }

        // =========================================================
        // 3. البحث
       //  =========================================================
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // ملاحظة: تأكد من أن searchBox معرف في ملف Designer
           
           try
           {
               if (dtCenters.Rows.Count > 0)
               {
                   string searchValue = SearchBox.Text;
                   dtCenters.DefaultView.RowFilter = string.Format("CenterName LIKE '%{0}%' OR City LIKE '%{0}%'", searchValue);
               }
           }
           catch { }
           
        }

        // =========================================================
        // 4. الأزرار
        // =========================================================

        private void addButton_Click_1(object sender, EventArgs e)
        {
            frmAddCenter_A addForm = new frmAddCenter_A();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadCentersData(); // تحديث بعد الإضافة
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // جلب البيانات من الصف المحدد
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CenterId"].Value);
                string name = dataGridView1.SelectedRows[0].Cells["CenterName"].Value.ToString();
                string city = dataGridView1.SelectedRows[0].Cells["City"].Value.ToString();
                string neighborhood = dataGridView1.SelectedRows[0].Cells["Neighborhood"].Value.ToString();

                // جلب الأعداد (للعرض فقط)
                int tCount = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TeacherCount"].Value);
                int sCount = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentCount"].Value);

                // معالجة الوقت (قد يكون null)
                TimeSpan? from = null;
                TimeSpan? to = null;
                if (dataGridView1.SelectedRows[0].Cells["WorkingHoursFrom"].Value != DBNull.Value)
                    from = (TimeSpan)dataGridView1.SelectedRows[0].Cells["WorkingHoursFrom"].Value;

                if (dataGridView1.SelectedRows[0].Cells["WorkingHoursTo"].Value != DBNull.Value)
                    to = (TimeSpan)dataGridView1.SelectedRows[0].Cells["WorkingHoursTo"].Value;

                // فتح فورم التعديل مع تمرير البيانات
                frmAddCenter_A editForm = new frmAddCenter_A(id, name, city, neighborhood, tCount, sCount, from, to);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCentersData();
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد مركز لتعديله", "تنبيه");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // يفضل أخذ الـ ID وتمريره لفورم الحذف
                // int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CenterId"].Value);

                frmDeleteCenter_A deleteForm = new frmDeleteCenter_A();
                // deleteForm.CenterId = id; // إذا كان لديك خاصية لاستقبال ال ID

                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCentersData();
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد مركز لحذفه", "تنبيه");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            frmPrintCenters_A frmPrint = new frmPrintCenters_A();
            frmPrint.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void actionsPanel_Paint(object sender, PaintEventArgs e) { }
    }
}