namespace RTadeusiewicz.NN.Example10ax
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiNeurons = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.uiEthaFactor = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRandomize = new System.Windows.Forms.CheckBox();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.cbDensity = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiEthaFactor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 153);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Neurons:";
            // 
            // uiNeurons
            // 
            this.uiNeurons.Location = new System.Drawing.Point(161, 363);
            this.uiNeurons.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiNeurons.Name = "uiNeurons";
            this.uiNeurons.Size = new System.Drawing.Size(46, 20);
            this.uiNeurons.TabIndex = 8;
            this.uiNeurons.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Etha factor:";
            // 
            // uiEthaFactor
            // 
            this.uiEthaFactor.AutoSize = true;
            this.uiEthaFactor.DecimalPlaces = 3;
            this.uiEthaFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.uiEthaFactor.Location = new System.Drawing.Point(250, 363);
            this.uiEthaFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiEthaFactor.Name = "uiEthaFactor";
            this.uiEthaFactor.Size = new System.Drawing.Size(50, 20);
            this.uiEthaFactor.TabIndex = 10;
            this.uiEthaFactor.Value = new decimal(new int[] {
            15,
            0,
            0,
            196608});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 314);
            this.panel1.TabIndex = 11;
            // 
            // cbRandomize
            // 
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Checked = true;
            this.cbRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRandomize.Location = new System.Drawing.Point(34, 338);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(79, 17);
            this.cbRandomize.TabIndex = 12;
            this.cbRandomize.Text = "Randomize";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(5, 347);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(4);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 30);
            this.explanationToolTip1.TabIndex = 13;
            this.explanationToolTip1.ToolTipText = "Neurons";
            // 
            // cbDensity
            // 
            this.cbDensity.AutoSize = true;
            this.cbDensity.Location = new System.Drawing.Point(33, 361);
            this.cbDensity.Name = "cbDensity";
            this.cbDensity.Size = new System.Drawing.Size(61, 17);
            this.cbDensity.TabIndex = 14;
            this.cbDensity.Text = "Density";
            this.cbDensity.UseVisualStyleBackColor = true;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.cbDensity);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.cbRandomize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiEthaFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiNeurons);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetUp";
            this.Size = new System.Drawing.Size(310, 399);
            ((System.ComponentModel.ISupportInitialize)(this.uiNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiEthaFactor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uiNeurons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uiEthaFactor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbRandomize;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.CheckBox cbDensity;

    }
}
