using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuralNet;

namespace Neural
{
    public partial class DialogResetNetwork : UserControl
    {
        public Window MainWindow { get; set; }

        public DialogResetNetwork()
        {
            InitializeComponent();
        }

        public void ControlActivation()
        {
            bEditAndReset.Focus();
        }

        private void CreateNetwork_Resize(object sender, EventArgs e)
        {
            pContent.Location = new Point((this.Width - pContent.Width) / 2, (this.Height - pContent.Height) / 2);
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            // TOOD: ERROR FATAL - application freeze!
            MainWindow.ucNetworkDetails.ResetNetwork();
            this.Hide();
        }

        private void BEditAndReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow.ChangePage(MainWindow.ucCreateNetwork.GetType());
            MainWindow.ucCreateNetwork.ControlActivation(MainWindow.ucNetworkDetails.GetNetwork());
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                BCancel_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
