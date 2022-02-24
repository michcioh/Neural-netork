namespace RTadeusiewicz.NN.Example11
{
    partial class Simulation
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
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.btStart = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.imgBitmap = new System.Windows.Forms.PictureBox();
            this.uiIteractions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiDistribution = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiAlpha0 = new System.Windows.Forms.NumericUpDown();
            this.uiAlpha1 = new System.Windows.Forms.NumericUpDown();
            this.uiNeighbour = new System.Windows.Forms.NumericUpDown();
            this.uiEspAlpha = new System.Windows.Forms.NumericUpDown();
            this.uiEspNeighbour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIteractions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiAlpha0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiAlpha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNeighbour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiEspAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiEspNeighbour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(667, 365);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(4);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 30);
            this.explanationToolTip1.TabIndex = 14;
            this.explanationToolTip1.ToolTipText = "Neurons";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(16, 323);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(86, 23);
            this.btStart.TabIndex = 13;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // imgBitmap
            // 
            this.imgBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.imgBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBitmap.Location = new System.Drawing.Point(3, 3);
            this.imgBitmap.Name = "imgBitmap";
            this.imgBitmap.Size = new System.Drawing.Size(697, 288);
            this.imgBitmap.TabIndex = 11;
            this.imgBitmap.TabStop = false;
            // 
            // uiIteractions
            // 
            this.uiIteractions.Location = new System.Drawing.Point(18, 22);
            this.uiIteractions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiIteractions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiIteractions.Name = "uiIteractions";
            this.uiIteractions.Size = new System.Drawing.Size(60, 20);
            this.uiIteractions.TabIndex = 16;
            this.uiIteractions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "All Iteractions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(89, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "0";
            // 
            // uiDistribution
            // 
            this.uiDistribution.FormattingEnabled = true;
            this.uiDistribution.Items.AddRange(new object[] {
            "Square",
            "Cross",
            "Triangle"});
            this.uiDistribution.Location = new System.Drawing.Point(129, 18);
            this.uiDistribution.Name = "uiDistribution";
            this.uiDistribution.Size = new System.Drawing.Size(79, 21);
            this.uiDistribution.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Figure:";
            // 
            // uiAlpha0
            // 
            this.uiAlpha0.DecimalPlaces = 4;
            this.uiAlpha0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.uiAlpha0.Location = new System.Drawing.Point(234, 20);
            this.uiAlpha0.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiAlpha0.Name = "uiAlpha0";
            this.uiAlpha0.Size = new System.Drawing.Size(68, 20);
            this.uiAlpha0.TabIndex = 22;
            this.uiAlpha0.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.uiAlpha0.ValueChanged += new System.EventHandler(this.uiAlpha0_ValueChanged);
            // 
            // uiAlpha1
            // 
            this.uiAlpha1.DecimalPlaces = 4;
            this.uiAlpha1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.uiAlpha1.Location = new System.Drawing.Point(316, 20);
            this.uiAlpha1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiAlpha1.Name = "uiAlpha1";
            this.uiAlpha1.Size = new System.Drawing.Size(69, 20);
            this.uiAlpha1.TabIndex = 23;
            this.uiAlpha1.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // uiNeighbour
            // 
            this.uiNeighbour.DecimalPlaces = 1;
            this.uiNeighbour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiNeighbour.Location = new System.Drawing.Point(129, 56);
            this.uiNeighbour.Name = "uiNeighbour";
            this.uiNeighbour.Size = new System.Drawing.Size(78, 20);
            this.uiNeighbour.TabIndex = 24;
            // 
            // uiEspAlpha
            // 
            this.uiEspAlpha.DecimalPlaces = 4;
            this.uiEspAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.uiEspAlpha.Location = new System.Drawing.Point(235, 57);
            this.uiEspAlpha.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.uiEspAlpha.Name = "uiEspAlpha";
            this.uiEspAlpha.Size = new System.Drawing.Size(67, 20);
            this.uiEspAlpha.TabIndex = 25;
            this.uiEspAlpha.Value = new decimal(new int[] {
            9997,
            0,
            0,
            262144});
            this.uiEspAlpha.ValueChanged += new System.EventHandler(this.uiEspAlpha_ValueChanged);
            // 
            // uiEspNeighbour
            // 
            this.uiEspNeighbour.DecimalPlaces = 4;
            this.uiEspNeighbour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.uiEspNeighbour.Location = new System.Drawing.Point(316, 57);
            this.uiEspNeighbour.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.uiEspNeighbour.Name = "uiEspNeighbour";
            this.uiEspNeighbour.Size = new System.Drawing.Size(69, 20);
            this.uiEspNeighbour.TabIndex = 26;
            this.uiEspNeighbour.Value = new decimal(new int[] {
            9990,
            0,
            0,
            262144});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Alpha0:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Alpha1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Neighbour:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "EpsAlpha:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "EpsNeighb:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiIteractions);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uiEspNeighbour);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.uiEspAlpha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uiAlpha1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.uiDistribution);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.uiAlpha0);
            this.panel1.Controls.Add(this.uiNeighbour);
            this.panel1.Location = new System.Drawing.Point(122, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 79);
            this.panel1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 297);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(110, 106);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teaching";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(115, 297);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(400, 106);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teaching parameters";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imgBitmap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(707, 409);
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiIteractions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiAlpha0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiAlpha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNeighbour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiEspAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiEspNeighbour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox imgBitmap;
        private System.Windows.Forms.NumericUpDown uiIteractions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uiDistribution;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown uiAlpha0;
        private System.Windows.Forms.NumericUpDown uiAlpha1;
        private System.Windows.Forms.NumericUpDown uiNeighbour;
        private System.Windows.Forms.NumericUpDown uiEspAlpha;
        private System.Windows.Forms.NumericUpDown uiEspNeighbour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
