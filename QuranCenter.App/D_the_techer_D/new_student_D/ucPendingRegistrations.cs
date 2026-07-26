using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace النظام_النهائي
{
    // The class now correctly inherits from UserControl
    public partial class ucPendingRegistrations : UserControl
    {
        public string ConnectionString { get; set; }
        private List<Student> _pendingStudents;

        public ucPendingRegistrations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// تحميل طلبات التسجيل المعلقة من قاعدة البيانات
        /// </summary>
        public void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    // نفترض أن لديك حقل 'Status' وحالته 'Pending' للطلبات المعلقة
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students WHERE Status = N'Pending'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    _pendingStudents = dt.AsEnumerable().Select(row => new Student
                    {
                        Id = row.Field<int>("ID"),
                        FullName = row.Field<string>("FullName"),
                        RegistrationNumber = row.Field<string>("RegistrationNumber"),
                        NationalID = row.Field<string>("NationalID"),
                        StudentPhone = row.Field<string>("StudentPhone")
                        // يمكنك إضافة باقي الحقول إذا أردت عرضها
                    }).ToList();

                    SetupDataGridView();
                    dgvRequests.DataSource = _pendingStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الطلبات المعلقة: \n" + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvRequests.AutoGenerateColumns = false;
            dgvRequests.Columns.Clear();

            dgvRequests.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "تحديد", Name = "colSelect", Width = 50 });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "اسم الطالب", DataPropertyName = "FullName", FillWeight = 150 });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "RegistrationNumber", HeaderText = "رقم القيد", DataPropertyName = "RegistrationNumber" });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "NationalID", HeaderText = "الرقم الوطني", DataPropertyName = "NationalID" });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentPhone", HeaderText = "رقم الهاتف", DataPropertyName = "StudentPhone" });
        }

        /// <summary>
        /// فتح نموذج إضافة طالب جديد لإرسال طلب تسجيل
        /// </summary>
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            // نفترض أن لديك نموذج frmAddStudent جاهز
            frmAddStudent addForm = new frmAddStudent(ConnectionString);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // إعادة تحميل البيانات بعد إضافة طلب جديد بنجاح
                LoadData();
            }
        }

        /// <summary>
        /// حذف طلبات التسجيل المحددة
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selectedStudentIds = GetSelectedStudentIds();
            if (selectedStudentIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طلب واحد على الأقل لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"هل أنت متأكد من حذف {selectedStudentIds.Count} طلب تسجيل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        string query = $"DELETE FROM Students WHERE ID IN ({string.Join(",", selectedStudentIds)})";
                        SqlCommand cmd = new SqlCommand(query, con);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"تم حذف {rowsAffected} طلب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حذف الطلبات: \n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// طباعة الطلبات المحددة
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            print_Form ff = new print_Form(); ff.ShowDialog();
            List<int> selectedStudentIds = GetSelectedStudentIds();
            if (selectedStudentIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طلب واحد على الأقل للطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // يمكنك هنا استبدال هذه الرسالة بكود الطباعة الفعلي
            string message = "سيتم طباعة بيانات الطلبات التالية:\n" + string.Join(", ", selectedStudentIds);
            MessageBox.Show(message, "عملية طباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_pendingStudents == null) return;
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvRequests.DataSource = _pendingStudents;
            }
            else
            {
                dgvRequests.DataSource = _pendingStudents.Where(s =>
                    s.FullName.ToLower().Contains(searchText) ||
                    s.RegistrationNumber.Contains(searchText) ||
                    s.NationalID.Contains(searchText)
                ).ToList();
            }
        }

        private List<int> GetSelectedStudentIds()
        {
            List<int> selectedIds = new List<int>();
            foreach (DataGridViewRow row in dgvRequests.Rows)
            {
                if (row.Cells["colSelect"].Value != null && Convert.ToBoolean(row.Cells["colSelect"].Value))
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
    }
}

