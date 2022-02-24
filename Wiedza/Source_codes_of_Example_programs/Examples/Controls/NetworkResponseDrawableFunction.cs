using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using System.Drawing;

namespace RTadeusiewicz.NN.Controls
{
    public class NetworkResponseDrawableFunction : Computed2DSeries.ParametrizedFunction
    {
        public NetworkResponseDrawableFunction()
        {
            _outputColors.Change += new EventHandler(_outputColors_Change);
        }

        void _outputColors_Change(object sender, EventArgs e)
        {
            RefreshView();
        }

        private MlpNetwork _neuralNetwork;

        public MlpNetwork NeuralNetwork
        {
            get { return _neuralNetwork; }
            set
            {
                _neuralNetwork = value;
                RefreshView();
            }
        }

        private double _outputScale = 1.0;

        public double OutputScale
        {
            get { return _outputScale; }
            set
            {
                _outputScale = value;
                RefreshView();
            }
        }

        private double _outputOffset = 0.0;

        public double OutputOffset
        {
            get { return _outputOffset; }
            set
            {
                _outputOffset = value;
                RefreshView();
            }
        }

        private NotifyingList<Color> _outputColors = new NotifyingList<Color>();

        public NotifyingList<Color> OutputColors
        {
            get { return _outputColors; }
        }

        private bool _brightnessScaling;

        public bool BrightnessScaling
        {
            get { return _brightnessScaling; }
            set
            {
                _brightnessScaling = value;
                RefreshView();
            }
        }

        private int ClampColorValue(double value)
        {
            int result = (int)Math.Round(value);
            if (result < 0)
                result = 0;
            else if (result > 255)
                result = 255;
            return result;
        }

        public override Color Compute(double x, double y)
        {
            double[] response = _neuralNetwork.Response(new double[] { x, y });
            if (response.Length > _outputColors.Count)
                throw new InvalidOperationException(
                    "The number of outputs is greater than the number of colors.");
            double red = 0.0, green = 0.0, blue = 0.0, alpha = 0.0;
            for (int i = 0; i < response.Length; i++)
            {
                double scaledResult = response[i] * _outputScale + _outputOffset;
                red += _outputColors[i].R * scaledResult;
                green += _outputColors[i].G * scaledResult;
                blue += _outputColors[i].B * scaledResult;
                alpha += _outputColors[i].A * scaledResult;
            }

            if (_brightnessScaling)
            {
                red /= response.Length;
                green /= response.Length;
                blue /= response.Length;
                alpha /= response.Length;
            }

            return Color.FromArgb(
                ClampColorValue(alpha),
                ClampColorValue(red),
                ClampColorValue(green),
                ClampColorValue(blue)
                );
        }
    }
}
