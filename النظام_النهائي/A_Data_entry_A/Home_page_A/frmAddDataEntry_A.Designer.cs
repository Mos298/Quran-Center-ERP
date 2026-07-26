namespace النظام_النهائي
{
    partial class frmAddDataEntry_A
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtRegistrationNum = new System.Windows.Forms.TextBox();
            this.lblRegistrationNum = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
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
            this.pnlTopBar.Size = new System.Drawing.Size(446, 60);
            this.pnlTopBar.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(446, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "إضافة مدخل بيانات جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtNationalId);
            this.pnlMain.Controls.Add(this.lblNationalId);
            this.pnlMain.Controls.Add(this.txtPhoneNumber);
            this.pnlMain.Controls.Add(this.lblPhoneNumber);
            this.pnlMain.Controls.Add(this.txtRegistrationNum);
            this.pnlMain.Controls.Add(this.lblRegistrationNum);
            this.pnlMain.Controls.Add(this.txtPosition);
            this.pnlMain.Controls.Add(this.lblPosition);
            this.pnlMain.Controls.Add(this.txtDepartment);
            this.pnlMain.Controls.Add(this.lblDepartment);
            this.pnlMain.Controls.Add(this.cmbGender);
            this.pnlMain.Controls.Add(this.dtpBirthDate);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.txtQualification);
            this.pnlMain.Controls.Add(this.lblFullName);
            this.pnlMain.Controls.Add(this.txtFullName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(446, 498);
            this.pnlMain.TabIndex = 12;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(28, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 30);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(244, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "المدينة:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNationalId
            // 
            this.txtNationalId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNationalId.Location = new System.Drawing.Point(28, 406);
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(210, 30);
            this.txtNationalId.TabIndex = 8;
            // 
            // lblNationalId
            // 
            this.lblNationalId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNationalId.Location = new System.Drawing.Point(244, 406);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(192, 25);
            this.lblNationalId.TabIndex = 20;
            this.lblNationalId.Text = "الرقم الوطني:";
            this.lblNationalId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(28, 356);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(210, 30);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(244, 356);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(192, 25);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "رقم الهاتف:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegistrationNum
            // 
            this.txtRegistrationNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtRegistrationNum.Location = new System.Drawing.Point(28, 306);
            this.txtRegistrationNum.Name = "txtRegistrationNum";
            this.txtRegistrationNum.ReadOnly = true;
            this.txtRegistrationNum.Size = new System.Drawing.Size(210, 30);
            this.txtRegistrationNum.TabIndex = 6;
            this.txtRegistrationNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRegistrationNum
            // 
            this.lblRegistrationNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRegistrationNum.Location = new System.Drawing.Point(244, 306);
            this.lblRegistrationNum.Name = "lblRegistrationNum";
            this.lblRegistrationNum.Size = new System.Drawing.Size(192, 25);
            this.lblRegistrationNum.TabIndex = 16;
            this.lblRegistrationNum.Text = "رقم القيد:";
            this.lblRegistrationNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Location = new System.Drawing.Point(28, 256);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(210, 30);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.Text = "مدخل بيانات";
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPosition.Location = new System.Drawing.Point(244, 256);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(192, 25);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "المنصب:";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDepartment.Location = new System.Drawing.Point(28, 206);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(210, 30);
            this.txtDepartment.TabIndex = 4;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDepartment.Location = new System.Drawing.Point(244, 206);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(192, 25);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "القسم:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cmbGender.Location = new System.Drawing.Point(28, 156);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(210, 31);
            this.cmbGender.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(28, 62);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDate.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDate.Location = new System.Drawing.Point(244, 62);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(192, 25);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBirthDate.Click += new System.EventHandler(this.lblBirthDate_Click);
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(244, 156);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(192, 25);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "الجنس:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualification.Location = new System.Drawing.Point(244, 106);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(192, 25);
            this.lblQualification.TabIndex = 5;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQualification
            // 
            this.txtQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQualification.Location = new System.Drawing.Point(28, 106);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(210, 30);
            this.txtQualification.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.Location = new System.Drawing.Point(244, 26);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(192, 25);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "الاسم:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(28, 26);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(210, 30);
            this.txtFullName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(197, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 45);
            this.btnCancel.TabIndex = 14;
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
            this.btnSave.Location = new System.Drawing.Point(327, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddDataEntry_A
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(446, 635);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddDataEntry_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة مدخل بيانات";
            this.Load += new System.EventHandler(this.frmAddDataEntry_Load);
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
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRegistrationNum;
        private System.Windows.Forms.Label lblRegistrationNum;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.Label lblNationalId;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
