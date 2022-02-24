using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example01b
{
    public partial class MainForm : Form
    {
        private Neuron _examinedNeuron = new Neuron(2);

        private PointDataSeries _chartPoints = new PointDataSeries(2);

        public MainForm()
        {
            InitializeComponent();
            _chartPoints.Points.Add(new PointDataSeries.ChartPoint());
            _chartPoints.Points.Add(new PointDataSeries.ChartPoint());
            _chartPoints.PointSize = 2;
            uiChartPlotter.DataSeries.Add(_chartPoints);
            EvaluateObject();
        }

        private void EvaluateObject()
        {
            _examinedNeuron.Weights[0] = (double)uiWeight1.Value;
            _examinedNeuron.Weights[1] = (double)uiWeight2.Value;

            double[] inputs = new double[]
            {
                (double)uiObject1.Value,
                (double)uiObject2.Value
            };

            double response = _examinedNeuron.Response(inputs);

            double strength =
                _examinedNeuron.MemoryTraceStrength(StrengthNorm.Euclidean);
            Color signalColor;
            if (Math.Abs(response) < 0.2 * strength)
                signalColor = Color.DarkCyan;
            else if (response < 0)
                signalColor = Color.Blue;
            else
                signalColor = Color.Red;

            // 8 digits should be enough.
            uiResponse.Text = response.ToString("g8");
            uiResponse.ForeColor = uiKeyObject.ForeColor = signalColor;

            PointF weightsPoint = new PointF(
                (float)_examinedNeuron.Weights[0],
                (float)_examinedNeuron.Weights[1]);
            PointF inputPoint = new PointF(
                (float)inputs[0],
                (float)inputs[1]);
            PointDataSeries.ChartPoint weightsSignal = new PointDataSeries.ChartPoint(
                    weightsPoint, Color.Green, true);
            PointDataSeries.ChartPoint inputSignal = new PointDataSeries.ChartPoint(
                    inputPoint, signalColor, true);

            _chartPoints.Points[0] = weightsSignal;
            _chartPoints.Points[1] = inputSignal;
        }

        /* Jeœli u¿ywasz Visual Studio, mo¿esz ukryæ mniej istotne czêœci kodu,
         * klikaj¹c ikonê "-" po lewej stronie poni¿szej linii. */
        #region GUI-related stuff

        private void ParameterChanged(object sender, EventArgs e)
        {
            EvaluateObject();
        }

        private void VisualizerMouseHandler(object sender, MouseEventArgs e)
        {
            // The controls to be updated.
            NumericUpDown uiCoord1 = null;
            NumericUpDown uiCoord2 = null;
            // Determines if we need update.
            bool evaluate = false;

            // Determine if we have anything to do.
            if ((e.Button & MouseButtons.Left) != 0)
            {
                uiCoord1 = uiObject1;
                uiCoord2 = uiObject2;
                evaluate = true;
            }
            if ((e.Button & MouseButtons.Right) != 0)
            {
                uiCoord1 = uiWeight1;
                uiCoord2 = uiWeight2;
                evaluate = true;
            }

            if (evaluate)
            {
                // Crop the values to the acceptable range to avoid the exceptions.
                PointF signalPosition = uiChartPlotter.Screen2Space(e.Location);
                decimal x = Math.Max((decimal)signalPosition.X, uiCoord1.Minimum);
                x = Math.Min(x, uiCoord1.Maximum);
                decimal y = Math.Max((decimal)signalPosition.Y, uiCoord2.Minimum);
                y = Math.Min(y, uiCoord2.Maximum);
                uiCoord1.Value = x;
                uiCoord2.Value = y;
                EvaluateObject();
            }
        }
        #endregion
    }
}