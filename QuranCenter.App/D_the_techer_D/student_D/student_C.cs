using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Make sure to add the correct using directive for frmEditStudent_c
// If frmEditStudent_c is in another namespace, replace النظام_النهائي with the correct one

using النظام_النهائي.D_the_techer_D.student_D; // Or update to the actual namespace where frmEditStudent_c is defined

namespace النظام_النهائي
{
    public partial class student_C : UserControl
    {
        public student_C()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here";// Replace with your actual connection string
            /* editForm = new frmEditStudent(connectionString);
             editForm.ShowDialog();

             */
            frmEditStudent_s editForm = new frmEditStudent_s(connectionString);

            // 2. إظهار النموذج كنافذة منبثقة
            editForm.ShowDialog();



        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here"; // Replace with your actual connection string
            frmAddStudent gg = new frmAddStudent(connectionString);
            gg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAssignExistingStudent jk = new frmAssignExistingStudent("your_connection_string_here", "current_teacher_name_here");
            jk.ShowDialog();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            frmPrintStudents ggf = new frmPrintStudents("your_connection_string_here", "current_teacher_name_here");
            ggf.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAssignExistingStudent fgk = new frmAssignExistingStudent("your_connection_string_here", "current_teacher_name_here");
            fgk.ShowDialog();
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            frmPrintStudents ff = new frmPrintStudents("your_connection_string_here", "current_teacher_name_here");
            ff.ShowDialog();
        }

        private void actionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmRemoveStudent ff = new frmRemoveStudent("your_connection_string_here", "current_teacher_name_here");
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           frmRequestStudentTransfer ff = new frmRequestStudentTransfer("your_connection_string_here", "current_teacher_name_here", "current_teacherRegNumber");
            ff.ShowDialog();
        }
    }
}
