namespace RTadeusiewicz.NN.Example06a
{
    partial class ExperimentPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperimentPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.uiNeuronParams = new System.Windows.Forms.DataGridView();
            this.uiInputNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiWeightCol = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.uiSignalCol = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uiResponse = new System.Windows.Forms.TextBox();
            this.uiSignalStrength = new System.Windows.Forms.TextBox();
            this.uiMemStrength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiNeuronType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiNeuronParams)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perform experiments";
            // 
            // uiNeuronParams
            // 
            this.uiNeuronParams.AllowUserToAddRows = false;
            this.uiNeuronParams.AllowUserToDeleteRows = false;
            this.uiNeuronParams.AllowUserToResizeRows = false;
            this.uiNeuronParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNeuronParams.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiNeuronParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiNeuronParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uiInputNumberCol,
            this.uiWeightCol,
            this.uiSignalCol});
            this.uiNeuronParams.Location = new System.Drawing.Point(6, 58);
            this.uiNeuronParams.MultiSelect = false;
            this.uiNeuronParams.Name = "uiNeuronParams";
            this.uiNeuronParams.RowHeadersVisible = false;
            this.uiNeuronParams.Size = new System.Drawing.Size(212, 209);
            this.uiNeuronParams.TabIndex = 1;
            this.uiNeuronParams.VirtualMode = true;
            this.uiNeuronParams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiNeuronParams_CellClick);
            this.uiNeuronParams.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.uiNeuronParams_CellValueNeeded);
            this.uiNeuronParams.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.uiNeuronParams_CellValuePushed);
            // 
            // uiInputNumberCol
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiInputNumberCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.uiInputNumberCol.HeaderText = "i";
            this.uiInputNumberCol.Name = "uiInputNumberCol";
            this.uiInputNumberCol.ReadOnly = true;
            this.uiInputNumberCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.uiInputNumberCol.ToolTipText = "The input number";
            this.uiInputNumberCol.Width = 40;
            // 
            // uiWeightCol
            // 
            this.uiWeightCol.DecimalPlaces = 1;
            this.uiWeightCol.HeaderText = "w(i)";
            this.uiWeightCol.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiWeightCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiWeightCol.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiWeightCol.Name = "uiWeightCol";
            this.uiWeightCol.ToolTipText = "The input weight value";
            this.uiWeightCol.Width = 70;
            // 
            // uiSignalCol
            // 
            this.uiSignalCol.DecimalPlaces = 1;
            this.uiSignalCol.HeaderText = "x(i)";
            this.uiSignalCol.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiSignalCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiSignalCol.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.uiSignalCol.Name = "uiSignalCol";
            this.uiSignalCol.ToolTipText = "The input signal value";
            this.uiSignalCol.Width = 70;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the input weights and signal values in the table below.";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(195, 19);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip1.TabIndex = 3;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.uiNeuronType);
            this.groupBox1.Controls.Add(this.uiNeuronParams);
            this.groupBox1.Controls.Add(this.explanationToolTip1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Experiment data";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.uiResponse);
            this.groupBox2.Controls.Add(this.uiSignalStrength);
            this.groupBox2.Controls.Add(this.uiMemStrength);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(233, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experiment result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Recalculate!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uiResponse
            // 
            this.uiResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiResponse.BackColor = System.Drawing.SystemColors.Control;
            this.uiResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiResponse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiResponse.Location = new System.Drawing.Point(135, 71);
            this.uiResponse.Name = "uiResponse";
            this.uiResponse.Size = new System.Drawing.Size(144, 26);
            this.uiResponse.TabIndex = 1;
            // 
            // uiSignalStrength
            // 
            this.uiSignalStrength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSignalStrength.BackColor = System.Drawing.SystemColors.Control;
            this.uiSignalStrength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiSignalStrength.Location = new System.Drawing.Point(135, 45);
            this.uiSignalStrength.Name = "uiSignalStrength";
            this.uiSignalStrength.Size = new System.Drawing.Size(144, 20);
            this.uiSignalStrength.TabIndex = 1;
            // 
            // uiMemStrength
            // 
            this.uiMemStrength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMemStrength.BackColor = System.Drawing.SystemColors.Control;
            this.uiMemStrength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiMemStrength.Location = new System.Drawing.Point(135, 19);
            this.uiMemStrength.Name = "uiMemStrength";
            this.uiMemStrength.Size = new System.Drawing.Size(144, 20);
            this.uiMemStrength.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Memory trace strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input signal strength:";
            // 
            // uiNeuronType
            // 
            this.uiNeuronType.AutoSize = true;
            this.uiNeuronType.Location = new System.Drawing.Point(6, 270);
            this.uiNeuronType.Name = "uiNeuronType";
            this.uiNeuronType.Size = new System.Drawing.Size(35, 13);
            this.uiNeuronType.TabIndex = 3;
            this.uiNeuronType.Text = "label6";
            // 
            // ExperimentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ExperimentPanel";
            this.Size = new System.Drawing.Size(521, 312);
            ((System.ComponentModel.ISupportInitialize)(this.uiNeuronParams)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiNeuronParams;
        private System.Windows.Forms.Label label2;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiInputNumberCol;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn uiWeightCol;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn uiSignalCol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiResponse;
        private System.Windows.Forms.TextBox uiSignalStrength;
        private System.Windows.Forms.TextBox uiMemStrength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label uiNeuronType;
    }
}
