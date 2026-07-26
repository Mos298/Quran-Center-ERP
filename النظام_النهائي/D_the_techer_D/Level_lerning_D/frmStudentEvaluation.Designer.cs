namespace النظام_النهائي
{
    partial class frmStudentEvaluation
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchRegNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.grpEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTajweedLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizationLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizedAjza)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchRegNumber);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlSearch.Size = new System.Drawing.Size(681, 98);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(65, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchRegNumber
            // 
            this.txtSearchRegNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchRegNumber.Location = new System.Drawing.Point(190, 30);
            this.txtSearchRegNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchRegNumber.Name = "txtSearchRegNumber";
            this.txtSearchRegNumber.Size = new System.Drawing.Size(244, 34);
            this.txtSearchRegNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل رقم القيد للطالب:";
            // 
            // grpEvaluation
            // 
            this.grpEvaluation.Controls.Add(this.label11);
            this.grpEvaluation.Controls.Add(this.label10);
            this.grpEvaluation.Controls.Add(this.label9);
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
            this.grpEvaluation.Enabled = false;
            this.grpEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpEvaluation.Location = new System.Drawing.Point(15, 117);
            this.grpEvaluation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEvaluation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpEvaluation.Size = new System.Drawing.Size(652, 357);
            this.grpEvaluation.TabIndex = 1;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "بيانات التقييم";
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
            this.cboOverallLevel.Location = new System.Drawing.Point(169, 295);
            this.cboOverallLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboOverallLevel.Name = "cboOverallLevel";
            this.cboOverallLevel.Size = new System.Drawing.Size(291, 29);
            this.cboOverallLevel.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "المستوى العام:";
            // 
            // numTajweedLevel
            // 
            this.numTajweedLevel.Location = new System.Drawing.Point(352, 244);
            this.numTajweedLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTajweedLevel.Name = "numTajweedLevel";
            this.numTajweedLevel.Size = new System.Drawing.Size(82, 29);
            this.numTajweedLevel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "مستوى الطالب في الأحكام:";
            // 
            // numMemorizationLevel
            // 
            this.numMemorizationLevel.Location = new System.Drawing.Point(352, 192);
            this.numMemorizationLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMemorizationLevel.Name = "numMemorizationLevel";
            this.numMemorizationLevel.Size = new System.Drawing.Size(82, 29);
            this.numMemorizationLevel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "مستوى الطالب في الحفظ:";
            // 
            // numMemorizedAjza
            // 
            this.numMemorizedAjza.Location = new System.Drawing.Point(352, 140);
            this.numMemorizedAjza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numMemorizedAjza.Size = new System.Drawing.Size(82, 29);
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
            this.label5.Location = new System.Drawing.Point(475, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
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
            this.cboCommitment.Location = new System.Drawing.Point(286, 89);
            this.cboCommitment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCommitment.Name = "cboCommitment";
            this.cboCommitment.Size = new System.Drawing.Size(174, 29);
            this.cboCommitment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "التزام الطالب:";
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNumber.Location = new System.Drawing.Point(23, 43);
            this.lblRegNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(210, 21);
            this.lblRegNumber.TabIndex = 3;
            this.lblRegNumber.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم القيد:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.Location = new System.Drawing.Point(318, 43);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(210, 21);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم الطالب:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(652, 62);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ التقييم";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "%";
            // 
            // frmStudentEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpEvaluation);
            this.Controls.Add(this.pnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentEvaluation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "متابعة المستوى التعليمي للطالب";
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTajweedLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizationLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemorizedAjza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchRegNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCommitment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMemorizedAjza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMemorizationLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTajweedLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOverallLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

