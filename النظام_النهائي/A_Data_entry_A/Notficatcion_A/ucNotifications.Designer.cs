namespace النظام_النهائي
{
    partial class ucNotifications
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flpRequestsList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblDetailsContent = new System.Windows.Forms.Label();
            this.lblDetailInitiator = new System.Windows.Forms.Label();
            this.lblDetailDate = new System.Windows.Forms.Label();
            this.lblDetailSubject = new System.Windows.Forms.Label();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.pnlNoSelection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlNoSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flpRequestsList);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Panel1MinSize = 320;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlDetails);
            this.splitContainer.Panel2.Controls.Add(this.pnlNoSelection);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer.Size = new System.Drawing.Size(950, 650);
            this.splitContainer.SplitterDistance = 320;
            this.splitContainer.TabIndex = 0;
            // 
            // flpRequestsList
            // 
            this.flpRequestsList.AutoScroll = true;
            this.flpRequestsList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpRequestsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRequestsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRequestsList.Location = new System.Drawing.Point(0, 0);
            this.flpRequestsList.Name = "flpRequestsList";
            this.flpRequestsList.Size = new System.Drawing.Size(320, 650);
            this.flpRequestsList.TabIndex = 0;
            this.flpRequestsList.WrapContents = false;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.btnReject);
            this.pnlDetails.Controls.Add(this.btnApprove);
            this.pnlDetails.Controls.Add(this.lblDetailsContent);
            this.pnlDetails.Controls.Add(this.lblDetailInitiator);
            this.pnlDetails.Controls.Add(this.lblDetailDate);
            this.pnlDetails.Controls.Add(this.lblDetailSubject);
            this.pnlDetails.Controls.Add(this.lblDetailTitle);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDetails.Size = new System.Drawing.Size(626, 650);
            this.pnlDetails.TabIndex = 0;
            this.pnlDetails.Visible = false;
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.BackColor = System.Drawing.Color.Tomato;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(23, 587);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(150, 40);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "رفض الطلب";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(179, 587);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(150, 40);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "موافقة على الطلب";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblDetailsContent
            // 
            this.lblDetailsContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsContent.Location = new System.Drawing.Point(23, 180);
            this.lblDetailsContent.Name = "lblDetailsContent";
            this.lblDetailsContent.Size = new System.Drawing.Size(580, 200);
            this.lblDetailsContent.TabIndex = 4;
            this.lblDetailsContent.Text = "محتوى تفاصيل الطلب هنا...";
            // 
            // lblDetailInitiator
            // 
            this.lblDetailInitiator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailInitiator.ForeColor = System.Drawing.Color.Gray;
            this.lblDetailInitiator.Location = new System.Drawing.Point(23, 130);
            this.lblDetailInitiator.Name = "lblDetailInitiator";
            this.lblDetailInitiator.Size = new System.Drawing.Size(580, 23);
            this.lblDetailInitiator.TabIndex = 3;
            this.lblDetailInitiator.Text = "مقدم الطلب:";
            this.lblDetailInitiator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetailDate
            // 
            this.lblDetailDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDetailDate.Location = new System.Drawing.Point(23, 100);
            this.lblDetailDate.Name = "lblDetailDate";
            this.lblDetailDate.Size = new System.Drawing.Size(580, 23);
            this.lblDetailDate.TabIndex = 2;
            this.lblDetailDate.Text = "تاريخ الطلب:";
            this.lblDetailDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetailSubject
            // 
            this.lblDetailSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetailSubject.Location = new System.Drawing.Point(23, 60);
            this.lblDetailSubject.Name = "lblDetailSubject";
            this.lblDetailSubject.Size = new System.Drawing.Size(580, 30);
            this.lblDetailSubject.TabIndex = 1;
            this.lblDetailSubject.Text = "المعني بالطلب";
            this.lblDetailSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTitle.Location = new System.Drawing.Point(23, 20);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(580, 40);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "عنوان الطلب";
            this.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlNoSelection
            // 
            this.pnlNoSelection.Controls.Add(this.label1);
            this.pnlNoSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlNoSelection.Name = "pnlNoSelection";
            this.pnlNoSelection.Size = new System.Drawing.Size(626, 650);
            this.pnlNoSelection.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 650);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرجاء تحديد طلب لعرض تفاصيله";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNotifications";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(950, 650);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlNoSelection.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flpRequestsList;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblDetailSubject;
        private System.Windows.Forms.Label lblDetailDate;
        private System.Windows.Forms.Label lblDetailInitiator;
        private System.Windows.Forms.Label lblDetailsContent;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Panel pnlNoSelection;
        private System.Windows.Forms.Label label1;
    }
}
