using System;
using System.Drawing;
using System.Windows.Forms;

// The namespace should match your project's name
namespace النظام_النهائي
{
    public partial class center : UserControl
    {
        // 1. تعريف الحدث (Event)
        // هذا الحدث سيحمل الصورة الجديدة التي يختارها المستخدم
        public event EventHandler<Image> PictureChanged;

        public center()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // This will open the change password form as a dialog
            using (frmChangePassword_A changePasswordForm = new frmChangePassword_A())
            {
                changePasswordForm.ShowDialog();
            }
        }

        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            // Using statement ensures the dialog is properly disposed of
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filter for common image file types
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
                openFileDialog.Title = "اختر صورة شخصية";

                // Show the dialog and check if the user clicked "OK"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Create a new Bitmap object from the selected file
                        var selectedImage = new Bitmap(openFileDialog.FileName);

                        // 2. إطلاق الحدث (Raise the Event)
                        // Send the selected image to any listener (which is Form_A)
                        // The?. Invoke pattern is a safe way to raise an event,
                        // it checks if there are any subscribers before raising.
                        PictureChanged?.Invoke(this, selectedImage);
                    }
                    catch (Exception ex)
                    {
                        // Inform the user if the selected file is not a valid image
                        MessageBox.Show("خطأ في تحميل الصورة: " + ex.Message);
                    }
                }
            }
        }

        private void btnEditPicture_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 2. إذا اختار المستخدم صورة، نقوم بتحميلها
                    Image selectedImage = Image.FromFile(ofd.FileName);

                    // 3. (أهم خطوة) نطلق حدث "PictureChanged" ونرسل معه الصورة الجديدة
                    // النموذج الرئيسي Form_A يستمع لهذا الحدث
                    PictureChanged?.Invoke(this, selectedImage);
                }
            }
        }

        // You can add event handlers for other buttons here if needed
        // For example:
        // private void btnHomePage_Click(object sender, EventArgs e)
        // {
        //     // Code to handle "طلب تعديل" button click
        // }
    }
}

