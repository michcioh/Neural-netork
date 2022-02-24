namespace RTadeusiewicz.NN.Example04
{
    partial class TeachingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachingPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.uiStepNumber = new System.Windows.Forms.Label();
            this.uiComment = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiTeachMore = new System.Windows.Forms.Button();
            this.uiReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTeachingRatio = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiInputData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiTeachingProgress = new System.Windows.Forms.DataGridView();
            this.uiShowHistory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachingRatio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiInputData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachingProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teaching";
            // 
            // uiStepNumber
            // 
            this.uiStepNumber.AutoSize = true;
            this.uiStepNumber.Location = new System.Drawing.Point(12, 20);
            this.uiStepNumber.Name = "uiStepNumber";
            this.uiStepNumber.Size = new System.Drawing.Size(32, 13);
            this.uiStepNumber.TabIndex = 1;
            this.uiStepNumber.Text = "Step:";
            // 
            // uiComment
            // 
            this.uiComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiComment.AutoEllipsis = true;
            this.uiComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiComment.Location = new System.Drawing.Point(75, 20);
            this.uiComment.Name = "uiComment";
            this.uiComment.Size = new System.Drawing.Size(447, 13);
            this.uiComment.TabIndex = 2;
            this.uiComment.Text = "Comment:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 317);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.uiTeachMore);
            this.flowLayoutPanel1.Controls.Add(this.uiReset);
            this.flowLayoutPanel1.Controls.Add(this.uiShowHistory);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.explanationToolTip1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 281);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 36);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // uiTeachMore
            // 
            this.uiTeachMore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeachMore.AutoSize = true;
            this.uiTeachMore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiTeachMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTeachMore.Location = new System.Drawing.Point(361, 3);
            this.uiTeachMore.Name = "uiTeachMore";
            this.uiTeachMore.Size = new System.Drawing.Size(118, 30);
            this.uiTeachMore.TabIndex = 5;
            this.uiTeachMore.Text = "Teach more!";
            this.uiTeachMore.UseVisualStyleBackColor = true;
            this.uiTeachMore.Click += new System.EventHandler(this.uiTeachMore_Click);
            // 
            // uiReset
            // 
            this.uiReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiReset.AutoSize = true;
            this.uiReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiReset.Location = new System.Drawing.Point(260, 3);
            this.uiReset.Name = "uiReset";
            this.uiReset.Size = new System.Drawing.Size(95, 30);
            this.uiReset.TabIndex = 1;
            this.uiReset.Text = "Restart teaching";
            this.uiReset.UseVisualStyleBackColor = true;
            this.uiReset.Click += new System.EventHandler(this.uiReset_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.uiTeachingRatio, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(32, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(140, 30);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // uiTeachingRatio
            // 
            this.uiTeachingRatio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiTeachingRatio.AutoSize = true;
            this.uiTeachingRatio.DecimalPlaces = 3;
            this.uiTeachingRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.uiTeachingRatio.Location = new System.Drawing.Point(87, 5);
            this.uiTeachingRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiTeachingRatio.Name = "uiTeachingRatio";
            this.uiTeachingRatio.Size = new System.Drawing.Size(50, 20);
            this.uiTeachingRatio.TabIndex = 6;
            this.uiTeachingRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teaching ratio:";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(3, 3);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 30);
            this.explanationToolTip1.TabIndex = 8;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiInputData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input data";
            // 
            // uiInputData
            // 
            this.uiInputData.AllowUserToAddRows = false;
            this.uiInputData.AllowUserToDeleteRows = false;
            this.uiInputData.AllowUserToResizeRows = false;
            this.uiInputData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiInputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiInputData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiInputData.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiInputData.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiInputData.Location = new System.Drawing.Point(6, 19);
            this.uiInputData.MultiSelect = false;
            this.uiInputData.Name = "uiInputData";
            this.uiInputData.ReadOnly = true;
            this.uiInputData.RowHeadersVisible = false;
            this.uiInputData.Size = new System.Drawing.Size(510, 89);
            this.uiInputData.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiTeachingProgress);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 155);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teaching progress";
            // 
            // uiTeachingProgress
            // 
            this.uiTeachingProgress.AllowUserToAddRows = false;
            this.uiTeachingProgress.AllowUserToDeleteRows = false;
            this.uiTeachingProgress.AllowUserToResizeRows = false;
            this.uiTeachingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeachingProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiTeachingProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiTeachingProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiTeachingProgress.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiTeachingProgress.DefaultCellStyle = dataGridViewCellStyle4;
            this.uiTeachingProgress.Location = new System.Drawing.Point(6, 19);
            this.uiTeachingProgress.MultiSelect = false;
            this.uiTeachingProgress.Name = "uiTeachingProgress";
            this.uiTeachingProgress.ReadOnly = true;
            this.uiTeachingProgress.RowHeadersVisible = false;
            this.uiTeachingProgress.Size = new System.Drawing.Size(510, 130);
            this.uiTeachingProgress.TabIndex = 2;
            // 
            // uiShowHistory
            // 
            this.uiShowHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowHistory.AutoSize = true;
            this.uiShowHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiShowHistory.Location = new System.Drawing.Point(205, 3);
            this.uiShowHistory.Name = "uiShowHistory";
            this.uiShowHistory.Size = new System.Drawing.Size(49, 30);
            this.uiShowHistory.TabIndex = 9;
            this.uiShowHistory.Text = "History";
            this.uiShowHistory.UseVisualStyleBackColor = true;
            this.uiShowHistory.Click += new System.EventHandler(this.uiShowHistory_Click);
            // 
            // TeachingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uiComment);
            this.Controls.Add(this.uiStepNumber);
            this.Controls.Add(this.label1);
            this.Name = "TeachingPanel";
            this.Size = new System.Drawing.Size(534, 356);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachingRatio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiInputData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachingProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uiStepNumber;
        private System.Windows.Forms.Label uiComment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button uiTeachMore;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button uiReset;
        private System.Windows.Forms.NumericUpDown uiTeachingRatio;
        private System.Windows.Forms.Label label8;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView uiInputData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView uiTeachingProgress;
        private System.Windows.Forms.Button uiShowHistory;
    }
}
