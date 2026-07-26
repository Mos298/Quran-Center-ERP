namespace النظام_النهائي
{
    partial class frmPrintSupervisors_A2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintSupervisors_A2));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.clbSupervisors = new System.Windows.Forms.CheckedListBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvSupervisors = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlTopBar.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(772, 60);
            this.pnlTopBar.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(772, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "طباعة بيانات المشرفين";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.White;
            this.pnlSelection.Controls.Add(this.btnLoadData);
            this.pnlSelection.Controls.Add(this.clbSupervisors);
            this.pnlSelection.Controls.Add(this.lblInstruction);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelection.Location = new System.Drawing.Point(0, 60);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(772, 200);
            this.pnlSelection.TabIndex = 14;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(27, 129);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(131, 45);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "تحميل البيانات";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // clbSupervisors
            // 
            this.clbSupervisors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbSupervisors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clbSupervisors.FormattingEnabled = true;
            this.clbSupervisors.Location = new System.Drawing.Point(185, 45);
            this.clbSupervisors.Name = "clbSupervisors";
            this.clbSupervisors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clbSupervisors.Size = new System.Drawing.Size(559, 129);
            this.clbSupervisors.TabIndex = 1;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstruction.Location = new System.Drawing.Point(519, 15);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInstruction.Size = new System.Drawing.Size(218, 23);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "حدد مشرفاً أو أكثر من القائمة:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvSupervisors);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGrid.Location = new System.Drawing.Point(0, 260);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.pnlGrid.Size = new System.Drawing.Size(772, 320);
            this.pnlGrid.TabIndex = 15;
            // 
            // dgvSupervisors
            // 
            this.dgvSupervisors.AllowUserToAddRows = false;
            this.dgvSupervisors.AllowUserToDeleteRows = false;
            this.dgvSupervisors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupervisors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSupervisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupervisors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupervisors.Location = new System.Drawing.Point(10, 12);
            this.dgvSupervisors.Name = "dgvSupervisors";
            this.dgvSupervisors.ReadOnly = true;
            this.dgvSupervisors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSupervisors.RowHeadersWidth = 51;
            this.dgvSupervisors.RowTemplate.Height = 24;
            this.dgvSupervisors.Size = new System.Drawing.Size(752, 296);
            this.dgvSupervisors.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(636, 604);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 45);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // frmPrintSupervisors_A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 711);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintSupervisors_A2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طباعة بيانات المشرفين";
            this.Load += new System.EventHandler(this.frmPrintSupervisors_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.CheckedListBox clbSupervisors;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvSupervisors;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
