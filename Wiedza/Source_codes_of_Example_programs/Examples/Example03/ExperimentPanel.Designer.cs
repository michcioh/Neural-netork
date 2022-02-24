namespace RTadeusiewicz.NN.Example03
{
    partial class ExperimentPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperimentPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.uiKnownObjects = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputData = new System.Windows.Forms.DataGridView();
            this.uiResponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiKnownObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiInputData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Experiments";
            // 
            // uiKnownObjects
            // 
            this.uiKnownObjects.AllowUserToAddRows = false;
            this.uiKnownObjects.AllowUserToDeleteRows = false;
            this.uiKnownObjects.AllowUserToResizeRows = false;
            this.uiKnownObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiKnownObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiKnownObjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiKnownObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiKnownObjects.Location = new System.Drawing.Point(3, 36);
            this.uiKnownObjects.MultiSelect = false;
            this.uiKnownObjects.Name = "uiKnownObjects";
            this.uiKnownObjects.ReadOnly = true;
            this.uiKnownObjects.RowHeadersVisible = false;
            this.uiKnownObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiKnownObjects.Size = new System.Drawing.Size(478, 162);
            this.uiKnownObjects.TabIndex = 2;
            this.uiKnownObjects.SelectionChanged += new System.EventHandler(this.uiKnownObjects_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Those are the objects our neuron should already know:";
            // 
            // uiInputData
            // 
            this.uiInputData.AllowUserToAddRows = false;
            this.uiInputData.AllowUserToDeleteRows = false;
            this.uiInputData.AllowUserToResizeRows = false;
            this.uiInputData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiInputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiInputData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiInputData.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiInputData.DefaultCellStyle = dataGridViewCellStyle1;
            this.uiInputData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.uiInputData.Location = new System.Drawing.Point(3, 217);
            this.uiInputData.MultiSelect = false;
            this.uiInputData.Name = "uiInputData";
            this.uiInputData.RowHeadersVisible = false;
            this.uiInputData.Size = new System.Drawing.Size(478, 74);
            this.uiInputData.TabIndex = 2;
            this.uiInputData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiInputData_CellValueChanged);
            // 
            // uiResponse
            // 
            this.uiResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiResponse.BackColor = System.Drawing.SystemColors.Control;
            this.uiResponse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiResponse.Location = new System.Drawing.Point(381, 299);
            this.uiResponse.Name = "uiResponse";
            this.uiResponse.Size = new System.Drawing.Size(100, 20);
            this.uiResponse.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Here you can enter the feature values for the object to be recognized:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(286, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Response:";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.explanationToolTip1.Location = new System.Drawing.Point(3, 297);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(23, 23);
            this.explanationToolTip1.TabIndex = 7;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(185, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Recalculate!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExperimentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.explanationToolTip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiInputData);
            this.Controls.Add(this.uiKnownObjects);
            this.Controls.Add(this.label1);
            this.Name = "ExperimentPanel";
            this.Size = new System.Drawing.Size(484, 323);
            ((System.ComponentModel.ISupportInitialize)(this.uiKnownObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiInputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiKnownObjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView uiInputData;
        private System.Windows.Forms.TextBox uiResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.Button button1;
    }
}
