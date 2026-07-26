namespace النظام_النهائي
{

    partial class EditDataForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.txtCenterName = new System.Windows.Forms.TextBox();
            this.lblSurah = new System.Windows.Forms.Label();
            this.cmbSurah = new System.Windows.Forms.ComboBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.lblWorkTime = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
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
            this.mainPanel.SuspendLayout();
            this.groupNotes.SuspendLayout();
            this.groupMastery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.btnSaveChanges);
            this.mainPanel.Controls.Add(this.groupNotes);
            this.mainPanel.Controls.Add(this.groupMastery);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(933, 554);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
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
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(391, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "بيانات التعديل";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(379, 468);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 49);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "حفظ التغييرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // groupNotes
            // 
            this.groupNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupNotes.Controls.Add(this.txtNotes);
            this.groupNotes.Controls.Add(this.btnDeleteNotes);
            this.groupNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupNotes.ForeColor = System.Drawing.Color.Black;
            this.groupNotes.Location = new System.Drawing.Point(47, 279);
            this.groupNotes.Margin = new System.Windows.Forms.Padding(4);
            this.groupNotes.Name = "groupNotes";
            this.groupNotes.Padding = new System.Windows.Forms.Padding(4);
            this.groupNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupNotes.Size = new System.Drawing.Size(840, 160);
            this.groupNotes.TabIndex = 1;
            this.groupNotes.TabStop = false;
            this.groupNotes.Text = "ملاحظات";
            this.groupNotes.Enter += new System.EventHandler(this.groupNotes_Enter);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(181, 30);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(641, 98);
            this.txtNotes.TabIndex = 1;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
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
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // groupMastery
            // 
            this.groupMastery.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupMastery.Controls.Add(this.comboBox1);
            this.groupMastery.Controls.Add(this.numericUpDown2);
            this.groupMastery.Controls.Add(this.lblCity);
            this.groupMastery.Controls.Add(this.cmbCity);
            this.groupMastery.Controls.Add(this.lblCenterName);
            this.groupMastery.Controls.Add(this.txtCenterName);
            this.groupMastery.Controls.Add(this.lblSurah);
            this.groupMastery.Controls.Add(this.cmbSurah);
            this.groupMastery.Controls.Add(this.lblTeacherName);
            this.groupMastery.Controls.Add(this.txtTeacherName);
            this.groupMastery.Controls.Add(this.lblWorkTime);
            this.groupMastery.Controls.Add(this.lblStudentCount);
            this.groupMastery.Controls.Add(this.txtStudentCount);
            this.groupMastery.Controls.Add(this.btnDeleteMastery);
            this.groupMastery.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupMastery.ForeColor = System.Drawing.Color.Black;
            this.groupMastery.Location = new System.Drawing.Point(47, 86);
            this.groupMastery.Margin = new System.Windows.Forms.Padding(4);
            this.groupMastery.Name = "groupMastery";
            this.groupMastery.Padding = new System.Windows.Forms.Padding(4);
            this.groupMastery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupMastery.Size = new System.Drawing.Size(840, 185);
            this.groupMastery.TabIndex = 0;
            this.groupMastery.TabStop = false;
            this.groupMastery.Text = "إتقان الجماعي";
            this.groupMastery.Enter += new System.EventHandler(this.groupMastery_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(531, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 29);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(611, 124);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 29);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(397, 31);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(92, 23);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "اختر المدينة";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(344, 55);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(168, 29);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.Location = new System.Drawing.Point(741, 31);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(85, 23);
            this.lblCenterName.TabIndex = 2;
            this.lblCenterName.Text = "اسم المركز";
            this.lblCenterName.Click += new System.EventHandler(this.lblCenterName_Click);
            // 
            // txtCenterName
            // 
            this.txtCenterName.Location = new System.Drawing.Point(531, 55);
            this.txtCenterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCenterName.Name = "txtCenterName";
            this.txtCenterName.Size = new System.Drawing.Size(297, 29);
            this.txtCenterName.TabIndex = 3;
            this.txtCenterName.TextChanged += new System.EventHandler(this.txtCenterName_TextChanged);
            // 
            // lblSurah
            // 
            this.lblSurah.AutoSize = true;
            this.lblSurah.Location = new System.Drawing.Point(210, 98);
            this.lblSurah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurah.Name = "lblSurah";
            this.lblSurah.Size = new System.Drawing.Size(80, 23);
            this.lblSurah.TabIndex = 4;
            this.lblSurah.Text = "اختر سورة";
            this.lblSurah.Click += new System.EventHandler(this.lblSurah_Click);
            // 
            // cmbSurah
            // 
            this.cmbSurah.FormattingEnabled = true;
            this.cmbSurah.Location = new System.Drawing.Point(181, 123);
            this.cmbSurah.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSurah.Name = "cmbSurah";
            this.cmbSurah.Size = new System.Drawing.Size(140, 29);
            this.cmbSurah.TabIndex = 5;
            this.cmbSurah.SelectedIndexChanged += new System.EventHandler(this.cmbSurah_SelectedIndexChanged);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(397, 98);
            this.lblTeacherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(96, 23);
            this.lblTeacherName.TabIndex = 6;
            this.lblTeacherName.Text = "اسم المحفظ";
            this.lblTeacherName.Click += new System.EventHandler(this.lblTeacherName_Click);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(344, 123);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(168, 29);
            this.txtTeacherName.TabIndex = 7;
            this.txtTeacherName.TextChanged += new System.EventHandler(this.txtTeacherName_TextChanged);
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.Location = new System.Drawing.Point(583, 98);
            this.lblWorkTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(94, 23);
            this.lblWorkTime.TabIndex = 8;
            this.lblWorkTime.Text = "موعد العمل";
            this.lblWorkTime.Click += new System.EventHandler(this.lblWorkTime_Click);
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Location = new System.Drawing.Point(741, 98);
            this.lblStudentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(93, 23);
            this.lblStudentCount.TabIndex = 10;
            this.lblStudentCount.Text = "عدد الطلاب";
            this.lblStudentCount.Click += new System.EventHandler(this.lblStudentCount_Click);
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(688, 123);
            this.txtStudentCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.Size = new System.Drawing.Size(139, 29);
            this.txtStudentCount.TabIndex = 11;
            this.txtStudentCount.TextChanged += new System.EventHandler(this.txtStudentCount_TextChanged);
            // 
            // btnDeleteMastery
            // 
            this.btnDeleteMastery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDeleteMastery.FlatAppearance.BorderSize = 0;
            this.btnDeleteMastery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMastery.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMastery.Location = new System.Drawing.Point(23, 52);
            this.btnDeleteMastery.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMastery.Name = "btnDeleteMastery";
            this.btnDeleteMastery.Size = new System.Drawing.Size(140, 37);
            this.btnDeleteMastery.TabIndex = 0;
            this.btnDeleteMastery.Text = "حذف البيانات";
            this.btnDeleteMastery.UseVisualStyleBackColor = false;
            this.btnDeleteMastery.Click += new System.EventHandler(this.btnDeleteMastery_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // fontDialog2
            // 
            this.fontDialog2.Apply += new System.EventHandler(this.fontDialog2_Apply);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDataForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupNotes.ResumeLayout(false);
            this.groupNotes.PerformLayout();
            this.groupMastery.ResumeLayout(false);
            this.groupMastery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.Label lblSurah;
        private System.Windows.Forms.ComboBox cmbSurah;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label lblWorkTime;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.TextBox txtStudentCount;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}