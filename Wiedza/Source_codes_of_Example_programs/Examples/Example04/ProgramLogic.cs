using System;
using System.Collections.Generic;
using System.Text;
using RTadeusiewicz.NN.NeuralNetworks;
using RTadeusiewicz.NN.Controls;

namespace RTadeusiewicz.NN.Example04
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

        private TeachingSet _normalizedTeachingSet;

        internal TeachingSet NormalizedTeachingSet
        {
            get { return _normalizedTeachingSet; }
        }

        private LinearNetwork _examinedNetwork;

        internal LinearNetwork ExaminedNetwork
        {
            get { return _examinedNetwork; }
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

        internal TeachingSet.Element CurrentNormalizedElement
        {
            get { return _normalizedTeachingSet[_currentElementIndex]; }
        }

        private double[] _previousResponse;

        internal double[] PreviousResponse
        {
            get { return _previousResponse; }
        }

        private double[] _previousError;

        internal double[] PreviousError
        {
            get { return _previousError; }
        }

        private double[] _currentResponse;

        internal double[] CurrentResponse
        {
            get { return _currentResponse; }
        }

        private double[] _currentError;

        internal double[] CurrentError
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
            _examinedNetwork.Randomize(_randomGenerator, -0.1, 0.1);
            _currentElementIndex = -1;
            _teachingStep = 0;
        }

        internal void LoadTeachingSet(string fileName)
        {
            TeachingSet tset = NeuralNetworks.TeachingSet.FromFile(fileName);
            if (tset == null || tset.Count == 0)
                throw new ApplicationException("The file does not contain any data.");
            _teachingSetFileName = fileName;
            _teachingSet = tset;
            _normalizedTeachingSet = new TeachingSet(tset);
            _normalizedTeachingSet.Normalize();
            _examinedNetwork = new LinearNetwork(tset.InputCount, tset.OutputCount);
            InitializeTeaching();
        }

        internal void PerformTeaching(double teachingRatio)
        {
            /* We assume that we have non-zero amount of elements in the teaching set,
             * so we don't check if the 0 index is correct. This condition is
             * established by LoadTeachingSet(). */
            if (++_currentElementIndex >= _teachingSet.Count)
                _currentElementIndex = 0;

            _examinedNetwork.Learn(CurrentNormalizedElement, teachingRatio,
                ref _previousResponse, ref _previousError);

            _currentResponse =
                _examinedNetwork.Response(CurrentNormalizedElement.Inputs);
            _currentError = new double[_currentResponse.Length];
            for (int i = 0; i < _currentResponse.Length; i++)
                _currentError[i] =
                    CurrentElement.ExpectedOutputs[i] - _currentResponse[i];

            /*double avg = 0.0;
            foreach (double err in _currentError)
                avg += Math.Abs(err);
            avg /= _currentError.Length;
            _progressHistory.Buffer.Add((float)avg);*/

            double avg = 0.0;
            foreach (TeachingSet.Element elem in _normalizedTeachingSet)
            {
                double[] resp = _examinedNetwork.Response(elem.Inputs);
                for (int i = 0; i < resp.Length; i++)
                    avg += Math.Abs(elem.ExpectedOutputs[i] - resp[i]);
            }
            avg /= _examinedNetwork.Neurons.Length * _normalizedTeachingSet.Count;
            _progressHistory.Buffer.Add((float)avg);

            _teachingStep++;
        }

        internal double[] PerformExperiment(double[] inputSignals)
        {
            double[] normalizedSignals = (double[])inputSignals.Clone();
            Neuron.Normalize(normalizedSignals);
            return _examinedNetwork.Response(normalizedSignals);
        }

    }
}
