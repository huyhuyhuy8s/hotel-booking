namespace Console
{
    partial class UCStatisticRoom
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStatisticRoom));
            this.cTop3Customers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalRevenua = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.lblNumofOrder = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtDateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtDateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btLast7days = new Guna.UI2.WinForms.Guna2Button();
            this.btYesterday = new Guna.UI2.WinForms.Guna2Button();
            this.btLast30days = new Guna.UI2.WinForms.Guna2Button();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btDashboard = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProceeds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.lblNumCus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cTop3Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cStatistic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTop3Customers
            // 
            this.cTop3Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.cTop3Customers.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            legend1.Name = "Legend1";
            this.cTop3Customers.Legends.Add(legend1);
            this.cTop3Customers.Location = new System.Drawing.Point(938, 189);
            this.cTop3Customers.Name = "cTop3Customers";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Customers";
            this.cTop3Customers.Series.Add(series1);
            this.cTop3Customers.Size = new System.Drawing.Size(369, 277);
            this.cTop3Customers.TabIndex = 15;
            this.cTop3Customers.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            title1.Name = "The Top Customers";
            title1.Text = "The Top Customers";
            this.cTop3Customers.Titles.Add(title1);
            // 
            // cStatistic
            // 
            this.cStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.cStatistic.BorderlineWidth = 0;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            chartArea2.AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            chartArea2.Name = "ChartArea1";
            this.cStatistic.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            legend2.Name = "Legend1";
            this.cStatistic.Legends.Add(legend2);
            this.cStatistic.Location = new System.Drawing.Point(3, 189);
            this.cStatistic.Name = "cStatistic";
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            series2.EmptyPointStyle.Color = System.Drawing.Color.White;
            series2.EmptyPointStyle.LabelBackColor = System.Drawing.Color.White;
            series2.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.White;
            series2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Profit";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.cStatistic.Series.Add(series2);
            this.cStatistic.Size = new System.Drawing.Size(931, 455);
            this.cStatistic.TabIndex = 13;
            this.cStatistic.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            title2.Name = "The Total Revenue";
            title2.Text = "Gross Revenue";
            this.cStatistic.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblTotalRevenua);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(667, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 78);
            this.panel1.TabIndex = 12;
            // 
            // lblTotalRevenua
            // 
            this.lblTotalRevenua.AutoSize = true;
            this.lblTotalRevenua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalRevenua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTotalRevenua.Location = new System.Drawing.Point(85, 42);
            this.lblTotalRevenua.Name = "lblTotalRevenua";
            this.lblTotalRevenua.Size = new System.Drawing.Size(19, 21);
            this.lblTotalRevenua.TabIndex = 1;
            this.lblTotalRevenua.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTotal.Location = new System.Drawing.Point(85, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 21);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Revenue";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblNumOrders);
            this.panel2.Controls.Add(this.lblNumofOrder);
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 78);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblNumOrders.Location = new System.Drawing.Point(82, 42);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(19, 21);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "0";
            // 
            // lblNumofOrder
            // 
            this.lblNumofOrder.AutoSize = true;
            this.lblNumofOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumofOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblNumofOrder.Location = new System.Drawing.Point(82, 0);
            this.lblNumofOrder.Name = "lblNumofOrder";
            this.lblNumofOrder.Size = new System.Drawing.Size(147, 21);
            this.lblNumofOrder.TabIndex = 0;
            this.lblNumofOrder.Text = "Number of Orders";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Controls.Add(this.dtDateTo);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtDateFrom);
            this.guna2CustomGradientPanel1.Controls.Add(this.btLast7days);
            this.guna2CustomGradientPanel1.Controls.Add(this.btYesterday);
            this.guna2CustomGradientPanel1.Controls.Add(this.btLast30days);
            this.guna2CustomGradientPanel1.Controls.Add(this.btSearch);
            this.guna2CustomGradientPanel1.Controls.Add(this.btDashboard);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1304, 96);
            this.guna2CustomGradientPanel1.TabIndex = 16;
            // 
            // dtDateTo
            // 
            this.dtDateTo.BackColor = System.Drawing.Color.Transparent;
            this.dtDateTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.dtDateTo.BorderRadius = 10;
            this.dtDateTo.BorderThickness = 1;
            this.dtDateTo.Checked = true;
            this.dtDateTo.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtDateTo.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.dtDateTo.FillColor = System.Drawing.Color.White;
            this.dtDateTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtDateTo.ForeColor = System.Drawing.Color.DimGray;
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Location = new System.Drawing.Point(235, 54);
            this.dtDateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(166, 25);
            this.dtDateTo.TabIndex = 14;
            this.dtDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtDateTo.UseTransparentBackground = true;
            this.dtDateTo.Value = new System.DateTime(2024, 3, 16, 13, 14, 8, 798);
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtDateFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.dtDateFrom.BorderRadius = 10;
            this.dtDateFrom.BorderThickness = 1;
            this.dtDateFrom.Checked = true;
            this.dtDateFrom.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtDateFrom.CheckedState.ForeColor = System.Drawing.Color.DimGray;
            this.dtDateFrom.FillColor = System.Drawing.Color.White;
            this.dtDateFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtDateFrom.ForeColor = System.Drawing.Color.DimGray;
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(41, 54);
            this.dtDateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(166, 25);
            this.dtDateFrom.TabIndex = 13;
            this.dtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtDateFrom.UseTransparentBackground = true;
            this.dtDateFrom.Value = new System.DateTime(2024, 3, 16, 13, 14, 8, 798);
            // 
            // btLast7days
            // 
            this.btLast7days.BorderRadius = 10;
            this.btLast7days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLast7days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLast7days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLast7days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLast7days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btLast7days.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btLast7days.ForeColor = System.Drawing.Color.White;
            this.btLast7days.Location = new System.Drawing.Point(1046, 54);
            this.btLast7days.Name = "btLast7days";
            this.btLast7days.Size = new System.Drawing.Size(87, 25);
            this.btLast7days.TabIndex = 12;
            this.btLast7days.Text = "Last 7 days";
            this.btLast7days.Click += new System.EventHandler(this.BTLast7days_Click);
            // 
            // btYesterday
            // 
            this.btYesterday.BorderRadius = 10;
            this.btYesterday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btYesterday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btYesterday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btYesterday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btYesterday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btYesterday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btYesterday.ForeColor = System.Drawing.Color.White;
            this.btYesterday.Location = new System.Drawing.Point(1148, 54);
            this.btYesterday.Name = "btYesterday";
            this.btYesterday.Size = new System.Drawing.Size(82, 25);
            this.btYesterday.TabIndex = 11;
            this.btYesterday.Text = "Yesterday";
            this.btYesterday.Click += new System.EventHandler(this.BTYesterday_Click);
            // 
            // btLast30days
            // 
            this.btLast30days.BorderRadius = 10;
            this.btLast30days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLast30days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLast30days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLast30days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLast30days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btLast30days.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btLast30days.ForeColor = System.Drawing.Color.White;
            this.btLast30days.Location = new System.Drawing.Point(941, 54);
            this.btLast30days.Name = "btLast30days";
            this.btLast30days.Size = new System.Drawing.Size(90, 25);
            this.btLast30days.TabIndex = 10;
            this.btLast30days.Text = "Last 30 days";
            this.btLast30days.Click += new System.EventHandler(this.BTLast30days_Click);
            // 
            // btSearch
            // 
            this.btSearch.BorderRadius = 10;
            this.btSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(437, 54);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(82, 25);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.BTSearch_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btDashboard.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btDashboard.Location = new System.Drawing.Point(41, 5);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(143, 39);
            this.btDashboard.TabIndex = 0;
            this.btDashboard.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblTotalProceeds);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblNumCustomers);
            this.panel3.Controls.Add(this.lblNumCus);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(938, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 169);
            this.panel3.TabIndex = 14;
            // 
            // lblTotalProceeds
            // 
            this.lblTotalProceeds.AutoSize = true;
            this.lblTotalProceeds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalProceeds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTotalProceeds.Location = new System.Drawing.Point(21, 142);
            this.lblTotalProceeds.Name = "lblTotalProceeds";
            this.lblTotalProceeds.Size = new System.Drawing.Size(19, 21);
            this.lblTotalProceeds.TabIndex = 4;
            this.lblTotalProceeds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total proceeds";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblNumCustomers.Location = new System.Drawing.Point(21, 81);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(19, 21);
            this.lblNumCustomers.TabIndex = 2;
            this.lblNumCustomers.Text = "0";
            // 
            // lblNumCus
            // 
            this.lblNumCus.AutoSize = true;
            this.lblNumCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblNumCus.Location = new System.Drawing.Point(21, 54);
            this.lblNumCus.Name = "lblNumCus";
            this.lblNumCus.Size = new System.Drawing.Size(165, 21);
            this.lblNumCus.TabIndex = 1;
            this.lblNumCus.Text = "Number of Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Counter";
            // 
            // UCStatisticRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cTop3Customers);
            this.Controls.Add(this.cStatistic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "UCStatisticRoom";
            this.Size = new System.Drawing.Size(1310, 647);
            ((System.ComponentModel.ISupportInitialize)(this.cTop3Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cStatistic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cTop3Customers;
        private System.Windows.Forms.DataVisualization.Charting.Chart cStatistic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalRevenua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label lblNumofOrder;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btLast7days;
        private Guna.UI2.WinForms.Guna2Button btYesterday;
        private Guna.UI2.WinForms.Guna2Button btLast30days;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel btDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProceeds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label lblNumCus;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDateFrom;
    }
}
