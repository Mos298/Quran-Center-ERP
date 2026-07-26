using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace النظام_النهائي.C_monetor_C.tracking_C
{
    public partial class frmTeacherAttendance : Form
    {
        private string _connectionString;
        private int _supervisorId;
        private string v1;
        private string v2;

        // فئات مساعدة لتخزين بيانات القوائم المنسدلة
        private class Center { public int Id { get; set; } public string Name { get; set; } }
        private class Teacher { public int Id { get; set; } public string Name { get; set; } }

        public frmTeacherAttendance(string dbConnectionString, int supervisorId)
        {
            InitializeComponent();
            _connectionString = dbConnectionString;
            _supervisorId = supervisorId;
        }

        public frmTeacherAttendance(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        private void frmTeacherAttendance_Load(object sender, EventArgs e)
        {
            LoadAssignedCenters();
        }

        /// <summary>
        /// تحميل المراكز المكلف بها المشرف فقط
        /// </summary>
        private void LoadAssignedCenters()
        {
            var centers = new List<Center>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = "SELECT c.ID, c.CenterName FROM Centers c JOIN SupervisorAssignments sa ON c.ID = sa.CenterID WHERE sa.SupervisorID = @SupervisorID";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@SupervisorID", _supervisorId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        centers.Add(new Center { Id = Convert.ToInt32(row["ID"]), Name = row["CenterName"].ToString() });
                    }

                    cmbCenters.DataSource = centers;
                    cmbCenters.DisplayMember = "Name";
                    cmbCenters.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المراكز: \n" + ex.Message);
            }
        }

        /// <summary>
        /// عند اختيار مركز، يتم تحميل المحفظين التابعين له
        /// </summary>
        private void cmbCenters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedValue == null) return;

            int selectedCenterId = (int)cmbCenters.SelectedValue;
            LoadTeachersForCenter(selectedCenterId);
        }

        private void LoadTeachersForCenter(int centerId)
        {
            var teachers = new List<Teacher>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = "SELECT t.ID, t.TeacherName FROM Teachers t JOIN CenterAssignments ca ON t.ID = ca.TeacherID WHERE ca.CenterID = @CenterID";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@CenterID", centerId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        teachers.Add(new Teacher { Id = Convert.ToInt32(row["ID"]), Name = row["TeacherName"].ToString() });
                    }

                    cmbTeachers.DataSource = teachers;
                    cmbTeachers.DisplayMember = "Name";
                    cmbTeachers.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المحفظين: \n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedValue == null || cmbTeachers.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المركز والمحفِّظ أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string status = grpAttendance.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

            if (status == null)
            {
                MessageBox.Show("الرجاء تحديد حالة الحضور.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // نفترض وجود جدول 'TeacherAttendance' لتخزين سجلات الحضور
                    string query = @"INSERT INTO TeacherAttendance 
                                     (TeacherID, CenterID, SupervisorID, Status, VisitDate, RecordDate) 
                                     VALUES 
                                     (@TeacherID, @CenterID, @SupervisorID, @Status, @VisitDate, @RecordDate)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TeacherID", (int)cmbTeachers.SelectedValue);
                    cmd.Parameters.AddWithValue("@CenterID", (int)cmbCenters.SelectedValue);
                    cmd.Parameters.AddWithValue("@SupervisorID", _supervisorId);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@VisitDate", dtpVisitDate.Value);
                    cmd.Parameters.AddWithValue("@RecordDate", DateTime.Now); // تاريخ تسجيل البيانات الحالي

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم حفظ سجل الحضور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات: \n" + ex.Message);
            }
        }
    }
}
