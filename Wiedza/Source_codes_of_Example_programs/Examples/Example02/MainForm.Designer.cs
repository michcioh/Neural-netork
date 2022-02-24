namespace RTadeusiewicz.NN.Example02
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
            this.uiSignalGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiMainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.uiShowWinner = new System.Windows.Forms.CheckBox();
            this.uiWinner = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiWinnerNumber = new System.Windows.Forms.Label();
            this.uiResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.explanationToolTip2 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.uiSignalGrid)).BeginInit();
            this.uiMainLayoutPanel.SuspendLayout();
            this.uiWinner.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSignalGrid
            // 
            this.uiSignalGrid.AllowUserToAddRows = false;
            this.uiSignalGrid.AllowUserToDeleteRows = false;
            this.uiSignalGrid.AllowUserToResizeRows = false;
            this.uiSignalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiSignalGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiSignalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiMainLayoutPanel.SetColumnSpan(this.uiSignalGrid, 2);
            this.uiSignalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSignalGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.uiSignalGrid.Location = new System.Drawing.Point(3, 68);
            this.uiSignalGrid.MultiSelect = false;
            this.uiSignalGrid.Name = "uiSignalGrid";
            this.uiSignalGrid.RowHeadersVisible = false;
            this.uiSignalGrid.Size = new System.Drawing.Size(485, 103);
            this.uiSignalGrid.TabIndex = 0;
            this.uiSignalGrid.VirtualMode = true;
            this.uiSignalGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiSignalGrid_CellClick);
            this.uiSignalGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.uiSignalGrid_CellValueNeeded);
            this.uiSignalGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.uiSignalGrid_CurrentCellDirtyStateChanged);
            this.uiSignalGrid.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.uiSignalGrid_CellValuePushed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // uiMainLayoutPanel
            // 
            this.uiMainLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMainLayoutPanel.ColumnCount = 2;
            this.uiMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiMainLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.uiMainLayoutPanel.Controls.Add(this.explanationToolTip1, 1, 0);
            this.uiMainLayoutPanel.Controls.Add(this.uiSignalGrid, 0, 1);
            this.uiMainLayoutPanel.Controls.Add(this.uiShowWinner, 0, 2);
            this.uiMainLayoutPanel.Controls.Add(this.uiWinner, 0, 3);
            this.uiMainLayoutPanel.Controls.Add(this.explanationToolTip2, 1, 2);
            this.uiMainLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.uiMainLayoutPanel.Name = "uiMainLayoutPanel";
            this.uiMainLayoutPanel.RowCount = 4;
            this.uiMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiMainLayoutPanel.Size = new System.Drawing.Size(491, 294);
            this.uiMainLayoutPanel.TabIndex = 3;
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(465, 3);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip1.TabIndex = 2;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // uiShowWinner
            // 
            this.uiShowWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiShowWinner.AutoSize = true;
            this.uiShowWinner.Location = new System.Drawing.Point(3, 183);
            this.uiShowWinner.Name = "uiShowWinner";
            this.uiShowWinner.Size = new System.Drawing.Size(105, 17);
            this.uiShowWinner.TabIndex = 3;
            this.uiShowWinner.Text = "Show the winner";
            this.uiShowWinner.UseVisualStyleBackColor = true;
            this.uiShowWinner.CheckedChanged += new System.EventHandler(this.uiShowWinner_CheckedChanged);
            // 
            // uiWinner
            // 
            this.uiWinner.AutoSize = true;
            this.uiMainLayoutPanel.SetColumnSpan(this.uiWinner, 2);
            this.uiWinner.Controls.Add(this.tableLayoutPanel2);
            this.uiWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiWinner.Location = new System.Drawing.Point(3, 206);
            this.uiWinner.Name = "uiWinner";
            this.uiWinner.Size = new System.Drawing.Size(485, 85);
            this.uiWinner.TabIndex = 4;
            this.uiWinner.TabStop = false;
            this.uiWinner.Text = "Winner";
            this.uiWinner.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.uiThreshold, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.uiWinnerNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiResult, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 66);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // uiThreshold
            // 
            this.uiThreshold.AutoSize = true;
            this.uiThreshold.DecimalPlaces = 1;
            this.uiThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uiThreshold.Location = new System.Drawing.Point(186, 43);
            this.uiThreshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uiThreshold.Name = "uiThreshold";
            this.uiThreshold.Size = new System.Drawing.Size(44, 20);
            this.uiThreshold.TabIndex = 4;
            this.uiThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.uiThreshold.ValueChanged += new System.EventHandler(this.uiThreshold_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "And the winner is...";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Because of this, the network claims:";
            // 
            // uiWinnerNumber
            // 
            this.uiWinnerNumber.AutoSize = true;
            this.uiWinnerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiWinnerNumber.Location = new System.Drawing.Point(186, 0);
            this.uiWinnerNumber.Name = "uiWinnerNumber";
            this.uiWinnerNumber.Size = new System.Drawing.Size(57, 20);
            this.uiWinnerNumber.TabIndex = 2;
            this.uiWinnerNumber.Text = "label4";
            // 
            // uiResult
            // 
            this.uiResult.AutoSize = true;
            this.uiResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiResult.Location = new System.Drawing.Point(186, 20);
            this.uiResult.Name = "uiResult";
            this.uiResult.Size = new System.Drawing.Size(57, 20);
            this.uiResult.TabIndex = 3;
            this.uiResult.Text = "label5";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Threshold:";
            // 
            // explanationToolTip2
            // 
            this.explanationToolTip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.explanationToolTip2.Location = new System.Drawing.Point(465, 177);
            this.explanationToolTip2.Name = "explanationToolTip2";
            this.explanationToolTip2.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip2.TabIndex = 2;
            this.explanationToolTip2.ToolTipText = resources.GetString("explanationToolTip2.ToolTipText");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 318);
            this.Controls.Add(this.uiMainLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(463, 352);
            this.Name = "MainForm";
            this.Text = "Simple linear neural network (example 02)";
            ((System.ComponentModel.ISupportInitialize)(this.uiSignalGrid)).EndInit();
            this.uiMainLayoutPanel.ResumeLayout(false);
            this.uiMainLayoutPanel.PerformLayout();
            this.uiWinner.ResumeLayout(false);
            this.uiWinner.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiSignalGrid;
        private System.Windows.Forms.Label label1;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.TableLayoutPanel uiMainLayoutPanel;
        private System.Windows.Forms.CheckBox uiShowWinner;
        private System.Windows.Forms.GroupBox uiWinner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uiWinnerNumber;
        private System.Windows.Forms.Label uiResult;
        private System.Windows.Forms.NumericUpDown uiThreshold;
        private System.Windows.Forms.Label label4;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip2;
    }
}