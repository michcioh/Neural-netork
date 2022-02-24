using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example10b
{
    internal class ProgramLogic
    {
        private bool _density;

        private bool _randomize = true;

        public void Randomize(bool b)
        {
            _randomize = b;
        }

        private double[] power;

        internal double[] Power
        {
            get { return power; }
            set { power = value; }
        }


        public bool Randomize()
        {
            return _randomize;
        }

        int[] _ranges = new int[4];

        internal int[] Ranges
        {
            get { return _ranges; }
            set { _ranges = value; }
        }

        int[] _teachers_9 = new int[4];

        internal int[] Teachers_9
        {
            get { return _teachers_9; }
            set { _teachers_9 = value; }
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
            set { _ethaFactor=value; }
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

        private int _numberOfRuns;

        internal int NumberOfRuns
        {
            get { return _numberOfRuns; }
            set { _numberOfRuns = value; }
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
            _numberOfRuns = 0;

            if (_density)
            {
                w=new double[_numberOfInputs];
                for (int _input = 0; _input < w.Length; _input++)
                    w[_input] = 18.0 * _randomGenerator.NextDouble() - 9;

                for (int _neuron = 0; _neuron < _numberOfNeurons; _neuron++)
                    for (int _input = 0; _input < _numberOfInputs; _input++)
                    {
                        _examinedNetwork.Neurons[_neuron].Weights[_input] =
                            w[_input] + 2 * _randomGenerator.NextDouble() - 1;
                    } 
            }
            else
              _examinedNetwork.Randomize(_randomGenerator, -9.0, 9.0);

            _teachingElement.Inputs = new double[_numberOfInputs];
            power = new double[_numberOfNeurons];

            for (int i = 0; i < _ranges.Length; i++)
                _ranges[i] = 0;

             for (int x = 0; x < _numberOfNeurons; x++)
                power[x] = 1;

            for (int x = 0; x < _numberOfNeurons; x++)
            {
                power[x] = power[x] + _examinedNetwork.Neurons[x].Weights[0] *
                    _examinedNetwork.Neurons[x].Weights[0];
                power[x] = power[x] + _examinedNetwork.Neurons[x].Weights[1] *
                   _examinedNetwork.Neurons[x].Weights[1];
            }
        }


        internal void LoadTeachingSet(int numberOfNeurons, double ethaFactor,bool density)
        {
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

       
        internal void PerformTeaching()
        {
            //_examinedNetwork.Learn(_teachingElement, _ethaFactor);

            double max = 0;
            for (int k = 0; k < NumberOfNeurons; k++)
            {
                

                double res;
                for (int i = 0; i < _examinedNetwork.Neurons.Length; i++)
                {
                    res = _examinedNetwork.Neurons[i].Response(_teachingElement.Inputs);
                    res = 4 * res / power[i];

                    if (Math.Abs(res) > max)
                        max = res;
                }
            }

            for (int neuronIndex = 0; neuronIndex < NumberOfNeurons; neuronIndex++)
            {
                

              //  _examinedNetwork.Neurons[neuronIndex].Learn(
              //      _teachingElement.Inputs,
              //      _ethaFactor,
              //      max
              //  );

                double previous_response = _examinedNetwork.Neurons[neuronIndex].Response(_teachingElement.Inputs);

                previous_response = 4 * previous_response / power[neuronIndex];

                if (previous_response < 0.2 * max)
                    previous_response *= 0.3;
                if (previous_response < 0)
                    previous_response *= 0.1;

                power[neuronIndex] = 1; 

                for (int i = 0; i < 2; i++)
                {
                    _examinedNetwork.Neurons[neuronIndex].PrevWeights[i] =
                        _examinedNetwork.Neurons[neuronIndex].Weights[i];
                   // _prevWeights[i] = _weights[i];
                    _examinedNetwork.Neurons[neuronIndex].Weights[i] +=
                        _ethaFactor *
                        previous_response *
                        (_teachingElement.Inputs[i] - _examinedNetwork.Neurons[neuronIndex].Weights[i]);

                   // _weights[i] += etha * previous_response * (signals[i] - _weights[i]);
                }


                power[neuronIndex] = power[neuronIndex] +
                    _examinedNetwork.Neurons[neuronIndex].Weights[0] *
                    _examinedNetwork.Neurons[neuronIndex].Weights[0];
                power[neuronIndex] = power[neuronIndex] +
                    _examinedNetwork.Neurons[neuronIndex].Weights[1] *
                    _examinedNetwork.Neurons[neuronIndex].Weights[1];
            }

        }

        internal double[] PerformExperiment(double[] inputSignals)
        {
            _currentResponse = _examinedNetwork.Response(inputSignals);
            return _currentResponse;
        }

        internal void RestoreEthaFactor()
        {
            _ethaFactor = _ethaFactor0;
        }
    }
}
