namespace RTadeusiewicz.NN.Example06c
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPointCoords = new System.Windows.Forms.Label();
            this.uiResponse = new System.Windows.Forms.Label();
            this.uiChartPlotter = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTransferFunctionType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.uiWeight1 = new System.Windows.Forms.NumericUpDown();
            this.uiWeight2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.uiShowOnePoint = new System.Windows.Forms.Button();
            this.explanationToolTip2 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.uiShowMultiplePoints = new System.Windows.Forms.Button();
            this.uiStopShowingPoints = new System.Windows.Forms.Button();
            this.uiShowEntirePlane = new System.Windows.Forms.Button();
            this.uiPointTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiChartPlotter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 345);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.uiPointCoords);
            this.flowLayoutPanel1.Controls.Add(this.uiResponse);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(378, 324);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(16, 17);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // uiPointCoords
            // 
            this.uiPointCoords.AutoSize = true;
            this.uiPointCoords.Location = new System.Drawing.Point(4, 0);
            this.uiPointCoords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiPointCoords.Name = "uiPointCoords";
            this.uiPointCoords.Size = new System.Drawing.Size(0, 17);
            this.uiPointCoords.TabIndex = 0;
            // 
            // uiResponse
            // 
            this.uiResponse.AutoSize = true;
            this.uiResponse.Location = new System.Drawing.Point(12, 0);
            this.uiResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiResponse.Name = "uiResponse";
            this.uiResponse.Size = new System.Drawing.Size(0, 17);
            this.uiResponse.TabIndex = 1;
            // 
            // uiChartPlotter
            // 
            this.uiChartPlotter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiChartPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiChartPlotter.Location = new System.Drawing.Point(4, 4);
            this.uiChartPlotter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiChartPlotter.Name = "uiChartPlotter";
            this.tableLayoutPanel1.SetRowSpan(this.uiChartPlotter, 3);
            this.uiChartPlotter.Size = new System.Drawing.Size(366, 337);
            this.uiChartPlotter.TabIndex = 0;
            this.uiChartPlotter.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("uiChartPlotter.VisibleRectangle")));
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(378, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(383, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuron";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiTransferFunctionType, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(367, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer function type:";
            // 
            // uiTransferFunctionType
            // 
            this.uiTransferFunctionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTransferFunctionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiTransferFunctionType.FormattingEnabled = true;
            this.uiTransferFunctionType.Items.AddRange(new object[] {
            "Bipolar",
            "Unipolar",
            "Sigmoidal",
            "Hyperbolical tangent"});
            this.uiTransferFunctionType.Location = new System.Drawing.Point(163, 4);
            this.uiTransferFunctionType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTransferFunctionType.Name = "uiTransferFunctionType";
            this.uiTransferFunctionType.Size = new System.Drawing.Size(200, 24);
            this.uiTransferFunctionType.TabIndex = 1;
            this.uiTransferFunctionType.SelectedIndexChanged += new System.EventHandler(this.uiTransferFunctionType_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.explanationToolTip1, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiWeight1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiWeight2, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 44);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(367, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(27, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "w(1) =";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(27, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "w(2) =";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(331, 5);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(31, 28);
            this.explanationToolTip1.TabIndex = 2;
            this.explanationToolTip1.ToolTipText = null;
            // 
            // uiWeight1
            // 
            this.uiWeight1.AutoSize = true;
            this.uiWeight1.DecimalPlaces = 1;
            this.uiWeight1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeight1.Location = new System.Drawing.Point(82, 4);
            this.uiWeight1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiWeight1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiWeight1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiWeight1.Name = "uiWeight1";
            this.uiWeight1.Size = new System.Drawing.Size(56, 22);
            this.uiWeight1.TabIndex = 2;
            this.uiWeight1.ValueChanged += new System.EventHandler(this.weightChanged);
            // 
            // uiWeight2
            // 
            this.uiWeight2.AutoSize = true;
            this.uiWeight2.DecimalPlaces = 1;
            this.uiWeight2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeight2.Location = new System.Drawing.Point(245, 4);
            this.uiWeight2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiWeight2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiWeight2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiWeight2.Name = "uiWeight2";
            this.uiWeight2.Size = new System.Drawing.Size(56, 22);
            this.uiWeight2.TabIndex = 3;
            this.uiWeight2.ValueChanged += new System.EventHandler(this.weightChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(378, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(383, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sygna³y";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.uiShowEntirePlane, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(375, 130);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.uiShowOnePoint, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.explanationToolTip2, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(367, 38);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // uiShowOnePoint
            // 
            this.uiShowOnePoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowOnePoint.AutoSize = true;
            this.uiShowOnePoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiShowOnePoint.Location = new System.Drawing.Point(4, 4);
            this.uiShowOnePoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiShowOnePoint.Name = "uiShowOnePoint";
            this.uiShowOnePoint.Size = new System.Drawing.Size(318, 27);
            this.uiShowOnePoint.TabIndex = 0;
            this.uiShowOnePoint.Text = "Show one random point";
            this.uiShowOnePoint.UseVisualStyleBackColor = true;
            this.uiShowOnePoint.Click += new System.EventHandler(this.uiShowOnePoint_Click);
            // 
            // explanationToolTip2
            // 
            this.explanationToolTip2.Location = new System.Drawing.Point(331, 5);
            this.explanationToolTip2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.explanationToolTip2.Name = "explanationToolTip2";
            this.explanationToolTip2.Size = new System.Drawing.Size(31, 28);
            this.explanationToolTip2.TabIndex = 1;
            this.explanationToolTip2.ToolTipText = null;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.uiShowMultiplePoints, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.uiStopShowingPoints, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 50);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(367, 35);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // uiShowMultiplePoints
            // 
            this.uiShowMultiplePoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowMultiplePoints.AutoSize = true;
            this.uiShowMultiplePoints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiShowMultiplePoints.Location = new System.Drawing.Point(4, 4);
            this.uiShowMultiplePoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiShowMultiplePoints.Name = "uiShowMultiplePoints";
            this.uiShowMultiplePoints.Size = new System.Drawing.Size(175, 27);
            this.uiShowMultiplePoints.TabIndex = 0;
            this.uiShowMultiplePoints.Text = "Show multiple points";
            this.uiShowMultiplePoints.UseVisualStyleBackColor = true;
            this.uiShowMultiplePoints.Click += new System.EventHandler(this.uiShowMultiplePoints_Click);
            // 
            // uiStopShowingPoints
            // 
            this.uiStopShowingPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiStopShowingPoints.AutoSize = true;
            this.uiStopShowingPoints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiStopShowingPoints.Enabled = false;
            this.uiStopShowingPoints.Location = new System.Drawing.Point(187, 4);
            this.uiStopShowingPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiStopShowingPoints.Name = "uiStopShowingPoints";
            this.uiStopShowingPoints.Size = new System.Drawing.Size(176, 27);
            this.uiStopShowingPoints.TabIndex = 1;
            this.uiStopShowingPoints.Text = "Stop";
            this.uiStopShowingPoints.UseVisualStyleBackColor = true;
            this.uiStopShowingPoints.Click += new System.EventHandler(this.uiStopShowingPoints_Click);
            // 
            // uiShowEntirePlane
            // 
            this.uiShowEntirePlane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowEntirePlane.AutoSize = true;
            this.uiShowEntirePlane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiShowEntirePlane.Location = new System.Drawing.Point(8, 96);
            this.uiShowEntirePlane.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uiShowEntirePlane.Name = "uiShowEntirePlane";
            this.uiShowEntirePlane.Size = new System.Drawing.Size(359, 27);
            this.uiShowEntirePlane.TabIndex = 2;
            this.uiShowEntirePlane.Text = "Show the entire plane";
            this.uiShowEntirePlane.UseVisualStyleBackColor = true;
            this.uiShowEntirePlane.Click += new System.EventHandler(this.uiShowEntirePlane_Click);
            // 
            // uiPointTimer
            // 
            this.uiPointTimer.Tick += new System.EventHandler(this.uiPointTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(805, 408);
            this.Name = "MainForm";
            this.Text = "Single non-liner neuron examination with visualization (example 06c)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RTadeusiewicz.NN.Controls.ChartPlotter uiChartPlotter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiTransferFunctionType;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiShowOnePoint;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip2;
        private System.Windows.Forms.Button uiShowMultiplePoints;
        private System.Windows.Forms.Button uiStopShowingPoints;
        private System.Windows.Forms.Button uiShowEntirePlane;
        private System.Windows.Forms.NumericUpDown uiWeight1;
        private System.Windows.Forms.NumericUpDown uiWeight2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label uiPointCoords;
        private System.Windows.Forms.Label uiResponse;
        private System.Windows.Forms.Timer uiPointTimer;
    }
}

