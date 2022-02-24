using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example08a
{
    public partial class MainForm : Form
    {
        private SigmoidalNeuron neuron10 = new SigmoidalNeuron(3);
        private SigmoidalNeuron neuron11 = new SigmoidalNeuron(3);
        private SigmoidalNeuron neuron20 = new SigmoidalNeuron(3);
        private SigmoidalNeuron neuron21 = new SigmoidalNeuron(3);

        private int krok=0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (krok)
            {
                case 0:

                    double[] tablica = new double[3];

                    tablica[0] = float.Parse(waga100.Text);
                    tablica[1] = float.Parse(waga101.Text);
                    tablica[2] = float.Parse(waga102.Text);
                    Array.Copy(tablica, neuron10.Weights, tablica.Length);

                    tablica = new double[3];
                    tablica[0] = float.Parse(waga110.Text);
                    tablica[1] = float.Parse(waga111.Text);
                    tablica[2] = float.Parse(waga112.Text);
                    Array.Copy(tablica, neuron11.Weights, tablica.Length);

                    tablica = new double[3];
                    tablica[0] = float.Parse(waga200.Text);
                    tablica[1] = float.Parse(waga201.Text);
                    tablica[2] = float.Parse(waga202.Text);
                    Array.Copy(tablica, neuron20.Weights, tablica.Length);

                    tablica = new double[3];
                    tablica[0] = float.Parse(waga210.Text);
                    tablica[1] = float.Parse(waga211.Text);
                    tablica[2] = float.Parse(waga212.Text);
                    Array.Copy(tablica, neuron21.Weights, tablica.Length);

                  
                    waga100.ReadOnly = true;
                    waga101.ReadOnly = true;
                    waga102.ReadOnly = true;
                    waga110.ReadOnly = true;
                    waga111.ReadOnly = true;
                    waga112.ReadOnly = true;
                    waga200.ReadOnly = true;
                    waga201.ReadOnly = true;
                    waga202.ReadOnly = true;
                    waga210.ReadOnly = true;
                    waga211.ReadOnly = true;
                    waga212.ReadOnly = true;
                    wejscie00.ReadOnly = true;
                    wejscie01.ReadOnly = true;

            
                    wyjscie10.Text = "";
                    wejscie11.Text = "";
                    wyjscie11.Text = "";
                    wejscie20.Text = "";
                    wyjscie20.Text = "";
                    wejscie20.Text = "";
                    wyjscie21.Text = "";
                    wyjscie22.Text = "";
                    wyjscie23.Text = "";
                    wyjscie22.BackColor = Color.LightGray;
                    wyjscie23.BackColor = Color.LightGray;

                    wejscie10.Text = ((float.Parse(wejscie00.Text)) * neuron10.Weights[0] + (float.Parse(wejscie01.Text)) * neuron10.Weights[1] + (float.Parse(BIAS.Text)) * neuron10.Weights[2]).ToString();
                    wejscie10.BackColor = Color.LightCoral;
                    wyjscie21.BackColor = Color.LightGray;

                    krok++;
                    break;
                case 1:
                    wejscie11.Text = ((float.Parse(wejscie00.Text)) * neuron11.Weights[0] + (float.Parse(wejscie01.Text)) * neuron11.Weights[1] + (float.Parse(BIAS.Text)) * neuron11.Weights[2]).ToString();
                    wejscie10.BackColor = Color.LightGray;
                    wejscie11.BackColor = Color.LightCoral;
                    krok++;
                    break;
                case 2:
                    wyjscie10.Text = (neuron10.ActivationFunction(float.Parse(wejscie10.Text))).ToString();
                    wejscie11.BackColor = Color.LightGray;
                    wyjscie10.BackColor = Color.LightCoral;
                    krok++;
                    break;
                case 3:
                    wyjscie11.Text = (neuron11.ActivationFunction(float.Parse(wejscie11.Text))).ToString();
                    wyjscie10.BackColor = Color.LightGray;
                    wyjscie11.BackColor = Color.LightCoral;
                    krok++;
                    break;
                case 4:
                    wejscie20.Text = ((float.Parse(wyjscie10.Text)) * neuron20.Weights[0] + (float.Parse(wyjscie11.Text)) * neuron20.Weights[1] + (float.Parse(BIAS.Text)) * neuron20.Weights[2]).ToString();
                    wyjscie11.BackColor = Color.LightGray;
                    wejscie20.BackColor = Color.LightCoral;
                    krok++;
                    break;
                case 5:
                    wejscie21.Text = ((float.Parse(wyjscie10.Text)) * neuron21.Weights[0] + (float.Parse(wyjscie11.Text)) * neuron21.Weights[1] + (float.Parse(BIAS.Text)) * neuron21.Weights[2]).ToString();
                    wejscie20.BackColor = Color.LightGray;
                    wejscie21.BackColor = Color.LightCoral;
                    krok++;
                    break;
                case 6:
                    wyjscie20.Text = (neuron20.ActivationFunction(float.Parse(wejscie20.Text))).ToString();
                    wejscie21.BackColor = Color.LightGray;
                    wyjscie20.BackColor = Color.LightCoral;
                    krok++;
                    break;
                case 7:
                    wyjscie21.Text = (neuron21.ActivationFunction(float.Parse(wejscie21.Text))).ToString();
                    wyjscie20.BackColor = Color.LightGray;
                    wyjscie21.BackColor = Color.LightCoral;
                    krok++;
                    break;

                case 8:
                    wyjscie22.Text = wyjscie20.Text;
                    wyjscie23.Text = wyjscie21.Text;
                    wyjscie22.BackColor = Color.LightCoral;
                    wyjscie23.BackColor = Color.LightCoral;
                    wyjscie21.BackColor = Color.LightGray;
                    krok = 0;

                    waga100.ReadOnly = false;
                    waga101.ReadOnly = false;
                    waga102.ReadOnly = false;
                    waga110.ReadOnly = false;
                    waga111.ReadOnly = false;
                    waga112.ReadOnly = false;
                    waga200.ReadOnly = false;
                    waga201.ReadOnly = false;
                    waga202.ReadOnly = false;
                    waga210.ReadOnly = false;
                    waga211.ReadOnly = false;
                    waga212.ReadOnly = false;
                    wejscie00.ReadOnly = false;
                    wejscie01.ReadOnly = false;
                    break;
            }

        }

        
    }
}