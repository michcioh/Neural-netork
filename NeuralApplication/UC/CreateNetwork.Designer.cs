namespace Neural
{
    partial class CreateNetwork
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bCreateNetwork = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bResetToDefault = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsesBiasNeurons = new System.Windows.Forms.CheckBox();
            this.nudMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.nudMinWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLearningMethod = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLayers = new System.Windows.Forms.DataGridView();
            this.LayerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeuronsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pContent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // bCreateNetwork
            // 
            this.bCreateNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.bCreateNetwork.FlatAppearance.BorderSize = 0;
            this.bCreateNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateNetwork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCreateNetwork.ForeColor = System.Drawing.Color.White;
            this.bCreateNetwork.Location = new System.Drawing.Point(589, 286);
            this.bCreateNetwork.Name = "bCreateNetwork";
            this.bCreateNetwork.Size = new System.Drawing.Size(153, 25);
            this.bCreateNetwork.TabIndex = 9;
            this.bCreateNetwork.Text = "Create network";
            this.bCreateNetwork.UseVisualStyleBackColor = false;
            this.bCreateNetwork.Click += new System.EventHandler(this.BCreateNetwork_Click);
            // 
            // pContent
            // 
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.lTitle);
            this.pContent.Controls.Add(this.bCancel);
            this.pContent.Controls.Add(this.bResetToDefault);
            this.pContent.Controls.Add(this.groupBox2);
            this.pContent.Controls.Add(this.groupBox1);
            this.pContent.Controls.Add(this.bCreateNetwork);
            this.pContent.Location = new System.Drawing.Point(22, 75);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(748, 327);
            this.pContent.TabIndex = 10;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTitle.Location = new System.Drawing.Point(8, 11);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(145, 20);
            this.lTitle.TabIndex = 32;
            this.lTitle.Text = "Create new network";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Goldenrod;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(430, 286);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 25);
            this.bCancel.TabIndex = 31;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bResetToDefault
            // 
            this.bResetToDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bResetToDefault.BackColor = System.Drawing.Color.IndianRed;
            this.bResetToDefault.FlatAppearance.BorderSize = 0;
            this.bResetToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bResetToDefault.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bResetToDefault.ForeColor = System.Drawing.Color.White;
            this.bResetToDefault.Location = new System.Drawing.Point(3, 286);
            this.bResetToDefault.Name = "bResetToDefault";
            this.bResetToDefault.Size = new System.Drawing.Size(153, 25);
            this.bResetToDefault.TabIndex = 29;
            this.bResetToDefault.Text = "Reset to default";
            this.bResetToDefault.UseVisualStyleBackColor = false;
            this.bResetToDefault.Click += new System.EventHandler(this.BResetToDefault_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbUsesBiasNeurons);
            this.groupBox2.Controls.Add(this.nudMaxWeight);
            this.groupBox2.Controls.Add(this.nudMinWeight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbLearningMethod);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(3, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 234);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Max. weight:";
            // 
            // cbUsesBiasNeurons
            // 
            this.cbUsesBiasNeurons.AutoSize = true;
            this.cbUsesBiasNeurons.Checked = true;
            this.cbUsesBiasNeurons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUsesBiasNeurons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUsesBiasNeurons.Location = new System.Drawing.Point(9, 145);
            this.cbUsesBiasNeurons.Name = "cbUsesBiasNeurons";
            this.cbUsesBiasNeurons.Size = new System.Drawing.Size(185, 21);
            this.cbUsesBiasNeurons.TabIndex = 34;
            this.cbUsesBiasNeurons.Text = "Network uses bias neurons";
            this.cbUsesBiasNeurons.UseVisualStyleBackColor = true;
            // 
            // nudMaxWeight
            // 
            this.nudMaxWeight.DecimalPlaces = 4;
            this.nudMaxWeight.Location = new System.Drawing.Point(129, 114);
            this.nudMaxWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMaxWeight.Name = "nudMaxWeight";
            this.nudMaxWeight.Size = new System.Drawing.Size(81, 25);
            this.nudMaxWeight.TabIndex = 39;
            this.nudMaxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMinWeight
            // 
            this.nudMinWeight.DecimalPlaces = 4;
            this.nudMinWeight.Location = new System.Drawing.Point(129, 83);
            this.nudMinWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMinWeight.Name = "nudMinWeight";
            this.nudMinWeight.Size = new System.Drawing.Size(81, 25);
            this.nudMinWeight.TabIndex = 11;
            this.nudMinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMinWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Min. weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Learning method:";
            // 
            // cbLearningMethod
            // 
            this.cbLearningMethod.BackColor = System.Drawing.Color.White;
            this.cbLearningMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLearningMethod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLearningMethod.FormattingEnabled = true;
            this.cbLearningMethod.Items.AddRange(new object[] {
            "Not linear",
            "Linear"});
            this.cbLearningMethod.Location = new System.Drawing.Point(129, 52);
            this.cbLearningMethod.Name = "cbLearningMethod";
            this.cbLearningMethod.Size = new System.Drawing.Size(170, 25);
            this.cbLearningMethod.TabIndex = 36;
            this.cbLearningMethod.SelectedIndexChanged += new System.EventHandler(this.CbLearningMethod_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(129, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 25);
            this.tbName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvLayers);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(314, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 234);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Rows not fully filled are ignored.";
            // 
            // dgvLayers
            // 
            this.dgvLayers.AllowUserToResizeColumns = false;
            this.dgvLayers.AllowUserToResizeRows = false;
            this.dgvLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLayers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LayerNo,
            this.NeuronsQuantity,
            this.Function});
            this.dgvLayers.Location = new System.Drawing.Point(6, 24);
            this.dgvLayers.Name = "dgvLayers";
            this.dgvLayers.RowHeadersVisible = false;
            this.dgvLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLayers.Size = new System.Drawing.Size(416, 181);
            this.dgvLayers.TabIndex = 26;
            this.dgvLayers.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvLayers_UserAddedRow);
            this.dgvLayers.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvLayers_UserDeletedRow);
            // 
            // LayerNo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.LayerNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.LayerNo.FillWeight = 76.14214F;
            this.LayerNo.HeaderText = "Layer";
            this.LayerNo.MinimumWidth = 75;
            this.LayerNo.Name = "LayerNo";
            this.LayerNo.ReadOnly = true;
            this.LayerNo.Width = 75;
            // 
            // NeuronsQuantity
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.NeuronsQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.NeuronsQuantity.FillWeight = 123.8579F;
            this.NeuronsQuantity.HeaderText = "Neurons quantity without bias neuron";
            this.NeuronsQuantity.MinimumWidth = 150;
            this.NeuronsQuantity.Name = "NeuronsQuantity";
            this.NeuronsQuantity.Width = 177;
            // 
            // Function
            // 
            this.Function.HeaderText = "Activation function";
            this.Function.Items.AddRange(new object[] {
            "sigmoid <0, 1>",
            "tanh <-1, 1>"});
            this.Function.MinimumWidth = 150;
            this.Function.Name = "Function";
            this.Function.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Function.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Function.Width = 150;
            // 
            // CreateNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "CreateNetwork";
            this.Size = new System.Drawing.Size(800, 600);
            this.Resize += new System.EventHandler(this.CreateNetwork_Resize);
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreateNetwork;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bResetToDefault;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbUsesBiasNeurons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLearningMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMaxWeight;
        private System.Windows.Forms.NumericUpDown nudMinWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeuronsQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Function;
    }
}
