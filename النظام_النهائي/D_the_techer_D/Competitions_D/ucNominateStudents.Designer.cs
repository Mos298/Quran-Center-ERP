namespace النظام_النهائي
{
    // لاحظ التغيير هنا: قمنا بتحديد النوع بشكل كامل
    partial class ucNominateStudents : System.Windows.Forms.UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboCompetitions = new System.Windows.Forms.ComboBox();
            this.grpConditions = new System.Windows.Forms.GroupBox();
            this.rtbConditions = new System.Windows.Forms.RichTextBox();
            this.btnShowNominationList = new System.Windows.Forms.Button();
            this.grpNomination = new System.Windows.Forms.GroupBox();
            this.clbStudents = new System.Windows.Forms.CheckedListBox();
            this.btnSubmitNomination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpConditions.SuspendLayout();
            this.grpNomination.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(806, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختر المسابقة المتاحة:";
            // 
            // cboCompetitions
            // 
            this.cboCompetitions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCompetitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompetitions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboCompetitions.FormattingEnabled = true;
            this.cboCompetitions.Location = new System.Drawing.Point(327, 24);
            this.cboCompetitions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCompetitions.Name = "cboCompetitions";
            this.cboCompetitions.Size = new System.Drawing.Size(420, 36);
            this.cboCompetitions.TabIndex = 1;
            this.cboCompetitions.SelectedIndexChanged += new System.EventHandler(this.cboCompetitions_SelectedIndexChanged);
            // 
            // grpConditions
            // 
            this.grpConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConditions.Controls.Add(this.rtbConditions);
            this.grpConditions.Controls.Add(this.btnShowNominationList);
            this.grpConditions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpConditions.Location = new System.Drawing.Point(14, 86);
            this.grpConditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConditions.Name = "grpConditions";
            this.grpConditions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConditions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpConditions.Size = new System.Drawing.Size(1092, 337);
            this.grpConditions.TabIndex = 2;
            this.grpConditions.TabStop = false;
            this.grpConditions.Text = "شروط ومعايير المسابقة";
            // 
            // rtbConditions
            // 
            this.rtbConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConditions.BackColor = System.Drawing.SystemColors.Control;
            this.rtbConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbConditions.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rtbConditions.Location = new System.Drawing.Point(42, 31);
            this.rtbConditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbConditions.Name = "rtbConditions";
            this.rtbConditions.ReadOnly = true;
            this.rtbConditions.Size = new System.Drawing.Size(992, 202);
            this.rtbConditions.TabIndex = 1;
            this.rtbConditions.Text = "";
            // 
            // btnShowNominationList
            // 
            this.btnShowNominationList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShowNominationList.AutoSize = true;
            this.btnShowNominationList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnShowNominationList.FlatAppearance.BorderSize = 0;
            this.btnShowNominationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNominationList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowNominationList.ForeColor = System.Drawing.Color.White;
            this.btnShowNominationList.Location = new System.Drawing.Point(488, 276);
            this.btnShowNominationList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowNominationList.Name = "btnShowNominationList";
            this.btnShowNominationList.Size = new System.Drawing.Size(154, 37);
            this.btnShowNominationList.TabIndex = 0;
            this.btnShowNominationList.TabStop = false;
            this.btnShowNominationList.Text = "ترشيح الطلاب";
            this.btnShowNominationList.UseVisualStyleBackColor = false;
            this.btnShowNominationList.Click += new System.EventHandler(this.btnShowNominationList_Click);
            // 
            // grpNomination
            // 
            this.grpNomination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNomination.Controls.Add(this.clbStudents);
            this.grpNomination.Controls.Add(this.btnSubmitNomination);
            this.grpNomination.Controls.Add(this.label2);
            this.grpNomination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpNomination.Location = new System.Drawing.Point(14, 431);
            this.grpNomination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNomination.Name = "grpNomination";
            this.grpNomination.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNomination.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpNomination.Size = new System.Drawing.Size(1092, 370);
            this.grpNomination.TabIndex = 3;
            this.grpNomination.TabStop = false;
            this.grpNomination.Text = "قائمة الترشيح";
            this.grpNomination.Enter += new System.EventHandler(this.grpNomination_Enter);
            // 
            // clbStudents
            // 
            this.clbStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbStudents.CheckOnClick = true;
            this.clbStudents.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.clbStudents.FormattingEnabled = true;
            this.clbStudents.Location = new System.Drawing.Point(42, 68);
            this.clbStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbStudents.Name = "clbStudents";
            this.clbStudents.Size = new System.Drawing.Size(992, 220);
            this.clbStudents.TabIndex = 2;
            // 
            // btnSubmitNomination
            // 
            this.btnSubmitNomination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSubmitNomination.AutoSize = true;
            this.btnSubmitNomination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSubmitNomination.FlatAppearance.BorderSize = 0;
            this.btnSubmitNomination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitNomination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmitNomination.ForeColor = System.Drawing.Color.White;
            this.btnSubmitNomination.Location = new System.Drawing.Point(488, 325);
            this.btnSubmitNomination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitNomination.Name = "btnSubmitNomination";
            this.btnSubmitNomination.Size = new System.Drawing.Size(154, 37);
            this.btnSubmitNomination.TabIndex = 1;
            this.btnSubmitNomination.Text = "تأكيد الترشيح";
            this.btnSubmitNomination.UseVisualStyleBackColor = false;
            this.btnSubmitNomination.Click += new System.EventHandler(this.btnSubmitNomination_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(792, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "الرجاء تحديد الطلاب المرشحين:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(56, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "الطلاب المرشحين";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ucNominateStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpNomination);
            this.Controls.Add(this.grpConditions);
            this.Controls.Add(this.cboCompetitions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucNominateStudents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1110, 828);
            this.Load += new System.EventHandler(this.ucNominateStudents_Load);
            this.grpConditions.ResumeLayout(false);
            this.grpConditions.PerformLayout();
            this.grpNomination.ResumeLayout(false);
            this.grpNomination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCompetitions;
        private System.Windows.Forms.GroupBox grpConditions;
        private System.Windows.Forms.RichTextBox rtbConditions;
        private System.Windows.Forms.Button btnShowNominationList;
        private System.Windows.Forms.GroupBox grpNomination;
        private System.Windows.Forms.Button btnSubmitNomination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbStudents;
        private System.Windows.Forms.Button button1;
    }
}

