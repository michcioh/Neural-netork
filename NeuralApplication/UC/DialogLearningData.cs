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
    public partial class DialogLearningData : UserControl
    {
        List<LearnSample> learnSamples = new List<LearnSample>();
        int OutputCount = 0;
        int InputCount = 0;
        bool IsNetworkUsingBiases = false;
        DataLearnDecription dld;
        Color errorColor = Color.FromArgb(255, 180, 180);

        public Window MainWindow { get; set; }

        public DialogLearningData()
        {
            InitializeComponent();
        }

        private void CreateNetwork_Resize(object sender, EventArgs e)
        {
            pContent.Location = new Point((this.Width - pContent.Width) / 2, (this.Height - pContent.Height) / 2);
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            MainWindow.ucNetworkDetails.NotifyLearnDataChange();
            this.Hide();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal void OnActivation(int inputCount, int outputCount, bool isNetworkUsingBiases) 
        {
            this.InputCount = inputCount;
            this.OutputCount = outputCount;
            this.IsNetworkUsingBiases = isNetworkUsingBiases;
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

        public List<LearnSample> GetLearnSamples()
        {
            
            //PaintRowsNormalDgvLearning();
            bool allOk = true;

            if (rbLearnAllData.Checked)
            {
                return learnSamples; // TODO: Now getting only readed from file, not from dgv
            }
            else
            {
                #region Validating and getting choosen rows indexes
                List<int> choosenRowIndexes = new List<int>();

                foreach (DataGridViewCell cell in dgvLearningData.SelectedCells)
                {
                    if (!choosenRowIndexes.Contains(cell.RowIndex))
                    {
                        choosenRowIndexes.Add(cell.RowIndex);
                    }
                }

                if (choosenRowIndexes.Count == 0)
                {
                    return null;
                }

                for (int choosenRowIdx = 0; choosenRowIdx < choosenRowIndexes.Count; choosenRowIdx++)
                {
                    int row = choosenRowIndexes.ElementAt(choosenRowIdx);

                    bool rowOk = true;

                    for (int cell = 1; cell < dgvLearningData.ColumnCount; cell++)
                    {
                        if (dgvLearningData.Rows[row].Cells[cell].Value == null && IsNetworkUsingBiases && dgvLearningData.Columns[cell].Visible)
                        {
                            rowOk = false;
                            break;
                        }

                        String input = dgvLearningData.Columns[cell].Visible ? dgvLearningData.Rows[row].Cells[cell].Value.ToString() : "1";
                        try
                        {
                            double doubleValue = Double.Parse(input);
                        }
                        catch (Exception)
                        {
                            rowOk = false;
                            break;
                        }
                    }

                    if (!rowOk)
                    {
                        allOk = false;

                        PaintRowRedDgvLearning(row);
                    }
                }

                if (!allOk)
                {
                    MessageBox.Show(this, "Inside red - colored rows are errors - correct it before learning!",
                        "Wrong value(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                #endregion

                #region Create list of learn samples using choosen rows indexes
                List<LearnSample> returnLearnSamples = new List<LearnSample>();

                for (int i = 0; i < choosenRowIndexes.Count; i++)
                {
                    int row = choosenRowIndexes.ElementAt(i);
                    LearnSample learnSample = new LearnSample(OutputCount);

                    for (int inputNo = 0; inputNo < InputCount; inputNo++)
                    {
                        String input = dgvLearningData.Rows[row].Cells[inputNo + 1].Value.ToString();
                        try
                        {
                            double doubleValue = Double.Parse(input);
                            learnSample.InputData.Add(doubleValue);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(this, input + " is not a double value! Learning doesn't start.", "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }

                    for (int outputNo = 0; outputNo < OutputCount; outputNo++)
                    {
                        String output = dgvLearningData.Rows[row].Cells[1 + InputCount + outputNo].Value.ToString();
                        try
                        {
                            double doubleValue = Double.Parse(output);
                            learnSample.OutputData[outputNo] = doubleValue;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(this, output + " is not a double value! Learning doesn't start.", "Wrong value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }

                    returnLearnSamples.Add(learnSample);
                }
                #endregion

                return returnLearnSamples;
            }
        }

        private void BReadingDataFile_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                List<string> fileContent = new List<string>();

                FileInfo fiLearnFile = new FileInfo(ofdOpen.FileName);
                StreamReader sr = new StreamReader(fiLearnFile.FullName);

                String line = sr.ReadLine();
                while (line != null)
                {
                    fileContent.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                // validate content
                if (fileContent.Count == 0)
                {
                    MessageBox.Show(this, "File is empty!", "Wrong file content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                String[] tab = fileContent.ElementAt(0).Split(new char[] { ';' });
                int inputCountWithoutBiases = InputCount;

                if (tab.Length != inputCountWithoutBiases + OutputCount)
                {
                    MessageBox.Show(this, "Quantity of data in row not equal sum of neurons input and output layer!", "Wrong file content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                learnSamples.Clear();
                for (int contentLineNo = 0; contentLineNo < fileContent.Count; contentLineNo++)
                {
                    // validation line
                    tab = fileContent.ElementAt(contentLineNo).Split(new char[] { ';' });

                    if (tab.Length != inputCountWithoutBiases + OutputCount)
                    {
                        MessageBox.Show(this, "Quantity of data in row not equal sum of neurons input and output in line number " + contentLineNo + "!",
                            "Wrong file content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        learnSamples.Clear();
                        return;
                    }
                    else
                    {
                        try
                        {
                            for (int i = 0; i < tab.Length; i++)
                            {
                                Double.Parse(tab[i]);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(this, "Some of data are not double values in line number " + contentLineNo + "!",
                            "Wrong file content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            learnSamples.Clear();
                            return;
                        }
                    }

                    // read data
                    int dataNo = 0;

                    LearnSample learnSample = new LearnSample(OutputCount);

                    for (; dataNo < inputCountWithoutBiases; dataNo++)
                    {
                        learnSample.InputData.Add(Double.Parse(tab[dataNo]));
                    }

                    int outputNo = 0;
                    for (; dataNo < tab.Length; dataNo++)
                    {
                        learnSample.OutputData[outputNo++] = Double.Parse(tab[dataNo]);
                    }

                    learnSamples.Add(learnSample);
                }

                FileInfo dld = new FileInfo(fiLearnFile.FullName.Replace(fiLearnFile.Extension, ".dld"));
                if (dld.Exists)
                {
                    ReadDldFile(dld);
                }

                if (cbShowData.Checked)
                {
                    WriteLearnSamplesToDgv();
                }

                tbFileName.Text = fiLearnFile.FullName;
            }
        }

        private void ReadDldFile(FileInfo dldFile)
        {
            dld = Tools.DeSerializeObject<DataLearnDecription>(dldFile.FullName);
            if (InputCount != dld.InputQuantity || OutputCount != dld.OutputQuantity)
            {
                dld = null;
                /*
                nudInputQuantity.Value = (Decimal)dld.InputQuantity;
                nudOutputQuantity.Value = (Decimal)dld.OutputQuantity;

                cbInputDimensions.SelectedIndex = dld.InputDimensionIndex;
                cbOutputDimensions.SelectedIndex = dld.OutputDimensionIndex;

                dgvInputMapping.Rows.Clear();

                foreach (MappedValue mappValue in dld.MappedInputs)
                {
                    dgvInputMapping.Rows.Add(new String[] { mappValue.OriginalValue, mappValue.NewValue });
                }

                dgvOutputMapping.Rows.Clear();

                foreach (MappedValue mappValue in dld.MappedOutputs)
                {
                    dgvOutputMapping.Rows.Add(new String[] { mappValue.OriginalValue, mappValue.NewValue });
                }*/
            }
        }

        private void ShowVisualization(int dataLearnItemIdx)
        {
            if (dld == null || dataLearnItemIdx == -1 || dataLearnItemIdx > learnSamples.Count - 1)
            {
                dgvInputData.Rows.Clear();
                dgvInputData.Columns.Clear();

                dgvOutputData.Rows.Clear();
                dgvOutputData.Columns.Clear();
            }
            else
            {
                LearnSample learnSample = learnSamples.ElementAt(dataLearnItemIdx);

                #region Input and ouptup dgv creation

                Size inputDimension = dld.InputPossibleDimensions[dld.InputDimensionIndex];
                Size outputDimension = dld.OutputPossibleDimensions[dld.OutputDimensionIndex];

                if (dgvInputData.ColumnCount == 0)
                {
                    
                    for (int columnNo = 0; columnNo < inputDimension.Width; columnNo++)
                    {
                        dgvInputData.Columns.Add("c" + columnNo, "c" + columnNo);
                        dgvInputData.Columns[dgvInputData.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    //String[] tab = new string[inputDimension.Width];

                    for (int rowNo = 0; rowNo < inputDimension.Height; rowNo++)
                    {
                        dgvInputData.Rows.Add();
                    }
                }

                if (dgvOutputData.ColumnCount == 0)
                {
                    
                    for (int columnNo = 0; columnNo < outputDimension.Width; columnNo++)
                    {
                        dgvOutputData.Columns.Add("c" + columnNo, "c" + columnNo);
                        dgvOutputData.Columns[dgvOutputData.ColumnCount - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    //String[] tab = new string[inputDimension.Width];

                    for (int rowNo = 0; rowNo < outputDimension.Height; rowNo++)
                    {
                        dgvOutputData.Rows.Add();
                    }
                }
                #endregion

                int elementNo = 0;
                for (int columnNo = 0; columnNo < inputDimension.Width; columnNo++)
                {
                    for (int rowNo = 0; rowNo < inputDimension.Height; rowNo++)
                    {
                        dgvInputData[columnNo, rowNo].Value = UseMapping(learnSample.InputData[elementNo++].ToString(), dld.MappedInputs);
                    }
                }

                elementNo = 0;
                for (int columnNo = 0; columnNo < outputDimension.Width; columnNo++)
                {
                    for (int rowNo = 0; rowNo < outputDimension.Height; rowNo++)
                    {
                        dgvOutputData[columnNo, rowNo].Value = UseMapping(learnSample.OutputData[elementNo++].ToString(), dld.MappedOutputs);
                    }
                }
            }

            if (dgvInputData.SelectedCells.Count > 0) dgvInputData.SelectedCells[0].Selected = false;
            if (dgvOutputData.SelectedCells.Count > 0) dgvOutputData.SelectedCells[0].Selected = false;
        }

        private String UseMapping(String value, List<MappedValue> mappedValues)
        {
            foreach(MappedValue mappedvalue in mappedValues)
            {
                if (mappedvalue.OriginalValue == value)
                    return mappedvalue.NewValue;
            }

            return value;
        }

        private void WriteLearnSamplesToDgv()
        {
            dgvLearningData.Rows.Clear();
            dgvLearningData.Columns.Clear();

            // columns
            dgvLearningData.Columns.Add("lineNo", "Line no.");

            dgvLearningData.Columns[0].ReadOnly = true;
            dgvLearningData.Columns[0].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;

            int inputCountWithoutBiases = InputCount;

            for (int col = 0; col < inputCountWithoutBiases; col++)
            {
                dgvLearningData.Columns.Add("in" + col, "input " + (col + 1));
            }

            for (int col = 0; col < OutputCount; col++)
            {
                dgvLearningData.Columns.Add("out" + col, "output " + (col + 1));
            }

            for (int sampleNo = 0; sampleNo < learnSamples.Count; sampleNo++)
            {
                LearnSample sample = learnSamples.ElementAt(sampleNo);

                String[] tab = new String[inputCountWithoutBiases + OutputCount + 1];

                int tabIdx = 0;
                tab[tabIdx++] = (sampleNo + 1).ToString();

                for (int inputNo = 0; inputNo < inputCountWithoutBiases; inputNo++)
                {
                    tab[tabIdx++] = sample.InputData.ElementAt(inputNo).ToString();
                }

                for (int outputNo = 0; outputNo < OutputCount; outputNo++)
                {
                    tab[tabIdx++] = sample.OutputData.ElementAt(outputNo).ToString();
                }

                dgvLearningData.Rows.Add(tab);
            }

            foreach (DataGridViewColumn col in dgvLearningData.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvLearningData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            SetRowsForLearningSamples();
        }

        private void SetRowsForLearningSamples()
        {
            for (int row = 0; row < dgvLearningData.RowCount; row++)
            {
                dgvLearningData.Rows[row].Cells["lineNo"].Value = (row + 1);
            }
        }

        private void CbShowData_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowData.Checked)
            {
                WriteLearnSamplesToDgv();
            }
            else
            {
                dgvLearningData.Rows.Clear();
                dgvLearningData.Columns.Clear();
            }
        }

        private void BDldFile_Click(object sender, EventArgs e)
        {
            // TODO: !IMPLEMENTED: Create / edit dld file from data learning dialog
            MainWindow.NotImplementedMessage();
        }

        private void DgvLearningData_SelectionChanged(object sender, EventArgs e)
        {
            if (dld != null && dgvLearningData.SelectedCells.Count == 1)
            {
                ShowVisualization(dgvLearningData.SelectedCells[0].RowIndex);
            }
            else
            {
                dgvInputData.Rows.Clear();
                dgvInputData.Columns.Clear();
                dgvOutputData.Rows.Clear();
                dgvOutputData.Columns.Clear();
            }
        }

        private void BSaveLearningDataToFile_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fiSaveFile = new FileInfo(sfdSave.FileName);
                try
                {
                    StreamWriter sw = new StreamWriter(fiSaveFile.FullName);

                    for (int row = 0; row < dgvLearningData.Rows.Count; row++)
                    {
                        String line = "";
                        bool lineOk = true;

                        for (int cell = 1; cell < dgvLearningData.ColumnCount; cell++)
                        {
                            if (IsNetworkUsingBiases && !dgvLearningData.Columns[cell].Visible && dgvLearningData.Rows[row].Cells[cell].Value == null)
                            {
                                dgvLearningData.Rows[row].Cells[cell].Value = "1";
                            }

                            if (dgvLearningData.Rows[row].Cells[cell].Value != null)
                            {
                                if (dgvLearningData.Rows[row].Cells[cell].Value.ToString() != "")
                                {
                                    if (line.Length != 0)
                                    {
                                        line += ";";
                                    }

                                    line += dgvLearningData.Rows[row].Cells[cell].Value.ToString();
                                }
                                else
                                {
                                    lineOk = false;
                                    break;
                                }
                            }
                            else
                            {
                                lineOk = false;
                                break;
                            }
                        }

                        if (lineOk)
                        {
                            sw.WriteLine(line);
                        }
                    }

                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvLearningData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetRowsForLearningSamples();
        }

        private void DgvLearningData_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SetRowsForLearningSamples();
        }

        private void DgvLearningData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SetRowsForLearningSamples();
        }

        public void PaintRowRedDgvLearning(int rowIdx)
        {
            for (int cell = 1; cell < dgvLearningData.Rows[rowIdx].Cells.Count; cell++)
            {
                dgvLearningData.Rows[rowIdx].Cells[cell].Style.BackColor = errorColor;
            }
        }

        public void PaintRowsNormalDgvLearning(int rowIdx = -1)
        {
            if (rowIdx == -1)
            {
                foreach (DataGridViewRow row in dgvLearningData.Rows)
                {
                    for (int cell = 1; cell < row.Cells.Count; cell++)
                    {
                        row.Cells[cell].Style.BackColor = Color.White;
                    }
                }
            }
            else
            {
                for (int cell = 1; cell < dgvLearningData.Rows[rowIdx].Cells.Count; cell++)
                {
                    dgvLearningData.Rows[rowIdx].Cells[cell].Style.BackColor = Color.White;
                }
            }
        }

        private void DgvLearningData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLearningData.Columns[e.ColumnIndex].Name != "lineNo")
            {
                MainWindow.ucNetworkDetails.TestNetwork();
            }
        }
    }
}
