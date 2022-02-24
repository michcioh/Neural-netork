using System;
using System.Collections.Generic;
using System.Text;

namespace RTadeusiewicz.NN.NeuralNetworks
{
    public class LinearNetwork
    {
        public LinearNetwork(int numberOfInputs, int numberOfNeurons)
        {
            _neurons = new Neuron[numberOfNeurons];
            _inputCount = numberOfInputs;
            for (int i = 0; i < _neurons.Length; i++)
                _neurons[i] = new Neuron(numberOfInputs);
        }

        public LinearNetwork(double[,] initialWeights)
            : this(initialWeights.GetLength(1), initialWeights.GetLength(0))
        {
            for (int neuron = 0; neuron < _neurons.Length; neuron++)
                for (int input = 0; input < _inputCount; input++)
                    _neurons[neuron].Weights[input] = initialWeights[neuron, input];
        }

        private Neuron[] _neurons;

        public Neuron[] Neurons
        {
            get { return _neurons; }
        }

        private double[] _neurons_dist;

        public double[] Neurons_dist
        {
            get { return _neurons_dist; }
        }

        private readonly int _inputCount;

        public int InputCount
        {
            get { return _inputCount; }
        }

        public double[] Response(double[] inputSignals)
        {
            if (inputSignals == null || inputSignals.Length != _inputCount)
                throw new ArgumentException(
                    "The signal array's length must be equal to the number of inputs.");

            double[] res = new double[_neurons.Length];
            for (int i = 0; i < res.Length; i++)
                res[i] = _neurons[i].Response(inputSignals);

            return res;
        }

        // Response dla exampla 10c white
        public double[] Response(double[] inputSignals, out int num)
        {
            if (inputSignals == null || inputSignals.Length != _inputCount)
                throw new ArgumentException(
                    "The signal array's length must be equal to the number of inputs.");

            double[] res = new double[_neurons.Length];
            double max=0;
            double dist=0;

           // for (int i = 0; i < _neurons.Length; i++)
           // {
             //   double dist=0;
              //  for(int j=0 ; j< _neurons[0].Weights.Length ; j++)

          //  {
//dist += _neurons[i].Weights[j] - inputSignals[j];
             //       res[i] = 1 / 
//
           // }
            //}

            num = -1;

            _neurons_dist = new double[_neurons.Length];

            for (int i = 0; i < res.Length; i++)

            {
                res[i] = _neurons[i].Response(inputSignals,out dist);

                _neurons_dist[i] = dist;
                if (res[i] > max)
                {
                    max = res[i];
                    num = i;
                }
            }

            return res;
        }
        // To be tested!
        public static int Winner(double[] output, double threshold)
        {
            int result = -1;
            double max = threshold;
            for (int i = 0; i < output.Length; i++)
                if (output[i] > max)
                {
                    max = output[i];
                    result = i;
                }
            return result;
        }

        public double Winner(double[] inputSignals)
        {
            double max=0;

            double res;
            for (int i = 0; i < _neurons.Length; i++)
            {
                res= _neurons[i].Response(inputSignals);
                if (Math.Abs(res)>max)
                    max=res;
            }
            return max;
        }

        public struct LearningStatistics
        {
            public double[] Output;
            public double Error;
            public LearningStatistics(double[] output, double error)
            {
                Output = output;
                Error = error;
            }
        }        
        
        public void Learn(TeachingSet.Element teachingElement, double etha)
        {
            double _max = 0;

            
            _max = Winner(teachingElement.Inputs);

            for (int x = 1; x < _neurons.Length; x++)
            {

            }

                for (int neuronIndex = 0; neuronIndex < _neurons.Length; neuronIndex++)
                {
                    _neurons[neuronIndex].Learn(
                        teachingElement.Inputs,
                        etha,
                        _max
                    );
                }
        }

        /* dodano dla samouczacego sie neuronu */
        public void Learn(TeachingSet.Element teachingElement,int neuronIndex, double etha)
        {
                 _neurons[neuronIndex].LearnSelf(
                    teachingElement.Inputs,
                    etha
                );
        }

        public void Learn(TeachingSet.Element teachingElement, double ratio,
            ref double[] previousResponse, ref double[] previousError)
        {
            if (previousResponse == null)
                previousResponse = new double[_neurons.Length];
            if (previousError == null)
                previousError = new double[_neurons.Length];

            for (int neuronIndex = 0; neuronIndex < _neurons.Length; neuronIndex++)
            {
                _neurons[neuronIndex].Learn(
                    teachingElement.Inputs,
                    teachingElement.ExpectedOutputs[neuronIndex],
                    ratio,
                    out previousResponse[neuronIndex],
                    out previousError[neuronIndex]
                );
            }
        }

        public void Randomize(Random randomGenerator, double min, double max)
        {
            foreach (Neuron n in _neurons)
                n.Randomize(randomGenerator, min, max);
        }

        public void Randomize(Random randomGenerator, double min, 
            double max, double epsilon)
        {
            foreach (Neuron n in _neurons)
                n.Randomize(randomGenerator, min, max,epsilon);
        }
    }
}
