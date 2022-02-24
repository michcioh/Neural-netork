using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example11
{
    internal class ProgramLogic
    {

        private int _netSizeX;
        internal int NetSizeX
        {
            get { return _netSizeX; }
        }
        private int _netSizeY;
        internal int NetSizeY
        {
            get { return _netSizeY; }
        }
        private double _initialWeights;
        internal double InitialWeights
        {
            get { return _initialWeights; }
        }

        private int _min;
        private int _max;

        public Random _randomGenerator = new Random();


        private double _alpha0;
        internal double Alpha0
        {
            get { return _alpha0; }
            set { _alpha0 = value; }
        }

        private double _alpha1;
        internal double Alpha1
        {
            get { return _alpha1; }
            set { _alpha1 = value; }
        }

        private double _neighbour;
        internal double Neighbour
        {
            get { return _neighbour; }
            set { _neighbour = value; }
        }

        private double _espAlpha;
        internal double EspAlpha
        {
            get { return _espAlpha; }
            set { _espAlpha = value; }
        }
        
        private double _espNeighbour;
        internal double EspNeighbour
        {
            get { return _espNeighbour; }
            set { _espNeighbour = value; }
        }

        private int _distribution;

        internal int Distribution
        {
            get { return _distribution; }
            set { _distribution = value; }
        }

        private int _iteractions;

        internal int Iteractions
        {
            get { return _iteractions; }
            set { _iteractions = value; }
        }

        private TeachingSet.Element _teachingElement;

        internal TeachingSet.Element TeachingElement
        {
            get { return _teachingElement; }
        }

        private LinearNetwork _examinedNetwork;

        internal LinearNetwork ExaminedNetwork
        {
            get { return _examinedNetwork; }
        }

        private int _numberOfInputs = 2;

        internal int NumbarOfInputs
        {
            get { return _numberOfInputs; }
        }

        public int _MapIndex(int X, int Y)
        {
            return Y * _netSizeX + X;
        }


        private int _numberOfNeurons;

        internal int NumberOfNeurons
        {
            get { return _numberOfNeurons; }
        }

        internal void InitializeTeaching()
        {         
            _examinedNetwork.Randomize(_randomGenerator, -1*_initialWeights, 1*_initialWeights, 0.001*_initialWeights);
            _teachingElement.Inputs = new double[_numberOfInputs];
        }
        

        internal void LoadTeachingSet(int netSizeX,int netSizeY, 
            double initialWeights)
        {
            _netSizeX = netSizeX;
            _netSizeY = netSizeY;
            _initialWeights = initialWeights;

            _min = _netSizeX;
            if (_netSizeY < _netSizeX)
                _min = _netSizeY;

            _max = _netSizeX;
            if (_netSizeY > _netSizeX)
                _max = _netSizeY;

            _alpha0 = 0.1;
            _alpha1 = 0.02;
            _neighbour = Convert.ToInt16(_min + _max) / 4.0 + 1;

            _espAlpha = 0.9997;
            _espNeighbour = 0.999;
            _distribution = 1;

            _iteractions = 0;

            _numberOfNeurons = _netSizeX * _netSizeY;
          
            _examinedNetwork = new LinearNetwork(_numberOfInputs, _netSizeX * _netSizeY);

            InitializeTeaching();
        }


        internal void PerformTeaching(double[] inputSignals)
        {
            double _oldmin = 10000;
            int _imin = 1;
            int _jmin = 1;
            double alpha;
            double odl;

            _teachingElement.Inputs = inputSignals;

            for (int i = 0; i < NetSizeX; i++)
                for (int j = 0; j < NetSizeY; j++)
                {
                    odl = Math.Sqrt(
                       Math.Pow(ExaminedNetwork.Neurons[_MapIndex(i, j)].Weights[0] - inputSignals[0], 2)
                            +
                       Math.Pow(ExaminedNetwork.Neurons[_MapIndex(i, j)].Weights[1] - inputSignals[1], 2));

                    if (odl < _oldmin)
                    {
                        _oldmin = odl;
                        _imin = i;
                        _jmin = j;
                    }
                }

            int s = Convert.ToInt16(Neighbour);

            for (int i = _imin - s; i <= _imin + s; i++)
                if (i >= 0 && i < NetSizeX)
                    for (int j = _jmin - s; j <= _jmin + s; j++)
                        if (j >= 0 && j < NetSizeY)
                        {
                            odl = Math.Abs(i - _imin);
                            
                            if (Math.Abs(j - _jmin) > odl)
                                odl = Math.Abs(j - _jmin);

                            if (odl <= s)
                            {
                                if (s > 0)
                                    alpha = (Alpha0 * (s - odl) +Alpha1 *odl) / s;

                                else
                                    alpha = Alpha0;

                               // _programLogic.PerformTeaching(points, i, j, alpha);
                                _examinedNetwork.Learn(_teachingElement, _MapIndex(i, j), alpha);
                            }
                        }
              
        }

    
    }
}
