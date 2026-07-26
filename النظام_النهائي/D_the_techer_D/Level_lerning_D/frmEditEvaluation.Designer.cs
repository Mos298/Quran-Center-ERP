namespace النظام_النهائي
{
    partial class frmEditEvaluation
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
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.cboOverallLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numTajweedLevel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numMemorizationLevel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numMemorizedAjza = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCommitment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTajweedLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizationLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizedAjza)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvaluation
            // 
            this.grpEvaluation.Controls.Add(this.cboOverallLevel);
            this.grpEvaluation.Controls.Add(this.label8);
            this.grpEvaluation.Controls.Add(this.numTajweedLevel);
            this.grpEvaluation.Controls.Add(this.label7);
            this.grpEvaluation.Controls.Add(this.numMemorizationLevel);
            this.grpEvaluation.Controls.Add(this.label6);
            this.grpEvaluation.Controls.Add(this.numMemorizedAjza);
            this.grpEvaluation.Controls.Add(this.label5);
            this.grpEvaluation.Controls.Add(this.cboCommitment);
            this.grpEvaluation.Controls.Add(this.label4);
            this.grpEvaluation.Controls.Add(this.lblRegNumber);
            this.grpEvaluation.Controls.Add(this.label3);
            this.grpEvaluation.Controls.Add(this.lblStudentName);
            this.grpEvaluation.Controls.Add(this.label2);
            this.grpEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpEvaluation.Location = new System.Drawing.Point(13, 13);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpEvaluation.Size = new System.Drawing.Size(559, 290);
            this.grpEvaluation.TabIndex = 2;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "تعديل بيانات التقييم";
            // 
            // cboOverallLevel
            // 
            this.cboOverallLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOverallLevel.FormattingEnabled = true;
            this.cboOverallLevel.Items.AddRange(new object[] {
            "ممتاز",
            "جيد جداً",
            "جيد",
            "مقبول",
            "ضعيف"});
            this.cboOverallLevel.Location = new System.Drawing.Point(145, 240);
            this.cboOverallLevel.Name = "cboOverallLevel";
            this.cboOverallLevel.Size = new System.Drawing.Size(250, 25);
            this.cboOverallLevel.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "المستوى العام:";
            // 
            // numTajweedLevel
            // 
            this.numTajweedLevel.Location = new System.Drawing.Point(325, 198);
            this.numTajweedLevel.Name = "numTajweedLevel";
            this.numTajweedLevel.Size = new System.Drawing.Size(70, 25);
            this.numTajweedLevel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "مستوى الطالب في الأحكام:";
            // 
            // numMemorizationLevel
            // 
            this.numMemorizationLevel.Location = new System.Drawing.Point(325, 156);
            this.numMemorizationLevel.Name = "numMemorizationLevel";
            this.numMemorizationLevel.Size = new System.Drawing.Size(70, 25);
            this.numMemorizationLevel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "مستوى الطالب في الحفظ:";
            // 
            // numMemorizedAjza
            // 
            this.numMemorizedAjza.Location = new System.Drawing.Point(325, 114);
            this.numMemorizedAjza.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMemorizedAjza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMemorizedAjza.Name = "numMemorizedAjza";
            this.numMemorizedAjza.Size = new System.Drawing.Size(70, 25);
            this.numMemorizedAjza.TabIndex = 7;
            this.numMemorizedAjza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "عدد الأجزاء المحفوظة:";
            // 
            // cboCommitment
            // 
            this.cboCommitment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommitment.FormattingEnabled = true;
            this.cboCommitment.Items.AddRange(new object[] {
            "ملتزم",
            "غير ملتزم"});
            this.cboCommitment.Location = new System.Drawing.Point(245, 72);
            this.cboCommitment.Name = "cboCommitment";
            this.cboCommitment.Size = new System.Drawing.Size(150, 25);
            this.cboCommitment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "التزام الطالب:";
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNumber.Location = new System.Drawing.Point(20, 35);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(180, 17);
            this.lblRegNumber.TabIndex = 3;
            this.lblRegNumber.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم القيد:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.Location = new System.Drawing.Point(273, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(180, 17);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم الطالب:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(13, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(559, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ التعديلات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpEvaluation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditEvaluation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل تقييم الطالب";
            this.Load += new System.EventHandler(this.frmEditEvaluation_Load);
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTajweedLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizationLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizedAjza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.ComboBox cboOverallLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numTajweedLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMemorizationLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMemorizedAjza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCommitment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}
