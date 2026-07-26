namespace النظام_النهائي
{
    partial class RequestItemControl
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(255, 15);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(40, 40);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "عنوان الطلب";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubject
            // 
            this.lblSubject.ForeColor = System.Drawing.Color.Gray;
            this.lblSubject.Location = new System.Drawing.Point(15, 33);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(234, 23);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "المعني بالطلب";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //    this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(15, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(194, 38);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "التاريخ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStatus.Location = new System.Drawing.Point(363, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(5, 96);
            this.pnlStatus.TabIndex = 4;
            // 
            // RequestItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestItemControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(368, 96);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlStatus;
    }
}
