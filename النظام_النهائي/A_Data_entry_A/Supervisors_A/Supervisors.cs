using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace النظام_النهائي
{
    public partial class Supervisors : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataTable dtSupervisors = new DataTable();

        public Supervisors()
        {
            InitializeComponent();

            // الإعدادات الأولية
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.RightToLeft = RightToLeft.Yes;

            this.Load += Supervisors_Load;

            if (searchBox != null) searchBox.TextChanged += SearchBox_TextChanged;
        }

        private void Supervisors_Load(object sender, EventArgs e)
        {
            LoadSupervisorsData();
        }

        public void LoadSupervisorsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("sp_GetAllSupervisors", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        dtSupervisors.Clear();
                        da.Fill(dtSupervisors);

                        dataGridView1.DataSource = dtSupervisors;
                        FormatGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        // =========================================================
        // دالة التنسيق الجديدة (حسب الأعمدة المطلوبة)
        // =========================================================
        private void FormatGrid()
        {
            // 1. المظهر العام (التصميم الأخضر)
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;

            // تنسيق الرأس
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // تنسيق الصفوف
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 255, 253);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 245, 238);
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowTemplate.Height = 35;

            // 2. تعريب الأعمدة وترتيبها حسب طلبك

            // 1. اسم المشرف
            if (dataGridView1.Columns.Contains("FullName"))
            {
                dataGridView1.Columns["FullName"].HeaderText = "اسم المشرف";
                dataGridView1.Columns["FullName"].DisplayIndex = 0;
                dataGridView1.Columns["FullName"].FillWeight = 150;
            }

            // 2. رقم القيد
            if (dataGridView1.Columns.Contains("RegistrationNumber"))
            {
                dataGridView1.Columns["RegistrationNumber"].HeaderText = "رقم القيد";
                dataGridView1.Columns["RegistrationNumber"].DisplayIndex = 1;
            }

            // 3. تاريخ الميلاد
            if (dataGridView1.Columns.Contains("BirthDate"))
            {
                dataGridView1.Columns["BirthDate"].HeaderText = "تاريخ الميلاد";
                dataGridView1.Columns["BirthDate"].DisplayIndex = 2;
                dataGridView1.Columns["BirthDate"].DefaultCellStyle.Format = "yyyy/MM/dd"; // تنسيق التاريخ
            }

            // 4. الإقامة
            if (dataGridView1.Columns.Contains("Residence"))
            {
                dataGridView1.Columns["Residence"].HeaderText = "الإقامة";
                dataGridView1.Columns["Residence"].DisplayIndex = 3;
            }

            // 5. المؤهل العلمي
            if (dataGridView1.Columns.Contains("Qualification"))
            {
                dataGridView1.Columns["Qualification"].HeaderText = "المؤهل العلمي";
                dataGridView1.Columns["Qualification"].DisplayIndex = 4;
            }

            // 6. الجنس
            if (dataGridView1.Columns.Contains("Gender"))
            {
                dataGridView1.Columns["Gender"].HeaderText = "الجنس";
                dataGridView1.Columns["Gender"].DisplayIndex = 5;
                // تقليص حجم العمود لأنه كلمة قصيرة
                dataGridView1.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            // 7. التكليف
            if (dataGridView1.Columns.Contains("AssignmentType"))
            {
                dataGridView1.Columns["AssignmentType"].HeaderText = "التكليف";
                dataGridView1.Columns["AssignmentType"].DisplayIndex = 6;
            }

            // 8. رقم الهاتف
            if (dataGridView1.Columns.Contains("PhoneNumber"))
            {
                dataGridView1.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
                dataGridView1.Columns["PhoneNumber"].DisplayIndex = 7;
            }

            // 9. الرقم الوطني
            if (dataGridView1.Columns.Contains("NationalId"))
            {
                dataGridView1.Columns["NationalId"].HeaderText = "الرقم الوطني";
                dataGridView1.Columns["NationalId"].DisplayIndex = 8;
            }

            // إخفاء الأعمدة غير المطلوبة
            if (dataGridView1.Columns.Contains("UserId")) dataGridView1.Columns["UserId"].Visible = false;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtSupervisors.Rows.Count > 0)
                {
                    string searchValue = searchBox.Text;
                    // تم توسيع البحث ليشمل الحقول الجديدة
                    string filter = string.Format(
                        "FullName LIKE '%{0}%' OR RegistrationNumber LIKE '%{0}%' OR PhoneNumber LIKE '%{0}%' OR NationalId LIKE '%{0}%'",
                        searchValue);
                    dtSupervisors.DefaultView.RowFilter = filter;
                }
            }
            catch { }
        }

        // (باقي الأزرار كما هي في الكود السابق)
        private void addButton_Click(object sender, EventArgs e)
        {
            frmAddSupervisor_A2 frm = new frmAddSupervisor_A2();
            if (frm.ShowDialog() == DialogResult.OK) LoadSupervisorsData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frmEditSupervisor_A2 frm = new frmEditSupervisor_A2();
                if (frm.ShowDialog() == DialogResult.OK) LoadSupervisorsData();
            }
            else MessageBox.Show("يرجى تحديد مشرف");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frmDeleteSupervisor_A2 frm = new frmDeleteSupervisor_A2();
                if (frm.ShowDialog() == DialogResult.OK) LoadSupervisorsData();
            }
            else MessageBox.Show("يرجى تحديد مشرف");
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            frmPrintSupervisors_A2 frm = new frmPrintSupervisors_A2();
            frm.ShowDialog();
        }

        private void actionsPanel_Paint(object sender, PaintEventArgs e) { }
    }
}