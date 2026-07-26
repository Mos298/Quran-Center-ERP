namespace النظام_النهائي
{
    partial class frmEditCenter_A
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCenters = new System.Windows.Forms.ComboBox();
            this.lblSelectCenter = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.txtCenterName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(479, 64);
            this.pnlTopBar.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(479, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "تعديل بيانات مركز";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.cmbCenters);
            this.pnlMain.Controls.Add(this.lblSelectCenter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 64);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(479, 85);
            this.pnlMain.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(35, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmbCenters
            // 
            this.cmbCenters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCenters.FormattingEnabled = true;
            this.cmbCenters.Location = new System.Drawing.Point(131, 27);
            this.cmbCenters.Name = "cmbCenters";
            this.cmbCenters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCenters.Size = new System.Drawing.Size(219, 31);
            this.cmbCenters.TabIndex = 1;
            // 
            // lblSelectCenter
            // 
            this.lblSelectCenter.AutoSize = true;
            this.lblSelectCenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectCenter.Location = new System.Drawing.Point(359, 32);
            this.lblSelectCenter.Name = "lblSelectCenter";
            this.lblSelectCenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectCenter.Size = new System.Drawing.Size(121, 23);
            this.lblSelectCenter.TabIndex = 0;
            this.lblSelectCenter.Text = "اختر اسم المركز:";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.lblWorkingHours);
            this.pnlDetails.Controls.Add(this.txtWorkingHours);
            this.pnlDetails.Controls.Add(this.lblArea);
            this.pnlDetails.Controls.Add(this.txtArea);
            this.pnlDetails.Controls.Add(this.lblCity);
            this.pnlDetails.Controls.Add(this.txtCity);
            this.pnlDetails.Controls.Add(this.lblCenterName);
            this.pnlDetails.Controls.Add(this.txtCenterName);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetails.Location = new System.Drawing.Point(0, 149);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(479, 233);
            this.pnlDetails.TabIndex = 11;
            this.pnlDetails.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArea.Location = new System.Drawing.Point(247, 86);
            this.lblArea.Name = "lblArea";
            this.lblArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblArea.Size = new System.Drawing.Size(192, 27);
            this.lblArea.TabIndex = 17;
            this.lblArea.Text = "المدينة: ";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCity.Location = new System.Drawing.Point(247, 22);
            this.lblCity.Name = "lblCity";
            this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCity.Size = new System.Drawing.Size(192, 27);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "المدينة:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCity.Location = new System.Drawing.Point(13, 19);
            this.txtCity.Name = "txtCity";
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCity.Size = new System.Drawing.Size(210, 30);
            this.txtCity.TabIndex = 14;
            // 
            // lblCenterName
            // 
            this.lblCenterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCenterName.Location = new System.Drawing.Point(247, 22);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCenterName.Size = new System.Drawing.Size(192, 27);
            this.lblCenterName.TabIndex = 13;
            this.lblCenterName.Text = "اسم المركز:";
            this.lblCenterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCenterName
            // 
            this.txtCenterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCenterName.Location = new System.Drawing.Point(13, 19);
            this.txtCenterName.Name = "txtCenterName";
            this.txtCenterName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCenterName.Size = new System.Drawing.Size(210, 30);
            this.txtCenterName.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(208, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 49);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(345, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ التعديلات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(13, 83);
            this.txtArea.Name = "txtArea";
            this.txtArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtArea.Size = new System.Drawing.Size(210, 30);
            this.txtArea.TabIndex = 16;
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWorkingHours.Location = new System.Drawing.Point(12, 148);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWorkingHours.Size = new System.Drawing.Size(210, 30);
            this.txtWorkingHours.TabIndex = 20;
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWorkingHours.Location = new System.Drawing.Point(247, 151);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWorkingHours.Size = new System.Drawing.Size(192, 27);
            this.lblWorkingHours.TabIndex = 21;
            this.lblWorkingHours.Text = "مواعيد العمل:";
            this.lblWorkingHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditCenter_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 464);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCenter_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل بيانات مركز";
            this.Load += new System.EventHandler(this.frmEditCenter_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSelectCenter;
        private System.Windows.Forms.ComboBox cmbCenters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.TextBox txtCenterName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.TextBox txtArea;
    }
}
