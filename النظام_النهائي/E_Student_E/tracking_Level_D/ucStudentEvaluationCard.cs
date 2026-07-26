using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي.D_the_techer_D.Level_lerning_D;

namespace النظام_النهائي.E_Student_E.tracking_Level_D
{
  
    public partial class ucStudentEvaluationCard : UserControl
    {
        public ucStudentEvaluationCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// دالة عامة لاستقبال بيانات التقييم وعرضها في الواجهة
        /// </summary>
        /// <param name="studentName">اسم الطالب</param>
        /// <param name="regNumber">رقم قيد الطالب</param>
        /// <param name="evaluation">كائن التقييم</param>
        public void DisplayEvaluation(string studentName, string regNumber, StudentEvaluation evaluation)
        {
            if (evaluation == null) return;

            // تعبئة بيانات الطالب
            lblStudentName.Text = studentName;
            lblRegNumber.Text = regNumber;

            // تعبئة بيانات التقييم
            lblCommitment.Text = evaluation.Commitment;
            lblMemorizedAjza.Text = evaluation.MemorizedAjza.ToString();

            // تحديث مستوى الحفظ
            lblMemorizationLevel.Text = evaluation.MemorizationLevel.ToString() + "%";
            progressMemorization.Value = evaluation.MemorizationLevel;

            // تحديث مستوى الأحكام
            lblTajweedLevel.Text = evaluation.TajweedLevel.ToString() + "%";
            progressTajweed.Value = evaluation.TajweedLevel;

            // تحديث المستوى العام مع تغيير اللون
            lblOverallLevel.Text = evaluation.OverallLevel;
            SetOverallLevelColor(evaluation.OverallLevel);
        }

        /// <summary>
        /// دالة مساعدة لتغيير لون نص المستوى العام بناءً على التقييم
        /// </summary>
        private void SetOverallLevelColor(string level)
        {
            switch (level)
            {
                case "ممتاز":
                    lblOverallLevel.ForeColor = Color.FromArgb(46, 204, 113); // أخضر
                    break;
                case "جيد جداً":
                    lblOverallLevel.ForeColor = Color.FromArgb(52, 152, 219); // أزرق
                    break;
                case "جيد":
                    lblOverallLevel.ForeColor = Color.FromArgb(241, 196, 15); // أصفر
                    break;
                case "مقبول":
                    lblOverallLevel.ForeColor = Color.FromArgb(230, 126, 34); // برتقالي
                    break;
                case "ضعيف":
                    lblOverallLevel.ForeColor = Color.FromArgb(231, 76, 60); // أحمر
                    break;
                default:
                    lblOverallLevel.ForeColor = Color.Black;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
