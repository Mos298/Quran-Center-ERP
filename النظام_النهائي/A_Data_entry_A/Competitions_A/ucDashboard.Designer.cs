namespace النظام_النهائي
{
    partial class ucDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardTotalCandidates = new System.Windows.Forms.Panel();
            this.lblTotalCandidates = new System.Windows.Forms.Label();
            this.lblTotalCandidatesTitle = new System.Windows.Forms.Label();
            this.cardActiveCompetitions = new System.Windows.Forms.Panel();
            this.lblActiveCompetitions = new System.Windows.Forms.Label();
            this.lblActiveCompetitionsTitle = new System.Windows.Forms.Label();
            this.cardTotalCompetitions = new System.Windows.Forms.Panel();
            this.lblTotalCompetitions = new System.Windows.Forms.Label();
            this.lblTotalCompetitionsTitle = new System.Windows.Forms.Label();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chartCompetitions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlCards.SuspendLayout();
            this.cardTotalCandidates.SuspendLayout();
            this.cardActiveCompetitions.SuspendLayout();
            this.cardTotalCompetitions.SuspendLayout();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCards
            // 
            this.pnlCards.ColumnCount = 3;
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCards.Controls.Add(this.cardTotalCandidates, 2, 0);
            this.pnlCards.Controls.Add(this.cardActiveCompetitions, 1, 0);
            this.pnlCards.Controls.Add(this.cardTotalCompetitions, 0, 0);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 0);
            this.pnlCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.RowCount = 1;
            this.pnlCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCards.Size = new System.Drawing.Size(1008, 148);
            this.pnlCards.TabIndex = 0;
            // 
            // cardTotalCandidates
            // 
            this.cardTotalCandidates.BackColor = System.Drawing.Color.White;
            this.cardTotalCandidates.Controls.Add(this.lblTotalCandidates);
            this.cardTotalCandidates.Controls.Add(this.lblTotalCandidatesTitle);
            this.cardTotalCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotalCandidates.Location = new System.Drawing.Point(676, 4);
            this.cardTotalCandidates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardTotalCandidates.Name = "cardTotalCandidates";
            this.cardTotalCandidates.Size = new System.Drawing.Size(328, 140);
            this.cardTotalCandidates.TabIndex = 2;
            // 
            // lblTotalCandidates
            // 
            this.lblTotalCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCandidates.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCandidates.Location = new System.Drawing.Point(0, 43);
            this.lblTotalCandidates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCandidates.Name = "lblTotalCandidates";
            this.lblTotalCandidates.Size = new System.Drawing.Size(328, 97);
            this.lblTotalCandidates.TabIndex = 1;
            this.lblTotalCandidates.Text = "0";
            this.lblTotalCandidates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCandidatesTitle
            // 
            this.lblTotalCandidatesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCandidatesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCandidatesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalCandidatesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalCandidatesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCandidatesTitle.Name = "lblTotalCandidatesTitle";
            this.lblTotalCandidatesTitle.Size = new System.Drawing.Size(328, 43);
            this.lblTotalCandidatesTitle.TabIndex = 0;
            this.lblTotalCandidatesTitle.Text = "إجمالي الطلاب";
            this.lblTotalCandidatesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardActiveCompetitions
            // 
            this.cardActiveCompetitions.BackColor = System.Drawing.Color.White;
            this.cardActiveCompetitions.Controls.Add(this.lblActiveCompetitions);
            this.cardActiveCompetitions.Controls.Add(this.lblActiveCompetitionsTitle);
            this.cardActiveCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActiveCompetitions.Location = new System.Drawing.Point(340, 4);
            this.cardActiveCompetitions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardActiveCompetitions.Name = "cardActiveCompetitions";
            this.cardActiveCompetitions.Size = new System.Drawing.Size(328, 140);
            this.cardActiveCompetitions.TabIndex = 1;
            // 
            // lblActiveCompetitions
            // 
            this.lblActiveCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveCompetitions.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCompetitions.Location = new System.Drawing.Point(0, 43);
            this.lblActiveCompetitions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveCompetitions.Name = "lblActiveCompetitions";
            this.lblActiveCompetitions.Size = new System.Drawing.Size(328, 97);
            this.lblActiveCompetitions.TabIndex = 1;
            this.lblActiveCompetitions.Text = "0";
            this.lblActiveCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveCompetitionsTitle
            // 
            this.lblActiveCompetitionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveCompetitionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCompetitionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblActiveCompetitionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblActiveCompetitionsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveCompetitionsTitle.Name = "lblActiveCompetitionsTitle";
            this.lblActiveCompetitionsTitle.Size = new System.Drawing.Size(328, 43);
            this.lblActiveCompetitionsTitle.TabIndex = 0;
            this.lblActiveCompetitionsTitle.Text = "المسابقات النشطة";
            this.lblActiveCompetitionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTotalCompetitions
            // 
            this.cardTotalCompetitions.BackColor = System.Drawing.Color.White;
            this.cardTotalCompetitions.Controls.Add(this.lblTotalCompetitions);
            this.cardTotalCompetitions.Controls.Add(this.lblTotalCompetitionsTitle);
            this.cardTotalCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotalCompetitions.Location = new System.Drawing.Point(4, 4);
            this.cardTotalCompetitions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardTotalCompetitions.Name = "cardTotalCompetitions";
            this.cardTotalCompetitions.Size = new System.Drawing.Size(328, 140);
            this.cardTotalCompetitions.TabIndex = 0;
            // 
            // lblTotalCompetitions
            // 
            this.lblTotalCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCompetitions.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompetitions.Location = new System.Drawing.Point(0, 43);
            this.lblTotalCompetitions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCompetitions.Name = "lblTotalCompetitions";
            this.lblTotalCompetitions.Size = new System.Drawing.Size(328, 97);
            this.lblTotalCompetitions.TabIndex = 1;
            this.lblTotalCompetitions.Text = "0";
            this.lblTotalCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCompetitionsTitle
            // 
            this.lblTotalCompetitionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCompetitionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompetitionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalCompetitionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalCompetitionsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCompetitionsTitle.Name = "lblTotalCompetitionsTitle";
            this.lblTotalCompetitionsTitle.Size = new System.Drawing.Size(328, 43);
            this.lblTotalCompetitionsTitle.TabIndex = 0;
            this.lblTotalCompetitionsTitle.Text = "إجمالي المسابقات";
            this.lblTotalCompetitionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.Controls.Add(this.chartCompetitions);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 148);
            this.pnlChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlChart.Size = new System.Drawing.Size(1008, 579);
            this.pnlChart.TabIndex = 1;
            // 
            // chartCompetitions
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCompetitions.ChartAreas.Add(chartArea1);
            this.chartCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCompetitions.Legends.Add(legend1);
            this.chartCompetitions.Location = new System.Drawing.Point(12, 12);
            this.chartCompetitions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartCompetitions.Name = "chartCompetitions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCompetitions.Series.Add(series1);
            this.chartCompetitions.Size = new System.Drawing.Size(984, 555);
            this.chartCompetitions.TabIndex = 0;
            this.chartCompetitions.Text = "chart1";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlCards);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1008, 727);
            this.pnlCards.ResumeLayout(false);
            this.cardTotalCandidates.ResumeLayout(false);
            this.cardActiveCompetitions.ResumeLayout(false);
            this.cardTotalCompetitions.ResumeLayout(false);
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCompetitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlCards;
        private System.Windows.Forms.Panel cardTotalCompetitions;
        private System.Windows.Forms.Label lblTotalCompetitionsTitle;
        private System.Windows.Forms.Label lblTotalCompetitions;
        private System.Windows.Forms.Panel cardTotalCandidates;
        private System.Windows.Forms.Label lblTotalCandidates;
        private System.Windows.Forms.Label lblTotalCandidatesTitle;
        private System.Windows.Forms.Panel cardActiveCompetitions;
        private System.Windows.Forms.Label lblActiveCompetitions;
        private System.Windows.Forms.Label lblActiveCompetitionsTitle;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompetitions;
    }
}

