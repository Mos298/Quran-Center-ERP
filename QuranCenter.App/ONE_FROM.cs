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
    public partial class ONE_FROM : Form
    {
        public ONE_FROM()
        {
            InitializeComponent();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            loginA ff = new loginA();
            this.Hide();
            ff.ShowDialog();
           this.Close();
           // this.Hide();

            // 2. إخفاء الفورم الحالي (الفورم الأول) حتى لا يظهر للمستخدم
            // Form2 استبدل كلمة
            // باسم الفورم الموجود لديك في متصفح الحلول


            // 2. إخفاء الفورم الحالي (الفورم الأول) حتى لا يظهر للمستخدم
            //  this.Hide();

            // 3. فتح الفورم الثاني بطريقة (Dialog)


            // 4. هذا السطر لن يعمل إلا بعد إغلاق الفورم الثاني
            // نقوم بإعادة إظهار الفورم الأول
            //  this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
