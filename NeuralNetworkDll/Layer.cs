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

        private int PreviousLayerNeuronsCount;

        public Layer() { }

        public Layer (LayerCreationInfo layerCreationInfo, bool IsNetworkUsingBias, LayerType type)
        {
            LayerNo = layerCreationInfo.LayerNo;
            PreviousLayerNeuronsCount = layerCreationInfo.PreviousLayerNeuronsCount;
            LayerActivationFunction = layerCreationInfo.LayerActivationFunction;
            this.Type = type;

            Neurons = new List<Neuron>();

            for (int i = 0; i< layerCreationInfo.HowManyNeuronsPerLayer; i++)
            {
                Neurons.Add(new Neuron(
                    LayerNo == 0 ?  1 : PreviousLayerNeuronsCount,
                    layerCreationInfo.LayerNo, 
                    false,
                    layerCreationInfo.LayerActivationFunction));
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
        
        public void ResetNeuronsOfLayer()
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
