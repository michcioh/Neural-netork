namespace RTadeusiewicz.NN.Example03
{
    partial class SetUpPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTeachingSet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTeachingSetBrowse = new System.Windows.Forms.Button();
            this.uiTeachingSetReset = new System.Windows.Forms.Button();
            this.uiOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the teaching set file";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // uiTeachingSet
            // 
            this.uiTeachingSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeachingSet.Location = new System.Drawing.Point(3, 135);
            this.uiTeachingSet.Name = "uiTeachingSet";
            this.uiTeachingSet.Size = new System.Drawing.Size(141, 20);
            this.uiTeachingSet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teaching set file:";
            // 
            // uiTeachingSetBrowse
            // 
            this.uiTeachingSetBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeachingSetBrowse.Location = new System.Drawing.Point(150, 133);
            this.uiTeachingSetBrowse.Name = "uiTeachingSetBrowse";
            this.uiTeachingSetBrowse.Size = new System.Drawing.Size(75, 23);
            this.uiTeachingSetBrowse.TabIndex = 4;
            this.uiTeachingSetBrowse.Text = "Browse...";
            this.uiTeachingSetBrowse.UseVisualStyleBackColor = true;
            this.uiTeachingSetBrowse.Click += new System.EventHandler(this.uiTeachingSetBrowse_Click);
            // 
            // uiTeachingSetReset
            // 
            this.uiTeachingSetReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeachingSetReset.Location = new System.Drawing.Point(231, 133);
            this.uiTeachingSetReset.Name = "uiTeachingSetReset";
            this.uiTeachingSetReset.Size = new System.Drawing.Size(110, 23);
            this.uiTeachingSetReset.TabIndex = 5;
            this.uiTeachingSetReset.Text = "Reset to default";
            this.uiTeachingSetReset.UseVisualStyleBackColor = true;
            this.uiTeachingSetReset.Click += new System.EventHandler(this.uiTeachingSetReset_Click);
            // 
            // uiOpenFile
            // 
            this.uiOpenFile.DefaultExt = "txt";
            this.uiOpenFile.Filter = "Text files|*.txt|All files|*.*";
            this.uiOpenFile.Title = "Open teaching sequence";
            // 
            // SetUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.uiTeachingSetReset);
            this.Controls.Add(this.uiTeachingSetBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiTeachingSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetUpPanel";
            this.Size = new System.Drawing.Size(344, 232);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiTeachingSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiTeachingSetBrowse;
        private System.Windows.Forms.Button uiTeachingSetReset;
        private System.Windows.Forms.OpenFileDialog uiOpenFile;
    }
}
