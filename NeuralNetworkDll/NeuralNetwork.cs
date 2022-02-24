using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    [Serializable]

    public class NeuralNetwork : ICloneable
    {
        public Topology Topology { get; set; }

        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public string Name { get; set; }
        public double NetworkError { get; set; }
        public bool NetworkErrorSet { get; set; }
        public LearningMethod MethodOfLearning { get; set; }
        public List<Epoch> EpochHistory = new List<Epoch>();
        public List<RmsErrorHistoryElement> RmsErrorHistory = new List<RmsErrorHistoryElement>();
        public long CollectSparseHistoryEvery { get; set; }
        /*public double Momentum { get; set; }
        public double Ratio { get; set; }*/
        public bool PreviousInputsSet { get; set; }

        public NeuralNetwork()
        {
            /*Ratio = 0.7;
            Momentum = 0.3;*/
        }

        public NeuralNetwork (
            Topology topology,
            double minWeight,
            double maxWeight,
            LearningMethod learningMethod,
            String name,
            long collectSparseHistoryEvery = 100000)
        {
            Topology = topology;
            this.MethodOfLearning = learningMethod;
            this.Name = name;

            NetworkError = 0;
            NetworkErrorSet = false;
            this.MinWeight = minWeight;
            this.MaxWeight = MaxWeight;
            this.CollectSparseHistoryEvery = collectSparseHistoryEvery;
            PreviousInputsSet = false;
        }

        public void PrepareToLearn()
        {
            #region Set PreviousInputs of all neurons
            SetPreviousInputs();
            PreviousInputsSet = true;
            #endregion
        }

        public List<double> Learn(LearnSample learnSample, double learningRate, double momentum, out String errorMessage, long epochNo)
        {
            #region Validation input data
            errorMessage = null;

            if (!learnSample.InputDataContainsBias)
            {
                learnSample.InputData.Add(1);
                learnSample.InputDataContainsBias = true;
            }

            if (learnSample.InputData.Count != Topology.Layers.First().Neurons.Count)
            {
                errorMessage = "Count of input data in learn sample is different than count of neurons on first layer!";
                return null;
            }

            if (learnSample.OutputData.Length != Topology.Layers.Last().Neurons.Count)
            {
                errorMessage = "Count of output data in learn sample is different than count of neurons on last layer!";
                return null;
            }
            #endregion

            #region Propagete values forward to be sure we work on proper data
            PropagateValuesForward(learnSample.InputData);
            #endregion

            #region Main learning
            int layerNo;
            double error;

            Layer lastLayer = Topology.Layers.Last();

            switch (MethodOfLearning)
            {
                case LearningMethod.LINEAR:
                    double neuronExpectedValue = learnSample.OutputData.ElementAt(0);

                    for (layerNo = Topology.Layers.Count - 1; layerNo >= 1; layerNo--) // layerNo >= 1 ---> are you sure >=
                    {
                        Layer layer = Topology.Layers.ElementAt(layerNo);

                        for (int neuronNo = 0; neuronNo < layer.Neurons.Count; neuronNo++)
                        {
                            Neuron neuron = layer.Neurons.ElementAt(neuronNo);

                            if (!neuron.IsBias)
                            {
                                //double error = neuronExpectedValue - neuron.OutputValue;
                                error = (neuronExpectedValue - neuron.GetOutputValue()) * neuron.GetOutputValue() * (1 - neuron.GetOutputValue());

                                for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                                {
                                    double correction = error * neuron.Inputs[inputNo].Value * learningRate;

                                    neuron.Inputs[inputNo].Weight += correction;
                                }
                            }
                        }
                    }
                    break;

                case LearningMethod.NOT_LINEAR:
                    // 1. Counting gradients for all not-bias neurons from layers [n..1]

                    // 1A. Counting gradients for last layer:
                    for (int outputNeuronNo = 0; outputNeuronNo < lastLayer.Neurons.Count; outputNeuronNo++)
                    {
                        double outputValue = Topology.Layers.Last().Neurons[outputNeuronNo].GetOutputValue();
                        error = learnSample.OutputData[outputNeuronNo] - outputValue;

                        double derivative = Calculations.Derivative(
                            outputValue,
                            Topology.Layers.Last().LayerActivationFunction);

                        Topology.Layers.Last().Neurons[outputNeuronNo].Error = error;
                        Topology.Layers.Last().Neurons[outputNeuronNo].Gradient = error * derivative;
                    }

                    // 1B. Counting gradients for previous layers, starting counting from inputs-connections of output neurons:
                    layerNo = Topology.Layers.Count - 2;

                    while (layerNo > 0)
                    {
                        for (int neuronNo = 0; neuronNo < Topology.Layers[layerNo].Neurons.Count; neuronNo++)
                        {
                            Neuron neuron = Topology.Layers[layerNo].Neurons[neuronNo];

                            neuron.Error = 0;

                            for (int neuronNextLayerNo = 0; neuronNextLayerNo < Topology.Layers[layerNo + 1].Neurons.Count; neuronNextLayerNo++)
                            {
                                Neuron neuronNextLayer = Topology.Layers[layerNo + 1].Neurons[neuronNextLayerNo];

                                neuron.Error += neuronNextLayer.Gradient * neuronNextLayer.Inputs[neuronNo].Weight;
                            }

                            double derivative = Calculations.Derivative(
                                neuron.GetOutputValue(),
                                Topology.Layers[layerNo].LayerActivationFunction);

                            neuron.Gradient = neuron.Error * derivative;
                        }

                        layerNo--;
                    }

                    // 2. Changing weights:
                    layerNo = Topology.Layers.Count - 1;

                    while (layerNo > 0)
                    {
                        for (int neuronNo = 0; neuronNo < Topology.Layers[layerNo].Neurons.Count; neuronNo++)
                        {
                            Neuron neuron = Topology.Layers[layerNo].Neurons[neuronNo];
                            for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                            {
                                neuron.Inputs[inputNo].Weight += learningRate * neuron.Gradient * neuron.Inputs[inputNo].Value -
                                    momentum * (neuron.Inputs[inputNo].Weight - neuron.PreviousInputs[inputNo].Weight);
                            }
                        }

                        layerNo--;
                    }

                    // 3. Counting current network error:
                    NetworkError = Calculations.RMSError(learnSample.OutputData, Topology.NetworkOutputValues());
                    NetworkErrorSet = true;
                    break;
            }

            PropagateValuesForward();
            #endregion

            #region Saving epoch in history
            if (epochNo % CollectSparseHistoryEvery == 0)
            {
                List<double> inputValues = new List<double>();
                foreach (Neuron neuron in Topology.Layers.First().Neurons)
                {
                    inputValues.Add(neuron.Inputs[0].Value);
                }

                List<double> outputValues = new List<double>();
                foreach (Neuron neuron in Topology.Layers.Last().Neurons)
                {
                    outputValues.Add(neuron.GetOutputValue());
                }

                Epoch epoch = new Epoch()
                {
                    InputValues = inputValues,
                    OutputValues = outputValues,
                    ExpectedOutputValues = learnSample.OutputData.ToList(),
                    LearningRate = learningRate,
                    EpochNo = epochNo
                };

                EpochHistory.Add(epoch);
                RmsErrorHistory.Add(
                    new RmsErrorHistoryElement() { RmsError = NetworkError, EpochNo = epochNo }
                );
            }
            #endregion

            #region Set PreviousInputs of all neurons
            SetPreviousInputs();
            #endregion

            #region Preparing data to return
            List<double> result = new List<double>();

            for (int neuronNo = 0; neuronNo < lastLayer.Neurons.Count; neuronNo++)
            {
                result.Add(lastLayer.Neurons.ElementAt(neuronNo).GetOutputValue());
            }
            #endregion

            return result;

            #region examples from other applications
            /*
            // from Internet example ;)
            _layers.Last().Neurons.ForEach(neuron =>
            {
                neuron.Inputs.ForEach(connection =>
                {
                    var output = neuron.CalculateOutput();
                    var netInput = connection.GetOutput();

                    var expectedOutput = _expectedResult[row][_layers.Last().Neurons.IndexOf(neuron)];

                    var nodeDelta = (expectedOutput - output) * output * (1 - output);
                    var delta = -1 * netInput * nodeDelta;

                    connection.UpdateWeight(_learningRate, delta);

                    neuron.PreviousPartialDerivate = nodeDelta;
                });
            });*/

            /*
            //From book's example 
            double neuronExpectedValue = learnSample.OutputData.ElementAt(0);

            for (int layerNo = Topology.Layers.Count - 1; layerNo >= 1; layerNo--) // layerNo >= 1 ---> are you sure >=
            {
                Layer layer = Topology.Layers.ElementAt(layerNo);

                for (int neuronNo = 0; neuronNo < layer.Neurons.Count; neuronNo++)
                {
                    Neuron neuron = layer.Neurons.ElementAt(neuronNo);

                    if (!neuron.IsBias)
                    {
                        //double error = neuronExpectedValue - neuron.OutputValue;
                        double error = (neuronExpectedValue - neuron.OutputValue) * neuron.OutputValue * (1 - neuron.OutputValue);

                        for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                        {
                            double correction = error * neuron.Inputs[inputNo].Value * learningRate;

                            neuron.Inputs[inputNo].Weight += correction;
                        }
                    }
                }
            }*/
            #endregion
        }

        public void SetPreviousInputs()
        {
            for (int layerNo = Topology.Layers.Count - 1; layerNo >= 1; layerNo--) // layerNo >= 1 ---> are you sure >=
            {
                Layer layer = Topology.Layers.ElementAt(layerNo);

                for (int neuronNo = 0; neuronNo < layer.Neurons.Count; neuronNo++)
                {
                    Neuron neuron = layer.Neurons.ElementAt(neuronNo);
                    for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                    {
                        neuron.PreviousInputs[inputNo].Weight = neuron.Inputs[inputNo].Weight;
                    }
                    
                }
            }
        }

        public List<double> Learn_old(LearnSample learnSample, double learningRate, out String errorMessage, long epochNo)
        {
            #region Validation input data
            errorMessage = null;

            if (!learnSample.InputDataContainsBias)
            {
                learnSample.InputData.Add(1);
                learnSample.InputDataContainsBias = true;
            }

            if (learnSample.InputData.Count != Topology.Layers.First().Neurons.Count)
            {
                errorMessage = "Count of input data in learn sample is different than count of neurons on first layer!";
                return null;
            }

            if (learnSample.OutputData.Length != Topology.Layers.Last().Neurons.Count)
            {
                errorMessage = "Count of output data in learn sample is different than count of neurons on last layer!";
                return null;
            }
            #endregion

            #region Propagete values forward to be sure we work on proper data
            PropagateValuesForward(learnSample.InputData);
            #endregion

            #region Main learning
            int layerNo;
            double error;

            Layer lastLayer = Topology.Layers.Last();

            switch (MethodOfLearning)
            {
                case LearningMethod.LINEAR:
                    double neuronExpectedValue = learnSample.OutputData.ElementAt(0);

                    for (layerNo = Topology.Layers.Count - 1; layerNo >= 1; layerNo--) // layerNo >= 1 ---> are you sure >=
                    {
                        Layer layer = Topology.Layers.ElementAt(layerNo);

                        for (int neuronNo = 0; neuronNo < layer.Neurons.Count; neuronNo++)
                        {
                            Neuron neuron = layer.Neurons.ElementAt(neuronNo);

                            if (!neuron.IsBias)
                            {
                                //double error = neuronExpectedValue - neuron.OutputValue;
                                error = (neuronExpectedValue - neuron.GetOutputValue()) * neuron.GetOutputValue() * (1 - neuron.GetOutputValue());

                                for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                                {
                                    double correction = error * neuron.Inputs[inputNo].Value * learningRate;

                                    neuron.Inputs[inputNo].Weight += correction;
                                }
                            }
                        }
                    }
                    break;

                case LearningMethod.NOT_LINEAR:
                    // 1. Counting gradients for all not-bias neurons from layers [n..1]

                    // 1A. Counting gradients for last layer:
                    for (int outputNeuronNo = 0; outputNeuronNo < lastLayer.Neurons.Count; outputNeuronNo++)
                    {
                        double outputValue = Topology.Layers.Last().Neurons[outputNeuronNo].GetOutputValue();
                        error = learnSample.OutputData[outputNeuronNo] - outputValue;

                        double derivative = Calculations.Derivative(
                            outputValue,
                            Topology.Layers.Last().LayerActivationFunction);

                        Topology.Layers.Last().Neurons[outputNeuronNo].Gradient = error * derivative;
                    }

                    // 1B. Counting gradients for previous layers, starting counting from inputs-connections of output neurons:
                    layerNo = Topology.Layers.Count - 1;
                    
                    while (layerNo > 0)
                    {
                        // for each neuron in current layer (layerNo) change gradients of non-bias connected neurons from previous layer
                        foreach(Neuron neuron in Topology.Layers[layerNo].Neurons)
                        {
                            foreach (Input input in neuron.Inputs)
                            {
                                Neuron connectedNeuron = Topology.Layers[layerNo - 1].Neurons[input.ConnectedWithPreviousLayerNeuronNo];

                                if (!connectedNeuron.IsBias)
                                {
                                    double derivative = Calculations.Derivative(
                                        connectedNeuron.GetOutputValue(), 
                                        Topology.Layers[layerNo - 1].LayerActivationFunction);

                                    connectedNeuron.Gradient = neuron.Gradient * input.Weight * derivative;
                                }
                            }
                        }

                        layerNo--;
                    }

                    // 2. Changing weights:
                    layerNo = Topology.Layers.Count - 1;

                    while (layerNo > 0)
                    {
                        // for each neuron in current layer (layerNo) change weights of his inputs
                        foreach (Neuron neuron in Topology.Layers[layerNo].Neurons)
                        {
                            foreach (Input input in neuron.Inputs)
                            {
                                Neuron connectedNeuron = Topology.Layers[layerNo - 1].Neurons[input.ConnectedWithPreviousLayerNeuronNo];
                                input.Weight += learningRate * neuron.Gradient * connectedNeuron.GetOutputValue();
                            }
                        }

                        layerNo--;
                    }

                    // 3. Counting current network error:
                    NetworkError = Calculations.RMSError(learnSample.OutputData, Topology.NetworkOutputValues());
                    NetworkErrorSet = true;
                    break;
            }

            PropagateValuesForward();
            #endregion

            #region Saving epoch in history
            if (epochNo % CollectSparseHistoryEvery == 0)
            {
                List<double> inputValues = new List<double>();
                foreach (Neuron neuron in Topology.Layers.First().Neurons)
                {
                    inputValues.Add(neuron.Inputs[0].Value);
                }

                List<double> outputValues = new List<double>();
                foreach (Neuron neuron in Topology.Layers.Last().Neurons)
                {
                    outputValues.Add(neuron.GetOutputValue());
                }

                Epoch epoch = new Epoch()
                {
                    InputValues = inputValues,
                    OutputValues = outputValues,
                    ExpectedOutputValues = learnSample.OutputData.ToList(),
                    LearningRate = learningRate,
                    EpochNo = epochNo
                };

                EpochHistory.Add(epoch);
                RmsErrorHistory.Add(
                    new RmsErrorHistoryElement() { RmsError = NetworkError, EpochNo = epochNo }
                );
            }
            #endregion

            #region Preparing data to return
            List<double> result = new List<double>();

            for (int neuronNo = 0; neuronNo < lastLayer.Neurons.Count; neuronNo++)
            {
                result.Add(lastLayer.Neurons.ElementAt(neuronNo).GetOutputValue());
            }
            #endregion

            return result;

            #region examples from other applications
            /*
            // from Internet example ;)
            _layers.Last().Neurons.ForEach(neuron =>
            {
                neuron.Inputs.ForEach(connection =>
                {
                    var output = neuron.CalculateOutput();
                    var netInput = connection.GetOutput();

                    var expectedOutput = _expectedResult[row][_layers.Last().Neurons.IndexOf(neuron)];

                    var nodeDelta = (expectedOutput - output) * output * (1 - output);
                    var delta = -1 * netInput * nodeDelta;

                    connection.UpdateWeight(_learningRate, delta);

                    neuron.PreviousPartialDerivate = nodeDelta;
                });
            });*/

            /*
            //From book's example 
            double neuronExpectedValue = learnSample.OutputData.ElementAt(0);

            for (int layerNo = Topology.Layers.Count - 1; layerNo >= 1; layerNo--) // layerNo >= 1 ---> are you sure >=
            {
                Layer layer = Topology.Layers.ElementAt(layerNo);

                for (int neuronNo = 0; neuronNo < layer.Neurons.Count; neuronNo++)
                {
                    Neuron neuron = layer.Neurons.ElementAt(neuronNo);

                    if (!neuron.IsBias)
                    {
                        //double error = neuronExpectedValue - neuron.OutputValue;
                        double error = (neuronExpectedValue - neuron.OutputValue) * neuron.OutputValue * (1 - neuron.OutputValue);

                        for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                        {
                            double correction = error * neuron.Inputs[inputNo].Value * learningRate;

                            neuron.Inputs[inputNo].Weight += correction;
                        }
                    }
                }
            }*/
            #endregion
        }

        public List<double> CountOutputData(List<double> inputData, out String errorMessage)
        {
            #region Validation input data
            errorMessage = null;

            if (inputData.Count != Topology.Layers.First().Neurons.Count)
            {
                errorMessage = "Count of input data in learn sample is different than count of neurons on first layer!";
                return null;
            }
            #endregion

            PropagateValuesForward(inputData);

            #region Preparing data to return
            List<double> result = new List<double>();

            Layer lastLayer = Topology.Layers.Last();

            for (int neuronNo = 0; neuronNo < lastLayer.Neurons.Count; neuronNo++)
            {
                result.Add(lastLayer.Neurons.ElementAt(neuronNo).GetOutputValue());
            }
            #endregion

            return result;
        }

        public void PropagateValuesForward(List<double> networkInputsData = null, int firstLayerNoToChangeInputs = 1)
        {
            if (networkInputsData == null)
            {
                networkInputsData = Topology.NetworkInputValues();
            }

            #region First layer
            Layer firstLayer = Topology.Layers.First();
            firstLayer.SetInputsDataAndOutputsForFirstLayer(networkInputsData);
            #endregion

            #region Next layers
            for (int layerNo = firstLayerNoToChangeInputs; layerNo < Topology.Layers.Count; layerNo++)
            {
                Layer currentLayer = Topology.Layers.ElementAt(layerNo);
                Layer previousLayer = Topology.Layers.ElementAt(layerNo - 1);

                // Each neuron in current layer gets data from all neurons from previous layers and multiples it by his weight
                for (int neuronNo = 0; neuronNo < currentLayer.Neurons.Count; neuronNo++)
                {
                    Neuron neuron = currentLayer.Neurons.ElementAt(neuronNo);

                    // setting input values for neuron
                    for (int inputNo = 0; inputNo < neuron.Inputs.Count; inputNo++)
                    {
                        neuron.Inputs.ElementAt(inputNo).Value = previousLayer.Neurons.ElementAt(inputNo).GetOutputValue();
                    }

                    // let's neuron to count his output
                    neuron.CountOutput();
                }
            }
            #endregion
        }
        
        public void ResetNetwork()
        {
            for (int layerNo = 0; layerNo < Topology.Layers.Count; layerNo++)
            {
                Topology.Layers.ElementAt(layerNo).ResetNeuronsOfLayer();
            }

            PropagateValuesForward();

            EpochHistory.Clear();
            NetworkErrorSet = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public enum ActivationFunction
        {
            TANH = 0,
            SIGMOID = 1,
            SINUSOID = 2,
            BINARY_STEP = 3,
            NO_FUNCTION = 4
        }

        public enum LearningMethod
        {
            LINEAR,
            NOT_LINEAR
        }
    }
}
