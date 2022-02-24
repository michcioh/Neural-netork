using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.Controls;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example12a
{
    public partial class MainForm : Form
    {
        private Neuron _examinedNeuron = new Neuron(2);
        private int TeachingStep = 0;
        private double Response = 0.0;
        //private int New_Simulation = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void EvaluateObject()
        {
            _examinedNeuron.Weights[0] = (double) 1.0;
            _examinedNeuron.Weights[1] = (double)uiFeedbackWeight.Value;

            double[] inputs = new double[]
            {
                (double)uiInputSignalStrength.Value,
                (double)Response
            };

            if ( SingleInputImpulsCheckBox1.Checked && (TeachingStep > 0) )
                inputs[0] = 0.0;

            Response = _examinedNeuron.Response(inputs);
            TeachingStep++;

            

            string Response_text;
            string Response_text_pom;
            //Response_text_pom = Response.ToString("e7").PadLeft(9) ;
            Response_text_pom = Response.ToString("f6");
            Response_text = String.Format("i={0,3}   y= {1,13}\n", TeachingStep, Response_text_pom);
            

            richTextBox1.AppendText(Response_text);
                       
        }


        private void Continue_button_Click(object sender, EventArgs e)
        {
            EvaluateObject();
        }

        private void StartNew_button_Click(object sender, EventArgs e)
        {
            Response = 0.0;
            TeachingStep = 0;
            richTextBox1.Clear();
            EvaluateObject();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Response = 0.0;
            TeachingStep = 0;
            uiFeedbackWeight.Value = 0;
            uiInputSignalStrength.Value = 0;
            richTextBox1.Clear();
        }

        private void uiFeedbackWeight_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}