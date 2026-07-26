using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class ucManageCompetitions : UserControl
    {
        // جملة الاتصال
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public ucManageCompetitions()
        {
            InitializeComponent();
            LoadCompetitionsData();
        }

        // 1. دالة تحميل البيانات (تم تحديثها لتلوين الأسطر بعد التحميل)
        public void LoadCompetitionsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllCompetitions", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCompetitions.DataSource = dt;

                        StyleDataGridView();

                        // تلوين الحالات بعد تحميل البيانات
                        ColorizeStatusRows();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات المسابقات: " + ex.Message);
            }
        }

        // 2. دالة التنسيق
        private void StyleDataGridView()
        {
            // إعدادات عامة
            dgvCompetitions.RightToLeft = RightToLeft.Yes;
            dgvCompetitions.AllowUserToAddRows = false;
            dgvCompetitions.AllowUserToDeleteRows = false;
            dgvCompetitions.ReadOnly = true;
            dgvCompetitions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompetitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompetitions.BackgroundColor = Color.White;
            dgvCompetitions.BorderStyle = BorderStyle.None;
            dgvCompetitions.RowHeadersVisible = false;

            // تنسيق الرأس
            dgvCompetitions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 178, 148);
            dgvCompetitions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompetitions.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvCompetitions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCompetitions.EnableHeadersVisualStyles = false;
            dgvCompetitions.ColumnHeadersHeight = 40;

            // تنسيق الأسطر
            dgvCompetitions.DefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Regular);
            dgvCompetitions.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCompetitions.RowTemplate.Height = 35;

            // إخفاء المعرف
            if (dgvCompetitions.Columns["CompetitionId"] != null)
                dgvCompetitions.Columns["CompetitionId"].Visible = false;

            // تنسيق التواريخ
            if (dgvCompetitions.Columns["وقت البدء"] != null)
                dgvCompetitions.Columns["وقت البدء"].DefaultCellStyle.Format = "yyyy/MM/dd hh:mm tt";

            if (dgvCompetitions.Columns["وقت الانتهاء"] != null)
                dgvCompetitions.Columns["وقت الانتهاء"].DefaultCellStyle.Format = "yyyy/MM/dd hh:mm tt";
        }

        // 3. دالة جديدة لتلوين حالة المسابقة
        private void ColorizeStatusRows()
        {
            foreach (DataGridViewRow row in dgvCompetitions.Rows)
            {
                // نتأكد أن العمود "حالة المسابقة" موجود والقيمة ليست فارغة
                if (row.Cells["حالة المسابقة"].Value != null)
                {
                    string status = row.Cells["حالة المسابقة"].Value.ToString();

                    if (status == "نشطة")
                    {
                        // لون أخضر فاتح للنص أو الخلفية
                        row.Cells["حالة المسابقة"].Style.ForeColor = Color.Green;
                        row.Cells["حالة المسابقة"].Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    }
                    else if (status == "منتهية")
                    {
                        // لون أحمر للنص
                        row.Cells["حالة المسابقة"].Style.ForeColor = Color.Red;
                    }
                    else if (status == "لم تبدأ بعد")
                    {
                        // لون برتقالي/ذهبي
                        row.Cells["حالة المسابقة"].Style.ForeColor = Color.DarkGoldenrod;
                    }
                }
            }
        }
        // زر إضافة مسابقة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // سنقوم بإنشاء هذه الشاشة لاحقاً frmAddCompetition
            frmAddCompetition frm = new frmAddCompetition();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCompetitionsData(); // تحديث الجدول بعد الإضافة
            }
        }

        // زر حذف مسابقة
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCompetitions.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مسابقة لحذفها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("هل أنت متأكد من حذف هذه المسابقة؟\nسيتم حذف جميع سجلات المشاركة المرتبطة بها.",
                                                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    int compId = Convert.ToInt32(dgvCompetitions.SelectedRows[0].Cells["CompetitionId"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_DeleteCompetition", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CompetitionId", compId);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("تم الحذف بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCompetitionsData(); // تحديث الجدول
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // زر تعديل (اختياري)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار سطر
            if (dgvCompetitions.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مسابقة لتعديلها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. الحصول على الـ ID من السطر المحدد
                // تأكد أن اسم العمود هنا يطابق اسم العمود المخفي في DataGridView (غالباً "CompetitionId")
                int compId = Convert.ToInt32(dgvCompetitions.SelectedRows[0].Cells["CompetitionId"].Value);

                // 3. فتح فورم التعديل وإرسال الـ ID
                // (لاحظ أننا مررنا الـ compId في القوسين)
                frmEditCompetition frm = new frmEditCompetition(compId);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // 4. تحديث الجدول إذا تم الحفظ بنجاح
                    LoadCompetitionsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح شاشة التعديل: " + ex.Message);
            }// كود التعديل يضاف هنا لاحقاً
        }

     
        private void ucManageCompetitions_Load(object sender, EventArgs e)
        {
              LoadCompetitionsData();
        }

        private void dgvCompetitions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}