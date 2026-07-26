using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmPrintCenters_A : Form
    {
        // !!! هام جداً: قم بتغيير جملة الاتصال هذه لتطابق قاعدة بياناتك
        private string connectionString = "Your_Connection_String_Goes_Here";
        private int rowToPrint = 0; // متغير لتتبع الصفوف بين الصفحات

        public frmPrintCenters_A()
        {
            InitializeComponent();
        }

        private void frmPrintCenters_Load(object sender, EventArgs e)
        {
            LoadCentersIntoCheckedListBox();
        }

        private void LoadCentersIntoCheckedListBox()
        {
           /* using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT CenterID, CenterName FROM Centers ORDER BY CenterName";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ((ListBox)chklistCenters).DataSource = dt;
                    ((ListBox)chklistCenters).DisplayMember = "CenterName";
                    ((ListBox)chklistCenters).ValueMember = "CenterID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل تحميل قائمة المراكز. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
       */ }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var selectedCenterIds = new List<int>();
            foreach (var item in chklistCenters.CheckedItems)
            {
                var row = (item as DataRowView);
                if (row != null)
                {
                    selectedCenterIds.Add((int)row["CenterID"]);
                }
            }

            if (selectedCenterIds.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مركز واحد على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ids = string.Join(",", selectedCenterIds);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // !!! هام: تأكد من أن أسماء الأعمدة صحيحة
                    string query = $"SELECT CenterName AS [اسم المركز], City AS [المدينة], Area AS [المحلة], TeacherCount AS [عدد المحفظين], StudentCount AS [عدد الطلاب], WorkingHours AS [مواعيد العمل] FROM Centers WHERE CenterID IN ({ids})";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPrintPreview.DataSource = dt;
                    btnPrint.Enabled = true; // تفعيل زر الطباعة
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل تحميل بيانات المراكز المحددة. الخطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvPrintPreview.Rows.Count > 0)
            {
                rowToPrint = 0; // إعادة تعيين العداد قبل كل عملية طباعة
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد بيانات للطباعة. الرجاء تحميل البيانات أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // إعدادات الخطوط والألوان
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font cellFont = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);

            // إعدادات التخطيط والهوامش
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float rowHeight = 40;
            float[] columnWidths = { 150, 100, 100, 100, 100, 150 }; // عرض الأعمدة بالبكسل

            // --- طباعة رأس التقرير ---
            e.Graphics.DrawString("تقرير المراكز", new Font("Arial", 20, FontStyle.Bold), brush, e.MarginBounds.Left, y);
            y += 50;

            // --- طباعة رؤوس الأعمدة ---
            for (int i = 0; i < dgvPrintPreview.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x, y, columnWidths[i], rowHeight);
                e.Graphics.DrawRectangle(pen, x, y, columnWidths[i], rowHeight);
                e.Graphics.DrawString(dgvPrintPreview.Columns[i].HeaderText, headerFont, brush, new RectangleF(x, y, columnWidths[i], rowHeight));
                x += columnWidths[i];
            }
            y += rowHeight;

            // --- طباعة صفوف البيانات ---
            while (rowToPrint < dgvPrintPreview.Rows.Count)
            {
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    // إذا وصلنا نهاية الصفحة، نطلب صفحة جديدة
                    e.HasMorePages = true;
                    return;
                }

                x = e.MarginBounds.Left; // إعادة X إلى البداية لكل صف
                DataGridViewRow row = dgvPrintPreview.Rows[rowToPrint];
                for (int i = 0; i < dgvPrintPreview.Columns.Count; i++)
                {
                    e.Graphics.DrawRectangle(pen, x, y, columnWidths[i], rowHeight);
                    e.Graphics.DrawString(row.Cells[i].Value.ToString(), cellFont, brush, new RectangleF(x + 5, y + 5, columnWidths[i] - 10, rowHeight - 10));
                    x += columnWidths[i];
                }
                y += rowHeight;
                rowToPrint++;
            }

            // إذا انتهت جميع الصفوف
            e.HasMorePages = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
