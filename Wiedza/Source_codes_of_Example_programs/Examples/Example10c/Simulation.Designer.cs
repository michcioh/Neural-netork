namespace RTadeusiewicz.NN.Example10c
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
            this.button4_ = new System.Windows.Forms.Button();
            this.button1_ = new System.Windows.Forms.Button();
            this.button2_ = new System.Windows.Forms.Button();
            this.button3_ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBitmap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBitmap
            // 
            this.imgBitmap.BackColor = System.Drawing.SystemColors.Control;
            this.imgBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBitmap.Location = new System.Drawing.Point(3, 3);
            this.imgBitmap.Name = "imgBitmap";
            this.imgBitmap.Size = new System.Drawing.Size(300, 300);
            this.imgBitmap.TabIndex = 1;
            this.imgBitmap.TabStop = false;
            this.imgBitmap.Click += new System.EventHandler(this.imgBitmap_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(10, 318);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button6_Click);
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(8, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 30);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(277, 310);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 30);
            this.explanationToolTip1.TabIndex = 9;
            this.explanationToolTip1.ToolTipText = "Neurons";
            // 
            // cbRandomLearning
            // 
            this.cbRandomLearning.AutoSize = true;
            this.cbRandomLearning.Location = new System.Drawing.Point(169, 367);
            this.cbRandomLearning.Name = "cbRandomLearning";
            this.cbRandomLearning.Size = new System.Drawing.Size(94, 17);
            this.cbRandomLearning.TabIndex = 10;
            this.cbRandomLearning.Text = "RND Learning";
            this.cbRandomLearning.UseVisualStyleBackColor = true;
            this.cbRandomLearning.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4_
            // 
            this.button4_.BackColor = System.Drawing.Color.White;
            this.button4_.Location = new System.Drawing.Point(229, 333);
            this.button4_.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4_.Name = "button4_";
            this.button4_.Size = new System.Drawing.Size(29, 19);
            this.button4_.TabIndex = 18;
            this.button4_.Tag = "4";
            this.button4_.Text = "IV";
            this.button4_.UseVisualStyleBackColor = false;
            this.button4_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button1_
            // 
            this.button1_.BackColor = System.Drawing.Color.White;
            this.button1_.Location = new System.Drawing.Point(229, 313);
            this.button1_.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1_.Name = "button1_";
            this.button1_.Size = new System.Drawing.Size(29, 19);
            this.button1_.TabIndex = 17;
            this.button1_.Tag = "1";
            this.button1_.Text = "I";
            this.button1_.UseVisualStyleBackColor = false;
            this.button1_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button2_
            // 
            this.button2_.BackColor = System.Drawing.Color.White;
            this.button2_.Location = new System.Drawing.Point(196, 313);
            this.button2_.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2_.Name = "button2_";
            this.button2_.Size = new System.Drawing.Size(29, 19);
            this.button2_.TabIndex = 16;
            this.button2_.Tag = "2";
            this.button2_.Text = "II";
            this.button2_.UseVisualStyleBackColor = false;
            this.button2_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button3_
            // 
            this.button3_.BackColor = System.Drawing.Color.White;
            this.button3_.Location = new System.Drawing.Point(196, 333);
            this.button3_.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3_.Name = "button3_";
            this.button3_.Size = new System.Drawing.Size(29, 19);
            this.button3_.TabIndex = 15;
            this.button3_.Tag = "3";
            this.button3_.Text = "III";
            this.button3_.UseVisualStyleBackColor = false;
            this.button3_.Click += new System.EventHandler(this.button1__Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "new pattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4_);
            this.Controls.Add(this.button1_);
            this.Controls.Add(this.button2_);
            this.Controls.Add(this.button3_);
            this.Controls.Add(this.cbRandomLearning);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imgBitmap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(310, 399);
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
        private System.Windows.Forms.Button button4_;
        private System.Windows.Forms.Button button1_;
        private System.Windows.Forms.Button button2_;
        private System.Windows.Forms.Button button3_;
        private System.Windows.Forms.Button button1;
    }
}
