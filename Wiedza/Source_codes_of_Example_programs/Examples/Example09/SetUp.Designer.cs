namespace RTadeusiewicz.NN.Example09
{
    partial class SetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUp));
            this.nrLayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nrLay1 = new System.Windows.Forms.NumericUpDown();
            this.nrLay2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nX1 = new System.Windows.Forms.NumericUpDown();
            this.nR1 = new System.Windows.Forms.NumericUpDown();
            this.nY1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nY2 = new System.Windows.Forms.NumericUpDown();
            this.nR2 = new System.Windows.Forms.NumericUpDown();
            this.nX2 = new System.Windows.Forms.NumericUpDown();
            this.nY3 = new System.Windows.Forms.NumericUpDown();
            this.nR3 = new System.Windows.Forms.NumericUpDown();
            this.nX3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.nrLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrLay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrLay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nrLayers
            // 
            this.nrLayers.Location = new System.Drawing.Point(14, 46);
            this.nrLayers.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nrLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrLayers.Name = "nrLayers";
            this.nrLayers.Size = new System.Drawing.Size(44, 20);
            this.nrLayers.TabIndex = 0;
            this.nrLayers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nrLayers.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layers:";
            // 
            // nrLay1
            // 
            this.nrLay1.Location = new System.Drawing.Point(98, 46);
            this.nrLay1.Name = "nrLay1";
            this.nrLay1.Size = new System.Drawing.Size(120, 20);
            this.nrLay1.TabIndex = 2;
            this.nrLay1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nrLay2
            // 
            this.nrLay2.Location = new System.Drawing.Point(280, 46);
            this.nrLay2.Name = "nrLay2";
            this.nrLay2.Size = new System.Drawing.Size(120, 20);
            this.nrLay2.TabIndex = 3;
            this.nrLay2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Neurons in first hidden layer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(250, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Neurons in second hidden layer:";
            // 
            // nX1
            // 
            this.nX1.DecimalPlaces = 2;
            this.nX1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nX1.Location = new System.Drawing.Point(129, 42);
            this.nX1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nX1.Name = "nX1";
            this.nX1.Size = new System.Drawing.Size(70, 20);
            this.nX1.TabIndex = 6;
            // 
            // nR1
            // 
            this.nR1.DecimalPlaces = 2;
            this.nR1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nR1.Location = new System.Drawing.Point(330, 42);
            this.nR1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nR1.Name = "nR1";
            this.nR1.Size = new System.Drawing.Size(70, 20);
            this.nR1.TabIndex = 8;
            // 
            // nY1
            // 
            this.nY1.DecimalPlaces = 2;
            this.nY1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nY1.Location = new System.Drawing.Point(229, 42);
            this.nY1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nY1.Name = "nY1";
            this.nY1.Size = new System.Drawing.Size(70, 20);
            this.nY1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X coord.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(226, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y coord.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(327, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Radius";
            // 
            // nY2
            // 
            this.nY2.DecimalPlaces = 2;
            this.nY2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nY2.Location = new System.Drawing.Point(229, 68);
            this.nY2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nY2.Name = "nY2";
            this.nY2.Size = new System.Drawing.Size(70, 20);
            this.nY2.TabIndex = 13;
            // 
            // nR2
            // 
            this.nR2.DecimalPlaces = 2;
            this.nR2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nR2.Location = new System.Drawing.Point(330, 68);
            this.nR2.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nR2.Name = "nR2";
            this.nR2.Size = new System.Drawing.Size(70, 20);
            this.nR2.TabIndex = 14;
            // 
            // nX2
            // 
            this.nX2.DecimalPlaces = 2;
            this.nX2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nX2.Location = new System.Drawing.Point(129, 68);
            this.nX2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nX2.Name = "nX2";
            this.nX2.Size = new System.Drawing.Size(70, 20);
            this.nX2.TabIndex = 12;
            // 
            // nY3
            // 
            this.nY3.DecimalPlaces = 2;
            this.nY3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nY3.Location = new System.Drawing.Point(230, 94);
            this.nY3.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nY3.Name = "nY3";
            this.nY3.Size = new System.Drawing.Size(70, 20);
            this.nY3.TabIndex = 19;
            // 
            // nR3
            // 
            this.nR3.DecimalPlaces = 2;
            this.nR3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nR3.Location = new System.Drawing.Point(330, 94);
            this.nR3.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nR3.Name = "nR3";
            this.nR3.Size = new System.Drawing.Size(71, 20);
            this.nR3.TabIndex = 20;
            // 
            // nX3
            // 
            this.nX3.DecimalPlaces = 2;
            this.nX3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nX3.Location = new System.Drawing.Point(130, 94);
            this.nX3.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nX3.Name = "nX3";
            this.nX3.Size = new System.Drawing.Size(70, 20);
            this.nX3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nX1);
            this.groupBox1.Controls.Add(this.nR1);
            this.groupBox1.Controls.Add(this.nY1);
            this.groupBox1.Controls.Add(this.nY3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nR3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nX3);
            this.groupBox1.Controls.Add(this.nX2);
            this.groupBox1.Controls.Add(this.nR2);
            this.groupBox1.Controls.Add(this.nY2);
            this.groupBox1.Location = new System.Drawing.Point(3, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circles coordinates";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(37, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Circle 3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(36, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Circle 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(36, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Circle 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nrLayers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nrLay1);
            this.groupBox2.Controls.Add(this.nrLay2);
            this.groupBox2.Location = new System.Drawing.Point(3, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 88);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NN settings";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(446, 252);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip1.TabIndex = 26;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetUp";
            this.Size = new System.Drawing.Size(526, 294);
            ((System.ComponentModel.ISupportInitialize)(this.nrLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrLay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrLay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nrLayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nrLay1;
        private System.Windows.Forms.NumericUpDown nrLay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nX1;
        private System.Windows.Forms.NumericUpDown nR1;
        private System.Windows.Forms.NumericUpDown nY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nY2;
        private System.Windows.Forms.NumericUpDown nR2;
        private System.Windows.Forms.NumericUpDown nX2;
        private System.Windows.Forms.NumericUpDown nY3;
        private System.Windows.Forms.NumericUpDown nR3;
        private System.Windows.Forms.NumericUpDown nX3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
    }
}
