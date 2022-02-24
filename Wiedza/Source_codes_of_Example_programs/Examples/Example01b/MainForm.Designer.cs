namespace RTadeusiewicz.NN.Example01b
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiWeight2 = new System.Windows.Forms.NumericUpDown();
            this.uiWeight1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.explanationToolTip2 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uiObject2 = new System.Windows.Forms.NumericUpDown();
            this.uiObject1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.explanationToolTip3 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.uiKeyObject = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiResponse = new System.Windows.Forms.TextBox();
            this.uiChartPlotter = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiObject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiObject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.explanationToolTip1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uiWeight2);
            this.groupBox1.Controls.Add(this.uiWeight1);
            this.groupBox1.Location = new System.Drawing.Point(280, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feature weights (model object)";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(291, 19);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip1.TabIndex = 4;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "w(2) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "w(1) =";
            // 
            // uiWeight2
            // 
            this.uiWeight2.DecimalPlaces = 1;
            this.uiWeight2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeight2.Location = new System.Drawing.Point(189, 19);
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
            this.uiWeight2.Size = new System.Drawing.Size(67, 20);
            this.uiWeight2.TabIndex = 3;
            this.uiWeight2.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // uiWeight1
            // 
            this.uiWeight1.DecimalPlaces = 1;
            this.uiWeight1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeight1.Location = new System.Drawing.Point(48, 19);
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
            this.uiWeight1.Size = new System.Drawing.Size(67, 20);
            this.uiWeight1.TabIndex = 1;
            this.uiWeight1.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.explanationToolTip2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.uiObject2);
            this.groupBox2.Controls.Add(this.uiObject1);
            this.groupBox2.Location = new System.Drawing.Point(280, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluated object";
            // 
            // explanationToolTip2
            // 
            this.explanationToolTip2.Location = new System.Drawing.Point(291, 19);
            this.explanationToolTip2.Name = "explanationToolTip2";
            this.explanationToolTip2.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip2.TabIndex = 4;
            this.explanationToolTip2.ToolTipText = "Here you can enter the feature values of the evaluated object. As above, you are\r" +
                "\nfree to imagine that it is a flower whose fragrance intensity is x(1) and colou" +
                "r intensity\r\nis x(2).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "x(2) =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "x(1) =";
            // 
            // uiObject2
            // 
            this.uiObject2.DecimalPlaces = 1;
            this.uiObject2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiObject2.Location = new System.Drawing.Point(189, 19);
            this.uiObject2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiObject2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiObject2.Name = "uiObject2";
            this.uiObject2.Size = new System.Drawing.Size(67, 20);
            this.uiObject2.TabIndex = 3;
            this.uiObject2.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // uiObject1
            // 
            this.uiObject1.DecimalPlaces = 1;
            this.uiObject1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiObject1.Location = new System.Drawing.Point(48, 19);
            this.uiObject1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiObject1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiObject1.Name = "uiObject1";
            this.uiObject1.Size = new System.Drawing.Size(67, 20);
            this.uiObject1.TabIndex = 1;
            this.uiObject1.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "The neuron that you will be examining will divide the objects you will show it in" +
                "to the ones that it likes and the ones it dislikes.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(286, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Neuron\'s response:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RTadeusiewicz.NN.Example01b.Properties.Resources.GoRtlHS;
            this.pictureBox1.Location = new System.Drawing.Point(280, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Model object";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.explanationToolTip3);
            this.groupBox3.Controls.Add(this.uiKeyObject);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(302, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 65);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph";
            // 
            // explanationToolTip3
            // 
            this.explanationToolTip3.Location = new System.Drawing.Point(269, 21);
            this.explanationToolTip3.Name = "explanationToolTip3";
            this.explanationToolTip3.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip3.TabIndex = 3;
            this.explanationToolTip3.ToolTipText = resources.GetString("explanationToolTip3.ToolTipText");
            // 
            // uiKeyObject
            // 
            this.uiKeyObject.AutoSize = true;
            this.uiKeyObject.Location = new System.Drawing.Point(6, 42);
            this.uiKeyObject.Name = "uiKeyObject";
            this.uiKeyObject.Size = new System.Drawing.Size(87, 13);
            this.uiKeyObject.TabIndex = 2;
            this.uiKeyObject.Text = "Evaluated object";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Click to perform experiment! See explanations.";
            // 
            // uiResponse
            // 
            this.uiResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiResponse.BackColor = System.Drawing.SystemColors.Control;
            this.uiResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiResponse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiResponse.Location = new System.Drawing.Point(496, 171);
            this.uiResponse.Name = "uiResponse";
            this.uiResponse.Size = new System.Drawing.Size(104, 19);
            this.uiResponse.TabIndex = 5;
            // 
            // uiChartPlotter
            // 
            this.uiChartPlotter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiChartPlotter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiChartPlotter.Location = new System.Drawing.Point(12, 12);
            this.uiChartPlotter.Name = "uiChartPlotter";
            this.uiChartPlotter.Size = new System.Drawing.Size(262, 262);
            this.uiChartPlotter.TabIndex = 0;
            this.uiChartPlotter.Text = "signalVisualizer1";
            this.uiChartPlotter.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("uiChartPlotter.VisibleRectangle")));
            this.uiChartPlotter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VisualizerMouseHandler);
            this.uiChartPlotter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VisualizerMouseHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 299);
            this.Controls.Add(this.uiResponse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiChartPlotter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(620, 333);
            this.Name = "MainForm";
            this.Text = "Single neuron examination with visualization (example 01b)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeight1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiObject2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiObject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uiWeight2;
        private System.Windows.Forms.NumericUpDown uiWeight1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uiObject2;
        private System.Windows.Forms.NumericUpDown uiObject1;
        private System.Windows.Forms.Label label1;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip2;
        private RTadeusiewicz.NN.Controls.ChartPlotter uiChartPlotter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label uiKeyObject;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiResponse;


    }
}

