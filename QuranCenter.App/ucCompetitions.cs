using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class ucCompetitions : UserControl
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";

        public ucCompetitions()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // --- 1. التحقق من صحة البيانات الأساسية ---
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(txtSupervisorName.Text))
            {
                MessageBox.Show("الرجاء إدخال كافة معلومات المسابقة العامة.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2. حفظ معلومات المسابقة الرئيسية والحصول على ID الخاص بها ---
            int competitionId = SaveCompetitionInfo();

            if (competitionId > 0)
            {
                // --- 3. حفظ نتائج الطلاب المرتبطة بالمسابقة ---
                bool allResultsSaved = SaveStudentResults(competitionId);

                if (allResultsSaved)
                {
                    MessageBox.Show("تم حفظ بيانات المسابقة ونتائج الطلاب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("تم حفظ معلومات المسابقة ولكن حدث خطأ أثناء حفظ بعض نتائج الطلاب.", "خطأ جزئي", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("فشل حفظ بيانات المسابقة الرئيسية.", "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int SaveCompetitionInfo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: استبدل 'Competitions' باسم جدول المسابقات
                // استخدمنا OUTPUT INSERTED.CompetitionID لاستعادة ID السجل الجديد
                string query = @"INSERT INTO Competitions (Location, CompetitionTime, SupervisorName) 
                                 OUTPUT INSERTED.CompetitionID 
                                 VALUES (@Location, @CompetitionTime, @SupervisorName)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@CompetitionTime", dtpCompetitionTime.Value);
                    cmd.Parameters.AddWithValue("@SupervisorName", txtSupervisorName.Text);

                    try
                    {
                        con.Open();
                        // ExecuteScalar يُستخدم هنا لأنه يرجع قيمة واحدة (وهي الـ ID الجديد)
                        int newId = (int)cmd.ExecuteScalar();
                        return newId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ حفظ معلومات المسابقة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1; // إرجاع قيمة سالبة للدلالة على حدوث خطأ
                    }
                }
            }
        }

        private bool SaveStudentResults(int competitionId)
        {
            bool success = true;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // !!! هام: استبدل 'CompetitionResults' باسم جدول نتائج الطلاب
                string query = @"INSERT INTO CompetitionResults 
                               (CompetitionID, StudentName, TeacherName, CenterName, Score, Rank) 
                               VALUES 
                               (@CompetitionID, @StudentName, @TeacherName, @CenterName, @Score, @Rank)";

                // المرور على كل صف في الـ DataGridView
                foreach (DataGridViewRow row in dgvStudentResults.Rows)
                {
                    // تجاهل الصف الأخير (الجديد) إذا كان فارغاً
                    if (row.IsNewRow) continue;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CompetitionID", competitionId);
                        // تأكد من أن أسماء الأعمدة تطابق ما لديك
                        cmd.Parameters.AddWithValue("@StudentName", row.Cells["colStudentName"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TeacherName", row.Cells["colTeacherName"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CenterName", row.Cells["colCenterName"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Score", Convert.ToInt32(row.Cells["colScore"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@Rank", Convert.ToInt32(row.Cells["colRank"].Value ?? 0));

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            // إذا فشل حفظ أي طالب، يتم تسجيل ذلك ولكن العملية تستمر
                            success = false;
                            MessageBox.Show($"خطأ حفظ نتيجة الطالب: {row.Cells["colStudentName"].Value}\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return success;
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            txtSupervisorName.Clear();
            dtpCompetitionTime.Value = DateTime.Now;
            dgvStudentResults.Rows.Clear();
        }
    }
}
