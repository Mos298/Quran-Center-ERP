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
    public partial class eductional_level_C : UserControl
    {
        public eductional_level_C()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            frmPrintEvaluation ff = new frmPrintEvaluation("your_connection_string_here");
            ff.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            frmStudentEvaluation gg = new frmStudentEvaluation("your_connection_string_here");
            gg.ShowDialog();
        }
    }
}
