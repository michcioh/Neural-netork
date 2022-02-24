using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuralNet;

namespace Data_for_neural_networks
{
    public partial class Window : Form
    {
        DataTable dtExample = new DataTable();
        DataTable dtResult = new DataTable();

        bool IsMouseLeftDown = false;
        bool IsMouseRightDown = false;

        private NeuralNetwork actualNetwork = null;

        List<String> learningData = new List<string>();

        public Window()
        {
            InitializeComponent();
        }

        private void nudExample_ValueChanged(object sender, EventArgs e)
        {
            dtExample.Rows.Clear();
            dtExample.Columns.Clear();

            for (int i = 0; i < (int) nudExampleColumns.Value; i++)
            {
                dtExample.Columns.Add(new DataColumn("example" + i, typeof(string)));
            }

            for (int i = 0; i < (int)nudExampleRows.Value; i++)
            {
                dtExample.Rows.Add();
            }

            ResetDgv(dgvExample, dtExample);
        }

        private void nudResult_ValueChanged(object sender, EventArgs e)
        {
            dtResult.Rows.Clear();
            dtResult.Columns.Clear();

            for (int i = 0; i < (int)nudResultColumns.Value; i++)
            {
                dtResult.Columns.Add(new DataColumn("result" + i, typeof(string)));
            }

            for (int i = 0; i < (int)nudResultRows.Value; i++)
            {
                dtResult.Rows.Add();
            }

            ResetDgv(dgvResult, dtResult);
        }

        private void ResetDgv(DataGridView dgv, DataTable data)
        {
            dgv.DataSource = data;

            int columnCnt = dgv.Columns.Count;
            int rowCnt = dgv.Rows.Count;

            int dim = columnCnt > rowCnt ? columnCnt : rowCnt;

            for (int c = 0; c < columnCnt; c++)
            {
                dgv.Columns[c].Width = (dgv.Width - dim) / dim;
                dgv.Columns[c].ReadOnly = true;
            }

            for (int r = 0; r < rowCnt; r++)
            {
                dgv.Rows[r].Height = (dgv.Width - dim) / dim;
            }

            for (int c = 0; c < dgv.Columns.Count; c++)
            {
                for (int r = 0; r < dgv.Columns.Count; r++)
                {
                    dgv.Rows[r].Cells[c].Value = "0";
                }
            }

            ColorTable(dgv);
        }

        private void Window_Load(object sender, EventArgs e)
        {
            nudExample_ValueChanged(null, null);
            nudResult_ValueChanged(null, null);

            //tRefresh.Start();
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (IsMouseLeftDown || IsMouseRightDown)
            {
                CellClick((DataGridView)sender, e.RowIndex, e.ColumnIndex);
            }

            // Console.WriteLine("dgv_CellMouseEnter: " + e.RowIndex + " x " + e.ColumnIndex);
        }

        private void CellClick(DataGridView dgv, int RowIndex, int ColumnIndex)
        {
            //dgv.Rows[RowIndex].Cells[ColumnIndex].Style.BackColor = IsMouseLeftDown ? Color.Black : Color.White;
            //dgv.Rows[RowIndex].Cells[ColumnIndex].Style.SelectionBackColor = dgv.Rows[RowIndex].Cells[ColumnIndex].Style.BackColor;

            if (dgv.Name == "dgvExample")
            {
                dtExample.Rows[RowIndex][ColumnIndex] = GetClickedValue(IsMouseLeftDown);
            } 
            else
            {
                dtResult.Rows[RowIndex][ColumnIndex] = GetClickedValue(IsMouseLeftDown);
            }

            Console.WriteLine("CellClick: " + RowIndex + " x " + ColumnIndex);
        }

        private String GetClickedValue(bool isMouseLeftDown)
        {
            if (isMouseLeftDown)
            {
                if (rbBlueL.Checked) return tbBlue.Text;
                if (rbBrownL.Checked) return tbBrown.Text;
                if (rbGreenL.Checked) return tbGreen.Text;
                if (rbGreyL.Checked) return tbGrey.Text;
                if (rbRedL.Checked) return tbRed.Text;
                if (rbWhiteL.Checked) return tbWhite.Text;
            } 
            else
            {
                if (rbBlueR.Checked) return tbBlue.Text;
                if (rbBrownR.Checked) return tbBrown.Text;
                if (rbGreenR.Checked) return tbGreen.Text;
                if (rbGreyR.Checked) return tbGrey.Text;
                if (rbRedR.Checked) return tbRed.Text;
                if (rbWhiteR.Checked) return tbWhite.Text;
            }

            return "0";
        }

        private Color GetColorByValue(String value)
        {
            if (value.Equals(tbBlue.Text)) return tbBlue.BackColor;
            if (value.Equals(tbBrown.Text)) return tbBrown.BackColor;
            if (value.Equals(tbGreen.Text)) return tbGreen.BackColor;
            if (value.Equals(tbGrey.Text)) return tbGrey.BackColor;
            if (value.Equals(tbRed.Text)) return tbRed.BackColor;
            if (value.Equals(tbWhite.Text)) return tbWhite.BackColor;

            return Color.FromArgb(240, 240, 240);
        }

        private void dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && IsMouseLeftDown)
            {
                IsMouseLeftDown = false;
                ColorTable((DataGridView)sender);
            }

            if (e.Button == MouseButtons.Right && IsMouseRightDown)
            {
                IsMouseRightDown = false;
                ColorTable((DataGridView)sender);
            }
        }

        private void dgv_MouseLeave(object sender, EventArgs e)
        {
            if (IsMouseLeftDown || IsMouseRightDown)
            {
                ColorTable((DataGridView)sender);
            }

            IsMouseLeftDown = false;
            IsMouseRightDown = false;
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsMouseLeftDown = false;
            IsMouseRightDown = false;

            if (e.Button == MouseButtons.Left)
            {
                IsMouseLeftDown = true;
            } 
            else if (e.Button == MouseButtons.Right)
            {
                IsMouseRightDown = true;
            }

            CellClick((DataGridView) sender, e.RowIndex, e.ColumnIndex);
        }

        private void bClearExample_Click(object sender, EventArgs e)
        {
            nudExample_ValueChanged(null, null);
        }

        private void bClearResult_Click(object sender, EventArgs e)
        {
            nudResult_ValueChanged(null, null);
        }

        private void bClearAll_Click(object sender, EventArgs e)
        {
            nudExample_ValueChanged(null, null);
            nudResult_ValueChanged(null, null);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("data.csv", true);

            String row = "";

            for (int r = 0; r < dgvExample.Rows.Count; r++)
            {
                for (int c = 0; c < dgvExample.Rows.Count; c++)
                {
                    if (row.Length > 0) row += ";";
                    row += dgvExample.Rows[r].Cells[c].Style.BackColor == Color.Black ? 1 : 0;
                }
            }

            for (int r = 0; r < dgvResult.Rows.Count; r++)
            {
                for (int c = 0; c < dgvResult.Columns.Count; c++)
                {
                    if (row.Length > 0) row += ";";
                    row += dgvResult.Rows[r].Cells[c].Style.BackColor == Color.Black ? 1 : 0;
                }
            }

            sw.WriteLine(row);
            sw.Close();

            Console.WriteLine("Zapisane");
        }

        private void ColorTable(DataGridView dgv)
        {
            DataTable dt = (dgv.Name == "dgvExample") ? dtExample : dtResult;

            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int c = 0; c < dgv.Columns.Count; c++)
                {
                    FillCellWithColor(dgv, r, c, GetColorByValue(dt.Rows[r][c].ToString()));/*
                    dgv.Rows[r].Cells[c].Style.BackColor = dt.Rows[r][c].ToString() == "1" ? Color.Black : Color.White;
                    dgv.Rows[r].Cells[c].Style.SelectionBackColor = dgv.Rows[r].Cells[c].Style.BackColor;

                    dgv.Rows[r].Cells[c].Style.ForeColor = dt.Rows[r][c].ToString() == "1" ? Color.Black : Color.White;
                    dgv.Rows[r].Cells[c].Style.SelectionForeColor = dgv.Rows[r].Cells[c].Style.ForeColor;*/
                }
            }
        }

        private void FillCellWithColor(DataGridView dgv, int r, int c, Color color)
        {
            dgv.Rows[r].Cells[c].Style.BackColor = color;
            dgv.Rows[r].Cells[c].Style.SelectionBackColor = color;

            dgv.Rows[r].Cells[c].Style.ForeColor = color;
            dgv.Rows[r].Cells[c].Style.SelectionForeColor = color;
        }

        private void tRefresh_Tick(object sender, EventArgs e)
        {
            ColorTable(dgvExample);
            ColorTable(dgvResult);
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                bSave_Click(null, null);
            } else if (e.KeyCode == Keys.F5)
            {
                bCheck_Click(null, null);
            }
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (actualNetwork == null)
            {
                LoadNetwork();
            }

            if (actualNetwork != null)
            {
                List<double> inputData = new List<double>();

                for (int r = 0; r < dgvExample.Rows.Count; r++)
                {
                    for (int c = 0; c < dgvExample.Rows.Count; c++)
                    {
                        inputData.Add(double.Parse(dgvExample.Rows[r].Cells[c].Value.ToString()));
                    }
                }

                inputData.Add(-1); // bias

                String errMsg = "";
                List<double> result = actualNetwork.CountOutputData(inputData, out errMsg);

                if (errMsg == null)
                {
                    int idx = 0;
                    int maxR = 0;
                    int maxC = 0;


                    for (int r = 0; r < dgvResult.Rows.Count; r++)
                    {
                        for (int c = 0; c < dgvResult.Columns.Count; c++)
                        {
                            double percentage = ((int)(result[idx++] * 10000)) / 10000.0; // get value in format x,xxxx

                            if (double.Parse(dgvResult.Rows[r].Cells[c].Value.ToString()) > double.Parse(dgvResult.Rows[maxR].Cells[maxC].Value.ToString()))
                            {
                                maxR = r;
                                maxC = c;
                            }

                            dgvResult.Rows[r].Cells[c].Value = percentage;
                            dgvResult.Rows[r].Cells[c].Style.BackColor = Color.White;
                            dgvResult.Rows[r].Cells[c].Style.ForeColor = GetColorOfPercentage(percentage);
                            dgvResult.Rows[r].Cells[c].Style.SelectionForeColor = GetColorOfPercentage(percentage);
                        }
                    }

                    double winner = double.Parse(dgvResult.Rows[maxR].Cells[maxC].Value.ToString());
                    Color winnerForeColor = GetColorOfPercentage(winner);
                    Color winnerBackColor = GetColorByValue("1");

                    dgvResult.Rows[maxR].Cells[maxC].Style.BackColor = winnerBackColor;
                    dgvResult.Rows[maxR].Cells[maxC].Style.ForeColor = winnerForeColor;
                    dgvResult.Rows[maxR].Cells[maxC].Style.SelectionForeColor = winnerForeColor;
                } 
                else
                {
                    MessageBox.Show(this, errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Color GetColorOfPercentage(double percentage)
        {
            int rgbParam = (int)(100 - percentage);

            return Color.FromArgb(rgbParam, rgbParam, rgbParam);
        }

        private void LoadNetwork()
        {
            if (ofdOpen.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fiOpenFile = new FileInfo(ofdOpen.FileName);
                try
                {
                    actualNetwork = Tools.DeSerializeObject<NeuralNetwork>(fiOpenFile.FullName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actualNetwork = null;
                }
            } 
        }

        private void bLoadLearningFile_Click(object sender, EventArgs e)
        {
            if (ofdOpenLearnData.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fiOpenFile = new FileInfo(ofdOpenLearnData.FileName);
                try
                {
                    learningData = new List<string>();

                    StreamReader sr = new StreamReader(fiOpenFile.FullName);
                    String line = sr.ReadLine();

                    while (line != null)
                    {
                        if (line.Length > 0) learningData.Add(line);

                        line = sr.ReadLine();
                    }

                    sr.Close();

                    lInfoMax.Text ="Ilość ruchów:" + learningData.Count;

                    nudLearningDataLineNo.Maximum = learningData.Count;
                    nudLearningDataLineNo.Value = 1;
                    nudLearningDataLineNo.Minimum = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nudLearningDataLineNo_ValueChanged(object sender, EventArgs e)
        {
            String line = learningData[(int)nudLearningDataLineNo.Value - 1];
            String[] tab = line.Split(';');

            int expectedTabSize = dgvExample.Rows.Count * dgvExample.Columns.Count + dgvResult.Rows.Count * dgvResult.Columns.Count;

            if (expectedTabSize != tab.Length)
            {
                MessageBox.Show(this, "Nieprawidłowy rozmiar danych uczących, oczekiwano : " + expectedTabSize + ", a otrzymano " + tab.Length,
                    "Nieprawidłowy rozmiar danych uczących", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = 0;

            nudExample_ValueChanged(null, null);

            for (int r = 0; r < dgvExample.Rows.Count; r++)
            {
                for (int c = 0; c < dgvExample.Columns.Count; c++)
                {
                    String value = tab[idx++];

                    if (value.Equals(tbGreen.Text))
                    {
                        FillCellWithColor(dgvExample, r, c, tbGreen.BackColor);
                    }
                    else if (value.Equals(tbRed.Text))
                    {
                        FillCellWithColor(dgvExample, r, c, tbRed.BackColor);
                    }
                    else if (value.Equals(tbBlue.Text))
                    {
                        FillCellWithColor(dgvExample, r, c, tbBlue.BackColor);
                    }
                    else if (value.Equals(tbGrey.Text))
                    {
                        FillCellWithColor(dgvExample, r, c, tbGrey.BackColor);
                    }
                }
            }

            nudResult_ValueChanged(null, null);

            for (int r = 0; r < dgvResult.Rows.Count; r++)
            {
                for (int c = 0; c < dgvResult.Columns.Count; c++)
                {
                    String value = tab[idx++];

                    Console.WriteLine(value);

                    if (value == "-1")
                    {
                        Console.WriteLine();
                    }

                    if (value.Equals(tbGreen.Text))
                    {
                        FillCellWithColor(dgvResult, r, c, tbGreen.BackColor);
                    }
                    else if (value.Equals(tbRed.Text))
                    {
                        FillCellWithColor(dgvResult, r, c, tbRed.BackColor);
                    }
                    else if (value.Equals(tbBlue.Text))
                    {
                        FillCellWithColor(dgvResult, r, c, tbBlue.BackColor);
                    }
                    else if (value.Equals(tbGrey.Text))
                    {
                        FillCellWithColor(dgvResult, r, c, tbGrey.BackColor);
                    }
                }
            }
        }

        private void bLR_Click(object sender, EventArgs e)
        {
            String valueL = GetClickedValue(true);
            String valueR = GetClickedValue(false);

            for (int r = 0; r < dgvExample.Rows.Count; r++)
            {
                for (int c = 0; c < dgvExample.Rows.Count; c++)
                {
                    if (dgvExample.Rows[r].Cells[c].Value.ToString().Equals(valueL))
                    {
                        dgvExample.Rows[r].Cells[c].Value = valueR;
                    } 
                    else if (dgvExample.Rows[r].Cells[c].Value.ToString().Equals(valueR))
                    {
                        dgvExample.Rows[r].Cells[c].Value = valueL;
                    }
                }
            }

            ColorTable(dgvExample);
        }
    }
}
