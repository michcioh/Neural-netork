using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using System.Drawing;

namespace RTadeusiewicz.NN.Controls
{
    public class NeuronResponseDrawableFunction : Computed2DSeries.ParametrizedFunction
    {

        private Neuron _neuron;

        public Neuron Neuron
        {
            get { return _neuron; }
            set
            {
                _neuron = value;
                RefreshView();
            }
        }

        private Color myVar;

        public Color MyProperty
        {
            get { return myVar; }
            set
            {
                myVar = value;
                RefreshView();
            }
        }

        public override Color Compute(double x, double y)
        {
            /*double result = _neuron.Response(new double[] { x, y });
            if (result > 0.5)
            {
                int iResult = (int)((1.0 - result) * 510.0);
                return Color.FromArgb(255, iResult, 0);
            }
            else if (result >= 0.0)
            {
                int iResult = (int)(510.0 * result);
                return Color.FromArgb(iResult, 255, 0);
            }
            else
            {
                int iResult = 255 + (int)(255.0 * result);
                return Color.FromArgb(iResult, iResult, 255);
            }*/
            double result = (_neuron.Response(new double[] { x, y }) + 1.0) * 127.5;
            int iResult = (int)result;
            return Color.FromArgb(iResult, 0, 255 - iResult);
        }
    }
}
