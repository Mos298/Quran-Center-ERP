namespace النظام_النهائي
{
    partial class frmAddSupervisor_A2
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.comboAlojamiento = new System.Windows.Forms.ComboBox();
            this.National_number = new System.Windows.Forms.MaskedTextBox();
            this.phoonTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboassignment = new System.Windows.Forms.ComboBox();
            this.comboAcademic_qualification = new System.Windows.Forms.ComboBox();
            this.chklstTeachers = new System.Windows.Forms.CheckedListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblResidency = new System.Windows.Forms.Label();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.txtSupervisorName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(665, 60);
            this.pnlTopBar.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(665, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "إضافة مشرف جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.chklstTeachers);
            this.pnlMain.Controls.Add(this.comboAlojamiento);
            this.pnlMain.Controls.Add(this.lblSelect);
            this.pnlMain.Controls.Add(this.National_number);
            this.pnlMain.Controls.Add(this.phoonTextBox1);
            this.pnlMain.Controls.Add(this.comboassignment);
            this.pnlMain.Controls.Add(this.comboAcademic_qualification);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtPosition);
            this.pnlMain.Controls.Add(this.lblPosition);
            this.pnlMain.Controls.Add(this.cmbGender);
            this.pnlMain.Controls.Add(this.dtpBirthDate);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblAssignment);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.lblResidency);
            this.pnlMain.Controls.Add(this.lblSupervisorName);
            this.pnlMain.Controls.Add(this.txtSupervisorName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(665, 503);
            this.pnlMain.TabIndex = 11;
            // 
            // comboAlojamiento
            // 
            this.comboAlojamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlojamiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAlojamiento.FormattingEnabled = true;
            this.comboAlojamiento.Items.AddRange(new object[] {
            "",
            "1. أبوسليم",
            "2. أوباري",
            "3. أوجلة",
            "4. اجخرة",
            "5. إجدابيا",
            "6. إدري الشاطئ",
            "7. اسبيعة",
            "8. الأبرق",
            "9. الأبيار",
            "10. الأصابعة",
            "11. البردي",
            "12. البريقة",
            "13. البيضاء",
            "14. الجفرة",
            "15. الجميل",
            "16. الحرابة",
            "17. الحوامد",
            "18. الخمس",
            "19. الرجبان",
            "20. الرحيبات",
            "21. الرياينة",
            "22. الزاوية",
            "23. الزاوية الجنوب",
            "24. الزاوية الغرب",
            "25. الزنتان",
            "26. الزهراء",
            "27. الزويتينة سلطان",
            "28. السائح",
            "29. الشرقية",
            "30. الشقيقة",
            "31. الشويرف",
            "32. العامرية",
            "33. العجيلات",
            "34. العربان",
            "35. العزيزية",
            "36. العواته",
            "37. الغريفة",
            "38. القبة",
            "39. القرة بوللي",
            "40. القرضة الشاطئ",
            "41. القطرون",
            "42. القلعة",
            "43. القواليش",
            "44. القيقب",
            "45. الكفرة",
            "46. الماية",
            "47. المرج",
            "48. العوينة",
            "49. المعمورة",
            "50. المليطانية",
            "51. المنشية الجميل",
            "52. الناصرية",
            "53. امساعد",
            "54. انتلات البيضان",
            "55. بئر الأشهب",
            "56. باطن الجبل",
            "57. براك الشاطئ",
            "58. بنت بية",
            "59. بنغازي",
            "60. بني وليد",
            "61. تاجوراء",
            "62. تازربو",
            "63. تاورغاء",
            "64. تراغن",
            "65. ترهونة",
            "66. توكرة",
            "67. جادو",
            "68. جالو",
            "69. جردس العبيد",
            "70. جنزور",
            "71. جنوب الجبل الأخضر",
            "72. حي الأندلس",
            "73. خليج السدرة",
            "74. درج",
            "75. درنة",
            "76. ربيانة",
            "77. رقدالين",
            "78. زلطن",
            "79. زليتن",
            "80. زمزم",
            "81. زوارة",
            "82. ساحل الجبل",
            "83. سبها",
            "84. سرت",
            "85. سلوق",
            "86. سواني بن أدم",
            "87. سوسة",
            "88. سوق الجمعة",
            "89. سوق الخميس",
            "90. شحات",
            "91. صبراتة",
            "92. صرمان",
            "93. طبرق",
            "94. طرابلس المركز",
            "95. ظاهر الجبل",
            "96. عمر المختار",
            "97. عين زارة",
            "98. عين غزالة",
            "99. غات",
            "100. غدامس",
            "101. غريان",
            "102. قصر بن غشير",
            "103. قصر خيار",
            "104. قمينس",
            "105. كاباو",
            "106. ككلة",
            "107. مرادة",
            "108. مرزق",
            "109. مرسى دفنة",
            "110. مزدة",
            "111. مسلاتة",
            "112. مصراتة",
            "113. نالوت",
            "114. نسمة",
            "115. هراوة",
            "116. وادي البوانيس",
            "117. وادي عتبة",
            "118. وازن",
            "119. وردامة",
            "120. يفرن",
            "121. أم الرزم",
            "122. الجليدة",
            "123. الجديدة",
            "124. مدور الزيتون",
            "125. العوينات",
            "126. تجرهي",
            "127. المردوم",
            "128. تنيناي",
            "129. القريات",
            "130. زلة",
            "131. برقن",
            "132. اوال",
            "133. تهالة",
            "134. بركت",
            "135. سيناون",
            "136. زويلة",
            "137. راس الطبل",
            "138. المنطقة الادارية الشعبة",
            "139. جرمة",
            "140. قرارة",
            "141. الرقيبة"});
            this.comboAlojamiento.Location = new System.Drawing.Point(254, 138);
            this.comboAlojamiento.Name = "comboAlojamiento";
            this.comboAlojamiento.Size = new System.Drawing.Size(210, 31);
            this.comboAlojamiento.TabIndex = 44;
            this.comboAlojamiento.SelectedIndexChanged += new System.EventHandler(this.comboAlojamiento_SelectedIndexChanged);
            // 
            // National_number
            // 
            this.National_number.Location = new System.Drawing.Point(254, 430);
            this.National_number.Mask = "000000000000";
            this.National_number.Name = "National_number";
            this.National_number.Size = new System.Drawing.Size(210, 24);
            this.National_number.TabIndex = 43;
            this.National_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phoonTextBox1
            // 
            this.phoonTextBox1.Culture = new System.Globalization.CultureInfo("ar-001");
            this.phoonTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoonTextBox1.Location = new System.Drawing.Point(254, 383);
            this.phoonTextBox1.Mask = "000-0000000";
            this.phoonTextBox1.Name = "phoonTextBox1";
            this.phoonTextBox1.Size = new System.Drawing.Size(210, 24);
            this.phoonTextBox1.TabIndex = 14;
            this.phoonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboassignment
            // 
            this.comboassignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboassignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboassignment.FormattingEnabled = true;
            this.comboassignment.Items.AddRange(new object[] {
            "مصنف ",
            "مكافاة ",
            "متطوع"});
            this.comboassignment.Location = new System.Drawing.Point(254, 289);
            this.comboassignment.Name = "comboassignment";
            this.comboassignment.Size = new System.Drawing.Size(210, 31);
            this.comboassignment.TabIndex = 42;
            // 
            // comboAcademic_qualification
            // 
            this.comboAcademic_qualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAcademic_qualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAcademic_qualification.FormattingEnabled = true;
            this.comboAcademic_qualification.Items.AddRange(new object[] {
            "دبلوم عالى معهد ",
            "بكلويوس ",
            "ماستير ",
            "دكتوراء "});
            this.comboAcademic_qualification.Location = new System.Drawing.Point(254, 188);
            this.comboAcademic_qualification.Name = "comboAcademic_qualification";
            this.comboAcademic_qualification.Size = new System.Drawing.Size(210, 31);
            this.comboAcademic_qualification.TabIndex = 41;
            this.comboAcademic_qualification.SelectedIndexChanged += new System.EventHandler(this.comboAcademic_qualification_SelectedIndexChanged);
            // 
            // chklstTeachers
            // 
            this.chklstTeachers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chklstTeachers.FormattingEnabled = true;
            this.chklstTeachers.Location = new System.Drawing.Point(3, 69);
            this.chklstTeachers.Name = "chklstTeachers";
            this.chklstTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklstTeachers.Size = new System.Drawing.Size(221, 404);
            this.chklstTeachers.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(70, 40);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelect.Size = new System.Drawing.Size(94, 23);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "حدد المراكز ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(502, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "الرقم الوطني ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(513, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "رقم الهاتف ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Location = new System.Drawing.Point(254, 335);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(210, 30);
            this.txtPosition.TabIndex = 32;
            this.txtPosition.Text = "مشرف ";
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPosition.Location = new System.Drawing.Point(513, 335);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(136, 25);
            this.lblPosition.TabIndex = 33;
            this.lblPosition.Text = "المنصب:";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cmbGender.Location = new System.Drawing.Point(254, 240);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(210, 31);
            this.cmbGender.TabIndex = 29;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(254, 90);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDate.TabIndex = 28;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDate.Location = new System.Drawing.Point(513, 90);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(136, 25);
            this.lblBirthDate.TabIndex = 27;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignment
            // 
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssignment.Location = new System.Drawing.Point(513, 289);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(132, 25);
            this.lblAssignment.TabIndex = 26;
            this.lblAssignment.Text = "التكليف:";
            this.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(513, 240);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(128, 25);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "الجنس:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualification.Location = new System.Drawing.Point(513, 188);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(132, 25);
            this.lblQualification.TabIndex = 23;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResidency
            // 
            this.lblResidency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResidency.Location = new System.Drawing.Point(513, 138);
            this.lblResidency.Name = "lblResidency";
            this.lblResidency.Size = new System.Drawing.Size(136, 25);
            this.lblResidency.TabIndex = 21;
            this.lblResidency.Text = "الإقامة:";
            this.lblResidency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupervisorName.Location = new System.Drawing.Point(513, 40);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(140, 25);
            this.lblSupervisorName.TabIndex = 19;
            this.lblSupervisorName.Text = "اسم المشرف:";
            this.lblSupervisorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupervisorName
            // 
            this.txtSupervisorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSupervisorName.Location = new System.Drawing.Point(254, 40);
            this.txtSupervisorName.Multiline = true;
            this.txtSupervisorName.Name = "txtSupervisorName";
            this.txtSupervisorName.Size = new System.Drawing.Size(210, 33);
            this.txtSupervisorName.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(349, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 58);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(513, 597);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 59);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddSupervisor_A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 668);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSupervisor_A2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة مشرف جديد";
            this.Load += new System.EventHandler(this.frmAddSupervisor_A2_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblResidency;
        private System.Windows.Forms.Label lblSupervisorName;
        private System.Windows.Forms.TextBox txtSupervisorName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chklstTeachers;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox comboAcademic_qualification;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox comboassignment;
        private System.Windows.Forms.MaskedTextBox phoonTextBox1;
        private System.Windows.Forms.MaskedTextBox National_number;
        private System.Windows.Forms.ComboBox comboAlojamiento;
    }
}
