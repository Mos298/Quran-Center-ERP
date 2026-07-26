using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي.E_Student_E.tracking_Level_D;

namespace النظام_النهائي
{
    public partial class Form_E : Form
    {
        public Form_E()
        {
            InitializeComponent();
            LoadUserControl(new home());
        }
        private void LoadUserControl(UserControl userControl)
        {
            // اجعل الواجهة تملأ اللوحة بالكامل
            userControl.Dock = DockStyle.Fill;
            // نظّف اللوحة من أي محتوى قديم
            mainContentPanel.Controls.Clear();
            // أضف الواجهة الجديدة لعرضها
            mainContentPanel.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new home());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucStudentEvaluationCard());
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // LoadUserControl(new student_thereport_D());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يحتوي على سجلة التعلمي المشايخ و التقدير العامي لكل شسخ و مشاركاته في المسابقات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
