namespace RTadeusiewicz.NN.Example10b
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
            this.components = new System.ComponentModel.Container();
            this.imgBitmap = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.cbRandomLearning = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3_ = new System.Windows.Forms.Button();
            this.button2_ = new System.Windows.Forms.Button();
            this.button1_ = new System.Windows.Forms.Button();
            this.button4_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBitmap
            // 
            this.imgBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.imgBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBitmap.Location = new System.Drawing.Point(4, 4);
            this.imgBitmap.Margin = new System.Windows.Forms.Padding(4);
            this.imgBitmap.Name = "imgBitmap";
            this.imgBitmap.Size = new System.Drawing.Size(399, 369);
            this.imgBitmap.TabIndex = 1;
            this.imgBitmap.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 391);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(8, 393);
            this.btStart.Margin = new System.Windows.Forms.Padding(4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(100, 28);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 37);
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
            this.explanationToolTip1.Location = new System.Drawing.Point(373, 385);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(5);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(31, 37);
            this.explanationToolTip1.TabIndex = 9;
            this.explanationToolTip1.ToolTipText = "Neurons";
            // 
            // cbRandomLearning
            // 
            this.cbRandomLearning.AutoSize = true;
            this.cbRandomLearning.Location = new System.Drawing.Point(296, 447);
            this.cbRandomLearning.Margin = new System.Windows.Forms.Padding(4);
            this.cbRandomLearning.Name = "cbRandomLearning";
            this.cbRandomLearning.Size = new System.Drawing.Size(120, 21);
            this.cbRandomLearning.TabIndex = 10;
            this.cbRandomLearning.Text = "RND Learning";
            this.cbRandomLearning.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3_
            // 
            this.button3_.BackColor = System.Drawing.Color.White;
            this.button3_.Location = new System.Drawing.Point(260, 406);
            this.button3_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3_.Name = "button3_";
            this.button3_.Size = new System.Drawing.Size(39, 23);
            this.button3_.TabIndex = 11;
            this.button3_.Tag = "3";
            this.button3_.Text = "III";
            this.button3_.UseVisualStyleBackColor = false;
            this.button3_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button2_
            // 
            this.button2_.BackColor = System.Drawing.Color.White;
            this.button2_.Location = new System.Drawing.Point(260, 380);
            this.button2_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2_.Name = "button2_";
            this.button2_.Size = new System.Drawing.Size(39, 23);
            this.button2_.TabIndex = 12;
            this.button2_.Tag = "2";
            this.button2_.Text = "II";
            this.button2_.UseVisualStyleBackColor = false;
            this.button2_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button1_
            // 
            this.button1_.BackColor = System.Drawing.Color.White;
            this.button1_.Location = new System.Drawing.Point(304, 380);
            this.button1_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1_.Name = "button1_";
            this.button1_.Size = new System.Drawing.Size(39, 23);
            this.button1_.TabIndex = 13;
            this.button1_.Tag = "1";
            this.button1_.Text = "I";
            this.button1_.UseVisualStyleBackColor = false;
            this.button1_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button4_
            // 
            this.button4_.BackColor = System.Drawing.Color.White;
            this.button4_.Location = new System.Drawing.Point(304, 406);
            this.button4_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4_.Name = "button4_";
            this.button4_.Size = new System.Drawing.Size(39, 23);
            this.button4_.TabIndex = 14;
            this.button4_.Tag = "4";
            this.button4_.Text = "IV";
            this.button4_.UseVisualStyleBackColor = false;
            this.button4_.Click += new System.EventHandler(this.button1__Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.button4_);
            this.Controls.Add(this.cbRandomLearning);
            this.Controls.Add(this.button1_);
            this.Controls.Add(this.button2_);
            this.Controls.Add(this.button3_);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imgBitmap);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(437, 491);
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBitmap;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.CheckBox cbRandomLearning;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3_;
        private System.Windows.Forms.Button button2_;
        private System.Windows.Forms.Button button1_;
        private System.Windows.Forms.Button button4_;
    }
}
