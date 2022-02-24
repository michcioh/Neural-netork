namespace LibraryTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartPlotter1 = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartPlotter2 = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartPlotter3 = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.chartPlotter4 = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chartPlotter5 = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 357);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartPlotter1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Point data series";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartPlotter1
            // 
            this.chartPlotter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPlotter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartPlotter1.Location = new System.Drawing.Point(3, 67);
            this.chartPlotter1.Name = "chartPlotter1";
            this.chartPlotter1.Size = new System.Drawing.Size(405, 261);
            this.chartPlotter1.TabIndex = 3;
            this.chartPlotter1.Text = "chartPlotter1";
            this.chartPlotter1.TicksVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.None;
            this.chartPlotter1.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("chartPlotter1.VisibleRectangle")));
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(3, 3);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(405, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartPlotter2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Linear data series";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartPlotter2
            // 
            this.chartPlotter2.AxesVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.Horizontal;
            this.chartPlotter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartPlotter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPlotter2.Location = new System.Drawing.Point(3, 3);
            this.chartPlotter2.Name = "chartPlotter2";
            this.chartPlotter2.Size = new System.Drawing.Size(405, 325);
            this.chartPlotter2.TabIndex = 0;
            this.chartPlotter2.Text = "chartPlotter1";
            this.chartPlotter2.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("chartPlotter2.VisibleRectangle")));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartPlotter3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(411, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2D surface";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartPlotter3
            // 
            this.chartPlotter3.AxesVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.None;
            this.chartPlotter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartPlotter3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPlotter3.Location = new System.Drawing.Point(3, 3);
            this.chartPlotter3.Name = "chartPlotter3";
            this.chartPlotter3.Size = new System.Drawing.Size(405, 325);
            this.chartPlotter3.TabIndex = 0;
            this.chartPlotter3.Text = "chartPlotter3";
            this.chartPlotter3.TicksVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.None;
            this.chartPlotter3.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("chartPlotter3.VisibleRectangle")));
            this.chartPlotter3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartPlotter3_MouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox2);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.trackBar3);
            this.tabPage4.Controls.Add(this.chartPlotter4);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.trackBar2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(411, 331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Network output";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(190, 308);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Sigmoidal neurons";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show the lines";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar3.Location = new System.Drawing.Point(6, 57);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 268);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // chartPlotter4
            // 
            this.chartPlotter4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPlotter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartPlotter4.Location = new System.Drawing.Point(57, 57);
            this.chartPlotter4.Name = "chartPlotter4";
            this.chartPlotter4.Size = new System.Drawing.Size(348, 245);
            this.chartPlotter4.TabIndex = 2;
            this.chartPlotter4.Text = "chartPlotter4";
            this.chartPlotter4.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("chartPlotter4.VisibleRectangle")));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Randomize weights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(87, 6);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(318, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.checkBox3);
            this.tabPage5.Controls.Add(this.chartPlotter5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(411, 331);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "History";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 306);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Continuous";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chartPlotter5
            // 
            this.chartPlotter5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPlotter5.AxesVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.Horizontal;
            this.chartPlotter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartPlotter5.Location = new System.Drawing.Point(6, 6);
            this.chartPlotter5.Name = "chartPlotter5";
            this.chartPlotter5.Size = new System.Drawing.Size(399, 290);
            this.chartPlotter5.TabIndex = 0;
            this.chartPlotter5.Text = "chartPlotter5";
            this.chartPlotter5.TicksVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.Vertical;
            this.chartPlotter5.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("chartPlotter5.VisibleRectangle")));
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 357);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RTadeusiewicz.NN.Controls.ChartPlotter chartPlotter2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RTadeusiewicz.NN.Controls.ChartPlotter chartPlotter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private RTadeusiewicz.NN.Controls.ChartPlotter chartPlotter3;
        private System.Windows.Forms.TabPage tabPage4;
        private RTadeusiewicz.NN.Controls.ChartPlotter chartPlotter4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tabPage5;
        private RTadeusiewicz.NN.Controls.ChartPlotter chartPlotter5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox3;

    }
}

