using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example10c
{
    internal class ProgramLogic
    {
        private bool _density;

        private bool _randomize = true;

        public void Randomize(bool b)
        {
            _randomize = b;
        }

        public bool Randomize()
        {
            return _randomize;
        }

        private bool _soft;
        internal bool Soft
        {
            get { return _soft; }
            set { _soft = value; }
        }

        private int _winner;

        internal int Winner
        {
            get { return _winner; }
            set { _winner = value; }
        }


        int[] _ranges = new int[4];

        internal int[] Ranges
        {
            get { return _ranges; }
            set { _ranges = value; }
        }

        int[] _Quarter_winner = new int[4];

        internal int[] Quarter_winner
        {
            get { return _Quarter_winner; }
            set { _Quarter_winner = value; }
        }

        int[] _teachers = new int[4];

        internal int[] Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
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

        private double _ethaFactor;
        private double _ethaFactor0;

        internal double EthaFactor
        {
            get { return _ethaFactor; }
        }



        private int _numberOfNeurons;

        internal int NumberOfNeurons
        {
            get { return _numberOfNeurons; }
        }

        private double[] _currentResponse;

        internal double[] CurrentResponse
        {
            get { return _currentResponse; }
        }

        public NewRandom _randomGenerator;

        internal void InitializeRandom()
        {
            int _elements = _numberOfInputs * _numberOfNeurons;
            if (_randomGenerator == null || _elements != _randomGenerator.Elements)
                _randomGenerator = new NewRandom(_elements);
        }


        internal void InitializeTeaching()
        {
            double[] w;
            _randomGenerator.RewindTable();

            if (_density)
            {
                w=new double[_numberOfInputs];
                for (int _input = 0; _input < w.Length; _input++)
                    w[_input] = 18 * _randomGenerator.NextDouble() - 9;
                for (int _neuron = 0; _neuron < _numberOfNeurons; _neuron++)
                    for (int _input = 0; _input < _numberOfInputs; _input++)
                    {
                        _examinedNetwork.Neurons[_neuron].Weights[_input] =
                            w[_input] + 2 * _randomGenerator.NextDouble() - 1;
                    } 
            }
            else
              _examinedNetwork.Randomize(_randomGenerator, -9, 9);

            _teachingElement.Inputs = new double[_numberOfInputs];

            for (int i = 0; i < _ranges.Length; i++)
                _ranges[i] = 0;
        }

        internal void LoadTeachingSet(int numberOfNeurons, double ethaFactor,
            bool density, bool soft)
        {
            _soft = soft;
            _ethaFactor = ethaFactor;
            _ethaFactor0 = _ethaFactor;
            _numberOfNeurons = numberOfNeurons;
            InitializeRandom();
            _density = density;
            _randomGenerator.RewindTable();
            _randomGenerator.Randomize(_randomize);
           _examinedNetwork = new LinearNetwork(_numberOfInputs, numberOfNeurons);
            InitializeTeaching();         
        }


        internal int PerformTeaching(double[] inputSignals)
        {

             _examinedNetwork.Learn(_teachingElement, _winner, _ethaFactor);
             return _winner;

        }

        internal double[] PerformExperiment(double[] inputSignals)
        {
            _currentResponse = _examinedNetwork.Response(inputSignals,out _winner);
            return _currentResponse;
        }

        internal void RestoreEthaFactor()
        {
            _ethaFactor = _ethaFactor0;
        }


    }
}
