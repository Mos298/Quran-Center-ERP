namespace النظام_النهائي
{
    partial class student_C
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.showLabel = new System.Windows.Forms.Label();
            this.showCombo = new System.Windows.Forms.ComboBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.page1Button = new System.Windows.Forms.Button();
            this.page2Button = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contentTableLayoutPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paginationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(166)))), ((int)(((byte)(98)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(23, -97);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1312, 13);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(928, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "الصفحة الرئيسية / الاعدادات / إدارة الحلقات";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(166)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 51);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1191, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصفحة الرئيسية / الطلاب ";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.contentTableLayoutPanel);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1355, 802);
            this.panel5.TabIndex = 6;
            // 
            // contentTableLayoutPanel
            // 
            this.contentTableLayoutPanel.ColumnCount = 1;
            this.contentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentTableLayoutPanel.Controls.Add(this.actionsPanel, 0, 0);
            this.contentTableLayoutPanel.Controls.Add(this.dataGridView1, 0, 1);
            this.contentTableLayoutPanel.Controls.Add(this.paginationPanel, 0, 2);
            this.contentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTableLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.contentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contentTableLayoutPanel.Name = "contentTableLayoutPanel";
            this.contentTableLayoutPanel.RowCount = 3;
            this.contentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.contentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.contentTableLayoutPanel.Size = new System.Drawing.Size(1355, 802);
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
            this.actionsPanel.Location = new System.Drawing.Point(5, 4);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new System.Windows.Forms.Padding(13, 13, 13, 13);
            this.actionsPanel.Size = new System.Drawing.Size(1345, 104);
            this.actionsPanel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 597);
            this.dataGridView1.TabIndex = 5;
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
            this.paginationPanel.Location = new System.Drawing.Point(5, 721);
            this.paginationPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Padding = new System.Windows.Forms.Padding(13, 13, 13, 13);
            this.paginationPanel.Size = new System.Drawing.Size(1345, 77);
            this.paginationPanel.TabIndex = 4;
            // 
            // showLabel
            // 
            this.showLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showLabel.AutoSize = true;
            this.showLabel.Location = new System.Drawing.Point(1235, 24);
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
            this.showCombo.Location = new System.Drawing.Point(1134, 20);
            this.showCombo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.showCombo.Name = "showCombo";
            this.showCombo.Size = new System.Drawing.Size(87, 25);
            this.showCombo.TabIndex = 1;
            this.showCombo.Text = "10";
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.prevButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.prevButton.Location = new System.Drawing.Point(15, 20);
            this.prevButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(87, 39);
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
            this.page1Button.Location = new System.Drawing.Point(112, 20);
            this.page1Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.page1Button.Name = "page1Button";
            this.page1Button.Size = new System.Drawing.Size(50, 39);
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
            this.page2Button.Location = new System.Drawing.Point(168, 20);
            this.page2Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.page2Button.Name = "page2Button";
            this.page2Button.Size = new System.Drawing.Size(50, 39);
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
            this.nextButton.Location = new System.Drawing.Point(225, 20);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(87, 39);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "التالي";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(166)))), ((int)(((byte)(98)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addButton.Location = new System.Drawing.Point(1210, 35);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 39);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "إضافة";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.editButton.Location = new System.Drawing.Point(941, 35);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(125, 39);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "تعديل";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.deleteButton.Location = new System.Drawing.Point(1075, 35);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 39);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(332, 35);
            this.printButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(125, 39);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "🖨️ طباعة";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(273, 35);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(32, 17);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "بحث";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 35);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(249, 25);
            this.searchBox.TabIndex = 11;
            // 
            // student_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "student_C";
            this.Size = new System.Drawing.Size(1355, 850);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.contentTableLayoutPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paginationPanel.ResumeLayout(false);
            this.paginationPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.ComboBox showCombo;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button page1Button;
        private System.Windows.Forms.Button page2Button;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
    }
}
