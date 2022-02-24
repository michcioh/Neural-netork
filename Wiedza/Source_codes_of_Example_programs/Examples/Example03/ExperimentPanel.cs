using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;
using DataGridViewNumericUpDownElements;

namespace RTadeusiewicz.NN.Example03
{
    public partial class ExperimentPanel : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;

        private double[] _inputSignals;

        internal ExperimentPanel(ProgramLogic programLogic)
        {
            _programLogic = programLogic;
            _inputSignals = new double[_programLogic.ExaminedNeuron.Weights.Length];
            InitializeComponent();
            BuildGrids();
            /* We don't call PerformExperiment() here; it will be called by the
             * uiKnownObjects_SelectionChanged event handler. */
        }

        private void PerformExperiment()
        {
            double response = _programLogic.PerformExperiment(_inputSignals);
            uiResponse.Text = response.ToString("g8");
        }

        private void BuildGrids()
        {
            BuildKnownObjectsGrid();
            BuildInputDataGrid();
        }

        private void BuildKnownObjectsGrid()
        {
            int inCount = _programLogic.ExaminedNeuron.Weights.Length;
            for (int i = 0; i < inCount; i++)
                uiKnownObjects.Columns.Add("", String.Format("x({0})", i + 1));
            uiKnownObjects.Columns.Add("", "Output");
            foreach (DataGridViewColumn col in uiKnownObjects.Columns)
                col.MinimumWidth = 50;
            uiKnownObjects.Columns.Add("", "Comment");
            object[] values = new object[inCount+2];
            foreach (TeachingSet.Element elem in _programLogic.TeachingSet)
            {
                for (int i = 0; i < elem.Inputs.Length; i++)
                    values[i] = elem.Inputs[i];
                values[inCount] = elem.ExpectedOutputs[0];
                values[inCount+1] = elem.Comment;
                uiKnownObjects.Rows.Add(values);
            }
        }

        private void BuildInputDataGrid()
        {
            double[] neuronWeights = _programLogic.ExaminedNeuron.Weights;
            int colCount = neuronWeights.Length + 1;
            for (int i = 0; i < colCount; i++)
                uiInputData.Columns.Add("", "");
            foreach (DataGridViewColumn col in uiInputData.Columns)
                col.MinimumWidth = 60;
            DataGridViewColumn firstColumn = uiInputData.Columns[0];
            firstColumn.ReadOnly = true;
            DataGridViewCellStyle firstColumnStyle = firstColumn.DefaultCellStyle;
            firstColumnStyle.BackColor = firstColumnStyle.SelectionBackColor =
                SystemColors.Control;
            firstColumnStyle.ForeColor = firstColumnStyle.SelectionForeColor =
                SystemColors.ControlText;
            uiInputData.Rows.Add(3);
            uiInputData.Rows[0].Cells[0].Value = "Input number (i)";
            uiInputData.Rows[1].Cells[0].Value = "Input weight (w(i))";
            uiInputData.Rows[2].Cells[0].Value = "Input signal (x(i))";
            uiInputData.Rows[0].ReadOnly = true;
            uiInputData.Rows[1].ReadOnly = true;
            for (int i = 0; i < neuronWeights.Length; i++)
            {
                uiInputData.Rows[0].Cells[i + 1].Value = i + 1;
                uiInputData.Rows[1].Cells[i + 1].Value = neuronWeights[i];
                uiInputData.Rows[1].Cells[i + 1].Style.Format = "+0.000;-0.000";
                DataGridViewNumericUpDownCell inputCell =
                    new DataGridViewNumericUpDownCell();
                inputCell.Minimum = -10m;
                inputCell.Maximum = 10m;
                inputCell.Increment = 0.1m;
                inputCell.DecimalPlaces = 1;
                inputCell.Value = 0.0m;
                inputCell.ReadOnly = false;
                uiInputData.Rows[2].Cells[i + 1] = inputCell;
            }
        }

        public override bool IsFirst
        {
            get { return false; }
        }

        public override WizardPanel GetPrevious()
        {
            return new TeachingPanel(_programLogic);
        }

        private void uiKnownObjects_SelectionChanged(object sender, EventArgs e)
        {
            TeachingSet.Element elementSelected =
                _programLogic.TeachingSet[uiKnownObjects.CurrentRow.Index];
            for (int i = 0; i < _programLogic.ExaminedNeuron.Weights.Length; i++)
            {
                double val = elementSelected.Inputs[i];
                _inputSignals[i] = val;
                uiInputData.Rows[2].Cells[i + 1].Value = val.ToString();
            }
        }

        private void uiInputData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.RowIndex != 2)
                return;
            DataGridViewCell cell = uiInputData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            _inputSignals[e.ColumnIndex - 1] =
                double.Parse(cell.Value as string);
            PerformExperiment();
        }

    }
}

