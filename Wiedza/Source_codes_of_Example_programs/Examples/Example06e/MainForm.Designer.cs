namespace RTadeusiewicz.NN.Example06e
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiChartPlotter = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.uiStandardSet = new System.Windows.Forms.RadioButton();
            this.uiCustomSet = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.uiGapSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiGapSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLoadFromFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.uiCycleLength = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.uiOneTeachingCycle = new System.Windows.Forms.Button();
            this.uiRestartTeaching = new System.Windows.Forms.Button();
            this.uiContinuousTeaching = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.uiMethodPerceptron = new System.Windows.Forms.RadioButton();
            this.uiMethodWidrowHoff = new System.Windows.Forms.RadioButton();
            this.uiStepNumber = new System.Windows.Forms.Label();
            this.uiOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGapSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiCycleLength)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.42292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.uiChartPlotter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiStepNumber, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uiChartPlotter
            // 
            this.uiChartPlotter.AxesVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.None;
            this.uiChartPlotter.BackColor = System.Drawing.Color.Blue;
            this.uiChartPlotter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiChartPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiChartPlotter.Location = new System.Drawing.Point(3, 3);
            this.uiChartPlotter.Name = "uiChartPlotter";
            this.tableLayoutPanel1.SetRowSpan(this.uiChartPlotter, 3);
            this.uiChartPlotter.Size = new System.Drawing.Size(248, 248);
            this.uiChartPlotter.TabIndex = 0;
            this.uiChartPlotter.Text = "chartPlotter1";
            this.uiChartPlotter.TicksVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.None;
            this.uiChartPlotter.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("uiChartPlotter.VisibleRectangle")));
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(257, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teaching set";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiStandardSet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiCustomSet, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.uiLoadFromFile, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 76);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(179, 0);
            this.label6.Name = "label6";
            this.tableLayoutPanel2.SetRowSpan(this.label6, 2);
            this.label6.Size = new System.Drawing.Size(2, 63);
            this.label6.TabIndex = 1;
            // 
            // uiStandardSet
            // 
            this.uiStandardSet.AutoSize = true;
            this.uiStandardSet.Checked = true;
            this.uiStandardSet.Location = new System.Drawing.Point(3, 3);
            this.uiStandardSet.Name = "uiStandardSet";
            this.uiStandardSet.Size = new System.Drawing.Size(85, 17);
            this.uiStandardSet.TabIndex = 0;
            this.uiStandardSet.TabStop = true;
            this.uiStandardSet.Text = "Standard set";
            this.uiStandardSet.UseVisualStyleBackColor = true;
            this.uiStandardSet.CheckedChanged += new System.EventHandler(this.uiStandardSet_CheckedChanged);
            // 
            // uiCustomSet
            // 
            this.uiCustomSet.AutoSize = true;
            this.uiCustomSet.Location = new System.Drawing.Point(187, 3);
            this.uiCustomSet.Name = "uiCustomSet";
            this.uiCustomSet.Size = new System.Drawing.Size(77, 17);
            this.uiCustomSet.TabIndex = 1;
            this.uiCustomSet.Text = "Custom set";
            this.uiCustomSet.UseVisualStyleBackColor = true;
            this.uiCustomSet.CheckedChanged += new System.EventHandler(this.uiCustomSet_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiGapSize, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.uiGapSizeLabel, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(176, 40);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 4);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vertical gap size";
            // 
            // uiGapSize
            // 
            this.uiGapSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGapSize.AutoSize = false;
            this.uiGapSize.Location = new System.Drawing.Point(22, 16);
            this.uiGapSize.Maximum = 100;
            this.uiGapSize.Name = "uiGapSize";
            this.uiGapSize.Size = new System.Drawing.Size(85, 21);
            this.uiGapSize.TabIndex = 1;
            this.uiGapSize.TickFrequency = 10;
            this.uiGapSize.Value = 10;
            this.uiGapSize.Scroll += new System.EventHandler(this.uiGapSize_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "1";
            // 
            // uiGapSizeLabel
            // 
            this.uiGapSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGapSizeLabel.AutoSize = true;
            this.uiGapSizeLabel.Location = new System.Drawing.Point(132, 20);
            this.uiGapSizeLabel.Name = "uiGapSizeLabel";
            this.uiGapSizeLabel.Size = new System.Drawing.Size(41, 13);
            this.uiGapSizeLabel.TabIndex = 4;
            this.uiGapSizeLabel.Text = "(0,99)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 3);
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Changing these settings will restart the teaching.";
            // 
            // uiLoadFromFile
            // 
            this.uiLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLoadFromFile.AutoSize = true;
            this.uiLoadFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiLoadFromFile.Enabled = false;
            this.uiLoadFromFile.Location = new System.Drawing.Point(187, 26);
            this.uiLoadFromFile.Name = "uiLoadFromFile";
            this.uiLoadFromFile.Size = new System.Drawing.Size(170, 23);
            this.uiLoadFromFile.TabIndex = 0;
            this.uiLoadFromFile.Text = "Load from file...";
            this.uiLoadFromFile.UseVisualStyleBackColor = true;
            this.uiLoadFromFile.Click += new System.EventHandler(this.uiLoadFromFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(257, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teaching";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiCycleLength, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(360, 106);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Number of steps to perform before showing the result:";
            // 
            // uiCycleLength
            // 
            this.uiCycleLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiCycleLength.AutoSize = true;
            this.uiCycleLength.Location = new System.Drawing.Point(310, 4);
            this.uiCycleLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiCycleLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiCycleLength.Name = "uiCycleLength";
            this.uiCycleLength.Size = new System.Drawing.Size(47, 20);
            this.uiCycleLength.TabIndex = 1;
            this.uiCycleLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel4.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.uiOneTeachingCycle, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiRestartTeaching, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiContinuousTeaching, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(360, 29);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // uiOneTeachingCycle
            // 
            this.uiOneTeachingCycle.AutoSize = true;
            this.uiOneTeachingCycle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiOneTeachingCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOneTeachingCycle.Location = new System.Drawing.Point(3, 3);
            this.uiOneTeachingCycle.Name = "uiOneTeachingCycle";
            this.uiOneTeachingCycle.Size = new System.Drawing.Size(114, 23);
            this.uiOneTeachingCycle.TabIndex = 0;
            this.uiOneTeachingCycle.Text = "One cycle";
            this.uiOneTeachingCycle.UseVisualStyleBackColor = true;
            this.uiOneTeachingCycle.Click += new System.EventHandler(this.uiOneTeachingCycle_Click);
            // 
            // uiRestartTeaching
            // 
            this.uiRestartTeaching.AutoSize = true;
            this.uiRestartTeaching.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiRestartTeaching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRestartTeaching.Location = new System.Drawing.Point(243, 3);
            this.uiRestartTeaching.Name = "uiRestartTeaching";
            this.uiRestartTeaching.Size = new System.Drawing.Size(114, 23);
            this.uiRestartTeaching.TabIndex = 2;
            this.uiRestartTeaching.Text = "Restart";
            this.uiRestartTeaching.UseVisualStyleBackColor = true;
            this.uiRestartTeaching.Click += new System.EventHandler(this.uiRestartTeaching_Click);
            // 
            // uiContinuousTeaching
            // 
            this.uiContinuousTeaching.Appearance = System.Windows.Forms.Appearance.Button;
            this.uiContinuousTeaching.AutoSize = true;
            this.uiContinuousTeaching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiContinuousTeaching.Location = new System.Drawing.Point(123, 3);
            this.uiContinuousTeaching.Name = "uiContinuousTeaching";
            this.uiContinuousTeaching.Size = new System.Drawing.Size(114, 23);
            this.uiContinuousTeaching.TabIndex = 3;
            this.uiContinuousTeaching.Text = "Continuous";
            this.uiContinuousTeaching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiContinuousTeaching.UseVisualStyleBackColor = true;
            this.uiContinuousTeaching.CheckedChanged += new System.EventHandler(this.uiContinuousTeaching_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 42);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teaching method";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.uiMethodPerceptron, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.uiMethodWidrowHoff, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(348, 23);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // uiMethodPerceptron
            // 
            this.uiMethodPerceptron.AutoSize = true;
            this.uiMethodPerceptron.Checked = true;
            this.uiMethodPerceptron.Location = new System.Drawing.Point(3, 3);
            this.uiMethodPerceptron.Name = "uiMethodPerceptron";
            this.uiMethodPerceptron.Size = new System.Drawing.Size(77, 17);
            this.uiMethodPerceptron.TabIndex = 0;
            this.uiMethodPerceptron.TabStop = true;
            this.uiMethodPerceptron.Text = "Perceptron";
            this.uiMethodPerceptron.UseVisualStyleBackColor = true;
            // 
            // uiMethodWidrowHoff
            // 
            this.uiMethodWidrowHoff.AutoSize = true;
            this.uiMethodWidrowHoff.Location = new System.Drawing.Point(177, 3);
            this.uiMethodWidrowHoff.Name = "uiMethodWidrowHoff";
            this.uiMethodWidrowHoff.Size = new System.Drawing.Size(91, 17);
            this.uiMethodWidrowHoff.TabIndex = 1;
            this.uiMethodWidrowHoff.Text = "Widrow-Hoff\'s";
            this.uiMethodWidrowHoff.UseVisualStyleBackColor = true;
            // 
            // uiStepNumber
            // 
            this.uiStepNumber.AutoSize = true;
            this.uiStepNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiStepNumber.Location = new System.Drawing.Point(257, 241);
            this.uiStepNumber.Name = "uiStepNumber";
            this.uiStepNumber.Size = new System.Drawing.Size(41, 13);
            this.uiStepNumber.TabIndex = 1;
            this.uiStepNumber.Text = "label5";
            // 
            // uiOpenFile
            // 
            this.uiOpenFile.DefaultExt = "txt";
            this.uiOpenFile.Filter = "Text files|*.txt|All files|*.*";
            this.uiOpenFile.Title = "Open teaching set";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 278);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Line fitting using non-linear neuron (example 06e)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGapSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiCycleLength)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RTadeusiewicz.NN.Controls.ChartPlotter uiChartPlotter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton uiStandardSet;
        private System.Windows.Forms.RadioButton uiCustomSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar uiGapSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uiGapSizeLabel;
        private System.Windows.Forms.Button uiLoadFromFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown uiCycleLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton uiMethodPerceptron;
        private System.Windows.Forms.RadioButton uiMethodWidrowHoff;
        private System.Windows.Forms.OpenFileDialog uiOpenFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button uiOneTeachingCycle;
        private System.Windows.Forms.Button uiRestartTeaching;
        private System.Windows.Forms.CheckBox uiContinuousTeaching;
        private System.Windows.Forms.Label uiStepNumber;
    }
}

