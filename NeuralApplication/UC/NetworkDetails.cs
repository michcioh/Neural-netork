using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuralNet;
using System.IO;

namespace Neural
{
    public partial class NetworkDetails : UserControl
    {
        private NeuralNetwork Network; // setting and getting by SetNetwork and GetNetwork methods

        public Window MainWindow { get; set; }

        private int F11_F12_SIZE_CHANGED = 50;

        int howManyDigitsShowAfterDotPlaces = 4;
        private double learningRatio;

        public int epochMax { get; private set; }
        public bool bLearnXTimes { get; private set; }
        public bool bLearnUntilMinError { get; private set; }
        public double minimumError { get; private set; }

        private bool bUsingDataInSequence;
        private bool bUsingDataRandom;
        private string bwError;
        private bool bwRunning;
        private int epochNo = 0;

        public void NotifyLearnDataChange()
        {
            int dataQuantity = MainWindow.ucDialogLearningData.GetLearnSamples() == null ? 
                0 : MainWindow.ucDialogLearningData.GetLearnSamples().Count;

            tbLearningDataQuantity.Text = dataQuantity == 0 ? "<data not set>" : dataQuantity.ToString();
        }

        private bool DoRefreshDgvNeurons = true;

        public NetworkDetails()
        {
            InitializeComponent();
            bStopLearning.Location = bLearn.Location;
        }

        private void CreateNetwork_Resize(object sender, EventArgs e)
        {
            pContent.Location = new Point((this.Width - pContent.Width) / 2, (this.Height - pContent.Height) / 2);
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you wish to close this network without saving?", "Confirm close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Visible = false;
                this.MainWindow.NotifyNetworkClosed();
            }
        }

        public void SetNetwork(NeuralNetwork network)
        {
            this.Network = network;
            tbName.Text = network.Name;
            tbBias.Text = network.Topology.IsNetworkUsingBiases ? "yes" : "no";
            tbLearningMethod.Text = network.MethodOfLearning == NeuralNetwork.LearningMethod.LINEAR ? "linear" : "non linear";
            Tools.DoubleBuffered(pbNetworkError, true);

            SetColumnsDgvNeurons();
            RefreshDgvNeurons();

            WriteColumsToDgvNetworkTest();
        }

        public void NotifyNeuronsWeightNotChange()
        {
            dgvNeurons.Focus();
        }

        public NeuralNetwork GetNetwork()
        {
            return Network;
        }

        private void BSaveNetwork_Click(object sender, EventArgs e)
        {
            this.MainWindow.SaveToolStripMenuItem_Click(null, null);
        }

        internal void SavedOk()
        {
            tTimerSuccessfully.Stop();
            tTimerSuccessfully.Start();
            lSavedSuccessfully.Visible = true;
        }

        private void TTimerSuccessfully_Tick(object sender, EventArgs e)
        {
            tTimerSuccessfully.Stop();
            lSavedSuccessfully.Visible = false;
        }

        private void BReadingDataFile_Click(object sender, EventArgs e)
        {
            MainWindow.ChangePage(MainWindow.ucDialogLearningData.GetType());
            MainWindow.ucDialogLearningData.OnActivation(
                Network.Topology.GetInputCount(false), 
                Network.Topology.OutputCount, 
                Network.Topology.IsNetworkUsingBiases);
        }

        private void WriteColumsToDgvNetworkTest()
        {
            dgvTestData.Rows.Clear();
            dgvTestData.Columns.Clear();

            // columns
            dgvTestData.Columns.Add("lineNo", "Line no.");

            dgvTestData.Columns[0].ReadOnly = true;
            dgvTestData.Columns[0].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            dgvTestData.Columns[0].MinimumWidth = 80;

            for (int col = 0; col < Network.Topology.GetInputCount(false); col++)
            {
                dgvTestData.Columns.Add("in" + col, "input " + (col + 1));
                dgvTestData.Columns["in" + col].MinimumWidth = 75;
            }

            String rmsErrorColumnName = "rmsError" + dgvTestData.Columns.Count;

            dgvTestData.Columns.Add(rmsErrorColumnName, "RMS Error");
            dgvTestData.Columns[rmsErrorColumnName].MinimumWidth = 100;
            dgvTestData.Columns[rmsErrorColumnName].DefaultCellStyle.BackColor = Color.MistyRose;
            dgvTestData.Columns[rmsErrorColumnName].ReadOnly = true;

            for (int col = 0; col < Network.Topology.OutputCount; col++)
            {
                dgvTestData.Columns.Add("out" + (col + 1), "output " + (col + 1));
                dgvTestData.Columns[dgvTestData.Columns.Count - 1].DefaultCellStyle.BackColor = Color.OldLace;
                dgvTestData.Columns[dgvTestData.Columns.Count - 1].ReadOnly = true;
                dgvTestData.Columns["out" + (col + 1)].MinimumWidth = 90;

                dgvTestData.Columns.Add("Exp " + (col + 1), "expected output " + (col + 1));
                dgvTestData.Columns["Exp " + (col + 1)].DefaultCellStyle.BackColor = Color.SeaShell;
                dgvTestData.Columns["Exp " + (col + 1)].ReadOnly = true;
                dgvTestData.Columns["Exp " + (col + 1)].MinimumWidth = 140;


                dgvTestData.Columns.Add("Error " + (col + 1), "error output " + (col + 1));
                dgvTestData.Columns["Error " + (col + 1)].DefaultCellStyle.BackColor = Color.MistyRose;
                dgvTestData.Columns["Error " + (col + 1)].ReadOnly = true;
                dgvTestData.Columns["Error " + (col + 1)].MinimumWidth = 125;

            }

            foreach(DataGridViewColumn col in dgvTestData.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvTestData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            SetNamesEndEmptyValuesForTestData();
        }

        private void BSaveLearningDataToFile_Click(object sender, EventArgs e)
        {
            
        }

        private void BResetNetwork_Click(object sender, EventArgs e)
        {
            MainWindow.ChangePage(MainWindow.ucDialogResetNetwork.GetType());
        }

        public void ResetNetwork()
        {
            DoRefreshDgvNeurons = false;
            Network.ResetNetwork();
            DoRefreshDgvNeurons = true;
            RefreshDgvNeurons();
            TestNetwork();
            ShowCurrentNetworkError();
        }

        private void RefreshDgvNeurons()
        {
            if (!DoRefreshDgvNeurons) return;

            int selectedRowIdx = -1;
            int selectedColumnIdx = -1;

            if (dgvNeurons.SelectedCells.Count == 1)
            {
                selectedRowIdx = dgvNeurons.SelectedCells[0].RowIndex;
                selectedColumnIdx = dgvNeurons.SelectedCells[0].ColumnIndex;
            }

            dgvNeurons.Rows.Clear();

            dgvNeurons.Columns[2].Visible = Network.Topology.IsNetworkUsingBiases;

            for (int layerNo = 0; layerNo < Network.Topology.Layers.Count; layerNo++)
            {
                Layer layer = Network.Topology.Layers[layerNo];

                String[] tab = new String[dgvNeurons.ColumnCount];
                tab[0] = (layerNo + 1).ToString();

                for (int neuronNo = 0; neuronNo < layer.Neurons.Count; neuronNo++)
                {
                    Neuron neuron = Network.Topology.Layers[layerNo].Neurons[neuronNo];

                    tab[1] = (neuronNo + 1).ToString();
                    tab[2] = neuron.IsBias ? "yes" : "no";
                    tab[3] = layer.LayerActivationFunction.ToString();

                    int idx = 4;

                    for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                    {
                        if (!neuron.IsBias)
                        {
                            Input input = neuron.Inputs[inputNo];

                            if (layerNo == 0)
                            {
                                tab[idx++] = "none";
                                tab[idx++] = Tools.DoubleToString(input.Value, howManyDigitsShowAfterDotPlaces);
                            }
                            else
                            {
                                tab[idx++] = Tools.DoubleToString(input.Weight, howManyDigitsShowAfterDotPlaces);
                                tab[idx++] = Tools.DoubleToString(input.Value, howManyDigitsShowAfterDotPlaces);
                            }
                        }
                        else
                        {
                            tab[idx++] = "none";
                            tab[idx++] = "none";//"1";
                        }
                    }

                    tab[tab.Length -1] = Tools.DoubleToString(neuron.GetOutputValue(), howManyDigitsShowAfterDotPlaces);

                    dgvNeurons.Rows.Add(tab);
                }
            }

            if (selectedColumnIdx != -1 && selectedRowIdx != -1)
            {
                dgvNeurons[selectedColumnIdx, selectedRowIdx].Selected = true;
            } 
        }
        
        private void SetNamesEndEmptyValuesForTestData()
        {
            for (int row = 0; row < dgvTestData.RowCount; row++)
            {
                dgvTestData.Rows[row].Cells["lineNo"].Value = (row + 1);

                // needed to respect minimum width of cell when columns created
                for (int cell = 0; cell < dgvTestData.Rows[row].Cells.Count; cell++)
                {
                    
                    if (dgvTestData.Rows[row].Cells[cell].Value == null)
                    {
                        dgvTestData.Rows[row].Cells[cell].Value = "";
                    }
                }
            }
        }

        private void DgvNeurons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool wrongCell = false;
            if (dgvNeurons.Columns[e.ColumnIndex].Name.StartsWith("nWeight")) 
            {
                int inputNo = Int32.Parse(dgvNeurons.Columns[e.ColumnIndex].Name.Replace("nWeight", ""));

                try
                {
                    int layerNo = Int32.Parse(dgvNeurons.Rows[e.RowIndex].Cells["nLayerNo"].Value.ToString()) - 1;
                    int neuronNo = Int32.Parse(dgvNeurons.Rows[e.RowIndex].Cells["nNeuronNo"].Value.ToString()) - 1;
                    double inputValue = Double.Parse(dgvNeurons.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString().Replace(".", ","));
                    double weightValue = Double.Parse(dgvNeurons.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace(".", ","));

                    MainWindow.ucDialogChangeValueOfNeuron.SetControls(layerNo, neuronNo, inputNo, inputValue, weightValue, (int)nudDigits.Value);
                    MainWindow.ChangePage(MainWindow.ucDialogChangeValueOfNeuron.GetType());
                    
                }
                catch (Exception)
                {
                    wrongCell = true;
                }
            } else
            {
                wrongCell = true;
            }

            if (wrongCell)
                MessageBox.Show(this, "Are you sure it is a weight cell with value?", "Wrong cell?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void NotifyNeuronsWeightChange(int layerNo, int neuronNo, int inputNo, double newWeight)
        {
            Network.Topology.Layers[layerNo].Neurons[neuronNo].Inputs[inputNo].Weight = newWeight;
            Network.PropagateValuesForward(null, layerNo);
            RefreshDgvNeurons();
            MainWindow.ucDialogDgvNeuronsShow.SetControls(dgvNeurons, (int)nudDigits.Value);

            dgvNeurons.Focus();
            TestNetwork();
        }

        private void BShowLearnHistory_Click(object sender, EventArgs e)
        {
            if (Network.RmsErrorHistory.Count > 0)
            {
                MainWindow.ucDialogChart.SetData(Network.RmsErrorHistory);
                MainWindow.ChangePage(MainWindow.ucDialogChart.GetType());
            } else
            {
                MessageBox.Show(this, "There's no learning history so far.", "History is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TLearnFinished_Tick(object sender, EventArgs e)
        {
            tLearnFinished.Stop();
            lInfoLearnFinishedStopped.Visible = false;
        }

        private void BLearn_Click(object sender, EventArgs e)
        {
            // TODO: NEEDED: disable buttons when actions occurs in whole application
            // TODO: ERROR: Learning stops on set minimum error of whole network - check if this minimum is really minimum

            

            #region Learning
            lInfoLearning.Text = "Learning...";
            lInfoEpoch.Text = "Current epoch no.: 0";

            bLearn.Visible = false;
            bStopLearning.Visible = true;
            lInfoLearning.Visible = true;
            lInfoEpoch.Visible = true;

            // TODO: EVOLUTION: showing epoch no. while learing
            learningRatio = (double)nudRatio.Value;
            epochMax = (int)nudXDataTimes.Value;
            bLearnXTimes = rbLearnXTimes.Checked;
            bLearnUntilMinError = rbLearnUntilMinError.Checked;
            minimumError = (double)nudMinimumError.Value;
            bUsingDataInSequence = rbUsingDataInSequence.Checked;
            bUsingDataRandom = rbUsingDataRandom.Checked;
            bwRunning = true;
            bwLearning.RunWorkerAsync();
            
            if (cbShowCurrent.Checked)
            {
                tShowCurrentNetworkError.Start();
            }

            tShowEpochNo.Start();

            #endregion
        }
        private void BwLearning_DoWork(object sender, DoWorkEventArgs e)
        {
            epochNo = 0;
            int sampleNo = 0;
            bool errorGreater = true;
            Random random = new Random();

            bwError = null;

            while (((bLearnXTimes && epochNo < epochMax) ||
                   (bLearnUntilMinError && errorGreater)) 
                   && bwRunning)
            {
                LearnSample learnSample = null;

                if (bUsingDataRandom)
                {
                    sampleNo = random.Next(0, MainWindow.ucDialogLearningData.GetLearnSamples().Count);
                    learnSample = MainWindow.ucDialogLearningData.GetLearnSamples().ElementAt(sampleNo);
                }
                else if (rbUsingDataInSequence.Checked)
                {
                    learnSample = MainWindow.ucDialogLearningData.GetLearnSamples().ElementAt(sampleNo);
                }

                Network.Learn(learnSample, learningRatio, out string errorMessage);

                if (errorMessage != null)
                {
                    bwError = "Learning stopped in epoch no. " + (epochNo + 1) + " becouse of error: " + errorMessage;
                    break;
                }

                errorGreater = (Network.NetworkError > minimumError);

                epochNo++;

                if (bUsingDataInSequence)
                {
                    sampleNo++;
                    if (sampleNo == MainWindow.ucDialogLearningData.GetLearnSamples().Count) sampleNo = 0;
                }

                if (bLearnXTimes && epochNo % 100 == 0)
                {
                    bwLearning.ReportProgress((epochNo * 100) / epochMax);
                }
            }
        }

        private void BwLearning_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lInfoLearning.Text = "Learning: " + e.ProgressPercentage + "%";
        }

        private void BwLearning_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tShowCurrentNetworkError.Stop();
            tShowEpochNo.Stop();
            lInfoEpoch.Visible = false;

            if (bwError != null)
            {
                MessageBox.Show(this, bwError,
                        "Learning stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshDgvNeurons();
            TestNetwork();

            lInfoLearning.Visible = false;
            tLearnFinished.Start();
            lInfoLearnFinishedStopped.Text = (bwError != null || !bwRunning) ? "Learn stopped" : "Learn finished";
            lInfoLearnFinishedStopped.ForeColor = (bwError != null || !bwRunning) ? Color.IndianRed : Color.FromArgb(0, 180, 0);

            lInfoLearnFinishedStopped.Visible = true;
            ShowCurrentNetworkError();

            bLearn.Visible = true;
            bStopLearning.Visible = false;
            bStopLearning.Enabled = true;
        }

        private void ShowCurrentNetworkError()
        {
            if (Network.NetworkErrorSet)
            {
                tbCurrentNetworkError.Text = Tools.DoubleToString(Network.NetworkError, 6);
                int pbValue = (int)(Network.NetworkError * pbNetworkError.Maximum * 50); // * 50 to show better in progress bar
                pbNetworkError.Value = (pbValue < pbNetworkError.Maximum) ? pbValue : pbNetworkError.Maximum;
            } else
            {
                tbCurrentNetworkError.Text = "?";
                pbNetworkError.Value = 0;
            }
        }

        private void DgvTestData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetNamesEndEmptyValuesForTestData();
        }

        private void DgvTestData_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetNamesEndEmptyValuesForTestData();
        }

        private void DgvTestData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SetNamesEndEmptyValuesForTestData();
        }

        public void TestNetwork()
        {
            DoRefreshDgvNeurons = false;

            for (int rowNo = 0; rowNo < dgvTestData.RowCount - 1; rowNo++)
            {
                TestNetwork(rowNo, false);
            }

            DoRefreshDgvNeurons = true;
            RefreshDgvNeurons();
        }

        private void TestNetwork(int rowIdx, bool refreshDgvNeurons)
        {
            if (rowIdx == dgvTestData.RowCount - 1) return;

            List<double> inputList = new List<double>();

            bool ok = true;
            String errMsg = "";

            for (int col = 1; col < Network.Topology.GetInputCount(false) + 1; col++)
            {
                if (dgvTestData.Rows[rowIdx].Cells[col].Value != null && dgvTestData.Rows[rowIdx].Cells[col].Value != "")
                {
                    try
                    {
                        inputList.Add(Double.Parse(dgvTestData.Rows[rowIdx].Cells[col].Value.ToString()));
                    } catch (Exception)
                    {
                        ok = false;
                        if (errMsg == "") errMsg = "Error : wrong value(s).";
                    }
                }
                else
                {
                     ok = false;
                     if (errMsg == "") errMsg = "Error : empty values.";
                }
            }

            if (Network.Topology.IsNetworkUsingBiases)
            {
                inputList.Add(1);
            }

            if (!ok)
            {
                for (int col = 0; col < Network.Topology.OutputCount; col++)
                {
                    int shift = col * 2;
                    dgvTestData.Rows[rowIdx].Cells[col + Network.Topology.GetInputCount(false) + 1 + shift].Value = "error";
                    dgvTestData.Rows[rowIdx].Cells[col + Network.Topology.GetInputCount(false) + 2 + shift].Value = "error";
                    dgvTestData.Rows[rowIdx].Cells[col + Network.Topology.GetInputCount(false) + 3 + shift].Value = "error";
                }
            }
            else
            {
                for (int inputNo = 0; inputNo < inputList.Count; inputNo++)
                {
                    Network.Topology.Layers[0].Neurons[inputNo].Inputs[0].Value = inputList[inputNo];
                }

                Network.PropagateValuesForward();

                double[]  expectedOutputs = CheckExpectedOutputs(rowIdx);

                for (int outputNo = 0; outputNo < Network.Topology.OutputCount; outputNo++)
                {
                    int shift = outputNo * 2 + 1;
                    double outputValue = Network.Topology.Layers.Last().Neurons[outputNo].GetOutputValue();

                    dgvTestData.Rows[rowIdx].Cells[outputNo + Network.Topology.GetInputCount(false) + 1 + shift].Value = 
                        Tools.DoubleToString(outputValue, howManyDigitsShowAfterDotPlaces);

                    if (expectedOutputs != null)
                    {
                        dgvTestData.Rows[rowIdx].Cells[Network.Topology.GetInputCount(false) + 1].Value = 
                            Tools.DoubleToString(
                                Calculations.RMSError(expectedOutputs, Network.Topology.NetworkOutputValues()), 
                                howManyDigitsShowAfterDotPlaces
                            );
                        dgvTestData.Rows[rowIdx].Cells[outputNo + Network.Topology.GetInputCount(false) + 2 + shift].Value = Tools.DoubleToString(expectedOutputs[outputNo], howManyDigitsShowAfterDotPlaces);
                        dgvTestData.Rows[rowIdx].Cells[outputNo + Network.Topology.GetInputCount(false) + 3 + shift].Value = Tools.DoubleToString(expectedOutputs[outputNo] - outputValue, howManyDigitsShowAfterDotPlaces);
                    }
                    else
                    {
                        dgvTestData.Rows[rowIdx].Cells[Network.Topology.GetInputCount(false) + 1].Value = "?";
                        dgvTestData.Rows[rowIdx].Cells[outputNo + Network.Topology.GetInputCount(false) + 2 + shift].Value = "?";
                        dgvTestData.Rows[rowIdx].Cells[outputNo + Network.Topology.GetInputCount(false) + 3 + shift].Value = "?";
                    }
                }

                if(refreshDgvNeurons) RefreshDgvNeurons();
            }
        }

        private void DgvTestData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TestNetwork(e.RowIndex, true);
        }

        private void BCopyFromLearnData_Click(object sender, EventArgs e)
        {
            DoRefreshDgvNeurons = false;

            int learningQuantity = MainWindow.ucDialogLearningData.GetLearnSamples().Count;

            if (learningQuantity == 0)
            {
                MessageBox.Show(this, 
                    "There is nothing to copy, because learn data is empty", 
                    "Learn data empty", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                DoRefreshDgvNeurons = true;

                return;
            } else  if (learningQuantity > 50)
            {
                if (MessageBox.Show(this,
                        "Quantity of learning data is " + learningQuantity + ". Are you sure you want to write all this data to gird?",
                        "A lot of learning data", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    DoRefreshDgvNeurons = true;
                    return;
                }
            }

            foreach(LearnSample learnSample in MainWindow.ucDialogLearningData.GetLearnSamples())
            {
                String[] tab = new String[Network.Topology.GetInputCount(false) + 1];

                for (int inputNo = 0; inputNo < Network.Topology.GetInputCount(false); inputNo++)
                {
                    tab[inputNo + 1] = learnSample.InputData[inputNo].ToString();
                    /*tab[inputNo + 1] = dgvLearningData.Rows[learnDataNo].Cells[inputNo + 1].Value == null ?
                        "" :
                        dgvLearningData.Rows[learnDataNo].Cells[inputNo + 1].Value.ToString();*/
                }

                dgvTestData.Rows.Add(tab);
                TestNetwork(dgvTestData.Rows.Count - 1, false);
            }

            SetNamesEndEmptyValuesForTestData();
            DoRefreshDgvNeurons = true;
            RefreshDgvNeurons();

            /*
            if (dgvLearningData.Rows.Count - 1 == 0)
            {
                MessageBox.Show(this, "There is nothing to copy, because learn data is empty", "Learn data empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DoRefreshDgvNeurons = false;

            int TestRowsAlready = dgvTestData.Rows.Count;

            for (int learnDataNo = 0; learnDataNo < dgvLearningData.Rows.Count - 1; learnDataNo++)
            {
                String[] tab = new String[Network.Topology.GetInputCount(false) + 1];

                for (int inputNo = 0; inputNo < Network.Topology.GetInputCount(false); inputNo++)
                {
                    tab[inputNo + 1] = dgvLearningData.Rows[learnDataNo].Cells[inputNo + 1].Value == null ? 
                        "" : 
                        dgvLearningData.Rows[learnDataNo].Cells[inputNo + 1].Value.ToString();
                }

                dgvTestData.Rows.Add(tab);
                TestNetwork(dgvTestData.Rows.Count - 1, false);
            }

            SetNamesEndEmptyValuesForTestData();
            DoRefreshDgvNeurons = true;
            RefreshDgvNeurons();*/
        }

        public void SetColumnsDgvNeurons()
        {
            #region Find maximum input's neuron
            int maxIputPerNeuron = -1;

            
            for (int layerNo = 1; layerNo < Network.Topology.Layers.Count; layerNo++)
            {
                if (Network.Topology.Layers[layerNo].Neurons[0].Inputs.Count > maxIputPerNeuron)
                    maxIputPerNeuron = Network.Topology.Layers[layerNo].Neurons[0].Inputs.Count;

                /*
                for (int neuronNo = 0; neuronNo < Network.Topology.Layers[layerNo].Neurons.Count; neuronNo++)
                {
                    int inputsCnt = Network.Topology.Layers[layerNo].Neurons[neuronNo].Inputs.Count;
                    if (inputsCnt > maxIputPerNeuron) maxIputPerNeuron = inputsCnt;
                }*/
            }
            #endregion

            #region Creating columns
            dgvNeurons.Columns.Clear();

            // TODO: EVOLUTION: show output column before inputs and values - maybe option with checkbox?
            dgvNeurons.Columns.Add("nLayerNo", "Layer no.");
            dgvNeurons.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNeurons.Columns[0].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            dgvNeurons.Columns.Add("nNeuronNo", "Neuron no.");
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            dgvNeurons.Columns.Add("nIsBias", "Is bias?");
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            dgvNeurons.Columns.Add("nActivationFunction", "Act. function");
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;

            for (int inputNo = 0; inputNo < maxIputPerNeuron; inputNo++)
            {
                dgvNeurons.Columns.Add("nWeight" + inputNo, "Weight " + (inputNo + 1));
                dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.BackColor = Color.MistyRose;

                dgvNeurons.Columns.Add("nInput" + inputNo, "Input " + (inputNo + 1));
                dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.BackColor = Color.SeaShell;
            }

            dgvNeurons.Columns.Add("nOutput", "Output");
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNeurons.Columns[dgvNeurons.ColumnCount - 1].DefaultCellStyle.BackColor = Color.OldLace;
            
            for (int columnNo = 0; columnNo < dgvNeurons.ColumnCount; columnNo++)
            {
                dgvNeurons.Columns[columnNo].ReadOnly = true;
            }
            #endregion
        }

        private void DgvNeurons_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvNeurons.SelectedCells.Count > 0 && e.KeyCode == Keys.Enter)
            {
                DgvNeurons_CellDoubleClick(
                    null,
                    new DataGridViewCellEventArgs(dgvNeurons.SelectedCells[0].ColumnIndex, dgvNeurons.SelectedCells[0].RowIndex)
                );
                
            }
            else if (e.KeyCode == Keys.F12)
            {
                gbNeurons.Height += F11_F12_SIZE_CHANGED;
                pContent.Height += F11_F12_SIZE_CHANGED;
                gbTest.Location = new Point(gbTest.Location.X, gbTest.Location.Y + F11_F12_SIZE_CHANGED);
            }
            else if (e.KeyCode == Keys.F11 && gbNeurons.Size.Height > 250)
            {
                gbNeurons.Height -= F11_F12_SIZE_CHANGED;
                pContent.Height -= F11_F12_SIZE_CHANGED;
                gbTest.Location = new Point(gbTest.Location.X, gbTest.Location.Y - F11_F12_SIZE_CHANGED);
            }
        }

        private void PContent_SizeChanged(object sender, EventArgs e)
        {
            pContent.Invalidate();
            this.AdjustFormScrollbars(true);
        }

        private void DgvLearningData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                gbLearingData.Height += F11_F12_SIZE_CHANGED;
                pContent.Height += F11_F12_SIZE_CHANGED;
            }
            else if (e.KeyCode == Keys.F11 && gbLearingData.Size.Height > 250)
            {
                gbLearingData.Height -= F11_F12_SIZE_CHANGED;
                pContent.Height -= F11_F12_SIZE_CHANGED;
            }
        }

        private void DgvTestData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                gbTest.Height += F11_F12_SIZE_CHANGED;
                pContent.Height += F11_F12_SIZE_CHANGED;
            }
            else if (e.KeyCode == Keys.F11 && gbTest.Size.Height > 250)
            {
                gbTest.Height -= F11_F12_SIZE_CHANGED;
                pContent.Height -= F11_F12_SIZE_CHANGED;
            }
        }

        private void NudDigits_ValueChanged(object sender, EventArgs e)
        {
            howManyDigitsShowAfterDotPlaces = (int)nudDigits.Value;
            RefreshDgvNeurons();

            for (int row = 0; row < dgvTestData.Rows.Count - 1; row++)
            {
                TestNetwork(row, true);
            }

            ShowCurrentNetworkError();
        }

        private double[] CheckExpectedOutputs(int testRowIdx)
        {
            double[] outputTab = new double[Network.Topology.OutputCount];

            bool fit = true;
            int learnNoFit = -1;

            for (int learningNo = 0; learningNo < MainWindow.ucDialogLearningData.GetLearnSamples().Count; learningNo++)
            {
                fit = true;

                for (int inputNo = 0; inputNo < Network.Topology.GetInputCount(false); inputNo++)
                {
                    if (Double.Parse(dgvTestData.Rows[testRowIdx].Cells["in" + inputNo].Value.ToString()) !=
                        MainWindow.ucDialogLearningData.GetLearnSamples()[learningNo].InputData[inputNo])
                    {
                        fit = false;
                        break;
                    }
                }

                if (fit)
                {
                    learnNoFit = learningNo;
                    break;
                }
            }            

            if (learnNoFit != -1)
            {
                for (int outputNo = 0; outputNo < outputTab.Length; outputNo++)
                {
                    outputTab[outputNo] = MainWindow.ucDialogLearningData.GetLearnSamples()[learnNoFit].OutputData[outputNo];
                }
            }
            else
            {
                return null;
            }

            return outputTab;
        }

        private void BEnlargeTableNeurons_Click(object sender, EventArgs e)
        {
            MainWindow.ucDialogDgvNeuronsShow.SetControls(dgvNeurons, (int) nudDigits.Value);
            MainWindow.ChangePage(MainWindow.ucDialogDgvNeuronsShow.GetType());
        }

        private void DgvNeurons_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvNeurons.SelectedCells.Count > 0 && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void BShowGraph_Click(object sender, EventArgs e)
        {
            MainWindow.NotImplementedMessage();
        }

        private void BShowCurrent_Click(object sender, EventArgs e)
        {
            ShowCurrentNetworkError();
        }

        private void BStopLearning_Click(object sender, EventArgs e)
        {
            // EVOLUTION: on stop button notify about changing in network and ask about restore network before learning process.
            bwRunning = false;
            bStopLearning.Enabled = false;
        }

        private void TShowCurrentNetworkError_Tick(object sender, EventArgs e)
        {
            ShowCurrentNetworkError();
        }

        private void BEnlargeTableTest_Click(object sender, EventArgs e)
        {
            // TODO: !IMPLEMENTED: show test dgv in new window with functionality
            MainWindow.NotImplementedMessage();
            MainWindow.ucDialogDgvNeuronsShow.SetControls(dgvTestData, (int)nudDigits.Value);
            MainWindow.ChangePage(MainWindow.ucDialogDgvNeuronsShow.GetType());
        }

        private void CbShowCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (bwRunning && cbShowCurrent.Checked)
            {
                tShowCurrentNetworkError.Start();
            }
            else
            {
                tShowCurrentNetworkError.Stop();
            }
        }

        private void CbSaveWithoutHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbSaveWithoutHistory.Checked)
            {
                if (MessageBox.Show(
                    this, 
                    "Saving networ with huge history may fail due to the large amount of data. Do you want to keep saving history?", 
                    "Saving history?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    cbSaveWithoutHistory.Checked = true;
                }
            }
        }

        private void TShowEpochNo_Tick(object sender, EventArgs e)
        {
            String epoch = epochNo.ToString();

            lInfoEpoch.Text = "Current epoch no.: " + epoch;
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            dgvTestData.Rows.Clear();
        }
    }
}
