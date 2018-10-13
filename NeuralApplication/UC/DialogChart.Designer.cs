namespace Neural.UC
{
    partial class DialogChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPoints = new System.Windows.Forms.NumericUpDown();
            this.bShow = new System.Windows.Forms.Button();
            this.cbChartType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShowValues = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lPointDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // chChart
            // 
            this.chChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chChart.ChartAreas.Add(chartArea3);
            this.chChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Name = "Learning progress";
            this.chChart.Legends.Add(legend3);
            this.chChart.Location = new System.Drawing.Point(3, 3);
            this.chChart.Name = "chChart";
            this.chChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series3.CustomProperties = "IsXAxisQuantitative=False, LabelStyle=Top";
            series3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelBackColor = System.Drawing.Color.FloralWhite;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.Legend = "Learning progress";
            series3.MarkerColor = System.Drawing.Color.RoyalBlue;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "RMS errors";
            series3.ShadowColor = System.Drawing.Color.Silver;
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chChart.Series.Add(series3);
            this.chChart.Size = new System.Drawing.Size(1036, 440);
            this.chChart.TabIndex = 0;
            this.chChart.Text = "Learning progress";
            title3.Name = "Learning progress";
            this.chChart.Titles.Add(title3);
            this.chChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChChart_MouseMove);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Goldenrod;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(886, 484);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 25);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Close";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Range from:";
            // 
            // nudFrom
            // 
            this.nudFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudFrom.Location = new System.Drawing.Point(99, 449);
            this.nudFrom.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(116, 25);
            this.nudFrom.TabIndex = 1;
            this.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrom.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // nudTo
            // 
            this.nudTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudTo.Location = new System.Drawing.Point(248, 449);
            this.nudTo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(116, 25);
            this.nudTo.TabIndex = 2;
            this.nudTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTo.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTo.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(221, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "to:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(370, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Points:";
            // 
            // nudPoints
            // 
            this.nudPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudPoints.Location = new System.Drawing.Point(419, 449);
            this.nudPoints.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPoints.Name = "nudPoints";
            this.nudPoints.Size = new System.Drawing.Size(68, 25);
            this.nudPoints.TabIndex = 3;
            this.nudPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPoints.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPoints.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // bShow
            // 
            this.bShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bShow.BackColor = System.Drawing.Color.RoyalBlue;
            this.bShow.FlatAppearance.BorderSize = 0;
            this.bShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bShow.ForeColor = System.Drawing.Color.White;
            this.bShow.Location = new System.Drawing.Point(334, 480);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(153, 25);
            this.bShow.TabIndex = 4;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = false;
            this.bShow.Click += new System.EventHandler(this.BShow_Click);
            // 
            // cbChartType
            // 
            this.cbChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbChartType.BackColor = System.Drawing.Color.White;
            this.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChartType.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbChartType.FormattingEnabled = true;
            this.cbChartType.Items.AddRange(new object[] {
            "point",
            "line",
            "spine",
            "column"});
            this.cbChartType.Location = new System.Drawing.Point(99, 484);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Size = new System.Drawing.Size(116, 21);
            this.cbChartType.TabIndex = 40;
            this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.CbChartType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Chart type:";
            // 
            // cbShowValues
            // 
            this.cbShowValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowValues.AutoSize = true;
            this.cbShowValues.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbShowValues.Location = new System.Drawing.Point(224, 484);
            this.cbShowValues.Name = "cbShowValues";
            this.cbShowValues.Size = new System.Drawing.Size(103, 21);
            this.cbShowValues.TabIndex = 42;
            this.cbShowValues.Text = "Show values*";
            this.cbShowValues.UseVisualStyleBackColor = true;
            this.cbShowValues.CheckedChanged += new System.EventHandler(this.CbShowValues_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(493, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "*Values are showing when points <= 100";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(493, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Point details:";
            // 
            // lPointDetails
            // 
            this.lPointDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lPointDetails.AutoSize = true;
            this.lPointDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPointDetails.Location = new System.Drawing.Point(572, 451);
            this.lPointDetails.Name = "lPointDetails";
            this.lPointDetails.Size = new System.Drawing.Size(78, 17);
            this.lPointDetails.TabIndex = 45;
            this.lPointDetails.Text = "select point";
            // 
            // DialogChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lPointDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbShowValues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChartType);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.nudPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.nudFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.chChart);
            this.Name = "DialogChart";
            this.Size = new System.Drawing.Size(1042, 512);
            ((System.ComponentModel.ISupportInitialize)(this.chChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chChart;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPoints;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.ComboBox cbChartType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbShowValues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lPointDetails;
    }
}
