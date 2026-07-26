using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; // نحتاج هذه المكتبة للألوان والخطوط
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A.Competitions_A;

namespace النظام_النهائي
{
    public partial class ucTeacherSupervision : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ucTeacherSupervision()
        {
            InitializeComponent();

            // تطبيق التصميم الجميل عند البدء
            StyleDataGridView();

            LoadSupervisorsData();
        }

        // دالة التنسيق والجماليات (ألوان ارتكوازية وخط كبير)
        private void StyleDataGridView()
        {
            // إعدادات عامة للجدول
            dgvTeachers.BorderStyle = BorderStyle.None;
            dgvTeachers.BackgroundColor = Color.White; // خلفية بيضاء نظيفة
            dgvTeachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // خطوط أفقية فقط
            dgvTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTeachers.EnableHeadersVisualStyles = false; // ضروري لتلوين الرأس

            // 1. تنسيق رأس الجدول (لون ارتكوازي - Turquoise)
            dgvTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgvTeachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTeachers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold); // خط كبير وعريض للعنوان
            dgvTeachers.ColumnHeadersHeight = 45; // زيادة ارتفاع الرأس

            // 2. تنسيق الصفوف (البيانات)
            dgvTeachers.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular); // خط كبير للبيانات
            dgvTeachers.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64); // لون نص رمادي داكن
            dgvTeachers.RowTemplate.Height = 35; // زيادة ارتفاع الصف ليكون مريحاً

            // 3. ألوان التحديد (عند الضغط على صف) - لون فسفوري
            dgvTeachers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 230, 118); // أخضر فسفوري جميل
            dgvTeachers.DefaultCellStyle.SelectionForeColor = Color.Black; // النص يصبح أسود عند التحديد ليكون مقروءاً

            // 4. تلوين الصفوف المتبادلة (اختياري لجمالية أكثر)
            dgvTeachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 250); // لون نعناعي فاتح جداً
        }

        // 1. تحميل بيانات المشرفين في الجدول الرئيسي
        public void LoadSupervisorsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // نستخدم الإجراء الذي أنشأناه سابقاً لجلب (الشيخ، المركز، المسابقة)
                    using (SqlCommand cmd = new SqlCommand("sp_Getdataendte_get_student", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvTeachers.DataSource = dt;

                        // إضافة زر التفاصيل (!) إذا لم يكن موجوداً
                        AddDetailsButtonColumn();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
        }

        private void AddDetailsButtonColumn()
        {
            if (dgvTeachers.Columns["colDetails"] == null)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "colDetails";
                btn.HeaderText = "تفاصيل";
                btn.Text = "!";
                btn.UseColumnTextForButtonValue = true;

                // تنسيق زر التفاصيل ليكون متناسقاً
                btn.FlatStyle = FlatStyle.Flat;
                btn.DefaultCellStyle.BackColor = Color.Orange;
                btn.DefaultCellStyle.ForeColor = Color.White;
                btn.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                dgvTeachers.Columns.Add(btn);
            }
        }

        // 2. حدث الضغط على الخلية (لفتح النافذة الجديدة)
        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد من الضغط على زر التفاصيل
            if (e.RowIndex >= 0 && dgvTeachers.Columns[e.ColumnIndex].Name == "colDetails")
            {
                // جلب البيانات من السطر المحدد
                int teacherId = Convert.ToInt32(dgvTeachers.Rows[e.RowIndex].Cells["TeacherId"].Value);
                string teacherName = dgvTeachers.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();

                // *ملاحظة*: إذا كنت قد عدلت فورم frmTeacherDetails ليقبل متغيرين فقط، فاحذف competitionId من السطرين التاليين

                // جلب رقم المسابقة (قد يكون null إذا لم يكن الشيخ مشرفاً على أي مسابقة بعد)
                int competitionId = 0;
                if (dgvTeachers.Rows[e.RowIndex].Cells["CompetitionId"].Value != DBNull.Value)
                {
                    competitionId = Convert.ToInt32(dgvTeachers.Rows[e.RowIndex].Cells["CompetitionId"].Value);
                }

                // فتح فورم التفاصيل (تأكد من عدد المتغيرات حسب آخر تحديث قمت به)
                // بناء على الكود المرفق منك، أنت تستخدم 3 متغيرات حالياً
                frmTeacherDetails frm = new frmTeacherDetails(teacherId, teacherName, competitionId);
                // إذا كان الكود لديك لا يزال يطلب 3 متغيرات، استخدم السطر التالي بدلاً من السابق:
                // frmTeacherDetails frm = new frmTeacherDetails(teacherId, teacherName, competitionId);

                frm.ShowDialog();
            }
        }
    }
}