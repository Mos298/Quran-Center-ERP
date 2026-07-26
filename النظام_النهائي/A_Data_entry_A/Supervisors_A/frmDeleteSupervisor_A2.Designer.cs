namespace النظام_النهائي
{
    partial class frmDeleteSupervisor_A2
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
            this.lblRegistrationNumValue = new System.Windows.Forms.Label();
            this.lblAssignmentValue = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblQualificationValue = new System.Windows.Forms.Label();
            this.lblResidencyValue = new System.Windows.Forms.Label();
            this.lblBirthDateValue = new System.Windows.Forms.Label();
            this.lblSupervisorNameValue = new System.Windows.Forms.Label();
            this.lblRegistrationNum = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblResidency = new System.Windows.Forms.Label();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pnlTopBar.Size = new System.Drawing.Size(520, 60);
            this.pnlTopBar.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(520, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "حذف بيانات مشرف";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.lblRegistrationNumValue);
            this.pnlMain.Controls.Add(this.lblAssignmentValue);
            this.pnlMain.Controls.Add(this.lblGenderValue);
            this.pnlMain.Controls.Add(this.lblQualificationValue);
            this.pnlMain.Controls.Add(this.lblResidencyValue);
            this.pnlMain.Controls.Add(this.lblBirthDateValue);
            this.pnlMain.Controls.Add(this.lblSupervisorNameValue);
            this.pnlMain.Controls.Add(this.lblRegistrationNum);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblAssignment);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.lblResidency);
            this.pnlMain.Controls.Add(this.lblSupervisorName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(520, 427);
            this.pnlMain.TabIndex = 13;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // lblRegistrationNumValue
            // 
            this.lblRegistrationNumValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRegistrationNumValue.Location = new System.Drawing.Point(44, 290);
            this.lblRegistrationNumValue.Name = "lblRegistrationNumValue";
            this.lblRegistrationNumValue.Size = new System.Drawing.Size(192, 25);
            this.lblRegistrationNumValue.TabIndex = 45;
            this.lblRegistrationNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssignmentValue
            // 
            this.lblAssignmentValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssignmentValue.Location = new System.Drawing.Point(44, 240);
            this.lblAssignmentValue.Name = "lblAssignmentValue";
            this.lblAssignmentValue.Size = new System.Drawing.Size(192, 25);
            this.lblAssignmentValue.TabIndex = 44;
            this.lblAssignmentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAssignmentValue.Click += new System.EventHandler(this.lblAssignmentValue_Click);
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGenderValue.Location = new System.Drawing.Point(44, 190);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(192, 25);
            this.lblGenderValue.TabIndex = 43;
            this.lblGenderValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQualificationValue
            // 
            this.lblQualificationValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualificationValue.Location = new System.Drawing.Point(44, 140);
            this.lblQualificationValue.Name = "lblQualificationValue";
            this.lblQualificationValue.Size = new System.Drawing.Size(192, 25);
            this.lblQualificationValue.TabIndex = 42;
            this.lblQualificationValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResidencyValue
            // 
            this.lblResidencyValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResidencyValue.Location = new System.Drawing.Point(44, 90);
            this.lblResidencyValue.Name = "lblResidencyValue";
            this.lblResidencyValue.Size = new System.Drawing.Size(192, 25);
            this.lblResidencyValue.TabIndex = 41;
            this.lblResidencyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBirthDateValue
            // 
            this.lblBirthDateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDateValue.Location = new System.Drawing.Point(44, 40);
            this.lblBirthDateValue.Name = "lblBirthDateValue";
            this.lblBirthDateValue.Size = new System.Drawing.Size(192, 25);
            this.lblBirthDateValue.TabIndex = 40;
            this.lblBirthDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorNameValue
            // 
            this.lblSupervisorNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupervisorNameValue.Location = new System.Drawing.Point(44, 0);
            this.lblSupervisorNameValue.Name = "lblSupervisorNameValue";
            this.lblSupervisorNameValue.Size = new System.Drawing.Size(192, 25);
            this.lblSupervisorNameValue.TabIndex = 39;
            this.lblSupervisorNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegistrationNum
            // 
            this.lblRegistrationNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegistrationNum.Location = new System.Drawing.Point(344, 290);
            this.lblRegistrationNum.Name = "lblRegistrationNum";
            this.lblRegistrationNum.Size = new System.Drawing.Size(121, 25);
            this.lblRegistrationNum.TabIndex = 38;
            this.lblRegistrationNum.Text = "رقم القيد:";
            this.lblRegistrationNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.Location = new System.Drawing.Point(344, 40);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(121, 25);
            this.lblBirthDate.TabIndex = 37;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssignment
            // 
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAssignment.Location = new System.Drawing.Point(344, 240);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(121, 25);
            this.lblAssignment.TabIndex = 36;
            this.lblAssignment.Text = "التكليف:";
            this.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(344, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(121, 25);
            this.lblGender.TabIndex = 35;
            this.lblGender.Text = "الجنس:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQualification.Location = new System.Drawing.Point(344, 140);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(121, 25);
            this.lblQualification.TabIndex = 34;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResidency
            // 
            this.lblResidency.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResidency.Location = new System.Drawing.Point(344, 90);
            this.lblResidency.Name = "lblResidency";
            this.lblResidency.Size = new System.Drawing.Size(121, 25);
            this.lblResidency.TabIndex = 33;
            this.lblResidency.Text = "الإقامة:";
            this.lblResidency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupervisorName.Location = new System.Drawing.Point(344, 0);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(121, 25);
            this.lblSupervisorName.TabIndex = 32;
            this.lblSupervisorName.Text = "اسم المشرف:";
            this.lblSupervisorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(228, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "إغلاق";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(372, 580);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 487);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(520, 80);
            this.pnlSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(35, 25);
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
            this.txtSearch.Location = new System.Drawing.Point(131, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(359, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(156, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "ابحث بالاسم أو القيد:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(44, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 47;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(344, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "رقم الهاتف :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(44, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 49;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(344, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "الرقم الوطني :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDeleteSupervisor_A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 652);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteSupervisor_A2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حذف بيانات مشرف";
            this.Load += new System.EventHandler(this.frmDeleteSupervisor_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRegistrationNum;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblResidency;
        private System.Windows.Forms.Label lblSupervisorName;
        private System.Windows.Forms.Label lblRegistrationNumValue;
        private System.Windows.Forms.Label lblAssignmentValue;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblQualificationValue;
        private System.Windows.Forms.Label lblResidencyValue;
        private System.Windows.Forms.Label lblBirthDateValue;
        private System.Windows.Forms.Label lblSupervisorNameValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
