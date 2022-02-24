using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example03
{
    internal class ProgramLogic
    {
        private string _teachingSetFileName;

        internal string TeachingSetFileName
        {
            get { return _teachingSetFileName; }
        }

        private TeachingSet _teachingSet;

        internal TeachingSet TeachingSet
        {
            get { return _teachingSet; }
        }

        private Neuron _examinedNeuron;

        internal Neuron ExaminedNeuron
        {
            get { return _examinedNeuron; }
        }

        private int _teachingStep;

        internal int TeachingStep
        {
            get { return _teachingStep; }
        }

        private int _currentElementIndex = -1;

        internal TeachingSet.Element CurrentElement
        {
            get { return _teachingSet[_currentElementIndex]; }
        }

        private double[] _currentNormalizedInputs;

        internal double[] CurrentNormalizedInputs
        {
            get { return _currentNormalizedInputs; }
        }

        private double[] _previousWeights;

        internal double[] PreviousWeights
        {
            get { return _previousWeights; }
        }

        private double _previousResponse;

        internal double PreviousResponse
        {
            get { return _previousResponse; }
        }

        private double _previousError;

        internal double PreviousError
        {
            get { return _previousError; }
        }

        private double _currentResponse;

        internal double CurrentResponse
        {
            get { return _currentResponse; }
        }

        private double _currentError;

        internal double CurrentError
        {
            get { return _currentError; }
        }

        private HistoryDataSeries _progressHistory = new HistoryDataSeries();

        internal HistoryDataSeries ProgressHistory
        {
            get { return _progressHistory; }
        }

        private Random _randomGenerator = new Random();

        internal void InitializeTeaching()
        {
            _examinedNeuron.Randomize(_randomGenerator, -0.1, 0.1);
            _currentElementIndex = -1;
            _teachingStep = 0;
        }

        internal void LoadTeachingSet(string fileName)
        {
            TeachingSet tset = NeuralNetworks.TeachingSet.FromFile(fileName);
            if (tset == null || tset.Count == 0)
                throw new ApplicationException("The file does not contain any data.");
            if (tset.OutputCount != 1)
                throw new ApplicationException(
                    "The file you supplied describe a learning set for the " +
                    "multi-neuron network. This application is capable of " +
                    "learning only one neuron. Please select a file that " +
                    "contains a learning set for one neuron.");
            _teachingSetFileName = fileName;
            _teachingSet = tset;
            _examinedNeuron = new Neuron(tset.InputCount);
            InitializeTeaching();
        }

        internal void PerformTeaching(double teachingRatio)
        {
            /* We assume that we have non-zero amount of elements in the teaching set,
             * so we don't check if the 0 index is correct. This condition is
             * established by LoadTeachingSet(). */
            if (++_currentElementIndex >= _teachingSet.Count)
                _currentElementIndex = 0;

            _currentNormalizedInputs = (double[])CurrentElement.Inputs.Clone();
            Neuron.Normalize(_currentNormalizedInputs);
            _previousWeights = (double[])_examinedNeuron.Weights.Clone();

            _examinedNeuron.Learn(_currentNormalizedInputs,
                CurrentElement.ExpectedOutputs[0],
                teachingRatio,
                out _previousResponse, out _previousError);

            _currentResponse = _examinedNeuron.Response(_currentNormalizedInputs);
            _currentError = CurrentElement.ExpectedOutputs[0] - _currentResponse;
            _progressHistory.Buffer.Add((float)Math.Abs(_currentError));

            _teachingStep++;
        }

        internal double PerformExperiment(double[] inputSignals)
        {
            double[] normalizedSignals = (double[])inputSignals.Clone();
            Neuron.Normalize(normalizedSignals);
            return _examinedNeuron.Response(normalizedSignals);
        }

    }
}
