// The namespace should match your project's name
namespace النظام_النهائي
{
    partial class center
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.btnEditPicture = new System.Windows.Forms.Button();
            this.grpCenterInfo = new System.Windows.Forms.GroupBox();
            this.lblCenterEmailValue = new System.Windows.Forms.Label();
            this.lblCenterPhoneValue = new System.Windows.Forms.Label();
            this.lblCenterEmail = new System.Windows.Forms.Label();
            this.lblCenterPhone = new System.Windows.Forms.Label();
            this.grpSupervisorInfo = new System.Windows.Forms.GroupBox();
            this.lblSupervisorGenderValue = new System.Windows.Forms.Label();
            this.lblSupervisorDobValue = new System.Windows.Forms.Label();
            this.lblSupervisorDeptValue = new System.Windows.Forms.Label();
            this.lblSupervisorIdValue = new System.Windows.Forms.Label();
            this.lblSupervisorPositionValue = new System.Windows.Forms.Label();
            this.lblSupervisorNameValue = new System.Windows.Forms.Label();
            this.lblSupervisorGender = new System.Windows.Forms.Label();
            this.lblSupervisorDob = new System.Windows.Forms.Label();
            this.lblSupervisorDept = new System.Windows.Forms.Label();
            this.lblSupervisorId = new System.Windows.Forms.Label();
            this.lblSupervisorPosition = new System.Windows.Forms.Label();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.grpCenterInfo.SuspendLayout();
            this.grpSupervisorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.btnHomePage);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(788, 60);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHomePage.ForeColor = System.Drawing.Color.White;
            this.btnHomePage.Location = new System.Drawing.Point(18, 10);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(105, 40);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "طلب تعديل";
            this.btnHomePage.UseVisualStyleBackColor = false;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.btnEditPicture);
            this.pnlMainContent.Controls.Add(this.grpCenterInfo);
            this.pnlMainContent.Controls.Add(this.grpSupervisorInfo);
            this.pnlMainContent.Controls.Add(this.btnChangePassword);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlMainContent.Location = new System.Drawing.Point(0, 60);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMainContent.Size = new System.Drawing.Size(788, 540);
            this.pnlMainContent.TabIndex = 1;
            // 
            // btnEditPicture
            // 
            this.btnEditPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditPicture.ForeColor = System.Drawing.Color.White;
            this.btnEditPicture.Location = new System.Drawing.Point(477, 480);
            this.btnEditPicture.Name = "btnEditPicture";
            this.btnEditPicture.Size = new System.Drawing.Size(131, 40);
            this.btnEditPicture.TabIndex = 3;
            this.btnEditPicture.Text = "تعديل الصورة";
            this.btnEditPicture.UseVisualStyleBackColor = false;
            this.btnEditPicture.Click += new System.EventHandler(this.btnEditPicture_Click);
            // 
            // grpCenterInfo
            // 
            this.grpCenterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCenterInfo.Controls.Add(this.lblCenterEmailValue);
            this.grpCenterInfo.Controls.Add(this.lblCenterPhoneValue);
            this.grpCenterInfo.Controls.Add(this.lblCenterEmail);
            this.grpCenterInfo.Controls.Add(this.lblCenterPhone);
            this.grpCenterInfo.Location = new System.Drawing.Point(420, 280);
            this.grpCenterInfo.Name = "grpCenterInfo";
            this.grpCenterInfo.Size = new System.Drawing.Size(341, 150);
            this.grpCenterInfo.TabIndex = 2;
            this.grpCenterInfo.TabStop = false;
            this.grpCenterInfo.Text = "معلومات الاتصال ";
            // 
            // lblCenterEmailValue
            // 
            this.lblCenterEmailValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterEmailValue.Location = new System.Drawing.Point(18, 90);
            this.lblCenterEmailValue.Name = "lblCenterEmailValue";
            this.lblCenterEmailValue.Size = new System.Drawing.Size(175, 23);
            this.lblCenterEmailValue.TabIndex = 3;
            this.lblCenterEmailValue.Text = "admin@quran-centers.sa";
            this.lblCenterEmailValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCenterPhoneValue
            // 
            this.lblCenterPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterPhoneValue.Location = new System.Drawing.Point(18, 50);
            this.lblCenterPhoneValue.Name = "lblCenterPhoneValue";
            this.lblCenterPhoneValue.Size = new System.Drawing.Size(175, 23);
            this.lblCenterPhoneValue.TabIndex = 2;
            this.lblCenterPhoneValue.Text = "+966 50 123 4567";
            this.lblCenterPhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCenterEmail
            // 
            this.lblCenterEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterEmail.Location = new System.Drawing.Point(219, 90);
            this.lblCenterEmail.Name = "lblCenterEmail";
            this.lblCenterEmail.Size = new System.Drawing.Size(105, 23);
            this.lblCenterEmail.TabIndex = 1;
            this.lblCenterEmail.Text = "البريد الإلكتروني:";
            this.lblCenterEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCenterPhone
            // 
            this.lblCenterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterPhone.Location = new System.Drawing.Point(219, 50);
            this.lblCenterPhone.Name = "lblCenterPhone";
            this.lblCenterPhone.Size = new System.Drawing.Size(105, 23);
            this.lblCenterPhone.TabIndex = 0;
            this.lblCenterPhone.Text = "الهاتف:";
            this.lblCenterPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSupervisorInfo
            // 
            this.grpSupervisorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorGenderValue);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorDobValue);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorDeptValue);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorIdValue);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorPositionValue);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorNameValue);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorGender);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorDob);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorDept);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorId);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorPosition);
            this.grpSupervisorInfo.Controls.Add(this.lblSupervisorName);
            this.grpSupervisorInfo.Location = new System.Drawing.Point(26, 30);
            this.grpSupervisorInfo.Name = "grpSupervisorInfo";
            this.grpSupervisorInfo.Size = new System.Drawing.Size(735, 230);
            this.grpSupervisorInfo.TabIndex = 1;
            this.grpSupervisorInfo.TabStop = false;
            this.grpSupervisorInfo.Text = "معلومات المشرف العام";
            // 
            // lblSupervisorGenderValue
            // 
            this.lblSupervisorGenderValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorGenderValue.Location = new System.Drawing.Point(18, 100);
            this.lblSupervisorGenderValue.Name = "lblSupervisorGenderValue";
            this.lblSupervisorGenderValue.Size = new System.Drawing.Size(175, 23);
            this.lblSupervisorGenderValue.TabIndex = 11;
            this.lblSupervisorGenderValue.Text = "ذكر";
            // 
            // lblSupervisorDobValue
            // 
            this.lblSupervisorDobValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorDobValue.Location = new System.Drawing.Point(18, 50);
            this.lblSupervisorDobValue.Name = "lblSupervisorDobValue";
            this.lblSupervisorDobValue.Size = new System.Drawing.Size(175, 23);
            this.lblSupervisorDobValue.TabIndex = 10;
            this.lblSupervisorDobValue.Text = "1985/03/15";
            // 
            // lblSupervisorDeptValue
            // 
            this.lblSupervisorDeptValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorDeptValue.Location = new System.Drawing.Point(411, 150);
            this.lblSupervisorDeptValue.Name = "lblSupervisorDeptValue";
            this.lblSupervisorDeptValue.Size = new System.Drawing.Size(175, 23);
            this.lblSupervisorDeptValue.TabIndex = 9;
            this.lblSupervisorDeptValue.Text = "المشرف العام";
            // 
            // lblSupervisorIdValue
            // 
            this.lblSupervisorIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorIdValue.Location = new System.Drawing.Point(411, 100);
            this.lblSupervisorIdValue.Name = "lblSupervisorIdValue";
            this.lblSupervisorIdValue.Size = new System.Drawing.Size(175, 23);
            this.lblSupervisorIdValue.TabIndex = 8;
            this.lblSupervisorIdValue.Text = "ADM-2024-381";
            // 
            // lblSupervisorPositionValue
            // 
            this.lblSupervisorPositionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorPositionValue.Location = new System.Drawing.Point(18, 150);
            this.lblSupervisorPositionValue.Name = "lblSupervisorPositionValue";
            this.lblSupervisorPositionValue.Size = new System.Drawing.Size(175, 23);
            this.lblSupervisorPositionValue.TabIndex = 7;
            this.lblSupervisorPositionValue.Text = "المشرف العام";
            // 
            // lblSupervisorNameValue
            // 
            this.lblSupervisorNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorNameValue.Location = new System.Drawing.Point(411, 50);
            this.lblSupervisorNameValue.Name = "lblSupervisorNameValue";
            this.lblSupervisorNameValue.Size = new System.Drawing.Size(175, 23);
            this.lblSupervisorNameValue.TabIndex = 6;
            this.lblSupervisorNameValue.Text = "عبد الرؤوف احمد";
            // 
            // lblSupervisorGender
            // 
            this.lblSupervisorGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorGender.Location = new System.Drawing.Point(219, 100);
            this.lblSupervisorGender.Name = "lblSupervisorGender";
            this.lblSupervisorGender.Size = new System.Drawing.Size(105, 23);
            this.lblSupervisorGender.TabIndex = 5;
            this.lblSupervisorGender.Text = "الجنس:";
            this.lblSupervisorGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorDob
            // 
            this.lblSupervisorDob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorDob.Location = new System.Drawing.Point(219, 50);
            this.lblSupervisorDob.Name = "lblSupervisorDob";
            this.lblSupervisorDob.Size = new System.Drawing.Size(105, 23);
            this.lblSupervisorDob.TabIndex = 4;
            this.lblSupervisorDob.Text = "تاريخ الميلاد:";
            this.lblSupervisorDob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorDept
            // 
            this.lblSupervisorDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorDept.Location = new System.Drawing.Point(612, 150);
            this.lblSupervisorDept.Name = "lblSupervisorDept";
            this.lblSupervisorDept.Size = new System.Drawing.Size(105, 23);
            this.lblSupervisorDept.TabIndex = 3;
            this.lblSupervisorDept.Text = "القسم:";
            this.lblSupervisorDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorId
            // 
            this.lblSupervisorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorId.Location = new System.Drawing.Point(612, 100);
            this.lblSupervisorId.Name = "lblSupervisorId";
            this.lblSupervisorId.Size = new System.Drawing.Size(105, 23);
            this.lblSupervisorId.TabIndex = 2;
            this.lblSupervisorId.Text = "رقم القيد:";
            this.lblSupervisorId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorPosition
            // 
            this.lblSupervisorPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorPosition.Location = new System.Drawing.Point(219, 150);
            this.lblSupervisorPosition.Name = "lblSupervisorPosition";
            this.lblSupervisorPosition.Size = new System.Drawing.Size(105, 23);
            this.lblSupervisorPosition.TabIndex = 1;
            this.lblSupervisorPosition.Text = "المنصب:";
            this.lblSupervisorPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorName.Location = new System.Drawing.Point(612, 50);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(105, 23);
            this.lblSupervisorName.TabIndex = 0;
            this.lblSupervisorName.Text = "الاسم:";
            this.lblSupervisorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(630, 480);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(131, 40);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "تغيير كلمة المرور";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "center";
            this.Size = new System.Drawing.Size(788, 600);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.grpCenterInfo.ResumeLayout(false);
            this.grpSupervisorInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.GroupBox grpSupervisorInfo;
        private System.Windows.Forms.Label lblSupervisorName;
        private System.Windows.Forms.Label lblSupervisorPosition;
        private System.Windows.Forms.Label lblSupervisorId;
        private System.Windows.Forms.Label lblSupervisorDept;
        private System.Windows.Forms.Label lblSupervisorDob;
        private System.Windows.Forms.Label lblSupervisorGender;
        private System.Windows.Forms.Label lblSupervisorNameValue;
        private System.Windows.Forms.Label lblSupervisorPositionValue;
        private System.Windows.Forms.Label lblSupervisorIdValue;
        private System.Windows.Forms.Label lblSupervisorDeptValue;
        private System.Windows.Forms.Label lblSupervisorDobValue;
        private System.Windows.Forms.Label lblSupervisorGenderValue;
        private System.Windows.Forms.GroupBox grpCenterInfo;
        private System.Windows.Forms.Label lblCenterPhone;
        private System.Windows.Forms.Label lblCenterEmail;
        private System.Windows.Forms.Label lblCenterPhoneValue;
        private System.Windows.Forms.Label lblCenterEmailValue;
        private System.Windows.Forms.Button btnEditPicture;
    }
}

