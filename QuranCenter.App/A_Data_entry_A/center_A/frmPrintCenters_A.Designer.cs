namespace النظام_النهائي
{
    partial class frmPrintCenters_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintCenters_A));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chklistCenters = new System.Windows.Forms.CheckedListBox();
            this.lblSelectCenters = new System.Windows.Forms.Label();
            this.dgvPrintPreview = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlTopBar.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(684, 64);
            this.pnlTopBar.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(684, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "طباعة تقرير المراكز";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.White;
            this.pnlSelection.Controls.Add(this.btnLoad);
            this.pnlSelection.Controls.Add(this.chklistCenters);
            this.pnlSelection.Controls.Add(this.lblSelectCenters);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelection.Location = new System.Drawing.Point(0, 64);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(684, 276);
            this.pnlSelection.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(279, 212);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 42);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "تحميل البيانات";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chklistCenters
            // 
            this.chklistCenters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chklistCenters.FormattingEnabled = true;
            this.chklistCenters.Location = new System.Drawing.Point(12, 61);
            this.chklistCenters.Name = "chklistCenters";
            this.chklistCenters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklistCenters.Size = new System.Drawing.Size(660, 129);
            this.chklistCenters.TabIndex = 1;
            // 
            // lblSelectCenters
            // 
            this.lblSelectCenters.AutoSize = true;
            this.lblSelectCenters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectCenters.Location = new System.Drawing.Point(288, 16);
            this.lblSelectCenters.Name = "lblSelectCenters";
            this.lblSelectCenters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectCenters.Size = new System.Drawing.Size(153, 23);
            this.lblSelectCenters.TabIndex = 0;
            this.lblSelectCenters.Text = "حدد المراكز للطباعة:";
            // 
            // dgvPrintPreview
            // 
            this.dgvPrintPreview.AllowUserToAddRows = false;
            this.dgvPrintPreview.AllowUserToDeleteRows = false;
            this.dgvPrintPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrintPreview.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrintPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintPreview.Location = new System.Drawing.Point(0, 346);
            this.dgvPrintPreview.Name = "dgvPrintPreview";
            this.dgvPrintPreview.ReadOnly = true;
            this.dgvPrintPreview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPrintPreview.RowHeadersWidth = 51;
            this.dgvPrintPreview.RowTemplate.Height = 24;
            this.dgvPrintPreview.Size = new System.Drawing.Size(684, 278);
            this.dgvPrintPreview.TabIndex = 13;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(568, 630);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 48);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(440, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 48);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "إغلاق";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmPrintCenters_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 723);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPrintPreview);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintCenters_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طباعة تقرير المراكز";
            this.Load += new System.EventHandler(this.frmPrintCenters_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Label lblSelectCenters;
        private System.Windows.Forms.CheckedListBox chklistCenters;
        private System.Windows.Forms.DataGridView dgvPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnLoad;
    }
}
