using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmAddTeacherVisit : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmAddTeacherVisit()
        {
            InitializeComponent();
            // يمكنك هنا إضافة كود لملء القائمة المنسدلة لأسماء المراكز من قاعدة البيانات
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // --- 1. التحقق من أن الحقول الأساسية ليست فارغة ---
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المحفظ.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2. إعداد الاتصال وأمر SQL ---
            // استخدم 'using' لضمان إغلاق الاتصال تلقائياً
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: استبدل 'TeacherVisits' باسم الجدول الخاص بك
                // وكذلك تأكد من مطابقة أسماء الأعمدة لأسماء الحقول في جدولك
                string query = @"INSERT INTO TeacherVisits 
                                (TeacherName, HasIjazah, AssignmentType, PhoneNumber, CenterName, IsCommitted, TeachingHours,
                                 Visit1_Date, Visit1_Students, Visit1_Attendance,
                                 Visit2_Date, Visit2_Students, Visit2_Attendance)
                                 VALUES 
                                (@TeacherName, @HasIjazah, @AssignmentType, @PhoneNumber, @CenterName, @IsCommitted, @TeachingHours,
                                 @Visit1_Date, @Visit1_Students, @Visit1_Attendance,
                                 @Visit2_Date, @Visit2_Students, @Visit2_Attendance)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // --- 3. إضافة البيانات كـ Parameters لمنع ثغرات الحقن ---
                    cmd.Parameters.AddWithValue("@TeacherName", txtName.Text);
                    cmd.Parameters.AddWithValue("@HasIjazah", cmbQuranIjazah.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AssignmentType", cmbAssignmentType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@CenterName", cmbCenterName.Text); // أو .SelectedValue إذا كانت مربوطة ببيانات
                    cmd.Parameters.AddWithValue("@IsCommitted", cmbCommitment.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TeachingHours", numTeachingHours.Value);

                    cmd.Parameters.AddWithValue("@Visit1_Date", dtpVisitDate1.Value);
                    cmd.Parameters.AddWithValue("@Visit1_Students", numStudents1.Value);
                    cmd.Parameters.AddWithValue("@Visit1_Attendance", cmbAttendance1.SelectedItem.ToString());

                    cmd.Parameters.AddWithValue("@Visit2_Date", dtpVisitDate2.Value);
                    cmd.Parameters.AddWithValue("@Visit2_Students", numStudents2.Value);
                    cmd.Parameters.AddWithValue("@Visit2_Attendance", cmbAttendance2.SelectedItem.ToString());

                    // --- 4. فتح الاتصال وتنفيذ الأمر ---
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery(); // تُستخدم للأوامر التي لا ترجع بيانات (مثل INSERT, UPDATE, DELETE)
                        MessageBox.Show("تم حفظ البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm(); // دالة لتنظيف الحقول بعد الحفظ
                    }
                    catch (Exception ex)
                    {
                        // في حال حدوث خطأ، يتم عرضه للمستخدم
                        MessageBox.Show("فشل حفظ البيانات. الخطأ: " + ex.Message, "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق النموذج عند الضغط على "إلغاء"
        }

        // دالة مساعدة لتنظيف الحقول
        private void ClearForm()
        {
            txtName.Clear();
            txtPhoneNumber.Clear();
            cmbQuranIjazah.SelectedIndex = -1;
            cmbAssignmentType.SelectedIndex = -1;
            cmbCenterName.SelectedIndex = -1;
            cmbCommitment.SelectedIndex = -1;
            numTeachingHours.Value = 0;
            numStudents1.Value = 0;
            cmbAttendance1.SelectedIndex = -1;
            numStudents2.Value = 0;
            cmbAttendance2.SelectedIndex = -1;
        }
    }
}
