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

namespace RTadeusiewicz.NN.Example06b
{
    public partial class ExperimentPanel : RTadeusiewicz.NN.Controls.WizardPanel
    {
        private ProgramLogic _programLogic;

        private double[] _inputSignals;

        internal ExperimentPanel(ProgramLogic programLogic)
        {
            _programLogic = programLogic;
            _inputSignals = new double[_programLogic.ExaminedNetwork.InputCount];
            InitializeComponent();
            BuildGrids();
            /* We don't call PerformExperiment() here; it will be called by the
             * uiKnownObjects_SelectionChanged event handler. */
        }

        private void PerformExperiment()
        {
            double[] response = _programLogic.PerformExperiment(_inputSignals);
            for (int i = 0; i < response.Length; i++)
                uiOutputData.Rows[0].Cells[i].Value = response[i];
        }

        private void BuildGrids()
        {
            BuildKnownObjectsGrid();
            BuildInputDataGrid();
            BuildOutputDataGrid();
        }

        private void BuildKnownObjectsGrid()
        {
            int inCount = _programLogic.ExaminedNetwork.InputCount;
            int outCount = _programLogic.ExaminedNetwork.OutputCount;
            for (int i = 0; i < inCount; i++)
                uiKnownObjects.Columns.Add("", String.Format("x({0})", i + 1));
            for (int i = 0; i < outCount; i++)
                uiKnownObjects.Columns.Add("", String.Format("y({0})", i + 1));
            foreach (DataGridViewColumn col in uiKnownObjects.Columns)
                col.MinimumWidth = 50;
            uiKnownObjects.Columns.Add("", "Comment");
            object[] values = new object[inCount + outCount + 1];
            foreach (TeachingSet.Element elem in _programLogic.TeachingSet)
            {
                for (int i = 0; i < inCount; i++)
                    values[i] = elem.Inputs[i];
                for (int i = 0; i < outCount; i++)
                    values[inCount + i] = elem.ExpectedOutputs[i];
                values[values.Length - 1] = elem.Comment;
                uiKnownObjects.Rows.Add(values);
            }
        }

        private void BuildInputDataGrid()
        {
            int inCount = _programLogic.ExaminedNetwork.InputCount;
            for (int i = 0; i < inCount; i++)
            {
                DataGridViewNumericUpDownColumn col =
                    new DataGridViewNumericUpDownColumn();
                col.HeaderText = String.Format("x({0})", i + 1);
                uiInputData.Columns.Add(col);
                col.MinimumWidth = 60;
                col.Minimum = -10m;
                col.Maximum = 10m;
                col.Increment = 0.1m;
                col.DecimalPlaces = 1;
            }
            uiInputData.Rows.Add();
        }

        private void BuildOutputDataGrid()
        {
            int outCount = _programLogic.ExaminedNetwork.OutputCount;
            for (int i = 0; i < outCount; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = String.Format("y({0})", i + 1);
                col.DefaultCellStyle.Format = "+0.000;-0.000";
                uiOutputData.Columns.Add(col);
            }
            uiOutputData.Rows.Add();
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
            for (int i = 0; i < _programLogic.ExaminedNetwork.InputCount; i++)
            {
                double val = elementSelected.Inputs[i];
                _inputSignals[i] = val;
                uiInputData.Rows[0].Cells[i].Value = val.ToString();
            }
        }

        private void uiInputData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = uiInputData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            _inputSignals[e.ColumnIndex] =
                double.Parse(cell.Value as string);
            PerformExperiment();
        }

    }
}

