using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example03
{
    public partial class TeachingPanel : RTadeusiewicz.NN.Controls.WizardPanel
    {
        internal TeachingPanel(ProgramLogic programLogic)
        {
            InitializeComponent();
            _programLogic = programLogic;
            PerformTeaching();
        }

        private ProgramLogic _programLogic;

        private HistoryWindow _historyWindow;

        private void PerformTeaching()
        {
            _programLogic.PerformTeaching((double)uiTeachingRatio.Value);
            ShowResults();
        }

        private void ShowResults()
        {
            TeachingSet.Element currentElement = _programLogic.CurrentElement;
            uiStepNumber.Text =
                String.Format("Step: {0}", _programLogic.TeachingStep);
            uiComment.Text =
                String.Format("Comment: {0}", currentElement.Comment);
            if (uiDataBefore.ColumnCount == 0)
                BuildGrids();
            PutNumbers(currentElement.Inputs, uiDataBefore.Rows[1]);
            PutNumbers(_programLogic.CurrentNormalizedInputs, uiDataBefore.Rows[2]);
            PutNumbers(_programLogic.PreviousWeights, uiDataBefore.Rows[3]);
            uiOutputBefore.Text = _programLogic.PreviousResponse.ToString("g6");
            uiCorrectBefore.Text = currentElement.ExpectedOutputs[0].ToString("g6");
            uiErrorBefore.Text = _programLogic.PreviousError.ToString("g6");

            PutNumbers(_programLogic.ExaminedNeuron.Weights, uiDataAfter.Rows[1]);
            uiOutputAfter.Text = _programLogic.CurrentResponse.ToString("g6");
            uiCorrectAfter.Text = currentElement.ExpectedOutputs[0].ToString("g6");
            uiErrorAfter.Text = _programLogic.CurrentError.ToString("g6");
        }

        private void PutNumbers(double[] numbers, DataGridViewRow row)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                DataGridViewCell cell = row.Cells[i + 1];
                cell.Value = numbers[i];
                cell.Style.Format = "+0.000;-0.000";
            }
        }

        private void BuildGridColumns(DataGridView control)
        {
            int colCount = _programLogic.ExaminedNeuron.Weights.Length + 1;
            for (int i = 0; i < colCount; i++)
                control.Columns.Add("", "");
            foreach (DataGridViewColumn col in control.Columns)
                col.MinimumWidth = 60;
            DataGridViewCellStyle firstColumnStyle =
                control.Columns[0].DefaultCellStyle;
            firstColumnStyle.BackColor = firstColumnStyle.SelectionBackColor =
                SystemColors.Control;
            firstColumnStyle.ForeColor = firstColumnStyle.SelectionForeColor =
                SystemColors.ControlText;
            control.Rows.Add(1);
            control.Rows[0].Cells[0].Value = "Input number (i)";
        }

        private void BuildGrids()
        {
            BuildGridColumns(uiDataBefore);
            uiDataBefore.Rows.Add(3);
            uiDataBefore.Rows[1].Cells[0].Value = "Original inputs (u(i))";
            uiDataBefore.Rows[2].Cells[0].Value = "Normalized inputs (x(i))";
            uiDataBefore.Rows[3].Cells[0].Value = "Weights (w(i))";
            BuildGridColumns(uiDataAfter);
            uiDataAfter.Rows.Add(1);
            uiDataAfter.Rows[1].Cells[0].Value = "Weights (w(i))";
            for (int i = 1; i <= _programLogic.ExaminedNeuron.Weights.Length; i++)
            {
                uiDataBefore.Rows[0].Cells[i].Value = i;
                uiDataAfter.Rows[0].Cells[i].Value = i;
            }

            DataGridViewColumn firstCol1 = uiDataBefore.Columns[0];
            DataGridViewColumn firstCol2 = uiDataAfter.Columns[0];
            int width1 = firstCol1.GetPreferredWidth(
                DataGridViewAutoSizeColumnMode.AllCells, true);
            int width2 = firstCol2.GetPreferredWidth(
                DataGridViewAutoSizeColumnMode.AllCells, true);
            int maxWidth = Math.Max(width1, width2);
            firstCol1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firstCol2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            firstCol1.Width = maxWidth;
            firstCol2.Width = maxWidth;
        }

        public override bool IsFirst
        {
            get { return false; }
        }

        public override WizardPanel GetPrevious()
        {
            if (_historyWindow != null)
                _historyWindow.Dispose();
            return new SetUpPanel(_programLogic);
        }

        public override bool IsLast
        {
            get { return false; }
        }

        public override WizardPanel GetNext()
        {
            if (_historyWindow != null)
                _historyWindow.Dispose();
            return new ExperimentPanel(_programLogic);
        }

        private void uiTeachMore_Click(object sender, EventArgs e)
        {
            PerformTeaching();
        }

        private void uiReset_Click(object sender, EventArgs e)
        {
            _programLogic.InitializeTeaching();
            PerformTeaching();
        }

        private void uiShowHistory_Click(object sender, EventArgs e)
        {
            if (_historyWindow == null)
            {
                _historyWindow = new HistoryWindow(_programLogic.ProgressHistory);
                _historyWindow.Disposed += new EventHandler(_historyWindow_Disposed);
                _historyWindow.Show(this.FindForm());
            }
        }

        void _historyWindow_Disposed(object sender, EventArgs e)
        {
            _historyWindow = null;
        }

    }
}

