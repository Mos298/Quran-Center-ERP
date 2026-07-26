namespace النظام_النهائي.D_the_techer_D.student_D
{
    partial class frmRequestStudentTransfer
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
            this.grpTeacherInfo = new System.Windows.Forms.GroupBox();
            this.txtTeacherRegNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentRegNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpRequestDetails = new System.Windows.Forms.GroupBox();
            this.txtRequestDetails = new System.Windows.Forms.TextBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.grpTeacherInfo.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.grpRequestDetails.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTeacherInfo
            // 
            this.grpTeacherInfo.Controls.Add(this.txtTeacherRegNumber);
            this.grpTeacherInfo.Controls.Add(this.label2);
            this.grpTeacherInfo.Controls.Add(this.txtTeacherName);
            this.grpTeacherInfo.Controls.Add(this.label1);
            this.grpTeacherInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeacherInfo.Location = new System.Drawing.Point(12, 85);
            this.grpTeacherInfo.Name = "grpTeacherInfo";
            this.grpTeacherInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpTeacherInfo.Size = new System.Drawing.Size(560, 90);
            this.grpTeacherInfo.TabIndex = 0;
            this.grpTeacherInfo.TabStop = false;
            this.grpTeacherInfo.Text = "بيانات مقدم الطلب (المحفِّظ)";
            // 
            // txtTeacherRegNumber
            // 
            this.txtTeacherRegNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtTeacherRegNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherRegNumber.Location = new System.Drawing.Point(21, 43);
            this.txtTeacherRegNumber.Name = "txtTeacherRegNumber";
            this.txtTeacherRegNumber.ReadOnly = true;
            this.txtTeacherRegNumber.Size = new System.Drawing.Size(180, 25);
            this.txtTeacherRegNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم القيد:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.SystemColors.Control;
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(286, 43);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.Size = new System.Drawing.Size(180, 25);
            this.txtTeacherName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الشيخ:";
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.btnSearchStudent);
            this.grpStudentInfo.Controls.Add(this.txtStudentName);
            this.grpStudentInfo.Controls.Add(this.label3);
            this.grpStudentInfo.Controls.Add(this.txtStudentRegNumber);
            this.grpStudentInfo.Controls.Add(this.label4);
            this.grpStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentInfo.Location = new System.Drawing.Point(12, 181);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpStudentInfo.Size = new System.Drawing.Size(560, 110);
            this.grpStudentInfo.TabIndex = 1;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "بيانات الطالب المراد نقله";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchStudent.FlatAppearance.BorderSize = 0;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudent.Location = new System.Drawing.Point(461, 53);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(84, 25);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "بحث";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(21, 53);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(180, 25);
            this.txtStudentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم الطالب:";
            // 
            // txtStudentRegNumber
            // 
            this.txtStudentRegNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentRegNumber.Location = new System.Drawing.Point(286, 53);
            this.txtStudentRegNumber.Name = "txtStudentRegNumber";
            this.txtStudentRegNumber.Size = new System.Drawing.Size(169, 25);
            this.txtStudentRegNumber.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "رقم قيد الطالب:";
            // 
            // grpRequestDetails
            // 
            this.grpRequestDetails.Controls.Add(this.txtRequestDetails);
            this.grpRequestDetails.Enabled = false;
            this.grpRequestDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRequestDetails.Location = new System.Drawing.Point(12, 297);
            this.grpRequestDetails.Name = "grpRequestDetails";
            this.grpRequestDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpRequestDetails.Size = new System.Drawing.Size(560, 200);
            this.grpRequestDetails.TabIndex = 2;
            this.grpRequestDetails.TabStop = false;
            this.grpRequestDetails.Text = "تفاصيل طلب النقل (يرجى توضيح المركز أو الشيخ المراد النقل إليه)";
            // 
            // txtRequestDetails
            // 
            this.txtRequestDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestDetails.Location = new System.Drawing.Point(3, 21);
            this.txtRequestDetails.Multiline = true;
            this.txtRequestDetails.Name = "txtRequestDetails";
            this.txtRequestDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequestDetails.Size = new System.Drawing.Size(554, 176);
            this.txtRequestDetails.TabIndex = 0;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSubmitRequest.Enabled = false;
            this.btnSubmitRequest.FlatAppearance.BorderSize = 0;
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRequest.Location = new System.Drawing.Point(12, 503);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(560, 50);
            this.btnSubmitRequest.TabIndex = 3;
            this.btnSubmitRequest.Text = "إرسال الطلب";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 65);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(584, 65);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "تقديم طلب نقل طالب";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRequestStudentTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.grpRequestDetails);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.grpTeacherInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequestStudentTransfer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقديم طلب نقل طالب";
            this.Load += new System.EventHandler(this.frmRequestStudentTransfer_Load);
            this.grpTeacherInfo.ResumeLayout(false);
            this.grpTeacherInfo.PerformLayout();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpRequestDetails.ResumeLayout(false);
            this.grpRequestDetails.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeacherInfo;
        private System.Windows.Forms.TextBox txtTeacherRegNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentRegNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpRequestDetails;
        private System.Windows.Forms.TextBox txtRequestDetails;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
    }
}

