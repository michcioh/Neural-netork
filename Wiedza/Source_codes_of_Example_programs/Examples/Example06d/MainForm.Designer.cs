namespace RTadeusiewicz.NN.Example06d
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
            this.uiTransferFunctionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLayerCount = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiLayerCountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uiOutputCount = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.uiOutputCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uiWeightsRange = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.uiWeightsRangeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uiBiasWeightsRange = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.uiBiasWeightsRangeLabel = new System.Windows.Forms.Label();
            this.uiDifferentBiasRange = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiCreateNewNetwork = new System.Windows.Forms.Button();
            this.uiSuspendCreating = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiShowNeuronLines = new System.Windows.Forms.CheckBox();
            this.uiBrightnessScaling = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiLayerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeightsRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBiasWeightsRange)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.uiChartPlotter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 250);
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
            this.tableLayoutPanel1.SetRowSpan(this.uiChartPlotter, 2);
            this.uiChartPlotter.Size = new System.Drawing.Size(189, 205);
            this.uiChartPlotter.TabIndex = 0;
            this.uiChartPlotter.Text = "chartPlotter1";
            this.uiChartPlotter.TicksVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.None;
            this.uiChartPlotter.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("uiChartPlotter.VisibleRectangle")));
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(198, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network parameters";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.uiTransferFunctionType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.uiLayerCount, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.uiLayerCountLabel, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.uiOutputCount, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.uiOutputCountLabel, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.uiWeightsRange, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.uiWeightsRangeLabel, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.uiBiasWeightsRange, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label13, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.uiBiasWeightsRangeLabel, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.uiDifferentBiasRange, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // uiTransferFunctionType
            // 
            this.uiTransferFunctionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.uiTransferFunctionType, 4);
            this.uiTransferFunctionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiTransferFunctionType.FormattingEnabled = true;
            this.uiTransferFunctionType.Items.AddRange(new object[] {
            "Bipolar",
            "Unipolar",
            "Sigmoidal",
            "Hyperbolical tangent"});
            this.uiTransferFunctionType.Location = new System.Drawing.Point(127, 3);
            this.uiTransferFunctionType.Name = "uiTransferFunctionType";
            this.uiTransferFunctionType.Size = new System.Drawing.Size(221, 21);
            this.uiTransferFunctionType.TabIndex = 1;
            this.uiTransferFunctionType.SelectedIndexChanged += new System.EventHandler(this.parameterChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer function type:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of layers";
            // 
            // uiLayerCount
            // 
            this.uiLayerCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLayerCount.AutoSize = false;
            this.uiLayerCount.LargeChange = 1;
            this.uiLayerCount.Location = new System.Drawing.Point(149, 30);
            this.uiLayerCount.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiLayerCount.Minimum = 1;
            this.uiLayerCount.Name = "uiLayerCount";
            this.uiLayerCount.Size = new System.Drawing.Size(140, 21);
            this.uiLayerCount.TabIndex = 3;
            this.uiLayerCount.Value = 1;
            this.uiLayerCount.Scroll += new System.EventHandler(this.parameterChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "10";
            // 
            // uiLayerCountLabel
            // 
            this.uiLayerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uiLayerCountLabel.AutoSize = true;
            this.uiLayerCountLabel.Location = new System.Drawing.Point(323, 34);
            this.uiLayerCountLabel.Name = "uiLayerCountLabel";
            this.uiLayerCountLabel.Size = new System.Drawing.Size(25, 13);
            this.uiLayerCountLabel.TabIndex = 5;
            this.uiLayerCountLabel.Text = "(10)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of outputs";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "1";
            // 
            // uiOutputCount
            // 
            this.uiOutputCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputCount.AutoSize = false;
            this.uiOutputCount.LargeChange = 1;
            this.uiOutputCount.Location = new System.Drawing.Point(149, 57);
            this.uiOutputCount.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiOutputCount.Minimum = 1;
            this.uiOutputCount.Name = "uiOutputCount";
            this.uiOutputCount.Size = new System.Drawing.Size(140, 21);
            this.uiOutputCount.TabIndex = 3;
            this.uiOutputCount.Value = 1;
            this.uiOutputCount.Scroll += new System.EventHandler(this.parameterChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "10";
            // 
            // uiOutputCountLabel
            // 
            this.uiOutputCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uiOutputCountLabel.AutoSize = true;
            this.uiOutputCountLabel.Location = new System.Drawing.Point(323, 61);
            this.uiOutputCountLabel.Name = "uiOutputCountLabel";
            this.uiOutputCountLabel.Size = new System.Drawing.Size(25, 13);
            this.uiOutputCountLabel.TabIndex = 5;
            this.uiOutputCountLabel.Text = "(10)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Weights range";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "0,1";
            // 
            // uiWeightsRange
            // 
            this.uiWeightsRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiWeightsRange.AutoSize = false;
            this.uiWeightsRange.LargeChange = 1;
            this.uiWeightsRange.Location = new System.Drawing.Point(149, 84);
            this.uiWeightsRange.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiWeightsRange.Minimum = -10;
            this.uiWeightsRange.Name = "uiWeightsRange";
            this.uiWeightsRange.Size = new System.Drawing.Size(140, 21);
            this.uiWeightsRange.TabIndex = 3;
            this.uiWeightsRange.Scroll += new System.EventHandler(this.parameterChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "10";
            // 
            // uiWeightsRangeLabel
            // 
            this.uiWeightsRangeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uiWeightsRangeLabel.AutoSize = true;
            this.uiWeightsRangeLabel.Location = new System.Drawing.Point(323, 88);
            this.uiWeightsRangeLabel.Name = "uiWeightsRangeLabel";
            this.uiWeightsRangeLabel.Size = new System.Drawing.Size(25, 13);
            this.uiWeightsRangeLabel.TabIndex = 5;
            this.uiWeightsRangeLabel.Text = "(10)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "0,1";
            // 
            // uiBiasWeightsRange
            // 
            this.uiBiasWeightsRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBiasWeightsRange.AutoSize = false;
            this.uiBiasWeightsRange.Enabled = false;
            this.uiBiasWeightsRange.LargeChange = 1;
            this.uiBiasWeightsRange.Location = new System.Drawing.Point(149, 111);
            this.uiBiasWeightsRange.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiBiasWeightsRange.Minimum = -10;
            this.uiBiasWeightsRange.Name = "uiBiasWeightsRange";
            this.uiBiasWeightsRange.Size = new System.Drawing.Size(140, 21);
            this.uiBiasWeightsRange.TabIndex = 3;
            this.uiBiasWeightsRange.Scroll += new System.EventHandler(this.parameterChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "10";
            // 
            // uiBiasWeightsRangeLabel
            // 
            this.uiBiasWeightsRangeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uiBiasWeightsRangeLabel.AutoSize = true;
            this.uiBiasWeightsRangeLabel.Location = new System.Drawing.Point(323, 115);
            this.uiBiasWeightsRangeLabel.Name = "uiBiasWeightsRangeLabel";
            this.uiBiasWeightsRangeLabel.Size = new System.Drawing.Size(25, 13);
            this.uiBiasWeightsRangeLabel.TabIndex = 5;
            this.uiBiasWeightsRangeLabel.Text = "(10)";
            // 
            // uiDifferentBiasRange
            // 
            this.uiDifferentBiasRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiDifferentBiasRange.AutoSize = true;
            this.uiDifferentBiasRange.Location = new System.Drawing.Point(3, 113);
            this.uiDifferentBiasRange.Name = "uiDifferentBiasRange";
            this.uiDifferentBiasRange.Size = new System.Drawing.Size(118, 17);
            this.uiDifferentBiasRange.TabIndex = 6;
            this.uiDifferentBiasRange.Text = "Different bias range";
            this.uiDifferentBiasRange.UseVisualStyleBackColor = true;
            this.uiDifferentBiasRange.CheckedChanged += new System.EventHandler(this.uiDifferentBiasRange_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.uiCreateNewNetwork);
            this.flowLayoutPanel1.Controls.Add(this.uiSuspendCreating);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // uiCreateNewNetwork
            // 
            this.uiCreateNewNetwork.AutoSize = true;
            this.uiCreateNewNetwork.Location = new System.Drawing.Point(3, 3);
            this.uiCreateNewNetwork.Name = "uiCreateNewNetwork";
            this.uiCreateNewNetwork.Size = new System.Drawing.Size(194, 27);
            this.uiCreateNewNetwork.TabIndex = 2;
            this.uiCreateNewNetwork.Text = "Create new random network";
            this.uiCreateNewNetwork.UseVisualStyleBackColor = true;
            this.uiCreateNewNetwork.Click += new System.EventHandler(this.parameterChanged);
            // 
            // uiSuspendCreating
            // 
            this.uiSuspendCreating.Appearance = System.Windows.Forms.Appearance.Button;
            this.uiSuspendCreating.AutoSize = true;
            this.uiSuspendCreating.Location = new System.Drawing.Point(203, 3);
            this.uiSuspendCreating.Name = "uiSuspendCreating";
            this.uiSuspendCreating.Size = new System.Drawing.Size(100, 23);
            this.uiSuspendCreating.TabIndex = 3;
            this.uiSuspendCreating.Text = "Suspend creating";
            this.uiSuspendCreating.UseVisualStyleBackColor = true;
            this.uiSuspendCreating.Visible = false;
            this.uiSuspendCreating.CheckedChanged += new System.EventHandler(this.uiSuspendCreating_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(198, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 42);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View parameters";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.uiShowNeuronLines);
            this.flowLayoutPanel2.Controls.Add(this.uiBrightnessScaling);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(351, 23);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // uiShowNeuronLines
            // 
            this.uiShowNeuronLines.AutoSize = true;
            this.uiShowNeuronLines.Location = new System.Drawing.Point(3, 3);
            this.uiShowNeuronLines.Name = "uiShowNeuronLines";
            this.uiShowNeuronLines.Size = new System.Drawing.Size(141, 17);
            this.uiShowNeuronLines.TabIndex = 3;
            this.uiShowNeuronLines.Text = "Show the \"neuron lines\"";
            this.uiShowNeuronLines.UseVisualStyleBackColor = true;
            this.uiShowNeuronLines.CheckedChanged += new System.EventHandler(this.uiShowNeuronLines_CheckedChanged);
            // 
            // uiBrightnessScaling
            // 
            this.uiBrightnessScaling.AutoSize = true;
            this.uiBrightnessScaling.Location = new System.Drawing.Point(150, 3);
            this.uiBrightnessScaling.Name = "uiBrightnessScaling";
            this.uiBrightnessScaling.Size = new System.Drawing.Size(132, 17);
            this.uiBrightnessScaling.TabIndex = 4;
            this.uiBrightnessScaling.Text = "Use brightness scaling";
            this.uiBrightnessScaling.UseVisualStyleBackColor = true;
            this.uiBrightnessScaling.CheckedChanged += new System.EventHandler(this.uiBrightnessScaling_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 274);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Random non-linear neural network examination (example 06d)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiLayerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeightsRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBiasWeightsRange)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RTadeusiewicz.NN.Controls.ChartPlotter uiChartPlotter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiTransferFunctionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar uiLayerCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uiLayerCountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar uiOutputCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uiOutputCountLabel;
        private System.Windows.Forms.Button uiCreateNewNetwork;
        private System.Windows.Forms.CheckBox uiShowNeuronLines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar uiWeightsRange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label uiWeightsRangeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox uiSuspendCreating;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar uiBiasWeightsRange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label uiBiasWeightsRangeLabel;
        private System.Windows.Forms.CheckBox uiDifferentBiasRange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox uiBrightnessScaling;
    }
}

