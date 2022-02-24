using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example06c
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            uiTransferFunctionType.SelectedIndex = 0;
            uiChartPlotter.VisibleRectangle = new RectangleF(
                (float)_xOffset, (float)_yOffset,
                (float)_xScale, (float)_yScale);
            _planeDataSeries.FunctionObject = _neuronResponseFunction;
            uiChartPlotter.DataSeries.Add(_pointDataSeries);
        }

        private const double _xScale = 20.0;

        private const double _xOffset = -10.0;

        private const double _yScale = 20.0;

        private const double _yOffset = -10.0;

        private NeuronResponseDrawableFunction _neuronResponseFunction =
            new NeuronResponseDrawableFunction();

        private PointDataSeries _pointDataSeries = new PointDataSeries();

        private Computed2DSeries _planeDataSeries = new Computed2DSeries();

        //{tga to eliminate DrawingLine from last point
        private int _lastchartPointIndexOf = -1;
        private double _lastchartPointX = 0.0;
        private double _lastchartPointY = 0.0;
        private Color _lastchartPointColor;
        //tga}

        private void CreateNeuron()
        {
            switch (uiTransferFunctionType.SelectedIndex)
            {
                case 0:
                    _neuronResponseFunction.Neuron = new BipolarNeuron(2);
                    break;
                case 1:
                    _neuronResponseFunction.Neuron = new UnipolarNeuron(2);
                    break;
                case 2:
                    _neuronResponseFunction.Neuron = new SigmoidalNeuron(2);
                    break;
                case 3:
                    _neuronResponseFunction.Neuron = new TanhNeuron(2);
                    break;
            }
            _neuronResponseFunction.Neuron.Weights[0] = (double)uiWeight1.Value;
            _neuronResponseFunction.Neuron.Weights[1] = (double)uiWeight2.Value;
            _pointDataSeries.Points.Clear();
        }

        private Random _random = new Random();

        private void ShowOnePoint()
        {
            //{tga to eliminate DrawingLine from last point
            if (_lastchartPointIndexOf >= 0)
            {
                _pointDataSeries.Points.RemoveAt(_lastchartPointIndexOf);

                PointDataSeries.ChartPoint chartPointLast =
                new PointDataSeries.ChartPoint(new PointF((float)_lastchartPointX, (float)_lastchartPointY),
                _lastchartPointColor, false);

                _pointDataSeries.Points.Add(chartPointLast);

            }
            //tga}

            double x = _random.NextDouble() * _xScale + _xOffset;
            double y = _random.NextDouble() * _yScale + _yOffset;
            Color color = _neuronResponseFunction.Compute(x, y);
            PointDataSeries.ChartPoint chartPoint =
                new PointDataSeries.ChartPoint(new PointF((float)x, (float)y),
                color, true);
            _pointDataSeries.Points.Add(chartPoint);
            
            //{tga to eliminate DrawingLine from last point
            _lastchartPointIndexOf = _pointDataSeries.Points.IndexOf(chartPoint);
            _lastchartPointX = x;
            _lastchartPointY = y;
            _lastchartPointColor = color;
            //tga}

            uiPointCoords.Text = String.Format("Point: ({0:g6}, {1:g6})", x, y);
            double originalResponse =
                _neuronResponseFunction.Neuron.Response(new double[] { x, y });
            uiResponse.Text = String.Format("Result: {0:g6}", originalResponse);
            uiResponse.ForeColor = color;
        }

        private void uiShowOnePoint_Click(object sender, EventArgs e)
        {
            uiChartPlotter.DataSeries[0] = _pointDataSeries;
            ShowOnePoint();
        }

        private void weightChanged(object sender, EventArgs e)
        {
            _neuronResponseFunction.Neuron.Weights[0] = (double)uiWeight1.Value;
            _neuronResponseFunction.Neuron.Weights[1] = (double)uiWeight2.Value;
            _pointDataSeries.Points.Clear();

            //{tga to eliminate DrawingLine from last point
            _lastchartPointIndexOf = -1;
            //tga}


            uiChartPlotter.Invalidate();
        }

        private void uiPointTimer_Tick(object sender, EventArgs e)
        {
            ShowOnePoint();
        }

        private void uiShowMultiplePoints_Click(object sender, EventArgs e)
        {
            uiChartPlotter.DataSeries[0] = _pointDataSeries;
            uiPointTimer.Enabled = true;
            uiShowOnePoint.Enabled = false;
            uiStopShowingPoints.Enabled = true;
            uiShowMultiplePoints.Enabled = false;
            uiShowEntirePlane.Enabled = false;
        }

        private void uiStopShowingPoints_Click(object sender, EventArgs e)
        {
            uiPointTimer.Enabled = false;
            uiShowOnePoint.Enabled = true;
            uiStopShowingPoints.Enabled = false;
            uiShowMultiplePoints.Enabled = true;
            uiShowEntirePlane.Enabled = true;
        }

        private void uiShowEntirePlane_Click(object sender, EventArgs e)
        {
            uiChartPlotter.DataSeries[0] = _planeDataSeries;
        }

        private void uiTransferFunctionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //{tga to eliminate DrawingLine from last point
            _lastchartPointIndexOf = -1;
            //tga}

            CreateNeuron();
        }
    }
}