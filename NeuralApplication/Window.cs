using NeuralNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural
{
    public partial class Window : Form
    {
        private NeuralNetwork actualNetwork;
        FileInfo fiOpenFile;

        public Window()
        {
            InitializeComponent();

            ChangePage(ucMain.GetType());
        }

        public void ChangePage(Type typ)
        {
            if (!IsDialogPage(typ))
            {
                HidePages();
            }

            if (typ.Name.Equals(ucMain.GetType().Name))
            {
                ucMain.Visible = true;
                ucMain.BringToFront();
            }
            else if (typ.Name.Equals(ucCreateNetwork.GetType().Name))
            {
                ucCreateNetwork.Visible = true;
                ucCreateNetwork.BringToFront();
                ucCreateNetwork.MainWindow = this;
            }
            else if (typ.Name.Equals(ucDialogResetNetwork.GetType().Name))
            {
                ucDialogResetNetwork.Visible = true;
                ucDialogResetNetwork.BringToFront();
                ucDialogResetNetwork.MainWindow = this;
                ucDialogResetNetwork.ControlActivation();
            }
            else if (typ.Name.Equals(ucDialogDgvNeuronsShow.GetType().Name))
            {
                ucDialogDgvNeuronsShow.Visible = true;
                ucDialogDgvNeuronsShow.BringToFront();
                ucDialogDgvNeuronsShow.MainWindow = this;
            }
            else if (typ.Name.Equals(ucDialogChangeValueOfNeuron.GetType().Name))
            {
                ucDialogChangeValueOfNeuron.Visible = true;
                ucDialogChangeValueOfNeuron.BringToFront();
                ucDialogChangeValueOfNeuron.MainWindow = this;
                ucDialogChangeValueOfNeuron.OnActivation();
            }
            else if (typ.Name.Equals(ucDialogChart.GetType().Name))
            {
                ucDialogChart.Visible = true;
                ucDialogChart.BringToFront();
                ucDialogChart.MainWindow = this;
                ucDialogChart.OnActivation();
            }
            else if (typ.Name.Equals(ucNetworkDetails.GetType().Name))
            {
                ucNetworkDetails.Visible = true;
                ucNetworkDetails.BringToFront();
                ucNetworkDetails.MainWindow = this;
                ucNetworkDetails.SetNetwork(actualNetwork);
            }
            else if (typ.Name.Equals(ucDialogDataLearningConverter.GetType().Name))
            {
                ucDialogDataLearningConverter.Visible = true;
                ucDialogDataLearningConverter.BringToFront();
                ucDialogDataLearningConverter.MainWindow = this;
                ucDialogDataLearningConverter.OnActivation();
            }
            else if (typ.Name.Equals(ucDialogLearningData.GetType().Name))
            {
                ucDialogLearningData.Visible = true;
                ucDialogLearningData.BringToFront();
                ucDialogLearningData.MainWindow = this;
            }
        }

        private bool IsDialogPage(Type typ)
        {
            if (typ.Name.Equals(ucCreateNetwork.GetType().Name) ||
                typ.Name.Equals(ucDialogResetNetwork.GetType().Name) ||
                typ.Name.Equals(ucDialogDgvNeuronsShow.GetType().Name) ||
                typ.Name.Equals(ucDialogChangeValueOfNeuron.GetType().Name) ||
                typ.Name.Equals(ucDialogChart.GetType().Name) ||
                typ.Name.Equals(ucDialogDataLearningConverter.GetType().Name) ||
                typ.Name.Equals(ucDialogLearningData.GetType().Name)
            ) return true;

            return false;
        }

        private void HidePages()
        {
            ucMain.Visible = false;
            ucCreateNetwork.Visible = false;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actualNetwork != null)
            {
                if (MessageBox.Show(this, "When you confirm to create new network, actual network will be closed without saving. " +
                    "Do you wish to save actual network?", "Saving actual network?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    SaveAsToolStripMenuItem_Click(null, null);
                }
            }

            ChangePage(ucCreateNetwork.GetType());
            ucCreateNetwork.ControlActivation(null);
        }

        public void SetActualNetworkFromNetworkDetails()
        {
            this.actualNetwork = ucNetworkDetails.GetNetwork();
        }

        public void NotifyNetworkCreated(NeuralNetwork network)
        {
            this.actualNetwork = network;
            ChangePage(ucNetworkDetails.GetType());
            fiOpenFile = null;
            SetMenu(true);
        }

        public void NotifyPercentageChanged(int percentage)
        {
            this.Text = "Learning " + percentage+"%";
        }

        public void NotifyLearningEnds()
        {
            this.Text = "Neural network";
        }

        public void NotifyNetworkClosed()
        {
            this.actualNetwork = null;
            ChangePage(ucMain.GetType());
            SetMenu(false);
            fiOpenFile = null;
        }

        public void SetMenu(bool isActiveNetwork)
        {
            saveToolStripMenuItem.Enabled = isActiveNetwork;
            saveAsToolStripMenuItem.Enabled = isActiveNetwork;
            editActiveNetworkToolStripMenuItem.Enabled = isActiveNetwork;
        }

        public void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualNetworkFromNetworkDetails();

            if (fiOpenFile != null)
            {
                sfdSave.InitialDirectory = fiOpenFile.Directory.FullName;
                sfdSave.FileName = fiOpenFile.Name;
            }
            else
            {
                sfdSave.FileName = actualNetwork.Name;
            }

            if (sfdSave.ShowDialog(this) == DialogResult.OK)
            {
                fiOpenFile = new FileInfo(sfdSave.FileName);
                try
                {
                    DoSerializableNetwork(fiOpenFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualNetworkFromNetworkDetails();

            if (fiOpenFile != null && ofdOpen.FileName != "")
            {
                fiOpenFile = new FileInfo(ofdOpen.FileName);
                try
                {
                    DoSerializableNetwork(fiOpenFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SaveAsToolStripMenuItem_Click(null, null);
            }
        }
        
        private void DoSerializableNetwork(FileInfo fiFile)
        {
            NeuralNetwork copy = (NeuralNetwork)actualNetwork.Clone();

            if (ucNetworkDetails.cbSaveWithoutHistory.Checked)
            {
                copy.EpochHistory.Clear();
            }

            if (ucNetworkDetails.cbSaveWithoutAnyHistory.Checked)
            {
                copy.RmsErrorHistory.Clear();
            }

            Tools.SerializeObject(copy, fiOpenFile.FullName);
            ucNetworkDetails.SavedOk();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: ERROR: Something is wrong when opened network is bigger (I don't think smaller) then current (for example when learn data are provided)
            if (actualNetwork != null)
            {
                if (MessageBox.Show(this, "When you open new network, actual network will be closed without saving. Do you wish to continue?", "Without saving?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }
            }

            if (ofdOpen.ShowDialog(this) == DialogResult.OK)
            {
                fiOpenFile = new FileInfo(ofdOpen.FileName);
                try
                {
                    actualNetwork = Tools.DeSerializeObject<NeuralNetwork>(fiOpenFile.FullName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SetMenu(true);

                ChangePage(ucNetworkDetails.GetType());
            }
        }

        private void ShowActualNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePage(ucNetworkDetails.GetType());
        }

        private void EditActiveNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePage(ucDialogResetNetwork.GetType());
        }

        public void NotImplementedMessage()
        {
            MessageBox.Show(this, "Sooooorry not implemented yet or it's implementation is not finished!", "oyoyoyoyo... y!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Close application?", "End of work?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ConvertCsvFileToDataLearningFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePage(ucDialogDataLearningConverter.GetType());
        }
    }
}