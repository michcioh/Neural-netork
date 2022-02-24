namespace RTadeusiewicz.NN.Example11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.uiNetSizeY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.uiNetSizeX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.uiWeights = new System.Windows.Forms.NumericUpDown();
            this.lable1 = new System.Windows.Forms.Label();
            this.explanationToolTip2 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNetSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNetSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeights)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 261);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 153);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // uiNetSizeY
            // 
            this.uiNetSizeY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiNetSizeY.AutoSize = true;
            this.uiNetSizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiNetSizeY.Location = new System.Drawing.Point(150, 302);
            this.uiNetSizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiNetSizeY.Name = "uiNetSizeY";
            this.uiNetSizeY.Size = new System.Drawing.Size(49, 19);
            this.uiNetSizeY.TabIndex = 17;
            this.uiNetSizeY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(148, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Net size Y:";
            // 
            // uiNetSizeX
            // 
            this.uiNetSizeX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiNetSizeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiNetSizeX.Location = new System.Drawing.Point(62, 302);
            this.uiNetSizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiNetSizeX.Name = "uiNetSizeX";
            this.uiNetSizeX.Size = new System.Drawing.Size(46, 19);
            this.uiNetSizeX.TabIndex = 15;
            this.uiNetSizeX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Net size X:";
            // 
            // uiWeights
            // 
            this.uiWeights.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiWeights.AutoSize = true;
            this.uiWeights.DecimalPlaces = 2;
            this.uiWeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiWeights.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.uiWeights.Location = new System.Drawing.Point(239, 302);
            this.uiWeights.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiWeights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.uiWeights.Name = "uiWeights";
            this.uiWeights.Size = new System.Drawing.Size(55, 19);
            this.uiWeights.TabIndex = 20;
            this.uiWeights.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable1.Location = new System.Drawing.Point(236, 285);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(189, 13);
            this.lable1.TabIndex = 21;
            this.lable1.Text = "Range of initial random weights:";
            // 
            // explanationToolTip2
            // 
            this.explanationToolTip2.Location = new System.Drawing.Point(652, 291);
            this.explanationToolTip2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explanationToolTip2.Name = "explanationToolTip2";
            this.explanationToolTip2.Size = new System.Drawing.Size(23, 30);
            this.explanationToolTip2.TabIndex = 19;
            this.explanationToolTip2.ToolTipText = "Neurons";
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.uiWeights);
            this.Controls.Add(this.explanationToolTip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiNetSizeY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiNetSizeX);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetUp";
            this.Size = new System.Drawing.Size(706, 347);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiNetSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNetSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uiNetSizeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uiNetSizeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uiWeights;
        private System.Windows.Forms.Label lable1;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip2;
    }
}
