using النظام_النهائي.Properties;

namespace النظام_النهائي
{
    partial class print_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print_Form));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.chklstTeachers = new System.Windows.Forms.CheckedListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.dgvPrintPreview = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
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
            this.pnlTopBar.Size = new System.Drawing.Size(772, 60);
            this.pnlTopBar.TabIndex = 14;
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
            this.lblTitle.Text = "طباعة طلابات التسجيل";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.White;
            this.pnlSelection.Controls.Add(this.btnLoadData);
            this.pnlSelection.Controls.Add(this.chklstTeachers);
            this.pnlSelection.Controls.Add(this.lblSelect);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSelection.Location = new System.Drawing.Point(553, 60);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(219, 493);
            this.pnlSelection.TabIndex = 15;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(18, 440);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(184, 40);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "تحميل البيانات";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // chklstTeachers
            // 
            this.chklstTeachers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chklstTeachers.FormattingEnabled = true;
            this.chklstTeachers.Location = new System.Drawing.Point(18, 50);
            this.chklstTeachers.Name = "chklstTeachers";
            this.chklstTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklstTeachers.Size = new System.Drawing.Size(184, 379);
            this.chklstTeachers.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelect.Location = new System.Drawing.Point(44, 20);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelect.Size = new System.Drawing.Size(146, 23);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "حدد طلب التسجيل:";
            // 
            // dgvPrintPreview
            // 
            this.dgvPrintPreview.AllowUserToAddRows = false;
            this.dgvPrintPreview.AllowUserToDeleteRows = false;
            this.dgvPrintPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrintPreview.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrintPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPrintPreview.Location = new System.Drawing.Point(0, 60);
            this.dgvPrintPreview.Name = "dgvPrintPreview";
            this.dgvPrintPreview.ReadOnly = true;
            this.dgvPrintPreview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPrintPreview.RowHeadersWidth = 51;
            this.dgvPrintPreview.RowTemplate.Height = 24;
            this.dgvPrintPreview.Size = new System.Drawing.Size(553, 425);
            this.dgvPrintPreview.TabIndex = 16;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(197, 490);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(175, 50);
            this.btnPrint.TabIndex = 17;
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
            // print_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 553);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPrintPreview);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "print_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طباعة بيانات المحفظين";
            this.Load += new System.EventHandler(this.frmPrintTeachers_Load);
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
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.CheckedListBox chklstTeachers;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.DataGridView dgvPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
