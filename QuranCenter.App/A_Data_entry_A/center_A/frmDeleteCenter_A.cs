using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmDeleteCenter_A : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmDeleteCenter_A()
        {
            InitializeComponent();
        }

        private void frmDeleteCenter_Load(object sender, EventArgs e)
        {
            // عند تحميل النموذج، يتم ملء القائمة المنسدلة بأسماء المراكز
            LoadCentersIntoComboBox();
        }

        private void LoadCentersIntoComboBox()
        {
           /* using (SqlConnection con = new SqlConnection(connectionString))
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
          */ 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
                            // ملء الحقول بالبيانات التي تم جلبها (استخدمنا Labels للعرض فقط)
                            lblCenterNameValue.Text = reader["CenterName"].ToString();
                            lblCityValue.Text = reader["City"].ToString();
                            lblAreaValue.Text = reader["Area"].ToString();
                        //    lblTeachersValue.Text = reader["TeacherCount"].ToString();
                          //  lblStudentsValue.Text = reader["StudentCount"].ToString();
                            lblWorkingHoursValue.Text = reader["WorkingHours"].ToString();

                            // إظهار لوحة التفاصيل وتفعيل زر الحذف
                            pnlDetails.Visible = true;
                            btnDelete.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل جلب بيانات المركز. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedValue == null) return;

            string centerNameToDelete = cmbCenters.Text;

            // --- رسالة التأكيد ---
            var confirmResult = MessageBox.Show($"هل أنت متأكد من أنك تريد حذف مركز '{centerNameToDelete}'؟\nسيتم حذف جميع البيانات المرتبطة به بشكل نهائي.",
                                                 "تأكيد الحذف",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // --- تنفيذ الحذف ---
                int selectedCenterId = (int)cmbCenters.SelectedValue;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                    string query = "DELETE FROM Centers WHERE CenterID = @CenterID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CenterID", selectedCenterId);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم حذف المركز بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("فشل حذف المركز. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
