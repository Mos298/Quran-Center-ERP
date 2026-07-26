using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class CentersUC : UserControl
    {
        public CentersUC()
        {
            InitializeComponent();
        }

        // هذه الدالة سيتم تنفيذها تلقائيًا عند تحميل الواجهة
        private void CentersUC_Load(object sender, EventArgs e)
        {
            LoadCentersData();
        }

        /// <summary>
        /// دالة خاصة لجلب بيانات المراكز من قاعدة البيانات وعرضها
        /// </summary>
        private void LoadCentersData()
        {
            // نفس كود جلب البيانات الذي تعرفه، لكن باستخدام الإجراء المخزن الخاص بالمراكز
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // تأكد من أن "viewcenter" هو الاسم الصحيح للإجراء المخزن الخاص بالمراكز
                SqlCommand cmd = new SqlCommand("viewcenter", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    sqlConnection.Open();
                    ad.Fill(dt); // نملأ الجدول بالبيانات

                    dataGridView1.DataSource = dt; // نربط الجدول بالـ DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // نجعل الأعمدة تملأ المساحة
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء جلب بيانات المراكز: " + ex.Message);
                }
            }
        }

        // --- أحداث الأزرار الخاصة بالمراكز ---

  
  

        private void addButton_Click_1(object sender, EventArgs e)
        {
            // هنا تضع الكود لفتح فورم "إضافة مركز جديد"
            // مثلاً: AddCenterForm addForm = new AddCenterForm();
            // addForm.ShowDialog();
            EditDataForm editDataForm = new EditDataForm();
            editDataForm.ShowDialog();
            MessageBox.Show("سيتم فتح فورم إضافة مركز جديد.");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // هنا تضع الكود الخاص بحذف المركز المحدد من قاعدة البيانات
            MessageBox.Show("سيتم حذف المركز المحدد.");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // هنا تضع الكود لفتح فورم "تعديل بيانات المركز المحدد"
            MessageBox.Show("سيتم فتح فورم تعديل المركز.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}