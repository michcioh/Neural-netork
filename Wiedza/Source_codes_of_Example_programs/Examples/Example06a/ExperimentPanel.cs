using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example06a
{
    public enum NeuronType { Unipolar, Bipolar };

    public partial class ExperimentPanel : WizardPanel
    {
        private Neuron _examinedNeuron;

        private double[] _inputSignals;

        private NeuronType _neuronType;

        public ExperimentPanel(int inputCount, NeuronType neuronType)
        {
            InitializeComponent();
            _neuronType = neuronType;
            switch (neuronType)
            {
                case NeuronType.Unipolar:
                    _examinedNeuron = new UnipolarNeuron(inputCount);
                    uiNeuronType.Text = "Neuron type: unipolar";
                    break;
                case NeuronType.Bipolar:
                    _examinedNeuron = new BipolarNeuron(inputCount);
                    uiNeuronType.Text = "Neuron type: bipolar";
                    break;
            }
            _inputSignals = new double[inputCount];
            uiNeuronParams.RowCount = inputCount;
            UpdateResults();
        }

        private void UpdateResults()
        {
            double signalStrength =
                Neuron.Strength(_inputSignals, StrengthNorm.Euclidean);
            double memStrength = 
                _examinedNeuron.MemoryTraceStrength(StrengthNorm.Euclidean);
            double response = _examinedNeuron.Response(_inputSignals);

            uiSignalStrength.Text = signalStrength.ToString();
            uiMemStrength.Text = memStrength.ToString();
            uiResponse.Text = response.ToString();
        }

        /* Jeœli u¿ywasz Visual Studio, mo¿esz ukryæ mniej istotne czêœci kodu,
         * klikaj¹c ikonê "-" po lewej stronie poni¿szej linii. */
        #region GUI-related stuff

        public override bool IsFirst
        {
            get { return false; }
        }

        public override WizardPanel GetPrevious()
        {
            return new SetUpPanel(_examinedNeuron.Weights.Length, _neuronType);
        }

        private void uiNeuronParams_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Value = e.RowIndex+1;
                    break;
                case 1:
                    e.Value = _examinedNeuron.Weights[e.RowIndex];
                    break;
                case 2:
                    e.Value = _inputSignals[e.RowIndex];
                    break;
            }
        }

        private void uiNeuronParams_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    _examinedNeuron.Weights[e.RowIndex] =
                        double.Parse(e.Value as string);
                    UpdateResults();
                    break;
                case 2:
                    _inputSignals[e.RowIndex] =
                        double.Parse(e.Value as string);
                    UpdateResults();
                    break;
            }
        }

        private void uiNeuronParams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uiNeuronParams.BeginEdit(true);
        }

        #endregion
    }
}

