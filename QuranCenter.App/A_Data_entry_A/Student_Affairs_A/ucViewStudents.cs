using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms; // Keep this for WinForms controls

namespace النظام_النهائي
{
    public partial class ucViewStudents : System.Windows.Forms.UserControl // Fully qualify UserControl
    {
        // جملة الاتصال - يجب أن تكون عامة ليتمكن النموذج الرئيسي من تزويدنا بها
        public string ConnectionString { get; set; } = "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;";

        // قائمة لتخزين جميع الطلاب الذين يتم تحميلهم
        private List<Student> _allStudents;

        public ucViewStudents()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        /// <summary>
        /// هذه الدالة هي نقطة البداية. يتم استدعاؤها من النموذج الرئيسي بعد عرض الواجهة
        /// </summary>
        public void LoadData()
        {
           /*
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    // استعلام لجلب كل بيانات الطلاب
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // تحويل البيانات من DataTable إلى List<Student>
                    _allStudents = dt.AsEnumerable().Select(row => new Student
                    {
                        Id = row.Field<int>("ID"),
                        FullName = row.Field<string>("FullName"),
                        GuardianName = row.Field<string>("GuardianName"),
                        BirthDate = row.Field<DateTime>("BirthDate"),
                        Nationality = row.Field<string>("Nationality"),
                        Residence = row.Field<string>("Residence"),
                        Gender = row.Field<string>("Gender"),
                        NationalID = row.Field<string>("NationalID"),
                        StudentPhone = row.Field<string>("StudentPhone"),
                        GuardianPhone = row.Field<string>("GuardianPhone"),
                        RegistrationNumber = row.Field<string>("RegistrationNumber"),
                        Password = row.Field<string>("Password")
                    }).ToList();

                    // إعداد الجدول قبل ربط البيانات
                    SetupDataGridView();
                    dgvStudents.DataSource = _allStudents;
                }
          
            */

        }   




        private void SetupDataGridView()
        {
            dgvStudents.RightToLeft = RightToLeft.Yes;
            dgvStudents.AutoGenerateColumns = false;

            dgvStudents.Columns.Clear(); // مسح الأعمدة الموجودة لضمان عدم تكرارها

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn { HeaderText = "تحديد", Name = "colSelect", Width = 50 };
            dgvStudents.Columns.Add(chkColumn);

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "اسم الطالب", DataPropertyName = "FullName", FillWeight = 150 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "GuardianName", HeaderText = "اسم ولي الأمر", DataPropertyName = "GuardianName", FillWeight = 150 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "RegistrationNumber", HeaderText = "رقم القيد", DataPropertyName = "RegistrationNumber" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "NationalID", HeaderText = "الرقم الوطني", DataPropertyName = "NationalID" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentPhone", HeaderText = "رقم الهاتف", DataPropertyName = "StudentPhone" });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvStudents.DataSource = _allStudents;
            }
            else
            {
                dgvStudents.DataSource = _allStudents.Where(s =>
                    s.FullName.ToLower().Contains(searchText) ||
                    s.RegistrationNumber.Contains(searchText) ||
                    s.NationalID.Contains(searchText)
                ).ToList();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<int> selectedStudentIds = GetSelectedStudentIds();
            if (selectedStudentIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل للطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string message = "سيتم طباعة بيانات الطلاب أصحاب الهويات التالية:\n" + string.Join(", ", selectedStudentIds);
            MessageBox.Show(message, "عملية طباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            List<int> selectedStudentIds = GetSelectedStudentIds();
            if (selectedStudentIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل لتعيين كلمة المرور.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    // استخدام IN clause لتحديث كل الطلاب المحددين مرة واحدة
                    string query = $"UPDATE Students SET Password = @Password WHERE ID IN ({string.Join(",", selectedStudentIds)})";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Password", "0000");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"تم تعيين كلمة المرور لـ {rowsAffected} طالب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // إعادة تحميل البيانات لتحديث الواجهة
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحديث كلمة المرور: \n" + ex.Message);
            }
        }

        /// <summary>
        /// دالة مساعدة للحصول على قائمة هويات الطلاب المحددين في الجدول
        /// </summary>
        private List<int> GetSelectedStudentIds()
        {
            List<int> selectedIds = new List<int>();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value))
                {
                    Student student = row.DataBoundItem as Student;
                    if (student != null)
                    {
                        selectedIds.Add(student.Id);
                    }
                }
            }
            return selectedIds;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

