namespace النظام_النهائي
{
    partial class frmPrintMentors_A3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintMentors_A3));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMentors = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lblSelectMentors = new System.Windows.Forms.Label();
            this.checkedListBoxMentors = new System.Windows.Forms.CheckedListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentors)).BeginInit();
            this.pnlControls.SuspendLayout();
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
            this.lblTitle.Text = "طباعة بيانات الموجهين";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMentors);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 310);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(772, 343);
            this.pnlMain.TabIndex = 15;
            // 
            // dgvMentors
            // 
            this.dgvMentors.AllowUserToAddRows = false;
            this.dgvMentors.AllowUserToDeleteRows = false;
            this.dgvMentors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMentors.BackgroundColor = System.Drawing.Color.White;
            this.dgvMentors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMentors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMentors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMentors.Location = new System.Drawing.Point(0, 0);
            this.dgvMentors.Name = "dgvMentors";
            this.dgvMentors.ReadOnly = true;
            this.dgvMentors.RowHeadersWidth = 51;
            this.dgvMentors.RowTemplate.Height = 24;
            this.dgvMentors.Size = new System.Drawing.Size(772, 343);
            this.dgvMentors.TabIndex = 0;
            this.dgvMentors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMentors_CellContentClick);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.btnLoadData);
            this.pnlControls.Controls.Add(this.lblSelectMentors);
            this.pnlControls.Controls.Add(this.checkedListBoxMentors);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 60);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(772, 180);
            this.pnlControls.TabIndex = 16;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(44, 75);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(131, 40);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "تحميل البيانات";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lblSelectMentors
            // 
            this.lblSelectMentors.AutoSize = true;
            this.lblSelectMentors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectMentors.Location = new System.Drawing.Point(575, 3);
            this.lblSelectMentors.Name = "lblSelectMentors";
            this.lblSelectMentors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectMentors.Size = new System.Drawing.Size(172, 23);
            this.lblSelectMentors.TabIndex = 1;
            this.lblSelectMentors.Text = "حدد الموجهين للطباعة:";
            // 
            // checkedListBoxMentors
            // 
            this.checkedListBoxMentors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkedListBoxMentors.FormattingEnabled = true;
            this.checkedListBoxMentors.Location = new System.Drawing.Point(192, 40);
            this.checkedListBoxMentors.Name = "checkedListBoxMentors";
            this.checkedListBoxMentors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBoxMentors.Size = new System.Drawing.Size(569, 129);
            this.checkedListBoxMentors.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(648, 255);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 45);
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
            // frmPrintMentors_A3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 653);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintMentors_A3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طباعة بيانات الموجهين";
            this.Load += new System.EventHandler(this.frmPrintMentors_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMentors)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvMentors;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblSelectMentors;
        private System.Windows.Forms.CheckedListBox checkedListBoxMentors;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
