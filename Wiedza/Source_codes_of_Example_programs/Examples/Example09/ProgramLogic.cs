using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RTadeusiewicz.NN.Example09
{

    internal class ProgramLogic
    {

        public Random _rndGenerator = new Random();

        private int _layers;

        internal int Layers
        {
            get { return _layers; }
            set { _layers = value; }
        }

        private double _eta = 0.7;

        internal double Eta
        {
            get { return _eta; }
            set { _eta = value; }
        }

        
        private double _alpha = 0.3;

        internal double Alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        private double _scale = 5;

        internal double Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        private int _totalIterations;

        internal int TotalIterations
        {
            get { return _totalIterations; }
            set { _totalIterations = value; }
        }

        public double[,,,] weight = new double[4,11,10,3];

        public double[,] sigma = new double[4,10];

        public double[,] y = new double[4,11];

        public int[] d = new int[10];

        public double[,] c = new double[3,2];

        public double[] r = new double[3];

        public int[] n = new int[5];

        private double[] koord = new double[2];

        public Color[] colors = new Color[6];


        public void InitializeTeaching()
        {
            _totalIterations = 0;
            InitializeWeights();
            colors[0] = Color.FromArgb(0, 166, 255);
            colors[1] = Color.FromArgb(255, 77, 0);
            colors[2] = Color.DarkGreen;
            colors[3] = Color.Red;
            colors[4] = Color.Lime;
            colors[5] = Color.Yellow;                     
        }

        public void WhichSet()
        {
            double[] dist = new double[3];

            for (int i = 0; i <= 2; i++)
            {
                dist[i] = (c[i,0] - y[0,0]) * (c[i,0] - y[0,0]);
                dist[i] = dist[i] + (c[i,1] - y[0,1]) * (c[i,1] - y[0,1]);
                dist[i] = Math.Sqrt(dist[i]);
            }
            d[0] = 0;
            for (int i = 0; i <= 2; i++)
                if (dist[i] <= r[i] && r[i]>0)
                    d[0] = 1;
        }

        public void WeightAdaptation()
        {
            double error =0; 
            double change = 0;

            for ( int i = _layers ; i > 0 ; i--)
                for (int j = 0; j <= n[i] - 1; j++)
                {
                    //if (i == _layers - 1)
                    if (i == _layers )
                        error = d[j] - y[i,j];
                    else
                    {
                        error = 0;
                        for (int k = 0; k <= n[i + 1] - 1; k++)
                            error = error + sigma[i + 1,k] * weight[i + 1,j,k,0];
                    }
                    sigma[i,j] = error * y[i,j] * (1 - y[i,j]);

                }
            for (int i = 1; i <= _layers; i++)
                for (int j = 0; j <= n[i - 1]; j++)
                    for (int k = 0; k <= n[i] - 1; k++)
                        weight[i,j,k,2] = weight[i,j,k,0];

            for (int i = 1; i <= _layers; i++)
                for (int j = 0; j <= n[i - 1]; j++)
                    for (int k = 0; k <= n[i] - 1; k++)
                    {
                        change = _alpha * (weight[i,j,k,0] - weight[i,j,k,1]);
                        change = _eta * sigma[i,k] * y[i - 1,j] - change;
                        weight[i,j,k,0] = weight[i,j,k,0] + change;
                    }

            for (int i = 1; i <= _layers; i++)
                for (int j = 0; j <= n[i - 1]; j++)
                    for (int k = 0; k <= n[i] - 1; k++)
                        weight[i,j,k,1] = weight[i,j,k,2];

        }

        public void NetworkRespond()
        {
            for (int i = 1 ; i <= _layers ; i++)
                for (int k = 0; k <= n[i] - 1; k++)
                {
                    y[i,k] = 0;
                    y[i - 1,n[i - 1]] = -1;
                    for (int j = 0; j <= n[i - 1]; j++)
                        y[i,k] = y[i,k] + y[i - 1,j] * weight[i,j,k,0];
                    y[i,k] = 1.0 / (1 + Math.Exp(-y[i,k]));
                }
        }
       
        public void InitializeWeights()
        {
            for (int i=1 ; i <= _layers ; i++)
                for (int j=0 ; j <= n[i - 1] ; j++)
                    for (int k = 0; k <= n[i] - 1; k++)
                    {
                        weight[i,j,k,0] = (_rndGenerator.NextDouble() - 0.5) * Scale / 2.0;
                        if (weight[i,j,k,0] == 0)
                        {
                            weight[i,j,k,0] = Scale * 0.01;
                        }
                    }
        }     
    }
}
