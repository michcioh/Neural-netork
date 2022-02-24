using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example05
{
    /* 
     * This is the class for preparing simulation data
     * and storing it in 'teaching_set' binary file.
     *
     */
    class SignalPrepare
    {
        /* name of data file */
        private const String fileName = "teaching_set";

        /* network's size */
        private int netSize;

        /* numer of inputs of each neuron */
        private const int inputsNr = 5;

        /* signal's noise level */
        private double noiseLevel;

        /* signal's frequency */
        private double freq;

        /* variable holding generated data */
        private double value;
      
        private FileStream file;
        private BinaryWriter writer;
        private Random rndGen;
    
        /* constructor */
        public SignalPrepare(int netSize, double noiseLevel, double freq)
        {            
            this.netSize = netSize;
            this.noiseLevel = noiseLevel;
            this.freq = freq;           

            /*now the data is being generated as well as stored in a file*/
            try
            {
                file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            }
            catch (IOException IOE) 
            { 
                MessageBox.Show("Unable to create data file!",
                                "Error creating data file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
  
            writer = new BinaryWriter(file);
            rndGen = new Random();

            /*writing noisy signal*/
            for (int i = 0; i < netSize; i++)
            {
                value = System.Math.Sin(freq * i) + noiseLevel * rndGen.NextDouble() - 0.5 * noiseLevel;               
                writer.Write(value);
            }
            /*writing clean signal*/
            for (int i = 0; i < netSize; i++)
            {
                value = System.Math.Sin(freq * i);
                writer.Write(value);
            }
            writer.Close();         
        }

        /* generates weights matrix */ 
        public double[][] createWeights()
        {
            double [][] weights = new double [netSize][];
            
            for (int i = 0; i < netSize; i++)
            {
                weights[i] = new double[inputsNr];
                for (int j = 0; j < inputsNr; j++)
                {
                    weights[i][j] = -.1 + .2 * rndGen.NextDouble();                   
                }
            }
            return weights;
        }     
    }

}
