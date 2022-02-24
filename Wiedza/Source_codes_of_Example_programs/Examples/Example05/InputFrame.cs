using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using RTadeusiewicz.NN.Controls;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example05
{
    /* 
     * This is the class of program's frame to input data.
     * It supplies interface to setup the network. 
     *
     */  
    public partial class InputFrame : Form
    {
        /* signal preparing class */
        private SignalPrepare prep;

        /* reference to the main (SignalFilter) class's instance */
        private SignalFilter filter;

        /* network's size (number of neurons) */
        private int size;        

        /* signal's noise level */
        private double noise;

        /* signal's frequency */
        private double freq;

        /* number of teaching steps */
        private int stepsNr;

        /* constructor*/
        public InputFrame(SignalFilter filter)
        {
            /* get the reference to the main class's instance */
            this.filter = filter;               
            InitializeComponent();            
        }
                
        /* accepts/rejects entered data */
        private void accept_Click(object sender, EventArgs e)
        {        
            /* validating input */
            try
            {
                size = Int32.Parse(netSizeTextBox.Text);
                if (size < 2 || size > 10000)
                {
                    MessageBox.Show("Enter network size, range [2,10000]",
                                     "Data Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    netSizeTextBox.Clear();
                    netSizeTextBox.Focus();
                    return;
                }
            }
            catch(FormatException fE)
            {
                MessageBox.Show("Wrong network size! ",
                                "Data Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                netSizeTextBox.Clear();
                netSizeTextBox.Focus();
                return;
             
            }
            
            try{
                try
                {
                    noise = Double.Parse(noiseLevelTextBox.Text);
                }
                catch (OverflowException oE)
                {
                    MessageBox.Show("Noise level too high!",
                                   "Data Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    stepsNrTextBox.Clear();
                    stepsNrTextBox.Focus();
                    return;
                }
                if (noise < 0)
                    throw new FormatException();
            }
            catch(FormatException fE)
            {
                MessageBox.Show("Noise level incorrect!",
                                "Data Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                noiseLevelTextBox.Clear();
                noiseLevelTextBox.Focus();
                return;             
            }
            try
            {
                try
                {
                    freq = Double.Parse(freqTextBox.Text);
                }
                catch (OverflowException oE)
                {
                    MessageBox.Show("Number of frequencies too high!",
                                    "Data Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    stepsNrTextBox.Clear();
                    stepsNrTextBox.Focus();
                    return;
                }
                if (freq < 0)
                    throw new FormatException();
            }
            catch (FormatException fE) 
            {
                MessageBox.Show("Wrong frequency!",
                                "Data Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                freqTextBox.Clear();
                freqTextBox.Focus();
                return;             
            }
            try
            {
                try
                {
                    stepsNr = Int32.Parse(stepsNrTextBox.Text);
                }
                catch (OverflowException oE)
                {
                    MessageBox.Show("Number of steps too high!",
                                    "Data Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    stepsNrTextBox.Clear();
                    stepsNrTextBox.Focus();
                    return;
                }

                if (stepsNr < 0)
                    throw new FormatException();
            }
            catch (FormatException fE)
            {
                MessageBox.Show("Incorrect number of steps!",
                                "Data Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);                           
                stepsNrTextBox.Clear();
                stepsNrTextBox.Focus();
                return;
            }    
        
            /* preparing the data file */
            prep = new SignalPrepare(size, noise, freq);
            
            /* updating referenced instance of SignalFilter class */
            filter.store(size, noise, freq, prep.createWeights(), stepsNr);
           
            /* initializing the network */
            filter.init();
            
            /* unlocking the main frame */
            filter.activateMain(false,true);
            
            this.Hide();              
        }

        /* switches input data to default values */
        private void defaults_Click(object sender, EventArgs e)
        {
            netSizeTextBox.Text = "500";
            noiseLevelTextBox.Text = "0,5";
            freqTextBox.Text = "0,02";
            stepsNrTextBox.Text = "50";
        }

        /* aborts input and hides dialog */
        private void cancel_Click(object sender, EventArgs e)
        {
            filter.activateMain(false,false);
            this.Hide();
        }

        /* closing the dialog */
        private void InputFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            filter.activateMain(true,false);            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InputFrame_Load(object sender, EventArgs e)
        {

        }
        
    }
}
