using System;

namespace Neural
{
    partial class DialogChangeValueOfNeuron
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
            this.bApply = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.lNeuronsInputNo = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lInputValue = new System.Windows.Forms.Label();
            this.lNeuronNo = new System.Windows.Forms.Label();
            this.lLayerNo = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.pContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.bApply.FlatAppearance.BorderSize = 0;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bApply.ForeColor = System.Drawing.Color.White;
            this.bApply.Location = new System.Drawing.Point(144, 255);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(153, 25);
            this.bApply.TabIndex = 9;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // pContent
            // 
            this.pContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContent.Controls.Add(this.lNeuronsInputNo);
            this.pContent.Controls.Add(this.label100);
            this.pContent.Controls.Add(this.label5);
            this.pContent.Controls.Add(this.lInputValue);
            this.pContent.Controls.Add(this.lNeuronNo);
            this.pContent.Controls.Add(this.lLayerNo);
            this.pContent.Controls.Add(this.nudWeight);
            this.pContent.Controls.Add(this.label3);
            this.pContent.Controls.Add(this.label2);
            this.pContent.Controls.Add(this.label1);
            this.pContent.Controls.Add(this.label4);
            this.pContent.Controls.Add(this.bCancel);
            this.pContent.Controls.Add(this.bApply);
            this.pContent.Location = new System.Drawing.Point(74, 75);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(632, 327);
            this.pContent.TabIndex = 10;
            // 
            // lNeuronsInputNo
            // 
            this.lNeuronsInputNo.AutoSize = true;
            this.lNeuronsInputNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNeuronsInputNo.Location = new System.Drawing.Point(300, 138);
            this.lNeuronsInputNo.Name = "lNeuronsInputNo";
            this.lNeuronsInputNo.Size = new System.Drawing.Size(97, 17);
            this.lNeuronsInputNo.TabIndex = 47;
            this.lNeuronsInputNo.Text = "Neuron\'s input";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label100.Location = new System.Drawing.Point(179, 138);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(116, 17);
            this.label100.TabIndex = 46;
            this.label100.Text = "Neuron\'s input no:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(140, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Changing weight of neuron";
            // 
            // lInputValue
            // 
            this.lInputValue.AutoSize = true;
            this.lInputValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lInputValue.Location = new System.Drawing.Point(300, 169);
            this.lInputValue.Name = "lInputValue";
            this.lInputValue.Size = new System.Drawing.Size(76, 17);
            this.lInputValue.TabIndex = 44;
            this.lInputValue.Text = "input value";
            // 
            // lNeuronNo
            // 
            this.lNeuronNo.AutoSize = true;
            this.lNeuronNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNeuronNo.Location = new System.Drawing.Point(300, 107);
            this.lNeuronNo.Name = "lNeuronNo";
            this.lNeuronNo.Size = new System.Drawing.Size(98, 17);
            this.lNeuronNo.TabIndex = 43;
            this.lNeuronNo.Text = "Neuron\'s layer:";
            // 
            // lLayerNo
            // 
            this.lLayerNo.AutoSize = true;
            this.lLayerNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLayerNo.Location = new System.Drawing.Point(300, 76);
            this.lLayerNo.Name = "lLayerNo";
            this.lLayerNo.Size = new System.Drawing.Size(57, 17);
            this.lLayerNo.TabIndex = 42;
            this.lLayerNo.Text = "layer no";
            // 
            // nudWeight
            // 
            this.nudWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudWeight.Location = new System.Drawing.Point(303, 198);
            this.nudWeight.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(100, 25);
            this.nudWeight.TabIndex = 41;
            this.nudWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NudWeight_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(179, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Weight value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(179, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Input value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(179, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Neuron\'s no.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(179, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Neuron\'s layer no:";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Goldenrod;
            this.bCancel.FlatAppearance.BorderSize = 0;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(303, 255);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 25);
            this.bCancel.TabIndex = 31;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // DialogChangeValueOfNeuron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "DialogChangeValueOfNeuron";
            this.Size = new System.Drawing.Size(800, 600);
            this.Resize += new System.EventHandler(this.CreateNetwork_Resize);
            this.pContent.ResumeLayout(false);
            this.pContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lInputValue;
        private System.Windows.Forms.Label lNeuronNo;
        private System.Windows.Forms.Label lLayerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lNeuronsInputNo;
        private System.Windows.Forms.Label label100;
    }
}
