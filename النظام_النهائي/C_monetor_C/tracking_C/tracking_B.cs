using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي.C_monetor_C.tracking_C;

namespace النظام_النهائي
{
    public partial class tracking_B : UserControl
    {
        private string v1;
        private int v2;

        public tracking_B()
        {
            InitializeComponent();
        }

        private void actionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance Ff = new frmTeacherAttendance(v1, v2);
            Ff.ShowDialog();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            print_c printForm = new print_c(v1, "your_teacher_name_here");  
            printForm.ShowDialog();
        }
    }
}
