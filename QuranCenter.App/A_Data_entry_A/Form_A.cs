using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A;
using النظام_النهائي.Properties;

namespace النظام_النهائي
{
    public partial class Form_A : Form
    {
        public Form_A()
        {
            InitializeComponent();
            bellPanel.Paint += BellPanel_Paint;
            // ربط زر الإشعار
            notifyButton.Click += NotifyButton_Click;
        

            // عند تشغيل النموذج، قم بتحميل واجهة "المركز" مباشرة
            // استدعاء الدالة الخاصة بالزر 7 يضمن أن يتم ربط الحدث بشكل صحيح
            button7_Click(this, EventArgs.Empty);
        }

        // هذه الدالة تستقبل الصورة الجديدة من "center" وتقوم بتحديثها
        private void Center1_PictureChanged(object sender, Image newImage)
        {
            // قم بتحديث الصورة في النموذج الرئيسي
            userAvatar.Image = newImage;
        }

        // هذه هي الدالة الصحيحة والوحيدة لتحميل أي UserControl
        private void LoadUserControl(UserControl userControl)
        {
            // اجعل الواجهة تملأ اللوحة بالكامل
            userControl.Dock = DockStyle.Fill;
            // نظّف اللوحة من أي محتوى قديم
            mainContentPanel.Controls.Clear();
            // أضف الواجهة الجديدة لعرضها
            mainContentPanel.Controls.Add(userControl);
        }

        // --- باقي دوال الأزرار والأحداث ---

        private void button1_Click(object sender, EventArgs e)
        {
             LoadUserControl(new cetterAcs());
         //   this.label4.Text = "الصفحة الرئيسية / الاعدادات / المراكز";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Supervisors());
         //   this.label4.Text = "الصفحة الرئيسية / الاعدادات / إدارةالمشرفين";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             LoadUserControl(new Mentors());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new memorizers());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // قم بإنشاء نسخة من واجهة المخطط البياني وتحميلها
            LoadUserControl(new Statistics());
        }
        //btnDashboard
        private void button6_Click(object sender, EventArgs e)
        {
            // LoadUserControl(new The_report());
            frmStudentAffairsMain frmStudentAffairsMain = new frmStudentAffairsMain();
            this.Hide();
            frmStudentAffairsMain.ShowDialog();
           this.Show();

        }

        // هذا هو الزر المسؤول عن عرض صفحة "المركز"
        private void button7_Click(object sender, EventArgs e)
        {
            // 1. أنشئ نسخة جديدة من واجهة "center"
            // إنشاء الواجهة
            center centerControl = new center();

            // ربط الأحداث
            centerControl.PictureChanged += Center1_PictureChanged;

            // عرض الواجهة
            LoadUserControl(centerControl);

            // استدعاء البيانات (الآن ستجلب بيانات المستخدم المسجل فقط أياً كان رقمه)
           // centerControl.LoadUserData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// قاعدة البيانات للصور 
        /// </summary>
        /*  private void LoadUserImageFromDatabase()
          {
              using (SqlConnection con = new SqlConnection(connectionString))
              {
                  // استبدل 'Users' باسم جدول المستخدمين و 'ProfilePicture' باسم حقل الصورة
                  // و 'UserID' باسم حقل هوية المستخدم
                  string query = "SELECT ProfilePicture FROM Users WHERE UserID = @UserID";
                  using (SqlCommand cmd = new SqlCommand(query, con))
                  {
                      cmd.Parameters.AddWithValue("@UserID", currentUserId);
                      try
                      {
                          con.Open();
                          object result = cmd.ExecuteScalar(); // استخدم ExecuteScalar لأنه يرجع قيمة واحدة فقط

                          if (result != null && result != DBNull.Value)
                          {
                              byte[] imageBytes = (byte[])result;
                              using (MemoryStream ms = new MemoryStream(imageBytes))
                              {
                                  userAvatar.Image = Image.FromStream(ms);
                              }
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("حدث خطأ أثناء تحميل الصورة: " + ex.Message);
                      }
                  }
              }
          }

          private void SaveUserImageToDatabase(Image image)
          {
              // 1. تحويل الصورة إلى مصفوفة بايتات
              byte[] imageBytes;
              using (MemoryStream ms = new MemoryStream())
              {
                  image.Save(ms, image.RawFormat); // نحافظ على تنسيق الصورة الأصلي
                  imageBytes = ms.ToArray();
              }

              // 2. حفظ مصفوفة البايتات في قاعدة البيانات
              using (SqlConnection con = new SqlConnection(connectionString))
              {
                  // استبدل أسماء الجداول والحقول بما يناسب قاعدة بياناتك
                  string query = "UPDATE Users SET ProfilePicture = @ProfilePicture WHERE UserID = @UserID";
                  using (SqlCommand cmd = new SqlCommand(query, con))
                  {
                      cmd.Parameters.AddWithValue("@UserID", currentUserId);
                      cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                      try
                      {
                          con.Open();
                          cmd.ExecuteNonQuery(); // ExecuteNonQuery لأننا نقوم بعملية تحديث
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("حدث خطأ أثناء حفظ الصورة: " + ex.Message);
                      }
                  }
              
   */ 
       


        // باقي الأحداث الفارغة (يمكنك حذفها إذا لم تكن بحاجتها)
        private void userAvatar_Click(object sender, EventArgs e) { }
        private void navPanel_Paint(object sender, PaintEventArgs e) { }
        private void userNameLabel_Click(object sender, EventArgs e) { }
        private void titleLabel_Click(object sender, EventArgs e) { }

        private void button9_Click(object sender, EventArgs e)
        {
           
            
            frmCompetitionsMain frmCompetitionsMain = new frmCompetitionsMain();
            this.Hide();
            frmCompetitionsMain.ShowDialog();
            this.Show();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
     
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        // المتغير الرئيسي لتتبع حالة الإشعار
        private bool _hasNotification = false;

        

        // ----------------------------------------------------------------------

        // هذا الحدث يتم تنفيذه في كل مرة يحتاج فيها الـ Panel لإعادة الرسم
        private void BellPanel_Paint(object sender, PaintEventArgs e)
        {
            // 1. تحديد اللون بناءً على حالة الإشعار
            Color bellColor;
            if (_hasNotification)
            {
                bellColor = Color.Red; // أحمر عند وجود إشعار
            }
            else
            {
                bellColor = Color.Yellow; // أصفر في الحالة العادية
            }

            // 2. استخدام GDI+ للرسم
            Graphics g = e.Graphics;

            // قم بتخيل أبعاد الرسم داخل اللوحة
            int w = bellPanel.Width;
            int h = bellPanel.Height;

            // فرشاة الرسم
            using (SolidBrush brush = new SolidBrush(bellColor))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // أ. رسم جسم الجرس (مثال على شكل شبه منحرف أو مربع منحني)
                // النقاط التي تشكل جسم الجرس
                Point[] bellBody = new Point[]
                {
                new Point(w * 1 / 4, h * 1 / 4),
                new Point(w * 3 / 4, h * 1 / 4),
                new Point(w * 4 / 5, h * 4 / 5),
                new Point(w * 1 / 5, h * 4 / 5)
                };

                g.FillPolygon(brush, bellBody);
                g.DrawPolygon(pen, bellBody); // لرسم الحدود

                // ب. رسم مقبض الجرس (الجزء العلوي)
                g.FillRectangle(brush, w * 3 / 8, h * 1 / 16, w * 1 / 4, h * 1 / 8);
                g.DrawRectangle(pen, w * 3 / 8, h * 1 / 16, w * 1 / 4, h * 1 / 8);

                // ج. رسم لسان الجرس (الجرس الصغير في الأسفل)
                g.FillEllipse(Brushes.Black, w * 1 / 2 - 5, h * 7 / 8 - 5, 10, 10);

                // 3. إضافة علامة الإشعار (الدائرة الحمراء الصغيرة)
                if (_hasNotification)
                {
                    // نرسم دائرة حمراء صغيرة في الزاوية العلوية اليمنى
                    int dotSize = 10;
                    Rectangle dotRect = new Rectangle(w - dotSize, 0, dotSize, dotSize);
                    g.FillEllipse(Brushes.Red, dotRect);
                }
            }
        }

        // ----------------------------------------------------------------------

        // هذا الحدث لمحاكاة وصول إشعار
        private void NotifyButton_Click(object sender, EventArgs e)
        {
            // عكس حالة الإشعار (إذا كانت false تصبح true والعكس)
            _hasNotification = !_hasNotification;

            // إعادة رسم الـ Panel لعكس التغيير في اللون
            bellPanel.Invalidate();

            // تحديث نص الزر
            notifyButton.Text = _hasNotification ? "إلغاء الإشعار" : "إضافة إشعار";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 1. إنشاء نسخة من واجهة الإشعارات
            // (من الأفضل تعريفها في الأعلى مع باقي الواجهات لتجنب إنشائها كل مرة)
            ucNotifications notificationsControl = new ucNotifications();

            // 2. تمرير جملة الاتصال لها
            // تأكد من استبدال هذا بجملة الاتصال الحقيقية من نظامك
            notificationsControl.ConnectionString = "Your_Connection_String_Goes_Here";

            // 3. استدعاء دالة العرض العامة التي أنشأتها
            LoadUserControl(notificationsControl);

            // 4. (مهم) استدعاء دالة تحميل البيانات الخاصة بالواجهة
            notificationsControl.LoadData();
        }
    }
}

