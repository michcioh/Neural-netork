using System;

namespace Neural
{
    partial class DialogLearningData
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
            this.bApply = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.rbLearnAllData = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbLearnSelectedData = new System.Windows.Forms.RadioButton();
            this.bDldFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInputData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOutputData = new System.Windows.Forms.DataGridView();
            this.gbLearingData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.cbShowData = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bSaveLearningDataToFile = new System.Windows.Forms.Button();
            this.bReadingDataFile = new System.Windows.Forms.Button();
            this.dgvLearningData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.pContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputData)).BeginInit();
            this.gbLearingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningData)).BeginInit();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.bApply.FlatAppearance.BorderSize = 0;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(766, 639);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(153, 25);
            this.bApply.TabIndex = 9;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // pContent
            // 
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.rbLearnAllData);
            this.pContent.Controls.Add(this.label7);
            this.pContent.Controls.Add(this.rbLearnSelectedData);
            this.pContent.Controls.Add(this.bDldFile);
            this.pContent.Controls.Add(this.groupBox1);
            this.pContent.Controls.Add(this.gbLearingData);
            this.pContent.Controls.Add(this.label5);
            this.pContent.Controls.Add(this.bApply);
            this.pContent.Location = new System.Drawing.Point(18, 22);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(942, 678);
            this.pContent.TabIndex = 10;
            // 
            // rbLearnAllData
            // 
            this.rbLearnAllData.AutoSize = true;
            this.rbLearnAllData.Checked = true;
            this.rbLearnAllData.Location = new System.Drawing.Point(437, 641);
            this.rbLearnAllData.Name = "rbLearnAllData";
            this.rbLearnAllData.Size = new System.Drawing.Size(141, 21);
            this.rbLearnAllData.TabIndex = 49;
            this.rbLearnAllData.TabStop = true;
            this.rbLearnAllData.Text = "all data for learning";
            this.rbLearnAllData.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(351, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Use data as:";
            // 
            // rbLearnSelectedData
            // 
            this.rbLearnSelectedData.AutoSize = true;
            this.rbLearnSelectedData.Location = new System.Drawing.Point(584, 641);
            this.rbLearnSelectedData.Name = "rbLearnSelectedData";
            this.rbLearnSelectedData.Size = new System.Drawing.Size(176, 21);
            this.rbLearnSelectedData.TabIndex = 51;
            this.rbLearnSelectedData.Text = "selected data for learning";
            this.rbLearnSelectedData.UseVisualStyleBackColor = true;
            // 
            // bDldFile
            // 
            this.bDldFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDldFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.bDldFile.FlatAppearance.BorderSize = 0;
            this.bDldFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDldFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDldFile.ForeColor = System.Drawing.Color.White;
            this.bDldFile.Location = new System.Drawing.Point(21, 639);
            this.bDldFile.Name = "bDldFile";
            this.bDldFile.Size = new System.Drawing.Size(153, 25);
            this.bDldFile.TabIndex = 48;
            this.bDldFile.Text = "Data learn description";
            this.bDldFile.UseVisualStyleBackColor = false;
            this.bDldFile.Click += new System.EventHandler(this.BDldFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(21, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 312);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data visualization";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInputData);
            this.groupBox3.Location = new System.Drawing.Point(6, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 286);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input data";
            // 
            // dgvInputData
            // 
            this.dgvInputData.AllowUserToAddRows = false;
            this.dgvInputData.AllowUserToDeleteRows = false;
            this.dgvInputData.AllowUserToResizeColumns = false;
            this.dgvInputData.AllowUserToResizeRows = false;
            this.dgvInputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInputData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputData.ColumnHeadersVisible = false;
            this.dgvInputData.Enabled = false;
            this.dgvInputData.Location = new System.Drawing.Point(3, 24);
            this.dgvInputData.Name = "dgvInputData";
            this.dgvInputData.RowHeadersVisible = false;
            this.dgvInputData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.dgvInputData.Size = new System.Drawing.Size(420, 251);
            this.dgvInputData.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOutputData);
            this.groupBox2.Location = new System.Drawing.Point(459, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 289);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output data";
            // 
            // dgvOutputData
            // 
            this.dgvOutputData.AllowUserToAddRows = false;
            this.dgvOutputData.AllowUserToDeleteRows = false;
            this.dgvOutputData.AllowUserToResizeColumns = false;
            this.dgvOutputData.AllowUserToResizeRows = false;
            this.dgvOutputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOutputData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOutputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputData.ColumnHeadersVisible = false;
            this.dgvOutputData.Enabled = false;
            this.dgvOutputData.Location = new System.Drawing.Point(6, 24);
            this.dgvOutputData.Name = "dgvOutputData";
            this.dgvOutputData.RowHeadersVisible = false;
            this.dgvOutputData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.dgvOutputData.Size = new System.Drawing.Size(420, 251);
            this.dgvOutputData.TabIndex = 38;
            // 
            // gbLearingData
            // 
            this.gbLearingData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLearingData.Controls.Add(this.label1);
            this.gbLearingData.Controls.Add(this.tbFileName);
            this.gbLearingData.Controls.Add(this.cbShowData);
            this.gbLearingData.Controls.Add(this.label4);
            this.gbLearingData.Controls.Add(this.bSaveLearningDataToFile);
            this.gbLearingData.Controls.Add(this.bReadingDataFile);
            this.gbLearingData.Controls.Add(this.dgvLearningData);
            this.gbLearingData.Location = new System.Drawing.Point(21, 40);
            this.gbLearingData.Name = "gbLearingData";
            this.gbLearingData.Size = new System.Drawing.Size(898, 274);
            this.gbLearingData.TabIndex = 46;
            this.gbLearingData.TabStop = false;
            this.gbLearingData.Text = "Data for learning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Loaded file:";
            // 
            // tbFileName
            // 
            this.tbFileName.BackColor = System.Drawing.SystemColors.Control;
            this.tbFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFileName.Location = new System.Drawing.Point(88, 24);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(532, 18);
            this.tbFileName.TabIndex = 39;
            this.tbFileName.Text = "none";
            // 
            // cbShowData
            // 
            this.cbShowData.AutoSize = true;
            this.cbShowData.Location = new System.Drawing.Point(483, 246);
            this.cbShowData.Name = "cbShowData";
            this.cbShowData.Size = new System.Drawing.Size(88, 21);
            this.cbShowData.TabIndex = 37;
            this.cbShowData.Text = "Show data";
            this.cbShowData.UseVisualStyleBackColor = true;
            this.cbShowData.CheckedChanged += new System.EventHandler(this.CbShowData_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Only rows with all cells filled will be valid and used to learning";
            // 
            // bSaveLearningDataToFile
            // 
            this.bSaveLearningDataToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveLearningDataToFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.bSaveLearningDataToFile.FlatAppearance.BorderSize = 0;
            this.bSaveLearningDataToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveLearningDataToFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSaveLearningDataToFile.ForeColor = System.Drawing.Color.White;
            this.bSaveLearningDataToFile.Location = new System.Drawing.Point(736, 243);
            this.bSaveLearningDataToFile.Name = "bSaveLearningDataToFile";
            this.bSaveLearningDataToFile.Size = new System.Drawing.Size(153, 25);
            this.bSaveLearningDataToFile.TabIndex = 35;
            this.bSaveLearningDataToFile.Text = "Save data to file";
            this.bSaveLearningDataToFile.UseVisualStyleBackColor = false;
            this.bSaveLearningDataToFile.Click += new System.EventHandler(this.BSaveLearningDataToFile_Click);
            // 
            // bReadingDataFile
            // 
            this.bReadingDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bReadingDataFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.bReadingDataFile.FlatAppearance.BorderSize = 0;
            this.bReadingDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadingDataFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bReadingDataFile.ForeColor = System.Drawing.Color.White;
            this.bReadingDataFile.Location = new System.Drawing.Point(577, 243);
            this.bReadingDataFile.Name = "bReadingDataFile";
            this.bReadingDataFile.Size = new System.Drawing.Size(153, 25);
            this.bReadingDataFile.TabIndex = 34;
            this.bReadingDataFile.Text = "Read data file";
            this.bReadingDataFile.UseVisualStyleBackColor = false;
            this.bReadingDataFile.Click += new System.EventHandler(this.BReadingDataFile_Click);
            // 
            // dgvLearningData
            // 
            this.dgvLearningData.AllowUserToResizeColumns = false;
            this.dgvLearningData.AllowUserToResizeRows = false;
            this.dgvLearningData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLearningData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLearningData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLearningData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearningData.Location = new System.Drawing.Point(6, 48);
            this.dgvLearningData.Name = "dgvLearningData";
            this.dgvLearningData.RowHeadersVisible = false;
            this.dgvLearningData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvLearningData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLearningData.Size = new System.Drawing.Size(883, 189);
            this.dgvLearningData.TabIndex = 27;
            this.dgvLearningData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLearningData_CellValueChanged);
            this.dgvLearningData.SelectionChanged += new System.EventHandler(this.DgvLearningData_SelectionChanged);
            this.dgvLearningData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvLearningData_UserAddedRow);
            this.dgvLearningData.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvLearningData_UserDeletedRow);
            this.dgvLearningData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvLearningData_UserDeletingRow);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Learning data";
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "csv";
            this.sfdSave.Filter = "CSV files|*.csv|All files|*.*";
            this.sfdSave.RestoreDirectory = true;
            // 
            // DialogLearningData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(984, 715);
            this.Name = "DialogLearningData";
            this.Size = new System.Drawing.Size(984, 715);
            this.Resize += new System.EventHandler(this.CreateNetwork_Resize);
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputData)).EndInit();
            this.gbLearingData.ResumeLayout(false);
            this.gbLearingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbLearingData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSaveLearningDataToFile;
        private System.Windows.Forms.Button bReadingDataFile;
        private System.Windows.Forms.DataGridView dgvLearningData;
        private System.Windows.Forms.DataGridView dgvInputData;
        private System.Windows.Forms.DataGridView dgvOutputData;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.CheckBox cbShowData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bDldFile;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.RadioButton rbLearnAllData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbLearnSelectedData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileName;
    }
}
