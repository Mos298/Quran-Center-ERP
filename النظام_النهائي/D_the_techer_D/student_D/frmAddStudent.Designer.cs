namespace النظام_النهائي
{
    partial class frmAddStudent
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGuardianPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(915, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblTitle.Size = new System.Drawing.Size(915, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة بيانات طالب جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الطالب:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtFullName.Location = new System.Drawing.Point(485, 107);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(291, 32);
            this.txtFullName.TabIndex = 0;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGuardianName.Location = new System.Drawing.Point(485, 156);
            this.txtGuardianName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(291, 32);
            this.txtGuardianName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم ولي الأمر:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(784, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "تاريخ الميلاد:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpBirthDate.Location = new System.Drawing.Point(485, 206);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(291, 32);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTeacherName.Location = new System.Drawing.Point(485, 255);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(291, 32);
            this.txtTeacherName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(784, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المعلم:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(784, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "الجنسية:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNationality
            // 
            this.cboNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNationality.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cboNationality.FormattingEnabled = true;
            this.cboNationality.Items.AddRange(new object[] {
            "ليبي/ة",
            "أخرى"});
            this.cboNationality.Location = new System.Drawing.Point(485, 304);
            this.cboNationality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(291, 33);
            this.cboNationality.TabIndex = 4;
            this.cboNationality.SelectedIndexChanged += new System.EventHandler(this.cboNationality_SelectedIndexChanged);
            // 
            // txtResidence
            // 
            this.txtResidence.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtResidence.Location = new System.Drawing.Point(14, 107);
            this.txtResidence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(291, 32);
            this.txtResidence.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "مكان الإقامة:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "الجنس:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cboGender.Location = new System.Drawing.Point(14, 156);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(291, 33);
            this.cboGender.TabIndex = 6;
            // 
            // lblNationalId
            // 
            this.lblNationalId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalId.Location = new System.Drawing.Point(313, 209);
            this.lblNationalId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(117, 28);
            this.lblNationalId.TabIndex = 15;
            this.lblNationalId.Text = "الرقم الوطني:";
            this.lblNationalId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNationalId
            // 
            this.txtNationalId.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNationalId.Location = new System.Drawing.Point(14, 206);
            this.txtNationalId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(291, 32);
            this.txtNationalId.TabIndex = 7;
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtStudentPhone.Location = new System.Drawing.Point(14, 255);
            this.txtStudentPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(291, 32);
            this.txtStudentPhone.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "رقم الهاتف:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGuardianPhone
            // 
            this.txtGuardianPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGuardianPhone.Location = new System.Drawing.Point(14, 304);
            this.txtGuardianPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuardianPhone.Name = "txtGuardianPhone";
            this.txtGuardianPhone.Size = new System.Drawing.Size(291, 32);
            this.txtGuardianPhone.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 308);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "رقم هاتف ولي الأمر:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(726, 406);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 28);
            this.label12.TabIndex = 21;
            this.label12.Text = "رقم القيد التلقائي:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegistrationNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblRegistrationNumber.Location = new System.Drawing.Point(14, 394);
            this.lblRegistrationNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(704, 49);
            this.lblRegistrationNumber.TabIndex = 22;
            this.lblRegistrationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(196, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 55);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(14, 492);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 55);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmAddStudent
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(915, 567);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRegistrationNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGuardianPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStudentPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNationalId);
            this.Controls.Add(this.lblNationalId);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResidence);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNationality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة طالب جديد";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNationality;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblNationalId;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGuardianPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
