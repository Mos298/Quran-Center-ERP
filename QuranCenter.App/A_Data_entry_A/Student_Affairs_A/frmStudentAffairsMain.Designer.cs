namespace النظام_النهائي
{
    partial class frmStudentAffairsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentAffairsMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlActiveTabIndicator = new System.Windows.Forms.Panel();
            this.btnInactiveStudents = new System.Windows.Forms.Button();
            this.btnRegistrationRequests = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.pnlActiveTabIndicator);
            this.pnlSidebar.Controls.Add(this.btnInactiveStudents);
            this.pnlSidebar.Controls.Add(this.btnRegistrationRequests);
            this.pnlSidebar.Controls.Add(this.btnViewStudents);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(233, 814);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox13);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 86);
            this.pnlLogo.TabIndex = 4;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox13.ForeColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(194, 4);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(39, 82);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 16;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(233, 86);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "شؤون الطلاب";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActiveTabIndicator
            // 
            this.pnlActiveTabIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pnlActiveTabIndicator.Location = new System.Drawing.Point(222, 98);
            this.pnlActiveTabIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActiveTabIndicator.Name = "pnlActiveTabIndicator";
            this.pnlActiveTabIndicator.Size = new System.Drawing.Size(12, 62);
            this.pnlActiveTabIndicator.TabIndex = 3;
            // 
            // btnInactiveStudents
            // 
            this.btnInactiveStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInactiveStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.btnInactiveStudents.FlatAppearance.BorderSize = 0;
            this.btnInactiveStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactiveStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInactiveStudents.ForeColor = System.Drawing.Color.Black;
            this.btnInactiveStudents.Location = new System.Drawing.Point(0, 246);
            this.btnInactiveStudents.Margin = new System.Windows.Forms.Padding(4);
            this.btnInactiveStudents.Name = "btnInactiveStudents";
            this.btnInactiveStudents.Size = new System.Drawing.Size(233, 62);
            this.btnInactiveStudents.TabIndex = 2;
            this.btnInactiveStudents.Text = "الطلاب المنقطعون";
            this.btnInactiveStudents.UseVisualStyleBackColor = false;
            this.btnInactiveStudents.Click += new System.EventHandler(this.btnInactiveStudents_Click);
            // 
            // btnRegistrationRequests
            // 
            this.btnRegistrationRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.btnRegistrationRequests.FlatAppearance.BorderSize = 0;
            this.btnRegistrationRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistrationRequests.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrationRequests.Location = new System.Drawing.Point(0, 172);
            this.btnRegistrationRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrationRequests.Name = "btnRegistrationRequests";
            this.btnRegistrationRequests.Size = new System.Drawing.Size(233, 62);
            this.btnRegistrationRequests.TabIndex = 1;
            this.btnRegistrationRequests.Text = "طلبات التسجيل";
            this.btnRegistrationRequests.UseVisualStyleBackColor = false;
            this.btnRegistrationRequests.Click += new System.EventHandler(this.btnRegistrationRequests_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewStudents.ForeColor = System.Drawing.Color.Black;
            this.btnViewStudents.Location = new System.Drawing.Point(0, 98);
            this.btnViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(233, 62);
            this.btnViewStudents.TabIndex = 0;
            this.btnViewStudents.Text = "عرض الطلاب";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.navButton_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(233, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1032, 86);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblTitle.Size = new System.Drawing.Size(1032, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "شؤون الطلاب";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(233, 86);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1032, 728);
            this.pnlMainContent.TabIndex = 2;
            // 
            // frmStudentAffairsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 814);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentAffairsMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة شؤون الطلاب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentAffairsMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnInactiveStudents;
        private System.Windows.Forms.Button btnRegistrationRequests;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlActiveTabIndicator;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}

