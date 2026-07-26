using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace النظام_النهائي
{


    public partial class login_D : Form
    {


        public login_D()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "اسم المستخدم")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }



        private void panel2_ChangeUICues(object sender, UICuesEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 25;
                Rectangle rect = new Rectangle(0, 0, panel2.Width - 1, panel2.Height - 1);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel2.Region = new Region(path);


            }


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {


            // منع صوت 

            // منع صوت "البييب" عند الضغط على Enter


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                textBox1.Text = "اسم المستخدم";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "اسم المستخدم")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

            if (textBox1.Text == "اسم المستخدم")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "كلمة المرور")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
                textBox2.PasswordChar = '\0'; // Show characters
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "كلمة المرور")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
                textBox2.PasswordChar = '*'; // Show characters
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "كلمة المرور";
                textBox2.ForeColor = System.Drawing.Color.Gray;
                textBox2.PasswordChar = '*'; // Show characters
            }
        }

        private void textBox2_ChangeUICues(object sender, UICuesEventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Toggle password visibility

            this.textBox2.Click += new System.EventHandler(this.pictureBox4_Click);
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; // Show characters
            }
            else
            {
                textBox2.PasswordChar = '*';
                // Hide characterspasswordTextBox.PasswordChar = '*'
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(32, 178, 170);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(0, 128, 128);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            // منع صوت 

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // منع صوت "البييب" عند الضغط على Enter

                // تحديد عنصر التحكم الذي أطلق الحدث
                Control currentControl = (Control)sender;

                // الانتقال إلى حقل نصي محدد بناءً على الحقل الحالي
                if (currentControl == textBox1)
                {
                    textBox2.Focus(); // الانتقال من textBox1 إلى textBox3
                }
                else if (currentControl == textBox2)
                {
                    button1.Focus();
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    // الانتقال من textBox2 إلى textBox1
                }


            }

        }



        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /*  private void button1_Click(object sender, EventArgs e)
          {
              // لا تنس إضافة هذا السطر في الأعلى



              // الكود الجديد الذي يقرأ من ملف الإعدادات
              string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

              // ... باقي الكود

              using (SqlConnection sqlConnection = new SqlConnection(connectionString))
              {
                  /* sqlConnection.Open(); // فتح الاتصال بقاعدة البيانات
                    SqlCommand cmd = new SqlCommand("sp_login", sqlConnection); // استخدام كائن SqlConnection
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text; // إضافة معامل @username بالقيمة المدخلة في textBox1
                     cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text; // إضافة معامل @password بالقيمة المدخلة في textBox2

                     SqlDataReader rd = cmd.ExecuteReader(); // تنفيذ الأمر وقراءة النتائج باستخدام SqlDataReader

                     if (rd.Read()) // التحقق مما إذا كان هناك سجلات مسترجعة
                     {
                         MessageBox.Show("Login [secceful");
                     }
                     else
                     {
                         MessageBox.Show("Login fulse"); // إظهار رسالة خطأ إذا كانت البيانات غير صحيحة
                     }
                     sqlConnection.Close();


              }
         */

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_D formC = new Form_D();
            this.Hide();
            formC.ShowDialog();
            this.Close();
        }

      
    }

}

