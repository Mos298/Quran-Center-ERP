namespace النظام_النهائي
{
    partial class frmEditStudent
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAndActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFullName.Location = new System.Drawing.Point(14, 43);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(303, 29);
            this.txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل رقم القيد ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveAndActivate
            // 
            this.btnSaveAndActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveAndActivate.FlatAppearance.BorderSize = 0;
            this.btnSaveAndActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndActivate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveAndActivate.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndActivate.Location = new System.Drawing.Point(14, 98);
            this.btnSaveAndActivate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAndActivate.Name = "btnSaveAndActivate";
            this.btnSaveAndActivate.Size = new System.Drawing.Size(303, 49);
            this.btnSaveAndActivate.TabIndex = 2;
            this.btnSaveAndActivate.Text = "حفظ وتنشيط";
            this.btnSaveAndActivate.UseVisualStyleBackColor = false;
            this.btnSaveAndActivate.Click += new System.EventHandler(this.btnSaveAndActivate_Click);
            // 
            // frmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 174);
            this.Controls.Add(this.btnSaveAndActivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل وتنشيط طالب";
            this.Load += new System.EventHandler(this.frmEditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAndActivate;
        // ... Add all other control declarations ...
    }
}
