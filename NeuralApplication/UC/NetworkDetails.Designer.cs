namespace Neural
{
    partial class NetworkDetails
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tTimerSuccessfully = new System.Windows.Forms.Timer(this.components);
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.bClose = new System.Windows.Forms.Button();
            this.bSaveNetwork = new System.Windows.Forms.Button();
            this.bResetNetwork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lSavedSuccessfully = new System.Windows.Forms.Label();
            this.gbLearingData = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLearningDataQuantity = new System.Windows.Forms.TextBox();
            this.bReadingDataFile = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSaveWithoutAnyHistory = new System.Windows.Forms.CheckBox();
            this.cbSaveWithoutHistory = new System.Windows.Forms.CheckBox();
            this.tbLearningMethod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDigits = new System.Windows.Forms.NumericUpDown();
            this.tbBias = new System.Windows.Forms.TextBox();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.cbRandomAmountOfTest = new System.Windows.Forms.CheckBox();
            this.nudAmountOfTest = new System.Windows.Forms.NumericUpDown();
            this.bClear = new System.Windows.Forms.Button();
            this.BEnlargeTableTest = new System.Windows.Forms.Button();
            this.bCopyFromLearnData = new System.Windows.Forms.Button();
            this.dgvTestData = new System.Windows.Forms.DataGridView();
            this.gbNeurons = new System.Windows.Forms.GroupBox();
            this.cbHideDgvNeurons = new System.Windows.Forms.CheckBox();
            this.BEnlargeTableNeurons = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNeurons = new System.Windows.Forms.DataGridView();
            this.nLayerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNeuronNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIsBias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nActivationFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLearning = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudMomentum = new System.Windows.Forms.NumericUpDown();
            this.rbUsingDataInSequence = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbUsingDataRandom = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.nudRatio = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLearnUntilMinError = new System.Windows.Forms.RadioButton();
            this.nudXDataTimes = new System.Windows.Forms.NumericUpDown();
            this.rbLearnXTimes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.nudMinimumError = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCollectEveryEpoch = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lInfoEpoch = new System.Windows.Forms.Label();
            this.bStopLearning = new System.Windows.Forms.Button();
            this.lInfoLearning = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShowCurrent = new System.Windows.Forms.CheckBox();
            this.bShowCurrent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbNetworkError = new System.Windows.Forms.ProgressBar();
            this.tbCurrentNetworkError = new System.Windows.Forms.TextBox();
            this.lInfoLearnFinishedStopped = new System.Windows.Forms.Label();
            this.bShowLearnHistory = new System.Windows.Forms.Button();
            this.bLearn = new System.Windows.Forms.Button();
            this.tLearnFinished = new System.Windows.Forms.Timer(this.components);
            this.bwLearning = new System.ComponentModel.BackgroundWorker();
            this.tShowCurrentNetworkError = new System.Windows.Forms.Timer(this.components);
            this.tShowEpochNo = new System.Windows.Forms.Timer(this.components);
            this.cbHideDgvTestData = new System.Windows.Forms.CheckBox();
            this.gbLearingData.SuspendLayout();
            this.pContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigits)).BeginInit();
            this.gbTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestData)).BeginInit();
            this.gbNeurons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeurons)).BeginInit();
            this.gbLearning.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXDataTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumError)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectEveryEpoch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTimerSuccessfully
            // 
            this.tTimerSuccessfully.Interval = 2000;
            this.tTimerSuccessfully.Tick += new System.EventHandler(this.TTimerSuccessfully_Tick);
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackColor = System.Drawing.Color.Goldenrod;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(853, 42);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(153, 25);
            this.bClose.TabIndex = 31;
            this.bClose.Text = "Close network";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // bSaveNetwork
            // 
            this.bSaveNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveNetwork.BackColor = System.Drawing.Color.RoyalBlue;
            this.bSaveNetwork.FlatAppearance.BorderSize = 0;
            this.bSaveNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveNetwork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSaveNetwork.ForeColor = System.Drawing.Color.White;
            this.bSaveNetwork.Location = new System.Drawing.Point(853, 11);
            this.bSaveNetwork.Name = "bSaveNetwork";
            this.bSaveNetwork.Size = new System.Drawing.Size(153, 25);
            this.bSaveNetwork.TabIndex = 33;
            this.bSaveNetwork.Text = "Save network";
            this.bSaveNetwork.UseVisualStyleBackColor = false;
            this.bSaveNetwork.Click += new System.EventHandler(this.BSaveNetwork_Click);
            // 
            // bResetNetwork
            // 
            this.bResetNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetNetwork.BackColor = System.Drawing.Color.IndianRed;
            this.bResetNetwork.FlatAppearance.BorderSize = 0;
            this.bResetNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bResetNetwork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bResetNetwork.ForeColor = System.Drawing.Color.White;
            this.bResetNetwork.Location = new System.Drawing.Point(853, 73);
            this.bResetNetwork.Name = "bResetNetwork";
            this.bResetNetwork.Size = new System.Drawing.Size(153, 25);
            this.bResetNetwork.TabIndex = 34;
            this.bResetNetwork.Text = "Edit / reset network";
            this.bResetNetwork.UseVisualStyleBackColor = false;
            this.bResetNetwork.Click += new System.EventHandler(this.BResetNetwork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Control;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(58, 21);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(532, 18);
            this.tbName.TabIndex = 36;
            this.tbName.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Is using bias neurons:";
            // 
            // lSavedSuccessfully
            // 
            this.lSavedSuccessfully.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSavedSuccessfully.AutoSize = true;
            this.lSavedSuccessfully.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSavedSuccessfully.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lSavedSuccessfully.Location = new System.Drawing.Point(729, 15);
            this.lSavedSuccessfully.Name = "lSavedSuccessfully";
            this.lSavedSuccessfully.Size = new System.Drawing.Size(118, 17);
            this.lSavedSuccessfully.TabIndex = 41;
            this.lSavedSuccessfully.Text = "Saved successfully";
            this.lSavedSuccessfully.Visible = false;
            // 
            // gbLearingData
            // 
            this.gbLearingData.Controls.Add(this.label4);
            this.gbLearingData.Controls.Add(this.tbLearningDataQuantity);
            this.gbLearingData.Controls.Add(this.bReadingDataFile);
            this.gbLearingData.Location = new System.Drawing.Point(6, 24);
            this.gbLearingData.Name = "gbLearingData";
            this.gbLearingData.Size = new System.Drawing.Size(218, 89);
            this.gbLearingData.TabIndex = 42;
            this.gbLearingData.TabStop = false;
            this.gbLearingData.Text = "Data for learning details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Data quantity:";
            // 
            // tbLearningDataQuantity
            // 
            this.tbLearningDataQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.tbLearningDataQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLearningDataQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLearningDataQuantity.Location = new System.Drawing.Point(100, 22);
            this.tbLearningDataQuantity.Name = "tbLearningDataQuantity";
            this.tbLearningDataQuantity.ReadOnly = true;
            this.tbLearningDataQuantity.Size = new System.Drawing.Size(99, 18);
            this.tbLearningDataQuantity.TabIndex = 40;
            this.tbLearningDataQuantity.Text = "<data not set>";
            // 
            // bReadingDataFile
            // 
            this.bReadingDataFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.bReadingDataFile.FlatAppearance.BorderSize = 0;
            this.bReadingDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadingDataFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bReadingDataFile.ForeColor = System.Drawing.Color.White;
            this.bReadingDataFile.Location = new System.Drawing.Point(32, 48);
            this.bReadingDataFile.Name = "bReadingDataFile";
            this.bReadingDataFile.Size = new System.Drawing.Size(153, 25);
            this.bReadingDataFile.TabIndex = 34;
            this.bReadingDataFile.Text = "Manage";
            this.bReadingDataFile.UseVisualStyleBackColor = false;
            this.bReadingDataFile.Click += new System.EventHandler(this.BReadingDataFile_Click);
            // 
            // pContent
            // 
            this.pContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContent.AutoScroll = true;
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.groupBox1);
            this.pContent.Controls.Add(this.gbTest);
            this.pContent.Controls.Add(this.gbNeurons);
            this.pContent.Controls.Add(this.gbLearning);
            this.pContent.Controls.Add(this.lSavedSuccessfully);
            this.pContent.Controls.Add(this.bResetNetwork);
            this.pContent.Controls.Add(this.bSaveNetwork);
            this.pContent.Controls.Add(this.bClose);
            this.pContent.Location = new System.Drawing.Point(14, 3);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1005, 1272);
            this.pContent.TabIndex = 10;
            this.pContent.SizeChanged += new System.EventHandler(this.PContent_SizeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSaveWithoutAnyHistory);
            this.groupBox1.Controls.Add(this.cbSaveWithoutHistory);
            this.groupBox1.Controls.Add(this.tbLearningMethod);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.nudDigits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBias);
            this.groupBox1.Location = new System.Drawing.Point(24, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 151);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network details";
            // 
            // cbSaveWithoutAnyHistory
            // 
            this.cbSaveWithoutAnyHistory.AutoSize = true;
            this.cbSaveWithoutAnyHistory.Location = new System.Drawing.Point(290, 65);
            this.cbSaveWithoutAnyHistory.Name = "cbSaveWithoutAnyHistory";
            this.cbSaveWithoutAnyHistory.Size = new System.Drawing.Size(224, 21);
            this.cbSaveWithoutAnyHistory.TabIndex = 58;
            this.cbSaveWithoutAnyHistory.Text = "Save network without RMS history";
            this.cbSaveWithoutAnyHistory.UseVisualStyleBackColor = true;
            // 
            // cbSaveWithoutHistory
            // 
            this.cbSaveWithoutHistory.AutoSize = true;
            this.cbSaveWithoutHistory.Location = new System.Drawing.Point(290, 41);
            this.cbSaveWithoutHistory.Name = "cbSaveWithoutHistory";
            this.cbSaveWithoutHistory.Size = new System.Drawing.Size(284, 21);
            this.cbSaveWithoutHistory.TabIndex = 57;
            this.cbSaveWithoutHistory.Text = "Save network without detailed epoch history";
            this.cbSaveWithoutHistory.UseVisualStyleBackColor = true;
            this.cbSaveWithoutHistory.CheckedChanged += new System.EventHandler(this.CbSaveWithoutHistory_CheckedChanged);
            // 
            // tbLearningMethod
            // 
            this.tbLearningMethod.BackColor = System.Drawing.SystemColors.Control;
            this.tbLearningMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLearningMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLearningMethod.Location = new System.Drawing.Point(152, 66);
            this.tbLearningMethod.Name = "tbLearningMethod";
            this.tbLearningMethod.ReadOnly = true;
            this.tbLearningMethod.Size = new System.Drawing.Size(170, 18);
            this.tbLearningMethod.TabIndex = 56;
            this.tbLearningMethod.Text = "learning method";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Learning method:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Number of digits showing after dot:";
            // 
            // nudDigits
            // 
            this.nudDigits.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.nudDigits.Location = new System.Drawing.Point(230, 90);
            this.nudDigits.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDigits.Name = "nudDigits";
            this.nudDigits.Size = new System.Drawing.Size(36, 25);
            this.nudDigits.TabIndex = 51;
            this.nudDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDigits.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDigits.ValueChanged += new System.EventHandler(this.NudDigits_ValueChanged);
            // 
            // tbBias
            // 
            this.tbBias.BackColor = System.Drawing.SystemColors.Control;
            this.tbBias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBias.Location = new System.Drawing.Point(152, 42);
            this.tbBias.Name = "tbBias";
            this.tbBias.ReadOnly = true;
            this.tbBias.Size = new System.Drawing.Size(29, 18);
            this.tbBias.TabIndex = 38;
            this.tbBias.Text = "yes";
            // 
            // gbTest
            // 
            this.gbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTest.Controls.Add(this.cbHideDgvTestData);
            this.gbTest.Controls.Add(this.cbRandomAmountOfTest);
            this.gbTest.Controls.Add(this.nudAmountOfTest);
            this.gbTest.Controls.Add(this.bClear);
            this.gbTest.Controls.Add(this.BEnlargeTableTest);
            this.gbTest.Controls.Add(this.bCopyFromLearnData);
            this.gbTest.Controls.Add(this.dgvTestData);
            this.gbTest.Location = new System.Drawing.Point(24, 843);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(982, 424);
            this.gbTest.TabIndex = 48;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Network test";
            // 
            // cbRandomAmountOfTest
            // 
            this.cbRandomAmountOfTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRandomAmountOfTest.AutoSize = true;
            this.cbRandomAmountOfTest.Location = new System.Drawing.Point(762, 394);
            this.cbRandomAmountOfTest.Name = "cbRandomAmountOfTest";
            this.cbRandomAmountOfTest.Size = new System.Drawing.Size(127, 21);
            this.cbRandomAmountOfTest.TabIndex = 54;
            this.cbRandomAmountOfTest.Text = "Random amount:";
            this.cbRandomAmountOfTest.UseVisualStyleBackColor = true;
            this.cbRandomAmountOfTest.CheckedChanged += new System.EventHandler(this.cbRandomAmountOfTest_CheckedChanged);
            // 
            // nudAmountOfTest
            // 
            this.nudAmountOfTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmountOfTest.Enabled = false;
            this.nudAmountOfTest.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmountOfTest.Location = new System.Drawing.Point(890, 393);
            this.nudAmountOfTest.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudAmountOfTest.Name = "nudAmountOfTest";
            this.nudAmountOfTest.Size = new System.Drawing.Size(52, 25);
            this.nudAmountOfTest.TabIndex = 52;
            this.nudAmountOfTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmountOfTest.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(9, 393);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(153, 25);
            this.bClear.TabIndex = 40;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BEnlargeTableTest
            // 
            this.BEnlargeTableTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BEnlargeTableTest.BackColor = System.Drawing.Color.RoyalBlue;
            this.BEnlargeTableTest.FlatAppearance.BorderSize = 0;
            this.BEnlargeTableTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEnlargeTableTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BEnlargeTableTest.ForeColor = System.Drawing.Color.White;
            this.BEnlargeTableTest.Location = new System.Drawing.Point(168, 393);
            this.BEnlargeTableTest.Name = "BEnlargeTableTest";
            this.BEnlargeTableTest.Size = new System.Drawing.Size(153, 25);
            this.BEnlargeTableTest.TabIndex = 39;
            this.BEnlargeTableTest.Text = "Enlarge table";
            this.BEnlargeTableTest.UseVisualStyleBackColor = false;
            this.BEnlargeTableTest.Click += new System.EventHandler(this.BEnlargeTableTest_Click);
            // 
            // bCopyFromLearnData
            // 
            this.bCopyFromLearnData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyFromLearnData.BackColor = System.Drawing.Color.RoyalBlue;
            this.bCopyFromLearnData.FlatAppearance.BorderSize = 0;
            this.bCopyFromLearnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopyFromLearnData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCopyFromLearnData.ForeColor = System.Drawing.Color.White;
            this.bCopyFromLearnData.Location = new System.Drawing.Point(505, 393);
            this.bCopyFromLearnData.Name = "bCopyFromLearnData";
            this.bCopyFromLearnData.Size = new System.Drawing.Size(251, 25);
            this.bCopyFromLearnData.TabIndex = 35;
            this.bCopyFromLearnData.Text = "Copy input values from learn data";
            this.bCopyFromLearnData.UseVisualStyleBackColor = false;
            this.bCopyFromLearnData.Click += new System.EventHandler(this.BCopyFromLearnData_Click);
            // 
            // dgvTestData
            // 
            this.dgvTestData.AllowUserToResizeColumns = false;
            this.dgvTestData.AllowUserToResizeRows = false;
            this.dgvTestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTestData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestData.Location = new System.Drawing.Point(6, 51);
            this.dgvTestData.Name = "dgvTestData";
            this.dgvTestData.RowHeadersVisible = false;
            this.dgvTestData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvTestData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTestData.Size = new System.Drawing.Size(936, 336);
            this.dgvTestData.TabIndex = 27;
            this.dgvTestData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTestData_CellValueChanged);
            this.dgvTestData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvTestData_UserAddedRow);
            this.dgvTestData.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvTestData_UserDeletedRow);
            this.dgvTestData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvTestData_UserDeletingRow);
            this.dgvTestData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvTestData_KeyUp);
            // 
            // gbNeurons
            // 
            this.gbNeurons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNeurons.Controls.Add(this.cbHideDgvNeurons);
            this.gbNeurons.Controls.Add(this.BEnlargeTableNeurons);
            this.gbNeurons.Controls.Add(this.label6);
            this.gbNeurons.Controls.Add(this.dgvNeurons);
            this.gbNeurons.Location = new System.Drawing.Point(24, 434);
            this.gbNeurons.Name = "gbNeurons";
            this.gbNeurons.Size = new System.Drawing.Size(982, 403);
            this.gbNeurons.TabIndex = 47;
            this.gbNeurons.TabStop = false;
            this.gbNeurons.Text = "Information about neurons (current state)";
            // 
            // cbHideDgvNeurons
            // 
            this.cbHideDgvNeurons.AutoSize = true;
            this.cbHideDgvNeurons.Checked = true;
            this.cbHideDgvNeurons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHideDgvNeurons.Location = new System.Drawing.Point(12, 24);
            this.cbHideDgvNeurons.Name = "cbHideDgvNeurons";
            this.cbHideDgvNeurons.Size = new System.Drawing.Size(111, 21);
            this.cbHideDgvNeurons.TabIndex = 39;
            this.cbHideDgvNeurons.Text = "Hide this table";
            this.cbHideDgvNeurons.UseVisualStyleBackColor = true;
            this.cbHideDgvNeurons.CheckedChanged += new System.EventHandler(this.cbHideDgvNeurons_CheckedChanged);
            // 
            // BEnlargeTableNeurons
            // 
            this.BEnlargeTableNeurons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BEnlargeTableNeurons.BackColor = System.Drawing.Color.RoyalBlue;
            this.BEnlargeTableNeurons.FlatAppearance.BorderSize = 0;
            this.BEnlargeTableNeurons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEnlargeTableNeurons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BEnlargeTableNeurons.ForeColor = System.Drawing.Color.White;
            this.BEnlargeTableNeurons.Location = new System.Drawing.Point(789, 372);
            this.BEnlargeTableNeurons.Name = "BEnlargeTableNeurons";
            this.BEnlargeTableNeurons.Size = new System.Drawing.Size(153, 25);
            this.BEnlargeTableNeurons.TabIndex = 38;
            this.BEnlargeTableNeurons.Text = "Enlarge table";
            this.BEnlargeTableNeurons.UseVisualStyleBackColor = false;
            this.BEnlargeTableNeurons.Click += new System.EventHandler(this.BEnlargeTableNeurons_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Double click on weigh or input cell to change values";
            // 
            // dgvNeurons
            // 
            this.dgvNeurons.AllowUserToAddRows = false;
            this.dgvNeurons.AllowUserToDeleteRows = false;
            this.dgvNeurons.AllowUserToResizeColumns = false;
            this.dgvNeurons.AllowUserToResizeRows = false;
            this.dgvNeurons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNeurons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNeurons.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNeurons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeurons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nLayerNo,
            this.nNeuronNo,
            this.nIsBias,
            this.nActivationFunction});
            this.dgvNeurons.Location = new System.Drawing.Point(12, 51);
            this.dgvNeurons.MultiSelect = false;
            this.dgvNeurons.Name = "dgvNeurons";
            this.dgvNeurons.RowHeadersVisible = false;
            this.dgvNeurons.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvNeurons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNeurons.Size = new System.Drawing.Size(930, 315);
            this.dgvNeurons.TabIndex = 28;
            this.dgvNeurons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNeurons_CellDoubleClick);
            this.dgvNeurons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvNeurons_KeyDown);
            this.dgvNeurons.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvNeurons_KeyUp);
            // 
            // nLayerNo
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            this.nLayerNo.DefaultCellStyle = dataGridViewCellStyle13;
            this.nLayerNo.HeaderText = "Layer no";
            this.nLayerNo.MinimumWidth = 100;
            this.nLayerNo.Name = "nLayerNo";
            this.nLayerNo.ReadOnly = true;
            // 
            // nNeuronNo
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            this.nNeuronNo.DefaultCellStyle = dataGridViewCellStyle14;
            this.nNeuronNo.HeaderText = "Neuron No";
            this.nNeuronNo.MinimumWidth = 100;
            this.nNeuronNo.Name = "nNeuronNo";
            this.nNeuronNo.ReadOnly = true;
            // 
            // nIsBias
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            this.nIsBias.DefaultCellStyle = dataGridViewCellStyle15;
            this.nIsBias.HeaderText = "Is bias?";
            this.nIsBias.MinimumWidth = 75;
            this.nIsBias.Name = "nIsBias";
            this.nIsBias.ReadOnly = true;
            this.nIsBias.Width = 75;
            // 
            // nActivationFunction
            // 
            this.nActivationFunction.HeaderText = "Activation function";
            this.nActivationFunction.MinimumWidth = 125;
            this.nActivationFunction.Name = "nActivationFunction";
            this.nActivationFunction.ReadOnly = true;
            this.nActivationFunction.Width = 127;
            // 
            // gbLearning
            // 
            this.gbLearning.Controls.Add(this.groupBox4);
            this.gbLearning.Controls.Add(this.groupBox3);
            this.gbLearning.Controls.Add(this.gbLearingData);
            this.gbLearning.Location = new System.Drawing.Point(24, 168);
            this.gbLearning.Name = "gbLearning";
            this.gbLearning.Size = new System.Drawing.Size(779, 260);
            this.gbLearning.TabIndex = 46;
            this.gbLearning.TabStop = false;
            this.gbLearning.Text = "Learning";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.nudMomentum);
            this.groupBox4.Controls.Add(this.rbUsingDataInSequence);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.rbUsingDataRandom);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.nudRatio);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(230, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 89);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conditions details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(169, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 64;
            this.label14.Text = "momentum:";
            // 
            // nudMomentum
            // 
            this.nudMomentum.DecimalPlaces = 2;
            this.nudMomentum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudMomentum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudMomentum.Location = new System.Drawing.Point(249, 18);
            this.nudMomentum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMomentum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMomentum.Name = "nudMomentum";
            this.nudMomentum.Size = new System.Drawing.Size(59, 25);
            this.nudMomentum.TabIndex = 65;
            this.nudMomentum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMomentum.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // rbUsingDataInSequence
            // 
            this.rbUsingDataInSequence.AutoSize = true;
            this.rbUsingDataInSequence.Location = new System.Drawing.Point(431, 18);
            this.rbUsingDataInSequence.Name = "rbUsingDataInSequence";
            this.rbUsingDataInSequence.Size = new System.Drawing.Size(95, 21);
            this.rbUsingDataInSequence.TabIndex = 63;
            this.rbUsingDataInSequence.Text = "in sequence";
            this.rbUsingDataInSequence.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Learning ratio:";
            // 
            // rbUsingDataRandom
            // 
            this.rbUsingDataRandom.AutoSize = true;
            this.rbUsingDataRandom.Checked = true;
            this.rbUsingDataRandom.Location = new System.Drawing.Point(353, 18);
            this.rbUsingDataRandom.Name = "rbUsingDataRandom";
            this.rbUsingDataRandom.Size = new System.Drawing.Size(72, 21);
            this.rbUsingDataRandom.TabIndex = 62;
            this.rbUsingDataRandom.TabStop = true;
            this.rbUsingDataRandom.Text = "random";
            this.rbUsingDataRandom.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(284, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Use data:";
            // 
            // nudRatio
            // 
            this.nudRatio.DecimalPlaces = 2;
            this.nudRatio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudRatio.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudRatio.Location = new System.Drawing.Point(104, 19);
            this.nudRatio.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRatio.Name = "nudRatio";
            this.nudRatio.Size = new System.Drawing.Size(59, 25);
            this.nudRatio.TabIndex = 44;
            this.nudRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLearnUntilMinError);
            this.panel1.Controls.Add(this.nudXDataTimes);
            this.panel1.Controls.Add(this.rbLearnXTimes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudMinimumError);
            this.panel1.Location = new System.Drawing.Point(9, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 27);
            this.panel1.TabIndex = 39;
            // 
            // rbLearnUntilMinError
            // 
            this.rbLearnUntilMinError.AutoSize = true;
            this.rbLearnUntilMinError.Location = new System.Drawing.Point(173, 2);
            this.rbLearnUntilMinError.Name = "rbLearnUntilMinError";
            this.rbLearnUntilMinError.Size = new System.Drawing.Size(241, 21);
            this.rbLearnUntilMinError.TabIndex = 64;
            this.rbLearnUntilMinError.Text = "the network achieves a minimal error";
            this.rbLearnUntilMinError.UseVisualStyleBackColor = true;
            // 
            // nudXDataTimes
            // 
            this.nudXDataTimes.Location = new System.Drawing.Point(23, 0);
            this.nudXDataTimes.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudXDataTimes.Name = "nudXDataTimes";
            this.nudXDataTimes.Size = new System.Drawing.Size(96, 25);
            this.nudXDataTimes.TabIndex = 51;
            this.nudXDataTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudXDataTimes.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // rbLearnXTimes
            // 
            this.rbLearnXTimes.AutoSize = true;
            this.rbLearnXTimes.Checked = true;
            this.rbLearnXTimes.Location = new System.Drawing.Point(2, 6);
            this.rbLearnXTimes.Name = "rbLearnXTimes";
            this.rbLearnXTimes.Size = new System.Drawing.Size(14, 13);
            this.rbLearnXTimes.TabIndex = 63;
            this.rbLearnXTimes.TabStop = true;
            this.rbLearnXTimes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(126, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "times";
            // 
            // nudMinimumError
            // 
            this.nudMinimumError.DecimalPlaces = 6;
            this.nudMinimumError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudMinimumError.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudMinimumError.Location = new System.Drawing.Point(418, 0);
            this.nudMinimumError.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinimumError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.nudMinimumError.Name = "nudMinimumError";
            this.nudMinimumError.Size = new System.Drawing.Size(90, 25);
            this.nudMinimumError.TabIndex = 61;
            this.nudMinimumError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMinimumError.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nudCollectEveryEpoch);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lInfoEpoch);
            this.groupBox3.Controls.Add(this.bStopLearning);
            this.groupBox3.Controls.Add(this.lInfoLearning);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.lInfoLearnFinishedStopped);
            this.groupBox3.Controls.Add(this.bShowLearnHistory);
            this.groupBox3.Controls.Add(this.bLearn);
            this.groupBox3.Location = new System.Drawing.Point(6, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 132);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Learning process";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "epoch";
            // 
            // nudCollectEveryEpoch
            // 
            this.nudCollectEveryEpoch.Location = new System.Drawing.Point(524, 94);
            this.nudCollectEveryEpoch.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCollectEveryEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCollectEveryEpoch.Name = "nudCollectEveryEpoch";
            this.nudCollectEveryEpoch.Size = new System.Drawing.Size(96, 25);
            this.nudCollectEveryEpoch.TabIndex = 70;
            this.nudCollectEveryEpoch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCollectEveryEpoch.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Collect history every";
            // 
            // lInfoEpoch
            // 
            this.lInfoEpoch.AutoSize = true;
            this.lInfoEpoch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lInfoEpoch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lInfoEpoch.Location = new System.Drawing.Point(552, 68);
            this.lInfoEpoch.Name = "lInfoEpoch";
            this.lInfoEpoch.Size = new System.Drawing.Size(169, 17);
            this.lInfoEpoch.TabIndex = 68;
            this.lInfoEpoch.Text = "Current epoch no.:  100000";
            this.lInfoEpoch.Visible = false;
            // 
            // bStopLearning
            // 
            this.bStopLearning.BackColor = System.Drawing.Color.IndianRed;
            this.bStopLearning.FlatAppearance.BorderSize = 0;
            this.bStopLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStopLearning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStopLearning.ForeColor = System.Drawing.Color.White;
            this.bStopLearning.Location = new System.Drawing.Point(393, 34);
            this.bStopLearning.Name = "bStopLearning";
            this.bStopLearning.Size = new System.Drawing.Size(153, 25);
            this.bStopLearning.TabIndex = 67;
            this.bStopLearning.Text = "Stop learning";
            this.bStopLearning.UseVisualStyleBackColor = false;
            this.bStopLearning.Visible = false;
            this.bStopLearning.Click += new System.EventHandler(this.BStopLearning_Click);
            // 
            // lInfoLearning
            // 
            this.lInfoLearning.AutoSize = true;
            this.lInfoLearning.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lInfoLearning.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lInfoLearning.Location = new System.Drawing.Point(552, 37);
            this.lInfoLearning.Name = "lInfoLearning";
            this.lInfoLearning.Size = new System.Drawing.Size(97, 17);
            this.lInfoLearning.TabIndex = 66;
            this.lInfoLearning.Text = "Learning: 100%";
            this.lInfoLearning.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(6, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbShowCurrent);
            this.groupBox2.Controls.Add(this.bShowCurrent);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbNetworkError);
            this.groupBox2.Controls.Add(this.tbCurrentNetworkError);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 96);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Root Mean Square error";
            // 
            // cbShowCurrent
            // 
            this.cbShowCurrent.AutoSize = true;
            this.cbShowCurrent.Location = new System.Drawing.Point(6, 72);
            this.cbShowCurrent.Name = "cbShowCurrent";
            this.cbShowCurrent.Size = new System.Drawing.Size(103, 21);
            this.cbShowCurrent.TabIndex = 67;
            this.cbShowCurrent.Text = "Show current";
            this.cbShowCurrent.UseVisualStyleBackColor = true;
            this.cbShowCurrent.CheckedChanged += new System.EventHandler(this.CbShowCurrent_CheckedChanged);
            // 
            // bShowCurrent
            // 
            this.bShowCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShowCurrent.BackColor = System.Drawing.Color.RoyalBlue;
            this.bShowCurrent.FlatAppearance.BorderSize = 0;
            this.bShowCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowCurrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bShowCurrent.ForeColor = System.Drawing.Color.White;
            this.bShowCurrent.Location = new System.Drawing.Point(225, 17);
            this.bShowCurrent.Name = "bShowCurrent";
            this.bShowCurrent.Size = new System.Drawing.Size(147, 25);
            this.bShowCurrent.TabIndex = 66;
            this.bShowCurrent.Text = "Show current";
            this.bShowCurrent.UseVisualStyleBackColor = false;
            this.bShowCurrent.Click += new System.EventHandler(this.BShowCurrent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "RMS error:";
            // 
            // pbNetworkError
            // 
            this.pbNetworkError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNetworkError.Location = new System.Drawing.Point(6, 48);
            this.pbNetworkError.MarqueeAnimationSpeed = 10000000;
            this.pbNetworkError.Maximum = 10000000;
            this.pbNetworkError.Name = "pbNetworkError";
            this.pbNetworkError.Size = new System.Drawing.Size(366, 18);
            this.pbNetworkError.Step = 10000000;
            this.pbNetworkError.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbNetworkError.TabIndex = 58;
            this.pbNetworkError.Visible = false;
            // 
            // tbCurrentNetworkError
            // 
            this.tbCurrentNetworkError.BackColor = System.Drawing.SystemColors.Control;
            this.tbCurrentNetworkError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurrentNetworkError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCurrentNetworkError.Location = new System.Drawing.Point(84, 21);
            this.tbCurrentNetworkError.Name = "tbCurrentNetworkError";
            this.tbCurrentNetworkError.ReadOnly = true;
            this.tbCurrentNetworkError.Size = new System.Drawing.Size(135, 18);
            this.tbCurrentNetworkError.TabIndex = 57;
            this.tbCurrentNetworkError.Text = "?";
            // 
            // lInfoLearnFinishedStopped
            // 
            this.lInfoLearnFinishedStopped.AutoSize = true;
            this.lInfoLearnFinishedStopped.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lInfoLearnFinishedStopped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.lInfoLearnFinishedStopped.Location = new System.Drawing.Point(552, 37);
            this.lInfoLearnFinishedStopped.Name = "lInfoLearnFinishedStopped";
            this.lInfoLearnFinishedStopped.Size = new System.Drawing.Size(92, 17);
            this.lInfoLearnFinishedStopped.TabIndex = 54;
            this.lInfoLearnFinishedStopped.Text = "Learn finished";
            this.lInfoLearnFinishedStopped.Visible = false;
            // 
            // bShowLearnHistory
            // 
            this.bShowLearnHistory.BackColor = System.Drawing.Color.RoyalBlue;
            this.bShowLearnHistory.FlatAppearance.BorderSize = 0;
            this.bShowLearnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowLearnHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bShowLearnHistory.ForeColor = System.Drawing.Color.White;
            this.bShowLearnHistory.Location = new System.Drawing.Point(393, 64);
            this.bShowLearnHistory.Name = "bShowLearnHistory";
            this.bShowLearnHistory.Size = new System.Drawing.Size(153, 25);
            this.bShowLearnHistory.TabIndex = 53;
            this.bShowLearnHistory.Text = "Chart of progress";
            this.bShowLearnHistory.UseVisualStyleBackColor = false;
            this.bShowLearnHistory.Click += new System.EventHandler(this.BShowLearnHistory_Click);
            // 
            // bLearn
            // 
            this.bLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.bLearn.FlatAppearance.BorderSize = 0;
            this.bLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLearn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLearn.ForeColor = System.Drawing.Color.White;
            this.bLearn.Location = new System.Drawing.Point(393, 33);
            this.bLearn.Name = "bLearn";
            this.bLearn.Size = new System.Drawing.Size(153, 25);
            this.bLearn.TabIndex = 45;
            this.bLearn.Text = "Learn!";
            this.bLearn.UseVisualStyleBackColor = false;
            this.bLearn.Click += new System.EventHandler(this.BLearn_Click);
            // 
            // tLearnFinished
            // 
            this.tLearnFinished.Interval = 2000;
            this.tLearnFinished.Tick += new System.EventHandler(this.TLearnFinished_Tick);
            // 
            // bwLearning
            // 
            this.bwLearning.WorkerReportsProgress = true;
            this.bwLearning.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwLearning_DoWork);
            this.bwLearning.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BwLearning_ProgressChanged);
            this.bwLearning.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwLearning_RunWorkerCompleted);
            // 
            // tShowCurrentNetworkError
            // 
            this.tShowCurrentNetworkError.Tick += new System.EventHandler(this.TShowCurrentNetworkError_Tick);
            // 
            // tShowEpochNo
            // 
            this.tShowEpochNo.Interval = 500;
            this.tShowEpochNo.Tick += new System.EventHandler(this.TShowEpochNo_Tick);
            // 
            // cbHideDgvTestData
            // 
            this.cbHideDgvTestData.AutoSize = true;
            this.cbHideDgvTestData.Checked = true;
            this.cbHideDgvTestData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHideDgvTestData.Location = new System.Drawing.Point(6, 24);
            this.cbHideDgvTestData.Name = "cbHideDgvTestData";
            this.cbHideDgvTestData.Size = new System.Drawing.Size(111, 21);
            this.cbHideDgvTestData.TabIndex = 55;
            this.cbHideDgvTestData.Text = "Hide this table";
            this.cbHideDgvTestData.UseVisualStyleBackColor = true;
            this.cbHideDgvTestData.CheckedChanged += new System.EventHandler(this.cbHideDgvTestData_CheckedChanged);
            // 
            // NetworkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "NetworkDetails";
            this.Size = new System.Drawing.Size(1022, 1287);
            this.Resize += new System.EventHandler(this.CreateNetwork_Resize);
            this.gbLearingData.ResumeLayout(false);
            this.gbLearingData.PerformLayout();
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigits)).EndInit();
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestData)).EndInit();
            this.gbNeurons.ResumeLayout(false);
            this.gbNeurons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeurons)).EndInit();
            this.gbLearning.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXDataTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumError)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectEveryEpoch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tTimerSuccessfully;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSaveNetwork;
        private System.Windows.Forms.Button bResetNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lSavedSuccessfully;
        private System.Windows.Forms.GroupBox gbLearingData;
        private System.Windows.Forms.Button bReadingDataFile;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.TextBox tbBias;
        private System.Windows.Forms.NumericUpDown nudRatio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbLearning;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bLearn;
        private System.Windows.Forms.GroupBox gbNeurons;
        private System.Windows.Forms.DataGridView dgvNeurons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudXDataTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bShowLearnHistory;
        private System.Windows.Forms.Label lInfoLearnFinishedStopped;
        private System.Windows.Forms.Timer tLearnFinished;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.DataGridView dgvTestData;
        private System.Windows.Forms.Button bCopyFromLearnData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudDigits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLearningMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLayerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNeuronNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIsBias;
        private System.Windows.Forms.DataGridViewTextBoxColumn nActivationFunction;
        private System.Windows.Forms.Button BEnlargeTableNeurons;
        private System.Windows.Forms.ProgressBar pbNetworkError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrentNetworkError;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLearnUntilMinError;
        private System.Windows.Forms.RadioButton rbLearnXTimes;
        private System.Windows.Forms.NumericUpDown nudMinimumError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUsingDataInSequence;
        private System.Windows.Forms.RadioButton rbUsingDataRandom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbShowCurrent;
        private System.Windows.Forms.Button bShowCurrent;
        private System.Windows.Forms.Label lInfoLearning;
        private System.Windows.Forms.Button bStopLearning;
        private System.ComponentModel.BackgroundWorker bwLearning;
        private System.Windows.Forms.Timer tShowCurrentNetworkError;
        public System.Windows.Forms.CheckBox cbSaveWithoutHistory;
        private System.Windows.Forms.Button BEnlargeTableTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLearningDataQuantity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lInfoEpoch;
        private System.Windows.Forms.Timer tShowEpochNo;
        private System.Windows.Forms.Button bClear;
        public System.Windows.Forms.CheckBox cbSaveWithoutAnyHistory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCollectEveryEpoch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudMomentum;
        private System.Windows.Forms.CheckBox cbRandomAmountOfTest;
        private System.Windows.Forms.NumericUpDown nudAmountOfTest;
        private System.Windows.Forms.CheckBox cbHideDgvNeurons;
        private System.Windows.Forms.CheckBox cbHideDgvTestData;
    }
}
