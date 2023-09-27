namespace MB_Accounting
{
    partial class DepartmentPerformanceForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentPerformanceForm));
            this.pictureBoxBackPink = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxBackYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartType = new System.Windows.Forms.Label();
            this.cbxChartType = new System.Windows.Forms.ComboBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.labelSD = new System.Windows.Forms.Label();
            this.labelEND = new System.Windows.Forms.Label();
            this.lblLess = new System.Windows.Forms.Label();
            this.lblMore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackPink
            // 
            this.pictureBoxBackPink.Image = global::MB_Accounting.Properties.Resources.previous_pink;
            this.pictureBoxBackPink.Location = new System.Drawing.Point(35, 42);
            this.pictureBoxBackPink.Name = "pictureBoxBackPink";
            this.pictureBoxBackPink.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackPink.TabIndex = 57;
            this.pictureBoxBackPink.TabStop = false;
            this.pictureBoxBackPink.Click += new System.EventHandler(this.pictureBoxBackPink_Click);
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 671);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 56;
            this.pictureBoxMoon.TabStop = false;
            this.pictureBoxMoon.Click += new System.EventHandler(this.pictureBoxMoon_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SlateGray;
            this.lblHeading.Location = new System.Drawing.Point(5, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1175, 100);
            this.lblHeading.TabIndex = 55;
            this.lblHeading.Text = "Department Performance";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBackYellow
            // 
            this.pictureBoxBackYellow.Image = global::MB_Accounting.Properties.Resources.previous_yellow;
            this.pictureBoxBackYellow.Location = new System.Drawing.Point(35, 42);
            this.pictureBoxBackYellow.Name = "pictureBoxBackYellow";
            this.pictureBoxBackYellow.Size = new System.Drawing.Size(93, 74);
            this.pictureBoxBackYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackYellow.TabIndex = 59;
            this.pictureBoxBackYellow.TabStop = false;
            this.pictureBoxBackYellow.Click += new System.EventHandler(this.pictureBoxBackYellow_Click);
            // 
            // pictureBoxSun
            // 
            this.pictureBoxSun.Image = global::MB_Accounting.Properties.Resources.sun;
            this.pictureBoxSun.Location = new System.Drawing.Point(1066, 671);
            this.pictureBoxSun.Name = "pictureBoxSun";
            this.pictureBoxSun.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSun.TabIndex = 58;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // mainChart
            // 
            this.mainChart.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(65, 147);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.YValuesPerPoint = 2;
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(700, 586);
            this.mainChart.TabIndex = 60;
            // 
            // lblChartType
            // 
            this.lblChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChartType.BackColor = System.Drawing.Color.Transparent;
            this.lblChartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartType.ForeColor = System.Drawing.Color.HotPink;
            this.lblChartType.Location = new System.Drawing.Point(782, 147);
            this.lblChartType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(389, 30);
            this.lblChartType.TabIndex = 62;
            this.lblChartType.Text = "Chart type";
            this.lblChartType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxChartType
            // 
            this.cbxChartType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxChartType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxChartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChartType.FormattingEnabled = true;
            this.cbxChartType.Items.AddRange(new object[] {
            "Point",
            "Column",
            "Pie",
            "Doughnut"});
            this.cbxChartType.Location = new System.Drawing.Point(783, 183);
            this.cbxChartType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxChartType.Name = "cbxChartType";
            this.cbxChartType.Size = new System.Drawing.Size(388, 33);
            this.cbxChartType.TabIndex = 61;
            this.cbxChartType.SelectedIndexChanged += new System.EventHandler(this.cbxChartType_SelectedIndexChanged);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFilter.Location = new System.Drawing.Point(783, 315);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(388, 31);
            this.tbxFilter.TabIndex = 64;
            this.tbxFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.HotPink;
            this.lblFilter.Location = new System.Drawing.Point(782, 229);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(389, 30);
            this.lblFilter.TabIndex = 65;
            this.lblFilter.Text = "Filter";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxFilter
            // 
            this.cbxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "Name",
            "Manufacturer",
            "Price Bought",
            "Price Selling",
            "Weight",
            "Height",
            "Width",
            "Depth",
            "Description",
            "Store Isle",
            "Warehouse Isle",
            "Quantity"});
            this.cbxFilter.Location = new System.Drawing.Point(783, 263);
            this.cbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(388, 33);
            this.cbxFilter.TabIndex = 66;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd MMM yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(783, 406);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(388, 29);
            this.dtpStart.TabIndex = 67;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd MMM yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(783, 561);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(388, 29);
            this.dtpEnd.TabIndex = 68;
            // 
            // labelSD
            // 
            this.labelSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSD.BackColor = System.Drawing.Color.Transparent;
            this.labelSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSD.ForeColor = System.Drawing.Color.HotPink;
            this.labelSD.Location = new System.Drawing.Point(782, 362);
            this.labelSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSD.Name = "labelSD";
            this.labelSD.Size = new System.Drawing.Size(389, 30);
            this.labelSD.TabIndex = 69;
            this.labelSD.Text = "Start";
            this.labelSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEND
            // 
            this.labelEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEND.BackColor = System.Drawing.Color.Transparent;
            this.labelEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEND.ForeColor = System.Drawing.Color.HotPink;
            this.labelEND.Location = new System.Drawing.Point(782, 514);
            this.labelEND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEND.Name = "labelEND";
            this.labelEND.Size = new System.Drawing.Size(389, 30);
            this.labelEND.TabIndex = 70;
            this.labelEND.Text = "End";
            this.labelEND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLess
            // 
            this.lblLess.AutoSize = true;
            this.lblLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLess.Location = new System.Drawing.Point(851, 461);
            this.lblLess.Name = "lblLess";
            this.lblLess.Size = new System.Drawing.Size(38, 39);
            this.lblLess.TabIndex = 71;
            this.lblLess.Text = "<";
            this.lblLess.Click += new System.EventHandler(this.lblLess_Click);
            // 
            // lblMore
            // 
            this.lblMore.AutoSize = true;
            this.lblMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMore.Location = new System.Drawing.Point(1059, 461);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(38, 39);
            this.lblMore.TabIndex = 72;
            this.lblMore.Text = ">";
            this.lblMore.Click += new System.EventHandler(this.lblMore_Click);
            // 
            // DepartmentPerformanceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblMore);
            this.Controls.Add(this.lblLess);
            this.Controls.Add(this.labelEND);
            this.Controls.Add(this.labelSD);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.cbxChartType);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.pictureBoxBackPink);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxBackYellow);
            this.Controls.Add(this.pictureBoxSun);
            this.Controls.Add(this.lblHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentPerformanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazzar Accounting - Department Performance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackPink;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxBackYellow;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.ComboBox cbxChartType;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label labelSD;
        private System.Windows.Forms.Label labelEND;
        private System.Windows.Forms.Label lblLess;
        private System.Windows.Forms.Label lblMore;
    }
}