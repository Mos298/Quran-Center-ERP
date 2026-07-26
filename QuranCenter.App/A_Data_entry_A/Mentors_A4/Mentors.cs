using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; // نحتاج هذه المكتبة للألوان والخطوط
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class Mentors : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Mentors()
        {
            InitializeComponent();
            LoadMentorsData();
        }
        
        private void LoadMentorsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllMentors", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        

                        // 1. ربط البيانات
                        dataGridView1.DataSource = dt;

                        // 2. استدعاء دالة التنسيق بعد جلب البيانات
                        StyleDataGridView();  
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات الموجهين: " + ex.Message);
            }
        }

        // --- دالة التنسيق الاحترافي ---
        private void StyleDataGridView()
        {
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;

            // تنسيق الرأس
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // تنسيق الصفوف
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 255, 253);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 245, 238);
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowTemplate.Height = 35;
            // إخفاء عمود المعرف (ID) لأنه للمبرمج فقط ولا يهم المستخدم
            // 2. تعريب الأعمدة وترتيبها حسب طلبك

            // 1. اسم المشرف
            if (dataGridView1.Columns.Contains("FullName"))
            {
                dataGridView1.Columns["FullName"].HeaderText = "اسم المشرف";
                dataGridView1.Columns["FullName"].DisplayIndex = 0;
                dataGridView1.Columns["FullName"].FillWeight = 150;
            }

            // 2. رقم القيد
            if (dataGridView1.Columns.Contains("RegistrationNumber"))
            {
                dataGridView1.Columns["RegistrationNumber"].HeaderText = "رقم القيد";
                dataGridView1.Columns["RegistrationNumber"].DisplayIndex = 1;
            }

            // 3. تاريخ الميلاد
            if (dataGridView1.Columns.Contains("BirthDate"))
            {
                dataGridView1.Columns["BirthDate"].HeaderText = "تاريخ الميلاد";
                dataGridView1.Columns["BirthDate"].DisplayIndex = 2;
                dataGridView1.Columns["BirthDate"].DefaultCellStyle.Format = "yyyy/MM/dd"; // تنسيق التاريخ
            }

            // 4. الإقامة
            if (dataGridView1.Columns.Contains("Residence"))
            {
                dataGridView1.Columns["Residence"].HeaderText = "الإقامة";
                dataGridView1.Columns["Residence"].DisplayIndex = 3;
            }

            // 5. المؤهل العلمي
            if (dataGridView1.Columns.Contains("Qualification"))
            {
                dataGridView1.Columns["Qualification"].HeaderText = "المؤهل العلمي";
                dataGridView1.Columns["Qualification"].DisplayIndex = 4;
            }

            // 6. الجنس
            if (dataGridView1.Columns.Contains("Gender"))
            {
                dataGridView1.Columns["Gender"].HeaderText = "الجنس";
                dataGridView1.Columns["Gender"].DisplayIndex = 5;
                // تقليص حجم العمود لأنه كلمة قصيرة
                dataGridView1.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            // 7. التكليف
            if (dataGridView1.Columns.Contains("AssignmentType"))
            {
                dataGridView1.Columns["AssignmentType"].HeaderText = "التكليف";
                dataGridView1.Columns["AssignmentType"].DisplayIndex = 6;
            }

            // 8. رقم الهاتف
            if (dataGridView1.Columns.Contains("PhoneNumber"))
            {
                dataGridView1.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
                dataGridView1.Columns["PhoneNumber"].DisplayIndex = 7;
            }

            // 9. الرقم الوطني
            if (dataGridView1.Columns.Contains("NationalId"))
            {
                dataGridView1.Columns["NationalId"].HeaderText = "الرقم الوطني";
                dataGridView1.Columns["NationalId"].DisplayIndex = 8;
            }

            // إخفاء الأعمدة غير المطلوبة
            if (dataGridView1.Columns.Contains("UserId")) dataGridView1.Columns["UserId"].Visible = false;
        }

        // أزرار التحكم
        private void addButton_Click(object sender, EventArgs e)
        {
            frmAddMentor_A3 frm = new frmAddMentor_A3();
            // عند إغلاق نافذة الإضافة بنجاح (DialogResult.OK)، نعيد تحميل الجدول
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMentorsData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // سنقوم ببرمجة هذا الزر لاحقاً ليعمل
            // frmDeleteMentor_A3 frm = new frmDeleteMentor_A3();
            // frm.ShowDialog();
            // LoadMentorsData();
        }
    }
}