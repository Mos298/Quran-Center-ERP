using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class ucRegistrationRequests : UserControl
    {
        public string ConnectionString { get; set; }
        private List<Student> _pendingStudents;

        public ucRegistrationRequests()
        {
            InitializeComponent();
        }

        /// <summary>
        /// تحميل بيانات الطلاب الذين ينتظرون الموافقة
        /// </summary>
        public void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    // نفترض أن لديك حقل 'Status' لتحديد حالة الطالب
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students WHERE Status = N'Pending'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    _pendingStudents = dt.AsEnumerable().Select(row => new Student
                    {
                        Id = row.Field<int>("ID"),
                        FullName = row.Field<string>("FullName"),
                        GuardianName = row.Field<string>("GuardianName"),
                        // ... أكمل باقي الحقول
                        RegistrationNumber = row.Field<string>("RegistrationNumber"),
                        NationalID = row.Field<string>("NationalID"),
                    }).ToList();

                    SetupDataGridView();
                    dgvRequests.DataSource = _pendingStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل طلبات التسجيل: \n" + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvRequests.RightToLeft = RightToLeft.Yes;
            dgvRequests.AutoGenerateColumns = false;
            dgvRequests.Columns.Clear();

            dgvRequests.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "تحديد", Name = "colSelect", Width = 50 });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "اسم الطالب", DataPropertyName = "FullName", FillWeight = 150 });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "GuardianName", HeaderText = "اسم ولي الأمر", DataPropertyName = "GuardianName", FillWeight = 150 });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "RegistrationNumber", HeaderText = "رقم القيد", DataPropertyName = "RegistrationNumber" });
            dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "NationalID", HeaderText = "الرقم الوطني", DataPropertyName = "NationalID" });
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

        private void btnApprove_Click(object sender, EventArgs e)
        {
            List<int> selectedStudentIds = GetSelectedStudentIds();
            if (selectedStudentIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل للموافقة عليه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = $"UPDATE Students SET Status = N'Active' WHERE ID IN ({string.Join(",", selectedStudentIds)})";
                    SqlCommand cmd = new SqlCommand(query, con);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"تمت الموافقة على {rowsAffected} طالب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // إعادة تحميل البيانات لتحديث الواجهة
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الموافقة على الطلاب: \n" + ex.Message);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            List<int> selectedStudentIds = GetSelectedStudentIds();
            if (selectedStudentIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل لرفضه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("هل أنت متأكد من حذف طلبات التسجيل المحددة؟ هذا الإجراء لا يمكن التراجع عنه.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"تم حذف {rowsAffected} طلب تسجيل بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حذف الطلبات: \n" + ex.Message);
                }
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
            string message = "سيتم طباعة بيانات الطلبات التالية:\n" + string.Join(", ", selectedStudentIds);
            MessageBox.Show(message, "عملية طباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
