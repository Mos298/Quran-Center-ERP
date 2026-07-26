using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmPrintSupervisors_A2 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private DataTable dtSupervisors = new DataTable();

        public frmPrintSupervisors_A2()
        {
            InitializeComponent();
        }

        private void frmPrintSupervisors_Load(object sender, EventArgs e)
        {
            LoadSupervisorsList();
        }

        private void LoadSupervisorsList()
        {/*
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT ID, SupervisorName FROM Supervisors";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        clbSupervisors.DataSource = dt;
                        clbSupervisors.DisplayMember = "SupervisorName";
                        clbSupervisors.ValueMember = "ID";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل قائمة المشرفين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
           */ }
     

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (clbSupervisors.CheckedItems.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مشرف واحد على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder supervisorIds = new StringBuilder();
            foreach (DataRowView item in clbSupervisors.CheckedItems)
            {
                supervisorIds.Append(item["ID"].ToString() + ",");
            }
            // إزالة الفاصلة الأخيرة
            supervisorIds.Length--;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                // لا نختار كلمة المرور للطباعة
                string query = $"SELECT ID, SupervisorName, BirthDate, Residency, Qualification, Gender, Assignment, RegistrationNumber FROM Supervisors WHERE ID IN ({supervisorIds.ToString()})";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    dtSupervisors.Clear();
                    try
                    {
                        da.Fill(dtSupervisors);
                        dgvSupervisors.DataSource = dtSupervisors;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل بيانات المشرفين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvSupervisors.Rows.Count > 0)
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("الرجاء تحميل البيانات أولاً قبل الطباعة.", "لا توجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // هذا الكود يقوم برسم الجدول للطباعة
            Graphics graphics = e.Graphics;
            Font font = new Font("Segoe UI", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 50;
            int offset = 40;

            // طباعة العنوان
            graphics.DrawString("تقرير بيانات المشرفين", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, startX, startY);
            startY += 60;

            // طباعة رؤوس الأعمدة
            for (int i = 0; i < dgvSupervisors.Columns.Count; i++)
            {
                graphics.DrawString(dgvSupervisors.Columns[i].HeaderText, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, startX + (i * 120), startY);
            }
            startY += offset;

            // طباعة صفوف البيانات
            for (int i = 0; i < dgvSupervisors.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSupervisors.Columns.Count; j++)
                {
                    object cellValue = dgvSupervisors.Rows[i].Cells[j].Value;
                    string cellText = cellValue != null ? cellValue.ToString() : "";
                    graphics.DrawString(cellText, font, Brushes.Black, startX + (j * 120), startY);
                }
                startY += offset;
            }
        }
    }
}
