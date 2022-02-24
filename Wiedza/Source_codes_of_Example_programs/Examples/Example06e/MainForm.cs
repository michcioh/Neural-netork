using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example06e
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            uiChartPlotter.VisibleRectangle =
                new RectangleF(-1.0f, -1.0f, 2.0f, 2.0f);
            _networkResponseFunction.NeuralNetwork = _examinedNetwork;
            _networkResponseFunction.OutputColors.Add(Color.Red);
            _networkDataSeries.FunctionObject = _networkResponseFunction;
            uiChartPlotter.DataSeries.Add(_networkDataSeries);
            uiChartPlotter.DataSeries.Add(_teachingSetDataSeries);
            UseStandardTeachingSet();
        }

        private TeachingSet _teachingSet;

        private PointDataSeries _teachingSetDataSeries = new PointDataSeries();

        private Computed2DSeries _networkDataSeries = new Computed2DSeries();

        private NetworkResponseDrawableFunction _networkResponseFunction =
            new NetworkResponseDrawableFunction();

        // Although the network consists of only one neuron, we use a network, not
        // a stand-alone neuron, because the network handles bias transparently.
        private MlpNetwork _examinedNetwork =
            new MlpNetwork(2, true, new int[] { 1 }, typeof(BipolarNeuron));

        private Random _randomGenerator = new Random();

        private int _stepNumber;

        private int StepNumber
        {
            get { return _stepNumber; }
            set
            {
                _stepNumber = value;
                uiStepNumber.Text = "Step number: " + _stepNumber.ToString();
            }
        }

        private void UseStandardTeachingSet()
        {
            /* We divide by 2, because each teaching set part takes half
             * of the gap size as its offset. */
            double offset = GetGapSize(uiGapSize.Value) / 2.0;
            _teachingSet = new TeachingSet(2, 1);
            TeachingSet.Element elem = new TeachingSet.Element();

            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    // Careful! We shouldn't make anything 0; it will render
                    // the element unuseful.
                    elem.Inputs =
                        new double[] { 0.2 + x * 0.2 + offset, -0.3 + y * 0.2 };
                    elem.ExpectedOutputs = new double[] { 1.0 };
                    _teachingSet.Add(elem);
                    elem.Inputs =
                        new double[] { -0.2 - x * 0.2 - offset, -0.3 + y * 0.2 };
                    elem.ExpectedOutputs = new double[] { -1.0 };
                    _teachingSet.Add(elem);
                }

            elem.Inputs = new double[] { offset, 0.3 };
            elem.ExpectedOutputs = new double[] { 1.0 };
            _teachingSet.Add(elem);
            elem.Inputs = new double[] { -offset, 0.3 };
            elem.ExpectedOutputs = new double[] { -1.0 };
            _teachingSet.Add(elem);

            ShowTeachingSet();
            RestartTeaching();
        }

        private void UseCustomTeachingSet()
        {
            if (uiOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                string fname = uiOpenFile.FileName;
                try
                {
                    TeachingSet tset = TeachingSet.FromFile(fname);
                    if (tset.Count == 0)
                    {
                        MessageBox.Show(this, "The file contains no usable data.",
                            Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        uiStandardSet.Checked = true;
                        return;
                    }
                    if (tset.InputCount != 2 || tset.OutputCount != 1)
                    {
                        MessageBox.Show(this,
                            "The file should be made for a 2-input, 1-output network.",
                            Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        uiStandardSet.Checked = true;
                        return;
                    }

                    _teachingSet = tset;
                    ShowTeachingSet();
                    RestartTeaching();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,
                        "Could not open the selected file.\n\nDetails: " + ex.Message,
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    uiStandardSet.Checked = true;
                }
            }
        }

        private double GetGapSize(int trackBarValue)
        {
            return trackBarValue / 100.0;
        }

        private void ShowTeachingSet()
        {
            _teachingSetDataSeries.Points.Clear();
            foreach (TeachingSet.Element elem in _teachingSet)
            {
                PointF pointLocation =
                    new PointF((float)elem.Inputs[0], (float)elem.Inputs[1]);
                int output = (int)((elem.ExpectedOutputs[0] + 1.0) * 127.5);
                Color pointColor = Color.FromArgb(output, output, output);
                PointDataSeries.ChartPoint chartPoint =
                    new PointDataSeries.ChartPoint(pointLocation, pointColor, false);
                _teachingSetDataSeries.Points.Add(chartPoint);
            }
        }

        private void RestartTeaching()
        {
            _examinedNetwork.Randomize(_randomGenerator, -1.0, 1.0, 0.001);
            StepNumber = 0;
            uiChartPlotter.Invalidate();
        }

        private void PerformTeachingCycle()
        {
            MlpNetwork.LearningMethod method =
                uiMethodWidrowHoff.Checked ? MlpNetwork.LearningMethod.WidrowHoff
                : MlpNetwork.LearningMethod.Perceptron;
            int stepCount = (int)uiCycleLength.Value;

            for (int i = 0; i < stepCount; i++)
            {
                int teachingElementIndex = _randomGenerator.Next(_teachingSet.Count);
                TeachingSet.Element teachingElement =
                    _teachingSet[teachingElementIndex];
                double[] prevResp = null;
                double[] prevErr = null;

                _examinedNetwork.LearnSimple(teachingElement, 0.1,
                        ref prevResp, ref prevErr, method);
            }

            StepNumber += stepCount;
            uiChartPlotter.Invalidate();
        }

        private void uiStandardSet_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = uiStandardSet.Checked;
            uiGapSize.Enabled = chk;
            UseStandardTeachingSet();
        }

        private void uiCustomSet_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = uiCustomSet.Checked;
            uiLoadFromFile.Enabled = chk;
            if (chk)
                UseCustomTeachingSet();
        }

        private void uiGapSize_Scroll(object sender, EventArgs e)
        {
            UseStandardTeachingSet();
            uiGapSizeLabel.Text =
                string.Format("({0:g2})", GetGapSize(uiGapSize.Value));
        }

        private void uiOneTeachingCycle_Click(object sender, EventArgs e)
        {
            PerformTeachingCycle();
        }

        private bool _stopTeaching = false;

        private void uiContinuousTeaching_CheckedChanged(object sender, EventArgs e)
        {
            if (uiContinuousTeaching.Checked)
            {
                _stopTeaching = false;
                while (!_stopTeaching)
                {
                    PerformTeachingCycle();
                    Application.DoEvents();
                }
            }
            else
                _stopTeaching = true;
        }

        private void uiRestartTeaching_Click(object sender, EventArgs e)
        {
            RestartTeaching();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _stopTeaching = true;
        }

        private void uiLoadFromFile_Click(object sender, EventArgs e)
        {
            UseCustomTeachingSet();
        }
    }
}