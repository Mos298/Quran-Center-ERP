namespace النظام_النهائي
{

    partial class edit_student_D
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.groupNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnDeleteNotes = new System.Windows.Forms.Button();
            this.groupMastery = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.txtCenterName = new System.Windows.Forms.TextBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.lblWorkTime = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.btnDeleteMastery = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSurah = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.groupNotes.SuspendLayout();
            this.groupMastery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.btnSaveChanges);
            this.mainPanel.Controls.Add(this.groupNotes);
            this.mainPanel.Controls.Add(this.groupMastery);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(933, 554);
            this.mainPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(887, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(391, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "بيانات التعديل";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(379, 468);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 49);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "ارسال طلب التعديل ";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // groupNotes
            // 
            this.groupNotes.Controls.Add(this.txtNotes);
            this.groupNotes.Controls.Add(this.btnDeleteNotes);
            this.groupNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupNotes.ForeColor = System.Drawing.Color.White;
            this.groupNotes.Location = new System.Drawing.Point(47, 279);
            this.groupNotes.Margin = new System.Windows.Forms.Padding(4);
            this.groupNotes.Name = "groupNotes";
            this.groupNotes.Padding = new System.Windows.Forms.Padding(4);
            this.groupNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupNotes.Size = new System.Drawing.Size(840, 160);
            this.groupNotes.TabIndex = 1;
            this.groupNotes.TabStop = false;
            this.groupNotes.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(181, 30);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(641, 98);
            this.txtNotes.TabIndex = 1;
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDeleteNotes.FlatAppearance.BorderSize = 0;
            this.btnDeleteNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotes.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotes.Location = new System.Drawing.Point(23, 25);
            this.btnDeleteNotes.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(140, 37);
            this.btnDeleteNotes.TabIndex = 0;
            this.btnDeleteNotes.Text = "حذف البيانات";
            this.btnDeleteNotes.UseVisualStyleBackColor = false;
            // 
            // groupMastery
            // 
            this.groupMastery.Controls.Add(this.textBox4);
            this.groupMastery.Controls.Add(this.label2);
            this.groupMastery.Controls.Add(this.textBox3);
            this.groupMastery.Controls.Add(this.label1);
            this.groupMastery.Controls.Add(this.textBox2);
            this.groupMastery.Controls.Add(this.textBox1);
            this.groupMastery.Controls.Add(this.comboBox2);
            this.groupMastery.Controls.Add(this.lblCity);
            this.groupMastery.Controls.Add(this.cmbCity);
            this.groupMastery.Controls.Add(this.lblCenterName);
            this.groupMastery.Controls.Add(this.txtCenterName);
            this.groupMastery.Controls.Add(this.lblSurah);
            this.groupMastery.Controls.Add(this.lblTeacherName);
            this.groupMastery.Controls.Add(this.txtTeacherName);
            this.groupMastery.Controls.Add(this.lblWorkTime);
            this.groupMastery.Controls.Add(this.lblStudentCount);
            this.groupMastery.Controls.Add(this.btnDeleteMastery);
            this.groupMastery.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupMastery.ForeColor = System.Drawing.Color.White;
            this.groupMastery.Location = new System.Drawing.Point(47, 66);
            this.groupMastery.Margin = new System.Windows.Forms.Padding(4);
            this.groupMastery.Name = "groupMastery";
            this.groupMastery.Padding = new System.Windows.Forms.Padding(4);
            this.groupMastery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupMastery.Size = new System.Drawing.Size(840, 205);
            this.groupMastery.TabIndex = 0;
            this.groupMastery.TabStop = false;
            this.groupMastery.Text = "إتقان الجماعي";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(569, 26);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 23);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "الاقامة";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(523, 55);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(131, 29);
            this.cmbCity.TabIndex = 1;
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.Location = new System.Drawing.Point(741, 31);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(98, 23);
            this.lblCenterName.TabIndex = 2;
            this.lblCenterName.Text = "اسم الطالب ";
            // 
            // txtCenterName
            // 
            this.txtCenterName.Location = new System.Drawing.Point(662, 55);
            this.txtCenterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCenterName.Name = "txtCenterName";
            this.txtCenterName.Size = new System.Drawing.Size(166, 29);
            this.txtCenterName.TabIndex = 3;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(361, 108);
            this.lblTeacherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(94, 23);
            this.lblTeacherName.TabIndex = 6;
            this.lblTeacherName.Text = "تاريخ الميلاد";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(310, 135);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(168, 29);
            this.txtTeacherName.TabIndex = 7;
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.Location = new System.Drawing.Point(256, 25);
            this.lblWorkTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(113, 23);
            this.lblWorkTime.TabIndex = 8;
            this.lblWorkTime.Text = "اسم ولي الامر ";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Location = new System.Drawing.Point(430, 25);
            this.lblStudentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(61, 23);
            this.lblStudentCount.TabIndex = 10;
            this.lblStudentCount.Text = "الجنس ";
            // 
            // btnDeleteMastery
            // 
            this.btnDeleteMastery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDeleteMastery.FlatAppearance.BorderSize = 0;
            this.btnDeleteMastery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMastery.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMastery.Location = new System.Drawing.Point(8, 50);
            this.btnDeleteMastery.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMastery.Name = "btnDeleteMastery";
            this.btnDeleteMastery.Size = new System.Drawing.Size(140, 37);
            this.btnDeleteMastery.TabIndex = 0;
            this.btnDeleteMastery.Text = "حذف البيانات";
            this.btnDeleteMastery.UseVisualStyleBackColor = false;
            this.btnDeleteMastery.Click += new System.EventHandler(this.btnDeleteMastery_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(385, 55);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 29);
            this.comboBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 29);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "الجنسية ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(662, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 29);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "رقم الهاتف ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(486, 135);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 29);
            this.textBox3.TabIndex = 20;
            // 
            // lblSurah
            // 
            this.lblSurah.AutoSize = true;
            this.lblSurah.Location = new System.Drawing.Point(140, 85);
            this.lblSurah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurah.Name = "lblSurah";
            this.lblSurah.Size = new System.Drawing.Size(133, 46);
            this.lblSurah.TabIndex = 4;
            this.lblSurah.Text = "الرقم الوطني\r\n/رقم جواز السفر  ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 135);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 29);
            this.textBox4.TabIndex = 21;
            // 
            // edit_student_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "edit_student_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDataForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupNotes.ResumeLayout(false);
            this.groupNotes.PerformLayout();
            this.groupMastery.ResumeLayout(false);
            this.groupMastery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // تعريف المتغيرات لكل عنصر في الواجهة
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox groupNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnDeleteNotes;
        private System.Windows.Forms.GroupBox groupMastery;
        private System.Windows.Forms.Button btnDeleteMastery;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.TextBox txtCenterName;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label lblWorkTime;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSurah;
    }
}