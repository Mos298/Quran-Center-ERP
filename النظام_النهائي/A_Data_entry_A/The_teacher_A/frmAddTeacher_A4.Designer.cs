namespace النظام_النهائي
{
    partial class frmAddTeacher_A4
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
            this.assignment = new System.Windows.Forms.ComboBox();
            this.comboxCenter = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblResidency = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxqualification = new System.Windows.Forms.ComboBox();
            this.comboBoxcity = new System.Windows.Forms.ComboBox();
            this.phoonTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.National_number = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pnlTopBar.Size = new System.Drawing.Size(471, 60);
            this.pnlTopBar.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(471, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "إضافة بيانات محفّظ جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.National_number);
            this.pnlMain.Controls.Add(this.phoonTextBox1);
            this.pnlMain.Controls.Add(this.comboBoxcity);
            this.pnlMain.Controls.Add(this.comboBoxqualification);
            this.pnlMain.Controls.Add(this.assignment);
            this.pnlMain.Controls.Add(this.comboxCenter);
            this.pnlMain.Controls.Add(this.txtPosition);
            this.pnlMain.Controls.Add(this.lblPosition);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cmbGender);
            this.pnlMain.Controls.Add(this.dtpBirthDate);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblAssignment);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.lblResidency);
            this.pnlMain.Controls.Add(this.lblTeacherName);
            this.pnlMain.Controls.Add(this.txtTeacherName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(471, 530);
            this.pnlMain.TabIndex = 11;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // assignment
            // 
            this.assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.assignment.FormattingEnabled = true;
            this.assignment.Items.AddRange(new object[] {
            "مكلف ",
            "مصنف ",
            "متطوع "});
            this.assignment.Location = new System.Drawing.Point(14, 325);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(210, 31);
            this.assignment.TabIndex = 37;
            // 
            // comboxCenter
            // 
            this.comboxCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboxCenter.FormattingEnabled = true;
            this.comboxCenter.Location = new System.Drawing.Point(14, 72);
            this.comboxCenter.Name = "comboxCenter";
            this.comboxCenter.Size = new System.Drawing.Size(210, 31);
            this.comboxCenter.TabIndex = 35;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Location = new System.Drawing.Point(14, 459);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(210, 30);
            this.txtPosition.TabIndex = 33;
            this.txtPosition.Text = "محفظ ";
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPosition.Location = new System.Drawing.Point(240, 461);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(192, 25);
            this.lblPosition.TabIndex = 34;
            this.lblPosition.Text = "المنصب:";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(240, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "رقم الوطني ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(240, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "رقم الهاتف ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ذكر ",
            "انثى"});
            this.cmbGender.Location = new System.Drawing.Point(14, 279);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(210, 31);
            this.cmbGender.TabIndex = 5;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(14, 129);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDate.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDate.Location = new System.Drawing.Point(240, 131);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(192, 25);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignment
            // 
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssignment.Location = new System.Drawing.Point(240, 331);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(192, 25);
            this.lblAssignment.TabIndex = 11;
            this.lblAssignment.Text = "التكليف:";
            this.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(240, 281);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(192, 25);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "الجنس:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualification.Location = new System.Drawing.Point(240, 231);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(192, 25);
            this.lblQualification.TabIndex = 7;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResidency
            // 
            this.lblResidency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResidency.Location = new System.Drawing.Point(240, 181);
            this.lblResidency.Name = "lblResidency";
            this.lblResidency.Size = new System.Drawing.Size(192, 25);
            this.lblResidency.TabIndex = 5;
            this.lblResidency.Text = "المدينة :";
            this.lblResidency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTeacherName.Location = new System.Drawing.Point(240, 17);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(192, 25);
            this.lblTeacherName.TabIndex = 3;
            this.lblTeacherName.Text = "اسم المحفّظ:";
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTeacherName.Location = new System.Drawing.Point(14, 15);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(210, 30);
            this.txtTeacherName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(225, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 45);
            this.btnCancel.TabIndex = 9;
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
            this.btnSave.Location = new System.Drawing.Point(345, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxqualification
            // 
            this.comboBoxqualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxqualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxqualification.FormattingEnabled = true;
            this.comboBoxqualification.Items.AddRange(new object[] {
            "دبلوم عالي ",
            "بكلوريوس",
            "ماجستير",
            "دكتورار  "});
            this.comboBoxqualification.Location = new System.Drawing.Point(14, 225);
            this.comboBoxqualification.Name = "comboBoxqualification";
            this.comboBoxqualification.Size = new System.Drawing.Size(210, 31);
            this.comboBoxqualification.TabIndex = 38;
            // 
            // comboBoxcity
            // 
            this.comboBoxcity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxcity.FormattingEnabled = true;
            this.comboBoxcity.Location = new System.Drawing.Point(14, 179);
            this.comboBoxcity.Name = "comboBoxcity";
            this.comboBoxcity.Size = new System.Drawing.Size(210, 31);
            this.comboBoxcity.TabIndex = 39;
            this.comboBoxcity.SelectedIndexChanged += new System.EventHandler(this.comboBoxcity_SelectedIndexChanged);
            // 
            // phoonTextBox1
            // 
            this.phoonTextBox1.Culture = new System.Globalization.CultureInfo("ar-001");
            this.phoonTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoonTextBox1.Location = new System.Drawing.Point(14, 370);
            this.phoonTextBox1.Mask = "000-0000000";
            this.phoonTextBox1.Name = "phoonTextBox1";
            this.phoonTextBox1.Size = new System.Drawing.Size(210, 24);
            this.phoonTextBox1.TabIndex = 40;
            this.phoonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // National_number
            // 
            this.National_number.Location = new System.Drawing.Point(14, 412);
            this.National_number.Mask = "000000000000";
            this.National_number.Name = "National_number";
            this.National_number.Size = new System.Drawing.Size(210, 24);
            this.National_number.TabIndex = 44;
            this.National_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(240, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "المراكز :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddTeacher_A4
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 657);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTeacher_A4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة محفّظ";
            this.Load += new System.EventHandler(this.frmAddTeacher_A4_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblResidency;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox comboxCenter;
        private System.Windows.Forms.ComboBox assignment;
        private System.Windows.Forms.ComboBox comboBoxqualification;
        private System.Windows.Forms.ComboBox comboBoxcity;
        private System.Windows.Forms.MaskedTextBox phoonTextBox1;
        private System.Windows.Forms.MaskedTextBox National_number;
        private System.Windows.Forms.Label label3;
    }
}
