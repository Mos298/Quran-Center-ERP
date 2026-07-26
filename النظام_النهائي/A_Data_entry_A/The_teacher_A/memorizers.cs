using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class memorizers : UserControl
    {
        // استخدام جملة الاتصال
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public memorizers()
        {
            InitializeComponent();
            LoadTeachersData();
        }

        private void LoadTeachersData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllTeachers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // 1. ربط البيانات
                        dataGridView1.DataSource = dt;

                        // 2. تطبيق التنسيق
                        StyleDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        private void StyleDataGridView()
        {
            // إعدادات الجدول العامة
            dataGridView1.RightToLeft = RightToLeft.Yes; // الاتجاه من اليمين لليسار
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // توسيع الأعمدة
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;

            // تنسيق الرأس (Header) - اللون التركواز
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 178, 148);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 45; // زيادة الارتفاع قليلاً لاستيعاب العناوين

            // تنسيق الخلايا (Rows)
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 35;

            // تلوين الأسطر المتبادلة
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 255, 248);

            // لون التحديد
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 100);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // --- إخفاء وتنسيق الأعمدة المحددة ---

            // إخفاء المعرف (UserId)
            if (dataGridView1.Columns["UserId"] != null)
                dataGridView1.Columns["UserId"].Visible = false;

            // تنسيق تاريخ الميلاد ليظهر كتاريخ فقط بدون وقت
            if (dataGridView1.Columns["تاريخ الميلاد"] != null)
                dataGridView1.Columns["تاريخ الميلاد"].DefaultCellStyle.Format = "yyyy/MM/dd";
        }

        // الأزرار
        private void addButton_Click(object sender, EventArgs e)
        {
             frmAddTeacher_A4 frm = new frmAddTeacher_A4();
             if (frm.ShowDialog() == DialogResult.OK) LoadTeachersData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
        }
    }
}