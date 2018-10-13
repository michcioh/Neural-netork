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
    public partial class DialogChangeValueOfNeuron : UserControl
    {
        int LayerNo;
        int NeuronNo;
        int InputNo;

        public Window MainWindow { get; set; }

        public DialogChangeValueOfNeuron()
        {
            InitializeComponent();
        }

        public void SetControls(int layerNo, int neuronNo, int inputNo, double value, double weight, int decimalPrecision)
        {
            LayerNo = layerNo;
            NeuronNo = neuronNo;
            InputNo = inputNo;

            lLayerNo.Text = (layerNo + 1).ToString();
            lNeuronNo.Text = (neuronNo + 1).ToString();
            lNeuronsInputNo.Text = inputNo.ToString();
            lInputValue.Text = value.ToString();
            nudWeight.DecimalPlaces = decimalPrecision;
            nudWeight.Value = (Decimal)weight;
        }

        private void CreateNetwork_Resize(object sender, EventArgs e)
        {
            pContent.Location = new Point((this.Width - pContent.Width) / 2, (this.Height - pContent.Height) / 2);
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            MainWindow.ucNetworkDetails.NotifyNeuronsWeightChange(LayerNo, NeuronNo, InputNo, (double)nudWeight.Value);
            this.Hide();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            MainWindow.ucNetworkDetails.NotifyNeuronsWeightNotChange();
            this.Hide();
        }

        private void NudWeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BApply_Click(null, null);
            }
        }

        internal void OnActivation()
        {
            nudWeight.Select(0, nudWeight.Value.ToString().Length + 100);
            nudWeight.Focus();
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
