using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using System.Drawing.Imaging;
using System.Windows.Forms;
using النظام_النهائي.C_monetor_C.Home_page_C;

namespace النظام_النهائي
{
    public partial class Form_C : Form
    {
        public Form_C()
        {
            InitializeComponent();
            LoadUserControl(new home_c());
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
            LoadUserControl(new home_c());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
