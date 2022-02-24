using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Neural.UC
{
    public partial class DialogChart : UserControl
    {
        private List<NeuralNet.RmsErrorHistoryElement> data;

        DataPoint previousDataPoint;
        Color normalPointColor = Color.FromArgb(65, 105, 255);
        Color selectedPointColor = Color.IndianRed;
        public Window MainWindow { get; set; }

        public DialogChart()
        {
            InitializeComponent();
        }

        public void OnActivation()
        {

        }

        public void SetData(List<NeuralNet.RmsErrorHistoryElement> data)
        {
            this.data = data;

            int dataSize = data.Count;

            nudFrom.Value = (Decimal) 1;
            nudFrom.Maximum = (Decimal)dataSize - 2;

            nudTo.Value = 1; // be sure value is less then new max:
            nudTo.Maximum = (Decimal)dataSize;
            nudTo.Value = (Decimal) dataSize;

            if (cbChartType.SelectedIndex == -1) cbChartType.SelectedIndex = 0;

            ShowChart();
        }

        private void ShowChart()
        {
            if (nudFrom.Value >nudTo.Value)
            {
                MessageBox.Show(this, "From is greater than to!", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chChart.Series[0].Points.Clear();

            List<NeuralNet.RmsErrorHistoryElement> dataToShow = new List<NeuralNet.RmsErrorHistoryElement>();

            int from = (int)nudFrom.Value - 1;
            int to = (int)nudTo.Value;
            int points = (int)nudPoints.Value;

            for (int i = from; i<to; i++)
            {
                dataToShow.Add(data[i]);
            }

            int modulo = dataToShow.Count / points;
            if (modulo == 0) modulo = 1;

            int point = 0;
            do
            {
                chChart.Series[0].Points.AddXY(dataToShow[point].EpochNo, dataToShow[point].RmsError);
                point += modulo;
            } while (point < dataToShow.Count);

            switch (cbChartType.SelectedIndex)
            {
                // TODO: EVOLUTION: save as app settings chart setting without range (becouse it depends of data)
                case 0:
                    chChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case 1:
                    chChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case 2:
                    chChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    break;
                case 3:
                    chChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
            }

            if (points > 100)
            {
                cbShowValues.Checked = false;
            } 

            chChart.Series[0].IsValueShownAsLabel = cbShowValues.Checked;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BShow_Click(object sender, EventArgs e)
        {
            ShowChart();
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            ShowChart();
        }

        private void CbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowChart();
        }

        private void CbShowValues_CheckedChanged(object sender, EventArgs e)
        {
            ShowChart();
        }

        

        private void ChChart_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chChart.HitTest(e.X, e.Y, ChartElementType.DataPoint);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint currentDataPoint = (DataPoint) result.Object;
                if (currentDataPoint != null)
                {
                    if (currentDataPoint != previousDataPoint)
                    {
                        ClearPreviousPoint();
                    }

                    String pointDetails = "epoch no.: " + (int)currentDataPoint.XValue + ", error: " + currentDataPoint.YValues[0];
                    //currentDataPoint.ToolTip = pointDetails;
                    lPointDetails.Text = pointDetails;
                    lPointDetails.Refresh();
                    //currentDataPoint.IsValueShownAsLabel = true;
                    currentDataPoint.MarkerColor = selectedPointColor;
                    currentDataPoint.MarkerSize = 10;

                    previousDataPoint = currentDataPoint;
                }
                else
                {
                    ClearPreviousPoint();
                }
            }
            else 
            {
                ClearPreviousPoint();
            }
        }

        private void ClearPreviousPoint()
        {
            if (previousDataPoint != null)
            {
                //previousDataPoint.IsValueShownAsLabel = false;
                previousDataPoint.MarkerColor = normalPointColor;
                previousDataPoint.MarkerSize = 5;
                lPointDetails.Text = "select point";
            }
        }
    }
}
