namespace Neural
{
    partial class Main
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pPicture = new System.Windows.Forms.Panel();
            this.pbNeuronsPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeuronsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright © Michał Heliński 2018";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 36);
            this.panel1.TabIndex = 3;
            // 
            // pPicture
            // 
            this.pPicture.BackColor = System.Drawing.SystemColors.Control;
            this.pPicture.Controls.Add(this.pbNeuronsPicture);
            this.pPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPicture.Location = new System.Drawing.Point(0, 0);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(1191, 615);
            this.pPicture.TabIndex = 4;
            // 
            // pbNeuronsPicture
            // 
            this.pbNeuronsPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbNeuronsPicture.Image")));
            this.pbNeuronsPicture.Location = new System.Drawing.Point(55, 33);
            this.pbNeuronsPicture.Name = "pbNeuronsPicture";
            this.pbNeuronsPicture.Size = new System.Drawing.Size(1200, 654);
            this.pbNeuronsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeuronsPicture.TabIndex = 0;
            this.pbNeuronsPicture.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pPicture);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1191, 651);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNeuronsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pPicture;
        private System.Windows.Forms.PictureBox pbNeuronsPicture;
    }
}
