namespace النظام_النهائي
{
    partial class frmPrintDataEntry_A
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
            this.btnPrintToFile = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(482, 60);
            this.pnlTopBar.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(482, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "طباعة تقرير مدخلي البيانات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrintToFile
            // 
            this.btnPrintToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnPrintToFile.FlatAppearance.BorderSize = 0;
            this.btnPrintToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintToFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintToFile.ForeColor = System.Drawing.Color.White;
            this.btnPrintToFile.Location = new System.Drawing.Point(141, 150);
            this.btnPrintToFile.Name = "btnPrintToFile";
            this.btnPrintToFile.Size = new System.Drawing.Size(200, 50);
            this.btnPrintToFile.TabIndex = 14;
            this.btnPrintToFile.Text = "حفظ التقرير إلى ملف";
            this.btnPrintToFile.UseVisualStyleBackColor = false;
            this.btnPrintToFile.Click += new System.EventHandler(this.btnPrintToFile_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstructions.Location = new System.Drawing.Point(12, 80);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInstructions.Size = new System.Drawing.Size(458, 55);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "اضغط على الزر أدناه لحفظ تقرير كامل ببيانات جميع مدخلي البيانات في ملف نصي.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrintDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 233);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnPrintToFile);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طباعة تقرير";
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPrintToFile;
        private System.Windows.Forms.Label lblInstructions;
    }
}
