using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example05
{

    /* 
     * This is the class of program's main frame.
     * It includes the graph plotter and supplies 
     * main user interface.
     *
     */  
    public partial class MainFrame : Form
    {        
        /* dialog for data input */
        private InputFrame input;

        /* disable combo boxes during simulation */
        private const int DEACTIVATE = 0;

        /* enable combo boxes after simulation */
        private const int ACTIVATE = 1;

        /* prepare clean and noisy display data */
        private const int CLEAN_AND_NOISY = 2;

        /* prepare computed display data */
        private const int COMPUTED = 3;
                
        /* instance of the program's main class */
        private SignalFilter filter;
        
        /* series of points - noisy signal */
        private ListDataSeries dataNoisy = null;
        
        /* series of points - clean signal */
        private ListDataSeries dataClean = null;
        
        /* series of points - computed signal */
        private ListDataSeries dataProcessed = null;
        
        /* simulation mode - auto/manual */
        private int simModeVal;
        
        /* simulation case - with/without shift of signal */
        private int chosenCaseVal;
        
        /* weights mode - standard/medium */
        private int weightsVal;
        
        /* logical coordinates' increasement */
        private float step;
        
        /* number of teaching steps */
        private int stepsNr;
        
        /* size of network - number of neurons */
        private int netSize;
        
        /* manual mode ready/not ready */
        private bool ready;

        /* simulation is/is not in progress */
        private bool simInProgress;
        
        /* the first simulation */
        private bool initial;

        /* display set/reset */
        private bool reseted;

        /* signal is/is not shifted */
        private bool shifted;

        /* indexing variable */
        private int index = 0;

        /* progess indicator's label */
        private String stepNrString;
     
        /* constructor */
        public MainFrame(SignalFilter filter)
        {           
            InitializeComponent();
            this.filter = filter;            
            stepNrString = stepNr.Text;                               
            simModeCombo.SelectedIndex = 0;
            chosenCaseCombo.SelectedIndex = 0;
            weightsCombo.SelectedIndex = 0;
            netSize = 0;
            ready = false;
            simInProgress = false;
            initial = true;
            reseted = false;
            shifted = false;
            dataNoisy = new ListDataSeries(netSize);
            dataNoisy.LineWidth = 2f;
            dataNoisy.ForeColor = Color.DarkGray;
            dataNoisy.AntiAlias = true;
            dataClean = new ListDataSeries(netSize);
            dataClean.LineWidth = 2f;
            dataClean.ForeColor = Color.Green;
            dataClean.AntiAlias = true;
            dataProcessed = new ListDataSeries(netSize);
            dataProcessed.LineWidth = 2f;
            dataProcessed.ForeColor = Color.Blue;
            dataProcessed.AntiAlias = true;
        }

        /* called when new network is created */
        public void refresh(SignalFilter filter, bool netRefresh)
        {                        
            if(netRefresh) /* network has changed */
            {
                this.filter = filter;                                          
                netSize = filter.getValue(SignalFilter.SIZE);
                stepsNr = filter.getValue(SignalFilter.STEPS);
                step = 20f / (float)(netSize - 1);
                /* setup display data */
                prepareDisplayData(CLEAN_AND_NOISY);
            }
            input = filter.getInput();
        }

        /* next step in manual mode */
        private void next_Click(object sender, EventArgs e)
        {
            if (ready) /* simulation started */
            {
                /* manual mode has been started */
                if (index <= stepsNr)
                {                                        
                    learningStep(index);                   
                    progressBar1.Value += 1;                    
                    index++;              
                    if (index == stepsNr + 1)
                    {
                        /* end of simulation */
                        index = 0;                     
                        ready = false;
                        simInProgress = false;
                        comboOnOff(ACTIVATE);
                    }
                }
            }
            else
                /* manual mode has not been started yet */
                return;
        }
        
        /* simulation start */
        private void start_Click(object sender, EventArgs e)
        {
            if (!filter.isLoaded()) /* network has not been created */
            {
                MessageBox.Show("Network not created!",
                                "Network error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (simInProgress) /* simulation is running */
            {
                MessageBox.Show("Simulation already started",
                                "Simulation started",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else
            {                
                if (initial) /* this is the first simulation */
                {                    
                    initial = false;
                    if (reseted) /* program is in the 'reset' state */ 
                        reseted = false;
                }
                else /* this is not the first simulation */
                {
                    if (!reseted) /* program is not in the 'reset' state */
                    {
                        /* this is not the first simulation - displayed data may be lost */
                        DialogResult result = MessageBox.Show("New simulation starts. Recent results will be overwritten",
                                                              "Continue?",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            return;
                        else /* restarting simulation */
                        {
                            plotArea.DataSeries.Remove(dataProcessed);
                            if (plotArea.DataSeries.Contains(dataClean))
                                plotArea.DataSeries.Remove(dataClean);
                            if (plotArea.DataSeries.Contains(dataNoisy))
                                plotArea.DataSeries.Remove(dataNoisy);
                            filter.restoreWeights();
                            if (cleanCheckBox.Checked)
                                plotArea.DataSeries.Add(dataClean);
                            if (noisyCheckBox.Checked)
                                plotArea.DataSeries.Add(dataNoisy);
                            this.Update();
                        }
                    }
                    else
                        reseted = false;
                }
                simInProgress = true;               
            }

            this.Focus();                                   

            /* setup the progress bar */
            progressBar1.Minimum = 1;
            progressBar1.Maximum = stepsNr+1;
            progressBar1.Value = 1;
                              
            /* retreive selected values */
            simModeVal = simModeCombo.SelectedIndex;         
            chosenCaseVal = chosenCaseCombo.SelectedIndex;
            weightsVal = weightsCombo.SelectedIndex;

            /* make computed data equal to noise data */
            filter.resetProcessedData();

            /* setup network's coefficient */
            if(chosenCaseVal == 0)
                filter.setCoefficent(SignalFilter.STANDARD);
            else if(chosenCaseVal == 1)
                filter.setCoefficent(SignalFilter.SHIFTED);

            /* setup weights */
            if(weightsVal == 0)
                filter.setWeights(SignalFilter.RANDOM);
            else if(weightsVal == 1)
                filter.setWeights(SignalFilter.MEDIUM);
                                    
            plotArea.DataSeries.Add(dataProcessed);
                   
            if (simModeVal == 0) /* auto simulation mode */
            {                   
                comboOnOff(DEACTIVATE);        
                for (int i = 0; i < stepsNr+1; i++)
                {    
                    /* handling GUI events */
                    Application.DoEvents();
                    
                    if (!simInProgress) /* simulation has been stopped by the user */
                        break;
                    learningStep(i);                                   
                    if (i != 0)
                        progressBar1.Value += 1;                    
                    System.Threading.Thread.Sleep(10);
                }                           
                simInProgress = false;
                comboOnOff(ACTIVATE);                
            }
            else if (simModeVal == 1) /* manual simulation mode */
            {
                comboOnOff(DEACTIVATE);
                ready = true;
                index = 0;
                learningStep(index);                
                index++;                              
            }
        }

        /* represents single learning step */ 
        private void learningStep(int index)
        {
            prepareDisplayData(COMPUTED);
            filter.learn(chosenCaseVal);
            stepNr.Text = stepNrString + (index) + " / " + stepsNr;
            plotArea.Update();
            groupBox4.Update();
        }
       
        /* prepares points of data by getting values from SignalFilter's instance */
        private void prepareDisplayData(int mode)
        {
            /* maximal noisy signal's value */
            double maxNoise = filter.getMaxNoise();

            /* maximal clean signal's value */
            double maxClean = filter.getMaxClean();

            /* minimal clean signal's value */
            double minClean = filter.getMinClean();                                      

            /* scaling variables */
            double scale = 0;
            double divisor = 0.0;
            double halfRange = (maxClean - minClean) / 2; 
      
            /* signals' current values */
            double YNoisy = 0.0, YClean = 0.0, YProcessed = 0.0;
            
            /* number of elements in clean/noisy and computed signals' data series */            
            int check1 = 0, check2 = 0;
                       
            scale = maxClean - minClean + filter.noiseLevel;
            divisor = (maxNoise + Math.Abs(minClean) + 0.2 * halfRange + 0.5 * filter.noiseLevel) / scale;      

            if (mode == CLEAN_AND_NOISY) /* prepare clean and noisy signals */
            {
                /* shift data if necessary */
                filter.shifter(chosenCaseCombo.SelectedIndex);
                if (chosenCaseCombo.SelectedIndex == 1)
                    shifted = true;
                else
                    shifted = false;

                int i1=-1,i2=-1;                
                i1 = plotArea.DataSeries.IndexOf(dataNoisy);
                i2 = plotArea.DataSeries.IndexOf(dataClean);
                
                check1 = dataNoisy.Data.Count; /* clean signal's data series has the same number
                                                * of elements */
                for (int i = 0; i < netSize; i++)
                {
                    if (shifted) /* signal is shifted */
                    {
                        YNoisy = (filter.nextValue(SignalFilter.NOISY, i) - Math.Abs(minClean) - 0.2 * halfRange - 0.5 * filter.noiseLevel) / scale;
                        YNoisy = YNoisy + (Math.Abs(minClean) + 0.2 * halfRange + 0.5 * filter.noiseLevel) / scale;
                        YClean = (filter.nextValue(SignalFilter.CLEAN, i) - Math.Abs(minClean) - 0.2 * halfRange - 0.5 * filter.noiseLevel) / scale;
                        YClean = YClean + (Math.Abs(minClean) + 0.2 * halfRange + 0.5 * filter.noiseLevel) / scale;
                    }
                    else /* signal is not shifted */
                    {
                        YNoisy = filter.nextValue(SignalFilter.NOISY, i) / scale;
                        YClean = filter.nextValue(SignalFilter.CLEAN, i) / scale;
                    }
                    YNoisy = (YNoisy / divisor) * 9.5;
                    YClean = (YClean / divisor) * 9.5;
                   
                    if (i < check1) 
                    {
                        dataNoisy.Data[i] = new PointF((float)(i * step) - 10f, (float)YNoisy);
                        dataClean.Data[i] = new PointF((float)(i * step) - 10f, (float)YClean);
                    }
                    else /* current network is bigger than previous */
                    {
                        dataNoisy.Data.Add(new PointF((float)(i * step) - 10f, (float)YNoisy));
                        dataClean.Data.Add(new PointF((float)(i * step) - 10f, (float)YClean));
                    }                    
                    if (i == netSize - 1)                          
                        for (int j = netSize; j < check1; j++) /* current network is smaller than previous */
                        {
                            dataNoisy.Data.RemoveAt(dataNoisy.Data.Count-1);
                            dataClean.Data.RemoveAt(dataClean.Data.Count-1);
                        }
                                        
                }                                
                if (i1 != -1)
                    plotArea.DataSeries[i1] = dataNoisy;
                if (i2 != -1)
                    plotArea.DataSeries[i2] = dataClean;                
            }
            else if (mode == COMPUTED) /* prepare computed signal */
            {
                check2 = dataProcessed.Data.Count;                               
                for (int i = 0; i < netSize; i++)
                {
                    if (shifted) /* signal is shifted */
                    {
                        YProcessed = (filter.nextValue(SignalFilter.COMPUTED, i) - Math.Abs(minClean) - 0.2 * halfRange - 0.5 * filter.noiseLevel) / scale;
                        YProcessed = YProcessed + (Math.Abs(minClean) + 0.2 * halfRange + 0.5 * filter.noiseLevel) / scale;                     
                    }
                    else /* signal is not shifted */                   
                        YProcessed = filter.nextValue(SignalFilter.COMPUTED, i) / scale;

                    YProcessed = (YProcessed / divisor) * 9.5f;

                    if (i < check2) /* current network is bigger than previous */
                        dataProcessed.Data[i] = new PointF((float)(i * step) - 10f, (float)YProcessed);
                    else    
                        dataProcessed.Data.Add(new PointF((float)(i * step) - 10f, (float)YProcessed));                
                    if (i == netSize - 1)
                        for (int j = netSize; j < check2; j++) /* current network is smaller than previous */                                                                
                            dataProcessed.Data.RemoveAt(dataProcessed.Data.Count - 1);                    
                }                                                       
            }
            return;
        }
   
        /* closing the main frame */
        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (simInProgress) /* simulation is running */
            {
                MessageBox.Show("Please stop already running simulation",
                                "Simulation running...",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                e.Cancel = true;
                
            }
            else /* simulation is not running */
                filter.close();
        }

        /* opening dialog for data input */
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (simInProgress) /* simulation is running */
            {
                MessageBox.Show("Please stop already running simulation",
                                "Unable to reset",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                return;
            }

            /* freeze main frame and show dialog for data input */         
            this.Enabled = false;            
            if (input == null)
                input = new InputFrame(filter);
            input.Show();
            return;
        }
      
        /* exiting application from main menu */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (simInProgress) /* simulation is running */
            {
                MessageBox.Show("Please stop already running simulation",
                                "Simulation running...",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
               
            }
            else /* simulation is not running */
                filter.close();
        }

        /* opens 'About...' frame*/
        private void aboutAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutFrame = new about();
            aboutFrame.Show();
        }

        /* clean signal check box's event listener */
        private void cleanCheckedChanged(object sender, EventArgs e)
        {
            if (!cleanCheckBox.Checked) /* hide clean signal */
            {
                if (plotArea.DataSeries.Contains(dataClean))
                {
                    plotArea.DataSeries.Remove(dataClean);
                    plotArea.Update();
                }
            }
            else /* show clean signal */      
                if (!plotArea.DataSeries.Contains(dataClean))
                {
                    plotArea.DataSeries.Add(dataClean);
                    plotArea.Update();
                }            
        }

        /* noisy signal check box's event listener */
        private void noisyCheckedChanged(object sender, EventArgs e)
        {
            if (!noisyCheckBox.Checked) /* hide noisy signal */
            {
                if (plotArea.DataSeries.Contains(dataNoisy))
                {
                    plotArea.DataSeries.Remove(dataNoisy);
                    plotArea.Update();
                }
            }
            else /* show noisy signal */
                if (!plotArea.DataSeries.Contains(dataNoisy))
                {
                    plotArea.DataSeries.Add(dataNoisy);
                    plotArea.Update();
                }            
        }

        /* stops the simulation */
        private void stop_Click(object sender, EventArgs e)
        {
            if (simInProgress) /* simulation is running */
            {               
                simInProgress = false;
            }           
            comboOnOff(ACTIVATE); /* make combo boxes active */
        }

        /* reset display and back to simulation defaults */
        private void reset_Click(object sender, EventArgs e)
        {            
            if (!simInProgress) /* simulation has ended */
            {
                reseter();
            }
            else /* simulation is running */
            {
                MessageBox.Show("Please stop already running simulation",
                                "Unable to reset",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Stop);
            }
        }

        /* resets display and switches options to defaults */ 
        private void reseter()
        {
            plotArea.DataSeries.Clear();            
            plotArea.Update();
            reseted = true;
            if (shifted) /* signal is shifted */
            {
                shifted = false;
                filter.setCoefficent(SignalFilter.STANDARD);
                filter.shiftBackData();
            }           
            index = 0;
            stepNr.Text = stepNrString;
            progressBar1.Value = 1;            
            simModeCombo.SelectedIndex = 0;            
            chosenCaseCombo.SelectedIndex = 0;
            weightsCombo.SelectedIndex = 0;            
            filter.restoreWeights();
            prepareDisplayData(CLEAN_AND_NOISY);
            this.Update();
            initial = true;
            if (cleanCheckBox.Checked)
                cleanCheckBox.Checked = false;
            if (noisyCheckBox.Checked)
                noisyCheckBox.Checked = false;
        }
                
        /* simulation case (shifted/standard) combo box's event listener */
        private void chosenCaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!simInProgress) /* simulation is not running */
            {
                if (chosenCaseCombo.SelectedIndex == 1) /* shifted mode chosen */
                {
                    if (!shifted) /* plot has not been shifted yet */
                    {                                 
                        plotArea.DataSeries.Remove(dataClean);
                        plotArea.DataSeries.Remove(dataNoisy);
                        filter.setCoefficent(SignalFilter.SHIFTED);
                        prepareDisplayData(CLEAN_AND_NOISY);
                        if (noisyCheckBox.Checked && !plotArea.DataSeries.Contains(dataNoisy))
                            plotArea.DataSeries.Add(dataNoisy);                            
                        if(cleanCheckBox.Checked && !plotArea.DataSeries.Contains(dataClean))
                            plotArea.DataSeries.Add(dataClean);                       
                        plotArea.Update();                    
                    }
                }
                else /* standard mode chosen */
                {
                    if (shifted) /* plot has already been shifted */
                    {                        
                        filter = filter.shiftBackData();
                        filter.setCoefficent(SignalFilter.STANDARD);                       
                        plotArea.DataSeries.Remove(dataClean);                        
                        plotArea.DataSeries.Remove(dataNoisy);
                        prepareDisplayData(CLEAN_AND_NOISY);
                        if (noisyCheckBox.Checked && !plotArea.DataSeries.Contains(dataNoisy))
                            plotArea.DataSeries.Add(dataNoisy);
                        if (cleanCheckBox.Checked && !plotArea.DataSeries.Contains(dataClean))
                            plotArea.DataSeries.Add(dataClean);                                                    
                        plotArea.Update();                        
                    }
                }
            }
        }

        /* enables/disables combo boxes */
        private void comboOnOff(int chosen) 
        {
            if (chosen == DEACTIVATE) /* diasable combo boxes */
            {     
                simModeCombo.Enabled = false;
                chosenCaseCombo.Enabled = false;
                weightsCombo.Enabled = false;
            }
            else if (chosen == ACTIVATE) /* enable combo boxes */
            {          
                simModeCombo.Enabled = true;
                chosenCaseCombo.Enabled = true;
                weightsCombo.Enabled = true;
            }
        }

    }
}
