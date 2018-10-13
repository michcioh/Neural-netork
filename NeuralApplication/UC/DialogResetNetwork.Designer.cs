using System;

namespace Neural
{
    partial class DialogResetNetwork
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
            this.bEditAndReset = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.pContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // bEditAndReset
            // 
            this.bEditAndReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditAndReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.bEditAndReset.FlatAppearance.BorderSize = 0;
            this.bEditAndReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditAndReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bEditAndReset.ForeColor = System.Drawing.Color.White;
            this.bEditAndReset.Location = new System.Drawing.Point(235, 180);
            this.bEditAndReset.Name = "bEditAndReset";
            this.bEditAndReset.Size = new System.Drawing.Size(153, 25);
            this.bEditAndReset.TabIndex = 9;
            this.bEditAndReset.Text = "Edit and reset network";
            this.bEditAndReset.UseVisualStyleBackColor = false;
            this.bEditAndReset.Click += new System.EventHandler(this.BEditAndReset_Click);
            // 
            // pContent
            // 
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.label4);
            this.pContent.Controls.Add(this.bCancel);
            this.pContent.Controls.Add(this.bReset);
            this.pContent.Controls.Add(this.bEditAndReset);
            this.pContent.Location = new System.Drawing.Point(74, 75);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(632, 327);
            this.pContent.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(225, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "What do you whant to do?";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Goldenrod;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(394, 180);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 25);
            this.bCancel.TabIndex = 31;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bReset
            // 
            this.bReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bReset.BackColor = System.Drawing.Color.IndianRed;
            this.bReset.FlatAppearance.BorderSize = 0;
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bReset.ForeColor = System.Drawing.Color.White;
            this.bReset.Location = new System.Drawing.Point(76, 180);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(153, 25);
            this.bReset.TabIndex = 29;
            this.bReset.Text = "Reset network";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // DialogResetNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "DialogResetNetwork";
            this.Size = new System.Drawing.Size(800, 600);
            this.Resize += new System.EventHandler(this.CreateNetwork_Resize);
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEditAndReset;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label4;
    }
}
