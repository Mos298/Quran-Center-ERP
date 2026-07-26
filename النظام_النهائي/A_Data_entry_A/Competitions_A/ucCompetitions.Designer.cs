namespace النظام_النهائي
{
    partial class ucCompetitions
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpCompetitionInfo = new System.Windows.Forms.GroupBox();
            this.txtSupervisorName = new System.Windows.Forms.TextBox();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.dtpCompetitionTime = new System.Windows.Forms.DateTimePicker();
            this.lblCompetitionTime = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.grpStudentResults = new System.Windows.Forms.GroupBox();
            this.dgvStudentResults = new System.Windows.Forms.DataGridView();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCenterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCompetitionInfo.SuspendLayout();
            this.grpStudentResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentResults)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCompetitionInfo
            // 
            this.grpCompetitionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCompetitionInfo.Controls.Add(this.txtSupervisorName);
            this.grpCompetitionInfo.Controls.Add(this.lblSupervisorName);
            this.grpCompetitionInfo.Controls.Add(this.dtpCompetitionTime);
            this.grpCompetitionInfo.Controls.Add(this.lblCompetitionTime);
            this.grpCompetitionInfo.Controls.Add(this.txtLocation);
            this.grpCompetitionInfo.Controls.Add(this.lblLocation);
            this.grpCompetitionInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCompetitionInfo.Location = new System.Drawing.Point(20, 80);
            this.grpCompetitionInfo.Name = "grpCompetitionInfo";
            this.grpCompetitionInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCompetitionInfo.Size = new System.Drawing.Size(760, 130);
            this.grpCompetitionInfo.TabIndex = 0;
            this.grpCompetitionInfo.TabStop = false;
            this.grpCompetitionInfo.Text = "معلومات المسابقة العامة";
            // 
            // txtSupervisorName
            // 
            this.txtSupervisorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupervisorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupervisorName.Location = new System.Drawing.Point(20, 85);
            this.txtSupervisorName.Name = "txtSupervisorName";
            this.txtSupervisorName.Size = new System.Drawing.Size(600, 27);
            this.txtSupervisorName.TabIndex = 5;
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisorName.AutoSize = true;
            this.lblSupervisorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSupervisorName.Location = new System.Drawing.Point(630, 90);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(111, 20);
            this.lblSupervisorName.TabIndex = 4;
            this.lblSupervisorName.Text = "لجنة الإشراف:";
            // 
            // dtpCompetitionTime
            // 
            this.dtpCompetitionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCompetitionTime.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.dtpCompetitionTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCompetitionTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCompetitionTime.Location = new System.Drawing.Point(20, 40);
            this.dtpCompetitionTime.Name = "dtpCompetitionTime";
            this.dtpCompetitionTime.Size = new System.Drawing.Size(250, 27);
            this.dtpCompetitionTime.TabIndex = 3;
            // 
            // lblCompetitionTime
            // 
            this.lblCompetitionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompetitionTime.AutoSize = true;
            this.lblCompetitionTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompetitionTime.Location = new System.Drawing.Point(280, 45);
            this.lblCompetitionTime.Name = "lblCompetitionTime";
            this.lblCompetitionTime.Size = new System.Drawing.Size(91, 20);
            this.lblCompetitionTime.TabIndex = 2;
            this.lblCompetitionTime.Text = "وقت المسابقة:";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocation.Location = new System.Drawing.Point(380, 40);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(240, 27);
            this.txtLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocation.Location = new System.Drawing.Point(630, 45);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(110, 20);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "مكان المسابقة:";
            // 
            // grpStudentResults
            // 
            this.grpStudentResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStudentResults.Controls.Add(this.dgvStudentResults);
            this.grpStudentResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudentResults.Location = new System.Drawing.Point(20, 230);
            this.grpStudentResults.Name = "grpStudentResults";
            this.grpStudentResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpStudentResults.Size = new System.Drawing.Size(760, 280);
            this.grpStudentResults.TabIndex = 1;
            this.grpStudentResults.TabStop = false;
            this.grpStudentResults.Text = "نتائج الطلاب المشاركين";
            // 
            // dgvStudentResults
            // 
            this.dgvStudentResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentName,
            this.colTeacherName,
            this.colCenterName,
            this.colScore,
            this.colRank});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentResults.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvStudentResults.Location = new System.Drawing.Point(3, 23);
            this.dgvStudentResults.Name = "dgvStudentResults";
            this.dgvStudentResults.RowHeadersWidth = 51;
            this.dgvStudentResults.RowTemplate.Height = 24;
            this.dgvStudentResults.Size = new System.Drawing.Size(754, 254);
            this.dgvStudentResults.TabIndex = 0;
            // 
            // colStudentName
            // 
            this.colStudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentName.HeaderText = "اسم الطالب";
            this.colStudentName.MinimumWidth = 6;
            this.colStudentName.Name = "colStudentName";
            // 
            // colTeacherName
            // 
            this.colTeacherName.HeaderText = "اسم المحفظ";
            this.colTeacherName.MinimumWidth = 6;
            this.colTeacherName.Name = "colTeacherName";
            this.colTeacherName.Width = 150;
            // 
            // colCenterName
            // 
            this.colCenterName.HeaderText = "اسم المركز";
            this.colCenterName.MinimumWidth = 6;
            this.colCenterName.Name = "colCenterName";
            this.colCenterName.Width = 150;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "الدرجة";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            this.colScore.Width = 80;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "الترتيب";
            this.colRank.MinimumWidth = 6;
            this.colRank.Name = "colRank";
            this.colRank.Width = 80;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ بيانات المسابقة";
            this.btnSave.UseVisualStyleBackColor = false;
          //  this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(800, 60);
            this.pnlTopBar.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(630, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(150, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة المسابقات";
            // 
            // ucCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpStudentResults);
            this.Controls.Add(this.grpCompetitionInfo);
            this.Name = "ucCompetitions";
            this.Size = new System.Drawing.Size(800, 600);
            this.grpCompetitionInfo.ResumeLayout(false);
            this.grpCompetitionInfo.PerformLayout();
            this.grpStudentResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentResults)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompetitionInfo;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCompetitionTime;
        private System.Windows.Forms.DateTimePicker dtpCompetitionTime;
        private System.Windows.Forms.Label lblSupervisorName;
        private System.Windows.Forms.TextBox txtSupervisorName;
        private System.Windows.Forms.GroupBox grpStudentResults;
        private System.Windows.Forms.DataGridView dgvStudentResults;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCenterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
    }
}
