namespace Neural.UC
{
    partial class DialogDataLearningConverter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bChooseFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.gbDataDetails = new System.Windows.Forms.GroupBox();
            this.cbOutputDimensions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbInputDimensions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudOutputQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudInputQuantity = new System.Windows.Forms.NumericUpDown();
            this.lQuantityInLine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.pDetails = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOutputMapping = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMappingInput = new System.Windows.Forms.GroupBox();
            this.dgvInputMapping = new System.Windows.Forms.DataGridView();
            this.cOryginalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMappedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTitle = new System.Windows.Forms.Label();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gbDataDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputQuantity)).BeginInit();
            this.pContent.SuspendLayout();
            this.pDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputMapping)).BeginInit();
            this.gbMappingInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "File:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bChooseFile);
            this.groupBox1.Controls.Add(this.tbFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(589, 61);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV file of learn data";
            // 
            // bChooseFile
            // 
            this.bChooseFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.bChooseFile.FlatAppearance.BorderSize = 0;
            this.bChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChooseFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bChooseFile.ForeColor = System.Drawing.Color.White;
            this.bChooseFile.Location = new System.Drawing.Point(430, 19);
            this.bChooseFile.Name = "bChooseFile";
            this.bChooseFile.Size = new System.Drawing.Size(153, 25);
            this.bChooseFile.TabIndex = 38;
            this.bChooseFile.Text = "Choose";
            this.bChooseFile.UseVisualStyleBackColor = false;
            this.bChooseFile.Click += new System.EventHandler(this.BChooseFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.BackColor = System.Drawing.Color.White;
            this.tbFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFile.Location = new System.Drawing.Point(42, 19);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(382, 25);
            this.tbFile.TabIndex = 37;
            // 
            // gbDataDetails
            // 
            this.gbDataDetails.Controls.Add(this.cbOutputDimensions);
            this.gbDataDetails.Controls.Add(this.label6);
            this.gbDataDetails.Controls.Add(this.cbInputDimensions);
            this.gbDataDetails.Controls.Add(this.label5);
            this.gbDataDetails.Controls.Add(this.label4);
            this.gbDataDetails.Controls.Add(this.nudOutputQuantity);
            this.gbDataDetails.Controls.Add(this.label3);
            this.gbDataDetails.Controls.Add(this.nudInputQuantity);
            this.gbDataDetails.Controls.Add(this.lQuantityInLine);
            this.gbDataDetails.Controls.Add(this.label2);
            this.gbDataDetails.Location = new System.Drawing.Point(3, 0);
            this.gbDataDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDataDetails.Name = "gbDataDetails";
            this.gbDataDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDataDetails.Size = new System.Drawing.Size(586, 123);
            this.gbDataDetails.TabIndex = 39;
            this.gbDataDetails.TabStop = false;
            this.gbDataDetails.Text = "Data details";
            // 
            // cbOutputDimensions
            // 
            this.cbOutputDimensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputDimensions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbOutputDimensions.FormattingEnabled = true;
            this.cbOutputDimensions.Location = new System.Drawing.Point(325, 81);
            this.cbOutputDimensions.Name = "cbOutputDimensions";
            this.cbOutputDimensions.Size = new System.Drawing.Size(196, 25);
            this.cbOutputDimensions.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(204, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Output dimension:";
            // 
            // cbInputDimensions
            // 
            this.cbInputDimensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputDimensions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbInputDimensions.FormattingEnabled = true;
            this.cbInputDimensions.Location = new System.Drawing.Point(325, 50);
            this.cbInputDimensions.Name = "cbInputDimensions";
            this.cbInputDimensions.Size = new System.Drawing.Size(196, 25);
            this.cbInputDimensions.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(204, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Input dimension:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Output quantity:";
            // 
            // nudOutputQuantity
            // 
            this.nudOutputQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudOutputQuantity.Location = new System.Drawing.Point(133, 82);
            this.nudOutputQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOutputQuantity.Name = "nudOutputQuantity";
            this.nudOutputQuantity.Size = new System.Drawing.Size(56, 25);
            this.nudOutputQuantity.TabIndex = 40;
            this.nudOutputQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOutputQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOutputQuantity.ValueChanged += new System.EventHandler(this.NudOutputQuantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Input quantity:";
            // 
            // nudInputQuantity
            // 
            this.nudInputQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudInputQuantity.Location = new System.Drawing.Point(133, 51);
            this.nudInputQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInputQuantity.Name = "nudInputQuantity";
            this.nudInputQuantity.Size = new System.Drawing.Size(56, 25);
            this.nudInputQuantity.TabIndex = 38;
            this.nudInputQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudInputQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInputQuantity.ValueChanged += new System.EventHandler(this.NudInputQuantity_ValueChanged);
            // 
            // lQuantityInLine
            // 
            this.lQuantityInLine.AutoSize = true;
            this.lQuantityInLine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQuantityInLine.Location = new System.Drawing.Point(130, 22);
            this.lQuantityInLine.Name = "lQuantityInLine";
            this.lQuantityInLine.Size = new System.Drawing.Size(59, 17);
            this.lQuantityInLine.TabIndex = 37;
            this.lQuantityInLine.Text = "quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data quantity in line:";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Goldenrod;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(296, 459);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 25);
            this.bCancel.TabIndex = 48;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bCreate
            // 
            this.bCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.bCreate.Enabled = false;
            this.bCreate.FlatAppearance.BorderSize = 0;
            this.bCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCreate.ForeColor = System.Drawing.Color.White;
            this.bCreate.Location = new System.Drawing.Point(455, 459);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(153, 25);
            this.bCreate.TabIndex = 47;
            this.bCreate.Text = "Save";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // pContent
            // 
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.pDetails);
            this.pContent.Controls.Add(this.bCancel);
            this.pContent.Controls.Add(this.lTitle);
            this.pContent.Controls.Add(this.bCreate);
            this.pContent.Controls.Add(this.groupBox1);
            this.pContent.Location = new System.Drawing.Point(14, 15);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(631, 498);
            this.pContent.TabIndex = 40;
            // 
            // pDetails
            // 
            this.pDetails.Controls.Add(this.groupBox2);
            this.pDetails.Controls.Add(this.gbMappingInput);
            this.pDetails.Controls.Add(this.gbDataDetails);
            this.pDetails.Location = new System.Drawing.Point(18, 125);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(596, 328);
            this.pDetails.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOutputMapping);
            this.groupBox2.Location = new System.Drawing.Point(299, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(290, 193);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mapping input values";
            // 
            // dgvOutputMapping
            // 
            this.dgvOutputMapping.AllowUserToResizeColumns = false;
            this.dgvOutputMapping.AllowUserToResizeRows = false;
            this.dgvOutputMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutputMapping.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOutputMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvOutputMapping.Location = new System.Drawing.Point(6, 25);
            this.dgvOutputMapping.Name = "dgvOutputMapping";
            this.dgvOutputMapping.RowHeadersVisible = false;
            this.dgvOutputMapping.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.dgvOutputMapping.Size = new System.Drawing.Size(272, 161);
            this.dgvOutputMapping.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Original value";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 125;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mapped value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 125;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // gbMappingInput
            // 
            this.gbMappingInput.Controls.Add(this.dgvInputMapping);
            this.gbMappingInput.Location = new System.Drawing.Point(3, 131);
            this.gbMappingInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMappingInput.Name = "gbMappingInput";
            this.gbMappingInput.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMappingInput.Size = new System.Drawing.Size(290, 193);
            this.gbMappingInput.TabIndex = 49;
            this.gbMappingInput.TabStop = false;
            this.gbMappingInput.Text = "Mapping input values";
            // 
            // dgvInputMapping
            // 
            this.dgvInputMapping.AllowUserToResizeColumns = false;
            this.dgvInputMapping.AllowUserToResizeRows = false;
            this.dgvInputMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInputMapping.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInputMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOryginalValue,
            this.cMappedValue});
            this.dgvInputMapping.Location = new System.Drawing.Point(9, 25);
            this.dgvInputMapping.Name = "dgvInputMapping";
            this.dgvInputMapping.RowHeadersVisible = false;
            this.dgvInputMapping.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.dgvInputMapping.Size = new System.Drawing.Size(272, 161);
            this.dgvInputMapping.TabIndex = 0;
            // 
            // cOryginalValue
            // 
            this.cOryginalValue.HeaderText = "Original value";
            this.cOryginalValue.MinimumWidth = 125;
            this.cOryginalValue.Name = "cOryginalValue";
            this.cOryginalValue.Width = 125;
            // 
            // cMappedValue
            // 
            this.cMappedValue.HeaderText = "Mapped value";
            this.cMappedValue.MinimumWidth = 125;
            this.cMappedValue.Name = "cMappedValue";
            this.cMappedValue.Width = 125;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTitle.Location = new System.Drawing.Point(14, 20);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(165, 20);
            this.lTitle.TabIndex = 33;
            this.lTitle.Text = "Learn Data Description";
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // DialogDataLearningConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DialogDataLearningConverter";
            this.Size = new System.Drawing.Size(1443, 680);
            this.Resize += new System.EventHandler(this.DialogDataLearningConverter_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDataDetails.ResumeLayout(false);
            this.gbDataDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputQuantity)).EndInit();
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.pDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputMapping)).EndInit();
            this.gbMappingInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputMapping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button bChooseFile;
        private System.Windows.Forms.GroupBox gbDataDetails;
        private System.Windows.Forms.Label lQuantityInLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudInputQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudOutputQuantity;
        private System.Windows.Forms.ComboBox cbOutputDimensions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbInputDimensions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.GroupBox gbMappingInput;
        private System.Windows.Forms.DataGridView dgvInputMapping;
        private System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOryginalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMappedValue;
        private System.Windows.Forms.DataGridView dgvOutputMapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
