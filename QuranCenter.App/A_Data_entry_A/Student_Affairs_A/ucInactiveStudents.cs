using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class ucInactiveStudents : UserControl
    {
        public string ConnectionString { get; set; }
        private List<Student> _inactiveStudents;

        public ucInactiveStudents()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
          /*  try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students WHERE Status = N'Inactive'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    _inactiveStudents = dt.AsEnumerable().Select(row => new Student
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

                    SetupDataGridView();
                    dgvInactiveStudents.DataSource = _inactiveStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات الطلاب المنقطعين: \n" + ex.Message);
            }*/
        }

        private void SetupDataGridView()
        {
            dgvInactiveStudents.RightToLeft = RightToLeft.Yes;
            dgvInactiveStudents.AutoGenerateColumns = false;
            dgvInactiveStudents.Columns.Clear();

            // تم حذف عمود زر التنشيط من هنا

            dgvInactiveStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "اسم الطالب", DataPropertyName = "FullName", FillWeight = 150 });
            dgvInactiveStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "RegistrationNumber", HeaderText = "رقم القيد", DataPropertyName = "RegistrationNumber" });
            dgvInactiveStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "NationalID", HeaderText = "الرقم الوطني", DataPropertyName = "NationalID" });
            dgvInactiveStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "GuardianPhone", HeaderText = "رقم هاتف ولي الأمر", DataPropertyName = "GuardianPhone" });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_inactiveStudents == null) return;
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvInactiveStudents.DataSource = _inactiveStudents;
            }
            else
            {
                dgvInactiveStudents.DataSource = _inactiveStudents.Where(s =>
                    s.FullName.ToLower().Contains(searchText) ||
                    s.RegistrationNumber.Contains(searchText) ||
                    s.NationalID.Contains(searchText)
                ).ToList();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInactiveStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل للطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // كود الطباعة يمكن إضافته هنا
            MessageBox.Show($"سيتم طباعة بيانات {dgvInactiveStudents.SelectedRows.Count} طالب.", "عملية طباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
          /*  if (dgvInactiveStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد طالب واحد على الأقل للتنشيط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            // الحصول على بيانات الطالب من الصف المحدد
         //   Student selectedStudent = dgvInactiveStudents.SelectedRows[0].DataBoundItem as Student;
          
            // فتح نافذة التعديل والتنشيط
            frmEditStudent ff = new frmEditStudent();
            ff.ShowDialog();
           
        } 
        }
    }


