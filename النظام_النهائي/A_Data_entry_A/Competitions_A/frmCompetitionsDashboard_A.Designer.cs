namespace النظام_النهائي
{
    partial class frmCompetitionsDashboard_A
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnActiveCompetitions = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnCompetitions = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.chartCompetitions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpTotalCandidates = new System.Windows.Forms.GroupBox();
            this.lblTotalCandidates = new System.Windows.Forms.Label();
            this.grpActiveCompetitions = new System.Windows.Forms.GroupBox();
            this.lblActiveCompetitionsStat = new System.Windows.Forms.Label();
            this.grpTotalCompetitions = new System.Windows.Forms.GroupBox();
            this.lblTotalCompetitions = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlCompetitions = new System.Windows.Forms.Panel();
            this.dgvCompetitions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.lblCompetitionsTitle = new System.Windows.Forms.Label();
            this.pnlCandidates = new System.Windows.Forms.Panel();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCandidatesTitle = new System.Windows.Forms.Label();
            this.pnlActiveResults = new System.Windows.Forms.Panel();
            this.flpActiveCompetitions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblActiveCompetitionsTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompetitions)).BeginInit();
            this.grpTotalCandidates.SuspendLayout();
            this.grpActiveCompetitions.SuspendLayout();
            this.grpTotalCompetitions.SuspendLayout();
            this.pnlCompetitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCandidates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlActiveResults.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnActiveCompetitions);
            this.pnlSidebar.Controls.Add(this.btnCandidates);
            this.pnlSidebar.Controls.Add(this.btnCompetitions);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlSidebar.Size = new System.Drawing.Size(175, 761);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnActiveCompetitions
            // 
            this.btnActiveCompetitions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActiveCompetitions.FlatAppearance.BorderSize = 0;
            this.btnActiveCompetitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveCompetitions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnActiveCompetitions.Location = new System.Drawing.Point(0, 210);
            this.btnActiveCompetitions.Name = "btnActiveCompetitions";
            this.btnActiveCompetitions.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.btnActiveCompetitions.Size = new System.Drawing.Size(175, 50);
            this.btnActiveCompetitions.TabIndex = 4;
            this.btnActiveCompetitions.Text = "المسابقات الحالية";
            this.btnActiveCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActiveCompetitions.UseVisualStyleBackColor = true;
            // 
            // btnCandidates
            // 
            this.btnCandidates.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCandidates.FlatAppearance.BorderSize = 0;
            this.btnCandidates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidates.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCandidates.Location = new System.Drawing.Point(0, 160);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.btnCandidates.Size = new System.Drawing.Size(175, 50);
            this.btnCandidates.TabIndex = 3;
            this.btnCandidates.Text = "الطلاب المرشحون";
            this.btnCandidates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCandidates.UseVisualStyleBackColor = true;
            // 
            // btnCompetitions
            // 
            this.btnCompetitions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetitions.FlatAppearance.BorderSize = 0;
            this.btnCompetitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetitions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCompetitions.Location = new System.Drawing.Point(0, 110);
            this.btnCompetitions.Name = "btnCompetitions";
            this.btnCompetitions.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.btnCompetitions.Size = new System.Drawing.Size(175, 50);
            this.btnCompetitions.TabIndex = 2;
            this.btnCompetitions.Text = "إدارة المسابقات";
            this.btnCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompetitions.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.Location = new System.Drawing.Point(0, 60);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.btnDashboard.Size = new System.Drawing.Size(175, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "لوحة التحكم";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(175, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نظام المسابقات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainContent.Controls.Add(this.pnlDashboard);
            this.pnlMainContent.Controls.Add(this.pnlCompetitions);
            this.pnlMainContent.Controls.Add(this.pnlCandidates);
            this.pnlMainContent.Controls.Add(this.pnlActiveResults);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(175, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.pnlMainContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMainContent.Size = new System.Drawing.Size(773, 761);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.chartCompetitions);
            this.pnlDashboard.Controls.Add(this.grpTotalCandidates);
            this.pnlDashboard.Controls.Add(this.grpActiveCompetitions);
            this.pnlDashboard.Controls.Add(this.grpTotalCompetitions);
            this.pnlDashboard.Controls.Add(this.lblDashboardTitle);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(18, 20);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(737, 721);
            this.pnlDashboard.TabIndex = 0;
            // 
            // chartCompetitions
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCompetitions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCompetitions.Legends.Add(legend1);
            this.chartCompetitions.Location = new System.Drawing.Point(13, 230);
            this.chartCompetitions.Name = "chartCompetitions";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCompetitions.Series.Add(series1);
            this.chartCompetitions.Size = new System.Drawing.Size(698, 411);
            this.chartCompetitions.TabIndex = 4;
            this.chartCompetitions.Text = "chart1";
            // 
            // grpTotalCandidates
            // 
            this.grpTotalCandidates.Controls.Add(this.lblTotalCandidates);
            this.grpTotalCandidates.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpTotalCandidates.Location = new System.Drawing.Point(97, 80);
            this.grpTotalCandidates.Name = "grpTotalCandidates";
            this.grpTotalCandidates.Size = new System.Drawing.Size(175, 100);
            this.grpTotalCandidates.TabIndex = 3;
            this.grpTotalCandidates.TabStop = false;
            this.grpTotalCandidates.Text = "إجمالي الطلاب";
            // 
            // lblTotalCandidates
            // 
            this.lblTotalCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCandidates.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCandidates.Location = new System.Drawing.Point(3, 26);
            this.lblTotalCandidates.Name = "lblTotalCandidates";
            this.lblTotalCandidates.Size = new System.Drawing.Size(169, 71);
            this.lblTotalCandidates.TabIndex = 0;
            this.lblTotalCandidates.Text = "0";
            this.lblTotalCandidates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpActiveCompetitions
            // 
            this.grpActiveCompetitions.Controls.Add(this.lblActiveCompetitionsStat);
            this.grpActiveCompetitions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpActiveCompetitions.Location = new System.Drawing.Point(282, 80);
            this.grpActiveCompetitions.Name = "grpActiveCompetitions";
            this.grpActiveCompetitions.Size = new System.Drawing.Size(175, 100);
            this.grpActiveCompetitions.TabIndex = 2;
            this.grpActiveCompetitions.TabStop = false;
            this.grpActiveCompetitions.Text = "المسابقات النشطة";
            // 
            // lblActiveCompetitionsStat
            // 
            this.lblActiveCompetitionsStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveCompetitionsStat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveCompetitionsStat.Location = new System.Drawing.Point(3, 26);
            this.lblActiveCompetitionsStat.Name = "lblActiveCompetitionsStat";
            this.lblActiveCompetitionsStat.Size = new System.Drawing.Size(169, 71);
            this.lblActiveCompetitionsStat.TabIndex = 0;
            this.lblActiveCompetitionsStat.Text = "0";
            this.lblActiveCompetitionsStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTotalCompetitions
            // 
            this.grpTotalCompetitions.Controls.Add(this.lblTotalCompetitions);
            this.grpTotalCompetitions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpTotalCompetitions.Location = new System.Drawing.Point(466, 80);
            this.grpTotalCompetitions.Name = "grpTotalCompetitions";
            this.grpTotalCompetitions.Size = new System.Drawing.Size(175, 100);
            this.grpTotalCompetitions.TabIndex = 1;
            this.grpTotalCompetitions.TabStop = false;
            this.grpTotalCompetitions.Text = "إجمالي المسابقات";
            this.grpTotalCompetitions.Enter += new System.EventHandler(this.grpTotalCompetitions_Enter);
            // 
            // lblTotalCompetitions
            // 
            this.lblTotalCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCompetitions.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCompetitions.Location = new System.Drawing.Point(3, 26);
            this.lblTotalCompetitions.Name = "lblTotalCompetitions";
            this.lblTotalCompetitions.Size = new System.Drawing.Size(169, 71);
            this.lblTotalCompetitions.TabIndex = 0;
            this.lblTotalCompetitions.Text = "0";
            this.lblTotalCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(737, 60);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "لوحة التحكم";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCompetitions
            // 
            this.pnlCompetitions.Controls.Add(this.dgvCompetitions);
            this.pnlCompetitions.Controls.Add(this.panel1);
            this.pnlCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompetitions.Location = new System.Drawing.Point(18, 20);
            this.pnlCompetitions.Name = "pnlCompetitions";
            this.pnlCompetitions.Size = new System.Drawing.Size(737, 721);
            this.pnlCompetitions.TabIndex = 1;
            this.pnlCompetitions.Visible = false;
            // 
            // dgvCompetitions
            // 
            this.dgvCompetitions.AllowUserToAddRows = false;
            this.dgvCompetitions.AllowUserToDeleteRows = false;
            this.dgvCompetitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompetitions.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompetitions.Location = new System.Drawing.Point(0, 60);
            this.dgvCompetitions.Name = "dgvCompetitions";
            this.dgvCompetitions.ReadOnly = true;
            this.dgvCompetitions.RowHeadersWidth = 51;
            this.dgvCompetitions.RowTemplate.Height = 24;
            this.dgvCompetitions.Size = new System.Drawing.Size(737, 661);
            this.dgvCompetitions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCompetition);
            this.panel1.Controls.Add(this.lblCompetitionsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCompetition
            // 
            this.btnAddCompetition.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddCompetition.FlatAppearance.BorderSize = 0;
            this.btnAddCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompetition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCompetition.ForeColor = System.Drawing.Color.White;
            this.btnAddCompetition.Location = new System.Drawing.Point(13, 15);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(140, 35);
            this.btnAddCompetition.TabIndex = 1;
            this.btnAddCompetition.Text = "إنشاء مسابقة جديدة";
            this.btnAddCompetition.UseVisualStyleBackColor = false;
            // 
            // lblCompetitionsTitle
            // 
            this.lblCompetitionsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompetitionsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCompetitionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCompetitionsTitle.Name = "lblCompetitionsTitle";
            this.lblCompetitionsTitle.Size = new System.Drawing.Size(737, 60);
            this.lblCompetitionsTitle.TabIndex = 0;
            this.lblCompetitionsTitle.Text = "إدارة المسابقات";
            this.lblCompetitionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCandidates
            // 
            this.pnlCandidates.Controls.Add(this.dgvCandidates);
            this.pnlCandidates.Controls.Add(this.panel2);
            this.pnlCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCandidates.Location = new System.Drawing.Point(18, 20);
            this.pnlCandidates.Name = "pnlCandidates";
            this.pnlCandidates.Size = new System.Drawing.Size(737, 721);
            this.pnlCandidates.TabIndex = 2;
            this.pnlCandidates.Visible = false;
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidates.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidates.Location = new System.Drawing.Point(0, 60);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowHeadersWidth = 51;
            this.dgvCandidates.RowTemplate.Height = 24;
            this.dgvCandidates.Size = new System.Drawing.Size(737, 661);
            this.dgvCandidates.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCandidatesTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 60);
            this.panel2.TabIndex = 1;
            // 
            // lblCandidatesTitle
            // 
            this.lblCandidatesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandidatesTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCandidatesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCandidatesTitle.Name = "lblCandidatesTitle";
            this.lblCandidatesTitle.Size = new System.Drawing.Size(737, 60);
            this.lblCandidatesTitle.TabIndex = 0;
            this.lblCandidatesTitle.Text = "الطلاب المرشحون";
            this.lblCandidatesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlActiveResults
            // 
            this.pnlActiveResults.Controls.Add(this.flpActiveCompetitions);
            this.pnlActiveResults.Controls.Add(this.panel3);
            this.pnlActiveResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActiveResults.Location = new System.Drawing.Point(18, 20);
            this.pnlActiveResults.Name = "pnlActiveResults";
            this.pnlActiveResults.Size = new System.Drawing.Size(737, 721);
            this.pnlActiveResults.TabIndex = 3;
            this.pnlActiveResults.Visible = false;
            // 
            // flpActiveCompetitions
            // 
            this.flpActiveCompetitions.AutoScroll = true;
            this.flpActiveCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActiveCompetitions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpActiveCompetitions.Location = new System.Drawing.Point(0, 60);
            this.flpActiveCompetitions.Name = "flpActiveCompetitions";
            this.flpActiveCompetitions.Size = new System.Drawing.Size(737, 661);
            this.flpActiveCompetitions.TabIndex = 2;
            this.flpActiveCompetitions.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblActiveCompetitionsTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 60);
            this.panel3.TabIndex = 1;
            // 
            // lblActiveCompetitionsTitle
            // 
            this.lblActiveCompetitionsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveCompetitionsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblActiveCompetitionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblActiveCompetitionsTitle.Name = "lblActiveCompetitionsTitle";
            this.lblActiveCompetitionsTitle.Size = new System.Drawing.Size(737, 60);
            this.lblActiveCompetitionsTitle.TabIndex = 0;
            this.lblActiveCompetitionsTitle.Text = "المسابقات الحالية والنتائج";
            this.lblActiveCompetitionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCompetitionsDashboard_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 761);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmCompetitionsDashboard_A";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة المسابقات";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCompetitions)).EndInit();
            this.grpTotalCandidates.ResumeLayout(false);
            this.grpActiveCompetitions.ResumeLayout(false);
            this.grpTotalCompetitions.ResumeLayout(false);
            this.pnlCompetitions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlCandidates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlActiveResults.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnActiveCompetitions;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnCompetitions;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlCompetitions;
        private System.Windows.Forms.Panel pnlCandidates;
        private System.Windows.Forms.Panel pnlActiveResults;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.GroupBox grpTotalCandidates;
        private System.Windows.Forms.Label lblTotalCandidates;
        private System.Windows.Forms.GroupBox grpActiveCompetitions;
        private System.Windows.Forms.Label lblActiveCompetitionsStat;
        private System.Windows.Forms.GroupBox grpTotalCompetitions;
        private System.Windows.Forms.Label lblTotalCompetitions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompetitions;
        private System.Windows.Forms.DataGridView dgvCompetitions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.Label lblCompetitionsTitle;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCandidatesTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblActiveCompetitionsTitle;
        private System.Windows.Forms.FlowLayoutPanel flpActiveCompetitions;
    }
}
