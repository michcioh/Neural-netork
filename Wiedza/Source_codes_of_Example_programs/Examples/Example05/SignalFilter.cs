using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example05
{
    /* 
     * This is program's main class.
     * It holds network's weights and supplies
     * interface to operate on created network.
     * Network is generated on the basis of data
     * stored by SignalPrepare class's instance 
     * in file 'teaching_set'. SignalFilter instance 
     * reads that file.
     *
     */
    public class SignalFilter
    {             
        /* standard signal */
        public const int STANDARD = 0;

        /* shifted signal */
        public const int SHIFTED = 1;
        
        /* clean signal */
        public const int CLEAN = 2;

        /* noisy signal */
        public const int NOISY = 3;

        /* signal being computed */
        public const int COMPUTED = 4;

        /* numer of inputs of each neuron */
        private const int inputsNr = 5;      

        /* size of network - number of neurons */
        private int size;
        public const int SIZE = 6;
        
        /* the number of teaching steps */
        private int stepsNr;
        public const int STEPS = 7;

        /* standard(random) weights */
        public const int RANDOM = 8;

        /* medium weights */
        public const int MEDIUM = 9;
        
        /* signal's noise level */
        public double noiseLevel;

        /* signal's frequency */
        private double freq;
        
        /* data file's name */
        private const String fileName = "teaching_set";
        
        /* network's coefficient */
        private double coefficient = .1;   

        /* main frame class's instance */
        private MainFrame main;

        /* instance of dialog for data input */
        private InputFrame input;
        
        /* data file */
        private FileStream file;
        private BinaryReader reader;
        
        /* variable helpful in learning process */
        private int step;
        
        /* indicates whether medium weights option was chosen */
        private bool mediumWeights;

        /* indicates whether network is ready to run */
        private bool loaded;

        /* array for holding noisy signal's data */
        private double[] dataNoisy = null;
        
        /* array for holding clean signal's data */
        private double[] dataClean = null;

        /* array for holding computed signal's data */
        private double[] dataProcessed = null;
        
        /* array for holding network's weights(may be changed during learning process) */
        private double[][] weights = null;

        /* array for holding original network's weights */
        private double[][] weightsArchive = null;

        /* noisy signal's maximal value */
        private double maxNoise;

        /* clean signal's maximal/minimal value */
        private double maxClean, minClean;        

        /* constructor */
        public SignalFilter()
        {          
            /* display main frame, freeze it and show dialog
             * for data input */
            main = new MainFrame(this);
            main.Show();
            main.Enabled = false;

            input = new InputFrame(this);          
            input.Show();                        
            input.Activate();

            maxNoise = 0.0;
            maxClean = 0.0;
            minClean = 0.0;            
        }

        /* sets network's parameters */
        public void store(int size, double noiseLevel, double freq, double [][] weights, int stepsNr)
        {     
            this.size = size;        
            this.noiseLevel = noiseLevel;
            this.freq = freq;
            this.weights = weights;
            /* 'remember' initial weights */
            weightsArchive = new double[size][];
            for (int i = 0; i < size; i++)
            {
                weightsArchive[i] = new double[inputsNr];
                for (int j = 0; j < inputsNr; j++)
                    weightsArchive[i][j] = weights[i][j];
            }            
            this.stepsNr = stepsNr;
            mediumWeights = false;
            loaded = false;
        }

        /* gets data from file 'teaching_set' and stores it in memory */
        public void init()
        {
            if(!loaded)
                loaded = true;
            int i = 0; 

            /* check whether file is available */
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);               
            }
            catch (IOException IOE)
            {
                MessageBox.Show("Unable to read data file!",
                                "Error opening file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
                      
            dataNoisy = new double[size];            
            dataClean = new double[size];            
            dataProcessed = new double[size];
            
            reader = new BinaryReader(file);
          
            /* read data from file and store it in memory */
            for (int j = 0; j < 2 * size+1; j++)
            {
                if (j == size)
                    i = 0;
                else if (j < size)
                {
                    dataNoisy[i] = reader.ReadDouble();
                    if (dataNoisy[i] > maxNoise)
                        maxNoise = dataNoisy[i];                    
                    i++;
                }
                else
                {
                    dataClean[i] = reader.ReadDouble();
                    if (dataClean[i] > maxClean)
                        maxClean = dataClean[i];
                    else if (dataClean[i] < minClean)
                        minClean = dataClean[i];
                    i++;
                }
            }

            /* make computed data equal to noise data */
            resetProcessedData();

            reader.Close();
        }

        /* returns next piece of data */
        public double nextValue(int choice, int i)
        {                                               
            switch (choice)
            {
                case NOISY:
                    /* noisy signal's data chosen */                   
                    return dataNoisy[i];                    
                case CLEAN:
                    /* clean signal's data chosen */                    
                    return dataClean[i];                                        
                case COMPUTED:
                    /* processed data chosen */
                    return dataProcessed[i];                                        
                default :
                    MessageBox.Show("Unable to read more data!,",
                                                         "Error opening file",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Error);
                    return -1;             
            }                       
        }

        /* returns network size/number of teaching steps */
        public int getValue(int which)
        {
            if (which == SIZE)                        
                return size;            
            else if (which == STEPS)
                return stepsNr;
            else
                return -1;
        }

        /* shifts signals(clean,noisy) upwards */ 
        private SignalFilter shiftData()
        {
            double halfRange = (maxClean - minClean)/2;
            for (int i = 0; i < size; i++)
            {
                dataClean[i] += Math.Abs(minClean) + 0.2 * halfRange + 0.5 * noiseLevel;
                dataNoisy[i] += Math.Abs(minClean) + 0.2 * halfRange + 0.5 * noiseLevel;           
            }
            return this;
        }

        /* shifts signals(clean,noisy) downwards */ 
        public SignalFilter shiftBackData()
        {
            double halfRange = (maxClean - minClean) / 2;
            for (int i = 0; i < size; i++)
            {
                dataClean[i] -= Math.Abs(minClean) + 0.2 * halfRange + 0.5 * noiseLevel;
                dataNoisy[i] -= Math.Abs(minClean) + 0.2 * halfRange + 0.5 * noiseLevel;               
            }
            return this;
        }

        /* closing the application */
        public void close()
        {
            Application.ExitThread();
            Application.Exit(); 
        }

        /* learning process's function */
        public void learn(int times)
        {
            /*numer of repetitions of each step*/
            int mul = times == 1 ? 3 : 1;       
            step = inputsNr / 2 + 2;
            double output = 0, error = 0;

            for (int k = 0; k < mul; k++)
            {
            	
            	// // //
            	for (int i = step - 1; i <= size - step; i++)
                {
                    for (int j = 0; j <= inputsNr; j++)
                        if (j > 0)
                            output = output + weights[i - 1][j - 1] * dataNoisy[i + j - step];
                        else
                            output = 0;

                    error = dataClean[i - step + 1] - output;

                    for (int j = 0; j <= inputsNr; j++)
                        if (j > 0)
                            weights[i - 1][j - 1] = weights[i - 1][j - 1] + coefficient * error * dataNoisy[i + j - step];
                        else
                            ;
                    for (int j = 0; j <= inputsNr; j++)
                        if (j > 0)
                            output = output + weights[i - 1][j - 1] * dataNoisy[i + j - step];
                        else
                            output = 0;

                    dataProcessed[i] = output;
                }
				// // // // // Pierwsze neurony nieuwzględnione w jedynie słusznej pętli
            	for (int i = step - 1; i >= 0; i--)
                {
                    if (size > 7)
                    {
                        for (int j = 0; j <= inputsNr; j++)
                            if (j > 0)
                                output = output + weights[i][j - 1] * dataNoisy[i + j - 1];
                            else
                                output = 0;

                        error = dataClean[i] - output;

                        for (int j = 0; j <= inputsNr; j++)
                            if (j > 0)
                                weights[i][j - 1] = weights[i][j - 1] + coefficient * error * dataNoisy[i + j - 1];
                            else
                                ;
                        for (int j = 0; j <= inputsNr; j++)
                            if (j > 0)
                                output = output + weights[i][j - 1] * dataNoisy[i + j - 1];
                            else
                                output = 0;

                        dataProcessed[i] = output;
                    }
                    else
                    {
                        if(i < size)
                            dataProcessed[i] = 0;
                    }
            	}
            
            	// // // // // // Ostatnie neurony nieuwzględnione w jedynie słusznej pętli
            	
            	for (int i = size - step  + 1; i <= size - 1; i++)
                {
                    if (i > 7)
                    {
                        for (int j = 0; j <= inputsNr; j++)
                            if (j > 0)
                                output = output + weights[i][j - 1] * dataNoisy[i - j];
                            else
                                output = 0;

                        error = dataClean[i - step + 1] - output;

                        for (int j = 0; j <= inputsNr; j++)
                            if (j > 0)
                                weights[i][j - 1] = weights[i][j - 1] + coefficient * error * dataNoisy[i - j];
                            else
                                ;

                        for (int j = 0; j <= inputsNr; j++)
                            if (j > 0)
                                output = output + weights[i][j - 1] * dataNoisy[i - j];
                            else
                                output = 0;

                        dataProcessed[i] = output;
                    }
                    else
                    {
                        if (i < size && i > 0)
                            dataProcessed[i] = 0;
                    }
                }
            }
        }

        /* bring the main frame back to active state and update reference
         * to frame for data input */
        public void activateMain(bool isNull, bool netRefresh)
        {
            if (isNull)
                input = null;            
            main.refresh(this,netRefresh);            
            main.Enabled = true;
        }

        /* restore initial weights */
        public void restoreWeights()
        {
            for (int i = 0; i < size; i++)  
                for (int j = 0; j < inputsNr; j++)
                    weights[i][j] = weightsArchive[i][j];            
        }

        /* set network's coefficient */
        public void setCoefficent(int chosen)
        {
            if(chosen == STANDARD)
                this.coefficient = 0.1;
            else if(chosen == SHIFTED)
                this.coefficient = 0.033;
        }

        /* set weights' values - medium/standard(random) */
        public void setWeights(int chosen)
        {
            if (chosen == MEDIUM)
            {
                mediumWeights = true;
                for (int i = 0; i < size; i++)
                {
                    weights[i][step] = 1;
                }
            }
            else if (chosen == RANDOM)
            {
                if (mediumWeights)
                {
                    mediumWeights = false;
                    for (int i = 0; i < size; i++)
                    {
                        weights[i][step] = weightsArchive[i][step];
                    }
                }
            }
        }

        /* returns reference to frame for data input  */
        public InputFrame getInput()
        {
            return input;
        }

        /* indicates whether network is ready to run */
        public bool isLoaded()
        {
            return loaded;
        }

        /* resets computed data(set to noisy signal's values)*/ 
        public void resetProcessedData()
        {            
            /* set to noise */            
            for (int i = 0; i < size; i++)
                dataProcessed[i] = dataNoisy[i];
        }

        /* shifts signals(noisy and clean) or does nothing */
        public void shifter(int chosen)
        {
            if (chosen == 0)
                return;
            else if (chosen == 1)
            {
                shiftData();
            }
        }
        
        /* returns the maximal noisy signal's value */
        public double getMaxNoise()
        {
            return maxNoise;
        }

        /* returns the maximal clean signal's value */
        public double getMaxClean()
        {
            return maxClean;
        }       

        /* returns the minimal clean signal's value */
        public double getMinClean()
        {
            return minClean;
        }
    }
}
