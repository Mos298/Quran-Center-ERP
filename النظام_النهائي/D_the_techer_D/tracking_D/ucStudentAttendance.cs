using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using النظام_النهائي.D_the_techer_D.tracking_D;

namespace النظام_النهائي
{
    public partial class ucStudentAttendance : UserControl
    {
        public string ConnectionString { get; set; }
        public string TeacherName { get; set; } // لتحديد طلاب الشيخ الحالي

        private List<AttendanceRecord> _attendanceList;
        private Bitmap _bitmap;

        public ucStudentAttendance()
        {
            InitializeComponent();
        }

        /// <summary>
        /// تحميل بيانات الطلاب التابعين للشيخ الحالي وتسجيل الحضور لليوم الحالي
        /// </summary>
        public void LoadData()
        {
            if (string.IsNullOrEmpty(ConnectionString) || string.IsNullOrEmpty(TeacherName))
            {
                MessageBox.Show("لم يتم تحديد بيانات الشيخ أو جملة الاتصال.");
                return;
            }

            lblCurrentDate.Text = DateTime.Now.ToString("yyyy/MM/dd");

            try
            {
                _attendanceList = new List<AttendanceRecord>();
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    // 1. جلب قائمة الطلاب التابعين لهذا الشيخ
                    string studentsQuery = "SELECT ID, FullName, RegistrationNumber FROM Students WHERE TeacherName = @TeacherName";
                    SqlCommand studentsCmd = new SqlCommand(studentsQuery, con);
                    studentsCmd.Parameters.AddWithValue("@TeacherName", TeacherName);

                    using (SqlDataReader reader = studentsCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _attendanceList.Add(new AttendanceRecord
                            {
                                StudentId = Convert.ToInt32(reader["ID"]),
                                FullName = reader["FullName"].ToString(),
                                RegistrationNumber = reader["RegistrationNumber"].ToString(),
                                Status = "حاضر" // القيمة الافتراضية
                            });
                        }
                    }

                    // 2. التحقق من وجود سجلات حضور محفوظة لليوم الحالي
                    string attendanceQuery = "SELECT StudentID, Status FROM Attendance WHERE AttendanceDate = @Today AND StudentID IN (SELECT ID FROM Students WHERE TeacherName = @TeacherName)";
                    SqlCommand attendanceCmd = new SqlCommand(attendanceQuery, con);
                    attendanceCmd.Parameters.AddWithValue("@Today", DateTime.Today);
                    attendanceCmd.Parameters.AddWithValue("@TeacherName", TeacherName);

                    using (SqlDataReader reader = attendanceCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentId = Convert.ToInt32(reader["StudentID"]);
                            string status = reader["Status"].ToString();

                            var record = _attendanceList.FirstOrDefault(a => a.StudentId == studentId);
                            if (record != null)
                            {
                                record.Status = status;
                            }
                        }
                    }
                }

                SetupDataGridView();
                dgvAttendance.DataSource = _attendanceList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات الحضور: \n" + ex.Message);
            }
        }

        /// <summary>
        /// إعداد أعمدة ومظهر جدول البيانات
        /// </summary>
        private void SetupDataGridView()
        {
            dgvAttendance.AutoGenerateColumns = false;
            dgvAttendance.Columns.Clear();

            // إضافة أعمدة البيانات
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "اسم الطالب", DataPropertyName = "FullName", Name = "FullName", ReadOnly = true, FillWeight = 150 });
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "رقم القيد", DataPropertyName = "RegistrationNumber", Name = "RegistrationNumber", ReadOnly = true });

            // إضافة عمود القائمة المنسدلة للحالة
            var statusColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "الحالة",
                DataPropertyName = "Status",
                Name = "Status",
                FlatStyle = FlatStyle.Flat
            };
            statusColumn.Items.AddRange("حاضر", "غائب", "متأخر", "بإذن");
            dgvAttendance.Columns.Add(statusColumn);
        }

        /// <summary>
        /// يتم استدعاؤها عند الضغط على زر "حفظ"
        /// </summary>
        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    foreach (var record in _attendanceList)
                    {
                        // استخدام MERGE للقيام بـ INSERT أو UPDATE في خطوة واحدة (UPSERT)
                        string query = @"
                            MERGE Attendance AS target
                            USING (SELECT @StudentID AS StudentID, @AttendanceDate AS AttendanceDate) AS source
                            ON (target.StudentID = source.StudentID AND target.AttendanceDate = source.AttendanceDate)
                            WHEN MATCHED THEN 
                                UPDATE SET Status = @Status
                            WHEN NOT MATCHED THEN
                                INSERT (StudentID, AttendanceDate, Status)
                                VALUES (source.StudentID, source.AttendanceDate, @Status);";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StudentID", record.StudentId);
                        cmd.Parameters.AddWithValue("@AttendanceDate", DateTime.Today);
                        cmd.Parameters.AddWithValue("@Status", record.Status);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("تم حفظ سجل الحضور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ سجل الحضور: \n" + ex.Message);
            }
        }

        /// <summary>
        /// يتم استدعاؤها عند الضغط على زر "طباعة"
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            _bitmap = new Bitmap(this.dgvAttendance.Width, this.dgvAttendance.Height);
            dgvAttendance.DrawToBitmap(_bitmap, new Rectangle(0, 0, this.dgvAttendance.Width, this.dgvAttendance.Height));
            e.Graphics.DrawImage(_bitmap, 10, 10);
        }

        private void lblCurrentDate_Click(object sender, EventArgs e)
        {

        }
    }
}
