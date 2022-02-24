using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    [Serializable]
    public class Input
    {
        public double Value { get; set; }
        public double Weight { get; set; }
        public int ConnectedWithPreviousLayerNeuronNo { get; set; }

        public Input(int connectedWithPreviousLayerNeuronNo) 
        {
            ConnectedWithPreviousLayerNeuronNo = connectedWithPreviousLayerNeuronNo;
        }

        public Input() { }
    }
}
