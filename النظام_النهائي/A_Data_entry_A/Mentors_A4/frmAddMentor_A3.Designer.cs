namespace النظام_النهائي
{
    partial class frmAddMentor_A3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblResidency = new System.Windows.Forms.Label();
            this.lblMentorName = new System.Windows.Forms.Label();
            this.txtMentorName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxqualification = new System.Windows.Forms.ComboBox();
            this.comboxAccommodation = new System.Windows.Forms.ComboBox();
            this.comboBoxassignment = new System.Windows.Forms.ComboBox();
            this.chklstCenter = new System.Windows.Forms.CheckedListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.National_number = new System.Windows.Forms.MaskedTextBox();
            this.phoonTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            this.pnlTopBar.Size = new System.Drawing.Size(699, 60);
            this.pnlTopBar.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(699, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "إضافة بيانات موجه جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.National_number);
            this.pnlMain.Controls.Add(this.phoonTextBox1);
            this.pnlMain.Controls.Add(this.chklstCenter);
            this.pnlMain.Controls.Add(this.lblSelect);
            this.pnlMain.Controls.Add(this.comboBoxassignment);
            this.pnlMain.Controls.Add(this.comboxAccommodation);
            this.pnlMain.Controls.Add(this.comboBoxqualification);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cmbGender);
            this.pnlMain.Controls.Add(this.dtpBirthDate);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblAssignment);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.lblResidency);
            this.pnlMain.Controls.Add(this.lblMentorName);
            this.pnlMain.Controls.Add(this.txtMentorName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(699, 462);
            this.pnlMain.TabIndex = 11;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(495, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "رقم الوطني :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(495, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "رقم الهتف : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbGender.TabIndex = 5;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(254, 80);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDate.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDate.Location = new System.Drawing.Point(495, 85);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(192, 25);
            this.lblBirthDate.TabIndex = 27;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignment
            // 
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssignment.Location = new System.Drawing.Point(495, 294);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(192, 25);
            this.lblAssignment.TabIndex = 26;
            this.lblAssignment.Text = "التكليف :";
            this.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(495, 240);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(192, 25);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "الجنس :";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualification.Location = new System.Drawing.Point(495, 190);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(192, 25);
            this.lblQualification.TabIndex = 23;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResidency
            // 
            this.lblResidency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResidency.Location = new System.Drawing.Point(495, 138);
            this.lblResidency.Name = "lblResidency";
            this.lblResidency.Size = new System.Drawing.Size(192, 25);
            this.lblResidency.TabIndex = 21;
            this.lblResidency.Text = "الإقامة:";
            this.lblResidency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMentorName
            // 
            this.lblMentorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMentorName.Location = new System.Drawing.Point(495, 40);
            this.lblMentorName.Name = "lblMentorName";
            this.lblMentorName.Size = new System.Drawing.Size(192, 25);
            this.lblMentorName.TabIndex = 19;
            this.lblMentorName.Text = "اسم الموجه:";
            this.lblMentorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMentorName.Click += new System.EventHandler(this.lblMentorName_Click);
            // 
            // txtMentorName
            // 
            this.txtMentorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMentorName.Location = new System.Drawing.Point(254, 35);
            this.txtMentorName.Name = "txtMentorName";
            this.txtMentorName.Size = new System.Drawing.Size(210, 30);
            this.txtMentorName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(390, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 56);
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
            this.btnSave.Location = new System.Drawing.Point(540, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 56);
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
            "ماستر ",
            "دكتوراء "});
            this.comboBoxqualification.Location = new System.Drawing.Point(254, 188);
            this.comboBoxqualification.Name = "comboBoxqualification";
            this.comboBoxqualification.Size = new System.Drawing.Size(210, 31);
            this.comboBoxqualification.TabIndex = 37;
            // 
            // comboxAccommodation
            // 
            this.comboxAccommodation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxAccommodation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboxAccommodation.FormattingEnabled = true;
            this.comboxAccommodation.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.comboxAccommodation.Location = new System.Drawing.Point(254, 138);
            this.comboxAccommodation.Name = "comboxAccommodation";
            this.comboxAccommodation.Size = new System.Drawing.Size(210, 31);
            this.comboxAccommodation.TabIndex = 38;
            this.comboxAccommodation.SelectedIndexChanged += new System.EventHandler(this.comboxAccommodation_SelectedIndexChanged);
            // 
            // comboBoxassignment
            // 
            this.comboBoxassignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxassignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxassignment.FormattingEnabled = true;
            this.comboBoxassignment.Items.AddRange(new object[] {
            "مصنف",
            "مكافاء",
            "متطوع"});
            this.comboBoxassignment.Location = new System.Drawing.Point(254, 288);
            this.comboBoxassignment.Name = "comboBoxassignment";
            this.comboBoxassignment.Size = new System.Drawing.Size(210, 31);
            this.comboBoxassignment.TabIndex = 39;
            // 
            // chklstCenter
            // 
            this.chklstCenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chklstCenter.FormattingEnabled = true;
            this.chklstCenter.Location = new System.Drawing.Point(12, 40);
            this.chklstCenter.Name = "chklstCenter";
            this.chklstCenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklstCenter.Size = new System.Drawing.Size(211, 404);
            this.chklstCenter.TabIndex = 41;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(121, 14);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelect.Size = new System.Drawing.Size(94, 23);
            this.lblSelect.TabIndex = 40;
            this.lblSelect.Text = "حدد المراكز ";
            // 
            // National_number
            // 
            this.National_number.Location = new System.Drawing.Point(254, 387);
            this.National_number.Mask = "000000000000";
            this.National_number.Name = "National_number";
            this.National_number.Size = new System.Drawing.Size(210, 24);
            this.National_number.TabIndex = 45;
            this.National_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phoonTextBox1
            // 
            this.phoonTextBox1.Culture = new System.Globalization.CultureInfo("ar-001");
            this.phoonTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoonTextBox1.Location = new System.Drawing.Point(254, 340);
            this.phoonTextBox1.Mask = "000-0000000";
            this.phoonTextBox1.Name = "phoonTextBox1";
            this.phoonTextBox1.Size = new System.Drawing.Size(210, 24);
            this.phoonTextBox1.TabIndex = 44;
            this.phoonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.phoonTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoonTextBox1_MaskInputRejected);
            // 
            // frmAddMentor_A3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 648);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMentor_A3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة موجه";
            this.Load += new System.EventHandler(this.frmAddMentor_A3_Load);
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
        private System.Windows.Forms.Label lblMentorName;
        private System.Windows.Forms.TextBox txtMentorName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxAccommodation;
        private System.Windows.Forms.ComboBox comboBoxqualification;
        private System.Windows.Forms.ComboBox comboBoxassignment;
        private System.Windows.Forms.CheckedListBox chklstCenter;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.MaskedTextBox National_number;
        private System.Windows.Forms.MaskedTextBox phoonTextBox1;
    }
}
