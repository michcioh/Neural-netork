/*
 * UWAGA: Ten plik jest automatycznie generowany przez narzêdzie do budowy
 * interfejsów okienkowych Visual Studio. Nie zawiera nic, co by³oby istotne
 * z punktu widzenia Czytelnika interesuj¹cego siê sieciami neuronowymi.
 * 
 * Aby obejrzeæ istotne kawa³ki kodu, obejrzyj plik "MainForm.cs".
 */

namespace RTadeusiewicz.NN.Example01a
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiWeightColorful = new System.Windows.Forms.NumericUpDown();
            this.uiWeightFragrant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uiObjectColorful = new System.Windows.Forms.NumericUpDown();
            this.uiObjectFragrant = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uiAttitude = new System.Windows.Forms.Label();
            this.uiOutput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeightColorful)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeightFragrant)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiObjectColorful)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiObjectFragrant)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "The neuron that you will be examining will divide the objects you will show it in" +
                "to the ones that it likes and the ones it dislikes.\r\n\r\nLet\'s assume that the rec" +
                "ognized objects are flowers.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uiWeightColorful);
            this.groupBox1.Controls.Add(this.uiWeightFragrant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feature weights";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Colorful:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fragrant:";
            // 
            // uiWeightColorful
            // 
            this.uiWeightColorful.DecimalPlaces = 1;
            this.uiWeightColorful.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeightColorful.Location = new System.Drawing.Point(289, 91);
            this.uiWeightColorful.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiWeightColorful.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiWeightColorful.Name = "uiWeightColorful";
            this.uiWeightColorful.Size = new System.Drawing.Size(72, 20);
            this.uiWeightColorful.TabIndex = 4;
            this.uiWeightColorful.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // uiWeightFragrant
            // 
            this.uiWeightFragrant.DecimalPlaces = 1;
            this.uiWeightFragrant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeightFragrant.Location = new System.Drawing.Point(94, 91);
            this.uiWeightFragrant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiWeightFragrant.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiWeightFragrant.Name = "uiWeightFragrant";
            this.uiWeightFragrant.Size = new System.Drawing.Size(72, 20);
            this.uiWeightFragrant.TabIndex = 2;
            this.uiWeightFragrant.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.uiObjectColorful);
            this.groupBox2.Controls.Add(this.uiObjectFragrant);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluated object";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Colorful:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "After setting the weights, you can perform experiments. Enter if the flower is:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fragrant:";
            // 
            // uiObjectColorful
            // 
            this.uiObjectColorful.DecimalPlaces = 1;
            this.uiObjectColorful.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiObjectColorful.Location = new System.Drawing.Point(289, 35);
            this.uiObjectColorful.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiObjectColorful.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiObjectColorful.Name = "uiObjectColorful";
            this.uiObjectColorful.Size = new System.Drawing.Size(72, 20);
            this.uiObjectColorful.TabIndex = 3;
            this.uiObjectColorful.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // uiObjectFragrant
            // 
            this.uiObjectFragrant.DecimalPlaces = 1;
            this.uiObjectFragrant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiObjectFragrant.Location = new System.Drawing.Point(94, 35);
            this.uiObjectFragrant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiObjectFragrant.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiObjectFragrant.Name = "uiObjectFragrant";
            this.uiObjectFragrant.Size = new System.Drawing.Size(72, 20);
            this.uiObjectFragrant.TabIndex = 1;
            this.uiObjectFragrant.ValueChanged += new System.EventHandler(this.ParameterChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.uiAttitude);
            this.groupBox3.Controls.Add(this.uiOutput);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neuron\'s response";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Recalculate!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uiAttitude
            // 
            this.uiAttitude.AutoSize = true;
            this.uiAttitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiAttitude.Location = new System.Drawing.Point(286, 35);
            this.uiAttitude.Margin = new System.Windows.Forms.Padding(3);
            this.uiAttitude.Name = "uiAttitude";
            this.uiAttitude.Size = new System.Drawing.Size(19, 13);
            this.uiAttitude.TabIndex = 3;
            this.uiAttitude.Text = "   ";
            // 
            // uiOutput
            // 
            this.uiOutput.AutoSize = true;
            this.uiOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOutput.Location = new System.Drawing.Point(286, 16);
            this.uiOutput.Margin = new System.Windows.Forms.Padding(3);
            this.uiOutput.Name = "uiOutput";
            this.uiOutput.Size = new System.Drawing.Size(19, 13);
            this.uiOutput.TabIndex = 2;
            this.uiOutput.Text = "   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "It means that the neuron\'s attitude against the flower is:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "The neuron\'s response value is:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Single neuron examination (example 01a)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeightColorful)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiWeightFragrant)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiObjectColorful)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiObjectFragrant)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown uiWeightFragrant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uiWeightColorful;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uiObjectColorful;
        private System.Windows.Forms.NumericUpDown uiObjectFragrant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label uiAttitude;
        private System.Windows.Forms.Label uiOutput;
        private System.Windows.Forms.Button button1;
    }
}

