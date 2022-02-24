namespace RTadeusiewicz.NN.Example05
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.noisyCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanCheckBox = new System.Windows.Forms.CheckBox();
            this.weightsCombo = new System.Windows.Forms.ComboBox();
            this.weights = new System.Windows.Forms.Label();
            this.chosenCase = new System.Windows.Forms.Label();
            this.chosenCaseCombo = new System.Windows.Forms.ComboBox();
            this.simMode = new System.Windows.Forms.Label();
            this.simModeCombo = new System.Windows.Forms.ComboBox();
            this.stepNr = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.plotArea = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(999, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.configToolStripMenuItem.Text = "Configuration";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAboutToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.aboutToolStripMenuItem.Text = "About ...";
            // 
            // aboutAboutToolStripMenuItem
            // 
            this.aboutAboutToolStripMenuItem.Name = "aboutAboutToolStripMenuItem";
            this.aboutAboutToolStripMenuItem.Size = new System.Drawing.Size(355, 22);
            this.aboutAboutToolStripMenuItem.Text = "About Signal filtering (egample 05)";
            this.aboutAboutToolStripMenuItem.Click += new System.EventHandler(this.aboutAboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.weightsCombo);
            this.groupBox1.Controls.Add(this.weights);
            this.groupBox1.Controls.Add(this.chosenCase);
            this.groupBox1.Controls.Add(this.chosenCaseCombo);
            this.groupBox1.Controls.Add(this.simMode);
            this.groupBox1.Controls.Add(this.simModeCombo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(856, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(140, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.noisyCheckBox);
            this.groupBox3.Controls.Add(this.cleanCheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(5, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(123, 73);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show signal";
            // 
            // noisyCheckBox
            // 
            this.noisyCheckBox.AutoSize = true;
            this.noisyCheckBox.Location = new System.Drawing.Point(13, 47);
            this.noisyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.noisyCheckBox.Name = "noisyCheckBox";
            this.noisyCheckBox.Size = new System.Drawing.Size(65, 21);
            this.noisyCheckBox.TabIndex = 15;
            this.noisyCheckBox.Text = "noisy";
            this.toolTip1.SetToolTip(this.noisyCheckBox, "Plot noisy signal");
            this.noisyCheckBox.UseVisualStyleBackColor = true;
            this.noisyCheckBox.CheckedChanged += new System.EventHandler(this.noisyCheckedChanged);
            // 
            // cleanCheckBox
            // 
            this.cleanCheckBox.AutoSize = true;
            this.cleanCheckBox.Location = new System.Drawing.Point(12, 22);
            this.cleanCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cleanCheckBox.Name = "cleanCheckBox";
            this.cleanCheckBox.Size = new System.Drawing.Size(97, 21);
            this.cleanCheckBox.TabIndex = 14;
            this.cleanCheckBox.Text = "reference";
            this.toolTip1.SetToolTip(this.cleanCheckBox, "Plot reference signal");
            this.cleanCheckBox.UseVisualStyleBackColor = true;
            this.cleanCheckBox.CheckedChanged += new System.EventHandler(this.cleanCheckedChanged);
            // 
            // weightsCombo
            // 
            this.weightsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightsCombo.FormattingEnabled = true;
            this.weightsCombo.Items.AddRange(new object[] {
            "Standard",
            "Average"});
            this.weightsCombo.Location = new System.Drawing.Point(9, 146);
            this.weightsCombo.Margin = new System.Windows.Forms.Padding(4);
            this.weightsCombo.Name = "weightsCombo";
            this.weightsCombo.Size = new System.Drawing.Size(127, 24);
            this.weightsCombo.TabIndex = 12;
            this.toolTip1.SetToolTip(this.weightsCombo, "Weights selection");
            // 
            // weights
            // 
            this.weights.AutoSize = true;
            this.weights.Location = new System.Drawing.Point(13, 126);
            this.weights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weights.Name = "weights";
            this.weights.Size = new System.Drawing.Size(66, 17);
            this.weights.TabIndex = 11;
            this.weights.Text = "Weights";
            // 
            // chosenCase
            // 
            this.chosenCase.AutoSize = true;
            this.chosenCase.Location = new System.Drawing.Point(9, 74);
            this.chosenCase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chosenCase.Name = "chosenCase";
            this.chosenCase.Size = new System.Drawing.Size(101, 17);
            this.chosenCase.TabIndex = 10;
            this.chosenCase.Text = "Choose case";
            //this.chosenCase.Click += new System.EventHandler(this.chosenCase_Click);
            // 
            // chosenCaseCombo
            // 
            this.chosenCaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chosenCaseCombo.FormattingEnabled = true;
            this.chosenCaseCombo.Items.AddRange(new object[] {
            "Basic one",
            "With shift"});
            this.chosenCaseCombo.Location = new System.Drawing.Point(9, 94);
            this.chosenCaseCombo.Margin = new System.Windows.Forms.Padding(4);
            this.chosenCaseCombo.Name = "chosenCaseCombo";
            this.chosenCaseCombo.Size = new System.Drawing.Size(127, 24);
            this.chosenCaseCombo.TabIndex = 9;
            this.toolTip1.SetToolTip(this.chosenCaseCombo, "Choosing a signal with or without shift.");
            this.chosenCaseCombo.SelectedIndexChanged += new System.EventHandler(this.chosenCaseCombo_SelectedIndexChanged);
            // 
            // simMode
            // 
            this.simMode.AutoSize = true;
            this.simMode.Location = new System.Drawing.Point(8, 21);
            this.simMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.simMode.Name = "simMode";
            this.simMode.Size = new System.Drawing.Size(131, 17);
            this.simMode.TabIndex = 3;
            this.simMode.Text = "Symulation mode";
            // 
            // simModeCombo
            // 
            this.simModeCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.simModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.simModeCombo.FormattingEnabled = true;
            this.simModeCombo.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.simModeCombo.Location = new System.Drawing.Point(8, 43);
            this.simModeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.simModeCombo.Name = "simModeCombo";
            this.simModeCombo.Size = new System.Drawing.Size(128, 24);
            this.simModeCombo.TabIndex = 2;
            this.simModeCombo.Tag = "";
            this.toolTip1.SetToolTip(this.simModeCombo, "Symulation type selection");
            // 
            // stepNr
            // 
            this.stepNr.AutoSize = true;
            this.stepNr.Location = new System.Drawing.Point(11, 48);
            this.stepNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepNr.Name = "stepNr";
            this.stepNr.Size = new System.Drawing.Size(51, 17);
            this.stepNr.TabIndex = 8;
            this.stepNr.Text = "Step: ";
            // 
            // stop
            // 
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stop.Location = new System.Drawing.Point(15, 103);
            this.stop.Margin = new System.Windows.Forms.Padding(4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(108, 28);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.toolTip1.SetToolTip(this.stop, "Stop teaching process");
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start.Location = new System.Drawing.Point(15, 26);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(108, 28);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.toolTip1.SetToolTip(this.start, "Start teaching process");
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // next
            // 
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Location = new System.Drawing.Point(14, 63);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(109, 28);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.toolTip1.SetToolTip(this.next, "Next learning step (only manual mode).");
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 26);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.progressBar1, "Simulation progress");
            this.progressBar1.Value = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.next);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(857, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(139, 179);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigation";
            // 
            // reset
            // 
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reset.Location = new System.Drawing.Point(15, 139);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 28);
            this.reset.TabIndex = 17;
            this.reset.Text = "Reset";
            this.toolTip1.SetToolTip(this.reset, "Clear plotting and set default settings.");
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.stepNr);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(857, 497);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(139, 73);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progress";
            //this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // plotArea
            // 
            this.plotArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plotArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plotArea.Location = new System.Drawing.Point(5, 30);
            this.plotArea.Margin = new System.Windows.Forms.Padding(4);
            this.plotArea.Name = "plotArea";
            this.plotArea.Size = new System.Drawing.Size(844, 598);
            this.plotArea.TabIndex = 4;
            this.plotArea.Text = "plotArea";
            this.plotArea.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("plotArea.VisibleRectangle")));
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(922, 588);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(5);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(31, 28);
            this.explanationToolTip1.TabIndex = 16;
            this.explanationToolTip1.ToolTipText = "Program window showing singal filtering.";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 633);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.plotArea);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrame";
            this.Text = "Signal filtering (egample 05)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            //this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolTip toolTip1;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox simModeCombo;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label simMode;
        private System.Windows.Forms.Label stepNr;
        private System.Windows.Forms.Label chosenCase;
        private System.Windows.Forms.ComboBox chosenCaseCombo;
        private System.Windows.Forms.ComboBox weightsCombo;
        private System.Windows.Forms.Label weights;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAboutToolStripMenuItem;
        private RTadeusiewicz.NN.Controls.ChartPlotter plotArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox noisyCheckBox;
        private System.Windows.Forms.CheckBox cleanCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button reset;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
    }
}

