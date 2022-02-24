namespace RTadeusiewicz.NN.Example06a
{
    partial class SetUpPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiUnipolar = new System.Windows.Forms.RadioButton();
            this.uiBipolar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiInputCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the number of inputs and neuron type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 138);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // uiInputCount
            // 
            this.uiInputCount.Location = new System.Drawing.Point(71, 180);
            this.uiInputCount.Name = "uiInputCount";
            this.uiInputCount.Size = new System.Drawing.Size(56, 20);
            this.uiInputCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of inputs:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiBipolar);
            this.groupBox1.Controls.Add(this.uiUnipolar);
            this.groupBox1.Location = new System.Drawing.Point(199, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuron type";
            // 
            // uiUnipolar
            // 
            this.uiUnipolar.AutoSize = true;
            this.uiUnipolar.Checked = true;
            this.uiUnipolar.Location = new System.Drawing.Point(6, 19);
            this.uiUnipolar.Name = "uiUnipolar";
            this.uiUnipolar.Size = new System.Drawing.Size(64, 17);
            this.uiUnipolar.TabIndex = 0;
            this.uiUnipolar.TabStop = true;
            this.uiUnipolar.Text = "Unipolar";
            this.uiUnipolar.UseVisualStyleBackColor = true;
            // 
            // uiBipolar
            // 
            this.uiBipolar.AutoSize = true;
            this.uiBipolar.Location = new System.Drawing.Point(6, 42);
            this.uiBipolar.Name = "uiBipolar";
            this.uiBipolar.Size = new System.Drawing.Size(57, 17);
            this.uiBipolar.TabIndex = 0;
            this.uiBipolar.Text = "Bipolar";
            this.uiBipolar.UseVisualStyleBackColor = true;
            // 
            // SetUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiInputCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetUpPanel";
            this.Size = new System.Drawing.Size(428, 274);
            ((System.ComponentModel.ISupportInitialize)(this.uiInputCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uiInputCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton uiBipolar;
        private System.Windows.Forms.RadioButton uiUnipolar;
    }
}
