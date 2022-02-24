namespace RTadeusiewicz.NN.Controls
{
    partial class WizardForm
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
            this.uiBack = new System.Windows.Forms.Button();
            this.uiNext = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiContainerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiBack
            // 
            this.uiBack.AutoSize = true;
            this.uiBack.Location = new System.Drawing.Point(3, 3);
            this.uiBack.Name = "uiBack";
            this.uiBack.Size = new System.Drawing.Size(75, 23);
            this.uiBack.TabIndex = 0;
            this.uiBack.Text = "< Back";
            this.uiBack.UseVisualStyleBackColor = true;
            this.uiBack.Click += new System.EventHandler(this.uiBack_Click);
            // 
            // uiNext
            // 
            this.uiNext.AutoSize = true;
            this.uiNext.Location = new System.Drawing.Point(84, 3);
            this.uiNext.Name = "uiNext";
            this.uiNext.Size = new System.Drawing.Size(75, 23);
            this.uiNext.TabIndex = 1;
            this.uiNext.Text = "Next >";
            this.uiNext.UseVisualStyleBackColor = true;
            this.uiNext.Click += new System.EventHandler(this.uiNext_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.uiNext);
            this.flowLayoutPanel1.Controls.Add(this.uiBack);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(355, 298);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // uiContainerPanel
            // 
            this.uiContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiContainerPanel.Location = new System.Drawing.Point(12, 12);
            this.uiContainerPanel.Name = "uiContainerPanel";
            this.uiContainerPanel.Size = new System.Drawing.Size(505, 275);
            this.uiContainerPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 2);
            this.label1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiContainerPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 339);
            this.panel1.TabIndex = 5;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 339);
            this.Controls.Add(this.panel1);
            this.Name = "WizardForm";
            this.Text = "WizardForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiBack;
        private System.Windows.Forms.Button uiNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel uiContainerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}