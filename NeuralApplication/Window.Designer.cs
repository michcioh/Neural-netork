namespace Neural
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.convertCsvFileToDataLearningFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editActiveNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.susnmnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucDialogLearningData = new Neural.DialogLearningData();
            this.ucDialogDataLearningConverter = new Neural.UC.DialogDataLearningConverter();
            this.ucDialogChart = new Neural.UC.DialogChart();
            this.ucDialogDgvNeuronsShow = new Neural.DialogDgvShow();
            this.ucDialogChangeValueOfNeuron = new Neural.DialogChangeValueOfNeuron();
            this.ucDialogResetNetwork = new Neural.DialogResetNetwork();
            this.ucMain = new Neural.Main();
            this.ucNetworkDetails = new Neural.NetworkDetails();
            this.ucCreateNetwork = new Neural.CreateNetwork();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkToolStripMenuItem,
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.convertCsvFileToDataLearningFileToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.networkToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.openToolStripMenuItem.Text = "Open network";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.saveToolStripMenuItem.Text = "Save active network";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.saveAsToolStripMenuItem.Text = "Save active network as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(270, 6);
            // 
            // convertCsvFileToDataLearningFileToolStripMenuItem
            // 
            this.convertCsvFileToDataLearningFileToolStripMenuItem.Name = "convertCsvFileToDataLearningFileToolStripMenuItem";
            this.convertCsvFileToDataLearningFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.convertCsvFileToDataLearningFileToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.convertCsvFileToDataLearningFileToolStripMenuItem.Text = "Create Learn Data Description";
            this.convertCsvFileToDataLearningFileToolStripMenuItem.Click += new System.EventHandler(this.ConvertCsvFileToDataLearningFileToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.editActiveNetworkToolStripMenuItem});
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.xToolStripMenuItem.Text = "Network";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.newToolStripMenuItem.Text = "Create new network";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // editActiveNetworkToolStripMenuItem
            // 
            this.editActiveNetworkToolStripMenuItem.Enabled = false;
            this.editActiveNetworkToolStripMenuItem.Name = "editActiveNetworkToolStripMenuItem";
            this.editActiveNetworkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editActiveNetworkToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.editActiveNetworkToolStripMenuItem.Text = "Edit / reset network";
            this.editActiveNetworkToolStripMenuItem.Click += new System.EventHandler(this.EditActiveNetworkToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "network";
            this.sfdSave.FileName = "network";
            this.sfdSave.Filter = "Neural network files|*.network|All files|*.*";
            this.sfdSave.RestoreDirectory = true;
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "Neural network files|*.network|All files|*.*";
            // 
            // susnmnieToolStripMenuItem
            // 
            this.susnmnieToolStripMenuItem.Name = "susnmnieToolStripMenuItem";
            this.susnmnieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.susnmnieToolStripMenuItem.Text = "susnmnie";
            // 
            // ucDialogLearningData
            // 
            this.ucDialogLearningData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDialogLearningData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucDialogLearningData.Location = new System.Drawing.Point(0, 24);
            this.ucDialogLearningData.MainWindow = null;
            this.ucDialogLearningData.MinimumSize = new System.Drawing.Size(984, 715);
            this.ucDialogLearningData.Name = "ucDialogLearningData";
            this.ucDialogLearningData.Size = new System.Drawing.Size(1034, 715);
            this.ucDialogLearningData.TabIndex = 10;
            // 
            // ucDialogDataLearningConverter
            // 
            this.ucDialogDataLearningConverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDialogDataLearningConverter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucDialogDataLearningConverter.Location = new System.Drawing.Point(0, 24);
            this.ucDialogDataLearningConverter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDialogDataLearningConverter.Name = "ucDialogDataLearningConverter";
            this.ucDialogDataLearningConverter.Size = new System.Drawing.Size(1034, 715);
            this.ucDialogDataLearningConverter.TabIndex = 9;
            // 
            // ucDialogChart
            // 
            this.ucDialogChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDialogChart.Location = new System.Drawing.Point(0, 24);
            this.ucDialogChart.MainWindow = null;
            this.ucDialogChart.Name = "ucDialogChart";
            this.ucDialogChart.Size = new System.Drawing.Size(1034, 715);
            this.ucDialogChart.TabIndex = 8;
            // 
            // ucDialogDgvNeuronsShow
            // 
            this.ucDialogDgvNeuronsShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDialogDgvNeuronsShow.Location = new System.Drawing.Point(0, 24);
            this.ucDialogDgvNeuronsShow.MainWindow = null;
            this.ucDialogDgvNeuronsShow.Name = "ucDialogDgvNeuronsShow";
            this.ucDialogDgvNeuronsShow.Size = new System.Drawing.Size(1034, 715);
            this.ucDialogDgvNeuronsShow.TabIndex = 7;
            // 
            // ucDialogChangeValueOfNeuron
            // 
            this.ucDialogChangeValueOfNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDialogChangeValueOfNeuron.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucDialogChangeValueOfNeuron.Location = new System.Drawing.Point(0, 24);
            this.ucDialogChangeValueOfNeuron.MainWindow = null;
            this.ucDialogChangeValueOfNeuron.Name = "ucDialogChangeValueOfNeuron";
            this.ucDialogChangeValueOfNeuron.Size = new System.Drawing.Size(1034, 715);
            this.ucDialogChangeValueOfNeuron.TabIndex = 6;
            // 
            // ucDialogResetNetwork
            // 
            this.ucDialogResetNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDialogResetNetwork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucDialogResetNetwork.Location = new System.Drawing.Point(0, 24);
            this.ucDialogResetNetwork.MainWindow = null;
            this.ucDialogResetNetwork.Name = "ucDialogResetNetwork";
            this.ucDialogResetNetwork.Size = new System.Drawing.Size(1034, 715);
            this.ucDialogResetNetwork.TabIndex = 5;
            // 
            // ucMain
            // 
            this.ucMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMain.Location = new System.Drawing.Point(0, 24);
            this.ucMain.Name = "ucMain";
            this.ucMain.Size = new System.Drawing.Size(1034, 715);
            this.ucMain.TabIndex = 0;
            // 
            // ucNetworkDetails
            // 
            this.ucNetworkDetails.BackColor = System.Drawing.SystemColors.Control;
            this.ucNetworkDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNetworkDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucNetworkDetails.Location = new System.Drawing.Point(0, 24);
            this.ucNetworkDetails.MainWindow = null;
            this.ucNetworkDetails.Name = "ucNetworkDetails";
            this.ucNetworkDetails.Size = new System.Drawing.Size(1034, 715);
            this.ucNetworkDetails.TabIndex = 4;
            // 
            // ucCreateNetwork
            // 
            this.ucCreateNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreateNetwork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucCreateNetwork.Location = new System.Drawing.Point(0, 24);
            this.ucCreateNetwork.MainWindow = null;
            this.ucCreateNetwork.Name = "ucCreateNetwork";
            this.ucCreateNetwork.Size = new System.Drawing.Size(1034, 737);
            this.ucCreateNetwork.TabIndex = 3;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.ucDialogLearningData);
            this.Controls.Add(this.ucDialogDataLearningConverter);
            this.Controls.Add(this.ucDialogChart);
            this.Controls.Add(this.ucDialogDgvNeuronsShow);
            this.Controls.Add(this.ucDialogChangeValueOfNeuron);
            this.Controls.Add(this.ucDialogResetNetwork);
            this.Controls.Add(this.ucMain);
            this.Controls.Add(this.ucNetworkDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucCreateNetwork);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 800);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural network";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public CreateNetwork ucCreateNetwork;
        public Main ucMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editActiveNetworkToolStripMenuItem;
        public NetworkDetails ucNetworkDetails;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem susnmnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public DialogResetNetwork ucDialogResetNetwork;
        public DialogDgvShow ucDialogDgvNeuronsShow;
        public DialogChangeValueOfNeuron ucDialogChangeValueOfNeuron;
        public UC.DialogChart ucDialogChart;
        private System.Windows.Forms.ToolStripMenuItem convertCsvFileToDataLearningFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private UC.DialogDataLearningConverter ucDialogDataLearningConverter;
        public DialogLearningData ucDialogLearningData;
    }
}

