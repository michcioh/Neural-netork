namespace Gomoku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPrzelaczZawodnika = new System.Windows.Forms.CheckBox();
            this.rbPlacementMode = new System.Windows.Forms.RadioButton();
            this.rbGameMode = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbRedR = new System.Windows.Forms.RadioButton();
            this.rbBrownR = new System.Windows.Forms.RadioButton();
            this.rbBlueR = new System.Windows.Forms.RadioButton();
            this.rbGreenR = new System.Windows.Forms.RadioButton();
            this.rbBackgroundR = new System.Windows.Forms.RadioButton();
            this.rbGreyR = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbRedL = new System.Windows.Forms.RadioButton();
            this.rbBrownL = new System.Windows.Forms.RadioButton();
            this.rbBlueL = new System.Windows.Forms.RadioButton();
            this.rbGreenL = new System.Windows.Forms.RadioButton();
            this.rbBackgroundL = new System.Windows.Forms.RadioButton();
            this.rbGreyL = new System.Windows.Forms.RadioButton();
            this.tbBrown = new System.Windows.Forms.TextBox();
            this.tbWhite = new System.Windows.Forms.TextBox();
            this.tbGrey = new System.Windows.Forms.TextBox();
            this.tbBackground = new System.Windows.Forms.TextBox();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbBlack = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlreadyReadWhiteWins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAlreadyReadBlackWins = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlreadyReadGamesCount = new System.Windows.Forms.Label();
            this.label626216 = new System.Windows.Forms.Label();
            this.bStartLoadingGames = new System.Windows.Forms.Button();
            this.lblInfoGierCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGamesToRead = new System.Windows.Forms.NumericUpDown();
            this.bStopLoadingGames = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.pBackgroud = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbColorSign = new System.Windows.Forms.TextBox();
            this.bLR = new System.Windows.Forms.Button();
            this.bClearExample = new System.Windows.Forms.Button();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.bwLoadGames = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamesToRead)).BeginInit();
            this.pBackgroud.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(127, 115);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(241, 273);
            this.dgv.TabIndex = 1;
            this.dgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            this.dgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            this.dgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseUp);
            this.dgv.MouseLeave += new System.EventHandler(this.dgv_MouseLeave);
            this.dgv.Resize += new System.EventHandler(this.dgv_Resize);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.Frozen = true;
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.Frozen = true;
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.Frozen = true;
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 499);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPrzelaczZawodnika);
            this.groupBox2.Controls.Add(this.rbPlacementMode);
            this.groupBox2.Controls.Add(this.rbGameMode);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(3, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 280);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tryb";
            // 
            // cbPrzelaczZawodnika
            // 
            this.cbPrzelaczZawodnika.AutoSize = true;
            this.cbPrzelaczZawodnika.Checked = true;
            this.cbPrzelaczZawodnika.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrzelaczZawodnika.Location = new System.Drawing.Point(176, 84);
            this.cbPrzelaczZawodnika.Name = "cbPrzelaczZawodnika";
            this.cbPrzelaczZawodnika.Size = new System.Drawing.Size(167, 17);
            this.cbPrzelaczZawodnika.TabIndex = 10;
            this.cbPrzelaczZawodnika.Text = "Przełącz zawodnika po ruchu";
            this.cbPrzelaczZawodnika.UseVisualStyleBackColor = true;
            this.cbPrzelaczZawodnika.Visible = false;
            // 
            // rbPlacementMode
            // 
            this.rbPlacementMode.AutoSize = true;
            this.rbPlacementMode.Location = new System.Drawing.Point(9, 45);
            this.rbPlacementMode.Name = "rbPlacementMode";
            this.rbPlacementMode.Size = new System.Drawing.Size(93, 17);
            this.rbPlacementMode.TabIndex = 1;
            this.rbPlacementMode.Text = "tryb układania";
            this.rbPlacementMode.UseVisualStyleBackColor = true;
            this.rbPlacementMode.Visible = false;
            // 
            // rbGameMode
            // 
            this.rbGameMode.AutoSize = true;
            this.rbGameMode.Checked = true;
            this.rbGameMode.Location = new System.Drawing.Point(9, 22);
            this.rbGameMode.Name = "rbGameMode";
            this.rbGameMode.Size = new System.Drawing.Size(59, 17);
            this.rbGameMode.TabIndex = 0;
            this.rbGameMode.TabStop = true;
            this.rbGameMode.Text = "tryb gry";
            this.rbGameMode.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Controls.Add(this.tbBrown);
            this.groupBox5.Controls.Add(this.tbWhite);
            this.groupBox5.Controls.Add(this.tbGrey);
            this.groupBox5.Controls.Add(this.tbBackground);
            this.groupBox5.Controls.Add(this.tbRed);
            this.groupBox5.Controls.Add(this.tbBlack);
            this.groupBox5.Location = new System.Drawing.Point(24, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 198);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wartości";
            this.groupBox5.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbRedR);
            this.panel3.Controls.Add(this.rbBrownR);
            this.panel3.Controls.Add(this.rbBlueR);
            this.panel3.Controls.Add(this.rbGreenR);
            this.panel3.Controls.Add(this.rbBackgroundR);
            this.panel3.Controls.Add(this.rbGreyR);
            this.panel3.Location = new System.Drawing.Point(109, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 170);
            this.panel3.TabIndex = 13;
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
            // rbBackgroundR
            // 
            this.rbBackgroundR.AutoSize = true;
            this.rbBackgroundR.Location = new System.Drawing.Point(7, 61);
            this.rbBackgroundR.Name = "rbBackgroundR";
            this.rbBackgroundR.Size = new System.Drawing.Size(14, 13);
            this.rbBackgroundR.TabIndex = 8;
            this.rbBackgroundR.UseVisualStyleBackColor = true;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.rbRedL);
            this.panel4.Controls.Add(this.rbBrownL);
            this.panel4.Controls.Add(this.rbBlueL);
            this.panel4.Controls.Add(this.rbGreenL);
            this.panel4.Controls.Add(this.rbBackgroundL);
            this.panel4.Controls.Add(this.rbGreyL);
            this.panel4.Location = new System.Drawing.Point(6, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 170);
            this.panel4.TabIndex = 12;
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
            // rbBackgroundL
            // 
            this.rbBackgroundL.AutoSize = true;
            this.rbBackgroundL.Location = new System.Drawing.Point(7, 61);
            this.rbBackgroundL.Name = "rbBackgroundL";
            this.rbBackgroundL.Size = new System.Drawing.Size(14, 13);
            this.rbBackgroundL.TabIndex = 8;
            this.rbBackgroundL.UseVisualStyleBackColor = true;
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
            // tbWhite
            // 
            this.tbWhite.BackColor = System.Drawing.Color.White;
            this.tbWhite.Location = new System.Drawing.Point(44, 125);
            this.tbWhite.Name = "tbWhite";
            this.tbWhite.Size = new System.Drawing.Size(57, 20);
            this.tbWhite.TabIndex = 3;
            this.tbWhite.Text = "1";
            this.tbWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbBackground
            // 
            this.tbBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(176)))), ((int)(((byte)(90)))));
            this.tbBackground.Location = new System.Drawing.Point(44, 73);
            this.tbBackground.Name = "tbBackground";
            this.tbBackground.Size = new System.Drawing.Size(57, 20);
            this.tbBackground.TabIndex = 0;
            this.tbBackground.Text = "0";
            this.tbBackground.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbBlack
            // 
            this.tbBlack.BackColor = System.Drawing.Color.Black;
            this.tbBlack.ForeColor = System.Drawing.Color.White;
            this.tbBlack.Location = new System.Drawing.Point(44, 47);
            this.tbBlack.Name = "tbBlack";
            this.tbBlack.Size = new System.Drawing.Size(57, 20);
            this.tbBlack.TabIndex = 2;
            this.tbBlack.Text = "-1";
            this.tbBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlreadyReadWhiteWins);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAlreadyReadBlackWins);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAlreadyReadGamesCount);
            this.groupBox1.Controls.Add(this.label626216);
            this.groupBox1.Controls.Add(this.bStartLoadingGames);
            this.groupBox1.Controls.Add(this.lblInfoGierCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudGamesToRead);
            this.groupBox1.Controls.Add(this.bStopLoadingGames);
            this.groupBox1.Controls.Add(this.pbLoading);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 130);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytywanie gier";
            // 
            // lblAlreadyReadWhiteWins
            // 
            this.lblAlreadyReadWhiteWins.AutoSize = true;
            this.lblAlreadyReadWhiteWins.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlreadyReadWhiteWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAlreadyReadWhiteWins.Location = new System.Drawing.Point(118, 105);
            this.lblAlreadyReadWhiteWins.Name = "lblAlreadyReadWhiteWins";
            this.lblAlreadyReadWhiteWins.Size = new System.Drawing.Size(14, 13);
            this.lblAlreadyReadWhiteWins.TabIndex = 22;
            this.lblAlreadyReadWhiteWins.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Wygrane białymi:";
            // 
            // lblAlreadyReadBlackWins
            // 
            this.lblAlreadyReadBlackWins.AutoSize = true;
            this.lblAlreadyReadBlackWins.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlreadyReadBlackWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAlreadyReadBlackWins.Location = new System.Drawing.Point(118, 88);
            this.lblAlreadyReadBlackWins.Name = "lblAlreadyReadBlackWins";
            this.lblAlreadyReadBlackWins.Size = new System.Drawing.Size(14, 13);
            this.lblAlreadyReadBlackWins.TabIndex = 20;
            this.lblAlreadyReadBlackWins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Wygrane czarnymi:";
            // 
            // lblAlreadyReadGamesCount
            // 
            this.lblAlreadyReadGamesCount.AutoSize = true;
            this.lblAlreadyReadGamesCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlreadyReadGamesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAlreadyReadGamesCount.Location = new System.Drawing.Point(118, 71);
            this.lblAlreadyReadGamesCount.Name = "lblAlreadyReadGamesCount";
            this.lblAlreadyReadGamesCount.Size = new System.Drawing.Size(14, 13);
            this.lblAlreadyReadGamesCount.TabIndex = 18;
            this.lblAlreadyReadGamesCount.Text = "0";
            // 
            // label626216
            // 
            this.label626216.AutoSize = true;
            this.label626216.BackColor = System.Drawing.SystemColors.Control;
            this.label626216.Location = new System.Drawing.Point(11, 71);
            this.label626216.Name = "label626216";
            this.label626216.Size = new System.Drawing.Size(111, 13);
            this.label626216.TabIndex = 16;
            this.label626216.Text = "Ilość wczytanych gier:";
            // 
            // bStartLoadingGames
            // 
            this.bStartLoadingGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStartLoadingGames.Location = new System.Drawing.Point(355, 16);
            this.bStartLoadingGames.Name = "bStartLoadingGames";
            this.bStartLoadingGames.Size = new System.Drawing.Size(75, 23);
            this.bStartLoadingGames.TabIndex = 15;
            this.bStartLoadingGames.Text = "Wczytaj";
            this.bStartLoadingGames.UseVisualStyleBackColor = true;
            this.bStartLoadingGames.Click += new System.EventHandler(this.bStartLoadingGames_Click);
            // 
            // lblInfoGierCount
            // 
            this.lblInfoGierCount.AutoSize = true;
            this.lblInfoGierCount.Location = new System.Drawing.Point(202, 22);
            this.lblInfoGierCount.Name = "lblInfoGierCount";
            this.lblInfoGierCount.Size = new System.Drawing.Size(21, 13);
            this.lblInfoGierCount.TabIndex = 14;
            this.lblInfoGierCount.Text = "/ ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ilość gier do wczytania:";
            // 
            // nudGamesToRead
            // 
            this.nudGamesToRead.Location = new System.Drawing.Point(132, 19);
            this.nudGamesToRead.Name = "nudGamesToRead";
            this.nudGamesToRead.Size = new System.Drawing.Size(64, 20);
            this.nudGamesToRead.TabIndex = 12;
            this.nudGamesToRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bStopLoadingGames
            // 
            this.bStopLoadingGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStopLoadingGames.Location = new System.Drawing.Point(355, 16);
            this.bStopLoadingGames.Name = "bStopLoadingGames";
            this.bStopLoadingGames.Size = new System.Drawing.Size(75, 23);
            this.bStopLoadingGames.TabIndex = 11;
            this.bStopLoadingGames.Text = "Stop";
            this.bStopLoadingGames.UseVisualStyleBackColor = true;
            this.bStopLoadingGames.Click += new System.EventHandler(this.bStopLoadingGames_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(9, 45);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(421, 23);
            this.pbLoading.TabIndex = 10;
            // 
            // pBackgroud
            // 
            this.pBackgroud.BackColor = System.Drawing.SystemColors.Control;
            this.pBackgroud.Controls.Add(this.dgv);
            this.pBackgroud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBackgroud.Location = new System.Drawing.Point(448, 48);
            this.pBackgroud.Name = "pBackgroud";
            this.pBackgroud.Size = new System.Drawing.Size(532, 451);
            this.pBackgroud.TabIndex = 4;
            this.pBackgroud.Resize += new System.EventHandler(this.pBackgroud_Resize);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbColorSign);
            this.panel5.Controls.Add(this.bLR);
            this.panel5.Controls.Add(this.bClearExample);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(448, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 48);
            this.panel5.TabIndex = 4;
            // 
            // tbColorSign
            // 
            this.tbColorSign.BackColor = System.Drawing.Color.Black;
            this.tbColorSign.Enabled = false;
            this.tbColorSign.Location = new System.Drawing.Point(6, 5);
            this.tbColorSign.Multiline = true;
            this.tbColorSign.Name = "tbColorSign";
            this.tbColorSign.ReadOnly = true;
            this.tbColorSign.Size = new System.Drawing.Size(40, 40);
            this.tbColorSign.TabIndex = 10;
            // 
            // bLR
            // 
            this.bLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLR.Location = new System.Drawing.Point(328, 15);
            this.bLR.Name = "bLR";
            this.bLR.Size = new System.Drawing.Size(99, 23);
            this.bLR.TabIndex = 9;
            this.bLR.Text = "lewy <-> prawy";
            this.bLR.UseVisualStyleBackColor = true;
            this.bLR.Click += new System.EventHandler(this.bLR_Click);
            // 
            // bClearExample
            // 
            this.bClearExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearExample.Location = new System.Drawing.Point(445, 12);
            this.bClearExample.Name = "bClearExample";
            this.bClearExample.Size = new System.Drawing.Size(75, 23);
            this.bClearExample.TabIndex = 8;
            this.bClearExample.Text = "Czyść";
            this.bClearExample.UseVisualStyleBackColor = true;
            this.bClearExample.Click += new System.EventHandler(this.bClearExample_Click);
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "Neural network files|*.network|All files|*.*";
            // 
            // bwLoadGames
            // 
            this.bwLoadGames.WorkerReportsProgress = true;
            this.bwLoadGames.WorkerSupportsCancellation = true;
            this.bwLoadGames.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGames_DoWork);
            this.bwLoadGames.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLoadGames_ProgressChanged);
            this.bwLoadGames.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGames_RunWorkerCompleted);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 499);
            this.Controls.Add(this.pBackgroud);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Window";
            this.Text = "Gomoku";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamesToRead)).EndInit();
            this.pBackgroud.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbRedR;
        private System.Windows.Forms.RadioButton rbBrownR;
        private System.Windows.Forms.RadioButton rbBlueR;
        private System.Windows.Forms.RadioButton rbGreenR;
        private System.Windows.Forms.RadioButton rbBackgroundR;
        private System.Windows.Forms.RadioButton rbGreyR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbRedL;
        private System.Windows.Forms.RadioButton rbBrownL;
        private System.Windows.Forms.RadioButton rbBlueL;
        private System.Windows.Forms.RadioButton rbGreenL;
        private System.Windows.Forms.RadioButton rbBackgroundL;
        private System.Windows.Forms.RadioButton rbGreyL;
        private System.Windows.Forms.TextBox tbBrown;
        private System.Windows.Forms.TextBox tbWhite;
        private System.Windows.Forms.TextBox tbGrey;
        private System.Windows.Forms.TextBox tbBackground;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbBlack;
        private System.Windows.Forms.Panel pBackgroud;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bLR;
        private System.Windows.Forms.Button bClearExample;
        private System.Windows.Forms.CheckBox cbPrzelaczZawodnika;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.ComponentModel.BackgroundWorker bwLoadGames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bStopLoadingGames;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label label626216;
        private System.Windows.Forms.Button bStartLoadingGames;
        private System.Windows.Forms.Label lblInfoGierCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGamesToRead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPlacementMode;
        private System.Windows.Forms.RadioButton rbGameMode;
        private System.Windows.Forms.TextBox tbColorSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label lblAlreadyReadGamesCount;
        private System.Windows.Forms.Label lblAlreadyReadWhiteWins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAlreadyReadBlackWins;
        private System.Windows.Forms.Label label3;
    }
}

