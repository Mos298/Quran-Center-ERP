using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي.C_monetor_C.Level_lerning_C;

namespace النظام_النهائي
{
    public partial class level_B : UserControl
    {
        public level_B()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacherEvaluation ff = new frmTeacherEvaluation("dbConnectionString", 1); // assuming a supervisor ID of 1 for demonstration
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          frmEditTeacherEvaluation ff = new frmEditTeacherEvaluation("dbConnectionString", "your_supervisorId_string_here");
            ff.ShowDialog();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            print_c1 printForm = new print_c1("dbConnectionString", "your_teacher_name_here");
            printForm.ShowDialog();
        }
    }
}
