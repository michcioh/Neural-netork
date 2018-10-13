using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNet
{
    public class LayerCreationInfo
    {
        public int HowManyNeuronsPerLayer { get; set; }
        public NeuralNetwork.ActivationFunction LayerActivationFunction { get; set; }
        public int LayerNo { get; set; }
        public int PreviousLayerNeuronsCount { get; set; }
        /*public bool AddBiasNeuron { get; set; }*/ // it is information about network, not layer
    }
}
