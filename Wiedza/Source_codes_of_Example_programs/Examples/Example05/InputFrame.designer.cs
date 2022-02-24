namespace RTadeusiewicz.NN.Example05
{
    partial class InputFrame
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
            this.netSizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noiseLevelTextBox = new System.Windows.Forms.TextBox();
            this.netSizeLabel = new System.Windows.Forms.Label();
            this.noiseLevelLabel = new System.Windows.Forms.Label();
            this.freqLabel = new System.Windows.Forms.Label();
            this.freqTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.stepsNrTextBox = new System.Windows.Forms.TextBox();
            this.stepsNrLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.defaults = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // netSizeTextBox
            // 
            this.netSizeTextBox.AcceptsReturn = true;
            this.netSizeTextBox.Location = new System.Drawing.Point(73, 65);
            this.netSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.netSizeTextBox.Name = "netSizeTextBox";
            this.netSizeTextBox.Size = new System.Drawing.Size(132, 22);
            this.netSizeTextBox.TabIndex = 0;
            this.netSizeTextBox.Text = "500";
            this.toolTip1.SetToolTip(this.netSizeTextBox, "Number of neurons.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter parameters:";
            // 
            // noiseLevelTextBox
            // 
            this.noiseLevelTextBox.Location = new System.Drawing.Point(74, 113);
            this.noiseLevelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noiseLevelTextBox.Name = "noiseLevelTextBox";
            this.noiseLevelTextBox.Size = new System.Drawing.Size(132, 22);
            this.noiseLevelTextBox.TabIndex = 2;
            this.noiseLevelTextBox.Text = "0,5";
            this.toolTip1.SetToolTip(this.noiseLevelTextBox, "Noise level.");
            // 
            // netSizeLabel
            // 
            this.netSizeLabel.AutoSize = true;
            this.netSizeLabel.Location = new System.Drawing.Point(70, 45);
            this.netSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.netSizeLabel.Name = "netSizeLabel";
            this.netSizeLabel.Size = new System.Drawing.Size(100, 17);
            this.netSizeLabel.TabIndex = 3;
            this.netSizeLabel.Text = "Network size";
            // 
            // noiseLevelLabel
            // 
            this.noiseLevelLabel.AutoSize = true;
            this.noiseLevelLabel.Location = new System.Drawing.Point(70, 93);
            this.noiseLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noiseLevelLabel.Name = "noiseLevelLabel";
            this.noiseLevelLabel.Size = new System.Drawing.Size(155, 17);
            this.noiseLevelLabel.TabIndex = 4;
            this.noiseLevelLabel.Text = "Noise level measure";
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Location = new System.Drawing.Point(72, 141);
            this.freqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(84, 17);
            this.freqLabel.TabIndex = 5;
            this.freqLabel.Text = "Frequency";
            // 
            // freqTextBox
            // 
            this.freqTextBox.Location = new System.Drawing.Point(73, 162);
            this.freqTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.freqTextBox.Name = "freqTextBox";
            this.freqTextBox.Size = new System.Drawing.Size(132, 22);
            this.freqTextBox.TabIndex = 6;
            this.freqTextBox.Text = "0,02";
            this.toolTip1.SetToolTip(this.freqTextBox, "Częstotliwość sygnału.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.explanationToolTip1);
            this.groupBox1.Controls.Add(this.stepsNrTextBox);
            this.groupBox1.Controls.Add(this.stepsNrLabel);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.accept);
            this.groupBox1.Controls.Add(this.defaults);
            this.groupBox1.Controls.Add(this.freqTextBox);
            this.groupBox1.Controls.Add(this.freqLabel);
            this.groupBox1.Controls.Add(this.noiseLevelLabel);
            this.groupBox1.Controls.Add(this.netSizeLabel);
            this.groupBox1.Controls.Add(this.noiseLevelTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.netSizeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 347);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(266, 9);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(35, 28);
            this.explanationToolTip1.TabIndex = 13;
            this.explanationToolTip1.ToolTipText = "Signal description and teaching settings.";
            // 
            // stepsNrTextBox
            // 
            this.stepsNrTextBox.Location = new System.Drawing.Point(75, 209);
            this.stepsNrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stepsNrTextBox.Name = "stepsNrTextBox";
            this.stepsNrTextBox.Size = new System.Drawing.Size(132, 22);
            this.stepsNrTextBox.TabIndex = 12;
            this.stepsNrTextBox.Text = "50";
            this.toolTip1.SetToolTip(this.stepsNrTextBox, "Number of teaching steps.");
            // 
            // stepsNrLabel
            // 
            this.stepsNrLabel.AutoSize = true;
            this.stepsNrLabel.Location = new System.Drawing.Point(72, 187);
            this.stepsNrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepsNrLabel.Name = "stepsNrLabel";
            this.stepsNrLabel.Size = new System.Drawing.Size(194, 17);
            this.stepsNrLabel.TabIndex = 11;
            this.stepsNrLabel.Text = "Number of teaching steps";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(159, 302);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancel, "Cancel.");
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(27, 302);
            this.accept.Margin = new System.Windows.Forms.Padding(4);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(100, 28);
            this.accept.TabIndex = 8;
            this.accept.Text = "Apply";
            this.toolTip1.SetToolTip(this.accept, "Apply.");
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // defaults
            // 
            this.defaults.Location = new System.Drawing.Point(88, 252);
            this.defaults.Margin = new System.Windows.Forms.Padding(4);
            this.defaults.Name = "defaults";
            this.defaults.Size = new System.Drawing.Size(118, 29);
            this.defaults.TabIndex = 7;
            this.defaults.Text = "Default";
            this.toolTip1.SetToolTip(this.defaults, "Default settings.");
            this.defaults.UseVisualStyleBackColor = true;
            this.defaults.Click += new System.EventHandler(this.defaults_Click);
            // 
            // InputFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 362);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputFrame";
            this.Text = "Data generation  and NN settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputFrame_FormClosing);
            this.Load += new System.EventHandler(this.InputFrame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.ToolTip toolTip1;

        #endregion

        private System.Windows.Forms.TextBox netSizeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noiseLevelTextBox;
        private System.Windows.Forms.Label netSizeLabel;
        private System.Windows.Forms.Label noiseLevelLabel;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.TextBox freqTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button defaults;
        private System.Windows.Forms.TextBox stepsNrTextBox;
        private System.Windows.Forms.Label stepsNrLabel;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
    }
}