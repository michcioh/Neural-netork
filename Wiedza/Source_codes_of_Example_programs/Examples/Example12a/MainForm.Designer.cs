namespace RTadeusiewicz.NN.Example12a
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiFeedbackWeight = new System.Windows.Forms.NumericUpDown();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputSignalStrength = new System.Windows.Forms.NumericUpDown();
            this.Continue_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartNew_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SingleInputImpulsCheckBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiFeedbackWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiInputSignalStrength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "feedback weight       =";
            // 
            // uiFeedbackWeight
            // 
            this.uiFeedbackWeight.DecimalPlaces = 1;
            this.uiFeedbackWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiFeedbackWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiFeedbackWeight.Location = new System.Drawing.Point(202, 40);
            this.uiFeedbackWeight.Margin = new System.Windows.Forms.Padding(4);
            this.uiFeedbackWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiFeedbackWeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiFeedbackWeight.Name = "uiFeedbackWeight";
            this.uiFeedbackWeight.Size = new System.Drawing.Size(101, 19);
            this.uiFeedbackWeight.TabIndex = 3;
            this.uiFeedbackWeight.ValueChanged += new System.EventHandler(this.uiFeedbackWeight_ValueChanged);
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(269, 335);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(35, 28);
            this.explanationToolTip1.TabIndex = 5;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "input signal strength =";
            // 
            // uiInputSignalStrength
            // 
            this.uiInputSignalStrength.DecimalPlaces = 1;
            this.uiInputSignalStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiInputSignalStrength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiInputSignalStrength.Location = new System.Drawing.Point(202, 13);
            this.uiInputSignalStrength.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputSignalStrength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.uiInputSignalStrength.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.uiInputSignalStrength.Name = "uiInputSignalStrength";
            this.uiInputSignalStrength.Size = new System.Drawing.Size(101, 19);
            this.uiInputSignalStrength.TabIndex = 7;
            // 
            // Continue_button
            // 
            this.Continue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Continue_button.Location = new System.Drawing.Point(6, 83);
            this.Continue_button.Name = "Continue_button";
            this.Continue_button.Size = new System.Drawing.Size(84, 23);
            this.Continue_button.TabIndex = 8;
            this.Continue_button.Text = "Continue";
            this.Continue_button.UseVisualStyleBackColor = true;
            this.Continue_button.Click += new System.EventHandler(this.Continue_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Step:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartNew_button);
            this.groupBox1.Controls.Add(this.Reset_button);
            this.groupBox1.Controls.Add(this.Continue_button);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(247, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 189);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "navigation";
            // 
            // StartNew_button
            // 
            this.StartNew_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartNew_button.Location = new System.Drawing.Point(5, 49);
            this.StartNew_button.Name = "StartNew_button";
            this.StartNew_button.Size = new System.Drawing.Size(86, 23);
            this.StartNew_button.TabIndex = 10;
            this.StartNew_button.Text = "Start New";
            this.StartNew_button.UseVisualStyleBackColor = true;
            this.StartNew_button.Click += new System.EventHandler(this.StartNew_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset_button.Location = new System.Drawing.Point(6, 116);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(85, 23);
            this.Reset_button.TabIndex = 9;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SingleInputImpulsCheckBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.uiFeedbackWeight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uiInputSignalStrength);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(2, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "single input impulse";
            // 
            // SingleInputImpulsCheckBox1
            // 
            this.SingleInputImpulsCheckBox1.AutoSize = true;
            this.SingleInputImpulsCheckBox1.Checked = true;
            this.SingleInputImpulsCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SingleInputImpulsCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SingleInputImpulsCheckBox1.Location = new System.Drawing.Point(202, 66);
            this.SingleInputImpulsCheckBox1.Name = "SingleInputImpulsCheckBox1";
            this.SingleInputImpulsCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.SingleInputImpulsCheckBox1.TabIndex = 8;
            this.SingleInputImpulsCheckBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "Simple recurrent NN (example 12a)";
            ((System.ComponentModel.ISupportInitialize)(this.uiFeedbackWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiInputSignalStrength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uiFeedbackWeight;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uiInputSignalStrength;
        private System.Windows.Forms.Button Continue_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox SingleInputImpulsCheckBox1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartNew_button;
    }
}

