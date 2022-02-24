namespace ModifyBitmap
{
    partial class WindowModifyBitmap
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowModifyBitmap));
            this.pTop = new System.Windows.Forms.Panel();
            this.cbCollectDebugInformations = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTranslateNN = new System.Windows.Forms.RadioButton();
            this.rbGrey = new System.Windows.Forms.RadioButton();
            this.bColorRecognizion = new System.Windows.Forms.Button();
            this.nudColorsCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxDim = new System.Windows.Forms.NumericUpDown();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.bModify = new System.Windows.Forms.Button();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pbOrginal = new System.Windows.Forms.PictureBox();
            this.pRight = new System.Windows.Forms.Panel();
            this.pbChanged = new System.Windows.Forms.PictureBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.bwChangeColor = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bDataForNeuralNetowrks = new System.Windows.Forms.Button();
            this.pTop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorsCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDim)).BeginInit();
            this.pLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrginal)).BeginInit();
            this.pRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChanged)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.bDataForNeuralNetowrks);
            this.pTop.Controls.Add(this.cbCollectDebugInformations);
            this.pTop.Controls.Add(this.groupBox2);
            this.pTop.Controls.Add(this.groupBox1);
            this.pTop.Controls.Add(this.tbInfo);
            this.pTop.Controls.Add(this.bModify);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1034, 134);
            this.pTop.TabIndex = 0;
            // 
            // cbCollectDebugInformations
            // 
            this.cbCollectDebugInformations.AutoSize = true;
            this.cbCollectDebugInformations.Location = new System.Drawing.Point(432, 51);
            this.cbCollectDebugInformations.Name = "cbCollectDebugInformations";
            this.cbCollectDebugInformations.Size = new System.Drawing.Size(150, 17);
            this.cbCollectDebugInformations.TabIndex = 7;
            this.cbCollectDebugInformations.Text = "Collect debug informations";
            this.cbCollectDebugInformations.UseVisualStyleBackColor = true;
            this.cbCollectDebugInformations.CheckedChanged += new System.EventHandler(this.cbCollectDebugInformations_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTranslateNN);
            this.groupBox2.Controls.Add(this.rbGrey);
            this.groupBox2.Controls.Add(this.bColorRecognizion);
            this.groupBox2.Controls.Add(this.nudColorsCount);
            this.groupBox2.Location = new System.Drawing.Point(194, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 107);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transformation";
            // 
            // rbTranslateNN
            // 
            this.rbTranslateNN.AutoSize = true;
            this.rbTranslateNN.Location = new System.Drawing.Point(6, 42);
            this.rbTranslateNN.Name = "rbTranslateNN";
            this.rbTranslateNN.Size = new System.Drawing.Size(187, 17);
            this.rbTranslateNN.TabIndex = 4;
            this.rbTranslateNN.Text = "Translate colors by neural network";
            this.rbTranslateNN.UseVisualStyleBackColor = true;
            // 
            // rbGrey
            // 
            this.rbGrey.AutoSize = true;
            this.rbGrey.Checked = true;
            this.rbGrey.Location = new System.Drawing.Point(6, 19);
            this.rbGrey.Name = "rbGrey";
            this.rbGrey.Size = new System.Drawing.Size(142, 17);
            this.rbGrey.TabIndex = 3;
            this.rbGrey.TabStop = true;
            this.rbGrey.Text = "Grey scale, colors count:";
            this.rbGrey.UseVisualStyleBackColor = true;
            // 
            // bColorRecognizion
            // 
            this.bColorRecognizion.Location = new System.Drawing.Point(22, 65);
            this.bColorRecognizion.Name = "bColorRecognizion";
            this.bColorRecognizion.Size = new System.Drawing.Size(116, 23);
            this.bColorRecognizion.TabIndex = 6;
            this.bColorRecognizion.Text = "Color recognizion";
            this.bColorRecognizion.UseVisualStyleBackColor = true;
            this.bColorRecognizion.Click += new System.EventHandler(this.BColorRecognizion_Click);
            // 
            // nudColorsCount
            // 
            this.nudColorsCount.Location = new System.Drawing.Point(154, 19);
            this.nudColorsCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColorsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudColorsCount.Name = "nudColorsCount";
            this.nudColorsCount.Size = new System.Drawing.Size(59, 20);
            this.nudColorsCount.TabIndex = 1;
            this.nudColorsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudColorsCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudColorsCount.ValueChanged += new System.EventHandler(this.nudColorsCount_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bOpenFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMaxDim);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture";
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(6, 19);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(159, 23);
            this.bOpenFile.TabIndex = 0;
            this.bOpenFile.Text = "Open image file";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.BOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max dim:";
            // 
            // nudMaxDim
            // 
            this.nudMaxDim.Location = new System.Drawing.Point(106, 48);
            this.nudMaxDim.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxDim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDim.Name = "nudMaxDim";
            this.nudMaxDim.Size = new System.Drawing.Size(59, 20);
            this.nudMaxDim.TabIndex = 7;
            this.nudMaxDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxDim.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxDim.ValueChanged += new System.EventHandler(this.nudMaxDim_ValueChanged);
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Location = new System.Drawing.Point(790, 17);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(232, 13);
            this.tbInfo.TabIndex = 5;
            this.tbInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(432, 22);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(116, 23);
            this.bModify.TabIndex = 3;
            this.bModify.Text = "Transform";
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.BModify_Click);
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.pbOrginal);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 134);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(273, 457);
            this.pLeft.TabIndex = 1;
            // 
            // pbOrginal
            // 
            this.pbOrginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOrginal.Image = ((System.Drawing.Image)(resources.GetObject("pbOrginal.Image")));
            this.pbOrginal.Location = new System.Drawing.Point(0, 0);
            this.pbOrginal.Name = "pbOrginal";
            this.pbOrginal.Size = new System.Drawing.Size(273, 457);
            this.pbOrginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrginal.TabIndex = 0;
            this.pbOrginal.TabStop = false;
            // 
            // pRight
            // 
            this.pRight.Controls.Add(this.pbChanged);
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(761, 134);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(273, 457);
            this.pRight.TabIndex = 3;
            // 
            // pbChanged
            // 
            this.pbChanged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbChanged.Location = new System.Drawing.Point(0, 0);
            this.pbChanged.Name = "pbChanged";
            this.pbChanged.Size = new System.Drawing.Size(273, 457);
            this.pbChanged.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbChanged.TabIndex = 1;
            this.pbChanged.TabStop = false;
            // 
            // bwChangeColor
            // 
            this.bwChangeColor.WorkerReportsProgress = true;
            this.bwChangeColor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwChangeColor_DoWork);
            this.bwChangeColor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BwChangeColor_ProgressChanged);
            this.bwChangeColor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwChangeColor_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bDataForNeuralNetowrks
            // 
            this.bDataForNeuralNetowrks.Location = new System.Drawing.Point(7, 101);
            this.bDataForNeuralNetowrks.Name = "bDataForNeuralNetowrks";
            this.bDataForNeuralNetowrks.Size = new System.Drawing.Size(181, 23);
            this.bDataForNeuralNetowrks.TabIndex = 4;
            this.bDataForNeuralNetowrks.Text = "Data for neural netowrks";
            this.bDataForNeuralNetowrks.UseVisualStyleBackColor = true;
            this.bDataForNeuralNetowrks.Click += new System.EventHandler(this.BDataForNeuralNetowrks_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 613);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify bitmap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window_Load);
            this.Resize += new System.EventHandler(this.Window_Resize);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorsCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDim)).EndInit();
            this.pLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOrginal)).EndInit();
            this.pRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChanged)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.PictureBox pbOrginal;
        private System.Windows.Forms.PictureBox pbChanged;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.NumericUpDown nudColorsCount;
        private System.ComponentModel.BackgroundWorker bwChangeColor;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button bColorRecognizion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxDim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTranslateNN;
        private System.Windows.Forms.RadioButton rbGrey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox cbCollectDebugInformations;
        private System.Windows.Forms.Button bDataForNeuralNetowrks;
    }
}

