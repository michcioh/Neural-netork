namespace RTadeusiewicz.NN.Example09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.bStart = new System.Windows.Forms.Button();
            this.imgBitmap = new System.Windows.Forms.PictureBox();
            this.nrEta = new System.Windows.Forms.NumericUpDown();
            this.nrAlpha = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nrIteractions = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTotalIterations = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrIteractions)).BeginInit();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStart.Location = new System.Drawing.Point(350, 249);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // imgBitmap
            // 
            this.imgBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.imgBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBitmap.Location = new System.Drawing.Point(3, 3);
            this.imgBitmap.Name = "imgBitmap";
            this.imgBitmap.Size = new System.Drawing.Size(588, 224);
            this.imgBitmap.TabIndex = 12;
            this.imgBitmap.TabStop = false;
            this.imgBitmap.Click += new System.EventHandler(this.imgBitmap_Click);
            // 
            // nrEta
            // 
            this.nrEta.DecimalPlaces = 2;
            this.nrEta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nrEta.Location = new System.Drawing.Point(71, 263);
            this.nrEta.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrEta.Name = "nrEta";
            this.nrEta.Size = new System.Drawing.Size(49, 20);
            this.nrEta.TabIndex = 14;
            this.nrEta.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.nrEta.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nrAlpha
            // 
            this.nrAlpha.DecimalPlaces = 2;
            this.nrAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nrAlpha.Location = new System.Drawing.Point(71, 237);
            this.nrAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrAlpha.Name = "nrAlpha";
            this.nrAlpha.Size = new System.Drawing.Size(49, 20);
            this.nrAlpha.TabIndex = 15;
            this.nrAlpha.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Eta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alpha:";
            // 
            // nrIteractions
            // 
            this.nrIteractions.Location = new System.Drawing.Point(241, 236);
            this.nrIteractions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nrIteractions.Name = "nrIteractions";
            this.nrIteractions.Size = new System.Drawing.Size(56, 20);
            this.nrIteractions.TabIndex = 18;
            this.nrIteractions.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nrIteractions.ValueChanged += new System.EventHandler(this.nrIteractions_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Iterations:";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(447, 249);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip1.TabIndex = 20;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total iterations:";
            // 
            // uiTotalIterations
            // 
            this.uiTotalIterations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTotalIterations.Location = new System.Drawing.Point(244, 264);
            this.uiTotalIterations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiTotalIterations.Name = "uiTotalIterations";
            this.uiTotalIterations.ReadOnly = true;
            this.uiTotalIterations.Size = new System.Drawing.Size(55, 13);
            this.uiTotalIterations.TabIndex = 22;
            this.uiTotalIterations.Text = "0";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.uiTotalIterations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrIteractions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrAlpha);
            this.Controls.Add(this.nrEta);
            this.Controls.Add(this.imgBitmap);
            this.Controls.Add(this.bStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(594, 293);
            this.Load += new System.EventHandler(this.Simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrIteractions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.PictureBox imgBitmap;
        private System.Windows.Forms.NumericUpDown nrEta;
        private System.Windows.Forms.NumericUpDown nrAlpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nrIteractions;
        private System.Windows.Forms.Label label3;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiTotalIterations;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
