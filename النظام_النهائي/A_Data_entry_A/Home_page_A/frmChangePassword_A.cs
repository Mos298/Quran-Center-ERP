using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// The namespace should match your project's name
namespace النظام_النهائي
{
    /// <summary>
    /// This form allows the user to change their password.
    /// </summary>
    public partial class frmChangePassword_A : Form
    {
        public frmChangePassword_A()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the Save button.
        /// Validates the passwords and saves the changes.
        /// </summary>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // TODO: Add your logic here to verify the current password.

            // Check if the new password and confirmation match
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("كلمة المرور الجديدة وتأكيدها غير متطابقين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new password is not empty
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("لا يمكن أن تكون كلمة المرور الجديدة فارغة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Add your logic here to update the password in the database.

            MessageBox.Show("تم تغيير كلمة المرور بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form after saving
            this.Close();
        }

        /// <summary>
        /// Handles the click event for the Cancel button.
        /// Closes the form without saving changes.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Just close the form
            this.Close();
        }
    }
}
