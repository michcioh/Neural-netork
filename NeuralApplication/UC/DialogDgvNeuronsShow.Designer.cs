namespace Neural
{
    partial class DialogDgvShow
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
            this.bCancel = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pDgv = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Goldenrod;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(589, 409);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 25);
            this.bCancel.TabIndex = 32;
            this.bCancel.Text = "Close";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(739, 400);
            this.dgv.TabIndex = 33;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNeurons_CellDoubleClick);
            // 
            // pDgv
            // 
            this.pDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDgv.Controls.Add(this.dgv);
            this.pDgv.Location = new System.Drawing.Point(3, 3);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(739, 400);
            this.pDgv.TabIndex = 34;
            // 
            // DialogDgvShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pDgv);
            this.Controls.Add(this.bCancel);
            this.Name = "DialogDgvShow";
            this.Size = new System.Drawing.Size(745, 437);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pDgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pDgv;
    }
}
