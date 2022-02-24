using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example06b
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
            TeachingSet.Element currentNormalizedElement =
                _programLogic.CurrentNormalizedElement;

            uiStepNumber.Text =
                String.Format("Step: {0}", _programLogic.TeachingStep);
            uiComment.Text =
                String.Format("Comment: {0}", currentElement.Comment);
            if (uiInputData.ColumnCount == 0)
                BuildGrids();
            PutNumbers(currentElement.Inputs, uiInputData.Rows[1]);
            PutNumbers(currentNormalizedElement.Inputs, uiInputData.Rows[2]);
            
            PutNumbers(_programLogic.PreviousResponse, uiTeachingProgress.Rows[1]);
            PutNumbers(currentElement.ExpectedOutputs, uiTeachingProgress.Rows[2]);
            PutNumbers(_programLogic.PreviousError, uiTeachingProgress.Rows[3]);
            PutNumbers(_programLogic.CurrentResponse, uiTeachingProgress.Rows[4]);
            PutNumbers(_programLogic.CurrentError, uiTeachingProgress.Rows[5]);
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

        private void BuildGridColumns(DataGridView control, int columnCount)
        {
            for (int i = 0; i < columnCount; i++)
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
            for (int i = 1; i < columnCount; i++)
                control.Rows[0].Cells[i].Value = i;
        }

        private void BuildGrids()
        {
            MlpNetwork network = _programLogic.ExaminedNetwork;
            BuildGridColumns(uiInputData, network.InputCount + 1);
            uiInputData.Rows.Add(2);
            uiInputData.Rows[0].Cells[0].Value = "Input number (i)";
            uiInputData.Rows[1].Cells[0].Value = "Original inputs (u(i))";
            uiInputData.Rows[2].Cells[0].Value = "Normalized inputs (x(i))";
            BuildGridColumns(uiTeachingProgress, network.OutputCount + 1);
            uiTeachingProgress.Rows.Add(5);
            uiTeachingProgress.Rows[0].Cells[0].Value = "Output number (j)";
            uiTeachingProgress.Rows[1].Cells[0].Value = "Value before teaching (y(j))";
            uiTeachingProgress.Rows[2].Cells[0].Value = "Value expected (z(j))";
            uiTeachingProgress.Rows[3].Cells[0].Value = "Error before teaching (e(j))";
            uiTeachingProgress.Rows[4].Cells[0].Value = "Value after teaching (y'(j))";
            uiTeachingProgress.Rows[5].Cells[0].Value = "Error after teaching (e'(j))";
            for (int i = 1; i < uiTeachingProgress.ColumnCount; i++)
            {
                DataGridViewCellStyle style =
                    uiTeachingProgress.Rows[2].Cells[i].Style;
                style.BackColor = style.SelectionBackColor = Color.LightGreen;
                style = uiTeachingProgress.Rows[3].Cells[i].Style;
                style.BackColor = style.SelectionBackColor = Color.Pink;
                style = uiTeachingProgress.Rows[5].Cells[i].Style;
                style.BackColor = style.SelectionBackColor = Color.Pink;
            }
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

