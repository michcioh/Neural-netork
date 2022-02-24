using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example06d
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            uiTransferFunctionType.SelectedIndex = 0;
            _dataSeries.FunctionObject = _netFun;
            uiChartPlotter.DataSeries.Add(_dataSeries);
            _neuronLines.ContinuousLine = false;
            _neuronLines.ForeColor = Color.Black;

            Binding binding = new Binding("Text", uiLayerCount, "Value");
            binding.FormattingEnabled = true;
            binding.FormatString = "(#)";
            uiLayerCountLabel.DataBindings.Add(binding);

            binding = new Binding("Text", uiOutputCount, "Value");
            binding.FormattingEnabled = true;
            binding.FormatString = "(#)";
            uiOutputCountLabel.DataBindings.Add(binding);

            binding = new Binding("Text", uiWeightsRange, "Value");
            binding.FormattingEnabled = true;
            binding.Format += new ConvertEventHandler(binding_Format);
            uiWeightsRangeLabel.DataBindings.Add(binding);

            binding = new Binding("Text", uiBiasWeightsRange, "Value");
            binding.FormattingEnabled = true;
            binding.Format += new ConvertEventHandler(binding_Format);
            uiBiasWeightsRangeLabel.DataBindings.Add(binding);

            _weightsRangeBinding = new Binding("Value", uiWeightsRange, "Value");
            uiBiasWeightsRange.DataBindings.Add(_weightsRangeBinding);
        }

        private Binding _weightsRangeBinding;

        void binding_Format(object sender, ConvertEventArgs e)
        {
            e.Value = string.Format("({0:g2})",  GetWeightsRange((int)e.Value));
        }

        private MlpNetwork _examinedNetwork;

        private Computed2DSeries _dataSeries = new Computed2DSeries();

        private NetworkResponseDrawableFunction _netFun =
            new NetworkResponseDrawableFunction();

        private ListDataSeries _neuronLines = new ListDataSeries();

        private Random _randomGenerator = new Random();

        private double GetWeightsRange(int rangeNumber)
        {
            return Math.Pow(10, rangeNumber/10.0);
        }

        private void CreateNetwork()
        {
            if (uiSuspendCreating.Checked)
                return;

            int layerCount = uiLayerCount.Value;
            int outputCount = uiOutputCount.Value;
            double weightsRange = GetWeightsRange(uiWeightsRange.Value);
            double topWeight = weightsRange / 2.0;
            double bottomWeight = topWeight - weightsRange;
            double biasWeightsRange = GetWeightsRange(uiBiasWeightsRange.Value);
            double bottomBiasWeight = -(biasWeightsRange / 2.0);

            int[] neuronCounts = new int[layerCount];
            for (int i = 0; i < neuronCounts.Length - 1; i++)
                neuronCounts[i] = layerCount;
            neuronCounts[neuronCounts.Length - 1] = outputCount;
            Type neuronType;
            switch (uiTransferFunctionType.SelectedIndex)
            {
                case 0: neuronType = typeof(BipolarNeuron); break;
                case 1: neuronType = typeof(UnipolarNeuron); break;
                case 2: neuronType = typeof(SigmoidalNeuron); break;
                case 3: neuronType = typeof(TanhNeuron); break;
                default: throw new InvalidOperationException();
            }

            _examinedNetwork = new MlpNetwork(2, true, neuronCounts, neuronType);
            _examinedNetwork.Randomize(_randomGenerator, bottomWeight, topWeight);
            if (uiDifferentBiasRange.Checked)
                foreach (Neuron n in _examinedNetwork.Layers[0])
                    n.Weights[n.Weights.Length - 1] =
                        bottomBiasWeight +
                        _randomGenerator.NextDouble() * biasWeightsRange;

            _netFun.NeuralNetwork = _examinedNetwork;
            _netFun.OutputOffset = 0.5;
            _netFun.OutputScale = 0.5;

            _netFun.OutputColors.Clear();
            for (int i = 0; i < outputCount; i++)
            {
                //{tga to paint only blue/red
                _netFun.OutputColors.Add(Color.FromArgb(255,0,0));
                //tga}

                //_netFun.OutputColors.Add(Color.FromArgb(
                //    _randomGenerator.Next(255),
                //    _randomGenerator.Next(255),
                //    _randomGenerator.Next(255)));
            }

            CreateNeuronLines();
        }

        private void CreateNeuronLines()
        {
            _neuronLines.Data.Clear();
            foreach (Neuron n in _examinedNetwork.Layers[0])
            {
                // The neuron weights denote an equation of form ax+by+c=0.
                double a = n.Weights[0];
                double b = n.Weights[1];
                double c = n.Weights[2];

                RectangleF vrect = uiChartPlotter.VisibleRectangle;

                // We need 2 points to draw a line.
                PointF[] points = new PointF[2];
                int currentPoint = 0;

                /* Let's calculate the potential y-coordinates of intersections
                 * with the left or right boundary. */
                double y = (-c - a * vrect.Left) / b;
                if (y >= vrect.Top && y <= vrect.Bottom)
                    points[currentPoint++] = new PointF(vrect.Left, (float)y);
                y = (-c - a * vrect.Right) / b;
                if (y >= vrect.Top && y <= vrect.Bottom)
                    points[currentPoint++] = new PointF(vrect.Right, (float)y);

                // If that's enough, don't bother to test other possibilities.
                if (currentPoint < 2)
                {
                    /* Let's calculate the potential x-coordinates of intersections
                     * with the top or bottom boundary. */
                    double x = (-c - b * vrect.Top) / a;
                    if (x >= vrect.Left && x <= vrect.Right)
                        points[currentPoint++] = new PointF((float)x, vrect.Top);
                    if (currentPoint < 2)
                    {
                        x = (-c - b * vrect.Bottom) / a;
                        if (x >= vrect.Left && x <= vrect.Right)
                            points[currentPoint++] = new PointF((float)x, vrect.Bottom);
                    }
                }

                // Finally, we add a new line to the data series.
                _neuronLines.Data.Add(points[0]);
                _neuronLines.Data.Add(points[1]);
            }
        }

        private void parameterChanged(object sender, EventArgs e)
        {
            CreateNetwork();
        }

        private void uiShowNeuronLines_CheckedChanged(object sender, EventArgs e)
        {
            if (uiShowNeuronLines.Checked)
                uiChartPlotter.DataSeries.Add(_neuronLines);
            else
                uiChartPlotter.DataSeries.Remove(_neuronLines);
        }

        private void uiSuspendCreating_CheckedChanged(object sender, EventArgs e)
        {
            uiCreateNewNetwork.Enabled = !uiSuspendCreating.Checked;
            if (!uiSuspendCreating.Checked)
                CreateNetwork();
        }

        private void uiDifferentBiasRange_CheckedChanged(object sender, EventArgs e)
        {
            if (uiDifferentBiasRange.Checked)
            {
                uiBiasWeightsRange.DataBindings.Remove(_weightsRangeBinding);
                uiBiasWeightsRange.Enabled = true;
            }
            else
            {
                uiBiasWeightsRange.DataBindings.Add(_weightsRangeBinding);
                uiBiasWeightsRange.Enabled = false;
                CreateNetwork();
            }
        }

        private void uiBrightnessScaling_CheckedChanged(object sender, EventArgs e)
        {
            _netFun.BrightnessScaling = uiBrightnessScaling.Checked;
        }
    }
}