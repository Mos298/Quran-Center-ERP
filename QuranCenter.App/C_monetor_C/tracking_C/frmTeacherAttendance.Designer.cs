namespace النظام_النهائي.C_monetor_C.tracking_C
{
    partial class frmTeacherAttendance
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCenters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAttendance = new System.Windows.Forms.GroupBox();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbExcused = new System.Windows.Forms.RadioButton();
            this.rbAbsent = new System.Windows.Forms.RadioButton();
            this.rbLate = new System.Windows.Forms.RadioButton();
            this.rbPresent = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.cmbTeachers);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.cmbCenters);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(915, 98);
            this.pnlHeader.TabIndex = 1;
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeachers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(28, 31);
            this.cmbTeachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTeachers.Size = new System.Drawing.Size(291, 36);
            this.cmbTeachers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "اختر المحفِّظ:";
            // 
            // cmbCenters
            // 
            this.cmbCenters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenters.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCenters.FormattingEnabled = true;
            this.cmbCenters.Location = new System.Drawing.Point(467, 31);
            this.cmbCenters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCenters.Name = "cmbCenters";
            this.cmbCenters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCenters.Size = new System.Drawing.Size(291, 36);
            this.cmbCenters.TabIndex = 1;
            this.cmbCenters.SelectedIndexChanged += new System.EventHandler(this.cmbCenters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختر المركز:";
            // 
            // grpAttendance
            // 
            this.grpAttendance.Controls.Add(this.dtpVisitDate);
            this.grpAttendance.Controls.Add(this.label4);
            this.grpAttendance.Controls.Add(this.rbExcused);
            this.grpAttendance.Controls.Add(this.rbAbsent);
            this.grpAttendance.Controls.Add(this.rbLate);
            this.grpAttendance.Controls.Add(this.rbPresent);
            this.grpAttendance.Controls.Add(this.label3);
            this.grpAttendance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpAttendance.Location = new System.Drawing.Point(14, 122);
            this.grpAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAttendance.Name = "grpAttendance";
            this.grpAttendance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpAttendance.Size = new System.Drawing.Size(887, 197);
            this.grpAttendance.TabIndex = 2;
            this.grpAttendance.TabStop = false;
            this.grpAttendance.Text = "تسجيل الحضور";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(492, 126);
            this.dtpVisitDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(231, 32);
            this.dtpVisitDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ الزيارة:";
            // 
            // rbExcused
            // 
            this.rbExcused.AutoSize = true;
            this.rbExcused.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbExcused.Location = new System.Drawing.Point(231, 55);
            this.rbExcused.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbExcused.Name = "rbExcused";
            this.rbExcused.Size = new System.Drawing.Size(61, 29);
            this.rbExcused.TabIndex = 5;
            this.rbExcused.TabStop = true;
            this.rbExcused.Text = "إذن";
            this.rbExcused.UseVisualStyleBackColor = true;
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbAbsent.Location = new System.Drawing.Point(344, 55);
            this.rbAbsent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(72, 29);
            this.rbAbsent.TabIndex = 4;
            this.rbAbsent.TabStop = true;
            this.rbAbsent.Text = "غياب";
            this.rbAbsent.UseVisualStyleBackColor = true;
            // 
            // rbLate
            // 
            this.rbLate.AutoSize = true;
            this.rbLate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbLate.Location = new System.Drawing.Point(466, 55);
            this.rbLate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLate.Name = "rbLate";
            this.rbLate.Size = new System.Drawing.Size(69, 29);
            this.rbLate.TabIndex = 3;
            this.rbLate.TabStop = true;
            this.rbLate.Text = "تأخير";
            this.rbLate.UseVisualStyleBackColor = true;
            // 
            // rbPresent
            // 
            this.rbPresent.AutoSize = true;
            this.rbPresent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rbPresent.Location = new System.Drawing.Point(590, 55);
            this.rbPresent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPresent.Name = "rbPresent";
            this.rbPresent.Size = new System.Drawing.Size(81, 29);
            this.rbPresent.TabIndex = 2;
            this.rbPresent.TabStop = true;
            this.rbPresent.Text = "حضور";
            this.rbPresent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "حالة حضور المحفِّظ:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(14, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(887, 74);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 432);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAttendance);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeacherAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "متابعة الحضور والغياب";
            this.Load += new System.EventHandler(this.frmTeacherAttendance_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpAttendance.ResumeLayout(false);
            this.grpAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCenters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAttendance;
        private System.Windows.Forms.RadioButton rbPresent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbExcused;
        private System.Windows.Forms.RadioButton rbAbsent;
        private System.Windows.Forms.RadioButton rbLate;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}