using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class CentersUC : UserControl
    {// نص الاتصال
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public CentersUC()
        {
            InitializeComponent();
            this.Load += CentersUC_Load;
            // ضبط الجدول ليملأ الواجهة بالكامل
            dgvCenters.Dock = DockStyle.Fill;

            // جعل اتجاه الجدول من اليمين لليسار
            dgvCenters.RightToLeft = RightToLeft.Yes;

            // تحميل البيانات عند البدء
         
        }

        // هذه الدالة سيتم تنفيذها تلقائيًا عند تحميل الواجهة
        private void CentersUC_Load(object sender, EventArgs e)
        {
            LoadCentersData();
        }

        /// <summary>
        /// دالة خاصة لجلب بيانات المراكز من قاعدة البيانات وعرضها
        /// </summary>

        // نفس كود جلب البيانات الذي تعرفه، لكن باستخدام الإجراء المخزن الخاص بالمراكز
        public void LoadCentersData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // جلب البيانات باستخدام الإجراء المخزن
                    using (SqlDataAdapter da = new SqlDataAdapter("sp_GetAllCenters", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        da.Fill(dt); // هنا يتم جلب البيانات

                        // === اللحظة السحرية ===
                        // بمجرد وضع البيانات هنا، سيقوم البرنامج بإنشاء الأعمدة تلقائياً
                        dgvCenters.DataSource = dt;

                        // الآن ننادي دالة التنسيق لتجميل الجدول
                        FormatGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            // 1. تنسيق عام للجدول
            dgvCenters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // توسيع الأعمدة
            dgvCenters.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // تحديد الصف بالكامل
            dgvCenters.ReadOnly = true; // منع التعديل المباشر
            dgvCenters.AllowUserToAddRows = false; // منع إضافة صف فارغ في الأسفل
            dgvCenters.RowHeadersVisible = false; // إخفاء الهامش الجانبي الفارغ
            dgvCenters.BackgroundColor = Color.White; // لون الخلفية
            dgvCenters.BorderStyle = BorderStyle.None;

            // 2. تنسيق رأس الجدول (Header)
            dgvCenters.EnableHeadersVisualStyles = false;
            dgvCenters.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 128); // لون تركواز
            dgvCenters.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // لون النص أبيض
            dgvCenters.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold); // الخط
            dgvCenters.ColumnHeadersHeight = 35; // ارتفاع الرأس

            // 3. تنسيق الصفوف
            dgvCenters.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // لون الصفوف الزوجية
            dgvCenters.RowsDefaultCellStyle.Font = new Font("Tahoma", 9); // خط البيانات
            dgvCenters.RowTemplate.Height = 30; // ارتفاع الصف

            // 4. إخفاء الأعمدة التي لا نريد عرضها (مثل الـ ID وتاريخ الإنشاء)
            // ملاحظة: الأسماء هنا يجب أن تطابق أسماء الأعمدة في SQL (بالإنجليزية)
            if (dgvCenters.Columns["CenterId"] != null)
                dgvCenters.Columns["CenterId"].Visible = false;

            if (dgvCenters.Columns["CreatedDate"] != null)
                dgvCenters.Columns["CreatedDate"].Visible = false;
        }
    
        // --- أحداث الأزرار الخاصة بالمراكز ---

  
  

        private void addButton_Click_1(object sender, EventArgs e)
        {
            // هنا تضع الكود لفتح فورم "إضافة مركز جديد"
            // مثلاً: AddCenterForm addForm = new AddCenterForm();
            // addForm.ShowDialog();
           frmAddCenter_A addForm =  new frmAddCenter_A();
              addForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            frmDeleteCenter_A deleteForm = new frmDeleteCenter_A();
              deleteForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // هنا تضع الكود لفتح فورم "تعديل بيانات المركز المحدد"
           frmEditCenter_A editForm = new frmEditCenter_A();
              editForm.ShowDialog();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            frmPrintCenters_A frmPrintCenters_A = new frmPrintCenters_A();
            frmPrintCenters_A.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}