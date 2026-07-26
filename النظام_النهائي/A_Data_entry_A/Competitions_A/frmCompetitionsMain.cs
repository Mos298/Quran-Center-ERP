using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmCompetitionsMain : Form
    {
        // 1. تعريف قوائم لتخزين البيانات
         private List<Competition> competitions = new List<Competition>(); // (تحتاج لتعريف الكلاس Competition)
         private List<Candidate> candidates = new List<Candidate>();       // (تحتاج لتعريف الكلاس Candidate)
         private List<Scores> scores = new List<Scores>();                 // (تحتاج لتعريف الكلاس Scores)

        // ملاحظة: بما أنك لم ترسل تعريف الكلاسات (Competition, etc)، سأفترض وجودها أو يمكنك تعليق القوائم أعلاه مؤقتاً

        // 2. تعريف الواجهات الفرعية
        private ucDashboard dashboardView;
        private ucManageCompetitions manageCompetitionsView;

        // --- تم فصل ucCandidates لعدم التأثير على الكود ---
         private ucTeacherSupervision candidatesView; 

        private ucActiveCompetitions activeCompetitionsView;
        private ucCompetitionLog logView;

        // جملة الاتصال
        private string connectionString = "Your_Connection_String_Goes_Here";

        public frmCompetitionsMain()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        private void frmCompetitionsMain_Load(object sender, EventArgs e)
        {
            // عرض لوحة التحكم كواجهة افتراضية
            navButton_Click(btnDashboard, EventArgs.Empty);
        }

        private void InitializeUserControls()
        {
            dashboardView = new ucDashboard { Dock = DockStyle.Fill };
            manageCompetitionsView = new ucManageCompetitions { Dock = DockStyle.Fill };

            // --- تم التعليق هنا ---
             candidatesView = new ucTeacherSupervision { Dock = DockStyle.Fill };

            activeCompetitionsView = new ucActiveCompetitions { Dock = DockStyle.Fill };
            logView = new ucCompetitionLog { Dock = DockStyle.Fill };
        }

        private void ShowUserControl(UserControl userControl)
        {
            pnlMainContent.Controls.Clear();

            if (userControl != null)
            {
                pnlMainContent.Controls.Add(userControl);
                userControl.Show();
            }
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // تحديث المؤشر المرئي
            pnlActiveTabIndicator.Height = clickedButton.Height;
            pnlActiveTabIndicator.Top = clickedButton.Top;

            // عرض الواجهة المناسبة
            if (clickedButton == btnDashboard)
            {
                lblTitle.Text = "لوحة التحكم";
                // dashboardView.LoadData(...); // تم التعليق لعدم وجود البيانات حالياً
                ShowUserControl(dashboardView);
            }
            else if (clickedButton == btnManageCompetitions)
            {
                lblTitle.Text = "إدارة المسابقات";
                // manageCompetitionsView.LoadData(...);
                ShowUserControl(manageCompetitionsView);
            }
            else if (clickedButton == btnCandidates)
            {
                // --- تم فصل الكود هنا ---
                lblTitle.Text = "الطلاب المرشحون";
              
                 //candidatesView.LoadData(pnlMainContent);
                 ShowUserControl(candidatesView);
            }
            else if (clickedButton == btnActiveCompetitions)
            {
                lblTitle.Text = "نتائج المسابقات";
                // activeCompetitionsView.LoadData(...);
                ShowUserControl(activeCompetitionsView);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "سجل المسابقات";
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                pnlActiveTabIndicator.Height = clickedButton.Height;
                pnlActiveTabIndicator.Top = clickedButton.Top;
            }
            // logView.LoadData(this.competitions);
            ShowUserControl(logView);
        }

        private void RefreshAllViews()
        {
            // dashboardView.LoadData(...);
            // manageCompetitionsView.LoadData(...);

            // --- تم التعليق ---
            // candidatesView.LoadData(candidates);

            // activeCompetitionsView.LoadData(...);
            // logView.LoadData(...);
        }

        // ... بقية الكود الخاص بقاعدة البيانات والأحداث ...

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}