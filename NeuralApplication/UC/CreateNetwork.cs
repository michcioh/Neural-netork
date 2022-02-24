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
    public partial class CreateNetwork : UserControl
    {
        private NeuralNetwork Network;
        public Window MainWindow { get; set; }

        public CreateNetwork()
        {
            InitializeComponent();
            SetRows();
        }

        private void CreateNetwork_Resize(object sender, EventArgs e)
        {
            pContent.Location = new Point((this.Width - pContent.Width) / 2, (this.Height - pContent.Height) / 2);
        }

        public void ControlActivation(NeuralNetwork network)
        {
            if (network == null)
            {
                ResetToDefault();
            }
            else
            {
                Network = network;

                //cbActivationFunction.SelectedIndex = (int) Network.activationFunction;
                cbLearningMethod.SelectedIndex = Network.MethodOfLearning == NeuralNetwork.LearningMethod.NOT_LINEAR ? 0 : 1;

                dgvLayers.Rows.Clear();
                for (int layerNo = 0; layerNo < Network.Topology.Layers.Count; layerNo++)
                {
                    Layer layer = Network.Topology.Layers[layerNo];

                    int inputNeuronsCount =
                        (Network.Topology.IsNetworkUsingBiases && Network.Topology.Layers[layerNo].Type != Layer.LayerType.OUTPUT) ?
                            layer.Neurons.Count - 1:
                            layer.Neurons.Count;

                    dgvLayers.Rows.Add(new String[] {
                        "",
                        inputNeuronsCount.ToString(),
                        layer.LayerActivationFunction == NeuralNetwork.ActivationFunction.SIGMOID ? "sigmoid <0, 1>" : "tanh <-1, 1>"
                    });
                }

                SetRows();
                cbUsesBiasNeurons.Checked = Network.Topology.IsNetworkUsingBiases;
                tbName.Text = Network.Name;
            }

            tbName.SelectAll();
            tbName.Focus();
        }

        private void DgvLayers_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetRows();
        }

        private void DgvLayers_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetRows();
        }

        private void SetRows()
        {
            for (int row = 0; row < dgvLayers.RowCount; row++)
            {
                dgvLayers.Rows[row].Cells["LayerNo"].Value = "Layer " + (row + 1);
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgvLayers.Rows[row].Cells["Function"];
                if (cell.Value == null)
                {
                    cell.Value = cell.Items[0].ToString();
                }
            }
        }

        private void BResetToDefault_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Really?", "Confirm reset values", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ResetToDefault();
            }
        }

        private void ResetToDefault()
        {
            cbLearningMethod.SelectedIndex = 0;

            dgvLayers.Rows.Clear();
            SetRows();
            cbUsesBiasNeurons.Checked = true;
            nudMinWeight.Value = (Decimal) (-1.0);
            nudMaxWeight.Value = (Decimal) 1.0;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Network = null;
            this.Visible = false;
        }

        private void BCreateNetwork_Click(object sender, EventArgs e)
        {
            // TODO: ERROR: Un-check "network uses bias" on crete and will be crash!
            // TODO: ERROR: Something is wrong when new network is bigger (I don't think smaller) then current before creating new one.
            if (nudMinWeight.Value > nudMaxWeight.Value)
            {
                MessageBox.Show(this, "Minimum weight is greater than maximum weight!", "Wrong minimum and maximum weight values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: EVOLUTION: validation seems to be neccesery! All rows should be fill correctly or should be information about not used rows
            List<LayerCreationInfo> layerCreationInfoList = new List<LayerCreationInfo>();

            for (int row = 0; row < dgvLayers.RowCount; row++)
            {
                if (dgvLayers.Rows[row].Cells["NeuronsQuantity"].Value == null ||
                    dgvLayers.Rows[row].Cells["Function"].Value == null) continue;

                String quantity = dgvLayers.Rows[row].Cells["NeuronsQuantity"].Value.ToString();
                try
                {
                    int intQuantity = Int32.Parse(quantity);

                    if (intQuantity < 1)
                    {
                        MessageBox.Show(this, quantity + " <- this value is a bed idea!", "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    layerCreationInfoList.Add(new LayerCreationInfo()
                    {
                        HowManyNeuronsPerLayer = intQuantity + (cbUsesBiasNeurons.Checked ? 1 : 0),
                        LayerNo = row,
                        LayerActivationFunction = ActivationFunctionFromRowIdx(row),
                        PreviousLayerNeuronsCount = layerCreationInfoList.Count == 0 ? 0 : layerCreationInfoList.ElementAt(layerCreationInfoList.Count - 1).HowManyNeuronsPerLayer
                    });
                } catch (FormatException)
                {
                    MessageBox.Show(this, quantity + " is not a decimal value!", "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // last layer has addde redundant bias neuron, need decrease neurons count:
            layerCreationInfoList.Last().HowManyNeuronsPerLayer--;

            if (layerCreationInfoList.Count < 2)
            {
                MessageBox.Show(this, "Network must have at least two layers!", "Need more layers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RandomWeight.MinWeight = (double)nudMinWeight.Value;
            RandomWeight.MaxWeight = (double)nudMaxWeight.Value;

            Topology topology = new Topology(layerCreationInfoList, cbUsesBiasNeurons.Checked);
            NeuralNetwork network = new NeuralNetwork(
                topology,
                (double)nudMinWeight.Value,
                (double)nudMaxWeight.Value,
                cbLearningMethod.SelectedIndex == 0 ? NeuralNetwork.LearningMethod.NOT_LINEAR : NeuralNetwork.LearningMethod.LINEAR,
                tbName.Text
            );

            network.PropagateValuesForward();

            MainWindow.NotifyNetworkCreated(network);
            this.Visible = false;
        }
        
        private NeuralNetwork.ActivationFunction ActivationFunctionFromRowIdx(int rowIdx)
        {
            DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgvLayers.Rows[rowIdx].Cells["Function"];
            int idx = cell.Items.IndexOf(cell.Value);

            switch (idx)
            {
                case 0:
                    return NeuralNetwork.ActivationFunction.SIGMOID;
                case 1:
                    return NeuralNetwork.ActivationFunction.TANH;
                default:
                    throw new Exception("Not recognized idx for activation function! (idx=" + idx + ")");
            }
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

        private void CbLearningMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLearningMethod.SelectedIndex == 1)
            {
                // TODO: !IMPLEMENTED: How about linear learning method now? Needs to use linear activation function? How it works now?
                MainWindow.NotImplementedMessage(); 
                cbLearningMethod.SelectedIndex = 0;
            }
        }
    }
}
