namespace النظام_النهائي
{
    partial class frmEditSupervisor_A2
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
            this.txtRegistrationNum = new System.Windows.Forms.TextBox();
            this.lblRegistrationNum = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.lblResidency = new System.Windows.Forms.Label();
            this.txtResidency = new System.Windows.Forms.TextBox();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.txtSupervisorName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(505, 60);
            this.pnlTopBar.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(505, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "تعديل بيانات مشرف";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtRegistrationNum);
            this.pnlMain.Controls.Add(this.lblRegistrationNum);
            this.pnlMain.Controls.Add(this.cmbGender);
            this.pnlMain.Controls.Add(this.dtpBirthDate);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblAssignment);
            this.pnlMain.Controls.Add(this.txtAssignment);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.txtQualification);
            this.pnlMain.Controls.Add(this.lblResidency);
            this.pnlMain.Controls.Add(this.txtResidency);
            this.pnlMain.Controls.Add(this.lblSupervisorName);
            this.pnlMain.Controls.Add(this.txtSupervisorName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(505, 459);
            this.pnlMain.TabIndex = 12;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 30);
            this.textBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(310, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "رقم الوطني ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegistrationNum
            // 
            this.txtRegistrationNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegistrationNum.Location = new System.Drawing.Point(12, 333);
            this.txtRegistrationNum.Name = "txtRegistrationNum";
            this.txtRegistrationNum.Size = new System.Drawing.Size(210, 30);
            this.txtRegistrationNum.TabIndex = 31;
            // 
            // lblRegistrationNum
            // 
            this.lblRegistrationNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRegistrationNum.Location = new System.Drawing.Point(310, 320);
            this.lblRegistrationNum.Name = "lblRegistrationNum";
            this.lblRegistrationNum.Size = new System.Drawing.Size(168, 25);
            this.lblRegistrationNum.TabIndex = 30;
            this.lblRegistrationNum.Text = "رقم الهاتف ";
            this.lblRegistrationNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cmbGender.Location = new System.Drawing.Point(12, 233);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(210, 31);
            this.cmbGender.TabIndex = 29;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(12, 83);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDate.TabIndex = 28;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDate.Location = new System.Drawing.Point(310, 70);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(168, 25);
            this.lblBirthDate.TabIndex = 27;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignment
            // 
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssignment.Location = new System.Drawing.Point(310, 270);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(168, 25);
            this.lblAssignment.TabIndex = 26;
            this.lblAssignment.Text = "التكليف:";
            this.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAssignment.Location = new System.Drawing.Point(12, 283);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(210, 30);
            this.txtAssignment.TabIndex = 25;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(310, 220);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(168, 25);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "الجنس:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualification.Location = new System.Drawing.Point(310, 170);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(168, 25);
            this.lblQualification.TabIndex = 23;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQualification
            // 
            this.txtQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQualification.Location = new System.Drawing.Point(12, 183);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(210, 30);
            this.txtQualification.TabIndex = 22;
            // 
            // lblResidency
            // 
            this.lblResidency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResidency.Location = new System.Drawing.Point(310, 120);
            this.lblResidency.Name = "lblResidency";
            this.lblResidency.Size = new System.Drawing.Size(168, 25);
            this.lblResidency.TabIndex = 21;
            this.lblResidency.Text = "الإقامة:";
            this.lblResidency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResidency
            // 
            this.txtResidency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResidency.Location = new System.Drawing.Point(12, 133);
            this.txtResidency.Name = "txtResidency";
            this.txtResidency.Size = new System.Drawing.Size(210, 30);
            this.txtResidency.TabIndex = 20;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupervisorName.Location = new System.Drawing.Point(310, 20);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(168, 25);
            this.lblSupervisorName.TabIndex = 19;
            this.lblSupervisorName.Text = "اسم المشرف:";
            this.lblSupervisorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupervisorName
            // 
            this.txtSupervisorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSupervisorName.Location = new System.Drawing.Point(12, 35);
            this.txtSupervisorName.Name = "txtSupervisorName";
            this.txtSupervisorName.Size = new System.Drawing.Size(210, 30);
            this.txtSupervisorName.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(9, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 45);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "إغلاق";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(378, 605);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(114, 45);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "حفظ";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.textBox2);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 519);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(505, 80);
            this.pnlSearch.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(254, -30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 30);
            this.textBox2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(44, -30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "رقم القيد:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(21, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(115, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(340, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(156, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "ابحث بالاسم أو القيد:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(198, 605);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(158, 45);
            this.btnResetPassword.TabIndex = 16;
            this.btnResetPassword.Text = "إعادة تعيين كلمة المرور";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // frmEditSupervisor_A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 665);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditSupervisor_A2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل بيانات مشرف";
            this.Load += new System.EventHandler(this.frmEditSupervisor_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtRegistrationNum;
        private System.Windows.Forms.Label lblRegistrationNum;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblResidency;
        private System.Windows.Forms.TextBox txtResidency;
        private System.Windows.Forms.Label lblSupervisorName;
        private System.Windows.Forms.TextBox txtSupervisorName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
