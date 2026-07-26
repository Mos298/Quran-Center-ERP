namespace النظام_النهائي
{
    partial class frmDeleteCenter_A
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCenters = new System.Windows.Forms.ComboBox();
            this.lblSelectCenter = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblWorkingHoursValue = new System.Windows.Forms.Label();
            this.lblAreaValue = new System.Windows.Forms.Label();
            this.lblCityValue = new System.Windows.Forms.Label();
            this.lblCenterNameValue = new System.Windows.Forms.Label();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlSearch.SuspendLayout();
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
            this.pnlTopBar.Size = new System.Drawing.Size(509, 64);
            this.pnlTopBar.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(509, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "حذف بيانات مركز";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.cmbCenters);
            this.pnlSearch.Controls.Add(this.lblSelectCenter);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 64);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(509, 85);
            this.pnlSearch.TabIndex = 11;
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
            this.btnSearch.Text = "عرض";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.pnlDetails.Controls.Add(this.lblWorkingHoursValue);
            this.pnlDetails.Controls.Add(this.lblAreaValue);
            this.pnlDetails.Controls.Add(this.lblCityValue);
            this.pnlDetails.Controls.Add(this.lblCenterNameValue);
            this.pnlDetails.Controls.Add(this.lblWorkingHours);
            this.pnlDetails.Controls.Add(this.lblArea);
            this.pnlDetails.Controls.Add(this.lblCity);
            this.pnlDetails.Controls.Add(this.lblCenterName);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetails.Location = new System.Drawing.Point(0, 149);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(509, 236);
            this.pnlDetails.TabIndex = 12;
            this.pnlDetails.Visible = false;
            // 
            // lblWorkingHoursValue
            // 
            this.lblWorkingHoursValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWorkingHoursValue.Location = new System.Drawing.Point(52, 153);
            this.lblWorkingHoursValue.Name = "lblWorkingHoursValue";
            this.lblWorkingHoursValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWorkingHoursValue.Size = new System.Drawing.Size(245, 27);
            this.lblWorkingHoursValue.TabIndex = 12;
            this.lblWorkingHoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAreaValue
            // 
            this.lblAreaValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAreaValue.Location = new System.Drawing.Point(44, 85);
            this.lblAreaValue.Name = "lblAreaValue";
            this.lblAreaValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAreaValue.Size = new System.Drawing.Size(245, 27);
            this.lblAreaValue.TabIndex = 9;
            this.lblAreaValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCityValue
            // 
            this.lblCityValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCityValue.Location = new System.Drawing.Point(44, 21);
            this.lblCityValue.Name = "lblCityValue";
            this.lblCityValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCityValue.Size = new System.Drawing.Size(245, 27);
            this.lblCityValue.TabIndex = 8;
            this.lblCityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCenterNameValue
            // 
            this.lblCenterNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCenterNameValue.Location = new System.Drawing.Point(44, 21);
            this.lblCenterNameValue.Name = "lblCenterNameValue";
            this.lblCenterNameValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCenterNameValue.Size = new System.Drawing.Size(245, 27);
            this.lblCenterNameValue.TabIndex = 7;
            this.lblCenterNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWorkingHours.Location = new System.Drawing.Point(314, 153);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWorkingHours.Size = new System.Drawing.Size(192, 27);
            this.lblWorkingHours.TabIndex = 6;
            this.lblWorkingHours.Text = "مواعيد العمل:";
            this.lblWorkingHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArea.Location = new System.Drawing.Point(306, 85);
            this.lblArea.Name = "lblArea";
            this.lblArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblArea.Size = new System.Drawing.Size(192, 27);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "المحلة:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCity.Location = new System.Drawing.Point(306, 21);
            this.lblCity.Name = "lblCity";
            this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCity.Size = new System.Drawing.Size(192, 27);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "المدينة:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCenterName
            // 
            this.lblCenterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCenterName.Location = new System.Drawing.Point(306, 21);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCenterName.Size = new System.Drawing.Size(192, 27);
            this.lblCenterName.TabIndex = 1;
            this.lblCenterName.Text = "اسم المركز:";
            this.lblCenterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(228, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 48);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(372, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 48);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "حذف المركز";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteCenter_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 465);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteCenter_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حذف بيانات مركز";
            this.Load += new System.EventHandler(this.frmDeleteCenter_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCenters;
        private System.Windows.Forms.Label lblSelectCenter;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.Label lblWorkingHoursValue;
        private System.Windows.Forms.Label lblAreaValue;
        private System.Windows.Forms.Label lblCityValue;
        private System.Windows.Forms.Label lblCenterNameValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}
