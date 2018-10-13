using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Neural.UC
{
    public partial class DialogDataLearningConverter : UserControl
    {
        FileInfo file;
        int ElementCount = 0;
        bool nudChangeValueAuto = true;
        List<Size> inputPossibleDimensions;
        List<Size> outputPossibleDimensions;

        public Window MainWindow { get; internal set; }

        public DialogDataLearningConverter()
        {
            InitializeComponent();
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

        private void DialogDataLearningConverter_Resize(object sender, EventArgs e)
        {
            pContent.Location = new Point((this.Width - pContent.Width) / 2, (this.Height - pContent.Height) / 2);
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal void OnActivation()
        {
            Reset();
            bChooseFile.Focus();
        }

        private void Reset()
        {
            pDetails.Enabled = false;
            nudInputQuantity.Value = (Decimal) 1;
            nudOutputQuantity.Value = (Decimal) 1;
            tbFile.Text = "";
            file = null;
            dgvInputMapping.Rows.Clear();
            dgvOutputMapping.Rows.Clear();
            nudChangeValueAuto = false;
            nudInputQuantity.Value = 1;
            nudOutputQuantity.Value = 1;
            nudChangeValueAuto = true;
            ElementCount = 0;
            lQuantityInLine.Text = ElementCount.ToString();
            cbInputDimensions.SelectedIndex = -1;
            cbOutputDimensions.SelectedIndex = -1;
        }

        private void BChooseFile_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog(this) == DialogResult.OK)
            {
                file = new FileInfo(ofdOpen.FileName);
                tbFile.Text = file.FullName;
                if (!ValidateFile())
                {
                    MessageBox.Show(this, "Format of file is wrong: should be csv file separated with semicolon, cointains only double values.", "Wrong file format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Reset();
                }
                else
                {
                    pDetails.Enabled = true;
                    bCreate.Enabled = true;

                    lQuantityInLine.Text = ElementCount.ToString();

                    nudInputQuantity.Value = ElementCount / 2;
                    nudInputQuantity.Maximum = ElementCount - 1;
                    nudOutputQuantity.Maximum = ElementCount - 1;

                    FileInfo dld = new FileInfo(file.FullName.Replace(file.Extension, ".dld"));
                    if (dld.Exists)
                    {
                        ReadDldFile(dld);
                    }
                }
            }
        }

        private void ReadDldFile(FileInfo dldFile)
        {
            DataLearnDecription dld = Tools.DeSerializeObject< DataLearnDecription>(dldFile.FullName);
            if (ElementCount == dld.InputQuantity + dld.OutputQuantity)
            {
                nudInputQuantity.Value = (Decimal) dld.InputQuantity;
                nudOutputQuantity.Value = (Decimal)dld.OutputQuantity;

                cbInputDimensions.SelectedIndex = dld.InputDimensionIndex;
                cbOutputDimensions.SelectedIndex = dld.OutputDimensionIndex;

                dgvInputMapping.Rows.Clear();

                foreach (MappedValue mappValue in dld.MappedInputs)
                {
                    dgvInputMapping.Rows.Add( new String[] { mappValue.OriginalValue, mappValue.NewValue} );
                }

                dgvOutputMapping.Rows.Clear();

                foreach (MappedValue mappValue in dld.MappedOutputs)
                {
                    dgvOutputMapping.Rows.Add(new String[] { mappValue.OriginalValue, mappValue.NewValue });
                }
            }
        }

        private List<Size> CreatePossibleDimensions(int size)
        {
            List<Size> dimensions = new List<Size>();

            for (int divider = 1; divider <= size; divider++)
            {
                if (size % divider == 0)
                {
                    Size dimension = new Size(divider, size / divider);
                    dimensions.Add(dimension);
                }
            }

            return dimensions;
        }

        private bool ValidateFile()
        {
            try
            {
                StreamReader sr = new StreamReader(file.FullName);
                String line = sr.ReadLine();
                String[] tab = line.Split(';');
                ElementCount = tab.Length;

                foreach (var item in tab)
                {
                    double.Parse(item);
                }
            }
            catch (Exception)
            {
                ElementCount = 0;
                return false;
            }

            return true;
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            String path = file.FullName.Replace(file.Name, "");
            String fileName = file.Name.Replace(file.Extension, "") + ".dld";
            String dldFile = path + fileName;

            // TODO: !IMPLEMENTED: Validation on not filled data - mapped.
            List<MappedValue> inputMappedValues = new List<MappedValue>();
            foreach (DataGridViewRow row in dgvInputMapping.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        MappedValue mappedValue = new MappedValue()
                        {
                            OriginalValue = row.Cells[0].Value.ToString(),
                            NewValue = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString()
                        };

                        inputMappedValues.Add(mappedValue);
                    }
                }
            }

            List<MappedValue> outputMappedValues = new List<MappedValue>();
            foreach (DataGridViewRow row in dgvOutputMapping.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        MappedValue mappedValue = new MappedValue()
                        {
                            OriginalValue = row.Cells[0].Value.ToString(),
                            NewValue = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString()
                        };

                        outputMappedValues.Add(mappedValue);
                    }
                }
            }


            DataLearnDecription dld = new DataLearnDecription()
            {
                InputQuantity = (int)nudInputQuantity.Value,
                OutputQuantity = (int)nudOutputQuantity.Value,
                InputPossibleDimensions = inputPossibleDimensions,
                OutputPossibleDimensions = outputPossibleDimensions,
                InputDimensionIndex = cbInputDimensions.SelectedIndex,
                OutputDimensionIndex = cbOutputDimensions.SelectedIndex,
                MappedInputs = inputMappedValues,
                MappedOutputs = outputMappedValues
            };

            try
            {
                Tools.SerializeObject(dld, dldFile);
                MessageBox.Show(this, "File " + fileName + " created successfully!", "File created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error while creating dld file: " + ex.Message, "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NudInputQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (nudChangeValueAuto)
            {
                nudChangeValueAuto = false;
                nudOutputQuantity.Value = (Decimal)ElementCount - nudInputQuantity.Value;
                nudChangeValueAuto = true;
            }

            outputPossibleDimensions = CreatePossibleDimensions((int)nudOutputQuantity.Value);
            RefreshCbDimensions(cbInputDimensions, outputPossibleDimensions);
        }

        private void RefreshCbDimensions(ComboBox cb, List<Size> possibleDimensions)
        {
            cb.Items.Clear();

            foreach (Size dimension  in possibleDimensions)
            {
                cb.Items.Add(dimension.Width + " x " + dimension.Height + " (rows: " + dimension.Width + ", columns: " + dimension.Height +")");
            }

            cb.SelectedIndex = 0;
        }

        private void NudOutputQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (nudChangeValueAuto)
            {
                nudChangeValueAuto = false;
                nudInputQuantity.Value = (Decimal)ElementCount - nudOutputQuantity.Value;
                nudChangeValueAuto = true;
            }

            inputPossibleDimensions = CreatePossibleDimensions((int)nudInputQuantity.Value);
            RefreshCbDimensions(cbOutputDimensions, inputPossibleDimensions);
        }
    }
}
