using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class print_Form : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        Bitmap bmp;

        public print_Form()
        {
            InitializeComponent();
        }

        private void frmPrintTeachers_Load(object sender, EventArgs e)
        {
            LoadTeachersToList();
        }

        private void LoadTeachersToList()
        {
            /*     using (SqlConnection con = new SqlConnection(connectionString))
                 {
                     // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                     string query = "SELECT ID, TeacherName FROM Teachers ORDER BY TeacherName";
                     using (SqlCommand cmd = new SqlCommand(query, con))
                     {
                         try
                         {
                             con.Open();
                             SqlDataReader reader = cmd.ExecuteReader();
                             while (reader.Read())
                             {
                                 chklstTeachers.Items.Add(new { Text = reader["TeacherName"].ToString(), Value = reader["ID"] });
                             }
                             chklstTeachers.DisplayMember = "Text";
                             chklstTeachers.ValueMember = "Value";
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show("فشل تحميل قائمة المحفظين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                     }
                 }
        */
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (chklstTeachers.CheckedItems.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد محفّظ واحد على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<int> selectedIds = new List<int>();
            foreach (var item in chklstTeachers.CheckedItems)
            {
                selectedIds.Add((int)item.GetType().GetProperty("Value").GetValue(item, null));
            }

            string ids = string.Join(",", selectedIds);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // !!! هام: تأكد من أن أسماء الجدول والأعمدة صحيحة
                // تم استبعاد عمود كلمة المرور من الطباعة
                string query = $"SELECT ID, TeacherName, BirthDate, Residency, Qualification, Gender, Assignment, RegistrationNumber FROM Teachers WHERE ID IN ({ids})";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvPrintPreview.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("فشل تحميل بيانات المحفظين. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvPrintPreview.Rows.Count > 0)
            {
                int height = dgvPrintPreview.Height;
                dgvPrintPreview.Height = dgvPrintPreview.RowCount * dgvPrintPreview.RowTemplate.Height * 2;
                bmp = new Bitmap(dgvPrintPreview.Width, dgvPrintPreview.Height);
                dgvPrintPreview.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPrintPreview.Width, dgvPrintPreview.Height));
                dgvPrintPreview.Height = height;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد بيانات للطباعة. الرجاء تحميل البيانات أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
