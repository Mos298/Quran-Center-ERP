using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmPrintMentors_A3 : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        Bitmap memoryImage;

        public frmPrintMentors_A3()
        {
            InitializeComponent();
        }

        private void frmPrintMentors_Load(object sender, EventArgs e)
        {
            LoadMentorsToListBox();
        }

        private void LoadMentorsToListBox()
        {
     /*       using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                string query = "SELECT MentorName FROM Mentors";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            checkedListBoxMentors.Items.Add(reader["MentorName"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل قائمة الموجهين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
     */   }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMentors.CheckedItems.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد موجه واحد على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // بناء جملة IN في SQL
            string inClause = "";
            foreach (object item in checkedListBoxMentors.CheckedItems)
            {
                inClause += $"'{item.ToString().Replace("'", "''")}',"; // Replace ' for safety
            }
            inClause = inClause.TrimEnd(',');

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة. لا نختار كلمة المرور
                string query = $"SELECT ID, MentorName, BirthDate, Residency, Qualification, Gender, Assignment, RegistrationNumber FROM Mentors WHERE MentorName IN ({inClause})";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMentors.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل بيانات الموجهين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvMentors.Rows.Count > 0)
            {
                CaptureScreen();
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد بيانات للطباعة. الرجاء تحميل البيانات أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CaptureScreen()
        {
            // إنشاء صورة بحجم الـ DataGridView
            memoryImage = new Bitmap(this.dgvMentors.Width, this.dgvMentors.Height);
            // رسم الـ DataGridView على الصورة
            dgvMentors.DrawToBitmap(memoryImage, new Rectangle(0, 0, this.dgvMentors.Width, this.dgvMentors.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // رسم الصورة الملتقطة على صفحة الطباعة
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void dgvMentors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
