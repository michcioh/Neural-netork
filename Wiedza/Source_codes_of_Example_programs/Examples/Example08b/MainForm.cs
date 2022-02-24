using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTadeusiewicz.NN.NeuralNetworks;

namespace RTadeusiewicz.NN.Example08b
{
    public partial class MainForm : Form
    {
        
        private SigmoidalNeuron neuron10 = new SigmoidalNeuron(3);
        private SigmoidalNeuron neuron11 = new SigmoidalNeuron(3);
        private SigmoidalNeuron neuron20 = new SigmoidalNeuron(3);
        private SigmoidalNeuron neuron21 = new SigmoidalNeuron(3);

        private int krok=0,iteracja=0,kroczek=100;
        private bool licz=false;
        private double[] inputSignals = new double[3];
        private double sigma_gradient10=0,sigma_gradient11=0,sigma20=0,sigma21=0;
        private double wspolczynnik_uczenia=0.7, wspolczynnik_momentum=0.3;

        private double[] signals = new double[3];
        private double[] prev_weights0 = new double[3];
        private double[] prev_weights1 = new double[3];
        private double[] prev_weights2 = new double[3];
        private double[] prev_weights3 = new double[3];
              
        private double response = 0, error_wagi10 = 0, error_wagi11 = 0, output_error1 = 0, output_error0 = 0;
        private double[] tablica;
    

        public MainForm()
        {
            InitializeComponent();
            
            tablica = new double[3];
            tablica[0] = 0.187;
            tablica[1] = 0.074;
            tablica[2] = 1.193;
            Array.Copy(tablica, neuron10.Weights, tablica.Length);

            tablica = new double[3];
            tablica[0] = -0.656;
            tablica[1] = -0.62;
            tablica[2] = -1.095;
            Array.Copy(tablica, neuron11.Weights, tablica.Length);

            tablica = new double[3];
            tablica[0] = -0.712;
            tablica[1] = 0.621;
            tablica[2] = 0.189;
            Array.Copy(tablica, neuron20.Weights, tablica.Length);

            tablica = new double[3];
            tablica[0] = 1.176;
            tablica[1] = -0.7;
            tablica[2] = 0.341;
            Array.Copy(tablica, neuron21.Weights, tablica.Length);


            waga100.Text = (neuron10.Weights[0]).ToString();
            waga101.Text = (neuron10.Weights[1]).ToString();
            waga102.Text = (neuron10.Weights[2]).ToString();

            waga110.Text = (neuron11.Weights[0]).ToString();
            waga111.Text = (neuron11.Weights[1]).ToString();
            waga112.Text = (neuron11.Weights[2]).ToString();

            waga200.Text = (neuron20.Weights[0]).ToString();
            waga201.Text = (neuron20.Weights[1]).ToString();
            waga202.Text = (neuron20.Weights[2]).ToString();

            waga210.Text = (neuron21.Weights[0]).ToString();
            waga211.Text = (neuron21.Weights[1]).ToString();
            waga212.Text = (neuron21.Weights[2]).ToString();

            inputSignals[0] = 2.584;
            inputSignals[1] = -0.845;
            inputSignals[2] = -1.0;
            wejscie00.Text = inputSignals[0].ToString();
            wejscie01.Text = inputSignals[1].ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            licz=true;
            button2_Click(sender,e);
        }

        /*
         * switch (kroczek)
                                {
                                    case 100:
                                        label27.Text = "Input weights";
                                        groupBox6.Visible = true;
                                        groupBox7.Visible = true;
                                        momentum.ReadOnly = true;
                                        wsp_uczenia.ReadOnly = true;
                                        kroczek++;
                                        break;

                                    case 101:
                                        label27.Text = "Presentation network";

                                        groupBox1.Visible = true;
                                        groupBox2.Visible = true;
                                        groupBox4.Visible = true;
                                        groupBox5.Visible = true;

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

                                        kroczek++;
                                        break;
                                    case 102:
                                        pole_iteracja.Visible = true;
                                        label8.Visible = true;
                                        kroczek++;
                                        break;

                                    case 103:

                                        label27.Text = "";
                                        kroczek = 100;
                                        break;

                                    } /// end swith kroczek
         * */


        private void button2_Click(object sender, EventArgs e)
        {
            label27.Text = "";

            
                    switch (krok)
                    {
                        case 0:
                            iteracja++;
                            pole_iteracja.Text = iteracja.ToString();
                            if (iteracja > 1)
                            
                            {
                                wspolczynnik_uczenia = float.Parse(wsp_uczenia.Text);
                                wspolczynnik_momentum = float.Parse(momentum.Text);

                                Random ran = new Random();

                                waga100.Text = waga100n.Text;
                                waga101.Text = waga101n.Text;
                                waga102.Text = waga102n.Text;

                                waga110.Text = waga110n.Text;
                                waga111.Text = waga111n.Text;
                                waga112.Text = waga112n.Text;

                                waga200.Text = waga200n.Text;
                                waga201.Text = waga201n.Text;
                                waga202.Text = waga202n.Text;

                                waga210.Text = waga210n.Text;
                                waga211.Text = waga211n.Text;
                                waga212.Text = waga212n.Text;

                                if (inputSignals[0] == double.Parse(wejscie00.Text) && inputSignals[1] == double.Parse(wejscie01.Text))
                                {
                                    inputSignals[0] = 5 * ran.NextDouble() - 2.5;
                                    inputSignals[1] = 5 * ran.NextDouble() - 2.5;
                                    inputSignals[2] = -1.0;
                                    wejscie00.Text = inputSignals[0].ToString();
                                    wejscie01.Text = inputSignals[1].ToString();
                                }


                            }

                            inputSignals[0] = double.Parse(wejscie00.Text);
                            inputSignals[1] = double.Parse(wejscie01.Text);

                            if (inputSignals[0] > 0)
                            {
                                poprawne20.Text = "1,0";
                                poprawne21.Text = "0,0";
                            }
                            else
                            {
                                poprawne20.Text = "0,0";
                                poprawne21.Text = "1,0";
                            }

                            waga100.ReadOnly = waga101.ReadOnly = waga102.ReadOnly = true;
                            waga110.ReadOnly = waga111.ReadOnly = waga112.ReadOnly = true;
                            waga200.ReadOnly = waga201.ReadOnly = waga202.ReadOnly = true;
                            waga210.ReadOnly = waga211.ReadOnly = waga212.ReadOnly = true;
                            wejscie00.ReadOnly = wejscie01.ReadOnly = true;
                            momentum.ReadOnly = true;
                            wsp_uczenia.ReadOnly = true;


                            wyjscie10.Text = "";
                            wejscie11.Text = wyjscie11.Text = "";
                            wejscie20.Text = wyjscie20.Text = "";
                            wejscie21.Text = wyjscie21.Text = "";

                            waga100n.Text = waga101n.Text = waga102n.Text = "";
                            waga110n.Text = waga111n.Text = waga112n.Text = "";
                            waga200n.Text = waga201n.Text = waga202n.Text = "";
                            waga210n.Text = waga211n.Text = waga212n.Text = "";

                            blad21wy.Text = blad21we.Text = blad20wy.Text = blad20we.Text = "";
                            blad11wy.Text = blad11we.Text = blad10wy.Text = blad10we.Text = "";
                            klasyfikacja.Text = "";


                            wejscie10.Text = ((float.Parse(wejscie00.Text)) * neuron10.Weights[0] + (float.Parse(wejscie01.Text)) * neuron10.Weights[1] + (float.Parse(bias0.Text)) * neuron10.Weights[2]).ToString();
                            wejscie10.BackColor = Color.Azure;
                            waga100n.BackColor = Color.LightGray;
                            waga101n.BackColor = Color.LightGray;
                            waga102n.BackColor = Color.LightGray;
                            waga110n.BackColor = Color.LightGray;
                            waga111n.BackColor = Color.LightGray;
                            waga112n.BackColor = Color.LightGray;
                            waga200n.BackColor = Color.LightGray;
                            waga201n.BackColor = Color.LightGray;
                            waga202n.BackColor = Color.LightGray;
                            waga210n.BackColor = Color.LightGray;
                            waga211n.BackColor = Color.LightGray;
                            waga212n.BackColor = Color.LightGray;

                            krok++;
                            if (licz == true)
                                goto case 1;
                            else break;
                        case 1:
                            wejscie11.Text = ((float.Parse(wejscie00.Text)) * neuron11.Weights[0] + (float.Parse(wejscie01.Text)) * neuron11.Weights[1] + (float.Parse(bias0.Text)) * neuron11.Weights[2]).ToString();
                            wejscie10.BackColor = Color.LightGray;
                            wejscie11.BackColor = Color.Azure;
                            krok++;
                            if (licz == true)
                                goto case 2;
                            else break;
                        case 2:
                            wyjscie10.Text = (neuron10.ActivationFunction(float.Parse(wejscie10.Text))).ToString();
                            wejscie11.BackColor = Color.LightGray;
                            wyjscie10.BackColor = Color.LightCoral;
                            krok++;
                            if (licz == true)
                                goto case 3;
                            else break;
                        case 3:
                            wyjscie11.Text = (neuron11.ActivationFunction(float.Parse(wejscie11.Text))).ToString();
                            wyjscie10.BackColor = Color.LightGray;
                            wyjscie11.BackColor = Color.LightCoral;
                            krok++;
                            if (licz == true)
                                goto case 4;
                            else break;
                        case 4:
                            signals[0] = float.Parse(wyjscie10.Text);
                            signals[1] = float.Parse(wyjscie11.Text);
                            signals[2] = inputSignals[2];

                            wejscie20.Text = ((float.Parse(wyjscie10.Text)) * neuron20.Weights[0] + (float.Parse(wyjscie11.Text)) * neuron20.Weights[1] + (float.Parse(bias0.Text)) * neuron20.Weights[2]).ToString();
                            wyjscie11.BackColor = Color.LightGray;
                            wejscie20.BackColor = Color.Azure;
                            krok++;
                            if (licz == true)
                                goto case 5;
                            else break;
                        case 5:
                            wejscie21.Text = ((float.Parse(wyjscie10.Text)) * neuron21.Weights[0] + (float.Parse(wyjscie11.Text)) * neuron21.Weights[1] + (float.Parse(bias0.Text)) * neuron21.Weights[2]).ToString();
                            wejscie20.BackColor = Color.LightGray;
                            wejscie21.BackColor = Color.Azure;
                            krok++;
                            if (licz == true)
                                goto case 6;
                            else break;
                        case 6:
                            wyjscie20.Text = neuron20.Response(signals).ToString();
                            wejscie21.BackColor = Color.LightGray;
                            wyjscie20.BackColor = Color.LightCoral;
                            krok++;
                            if (licz == true)
                                goto case 7;
                            else break;
                        case 7:
                            wyjscie21.Text = neuron21.Response(signals).ToString();
                            
                            wyjscie21.BackColor = Color.LightCoral;

                            Outputs.Visible = true;
                            wyjscie20a.Text = wyjscie20.Text;
                            wyjscie21a.Text = wyjscie21.Text;

                            krok++;
                            if (licz == true)
                                goto case 8;
                            else break;
                        case 8:
                            response = neuron21.Response(signals);
                            
                            poprawne21.Visible = true;
                            poprawne21.BackColor = Color.LightGreen;
                            label5.Visible = true;

                            output_error1 = double.Parse(poprawne21.Text) - response;
                            blad21wy.Text = output_error1.ToString();

                            wyjscie20.BackColor = Color.LightGray;
                            wyjscie21.BackColor = Color.LightGray;
                            blad21wy.BackColor = Color.LightCoral;
                            krok++;
                            if (licz == true)
                                goto case 9;
                            else break;
                            // algorytm back propagation, najpierw warstwy wyjœciowe:
                        case 9:
                            response = neuron20.Response(signals);
                            output_error0 = double.Parse(poprawne20.Text) - response;
                            blad20wy.Text = output_error0.ToString();

                            poprawne21.BackColor = Color.LightGray;

                            poprawne20.Visible = true;
                            poprawne20.BackColor = Color.LightGreen;
                            label4.Visible = true;


                            blad20wy.BackColor = Color.LightCoral;
                            blad21wy.BackColor = Color.LightGray;
                            krok++;
                            if (licz == true)
                                goto case 10;
                            else break;
                        case 10:
                            double error_sr = Math.Sqrt((output_error0 * output_error0 + output_error1 * output_error1) / 2);
                            blad.Text = error_sr.ToString();

                            poprawne20.BackColor = Color.LightGray;

                            blad.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            

                            if (Math.Abs(output_error0) > 0.5 | Math.Abs(output_error1) > 0.5)
                            {
                                klasyfikacja.Text = "BAD";
                                klasyfikacja.ForeColor = Color.Red;
                            }
                            else
                            {
                                klasyfikacja.Text = "GOOD";
                                klasyfikacja.ForeColor = Color.Green;
                            }


                            blad20wy.BackColor = Color.LightGray;
                            blad.BackColor = Color.LightCoral;
                            krok++;
                            if (licz == true)
                                goto case 11;
                            else break;
                        
                        case 11:
                            response = neuron21.Response(signals);
                            sigma21 = output_error1 * response * (1 - response);
                            blad21we.Text = sigma21.ToString();
                            blad21we.BackColor = Color.Azure;
                            blad.BackColor = Color.LightGray;
                            krok++;
                            if (licz == true)
                                goto case 12;
                            else break;
                        case 12:
                            response = neuron20.Response(signals);
                            sigma20 = output_error0 * response * (1 - response);
                            blad20we.Text = sigma20.ToString();
                            blad21we.BackColor = Color.LightGray;
                            blad20we.BackColor = Color.Azure;
                            krok++;
                            if (licz == true)
                                goto case 13;
                            else break;

                        case 13:
                            response = neuron11.Response(inputSignals);

                            error_wagi11 = sigma20 * neuron20.Weights[1] + sigma21 * neuron21.Weights[1];
                            blad11wy.Text = error_wagi11.ToString();

                            blad11wy.BackColor = Color.LightCoral;

                            krok++;
                            if (licz == true)
                                goto case 14;
                            else break;
                        case 14:
                            // algorytm back propagation, warstwy ukryte:

                            response = neuron10.Response(inputSignals);

                            error_wagi10 = sigma20 * neuron20.Weights[0] + sigma21 * neuron21.Weights[0];
                            blad10wy.Text = error_wagi10.ToString();

                            blad10wy.BackColor = Color.LightCoral;
                            blad11wy.BackColor = Color.LightGray;

                            krok++;
                            if (licz == true)
                                goto case 15;
                            else break;
                        case 15:

                            response = neuron11.Response(inputSignals);
                            sigma_gradient11 = error_wagi11 * response * (1 - response);
                            blad11we.Text = sigma_gradient11.ToString();
                            blad10wy.BackColor = Color.LightGray;
                            blad11we.BackColor = Color.Azure;
                           

                            krok++;
                            if (licz == true)
                                goto case 16;
                            else break;
                        case 16:


                            // ok
                            response = neuron10.Response(inputSignals);
                            sigma_gradient10 = error_wagi10 * response * (1 - response);
                            blad10we.Text = sigma_gradient10.ToString();
                            blad11we.BackColor = Color.LightGray;
                            blad10we.BackColor = Color.Azure;

                            krok++;
                            if (licz == true)
                                goto case 17;
                            else break;
                        case 17:
                            groupBox8.Visible = true;
                            groupBox9.Visible = true;
                            neuron10.Learn(inputSignals, prev_weights0, sigma_gradient10, wspolczynnik_uczenia, wspolczynnik_momentum);
                            waga100n.Text = (neuron10.Weights[0]).ToString();
                            waga101n.Text = (neuron10.Weights[1]).ToString();
                            waga102n.Text = (neuron10.Weights[2]).ToString();

                            waga110n.BackColor = Color.LightGray;
                            waga111n.BackColor = Color.LightGray;
                            waga112n.BackColor = Color.LightGray;

                            krok++;
                            
                            if (licz != true)
                            {
                                waga100n.BackColor = Color.LightCoral;
                                waga101n.BackColor = Color.LightCoral;
                                waga102n.BackColor = Color.LightCoral;
                            }
                            
                          
                            if (licz == true)
                                goto case 18;
                            else break;
                        case 18:
                            // ok
                            neuron11.Learn(inputSignals, prev_weights1, sigma_gradient11, wspolczynnik_uczenia, wspolczynnik_momentum);
                            waga110n.Text = (neuron11.Weights[0]).ToString();
                            waga111n.Text = (neuron11.Weights[1]).ToString();
                            waga112n.Text = (neuron11.Weights[2]).ToString();

                            blad10we.BackColor = Color.LightGray;

                            waga100n.BackColor = Color.LightGray;
                            waga101n.BackColor = Color.LightGray;
                            waga102n.BackColor = Color.LightGray;

                            waga110n.BackColor = Color.LightCoral;
                            waga111n.BackColor = Color.LightCoral;
                            waga112n.BackColor = Color.LightCoral;


                            krok++;
                            if (licz == true)
                                goto case 19;
                            else break;
                        case 19:


                            // ok
                            neuron20.Learn(signals, prev_weights2, sigma20, wspolczynnik_uczenia, wspolczynnik_momentum);
                            waga200n.Text = (neuron20.Weights[0]).ToString();
                            waga201n.Text = (neuron20.Weights[1]).ToString();
                            waga202n.Text = (neuron20.Weights[2]).ToString();

                            waga110n.BackColor = Color.LightGray;
                            waga111n.BackColor = Color.LightGray;
                            waga112n.BackColor = Color.LightGray;

                            waga200n.BackColor = Color.LightCoral;
                            waga201n.BackColor = Color.LightCoral;
                            waga202n.BackColor = Color.LightCoral;

                            krok++;
                            if (licz == true)
                                goto case 20;
                            else break;


                        case 20:

                            waga200n.BackColor = Color.LightGray;
                            waga201n.BackColor = Color.LightGray;
                            waga202n.BackColor = Color.LightGray;
                            

                            neuron21.Learn(signals, prev_weights3,sigma21, wspolczynnik_uczenia, wspolczynnik_momentum);
                            waga210n.Text = (neuron21.Weights[0]).ToString();
                            waga211n.Text = (neuron21.Weights[1]).ToString();
                            waga212n.Text = (neuron21.Weights[2]).ToString();

                            blad20we.BackColor = Color.LightGray;

                            if (licz != true)
                            {
                                waga210n.BackColor = Color.LightCoral;
                                waga211n.BackColor = Color.LightCoral;
                                waga212n.BackColor = Color.LightCoral;
                            }

                            krok = 0;
                            licz = false;

                            // /////
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
                            momentum.ReadOnly = false;
                            wsp_uczenia.ReadOnly = false;


                            prev_weights0[0] = float.Parse(waga100.Text);
                            prev_weights0[1] = float.Parse(waga101.Text);
                            prev_weights0[2] = float.Parse(waga102.Text);

                            prev_weights1[0] = float.Parse(waga110.Text);
                            prev_weights1[1] = float.Parse(waga111.Text);
                            prev_weights1[2] = float.Parse(waga112.Text);

                            prev_weights2[0] = float.Parse(waga200.Text);
                            prev_weights2[1] = float.Parse(waga201.Text);
                            prev_weights2[2] = float.Parse(waga202.Text);

                            prev_weights3[0] = float.Parse(waga210.Text);
                            prev_weights3[1] = float.Parse(waga211.Text);
                            prev_weights3[2] = float.Parse(waga212.Text);

                            break;

                            
                    } /// end switch krok

                    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void waga112_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void waga102_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            switch (kroczek)
            {
                case 100:
                    button3.Text = "Intro";
                    label27.Text = "Presentation of network";
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox4.Visible = true;
                    groupBox5.Visible = true;

                    bias1.Visible = true;
                    label2.Visible = true;
                    bias0.Visible = true;
                    label3.Visible = true;

                    kroczek++;
                    break;

                case 101:
                    label27.Text = "Input weights";

                    groupBox6.Visible = true;
                    groupBox7.Visible = true;
                    momentum.ReadOnly = true;
                    wsp_uczenia.ReadOnly = true;

                    kroczek++;
                    break;

                case 102:
                    label27.Text = "Input signals";

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

                    groupBox3.Visible = true;
                    
                    pole_iteracja.Visible = true;
                    label8.Visible = true;
                    kroczek++;
                    break;

                case 103:

                    label27.Text = "Click next step or iteration";
                    button3.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;

                    this.AcceptButton = button2;

                    kroczek++;
                    break;
               


            }
        }

        /* Do uzycia kiedys
        private void button4_Click(object sender, EventArgs e)
        {

            //data
            krok=0;
            iteracja = 1;
            kroczek = 100;
            pole_iteracja.Text = iteracja.ToString();

            wspolczynnik_uczenia = 0.7; 
            wspolczynnik_momentum = 0.3;
            wspolczynnik_uczenia = float.Parse(wsp_uczenia.Text);
            wspolczynnik_momentum = float.Parse(momentum.Text);
            wsp_uczenia.Text = "0,700";
            momentum.Text="0,300";



            tablica = new double[3];
            tablica[0] = 0.187;
            tablica[1] = 0.074;
            tablica[2] = 1.193;
            Array.Copy(tablica, neuron10.Weights, tablica.Length);

            tablica = new double[3];
            tablica[0] = -0.656;
            tablica[1] = -0.62;
            tablica[2] = -1.095;
            Array.Copy(tablica, neuron11.Weights, tablica.Length);

            tablica = new double[3];
            tablica[0] = -0.712;
            tablica[1] = 0.621;
            tablica[2] = 0.189;
            Array.Copy(tablica, neuron20.Weights, tablica.Length);

            tablica = new double[3];
            tablica[0] = 1.176;
            tablica[1] = -0.7;
            tablica[2] = 0.341;
            Array.Copy(tablica, neuron21.Weights, tablica.Length);


            waga100.Text = (neuron10.Weights[0]).ToString();
            waga101.Text = (neuron10.Weights[1]).ToString();
            waga102.Text = (neuron10.Weights[2]).ToString();

            waga110.Text = (neuron11.Weights[0]).ToString();
            waga111.Text = (neuron11.Weights[1]).ToString();
            waga112.Text = (neuron11.Weights[2]).ToString();

            waga200.Text = (neuron20.Weights[0]).ToString();
            waga201.Text = (neuron20.Weights[1]).ToString();
            waga202.Text = (neuron20.Weights[2]).ToString();

            waga210.Text = (neuron21.Weights[0]).ToString();
            waga211.Text = (neuron21.Weights[1]).ToString();
            waga212.Text = (neuron21.Weights[2]).ToString();

            inputSignals[0] = 2.584;
            inputSignals[1] = -0.845;
            inputSignals[2] = -1.0;
            wejscie00.Text = inputSignals[0].ToString();
            wejscie01.Text = inputSignals[1].ToString();

            //show

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;

                 maskedTextBox1.Visible = false;
                 label2.Visible = false;
                 BIAS.Visible = false;
                 label3.Visible = false;

                 groupBox6.Visible = false;
                 groupBox7.Visible = false;

                 pole_iteracja.Visible = false;
                 label8.Visible = false;
                 groupBox3.Visible = false;

                 button3.Visible = true;
                 button1.Visible = false;
                 button2.Visible = false;
                        

        } */

        
    }
}