namespace RTadeusiewicz.NN.Controls
{
    partial class HistoryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryWindow));
            this.uiHistoryPlotter = new RTadeusiewicz.NN.Controls.ChartPlotter();
            this.SuspendLayout();
            // 
            // uiHistoryPlotter
            // 
            this.uiHistoryPlotter.AxesVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.Horizontal;
            this.uiHistoryPlotter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiHistoryPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiHistoryPlotter.Location = new System.Drawing.Point(0, 0);
            this.uiHistoryPlotter.Name = "uiHistoryPlotter";
            this.uiHistoryPlotter.Size = new System.Drawing.Size(208, 140);
            this.uiHistoryPlotter.TabIndex = 0;
            this.uiHistoryPlotter.Text = "chartPlotter1";
            this.uiHistoryPlotter.TickDistance = 0.1F;
            this.uiHistoryPlotter.TicksVisibility = RTadeusiewicz.NN.Controls.ChartSurface.Axes.Vertical;
            this.uiHistoryPlotter.VisibleRectangle = ((System.Drawing.RectangleF)(resources.GetObject("uiHistoryPlotter.VisibleRectangle")));
            // 
            // HistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 140);
            this.Controls.Add(this.uiHistoryPlotter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HistoryWindow";
            this.ShowInTaskbar = false;
            this.Text = "Teaching progress history";
            this.ResumeLayout(false);

        }

        #endregion

        private RTadeusiewicz.NN.Controls.ChartPlotter uiHistoryPlotter;
    }
}