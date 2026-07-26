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
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
            LoadUserControl(new tracking_B());
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
            LoadUserControl(new tracking_B());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new level_B());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new the_report_B());
        }
    }
}
