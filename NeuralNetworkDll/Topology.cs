using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    [Serializable]
    public class Topology
    {
        public List<Layer> Layers { get; set; }
        public bool IsNetworkUsingBiases { get; set; }
        public int OutputCount { get; set; }

        public Topology() { }

        public Topology(List<LayerCreationInfo> layerCreationInfo, bool isNetworkUsingBias)
        {
            this.IsNetworkUsingBiases = isNetworkUsingBias;

            Layers = new List<Layer>();

            for (int layerNo = 0; layerNo < layerCreationInfo.Count; layerNo++)
            {
                Layer layer = new Layer(
                    layerCreationInfo.ElementAt(layerNo), 
                    (isNetworkUsingBias && layerNo < layerCreationInfo.Count - 1),
                    (layerNo == 0) ? Layer.LayerType.INPUT : 
                        (layerNo == layerCreationInfo.Count - 1) ? Layer.LayerType.OUTPUT : Layer.LayerType.HIDDEN
                );
                
                Layers.Add(layer);
            }

            OutputCount = Layers.Last().Neurons.Count;
        }

        public List<double> NetworkInputValues()
        {
            List<double> ret = new List<double>();

            for (int neuronNo = 0; neuronNo < Layers.First().Neurons.Count; neuronNo++)
            {
                ret.Add(Layers.First().Neurons.ElementAt(neuronNo).Inputs[0].Value);
            }

            return ret;
        }

        public double[] NetworkOutputValues()
        {
            double[] ret = new double[Layers.Last().Neurons.Count];

            for (int neuronNo = 0; neuronNo < Layers.Last().Neurons.Count; neuronNo++)
            {
                ret[neuronNo] = Layers.Last().Neurons.ElementAt(neuronNo).GetOutputValue();
            }

            return ret;
        }

        public int GetInputCount(bool withBias)
        {
            int inputWithBiasCount = Layers.First().Neurons.Count;

            return IsNetworkUsingBiases ?
                (withBias ? inputWithBiasCount : inputWithBiasCount - 1) :
                inputWithBiasCount;
        }
    }
}
