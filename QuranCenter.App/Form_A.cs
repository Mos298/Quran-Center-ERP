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
using النظام_النهائي.Properties;

namespace النظام_النهائي
{
    public partial class Form_A : Form
    {
        public Form_A()
        {
            InitializeComponent();

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
             LoadUserControl(new CentersUC());
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

        private void button6_Click(object sender, EventArgs e)
        {
            // LoadUserControl(new The_report());
        }

        // هذا هو الزر المسؤول عن عرض صفحة "المركز"
        private void button7_Click(object sender, EventArgs e)
        {
            // 1. أنشئ نسخة جديدة من واجهة "center"
            center centerControl = new center();

            // 2. اشترك في حدث تغيير الصورة الخاص بهذه النسخة
            centerControl.PictureChanged += Center1_PictureChanged;

            // 3. قم بتحميل الواجهة باستخدام الدالة الموحدة
            LoadUserControl(centerControl);
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
            LoadUserControl(new ucCompetitions());
        }
    }
}

