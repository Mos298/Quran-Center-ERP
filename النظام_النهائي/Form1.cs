using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using النظام_النهائي; // If login_A is in this namespace
// OR
// using YourOtherNamespace; // Replace with the actual namespace where login_A is defined

namespace النظام_النهائي
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login_C login = new login_C();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginA login = new loginA();
            this.Hide();
            login.ShowDialog();
            this.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            login_D login_C = new login_D();
            this.Hide();
            login_C.ShowDialog();
            this.Close();
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(32, 178, 170);
            button1.Size = new Size(225, 125);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            button1.BackColor = Color.FromArgb(0, 128, 128);
            button1.Size = new Size(220, 120);

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(32, 178, 170);
            button2.Size = new Size(225, 125);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(0, 128, 128);
            button2.Size = new Size(220, 120);

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(32, 178, 170);
            button3.Size = new Size(225, 125);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(0, 128, 128);
            button3.Size = new Size(220, 120);

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(32, 178, 170);
            button2.Size = new Size(225, 125);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(32, 178, 170);
            button1.Size = new Size(225, 125);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(32, 178, 170);
            button3.Size = new Size(225, 125);
        }

        private void button1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 25;
                Rectangle rect = new Rectangle(0, 0, button1.Width - 1, button1.Height - 1);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                button1.Region = new Region(path);


            }

        }

        private void button1_AutoSizeChanged(object sender, EventArgs e)
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

        private void panel1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 25;
                Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel1.Region = new Region(path);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login_E login_D = new login_E();
            this.Hide();
            login_D.ShowDialog();
            this.Close();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login_B login_E = new login_B();
            this.Hide();
            login_E.ShowDialog();
            this.Close();
        }
    }
}
