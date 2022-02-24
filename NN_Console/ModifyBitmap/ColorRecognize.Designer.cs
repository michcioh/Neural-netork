namespace ModifyBitmap
{
    partial class ColorRecognize
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
            this.pSource = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pDestination = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cdChooseColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // pSource
            // 
            this.pSource.BackColor = System.Drawing.Color.Black;
            this.pSource.Location = new System.Drawing.Point(12, 45);
            this.pSource.Name = "pSource";
            this.pSource.Size = new System.Drawing.Size(300, 300);
            this.pSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color to guess:";
            // 
            // pDestination
            // 
            this.pDestination.BackColor = System.Drawing.Color.Black;
            this.pDestination.Location = new System.Drawing.Point(318, 45);
            this.pDestination.Name = "pDestination";
            this.pDestination.Size = new System.Drawing.Size(300, 300);
            this.pDestination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Network answer:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorRecognize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pSource);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorRecognize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color recognize";
            this.Load += new System.EventHandler(this.ColorRecognize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog cdChooseColor;
    }
}

