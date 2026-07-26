namespace النظام_النهائي
{
    partial class frmAddCompetition
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dateTimePicker_end_time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtSponsor = new System.Windows.Forms.TextBox();
            this.lblSponsor = new System.Windows.Forms.Label();
            this.grpCommittee = new System.Windows.Forms.GroupBox();
            this.txtCommitteeMembers = new System.Windows.Forms.TextBox();
            this.lblCommitteeMembers = new System.Windows.Forms.Label();
            this.txtCommitteeName = new System.Windows.Forms.TextBox();
            this.lblCommitteeName = new System.Windows.Forms.Label();
            this.dtpCompetitionDate_start_time = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.grpCommittee.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dateTimePicker_end_time);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.grpCriteria);
            this.pnlMain.Controls.Add(this.cmbType);
            this.pnlMain.Controls.Add(this.lblType);
            this.pnlMain.Controls.Add(this.txtSponsor);
            this.pnlMain.Controls.Add(this.lblSponsor);
            this.pnlMain.Controls.Add(this.grpCommittee);
            this.pnlMain.Controls.Add(this.dtpCompetitionDate_start_time);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.txtLocation);
            this.pnlMain.Controls.Add(this.lblLocation);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 86);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.pnlMain.Size = new System.Drawing.Size(915, 728);
            this.pnlMain.TabIndex = 3;
            // 
            // dateTimePicker_end_time
            // 
            this.dateTimePicker_end_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_end_time.Location = new System.Drawing.Point(20, 126);
            this.dateTimePicker_end_time.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_end_time.Name = "dateTimePicker_end_time";
            this.dateTimePicker_end_time.Size = new System.Drawing.Size(256, 29);
            this.dateTimePicker_end_time.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "وقت  النتهاء المسابقة:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(27, 651);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 49);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(174, 651);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 49);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCriteria
            // 
            this.grpCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCriteria.Controls.Add(this.txtCriteria);
            this.grpCriteria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpCriteria.Location = new System.Drawing.Point(27, 412);
            this.grpCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Padding = new System.Windows.Forms.Padding(4);
            this.grpCriteria.Size = new System.Drawing.Size(861, 215);
            this.grpCriteria.TabIndex = 12;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "شروط ومعايير المسابقة";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCriteria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCriteria.Location = new System.Drawing.Point(4, 26);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCriteria.Multiline = true;
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCriteria.Size = new System.Drawing.Size(853, 185);
            this.txtCriteria.TabIndex = 0;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "محلية",
            "دولية"});
            this.cmbType.Location = new System.Drawing.Point(491, 353);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(256, 29);
            this.cmbType.TabIndex = 11;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(768, 357);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(107, 23);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "نوع المسابقة:";
            // 
            // txtSponsor
            // 
            this.txtSponsor.Location = new System.Drawing.Point(27, 353);
            this.txtSponsor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponsor.Name = "txtSponsor";
            this.txtSponsor.Size = new System.Drawing.Size(256, 29);
            this.txtSponsor.TabIndex = 9;
            // 
            // lblSponsor
            // 
            this.lblSponsor.AutoSize = true;
            this.lblSponsor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSponsor.Location = new System.Drawing.Point(303, 357);
            this.lblSponsor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSponsor.Name = "lblSponsor";
            this.lblSponsor.Size = new System.Drawing.Size(128, 23);
            this.lblSponsor.TabIndex = 8;
            this.lblSponsor.Text = "الراعي للمسابقة:";
            // 
            // grpCommittee
            // 
            this.grpCommittee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCommittee.Controls.Add(this.txtCommitteeMembers);
            this.grpCommittee.Controls.Add(this.lblCommitteeMembers);
            this.grpCommittee.Controls.Add(this.txtCommitteeName);
            this.grpCommittee.Controls.Add(this.lblCommitteeName);
            this.grpCommittee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpCommittee.Location = new System.Drawing.Point(27, 163);
            this.grpCommittee.Margin = new System.Windows.Forms.Padding(4);
            this.grpCommittee.Name = "grpCommittee";
            this.grpCommittee.Padding = new System.Windows.Forms.Padding(4);
            this.grpCommittee.Size = new System.Drawing.Size(861, 157);
            this.grpCommittee.TabIndex = 7;
            this.grpCommittee.TabStop = false;
            this.grpCommittee.Text = "لجنة الإشراف";
            // 
            // txtCommitteeMembers
            // 
            this.txtCommitteeMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommitteeMembers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCommitteeMembers.Location = new System.Drawing.Point(8, 97);
            this.txtCommitteeMembers.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommitteeMembers.Name = "txtCommitteeMembers";
            this.txtCommitteeMembers.Size = new System.Drawing.Size(691, 29);
            this.txtCommitteeMembers.TabIndex = 3;
            // 
            // lblCommitteeMembers
            // 
            this.lblCommitteeMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitteeMembers.AutoSize = true;
            this.lblCommitteeMembers.Location = new System.Drawing.Point(721, 100);
            this.lblCommitteeMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommitteeMembers.Name = "lblCommitteeMembers";
            this.lblCommitteeMembers.Size = new System.Drawing.Size(103, 23);
            this.lblCommitteeMembers.TabIndex = 2;
            this.lblCommitteeMembers.Text = "أعضاء اللجنة:";
            // 
            // txtCommitteeName
            // 
            this.txtCommitteeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommitteeName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCommitteeName.Location = new System.Drawing.Point(8, 47);
            this.txtCommitteeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommitteeName.Name = "txtCommitteeName";
            this.txtCommitteeName.Size = new System.Drawing.Size(691, 29);
            this.txtCommitteeName.TabIndex = 1;
            this.txtCommitteeName.TextChanged += new System.EventHandler(this.txtCommitteeName_TextChanged);
            // 
            // lblCommitteeName
            // 
            this.lblCommitteeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommitteeName.AutoSize = true;
            this.lblCommitteeName.Location = new System.Drawing.Point(734, 51);
            this.lblCommitteeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommitteeName.Name = "lblCommitteeName";
            this.lblCommitteeName.Size = new System.Drawing.Size(89, 23);
            this.lblCommitteeName.TabIndex = 0;
            this.lblCommitteeName.Text = "اسم اللجنة:";
            // 
            // dtpCompetitionDate_start_time
            // 
            this.dtpCompetitionDate_start_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCompetitionDate_start_time.Location = new System.Drawing.Point(458, 126);
            this.dtpCompetitionDate_start_time.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCompetitionDate_start_time.Name = "dtpCompetitionDate_start_time";
            this.dtpCompetitionDate_start_time.Size = new System.Drawing.Size(256, 29);
            this.dtpCompetitionDate_start_time.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(722, 132);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(153, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "وقت البدء المسابقة:";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(27, 73);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(720, 29);
            this.txtLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(755, 76);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(116, 23);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "مكان المسابقة:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(27, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(720, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(765, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم المسابقة:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(915, 86);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblTitle.Size = new System.Drawing.Size(915, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة مسابقة جديدة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAddCompetition
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(915, 814);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 851);
            this.Name = "frmAddCompetition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة مسابقة جديدة";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.grpCommittee.ResumeLayout(false);
            this.grpCommittee.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DateTimePicker dtpCompetitionDate_start_time;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpCommittee;
        private System.Windows.Forms.TextBox txtCommitteeName;
        private System.Windows.Forms.Label lblCommitteeName;
        private System.Windows.Forms.TextBox txtCommitteeMembers;
        private System.Windows.Forms.Label lblCommitteeMembers;
        private System.Windows.Forms.TextBox txtSponsor;
        private System.Windows.Forms.Label lblSponsor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_time;
        private System.Windows.Forms.Label label1;
    }
}
