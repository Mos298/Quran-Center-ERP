namespace النظام_النهائي
{
    partial class frmEditStudent_s
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchRegNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStudentData = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGuardianPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.grpStudentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchRegNumber);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(12);
            this.pnlSearch.Size = new System.Drawing.Size(915, 98);
            this.pnlSearch.TabIndex = 1;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(223, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchRegNumber
            // 
            this.txtSearchRegNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchRegNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchRegNumber.Location = new System.Drawing.Point(335, 30);
            this.txtSearchRegNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchRegNumber.Name = "txtSearchRegNumber";
            this.txtSearchRegNumber.Size = new System.Drawing.Size(244, 34);
            this.txtSearchRegNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل رقم القيد للطالب:";
            // 
            // grpStudentData
            // 
            this.grpStudentData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStudentData.Controls.Add(this.txtNotes);
            this.grpStudentData.Controls.Add(this.label12);
            this.grpStudentData.Controls.Add(this.txtGuardianPhone);
            this.grpStudentData.Controls.Add(this.label11);
            this.grpStudentData.Controls.Add(this.txtStudentPhone);
            this.grpStudentData.Controls.Add(this.label10);
            this.grpStudentData.Controls.Add(this.txtNationalId);
            this.grpStudentData.Controls.Add(this.lblNationalId);
            this.grpStudentData.Controls.Add(this.cboGender);
            this.grpStudentData.Controls.Add(this.label8);
            this.grpStudentData.Controls.Add(this.txtResidence);
            this.grpStudentData.Controls.Add(this.label7);
            this.grpStudentData.Controls.Add(this.cboNationality);
            this.grpStudentData.Controls.Add(this.label6);
            this.grpStudentData.Controls.Add(this.txtTeacherName);
            this.grpStudentData.Controls.Add(this.label5);
            this.grpStudentData.Controls.Add(this.dtpBirthDate);
            this.grpStudentData.Controls.Add(this.label4);
            this.grpStudentData.Controls.Add(this.txtGuardianName);
            this.grpStudentData.Controls.Add(this.label3);
            this.grpStudentData.Controls.Add(this.txtFullName);
            this.grpStudentData.Controls.Add(this.label2);
            this.grpStudentData.Enabled = false;
            this.grpStudentData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpStudentData.Location = new System.Drawing.Point(15, 117);
            this.grpStudentData.Margin = new System.Windows.Forms.Padding(4);
            this.grpStudentData.Name = "grpStudentData";
            this.grpStudentData.Padding = new System.Windows.Forms.Padding(4);
            this.grpStudentData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpStudentData.Size = new System.Drawing.Size(886, 497);
            this.grpStudentData.TabIndex = 2;
            this.grpStudentData.TabStop = false;
            this.grpStudentData.Text = "بيانات الطالب";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNotes.Location = new System.Drawing.Point(23, 357);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(731, 116);
            this.txtNotes.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.Location = new System.Drawing.Point(799, 361);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "ملاحظات:";
            // 
            // txtGuardianPhone
            // 
            this.txtGuardianPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGuardianPhone.Location = new System.Drawing.Point(23, 299);
            this.txtGuardianPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuardianPhone.Name = "txtGuardianPhone";
            this.txtGuardianPhone.Size = new System.Drawing.Size(291, 29);
            this.txtGuardianPhone.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.Location = new System.Drawing.Point(334, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "هاتف ولي الأمر:";
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStudentPhone.Location = new System.Drawing.Point(463, 299);
            this.txtStudentPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(291, 29);
            this.txtStudentPhone.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(785, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "هاتف الطالب:";
            // 
            // txtNationalId
            // 
            this.txtNationalId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNationalId.Location = new System.Drawing.Point(23, 241);
            this.txtNationalId.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(291, 29);
            this.txtNationalId.TabIndex = 17;
            // 
            // lblNationalId
            // 
            this.lblNationalId.AutoSize = true;
            this.lblNationalId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNationalId.Location = new System.Drawing.Point(351, 245);
            this.lblNationalId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(107, 23);
            this.lblNationalId.TabIndex = 16;
            this.lblNationalId.Text = "الرقم الوطني:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cboGender.Location = new System.Drawing.Point(463, 241);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(291, 29);
            this.cboGender.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(819, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "الجنس:";
            // 
            // txtResidence
            // 
            this.txtResidence.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtResidence.Location = new System.Drawing.Point(23, 183);
            this.txtResidence.Margin = new System.Windows.Forms.Padding(4);
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(291, 29);
            this.txtResidence.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(359, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "مكان الإقامة:";
            // 
            // cboNationality
            // 
            this.cboNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNationality.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboNationality.FormattingEnabled = true;
            this.cboNationality.Items.AddRange(new object[] {
            "ليبي/ة",
            "أخرى"});
            this.cboNationality.Location = new System.Drawing.Point(463, 183);
            this.cboNationality.Margin = new System.Windows.Forms.Padding(4);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(291, 29);
            this.cboNationality.TabIndex = 11;
            this.cboNationality.SelectedIndexChanged += new System.EventHandler(this.cboNationality_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(808, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "الجنسية:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTeacherName.Location = new System.Drawing.Point(23, 126);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(291, 29);
            this.txtTeacherName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(359, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "اسم المعلم:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(463, 126);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(291, 29);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(785, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاريخ الميلاد:";
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGuardianName.Location = new System.Drawing.Point(23, 68);
            this.txtGuardianName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(291, 29);
            this.txtGuardianName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(342, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم ولي الأمر:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFullName.Location = new System.Drawing.Point(463, 68);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(291, 29);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(789, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الطالب:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(477, 633);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(424, 62);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ التعديلات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(15, 633);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(455, 62);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "إعادة تعيين كلمة المرور";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // frmEditStudent_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 709);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpStudentData);
            this.Controls.Add(this.pnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditStudent_s";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل بيانات طالب";
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpStudentData.ResumeLayout(false);
            this.grpStudentData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchRegNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpStudentData;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNationality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.Label lblNationalId;
        private System.Windows.Forms.TextBox txtGuardianPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResetPassword;
    }
}
