using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A; // 1. استدعاء مكتبة الجلسة

namespace النظام_النهائي.D_the_techer_D.Competitions_D
{
    public partial class ucTeacherNomination : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // 2. تم حذف المتغير المحلي CurrentTeacherId لأنه لم يعد له لزوم

        public ucTeacherNomination()
        {
            InitializeComponent();

            // التحقق من أن المستخدم معلم
            if (Session.CurrentTeacherId == null)
            {
                MessageBox.Show("تنبيه: لا يوجد معرف معلم مسجل في الجلسة. يرجى إعادة تسجيل الدخول.", "خطأ صلاحيات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = false; // تعطيل الواجهة للحماية
                return;
            }

            LoadUpcomingCompetitions();
        }

        // 1. تحميل المسابقات القادمة
        private void LoadUpcomingCompetitions()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetUpcomingCompetitions", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCompetitions.DataSource = dt;
                        cmbCompetitions.DisplayMember = "CompetitionName"; // الاسم الظاهر
                        cmbCompetitions.ValueMember = "CompetitionId";     // القيمة المخفية

                        // تصفير الاختيار المبدئي
                        cmbCompetitions.SelectedIndex = -1;
                        ClearDetails();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المسابقات: " + ex.Message);
            }
        }

        // 2. عند اختيار مسابقة، نعرض التفاصيل
        private void cmbCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompetitions.SelectedIndex != -1 && cmbCompetitions.SelectedValue is int)
            {
                int compId = Convert.ToInt32(cmbCompetitions.SelectedValue);
                FillCompetitionDetails(compId);

                // تنظيف قائمة الطلاب لأن المسابقة تغيرت
                clbStudents.DataSource = null;
                btnSubmitNomination.Enabled = false;
            }
        }

        private void FillCompetitionDetails(int competitionId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetCompetitionDetailsById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CompetitionId", competitionId);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtLocation.Text = reader["Location"].ToString();
                                txtCompType.Text = reader["CompetitionType"].ToString();

                                // تنسيق التواريخ بشكل جميل
                                DateTime start = Convert.ToDateTime(reader["StartDate"]);
                                DateTime end = Convert.ToDateTime(reader["EndDate"]);

                                txtStartDate.Text = start.ToString("yyyy/MM/dd");
                                txtEndDate.Text = end.ToString("yyyy/MM/dd");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب التفاصيل: " + ex.Message);
            }
        }

        // 3. زر عرض الطلاب المرشحين (الذين لم يسجلوا بعد)
        private void btnShowNominationList_Click(object sender, EventArgs e)
        {
            if (cmbCompetitions.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار المسابقة أولاً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // تحقق إضافي للأمان
            if (Session.CurrentTeacherId == null) return;

            int compId = Convert.ToInt32(cmbCompetitions.SelectedValue);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetTeacherStudentsForNomination", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // 3. استخدام Session.CurrentTeacherId.Value
                        cmd.Parameters.AddWithValue("@TeacherId", Session.CurrentTeacherId.Value);
                        cmd.Parameters.AddWithValue("@CompetitionId", compId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // ربط البيانات بـ CheckedListBox
                            ((ListBox)clbStudents).DataSource = dt;
                            ((ListBox)clbStudents).DisplayMember = "StudentName";
                            ((ListBox)clbStudents).ValueMember = "StudentId";

                            btnSubmitNomination.Enabled = true;
                        }
                        else
                        {
                            clbStudents.DataSource = null;
                            btnSubmitNomination.Enabled = false;
                            MessageBox.Show("لا يوجد طلاب متاحين للترشيح لهذه المسابقة.\n(ربما تم تسجيل جميع طلابك بالفعل)", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب الطلاب: " + ex.Message);
            }
        }

        // 4. زر تأكيد الترشيح (الحفظ)
        private void btnSubmitNomination_Click(object sender, EventArgs e)
        {
            if (clbStudents.CheckedItems.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // تحقق إضافي للأمان
            if (Session.CurrentTeacherId == null) return;

            if (MessageBox.Show("هل أنت متأكد من ترشيح الطلاب المحددين لهذه المسابقة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int compId = Convert.ToInt32(cmbCompetitions.SelectedValue);
                int successCount = 0;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    foreach (object item in clbStudents.CheckedItems)
                    {
                        try
                        {
                            // الحصول على StudentId من العنصر المحدد (DataRowView)
                            DataRowView row = item as DataRowView;
                            int studentId = Convert.ToInt32(row["StudentId"]);

                            using (SqlCommand cmd = new SqlCommand("sp_SubmitStudentNomination", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@StudentId", studentId);
                                cmd.Parameters.AddWithValue("@CompetitionId", compId);

                                // 4. استخدام Session.CurrentTeacherId.Value
                                cmd.Parameters.AddWithValue("@TeacherId", Session.CurrentTeacherId.Value);

                                cmd.ExecuteNonQuery();
                                successCount++;
                            }
                        }
                        catch (Exception)
                        {
                            // تجاهل الأخطاء الفردية
                        }
                    }
                }

                MessageBox.Show($"تم ترشيح {successCount} طالب بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تحديث القائمة (سيختفي الطلاب الذين تم تسجيلهم للتو)
                btnShowNominationList.PerformClick();
            }
        }

        private void ClearDetails()
        {
            txtLocation.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtCompType.Clear();
            clbStudents.DataSource = null;
            btnSubmitNomination.Enabled = false;
        }
    }
}