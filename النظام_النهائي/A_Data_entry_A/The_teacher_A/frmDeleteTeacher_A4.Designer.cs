namespace النظام_النهائي
{
    partial class frmDeleteTeacher_A4
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAssignmentValue = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblQualificationValue = new System.Windows.Forms.Label();
            this.lblResidencyValue = new System.Windows.Forms.Label();
            this.lblBirthDateValue = new System.Windows.Forms.Label();
            this.lblTeacherNameValue = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblResidency = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlSearch.SuspendLayout();
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
            this.pnlTopBar.Size = new System.Drawing.Size(535, 60);
            this.pnlTopBar.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(535, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "حذف بيانات محفّظ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 60);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(535, 80);
            this.pnlSearch.TabIndex = 14;
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
            this.btnSearch.Text = "عرض";
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.lblAssignmentValue);
            this.pnlMain.Controls.Add(this.lblGenderValue);
            this.pnlMain.Controls.Add(this.lblQualificationValue);
            this.pnlMain.Controls.Add(this.lblResidencyValue);
            this.pnlMain.Controls.Add(this.lblBirthDateValue);
            this.pnlMain.Controls.Add(this.lblTeacherNameValue);
            this.pnlMain.Controls.Add(this.lblBirthDate);
            this.pnlMain.Controls.Add(this.lblAssignment);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.lblResidency);
            this.pnlMain.Controls.Add(this.lblTeacherName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 140);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(535, 473);
            this.pnlMain.TabIndex = 15;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(19, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 27;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(331, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "رقم الوطني : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(21, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 25;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(331, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "رقم الهاتف:  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAssignmentValue
            // 
            this.lblAssignmentValue.BackColor = System.Drawing.Color.Silver;
            this.lblAssignmentValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssignmentValue.Location = new System.Drawing.Point(23, 335);
            this.lblAssignmentValue.Name = "lblAssignmentValue";
            this.lblAssignmentValue.Size = new System.Drawing.Size(206, 25);
            this.lblAssignmentValue.TabIndex = 22;
            this.lblAssignmentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.BackColor = System.Drawing.Color.Silver;
            this.lblGenderValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGenderValue.Location = new System.Drawing.Point(21, 285);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(210, 25);
            this.lblGenderValue.TabIndex = 21;
            this.lblGenderValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQualificationValue
            // 
            this.lblQualificationValue.BackColor = System.Drawing.Color.Silver;
            this.lblQualificationValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualificationValue.Location = new System.Drawing.Point(21, 235);
            this.lblQualificationValue.Name = "lblQualificationValue";
            this.lblQualificationValue.Size = new System.Drawing.Size(210, 25);
            this.lblQualificationValue.TabIndex = 20;
            this.lblQualificationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResidencyValue
            // 
            this.lblResidencyValue.BackColor = System.Drawing.Color.Silver;
            this.lblResidencyValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResidencyValue.Location = new System.Drawing.Point(21, 185);
            this.lblResidencyValue.Name = "lblResidencyValue";
            this.lblResidencyValue.Size = new System.Drawing.Size(210, 25);
            this.lblResidencyValue.TabIndex = 19;
            this.lblResidencyValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthDateValue
            // 
            this.lblBirthDateValue.BackColor = System.Drawing.Color.Silver;
            this.lblBirthDateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBirthDateValue.Location = new System.Drawing.Point(21, 135);
            this.lblBirthDateValue.Name = "lblBirthDateValue";
            this.lblBirthDateValue.Size = new System.Drawing.Size(210, 25);
            this.lblBirthDateValue.TabIndex = 18;
            this.lblBirthDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeacherNameValue
            // 
            this.lblTeacherNameValue.BackColor = System.Drawing.Color.Silver;
            this.lblTeacherNameValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTeacherNameValue.Location = new System.Drawing.Point(21, 35);
            this.lblTeacherNameValue.Name = "lblTeacherNameValue";
            this.lblTeacherNameValue.Size = new System.Drawing.Size(210, 25);
            this.lblTeacherNameValue.TabIndex = 17;
            this.lblTeacherNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.Location = new System.Drawing.Point(340, 132);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(192, 25);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignment
            // 
            this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAssignment.Location = new System.Drawing.Point(340, 332);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(192, 25);
            this.lblAssignment.TabIndex = 11;
            this.lblAssignment.Text = "التكليف:";
            this.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(340, 282);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(192, 25);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "الجنس:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQualification.Location = new System.Drawing.Point(340, 232);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(192, 25);
            this.lblQualification.TabIndex = 7;
            this.lblQualification.Text = "المؤهل:";
            this.lblQualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResidency
            // 
            this.lblResidency.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResidency.Location = new System.Drawing.Point(340, 182);
            this.lblResidency.Name = "lblResidency";
            this.lblResidency.Size = new System.Drawing.Size(192, 25);
            this.lblResidency.TabIndex = 5;
            this.lblResidency.Text = "الإقامة:";
            this.lblResidency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTeacherName.Location = new System.Drawing.Point(340, 35);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(192, 25);
            this.lblTeacherName.TabIndex = 3;
            this.lblTeacherName.Text = "اسم المحفّظ:";
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(277, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 45);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(405, 619);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 45);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "حذف المحفّظ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 39;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(331, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = " المراكز:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDeleteTeacher_A4
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(535, 678);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteTeacher_A4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حذف بيانات محفّظ";
            this.Load += new System.EventHandler(this.frmDeleteTeacher_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblResidency;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAssignmentValue;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblQualificationValue;
        private System.Windows.Forms.Label lblResidencyValue;
        private System.Windows.Forms.Label lblBirthDateValue;
        private System.Windows.Forms.Label lblTeacherNameValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
