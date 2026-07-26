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
    public partial class EditDataForm : Form
    {
        public EditDataForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("صباحاً");
            comboBox1.Items.Add("مساءً");

            // Optional: Set a default selected item to avoid the error if the user doesn't make a choice.
            comboBox1.SelectedIndex = 0;
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string studentCount = txtStudentCount.Text;
            string centerName = txtCenterName.Text;
            MessageBox.Show($"تم حفظ البيانات بنجاح!\nعدد الطلاب: {studentCount}\nاسم المركز: {centerName}");
            // Check if an item is selected in the ComboBox before using it
            if (comboBox1.SelectedItem != null)
            {
                int selectedHour = (int)numericUpDown2.Value;
                string amPm = comboBox1.SelectedItem.ToString();

                string timeString = selectedHour + " " + amPm;

                MessageBox.Show("الوقت الذي تم اختياره هو: " + timeString);

                // ... rest of your code to save the data
            }
            else
            {
                // Tell the user to select an item
                MessageBox.Show("الرجاء اختيار 'صباحاً' أو 'مساءً'");
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // هذا هو المكان المثالي لملء القوائم المنسدلة بالبيانات
            // مثال: ملء قائمة المدن
            cmbCity.Items.Add("طرابلس");
            cmbCity.Items.Add("بنغازي");
            cmbCity.Items.Add("مصراتة");

            // مثال: ملء قائمة السور
            cmbSurah.Items.Add("الفاتحة");
            cmbSurah.Items.Add("البقرة");
            cmbSurah.Items.Add("آل عمران");
        }

        private void btnDeleteMastery_Click(object sender, EventArgs e)
        {
            txtStudentCount.Clear();
            numericUpDown2.Accelerations.Clear();
            txtTeacherName.Clear();
            txtCenterName.Clear();
            cmbSurah.SelectedIndex = -1; // لإلغاء الاختيار
            cmbCity.SelectedIndex = -1;
        }

        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            txtNotes.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق الواجهة الحالية
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

      

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 12)
            {
                // Change the AM/PM ComboBox to the next value.
                // If the ComboBox's index is 0 ("صباحاً"), it will change to 1 ("مساءً").
                // We use the remainder operator (%) to wrap around from 1 to 0 if we go past the end.
                if (comboBox1.SelectedIndex != -1)
                {
                    comboBox1.SelectedIndex = (comboBox1.SelectedIndex + 1) % comboBox1.Items.Count;
                }

                // Reset the value of the NumericUpDown to 1 to start the next cycle.
                numericUpDown2.Value = 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void groupMastery_Enter(object sender, EventArgs e)
        {

        }

        private void groupNotes_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCenterName_Click(object sender, EventArgs e)
        {

        }

        private void txtCenterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurah_Click(object sender, EventArgs e)
        {

        }

        private void cmbSurah_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTeacherName_Click(object sender, EventArgs e)
        {

        }

        private void txtTeacherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWorkTime_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentCount_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
