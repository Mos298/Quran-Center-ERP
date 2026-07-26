namespace النظام_النهائي
{
    partial class frmEditCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCompetition));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dateTimePicker_end_time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCompetitionDate_start_time = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.grpCommittee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Name = "pnlHeader";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtId);
            this.pnlMain.Controls.Add(this.lblId);
            this.pnlMain.Controls.Add(this.dateTimePicker_end_time);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dtpCompetitionDate_start_time);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.grpCriteria);
            this.pnlMain.Controls.Add(this.cmbType);
            this.pnlMain.Controls.Add(this.lblType);
            this.pnlMain.Controls.Add(this.txtSponsor);
            this.pnlMain.Controls.Add(this.lblSponsor);
            this.pnlMain.Controls.Add(this.grpCommittee);
            this.pnlMain.Controls.Add(this.txtLocation);
            this.pnlMain.Controls.Add(this.lblLocation);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Name = "pnlMain";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.Name = "lblId";
            // 
            // dateTimePicker_end_time
            // 
            resources.ApplyResources(this.dateTimePicker_end_time, "dateTimePicker_end_time");
            this.dateTimePicker_end_time.Name = "dateTimePicker_end_time";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dtpCompetitionDate_start_time
            // 
            resources.ApplyResources(this.dtpCompetitionDate_start_time, "dtpCompetitionDate_start_time");
            this.dtpCompetitionDate_start_time.Name = "dtpCompetitionDate_start_time";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCriteria
            // 
            resources.ApplyResources(this.grpCriteria, "grpCriteria");
            this.grpCriteria.Controls.Add(this.txtCriteria);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.TabStop = false;
            // 
            // txtCriteria
            // 
            resources.ApplyResources(this.txtCriteria, "txtCriteria");
            this.txtCriteria.Name = "txtCriteria";
            // 
            // cmbType
            // 
            resources.ApplyResources(this.cmbType, "cmbType");
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            resources.GetString("cmbType.Items"),
            resources.GetString("cmbType.Items1")});
            this.cmbType.Name = "cmbType";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // txtSponsor
            // 
            resources.ApplyResources(this.txtSponsor, "txtSponsor");
            this.txtSponsor.Name = "txtSponsor";
            // 
            // lblSponsor
            // 
            resources.ApplyResources(this.lblSponsor, "lblSponsor");
            this.lblSponsor.Name = "lblSponsor";
            // 
            // grpCommittee
            // 
            resources.ApplyResources(this.grpCommittee, "grpCommittee");
            this.grpCommittee.Controls.Add(this.txtCommitteeMembers);
            this.grpCommittee.Controls.Add(this.lblCommitteeMembers);
            this.grpCommittee.Controls.Add(this.txtCommitteeName);
            this.grpCommittee.Controls.Add(this.lblCommitteeName);
            this.grpCommittee.Name = "grpCommittee";
            this.grpCommittee.TabStop = false;
            // 
            // txtCommitteeMembers
            // 
            resources.ApplyResources(this.txtCommitteeMembers, "txtCommitteeMembers");
            this.txtCommitteeMembers.Name = "txtCommitteeMembers";
            // 
            // lblCommitteeMembers
            // 
            resources.ApplyResources(this.lblCommitteeMembers, "lblCommitteeMembers");
            this.lblCommitteeMembers.Name = "lblCommitteeMembers";
            // 
            // txtCommitteeName
            // 
            resources.ApplyResources(this.txtCommitteeName, "txtCommitteeName");
            this.txtCommitteeName.Name = "txtCommitteeName";
            // 
            // lblCommitteeName
            // 
            resources.ApplyResources(this.lblCommitteeName, "lblCommitteeName");
            this.lblCommitteeName.Name = "lblCommitteeName";
            // 
            // txtLocation
            // 
            resources.ApplyResources(this.txtLocation, "txtLocation");
            this.txtLocation.Name = "txtLocation";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // frmEditCompetition
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmEditCompetition";
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.grpCommittee.ResumeLayout(false);
            this.grpCommittee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtSponsor;
        private System.Windows.Forms.Label lblSponsor;
        private System.Windows.Forms.GroupBox grpCommittee;
        private System.Windows.Forms.TextBox txtCommitteeMembers;
        private System.Windows.Forms.Label lblCommitteeMembers;
        private System.Windows.Forms.TextBox txtCommitteeName;
        private System.Windows.Forms.Label lblCommitteeName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCompetitionDate_start_time;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtId; // تم تغيير الاسم ليكون أوضح
        private System.Windows.Forms.Label lblId; // تم تغيير الاسم
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}