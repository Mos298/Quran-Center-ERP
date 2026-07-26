namespace النظام_النهائي
{
    partial class CentersUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.showLabel = new System.Windows.Forms.Label();
            this.showCombo = new System.Windows.Forms.ComboBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.page1Button = new System.Windows.Forms.Button();
            this.page2Button = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.dgvCenters = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contentTableLayoutPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenters)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(166)))), ((int)(((byte)(98)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(27, -130);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1524, 23);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1064, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "الصفحة الرئيسية / الاعدادات / إدارة الحلقات";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(166)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 57);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصفحة الرئيسية / الاعدادات / إدارة المراكز  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.contentTableLayoutPanel);
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1590, 1053);
            this.panel5.TabIndex = 6;
            // 
            // contentTableLayoutPanel
            // 
            this.contentTableLayoutPanel.ColumnCount = 1;
            this.contentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentTableLayoutPanel.Controls.Add(this.actionsPanel, 0, 0);
            this.contentTableLayoutPanel.Controls.Add(this.dgvCenters, 0, 1);
            this.contentTableLayoutPanel.Controls.Add(this.paginationPanel, 0, 2);
            this.contentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.contentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.contentTableLayoutPanel.Name = "contentTableLayoutPanel";
            this.contentTableLayoutPanel.RowCount = 3;
            this.contentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.contentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.contentTableLayoutPanel.Size = new System.Drawing.Size(1590, 1053);
            this.contentTableLayoutPanel.TabIndex = 6;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.addButton);
            this.actionsPanel.Controls.Add(this.editButton);
            this.actionsPanel.Controls.Add(this.deleteButton);
            this.actionsPanel.Controls.Add(this.printButton);
            this.actionsPanel.Controls.Add(this.searchLabel);
            this.actionsPanel.Controls.Add(this.searchBox);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsPanel.Location = new System.Drawing.Point(5, 5);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new System.Windows.Forms.Padding(15, 18, 15, 18);
            this.actionsPanel.Size = new System.Drawing.Size(1580, 110);
            this.actionsPanel.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(166)))), ((int)(((byte)(98)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(499, 38);
            this.addButton.Margin = new System.Windows.Forms.Padding(5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(151, 52);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "إضافة";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.editButton.Location = new System.Drawing.Point(338, 37);
            this.editButton.Margin = new System.Windows.Forms.Padding(5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(151, 52);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "تعديل";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.deleteButton.Location = new System.Drawing.Point(182, 38);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(151, 52);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(21, 38);
            this.printButton.Margin = new System.Windows.Forms.Padding(5);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(151, 52);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "🖨️ طباعة";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(1508, 49);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(37, 20);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "بحث";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(956, 37);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(299, 26);
            this.searchBox.TabIndex = 5;
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.showLabel);
            this.paginationPanel.Controls.Add(this.showCombo);
            this.paginationPanel.Controls.Add(this.prevButton);
            this.paginationPanel.Controls.Add(this.page1Button);
            this.paginationPanel.Controls.Add(this.page2Button);
            this.paginationPanel.Controls.Add(this.nextButton);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginationPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginationPanel.Location = new System.Drawing.Point(5, 944);
            this.paginationPanel.Margin = new System.Windows.Forms.Padding(5);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Padding = new System.Windows.Forms.Padding(15, 18, 15, 18);
            this.paginationPanel.Size = new System.Drawing.Size(1580, 104);
            this.paginationPanel.TabIndex = 4;
            // 
            // showLabel
            // 
            this.showLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showLabel.AutoSize = true;
            this.showLabel.Location = new System.Drawing.Point(1448, 32);
            this.showLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(71, 17);
            this.showLabel.TabIndex = 0;
            this.showLabel.Text = "إظهار أسطر";
            // 
            // showCombo
            // 
            this.showCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showCombo.FormattingEnabled = true;
            this.showCombo.Location = new System.Drawing.Point(1326, 26);
            this.showCombo.Margin = new System.Windows.Forms.Padding(5);
            this.showCombo.Name = "showCombo";
            this.showCombo.Size = new System.Drawing.Size(103, 25);
            this.showCombo.TabIndex = 1;
            this.showCombo.Text = "10";
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.prevButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.prevButton.Location = new System.Drawing.Point(19, 26);
            this.prevButton.Margin = new System.Windows.Forms.Padding(5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(105, 52);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "السابق";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // page1Button
            // 
            this.page1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.page1Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.page1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page1Button.ForeColor = System.Drawing.Color.White;
            this.page1Button.Location = new System.Drawing.Point(134, 26);
            this.page1Button.Margin = new System.Windows.Forms.Padding(5);
            this.page1Button.Name = "page1Button";
            this.page1Button.Size = new System.Drawing.Size(60, 52);
            this.page1Button.TabIndex = 3;
            this.page1Button.Text = "1";
            this.page1Button.UseVisualStyleBackColor = false;
            // 
            // page2Button
            // 
            this.page2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.page2Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.page2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.page2Button.Location = new System.Drawing.Point(202, 26);
            this.page2Button.Margin = new System.Windows.Forms.Padding(5);
            this.page2Button.Name = "page2Button";
            this.page2Button.Size = new System.Drawing.Size(60, 52);
            this.page2Button.TabIndex = 4;
            this.page2Button.Text = "2";
            this.page2Button.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.nextButton.Location = new System.Drawing.Point(271, 26);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(105, 52);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "التالي";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // dgvCenters
            // 
            this.dgvCenters.AllowUserToResizeRows = false;
            this.dgvCenters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCenters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenters.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvCenters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCenters.Location = new System.Drawing.Point(5, 125);
            this.dgvCenters.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCenters.Name = "dgvCenters";
            this.dgvCenters.RowHeadersWidth = 51;
            this.dgvCenters.RowTemplate.Height = 26;
            this.dgvCenters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCenters.Size = new System.Drawing.Size(1580, 809);
            this.dgvCenters.TabIndex = 5;
            this.dgvCenters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CentersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CentersUC";
            this.Size = new System.Drawing.Size(1265, 907);
            this.Load += new System.EventHandler(this.CentersUC_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.contentTableLayoutPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.paginationPanel.ResumeLayout(false);
            this.paginationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel contentTableLayoutPanel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.ComboBox showCombo;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button page1Button;
        private System.Windows.Forms.Button page2Button;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.DataGridView dgvCenters;
    }
}
