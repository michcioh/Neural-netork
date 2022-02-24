using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    [Serializable]
    public class LearnSample
    {
        public List<double> InputData { get; set; }
        public double[] OutputData { get; set; }
        public bool InputDataContainsBias { get; set; }

        public LearnSample(int outputCount)
        {
            InputData = new List<double>();
            OutputData = new double[outputCount];
            InputDataContainsBias = false;
        }
    }
}
