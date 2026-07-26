namespace النظام_النهائي.A_Data_entry_A.Competitions_A
{
    partial class frmTeacherDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cmbCompetitions = new System.Windows.Forms.ComboBox();
            this.lblStaticComp = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblStaticTeacher = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.cmbCompetitions);
            this.pnlTop.Controls.Add(this.lblStaticComp);
            this.pnlTop.Controls.Add(this.lblTeacherName);
            this.pnlTop.Controls.Add(this.lblStaticTeacher);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 2;
            // 
            // cmbCompetitions
            // 
            this.cmbCompetitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompetitions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCompetitions.Location = new System.Drawing.Point(350, 55);
            this.cmbCompetitions.Name = "cmbCompetitions";
            this.cmbCompetitions.Size = new System.Drawing.Size(300, 31);
            this.cmbCompetitions.TabIndex = 0;
            this.cmbCompetitions.SelectedIndexChanged += new System.EventHandler(this.cmbCompetitions_SelectedIndexChanged);
            // 
            // lblStaticComp
            // 
            this.lblStaticComp.AutoSize = true;
            this.lblStaticComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaticComp.Location = new System.Drawing.Point(650, 60);
            this.lblStaticComp.Name = "lblStaticComp";
            this.lblStaticComp.Size = new System.Drawing.Size(77, 23);
            this.lblStaticComp.TabIndex = 1;
            this.lblStaticComp.Text = "المسابقة:";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTeacherName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTeacherName.Location = new System.Drawing.Point(400, 20);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(250, 25);
            this.lblTeacherName.TabIndex = 2;
            this.lblTeacherName.Text = "---";
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStaticTeacher
            // 
            this.lblStaticTeacher.AutoSize = true;
            this.lblStaticTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaticTeacher.Location = new System.Drawing.Point(650, 20);
            this.lblStaticTeacher.Name = "lblStaticTeacher";
            this.lblStaticTeacher.Size = new System.Drawing.Size(88, 23);
            this.lblStaticTeacher.TabIndex = 3;
            this.lblStaticTeacher.Text = "اسم الشيخ:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(380, 15);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(180, 40);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "نقل للمسابقة المحددة";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.btnTransfer);
            this.pnlBottom.Controls.Add(this.btnDelete);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 430);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 70);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(190, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "حذف الطالب المحدد";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ التغييرات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.ContextMenuStripChanged += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvStudents);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 100);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(800, 330);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeight = 29;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.Location = new System.Drawing.Point(10, 10);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.Size = new System.Drawing.Size(780, 310);
            this.dgvStudents.TabIndex = 1;
            // 
            // frmTeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmTeacherDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاصيل طلاب الحلقة";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlGrid;

        // الأدوات العامة التي سنستخدمها في الكود (public لتسهيل الوصول)
        public System.Windows.Forms.Label lblTeacherName;
        public System.Windows.Forms.ComboBox cmbCompetitions;
        public System.Windows.Forms.DataGridView dgvStudents;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lblStaticTeacher;
        private System.Windows.Forms.Label lblStaticComp;
        public System.Windows.Forms.Button btnTransfer;
    }
}