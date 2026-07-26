using System;
using System.Drawing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmStudentAffairsMain : Form
    {
        // تعريف الواجهات الفرعية
      
        private ucViewStudents viewStudentsView;
        ucRegistrationRequests lop;
        // ... سيتم تعريف باقي الواجهات هنا

        // جملة الاتصال - ستتم مشاركتها مع جميع الواجهات الفرعية
        private string connectionString = "Your_Connection_String_Goes_Here"; // <-- الرجاء تعديل هذا السطر

        public frmStudentAffairsMain()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        private void frmStudentAffairsMain_Load(object sender, EventArgs e)
        {
            // عرض الواجهة الافتراضية عند بدء التشغيل
            navButton_Click(viewStudentsView, EventArgs.Empty);
        }

        /// <summary>
        /// يقوم بإنشاء نسخ من الواجهات الفرعية وتزويدها بجملة الاتصال
        /// </summary>
        private void InitializeUserControls()
        {
          
          //  viewStudentsView = new ucViewStudents { Dock = DockStyle.Fill, ConnectionString = this.connectionString };
          //   lop = new ucRegistrationRequests { Dock = DockStyle.Fill, ConnectionString = this.connectionString };
            // ... سيتم إنشاء باقي الواجهات هنا وتزويدها بجملة الاتصال
        }

        /// <summary>
        /// دالة مركزية لعرض الواجهة الفرعية المطلوبة وتشغيلها
        /// </summary>
        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Clear();
          
            pnlMainContent.Controls.Add(userControl);
            userControl.Show();

            // بعد عرض الواجهة، نطلب منها أن تقوم بتحميل بياناتها بنفسها
               }
            // ... سيتم استدعاء دوال التحميل لباقي الواجهات هنا
      

        private void navButton_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ucViewStudents());
            lblTitle.Text = "عرض الطلاب";
        }  
            // ... باقي الأزرار
       

        /// <summary>
        /// دالة لتحديث مظهر الشريط الجانبي (الألوان والمؤشر)
        /// </summary>
      /*  private void UpdateSidebarUI(Button selectedButton)
        {
            Color sidebarBackColor = Color.FromArgb(45, 52, 54);
            Color activeTabColor = Color.FromArgb(63, 70, 72);

            /*   foreach (Control control in pnlSidebar.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = sidebarBackColor;
                }
            }*/
           // selectedButton.BackColor = activeTabColor;
         //   pnlActiveTabIndicator.Height = selectedButton.Height;
         //   pnlActiveTabIndicator.Top = selectedButton.Top;
        
      
        private void btnRegistrationRequests_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ucRegistrationRequests());
        }

        private void btnInactiveStudents_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ucInactiveStudents());
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

