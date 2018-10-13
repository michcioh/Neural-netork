using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Neural
{
    public partial class DialogDgvShow : UserControl
    {
        int Digits;
        public Window MainWindow { get; set; }

        public DialogDgvShow()
        {
            InitializeComponent();
        }

        public void SetControls(DataGridView dgvToShow, int digits)
        {
            this.dgv.Dispose();
            this.Digits = digits;

            DataGridView dgv = Tools.CopyDataGridView(dgvToShow);
            pDgv.Controls.Add(dgv);
            dgv.Invalidate();
            dgv.Refresh();
            this.dgv = dgv;
            this.dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = dgvToShow.ReadOnly;
            dgv.MultiSelect = dgvToShow.MultiSelect;
            dgv.RowHeadersVisible = dgvToShow.RowHeadersVisible; 
            dgv.AllowUserToResizeColumns = dgvToShow.AllowUserToResizeColumns;
            dgv.AllowUserToResizeRows = dgvToShow.AllowUserToResizeRows;
            dgv.AllowUserToAddRows = dgvToShow.AllowUserToAddRows;
            dgv.AllowUserToOrderColumns = dgvToShow.AllowUserToOrderColumns;
            dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNeurons_CellDoubleClick);

            dgv.Focus(); // TODO: ERROR: Escape not working and focus on dgv too... 
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DgvNeurons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool wrongCell = false;
            if (dgv.Columns[e.ColumnIndex].Name.StartsWith("nWeight"))
            {
                int inputNo = Int32.Parse(dgv.Columns[e.ColumnIndex].Name.Replace("nWeight", ""));

                try
                {
                    int layerNo = Int32.Parse(dgv.Rows[e.RowIndex].Cells["nLayerNo"].Value.ToString()) - 1;
                    int neuronNo = Int32.Parse(dgv.Rows[e.RowIndex].Cells["nNeuronNo"].Value.ToString()) - 1;
                    double inputValue = Double.Parse(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString().Replace(".", ","));
                    double weightValue = Double.Parse(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace(".", ","));

                    MainWindow.ucDialogChangeValueOfNeuron.SetControls(layerNo, neuronNo, inputNo, inputValue, weightValue, Digits);
                    MainWindow.ChangePage(MainWindow.ucDialogChangeValueOfNeuron.GetType());
                }
                catch (Exception)
                {
                    wrongCell = true;
                }
            }
            else
            {
                wrongCell = true;
            }

            if (wrongCell)
                MessageBox.Show(this, "Are you sure it is a weight cell with value?", "Wrong cell?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
