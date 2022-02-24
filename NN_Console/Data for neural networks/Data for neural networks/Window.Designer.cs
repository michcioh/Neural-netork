namespace Data_for_neural_networks
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExample = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bClearExample = new System.Windows.Forms.Button();
            this.nudExampleColumns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudExampleRows = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bClearResult = new System.Windows.Forms.Button();
            this.nudResultColumns = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResultRows = new System.Windows.Forms.NumericUpDown();
            this.bSave = new System.Windows.Forms.Button();
            this.bClearAll = new System.Windows.Forms.Button();
            this.tRefresh = new System.Windows.Forms.Timer(this.components);
            this.bCheck = new System.Windows.Forms.Button();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lInfoMax = new System.Windows.Forms.Label();
            this.nudLearningDataLineNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bLoadLearningFile = new System.Windows.Forms.Button();
            this.tbGrey = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbWhite = new System.Windows.Forms.TextBox();
            this.ofdOpenLearnData = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbRedR = new System.Windows.Forms.RadioButton();
            this.rbBrownR = new System.Windows.Forms.RadioButton();
            this.rbBlueR = new System.Windows.Forms.RadioButton();
            this.rbGreenR = new System.Windows.Forms.RadioButton();
            this.rbWhiteR = new System.Windows.Forms.RadioButton();
            this.rbGreyR = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRedL = new System.Windows.Forms.RadioButton();
            this.rbBrownL = new System.Windows.Forms.RadioButton();
            this.rbBlueL = new System.Windows.Forms.RadioButton();
            this.rbGreenL = new System.Windows.Forms.RadioButton();
            this.rbWhiteL = new System.Windows.Forms.RadioButton();
            this.rbGreyL = new System.Windows.Forms.RadioButton();
            this.tbBrown = new System.Windows.Forms.TextBox();
            this.bLR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExampleColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExampleRows)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultRows)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearningDataLineNo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExample
            // 
            this.dgvExample.AllowUserToAddRows = false;
            this.dgvExample.AllowUserToDeleteRows = false;
            this.dgvExample.AllowUserToResizeColumns = false;
            this.dgvExample.AllowUserToResizeRows = false;
            this.dgvExample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExample.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExample.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExample.Location = new System.Drawing.Point(6, 45);
            this.dgvExample.MultiSelect = false;
            this.dgvExample.Name = "dgvExample";
            this.dgvExample.RowHeadersVisible = false;
            this.dgvExample.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvExample.Size = new System.Drawing.Size(400, 400);
            this.dgvExample.TabIndex = 0;
            this.dgvExample.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            this.dgvExample.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            this.dgvExample.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseUp);
            this.dgvExample.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.dgvExample.MouseLeave += new System.EventHandler(this.dgv_MouseLeave);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.Location = new System.Drawing.Point(6, 45);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResult.Size = new System.Drawing.Size(400, 400);
            this.dgvResult.TabIndex = 1;
            this.dgvResult.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            this.dgvResult.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            this.dgvResult.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseUp);
            this.dgvResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.dgvResult.MouseLeave += new System.EventHandler(this.dgv_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLR);
            this.groupBox1.Controls.Add(this.bClearExample);
            this.groupBox1.Controls.Add(this.nudExampleColumns);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudExampleRows);
            this.groupBox1.Controls.Add(this.dgvExample);
            this.groupBox1.Location = new System.Drawing.Point(164, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 457);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wzorzec";
            // 
            // bClearExample
            // 
            this.bClearExample.Location = new System.Drawing.Point(331, 16);
            this.bClearExample.Name = "bClearExample";
            this.bClearExample.Size = new System.Drawing.Size(75, 23);
            this.bClearExample.TabIndex = 6;
            this.bClearExample.Text = "Czyść";
            this.bClearExample.UseVisualStyleBackColor = true;
            this.bClearExample.Click += new System.EventHandler(this.bClearExample_Click);
            // 
            // nudExampleColumns
            // 
            this.nudExampleColumns.Location = new System.Drawing.Point(85, 19);
            this.nudExampleColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExampleColumns.Name = "nudExampleColumns";
            this.nudExampleColumns.Size = new System.Drawing.Size(55, 20);
            this.nudExampleColumns.TabIndex = 5;
            this.nudExampleColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExampleColumns.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudExampleColumns.ValueChanged += new System.EventHandler(this.nudExample_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // nudExampleRows
            // 
            this.nudExampleRows.Location = new System.Drawing.Point(6, 19);
            this.nudExampleRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExampleRows.Name = "nudExampleRows";
            this.nudExampleRows.Size = new System.Drawing.Size(55, 20);
            this.nudExampleRows.TabIndex = 3;
            this.nudExampleRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExampleRows.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudExampleRows.ValueChanged += new System.EventHandler(this.nudExample_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bClearResult);
            this.groupBox2.Controls.Add(this.nudResultColumns);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudResultRows);
            this.groupBox2.Controls.Add(this.dgvResult);
            this.groupBox2.Location = new System.Drawing.Point(585, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 457);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik";
            // 
            // bClearResult
            // 
            this.bClearResult.Location = new System.Drawing.Point(331, 16);
            this.bClearResult.Name = "bClearResult";
            this.bClearResult.Size = new System.Drawing.Size(75, 23);
            this.bClearResult.TabIndex = 9;
            this.bClearResult.Text = "Czyść";
            this.bClearResult.UseVisualStyleBackColor = true;
            this.bClearResult.Click += new System.EventHandler(this.bClearResult_Click);
            // 
            // nudResultColumns
            // 
            this.nudResultColumns.Location = new System.Drawing.Point(85, 19);
            this.nudResultColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResultColumns.Name = "nudResultColumns";
            this.nudResultColumns.Size = new System.Drawing.Size(55, 20);
            this.nudResultColumns.TabIndex = 8;
            this.nudResultColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudResultColumns.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudResultColumns.ValueChanged += new System.EventHandler(this.nudResult_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // nudResultRows
            // 
            this.nudResultRows.Location = new System.Drawing.Point(6, 19);
            this.nudResultRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResultRows.Name = "nudResultRows";
            this.nudResultRows.Size = new System.Drawing.Size(55, 20);
            this.nudResultRows.TabIndex = 6;
            this.nudResultRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudResultRows.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudResultRows.ValueChanged += new System.EventHandler(this.nudResult_ValueChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 253);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(146, 43);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Zapisz [F1]";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClearAll
            // 
            this.bClearAll.Location = new System.Drawing.Point(897, 475);
            this.bClearAll.Name = "bClearAll";
            this.bClearAll.Size = new System.Drawing.Size(103, 27);
            this.bClearAll.TabIndex = 5;
            this.bClearAll.Text = "Czyść [ESC]";
            this.bClearAll.UseVisualStyleBackColor = true;
            this.bClearAll.Click += new System.EventHandler(this.bClearAll_Click);
            // 
            // tRefresh
            // 
            this.tRefresh.Interval = 1000;
            this.tRefresh.Tick += new System.EventHandler(this.tRefresh_Tick);
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(12, 339);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(146, 43);
            this.bCheck.TabIndex = 6;
            this.bCheck.Text = "Sprawdź wynik sieci [F5]";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "Neural network files|*.network|All files|*.*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lInfoMax);
            this.groupBox3.Controls.Add(this.nudLearningDataLineNo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.bLoadLearningFile);
            this.groupBox3.Location = new System.Drawing.Point(164, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Przeglądaj plik z danymi uczenia";
            // 
            // lInfoMax
            // 
            this.lInfoMax.AutoSize = true;
            this.lInfoMax.Location = new System.Drawing.Point(265, 24);
            this.lInfoMax.Name = "lInfoMax";
            this.lInfoMax.Size = new System.Drawing.Size(94, 13);
            this.lInfoMax.TabIndex = 10;
            this.lInfoMax.Text = "nie wczytano pliku";
            // 
            // nudLearningDataLineNo
            // 
            this.nudLearningDataLineNo.Location = new System.Drawing.Point(181, 22);
            this.nudLearningDataLineNo.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLearningDataLineNo.Name = "nudLearningDataLineNo";
            this.nudLearningDataLineNo.Size = new System.Drawing.Size(78, 20);
            this.nudLearningDataLineNo.TabIndex = 9;
            this.nudLearningDataLineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLearningDataLineNo.ValueChanged += new System.EventHandler(this.nudLearningDataLineNo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numer lini:";
            // 
            // bLoadLearningFile
            // 
            this.bLoadLearningFile.Location = new System.Drawing.Point(6, 19);
            this.bLoadLearningFile.Name = "bLoadLearningFile";
            this.bLoadLearningFile.Size = new System.Drawing.Size(107, 23);
            this.bLoadLearningFile.TabIndex = 7;
            this.bLoadLearningFile.Text = "Załaduj plik";
            this.bLoadLearningFile.UseVisualStyleBackColor = true;
            this.bLoadLearningFile.Click += new System.EventHandler(this.bLoadLearningFile_Click);
            // 
            // tbGrey
            // 
            this.tbGrey.BackColor = System.Drawing.Color.Silver;
            this.tbGrey.Location = new System.Drawing.Point(44, 99);
            this.tbGrey.Name = "tbGrey";
            this.tbGrey.Size = new System.Drawing.Size(57, 20);
            this.tbGrey.TabIndex = 4;
            this.tbGrey.Text = "0,15";
            this.tbGrey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGreen
            // 
            this.tbGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.tbGreen.Location = new System.Drawing.Point(44, 125);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(57, 20);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.Text = "1";
            this.tbGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBlue
            // 
            this.tbBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbBlue.Location = new System.Drawing.Point(44, 47);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(57, 20);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.Text = "-1";
            this.tbBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRed
            // 
            this.tbRed.BackColor = System.Drawing.Color.Coral;
            this.tbRed.ForeColor = System.Drawing.Color.White;
            this.tbRed.Location = new System.Drawing.Point(44, 21);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(57, 20);
            this.tbRed.TabIndex = 1;
            this.tbRed.Text = "-2";
            this.tbRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWhite
            // 
            this.tbWhite.Location = new System.Drawing.Point(44, 73);
            this.tbWhite.Name = "tbWhite";
            this.tbWhite.Size = new System.Drawing.Size(57, 20);
            this.tbWhite.TabIndex = 0;
            this.tbWhite.Text = "0";
            this.tbWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ofdOpenLearnData
            // 
            this.ofdOpenLearnData.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.tbBrown);
            this.groupBox5.Controls.Add(this.tbGreen);
            this.groupBox5.Controls.Add(this.tbGrey);
            this.groupBox5.Controls.Add(this.tbWhite);
            this.groupBox5.Controls.Add(this.tbRed);
            this.groupBox5.Controls.Add(this.tbBlue);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 198);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wartości";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRedR);
            this.panel2.Controls.Add(this.rbBrownR);
            this.panel2.Controls.Add(this.rbBlueR);
            this.panel2.Controls.Add(this.rbGreenR);
            this.panel2.Controls.Add(this.rbWhiteR);
            this.panel2.Controls.Add(this.rbGreyR);
            this.panel2.Location = new System.Drawing.Point(109, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 170);
            this.panel2.TabIndex = 13;
            // 
            // rbRedR
            // 
            this.rbRedR.AutoSize = true;
            this.rbRedR.Location = new System.Drawing.Point(7, 8);
            this.rbRedR.Name = "rbRedR";
            this.rbRedR.Size = new System.Drawing.Size(14, 13);
            this.rbRedR.TabIndex = 6;
            this.rbRedR.UseVisualStyleBackColor = true;
            // 
            // rbBrownR
            // 
            this.rbBrownR.AutoSize = true;
            this.rbBrownR.Location = new System.Drawing.Point(7, 139);
            this.rbBrownR.Name = "rbBrownR";
            this.rbBrownR.Size = new System.Drawing.Size(14, 13);
            this.rbBrownR.TabIndex = 11;
            this.rbBrownR.UseVisualStyleBackColor = true;
            // 
            // rbBlueR
            // 
            this.rbBlueR.AutoSize = true;
            this.rbBlueR.Checked = true;
            this.rbBlueR.Location = new System.Drawing.Point(7, 35);
            this.rbBlueR.Name = "rbBlueR";
            this.rbBlueR.Size = new System.Drawing.Size(14, 13);
            this.rbBlueR.TabIndex = 7;
            this.rbBlueR.TabStop = true;
            this.rbBlueR.UseVisualStyleBackColor = true;
            // 
            // rbGreenR
            // 
            this.rbGreenR.AutoSize = true;
            this.rbGreenR.Location = new System.Drawing.Point(7, 113);
            this.rbGreenR.Name = "rbGreenR";
            this.rbGreenR.Size = new System.Drawing.Size(14, 13);
            this.rbGreenR.TabIndex = 10;
            this.rbGreenR.UseVisualStyleBackColor = true;
            // 
            // rbWhiteR
            // 
            this.rbWhiteR.AutoSize = true;
            this.rbWhiteR.Location = new System.Drawing.Point(7, 61);
            this.rbWhiteR.Name = "rbWhiteR";
            this.rbWhiteR.Size = new System.Drawing.Size(14, 13);
            this.rbWhiteR.TabIndex = 8;
            this.rbWhiteR.UseVisualStyleBackColor = true;
            // 
            // rbGreyR
            // 
            this.rbGreyR.AutoSize = true;
            this.rbGreyR.Location = new System.Drawing.Point(7, 87);
            this.rbGreyR.Name = "rbGreyR";
            this.rbGreyR.Size = new System.Drawing.Size(14, 13);
            this.rbGreyR.TabIndex = 9;
            this.rbGreyR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRedL);
            this.panel1.Controls.Add(this.rbBrownL);
            this.panel1.Controls.Add(this.rbBlueL);
            this.panel1.Controls.Add(this.rbGreenL);
            this.panel1.Controls.Add(this.rbWhiteL);
            this.panel1.Controls.Add(this.rbGreyL);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 170);
            this.panel1.TabIndex = 12;
            // 
            // rbRedL
            // 
            this.rbRedL.AutoSize = true;
            this.rbRedL.Location = new System.Drawing.Point(7, 8);
            this.rbRedL.Name = "rbRedL";
            this.rbRedL.Size = new System.Drawing.Size(14, 13);
            this.rbRedL.TabIndex = 6;
            this.rbRedL.UseVisualStyleBackColor = true;
            // 
            // rbBrownL
            // 
            this.rbBrownL.AutoSize = true;
            this.rbBrownL.Location = new System.Drawing.Point(7, 139);
            this.rbBrownL.Name = "rbBrownL";
            this.rbBrownL.Size = new System.Drawing.Size(14, 13);
            this.rbBrownL.TabIndex = 11;
            this.rbBrownL.UseVisualStyleBackColor = true;
            // 
            // rbBlueL
            // 
            this.rbBlueL.AutoSize = true;
            this.rbBlueL.Location = new System.Drawing.Point(7, 35);
            this.rbBlueL.Name = "rbBlueL";
            this.rbBlueL.Size = new System.Drawing.Size(14, 13);
            this.rbBlueL.TabIndex = 7;
            this.rbBlueL.UseVisualStyleBackColor = true;
            // 
            // rbGreenL
            // 
            this.rbGreenL.AutoSize = true;
            this.rbGreenL.Checked = true;
            this.rbGreenL.Location = new System.Drawing.Point(7, 113);
            this.rbGreenL.Name = "rbGreenL";
            this.rbGreenL.Size = new System.Drawing.Size(14, 13);
            this.rbGreenL.TabIndex = 10;
            this.rbGreenL.TabStop = true;
            this.rbGreenL.UseVisualStyleBackColor = true;
            // 
            // rbWhiteL
            // 
            this.rbWhiteL.AutoSize = true;
            this.rbWhiteL.Location = new System.Drawing.Point(7, 61);
            this.rbWhiteL.Name = "rbWhiteL";
            this.rbWhiteL.Size = new System.Drawing.Size(14, 13);
            this.rbWhiteL.TabIndex = 8;
            this.rbWhiteL.UseVisualStyleBackColor = true;
            // 
            // rbGreyL
            // 
            this.rbGreyL.AutoSize = true;
            this.rbGreyL.Location = new System.Drawing.Point(7, 87);
            this.rbGreyL.Name = "rbGreyL";
            this.rbGreyL.Size = new System.Drawing.Size(14, 13);
            this.rbGreyL.TabIndex = 9;
            this.rbGreyL.UseVisualStyleBackColor = true;
            // 
            // tbBrown
            // 
            this.tbBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbBrown.ForeColor = System.Drawing.Color.White;
            this.tbBrown.Location = new System.Drawing.Point(44, 151);
            this.tbBrown.Name = "tbBrown";
            this.tbBrown.Size = new System.Drawing.Size(57, 20);
            this.tbBrown.TabIndex = 5;
            this.tbBrown.Text = "2";
            this.tbBrown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bLR
            // 
            this.bLR.Location = new System.Drawing.Point(146, 16);
            this.bLR.Name = "bLR";
            this.bLR.Size = new System.Drawing.Size(99, 23);
            this.bLR.TabIndex = 7;
            this.bLR.Text = "lewy <-> prawy";
            this.bLR.UseVisualStyleBackColor = true;
            this.bLR.Click += new System.EventHandler(this.bLR_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 538);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.bClearAll);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Data for neural networks";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExampleColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExampleRows)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultRows)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLearningDataLineNo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExample;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudExampleColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudExampleRows;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudResultColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudResultRows;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClearAll;
        private System.Windows.Forms.Button bClearExample;
        private System.Windows.Forms.Button bClearResult;
        private System.Windows.Forms.Timer tRefresh;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bLoadLearningFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenLearnData;
        private System.Windows.Forms.NumericUpDown nudLearningDataLineNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lInfoMax;
        private System.Windows.Forms.TextBox tbWhite;
        private System.Windows.Forms.TextBox tbGrey;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbBrown;
        private System.Windows.Forms.RadioButton rbBrownL;
        private System.Windows.Forms.RadioButton rbGreenL;
        private System.Windows.Forms.RadioButton rbGreyL;
        private System.Windows.Forms.RadioButton rbWhiteL;
        private System.Windows.Forms.RadioButton rbBlueL;
        private System.Windows.Forms.RadioButton rbRedL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRedR;
        private System.Windows.Forms.RadioButton rbBrownR;
        private System.Windows.Forms.RadioButton rbBlueR;
        private System.Windows.Forms.RadioButton rbGreenR;
        private System.Windows.Forms.RadioButton rbWhiteR;
        private System.Windows.Forms.RadioButton rbGreyR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bLR;
    }
}

