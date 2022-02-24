using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    [Serializable]
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }
        public int LayerNo { get; set; }
        public NeuralNetwork.ActivationFunction LayerActivationFunction;
        public LayerType Type { get; set; }
        public double MinWeight;
        public double MaxWeight;

        private int PreviousLayerNeuronsCount;

        public Layer() {
            // do not use!
        }

        public Layer (LayerCreationInfo layerCreationInfo, bool IsNetworkUsingBias, LayerType type, double minWeight, double maxWeight)
        {
            LayerNo = layerCreationInfo.LayerNo;
            PreviousLayerNeuronsCount = layerCreationInfo.PreviousLayerNeuronsCount;
            LayerActivationFunction = layerCreationInfo.LayerActivationFunction;
            this.Type = type;
            this.MinWeight = minWeight;
            this.MaxWeight = maxWeight;

            Neurons = new List<Neuron>();

            for (int i = 0; i< layerCreationInfo.HowManyNeuronsPerLayer; i++)
            {
                Neurons.Add(new Neuron(
                    LayerNo == 0 ?  1 : PreviousLayerNeuronsCount,
                    layerCreationInfo.LayerNo, 
                    false,
                    layerCreationInfo.LayerActivationFunction, 
                    MinWeight, 
                    MaxWeight));
            }

            if (IsNetworkUsingBias && type != LayerType.OUTPUT)
            {
                Neurons.Last().IsBias = true;
            }
        }

        public void SetInputsDataAndOutputsForFirstLayer(List<double> inputsDataForFirstLayer)
        {
            for (int neuronNo = 0; neuronNo < Neurons.Count; neuronNo++)
            {
                Neuron neuron = Neurons.ElementAt(neuronNo);
                neuron.Inputs.ElementAt(0).Value = inputsDataForFirstLayer.ElementAt(neuronNo);
                neuron.CountOutput();
            }
        }
        
        public void ResetNeuronsOfLayer(double minWeight, double maxWeight)
        {
            for (int neuronNo = 0; neuronNo < Neurons.Count; neuronNo++)
            {
                Neurons.ElementAt(neuronNo).ResetNeuron();
            }
        }

        public enum LayerType
        {
            INPUT,
            HIDDEN,
            OUTPUT
        }
    }
}
