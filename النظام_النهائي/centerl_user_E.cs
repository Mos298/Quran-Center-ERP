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
    public partial class centerl_user_E : UserControl
    {
        public centerl_user_E()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddTeacherVisit addForm = new frmAddTeacherVisit();
            addForm.ShowDialog();
        }
    }
}
