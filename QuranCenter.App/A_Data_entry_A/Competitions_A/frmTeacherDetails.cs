using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي.A_Data_entry_A.Competitions_A
{
    public partial class frmTeacherDetails : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private int _teacherId;
        private int _currentCompetitionId;

        // هذا هو "الكونستركتور" الذي يقبل 3 متغيرات والذي كان يسبب الخطأ
        public frmTeacherDetails(int teacherId, string teacherName, int initialCompetitionId)
        {
            InitializeComponent();
            // حفظ رقم المعلم لاستخدامه لاحقاً في زر النقل
            _teacherId = teacherId;
            
            // عرض اسم المعلم
            lblTeacherName.Text = teacherName;

            // 3. (هام جداً) حل مشكلة التحديد: إجبار الجدول على تحديد الصف بالكامل
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // منع التعديل اليدوي داخل الجدول لضمان التحديد الصحيح
            dgvStudents.ReadOnly = true;
            _teacherId = teacherId;
            _currentCompetitionId = initialCompetitionId;

            // التأكد من أن الليبل موجود في التصميم باسم lblTeacherName
            if (lblTeacherName != null)
                lblTeacherName.Text = teacherName;

            LoadCompetitionsCombo();
        }

        private void LoadCompetitionsCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetCompetitionsList", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCompetitions.DataSource = dt;
                        cmbCompetitions.DisplayMember = "CompetitionName";
                        cmbCompetitions.ValueMember = "CompetitionId";

                        if (_currentCompetitionId > 0)
                        {
                            cmbCompetitions.SelectedValue = _currentCompetitionId;
                        }

                        this.cmbCompetitions.SelectedIndexChanged += new System.EventHandler(this.cmbCompetitions_SelectedIndexChanged);
                        LoadStudentsData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل المسابقات: " + ex.Message); }
        }

        private void LoadStudentsData()
        {
            if (cmbCompetitions.SelectedValue == null) return;

            int compId;
            if (int.TryParse(cmbCompetitions.SelectedValue.ToString(), out compId))
            {
                _currentCompetitionId = compId;
            }
            else return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetStudentsInCompetitionByTeacher", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TeacherId", _teacherId);
                        cmd.Parameters.AddWithValue("@CompetitionId", _currentCompetitionId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvStudents.DataSource = dt;

                        if (dgvStudents.Columns["ParticipationId"] != null) dgvStudents.Columns["ParticipationId"].Visible = false;
                        if (dgvStudents.Columns["StudentId"] != null) dgvStudents.Columns["StudentId"].Visible = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل الطلاب: " + ex.Message); }
        }

        private void cmbCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LoadStudentsData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // التحقق باستخدام CurrentRow بدلاً من SelectedRows لأنه أكثر دقة
            if (dgvStudents.CurrentRow == null || dgvStudents.CurrentRow.Index == -1)
            {
                MessageBox.Show("الرجاء تحديد طالب لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من حذف هذا الطالب من المسابقة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // نأخذ القيمة من الصف الحالي (CurrentRow)
                    int participationId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["ParticipationId"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_RemoveStudentFromCompetition", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ParticipationId", participationId);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadStudentsData(); // تحديث الجدول
                    MessageBox.Show("تم الحذف بنجاح.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في الحذف: " + ex.Message);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم حفظ التغييرات.");
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار مسابقة
            // التحقق من اختيار مسابقة من القائمة
            if (cmbCompetitions.SelectedIndex == -1 || cmbCompetitions.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المسابقة المراد النقل إليها من القائمة أعلاه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من تحديد صفوف في الجدول
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب أو أكثر من القائمة لنقلهم.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من نقل الطلاب المحددين إلى المسابقة المختارة؟", "تأكيد النقل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int successCount = 0;
                int targetCompetitionId = Convert.ToInt32(cmbCompetitions.SelectedValue);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // الدوران على جميع الصفوف المحددة
                    foreach (DataGridViewRow row in dgvStudents.SelectedRows)
                    {
                        try
                        {
                            // التأكد من أن الصف ليس فارغاً
                            if (row.Cells["StudentId"].Value != null)
                            {
                                int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);

                                using (SqlCommand cmd = new SqlCommand("sp_AddStudentToCompetition", con))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                                    cmd.Parameters.AddWithValue("@CompetitionId", targetCompetitionId);

                                    // 4. استخدام رقم المعلم الديناميكي (المحفوظ من الـ Constructor)
                                    cmd.Parameters.AddWithValue("@TeacherId", _teacherId);

                                    cmd.ExecuteNonQuery();
                                    successCount++;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // يمكن تسجيل الخطأ هنا إذا لزم الأمر
                        }
                    }
                }

                if (successCount > 0)
                {
                    MessageBox.Show($"تم نقل {successCount} طالب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تحديث الجدول
                    // LoadStudentsData(); 
                }
                else
                {
                    MessageBox.Show("لم يتم نقل أي طالب (قد يكونون مسجلين بالفعل في هذه المسابقة).", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        }

}