namespace RTadeusiewicz.NN.Example10a
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
            this.imgBitmap = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBitmap
            // 
            this.imgBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.imgBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBitmap.Location = new System.Drawing.Point(4, 4);
            this.imgBitmap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgBitmap.Name = "imgBitmap";
            this.imgBitmap.Size = new System.Drawing.Size(399, 369);
            this.imgBitmap.TabIndex = 1;
            this.imgBitmap.TabStop = false;
            this.imgBitmap.Click += new System.EventHandler(this.imgBitmap_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 391);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(48, 392);
            this.btNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 28);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Continue";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Visible = false;
            this.btNext.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 37);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(364, 386);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(31, 37);
            this.explanationToolTip1.TabIndex = 9;
            this.explanationToolTip1.ToolTipText = "Neurons";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imgBitmap);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(413, 491);
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBitmap;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
    }
}
