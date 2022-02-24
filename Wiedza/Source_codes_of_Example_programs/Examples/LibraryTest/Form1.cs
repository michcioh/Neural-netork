using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace LibraryTest
{
    public partial class Form1 : Form
    {
        // The parametrized cosine function class.
        private class CosineFunction : ComputedDataSeries.ParametrizedFunction
        {
            private double _scale = 1.0;

            public double Scale
            {
                get { return _scale; }
                set
                {
                    _scale = value;
                    RefreshView();
                }
            }

            public override double Compute(double arg)
            {
                return Math.Cos(arg) * _scale;
            }
        }

        private CosineFunction cosFun = new CosineFunction();

        private NetworkResponseDrawableFunction netFun =
            new NetworkResponseDrawableFunction();

        private ListDataSeries _neuronLines = new ListDataSeries();

        private HistoryDataSeries _historyLines1 = new HistoryDataSeries();
        private HistoryDataSeries _historyLines2 = new HistoryDataSeries();

        public Form1()
        {
            InitializeComponent();

            // Initialize the point chart.
            PointDataSeries pds = new PointDataSeries();
            chartPlotter1.DataSeries.Add(pds);
            chartPlotter1.VisibleRectangle = new RectangleF(-0.5f, -0.5f,
                1.0f, 1.0f);

            // Initialize the "precomputed" linear function.
            ListDataSeries ds = new ListDataSeries(100);
            for (int i = 0; i < 100; i++)
            {
                float x = i / 10f - 5f;
                ds.Data.Add(new PointF(x, -x));
            }
            ds.ForeColor = Color.Red;
            chartPlotter2.DataSeries.Add(ds);

            // Initialize the "precomputed" sine function.
            ds = new ListDataSeries(20);
            ds.LineWidth = 2.0f;
            for (int i = 0; i < 20; i++)
            {
                float x = i / 2.0f;
                ds.Data.Add(new PointF(x, 9 * (float)Math.Sin(x)));
            }
            ds.ForeColor = Color.Blue;
            chartPlotter2.DataSeries.Add(ds);

            // Initialize the linear function.
            ComputedDataSeries ds2 = new ComputedDataSeries();
            ds2.LineWidth = 3.0f;
            ds2.Function = delegate(double x)
            {
                return x;
            };
            ds2.ForeColor = Color.Green;
            chartPlotter2.DataSeries.Add(ds2);

            // Initialize the parametrized cosine function.
            ds2 = new ComputedDataSeries();
            ds2.FunctionObject = cosFun;
            ds2.AntiAlias = true;
            chartPlotter2.DataSeries.Add(ds2);

            // Initialize some plots under the 2D surface.
            ds2 = new ComputedDataSeries();
            ds2.Function = delegate(double arg)
            {
                return Math.Sin(arg) * 5.0;
            };
            ds2.LineWidth = 2;
            ds2.AntiAlias = true;
            //chartPlotter3.DataSeries.Add(ds2);

            // Initialize the 2D surface.
            Computed2DSeries ds3 = new Computed2DSeries();
            /*ds3.Function = delegate(double x, double y)
            {
                return Color.FromArgb(
                    (int)((Math.Cos(x / 2.0) + 1.0) * 127.5),
                    (int)(Math.Abs(Math.Sin(x + y)) * 255.0),
                    (int)(Math.Abs(Math.Sin(x - y)) * 255.0),
                    (int)(Math.Abs(Math.Sin(y)) * 255.0));
            };*/
            ds3.Function = delegate(double x, double y)
            {
                double x0 = x, y0 = y;
                double x2, y2;
                int i = 255;

                while ((x2 = x * x) + (y2 = y * y) < 100.0 && i > 0)
                {
                    double xnew = x2 - y2 + x0;
                    double ynew = 2 * x * y + y0;
                    x = xnew;
                    y = ynew;
                    i--;
                }

                return Color.FromArgb(i, i, i);
            };
            chartPlotter3.DataSeries.Add(ds3);
            chartPlotter3.VisibleRectangle = new RectangleF(-2f, -2f, 4f, 4f);

            // Initialize the network response function.
            CreateNetwork();
            ds3 = new Computed2DSeries();
            ds3.FunctionObject = netFun;
            netFun.OutputOffset = 0.5;
            netFun.OutputScale = 0.5;
            netFun.NeuralNetwork = _network;
            chartPlotter4.DataSeries.Add(ds3);
            chartPlotter4.VisibleRectangle = new RectangleF(-1.0f, -1.0f, 2.0f, 2.0f);

            _neuronLines.ForeColor = Color.White;
            _neuronLines.ContinuousLine = false;

            // Initialize the history plotter.
            chartPlotter5.DataSeries.Add(_historyLines1);
            chartPlotter5.DataSeries.Add(_historyLines2);
            _historyLines1.ForeColor = Color.Blue;
            _historyLines1.StepLengthMode = HistoryDataSeries.LengthMode.Screen;
            _historyLines1.StepLength = 2.0f;
            _historyLines2.ForeColor = Color.Red;
            _historyLines2.StepLength = 0.5f;
        }

        private static Random randGen = new Random();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PointDataSeries ds = chartPlotter1.DataSeries[0] as PointDataSeries;
            while (ds.Points.Count > trackBar1.Value)
                ds.Points.RemoveAt(ds.Points.Count - 1);
            while (ds.Points.Count < trackBar1.Value)
            {
                PointF coords = new PointF(
                    (float)randGen.NextDouble() - 0.5f,
                    (float)randGen.NextDouble() - 0.5f);
                Color col = Color.FromArgb(
                    randGen.Next(256),
                    randGen.Next(256),
                    randGen.Next(256));
                PointDataSeries.PointShape shape = randGen.Next(2) > 0 ?
                    PointDataSeries.PointShape.Circle :
                    PointDataSeries.PointShape.Square;
                ds.Points.Add(new PointDataSeries.ChartPoint(
                    coords, col, true, shape));
            }
        }

        private int tickCounter = 0;

        // This method performs some animations.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                // Animate the points.
                PointDataSeries ds = chartPlotter1.DataSeries[0] as PointDataSeries;
                for (int i = 0; i < ds.Points.Count; i++)
                {
                    PointDataSeries.ChartPoint s = ds.Points[i];
                    s.Coords.X += (float)((randGen.NextDouble() - 0.5) / 100.0);
                    s.Coords.Y += (float)((randGen.NextDouble() - 0.5) / 100.0);
                    ds.Points[i] = s;
                }
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {
                // Animate the cosine function.
                if (++tickCounter == 100)
                    tickCounter = 0;
                cosFun.Scale = Math.Sin(tickCounter / 50.0 * Math.PI) * 2.0 + 3.0;
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                if (checkBox3.Checked)
                    MakeNoise();
            }
        }

        private MlpNetwork _network;

        private Random _randomGenerator = new Random();

        private void CreateNetwork()
        {
            int[] neuronCounts = new int[trackBar3.Value];
            for (int i = 0; i < neuronCounts.Length - 1; i++)
                neuronCounts[i] = trackBar3.Value;
            neuronCounts[neuronCounts.Length - 1] = trackBar2.Value;
            _network = new MlpNetwork(2, true, neuronCounts,
                checkBox2.Checked ? typeof(SigmoidalNeuron) : typeof(BipolarNeuron));
            if (checkBox2.Checked)
                foreach (Neuron[] layer in _network.Layers)
                    foreach (Neuron n in layer)
                        ((SigmoidalNeuron)n).Beta = 100.0;
            _network.Randomize(_randomGenerator, -10.0, 10.0);
            /*foreach (Neuron n in _network.Layers[0])
                n.Weights[n.Weights.Length - 1] =
                    _randomGenerator.NextDouble() * 20.0 - 10.0;*/
            netFun.NeuralNetwork = _network;
            netFun.OutputColors.Clear();
            if (trackBar2.Value == 2)
            {
                netFun.OutputColors.Add(Color.Red);
                netFun.OutputColors.Add(Color.Green);
            }
            else
                for (int i = 0; i < trackBar2.Value; i++)
                {
                    netFun.OutputColors.Add(Color.FromArgb(
                        _randomGenerator.Next(255),
                        _randomGenerator.Next(255),
                        _randomGenerator.Next(255)));
                }

            _neuronLines.Data.Clear();
            foreach (Neuron n in _network.Layers[0])
            {
                double a = n.Weights[0];
                double b = n.Weights[1];
                double c = n.Weights[2];
                RectangleF vrect = chartPlotter4.VisibleRectangle;
                PointF[] points = new PointF[2];
                int currentPoint = 0;
                double y = (-c - a * vrect.Left) / b;
                if (y >= vrect.Top && y <= vrect.Bottom)
                    points[currentPoint++] = new PointF(vrect.Left, (float)y);
                y = (-c - a * vrect.Right) / b;
                if (y >= vrect.Top && y <= vrect.Bottom)
                    points[currentPoint++] = new PointF(vrect.Right, (float)y);
                if (currentPoint < 2)
                {
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
                _neuronLines.Data.Add(points[0]);
                _neuronLines.Data.Add(points[1]);
                /*_neuronLines.Data.Add(new PointF(i / 10f, i / 10f));
                _neuronLines.Data.Add(new PointF(i / 10f + 0.1f, i / 10f));*/
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            CreateNetwork();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            CreateNetwork();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNetwork();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                chartPlotter4.DataSeries.Add(_neuronLines);
            else
                chartPlotter4.DataSeries.Remove(_neuronLines);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CreateNetwork();
        }

        private void MakeNoise()
        {
            _historyLines1.Buffer.Add((float)(randGen.NextDouble() * 10.0 - 5.0));
            _historyLines2.Buffer.Add((float)(randGen.NextDouble() * 10.0 - 5.0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeNoise();
        }

        private void chartPlotter3_MouseClick(object sender, MouseEventArgs e)
        {
            RectangleF rect = chartPlotter3.VisibleRectangle;
            PointF p = chartPlotter3.Screen2Space(e.Location);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    rect.Inflate(-0.2f * rect.Width, -0.2f * rect.Height);
                    break;
                case MouseButtons.Right:
                    rect.Inflate(0.2f * rect.Width, 0.2f * rect.Height);
                    break;
            }
            rect.X = p.X - rect.Width / 2.0f;
            rect.Y = p.Y - rect.Height / 2.0f;
            chartPlotter3.VisibleRectangle = rect;
        }

    }
}