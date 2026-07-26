using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace النظام_النهائي
{
    public partial class frmEditCenter_A : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmEditCenter_A()
        {
            InitializeComponent();
        }

        private void frmEditCenter_Load(object sender, EventArgs e)
        {
            // عند تحميل النموذج، يتم ملء القائمة المنسدلة بأسماء المراكز
            LoadCentersIntoComboBox();
        }

        private void LoadCentersIntoComboBox()
        {
          /*  using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                    string query = "SELECT CenterID, CenterName FROM Centers ORDER BY CenterName";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // ربط مصدر البيانات بالـ ComboBox
                    cmbCenters.DataSource = dt;
                    cmbCenters.DisplayMember = "CenterName"; // النص الذي سيظهر للمستخدم
                    cmbCenters.ValueMember = "CenterID";     // القيمة المخفية (ID)
                    cmbCenters.SelectedIndex = -1; // لإلغاء التحديد الافتراضي
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل تحميل قائمة المراكز. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           */ }
      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // التأكد من أن المستخدم اختار مركزاً
            if (cmbCenters.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار مركز من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCenterId = (int)cmbCenters.SelectedValue;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT * FROM Centers WHERE CenterID = @CenterID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CenterID", selectedCenterId);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // ملء الحقول بالبيانات التي تم جلبها
                            txtCenterName.Text = reader["CenterName"].ToString();
                            txtCity.Text = reader["City"].ToString();
                            txtArea.Text = reader["Area"].ToString();
                        /*    numTeachers.Value = Convert.ToInt32(reader["TeacherCount"]);
                            numStudents.Value = Convert.ToInt32(reader["StudentCount"]);
                          */  txtWorkingHours.Text = reader["WorkingHours"].ToString();

                            // إظهار لوحة التفاصيل وتفعيل زر الحفظ
                            pnlDetails.Visible = true;
                            btnSave.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل جلب بيانات المركز. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedValue == null) return; // حماية إضافية

            int selectedCenterId = (int)cmbCenters.SelectedValue;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = @"UPDATE Centers SET 
                                 CenterName = @CenterName, 
                                 City = @City, 
                                 Area = @Area, 
                                 TeacherCount = @TeacherCount, 
                                 StudentCount = @StudentCount, 
                                 WorkingHours = @WorkingHours 
                                 WHERE CenterID = @CenterID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CenterName", txtCenterName.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@Area", txtArea.Text);
            /*        cmd.Parameters.AddWithValue("@TeacherCount", numTeachers.Value);
                    cmd.Parameters.AddWithValue("@StudentCount", numStudents.Value);
                 */   cmd.Parameters.AddWithValue("@WorkingHours", txtWorkingHours.Text);
                    cmd.Parameters.AddWithValue("@CenterID", selectedCenterId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم تحديث البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحديث البيانات. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
