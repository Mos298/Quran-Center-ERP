namespace النظام_النهائي
{
    partial class frmAddTeacherVisit
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
            this.grpTeacherInfo = new System.Windows.Forms.GroupBox();
            this.comboTecher = new System.Windows.Forms.ComboBox();
            this.cmbQuranIjazah = new System.Windows.Forms.ComboBox();
            this.cmbAssignmentType = new System.Windows.Forms.ComboBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAssignmentType = new System.Windows.Forms.Label();
            this.lblQuranIjazah = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCenterInfo = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numTeachingHours = new System.Windows.Forms.NumericUpDown();
            this.lblTeachingHours = new System.Windows.Forms.Label();
            this.cmbCommitment = new System.Windows.Forms.ComboBox();
            this.lblCommitment = new System.Windows.Forms.Label();
            this.grpVisit1 = new System.Windows.Forms.GroupBox();
            this.cmbAttendance1 = new System.Windows.Forms.ComboBox();
            this.lblAttendance1 = new System.Windows.Forms.Label();
            this.numStudents1 = new System.Windows.Forms.NumericUpDown();
            this.lblStudents1 = new System.Windows.Forms.Label();
            this.dtpVisitDate1 = new System.Windows.Forms.DateTimePicker();
            this.lblVisitDate1 = new System.Windows.Forms.Label();
            this.grpVisit2 = new System.Windows.Forms.GroupBox();
            this.cmbAttendance2 = new System.Windows.Forms.ComboBox();
            this.lblAttendance2 = new System.Windows.Forms.Label();
            this.numStudents2 = new System.Windows.Forms.NumericUpDown();
            this.lblStudents2 = new System.Windows.Forms.Label();
            this.dtpVisitDate2 = new System.Windows.Forms.DateTimePicker();
            this.lblVisitDate2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxCenter = new System.Windows.Forms.ComboBox();
            this.phoonTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.grpTeacherInfo.SuspendLayout();
            this.grpCenterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeachingHours)).BeginInit();
            this.grpVisit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudents1)).BeginInit();
            this.grpVisit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudents2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTeacherInfo
            // 
            this.grpTeacherInfo.Controls.Add(this.phoonTextBox1);
            this.grpTeacherInfo.Controls.Add(this.comboTecher);
            this.grpTeacherInfo.Controls.Add(this.cmbQuranIjazah);
            this.grpTeacherInfo.Controls.Add(this.cmbAssignmentType);
            this.grpTeacherInfo.Controls.Add(this.lblPhoneNumber);
            this.grpTeacherInfo.Controls.Add(this.lblAssignmentType);
            this.grpTeacherInfo.Controls.Add(this.lblQuranIjazah);
            this.grpTeacherInfo.Controls.Add(this.lblName);
            this.grpTeacherInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTeacherInfo.Location = new System.Drawing.Point(37, 111);
            this.grpTeacherInfo.Name = "grpTeacherInfo";
            this.grpTeacherInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpTeacherInfo.Size = new System.Drawing.Size(749, 158);
            this.grpTeacherInfo.TabIndex = 0;
            this.grpTeacherInfo.TabStop = false;
            this.grpTeacherInfo.Text = "معلومات المحفظ الأساسية";
            // 
            // comboTecher
            // 
            this.comboTecher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTecher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboTecher.FormattingEnabled = true;
            this.comboTecher.Location = new System.Drawing.Point(400, 51);
            this.comboTecher.Name = "comboTecher";
            this.comboTecher.Size = new System.Drawing.Size(220, 28);
            this.comboTecher.TabIndex = 8;
            // 
            // cmbQuranIjazah
            // 
            this.cmbQuranIjazah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuranIjazah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbQuranIjazah.FormattingEnabled = true;
            this.cmbQuranIjazah.Items.AddRange(new object[] {
            "ربع",
            "نصف",
            "كامل",
            "غير محدد"});
            this.cmbQuranIjazah.Location = new System.Drawing.Point(29, 51);
            this.cmbQuranIjazah.Name = "cmbQuranIjazah";
            this.cmbQuranIjazah.Size = new System.Drawing.Size(220, 28);
            this.cmbQuranIjazah.TabIndex = 7;
            // 
            // cmbAssignmentType
            // 
            this.cmbAssignmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignmentType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAssignmentType.FormattingEnabled = true;
            this.cmbAssignmentType.Items.AddRange(new object[] {
            "متعاون",
            "متطوع",
            "تكليف"});
            this.cmbAssignmentType.Location = new System.Drawing.Point(29, 101);
            this.cmbAssignmentType.Name = "cmbAssignmentType";
            this.cmbAssignmentType.Size = new System.Drawing.Size(220, 28);
            this.cmbAssignmentType.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(629, 107);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 20);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "رقم الهاتف:";
            // 
            // lblAssignmentType
            // 
            this.lblAssignmentType.AutoSize = true;
            this.lblAssignmentType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAssignmentType.Location = new System.Drawing.Point(260, 107);
            this.lblAssignmentType.Name = "lblAssignmentType";
            this.lblAssignmentType.Size = new System.Drawing.Size(85, 20);
            this.lblAssignmentType.TabIndex = 3;
            this.lblAssignmentType.Text = "نوع التكليف:";
            // 
            // lblQuranIjazah
            // 
            this.lblQuranIjazah.AutoSize = true;
            this.lblQuranIjazah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuranIjazah.Location = new System.Drawing.Point(260, 57);
            this.lblQuranIjazah.Name = "lblQuranIjazah";
            this.lblQuranIjazah.Size = new System.Drawing.Size(124, 20);
            this.lblQuranIjazah.TabIndex = 2;
            this.lblQuranIjazah.Text = "إجازة القرآن الكريم:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(629, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم المحفظ:";
            // 
            // grpCenterInfo
            // 
            this.grpCenterInfo.Controls.Add(this.numericUpDown1);
            this.grpCenterInfo.Controls.Add(this.label2);
            this.grpCenterInfo.Controls.Add(this.numTeachingHours);
            this.grpCenterInfo.Controls.Add(this.lblTeachingHours);
            this.grpCenterInfo.Controls.Add(this.cmbCommitment);
            this.grpCenterInfo.Controls.Add(this.lblCommitment);
            this.grpCenterInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCenterInfo.Location = new System.Drawing.Point(37, 276);
            this.grpCenterInfo.Name = "grpCenterInfo";
            this.grpCenterInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCenterInfo.Size = new System.Drawing.Size(749, 101);
            this.grpCenterInfo.TabIndex = 1;
            this.grpCenterInfo.TabStop = false;
            this.grpCenterInfo.Text = "معلومات المركز والتدريس";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDown1.Location = new System.Drawing.Point(44, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 27);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(111, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "الى";
            // 
            // numTeachingHours
            // 
            this.numTeachingHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTeachingHours.Location = new System.Drawing.Point(160, 43);
            this.numTeachingHours.Name = "numTeachingHours";
            this.numTeachingHours.Size = new System.Drawing.Size(63, 27);
            this.numTeachingHours.TabIndex = 5;
            // 
            // lblTeachingHours
            // 
            this.lblTeachingHours.AutoSize = true;
            this.lblTeachingHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTeachingHours.Location = new System.Drawing.Point(228, 45);
            this.lblTeachingHours.Name = "lblTeachingHours";
            this.lblTeachingHours.Size = new System.Drawing.Size(136, 20);
            this.lblTeachingHours.TabIndex = 4;
            this.lblTeachingHours.Text = "ساعات التدريس من ";
            // 
            // cmbCommitment
            // 
            this.cmbCommitment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommitment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCommitment.FormattingEnabled = true;
            this.cmbCommitment.Items.AddRange(new object[] {
            "ملتزم",
            "غير ملتزم"});
            this.cmbCommitment.Location = new System.Drawing.Point(400, 47);
            this.cmbCommitment.Name = "cmbCommitment";
            this.cmbCommitment.Size = new System.Drawing.Size(204, 28);
            this.cmbCommitment.TabIndex = 3;
            // 
            // lblCommitment
            // 
            this.lblCommitment.AutoSize = true;
            this.lblCommitment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCommitment.Location = new System.Drawing.Point(620, 47);
            this.lblCommitment.Name = "lblCommitment";
            this.lblCommitment.Size = new System.Drawing.Size(103, 20);
            this.lblCommitment.TabIndex = 2;
            this.lblCommitment.Text = "الالتزام بالكتيب:";
            // 
            // grpVisit1
            // 
            this.grpVisit1.Controls.Add(this.cmbAttendance1);
            this.grpVisit1.Controls.Add(this.lblAttendance1);
            this.grpVisit1.Controls.Add(this.numStudents1);
            this.grpVisit1.Controls.Add(this.lblStudents1);
            this.grpVisit1.Controls.Add(this.dtpVisitDate1);
            this.grpVisit1.Controls.Add(this.lblVisitDate1);
            this.grpVisit1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpVisit1.Location = new System.Drawing.Point(37, 405);
            this.grpVisit1.Name = "grpVisit1";
            this.grpVisit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpVisit1.Size = new System.Drawing.Size(749, 101);
            this.grpVisit1.TabIndex = 2;
            this.grpVisit1.TabStop = false;
            this.grpVisit1.Text = "معلومات الزيارة الأولى";
            // 
            // cmbAttendance1
            // 
            this.cmbAttendance1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttendance1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAttendance1.FormattingEnabled = true;
            this.cmbAttendance1.Items.AddRange(new object[] {
            "حاضر",
            "غائب"});
            this.cmbAttendance1.Location = new System.Drawing.Point(29, 45);
            this.cmbAttendance1.Name = "cmbAttendance1";
            this.cmbAttendance1.Size = new System.Drawing.Size(120, 28);
            this.cmbAttendance1.TabIndex = 5;
            // 
            // lblAttendance1
            // 
            this.lblAttendance1.AutoSize = true;
            this.lblAttendance1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAttendance1.Location = new System.Drawing.Point(160, 51);
            this.lblAttendance1.Name = "lblAttendance1";
            this.lblAttendance1.Size = new System.Drawing.Size(102, 20);
            this.lblAttendance1.TabIndex = 4;
            this.lblAttendance1.Text = "حضور المحفظ:";
            // 
            // numStudents1
            // 
            this.numStudents1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numStudents1.Location = new System.Drawing.Point(269, 45);
            this.numStudents1.Name = "numStudents1";
            this.numStudents1.Size = new System.Drawing.Size(100, 27);
            this.numStudents1.TabIndex = 3;
            // 
            // lblStudents1
            // 
            this.lblStudents1.AutoSize = true;
            this.lblStudents1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudents1.Location = new System.Drawing.Point(380, 51);
            this.lblStudents1.Name = "lblStudents1";
            this.lblStudents1.Size = new System.Drawing.Size(157, 20);
            this.lblStudents1.TabIndex = 2;
            this.lblStudents1.Text = "عدد الطلاب المتواجدين:";
            // 
            // dtpVisitDate1
            // 
            this.dtpVisitDate1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpVisitDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate1.Location = new System.Drawing.Point(549, 45);
            this.dtpVisitDate1.Name = "dtpVisitDate1";
            this.dtpVisitDate1.Size = new System.Drawing.Size(120, 27);
            this.dtpVisitDate1.TabIndex = 1;
            // 
            // lblVisitDate1
            // 
            this.lblVisitDate1.AutoSize = true;
            this.lblVisitDate1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVisitDate1.Location = new System.Drawing.Point(680, 51);
            this.lblVisitDate1.Name = "lblVisitDate1";
            this.lblVisitDate1.Size = new System.Drawing.Size(51, 20);
            this.lblVisitDate1.TabIndex = 0;
            this.lblVisitDate1.Text = "التاريخ:";
            // 
            // grpVisit2
            // 
            this.grpVisit2.Controls.Add(this.cmbAttendance2);
            this.grpVisit2.Controls.Add(this.lblAttendance2);
            this.grpVisit2.Controls.Add(this.numStudents2);
            this.grpVisit2.Controls.Add(this.lblStudents2);
            this.grpVisit2.Controls.Add(this.dtpVisitDate2);
            this.grpVisit2.Controls.Add(this.lblVisitDate2);
            this.grpVisit2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpVisit2.Location = new System.Drawing.Point(37, 513);
            this.grpVisit2.Name = "grpVisit2";
            this.grpVisit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpVisit2.Size = new System.Drawing.Size(749, 101);
            this.grpVisit2.TabIndex = 3;
            this.grpVisit2.TabStop = false;
            this.grpVisit2.Text = "معلومات الزيارة الثانية";
            // 
            // cmbAttendance2
            // 
            this.cmbAttendance2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttendance2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAttendance2.FormattingEnabled = true;
            this.cmbAttendance2.Items.AddRange(new object[] {
            "حاضر",
            "غائب"});
            this.cmbAttendance2.Location = new System.Drawing.Point(29, 45);
            this.cmbAttendance2.Name = "cmbAttendance2";
            this.cmbAttendance2.Size = new System.Drawing.Size(120, 28);
            this.cmbAttendance2.TabIndex = 5;
            // 
            // lblAttendance2
            // 
            this.lblAttendance2.AutoSize = true;
            this.lblAttendance2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAttendance2.Location = new System.Drawing.Point(160, 51);
            this.lblAttendance2.Name = "lblAttendance2";
            this.lblAttendance2.Size = new System.Drawing.Size(102, 20);
            this.lblAttendance2.TabIndex = 4;
            this.lblAttendance2.Text = "حضور المحفظ:";
            // 
            // numStudents2
            // 
            this.numStudents2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numStudents2.Location = new System.Drawing.Point(269, 45);
            this.numStudents2.Name = "numStudents2";
            this.numStudents2.Size = new System.Drawing.Size(100, 27);
            this.numStudents2.TabIndex = 3;
            // 
            // lblStudents2
            // 
            this.lblStudents2.AutoSize = true;
            this.lblStudents2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudents2.Location = new System.Drawing.Point(380, 51);
            this.lblStudents2.Name = "lblStudents2";
            this.lblStudents2.Size = new System.Drawing.Size(157, 20);
            this.lblStudents2.TabIndex = 2;
            this.lblStudents2.Text = "عدد الطلاب المتواجدين:";
            // 
            // dtpVisitDate2
            // 
            this.dtpVisitDate2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpVisitDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate2.Location = new System.Drawing.Point(549, 45);
            this.dtpVisitDate2.Name = "dtpVisitDate2";
            this.dtpVisitDate2.Size = new System.Drawing.Size(120, 27);
            this.dtpVisitDate2.TabIndex = 1;
            // 
            // lblVisitDate2
            // 
            this.lblVisitDate2.AutoSize = true;
            this.lblVisitDate2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVisitDate2.Location = new System.Drawing.Point(680, 51);
            this.lblVisitDate2.Name = "lblVisitDate2";
            this.lblVisitDate2.Size = new System.Drawing.Size(51, 20);
            this.lblVisitDate2.TabIndex = 0;
            this.lblVisitDate2.Text = "التاريخ:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(625, 631);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ البيانات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(453, 631);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 51);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المركز:";
            // 
            // comboxCenter
            // 
            this.comboxCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboxCenter.FormattingEnabled = true;
            this.comboxCenter.Location = new System.Drawing.Point(242, 35);
            this.comboxCenter.Name = "comboxCenter";
            this.comboxCenter.Size = new System.Drawing.Size(210, 31);
            this.comboxCenter.TabIndex = 36;
            this.comboxCenter.SelectedIndexChanged += new System.EventHandler(this.comboxCenter_SelectedIndexChanged);
            // 
            // phoonTextBox1
            // 
            this.phoonTextBox1.Culture = new System.Globalization.CultureInfo("ar-001");
            this.phoonTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoonTextBox1.Location = new System.Drawing.Point(400, 104);
            this.phoonTextBox1.Mask = "000-0000000";
            this.phoonTextBox1.Name = "phoonTextBox1";
            this.phoonTextBox1.Size = new System.Drawing.Size(220, 27);
            this.phoonTextBox1.TabIndex = 41;
            this.phoonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmAddTeacherVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.comboxCenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpVisit2);
            this.Controls.Add(this.grpVisit1);
            this.Controls.Add(this.grpCenterInfo);
            this.Controls.Add(this.grpTeacherInfo);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTeacherVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة زيارة جديدة لمحفظ";
            this.grpTeacherInfo.ResumeLayout(false);
            this.grpTeacherInfo.PerformLayout();
            this.grpCenterInfo.ResumeLayout(false);
            this.grpCenterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeachingHours)).EndInit();
            this.grpVisit1.ResumeLayout(false);
            this.grpVisit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudents1)).EndInit();
            this.grpVisit2.ResumeLayout(false);
            this.grpVisit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudents2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeacherInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuranIjazah;
        private System.Windows.Forms.Label lblAssignmentType;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox cmbAssignmentType;
        private System.Windows.Forms.ComboBox cmbQuranIjazah;
        private System.Windows.Forms.GroupBox grpCenterInfo;
        private System.Windows.Forms.Label lblCommitment;
        private System.Windows.Forms.ComboBox cmbCommitment;
        private System.Windows.Forms.Label lblTeachingHours;
        private System.Windows.Forms.NumericUpDown numTeachingHours;
        private System.Windows.Forms.GroupBox grpVisit1;
        private System.Windows.Forms.Label lblVisitDate1;
        private System.Windows.Forms.DateTimePicker dtpVisitDate1;
        private System.Windows.Forms.Label lblStudents1;
        private System.Windows.Forms.NumericUpDown numStudents1;
        private System.Windows.Forms.Label lblAttendance1;
        private System.Windows.Forms.ComboBox cmbAttendance1;
        private System.Windows.Forms.GroupBox grpVisit2;
        private System.Windows.Forms.ComboBox cmbAttendance2;
        private System.Windows.Forms.Label lblAttendance2;
        private System.Windows.Forms.NumericUpDown numStudents2;
        private System.Windows.Forms.Label lblStudents2;
        private System.Windows.Forms.DateTimePicker dtpVisitDate2;
        private System.Windows.Forms.Label lblVisitDate2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTecher;
        private System.Windows.Forms.ComboBox comboxCenter;
        private System.Windows.Forms.MaskedTextBox phoonTextBox1;
    }
}
