namespace RTadeusiewicz.NN.Controls
{
    partial class ExplanationToolTip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiLabel = new System.Windows.Forms.Label();
            this.uiToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // uiLabel
            // 
            this.uiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel.Image = global::RTadeusiewicz.NN.Controls.Properties.Resources.Help;
            this.uiLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel.Location = new System.Drawing.Point(0, 0);
            this.uiLabel.Name = "uiLabel";
            this.uiLabel.Size = new System.Drawing.Size(23, 23);
            this.uiLabel.TabIndex = 3;
            this.uiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel.MouseEnter += new System.EventHandler(this.uiLabel_MouseEnter);
            // 
            // uiToolTip
            // 
            this.uiToolTip.AutoPopDelay = 30000;
            this.uiToolTip.InitialDelay = 0;
            this.uiToolTip.ReshowDelay = 100;
            this.uiToolTip.ShowAlways = true;
            this.uiToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.uiToolTip.ToolTipTitle = "Explanation";
            // 
            // ExplanationToolTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiLabel);
            this.Name = "ExplanationToolTip";
            this.Size = new System.Drawing.Size(23, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uiLabel;
        private System.Windows.Forms.ToolTip uiToolTip;
    }
}
