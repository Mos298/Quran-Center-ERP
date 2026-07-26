using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class Form_C : Form
    {
        public Form_C()
        {
            InitializeComponent();
            LoadUserControl(new student_C());
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
        private void Form_C_Load(object sender, EventArgs e)
        {

        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new student_C());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new tracking_C());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new eductional_level_C());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new the_report_C());
        }
    }
}
