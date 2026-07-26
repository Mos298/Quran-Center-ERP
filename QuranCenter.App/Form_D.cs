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
    public partial class Form_D : Form
    {
        public Form_D()
        {
            InitializeComponent();
            LoadUserControl(new data_student_D());
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
            LoadUserControl(new data_student_D());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new traking_D());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new student_thereport_D());
        }
    }
}
