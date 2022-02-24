using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example02
{
    public partial class MainForm : Form
    {
        private LinearNetwork _examinedNetwork;

        private string[] _classNames =
            { "mammal", "bird", "fish" };

        private string[] _featureNames =
            { 
                "number of legs", "lives in water", "can fly", "has feathers",
                "egg-laying"
            };

        private double[] _inputVector;

        private double[] _outputVector;

        public MainForm()
        {
            InitializeComponent();
            double[,] weights =
                {
                    { 4,    0.01,   0.01,   -1,     -1.5 },
                    { 2,    -1,     2,      2.5,    2},
                    { -1,   3.5,    0.01,   -2,     1.5 }
                };

            _examinedNetwork = new LinearNetwork(weights);
            _inputVector = new double[weights.GetLength(1)];
            BuildSignalGrid();
            DiscardResults();
        }

        private void UpdateResults()
        {
            _resultsAvailable = true;
            _outputVector = _examinedNetwork.Response(_inputVector);
            int lastRow = uiSignalGrid.RowCount - 1;
            for (int i = 1; i < uiSignalGrid.ColumnCount - 1; i++)
            {
                uiSignalGrid.Rows[lastRow].Cells[i].Style = null;
                uiSignalGrid.UpdateCellValue(i, lastRow);
            }
            if (uiShowWinner.Checked)
            {
                int winner =
                    LinearNetwork.Winner(_outputVector, (double)uiThreshold.Value);
                for (int i = 1; i < uiSignalGrid.ColumnCount - 1; i++)
                    uiSignalGrid.Rows[lastRow].Cells[i].Style = null;
                if (winner != -1)
                {
                    DataGridViewCellStyle winnerStyle = new DataGridViewCellStyle();
                    winnerStyle.BackColor = Color.Red;
                    uiSignalGrid.Rows[lastRow].Cells[winner + 1].Style = winnerStyle;
                    uiWinnerNumber.Text = String.Format("Neuron {0}", winner + 1);
                    uiResult.Text =
                        String.Format("This is a {0}.", _classNames[winner]);
                }
                else
                {
                    uiWinnerNumber.Text = "(There is no winner.)";
                    uiResult.Text = "This is something strange!";
                }
            }
        }

        private bool _resultsAvailable;

        private void DiscardResults()
        {
            _resultsAvailable = false;
            for (int i = 1; i < uiSignalGrid.ColumnCount - 1; i++)
            {
                uiSignalGrid.Rows[uiSignalGrid.RowCount - 1].Cells[i].Style = null;
                uiSignalGrid.UpdateCellValue(i, uiSignalGrid.RowCount - 1);
            }
            uiWinnerNumber.Text = "";
            uiResult.Text = "";
        }

        /* Jeœli u¿ywasz Visual Studio, mo¿esz ukryæ mniej istotne czêœci kodu,
         * klikaj¹c ikonê "-" po lewej stronie poni¿szej linii. */
        #region GUI-related stuff

        private void BuildSignalGrid()
        {
            uiSignalGrid.Columns.Clear();

            DataGridViewTextBoxColumn attribColumn = new DataGridViewTextBoxColumn();
            attribColumn.DefaultCellStyle.BackColor = SystemColors.Control;
            attribColumn.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            attribColumn.HeaderText = "Feature";
            attribColumn.ReadOnly = true;
            attribColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            attribColumn.MinimumWidth = 60;
            uiSignalGrid.Columns.Add(attribColumn);

            for (int i = 0; i < _examinedNetwork.Neurons.Length; i++)
            {
                DataGridViewTextBoxColumn weightColumn =
                    new DataGridViewTextBoxColumn();
                weightColumn.DefaultCellStyle.BackColor = SystemColors.Control;
                weightColumn.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                weightColumn.HeaderText = _classNames[i];
                weightColumn.ReadOnly = true;
                weightColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                weightColumn.MinimumWidth = 60;
                uiSignalGrid.Columns.Add(weightColumn);
            }

            DataGridViewTextBoxColumn inputColumn = new DataGridViewTextBoxColumn();
            inputColumn.HeaderText = "Input vector";
            inputColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            inputColumn.MinimumWidth = 60;
            uiSignalGrid.Columns.Add(inputColumn);

            uiSignalGrid.RowCount = _examinedNetwork.InputCount+1;
            DataGridViewRow resultsRow = uiSignalGrid.Rows[uiSignalGrid.RowCount - 1];
            resultsRow.ReadOnly = true;
            resultsRow.Height *= 2;
            resultsRow.DefaultCellStyle.BackColor = SystemColors.Control;
            resultsRow.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            resultsRow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            resultsRow.DefaultCellStyle.Font =
                new Font(uiSignalGrid.DefaultCellStyle.Font, FontStyle.Bold);

            DataGridViewButtonCell recalculateCell = new DataGridViewButtonCell();
            resultsRow.Cells[uiSignalGrid.ColumnCount - 1] = recalculateCell;
            recalculateCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void uiSignalGrid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            bool lastRow = e.RowIndex == uiSignalGrid.RowCount-1;
            if (e.ColumnIndex == 0)
                e.Value = lastRow ? "Output" : _featureNames[e.RowIndex];
            else if (e.ColumnIndex == _examinedNetwork.Neurons.Length + 1)
                e.Value =
                    lastRow ? "Recalculate output!"
                    : _inputVector[e.RowIndex].ToString("g6");
            else
            {
                if (lastRow)
                    e.Value = _resultsAvailable ?
                        _outputVector[e.ColumnIndex - 1].ToString("g6")
                        : "";
                else
                    e.Value =
                        _examinedNetwork.
                        Neurons[e.ColumnIndex - 1].Weights[e.RowIndex];
            }
        }

        private void uiSignalGrid_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == _examinedNetwork.Neurons.Length + 1)
            {
                string str = e.Value as string;
                try
                {
                    _inputVector[e.RowIndex] = double.Parse(str);
                }
                catch (FormatException)
                {
                    MessageBox.Show(this,
                        String.Format("\"{0}\" is not a correct number.\"", str),
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show(this,
                        String.Format("You are supposed to enter a number.", str),
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void uiSignalGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if we are in the "recalculate" button cell.
            if (e.ColumnIndex == uiSignalGrid.ColumnCount - 1
                && e.RowIndex == uiSignalGrid.RowCount - 1
                && !_resultsAvailable)
                UpdateResults();
        }

        private void uiSignalGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DiscardResults();
        }

        private void uiShowWinner_CheckedChanged(object sender, EventArgs e)
        {
            if (uiShowWinner.Checked)
            {
                uiWinner.Visible = true;
                int[] rowHeights = uiMainLayoutPanel.GetRowHeights();
                Height += rowHeights[uiMainLayoutPanel.GetRow(uiWinner)];
            }
            else
            {
                int[] rowHeights = uiMainLayoutPanel.GetRowHeights();
                uiWinner.Visible = false;
                Height -= rowHeights[uiMainLayoutPanel.GetRow(uiWinner)];
            }
            UpdateResults();
        }

        private void uiThreshold_ValueChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }
        #endregion
    }
}