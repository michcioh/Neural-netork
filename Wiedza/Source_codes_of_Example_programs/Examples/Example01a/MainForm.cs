using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example01a
{
    /// <summary>
    /// This is the main form class. It contains the most interesting parts
    /// of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The neuron that we are examining. This is a 2-input linear neuron.
        /// </summary>
        private Neuron _examinedNeuron = new Neuron(2);

        /// <summary>
        /// Creates a new main form and initializes its components.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method evaluates the object described by the user and shows
        /// the evaluation results.
        /// </summary>
        private void EvaluateObject()
        {
            /* First, we obtain the neuron parameters from the GUI controls.
             * We set the neuron weights according to them. */
            _examinedNeuron.Weights[0] = (double)uiWeightFragrant.Value;
            _examinedNeuron.Weights[1] = (double)uiWeightColorful.Value;

            // Now, we obtain the signal values and store them in an array.
            double[] signals = new double[]
            {
                (double)uiObjectFragrant.Value,
                (double)uiObjectColorful.Value
            };

            // Our ultimate target: compute the response using our neuron.
            double response = _examinedNeuron.Response(signals);

            /* Now we calculate the strength of neuron's memory trace. It's only
             * for purposes of determining if the neuron's response is strong enough
             * to be considered positive or negative. */
            double strength =
                _examinedNeuron.MemoryTraceStrength(StrengthNorm.Manhattan);

            /* Now, let's finally show the response using text and colors. First,
             * we determine the color and text needed. */
            string attitude;
            Color labelColor;
            if (Math.Abs(response) < 0.2 * strength)
            {
                attitude = "indifferent";
                labelColor = Color.DarkCyan;
            }
            else if (response < 0)
            {
                attitude = "negative";
                labelColor = Color.Blue;
            }
            else
            {
                attitude = "positive";
                labelColor = Color.Red;
            }

            /* And now, we put the text, color and numbers in appropriate places.
             * 10 digits should be enough to show the result. */
            uiOutput.Text = response.ToString("g10");
            uiAttitude.Text = attitude;
            uiAttitude.ForeColor = labelColor;
        }

        /// <summary>
        /// This method is called when the user changes any of the neuron's or input
        /// signals' parameters. It passes control to the <code>EvaluateObject</code>
        /// method.
        /// </summary>
        private void ParameterChanged(object sender, EventArgs e)
        {
            EvaluateObject();
        }

    }
}