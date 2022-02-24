using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNet
{
    [Serializable]
    public class Epoch
    {
        public List<double> InputValues { get; set; }
        public List<double> OutputValues { get; set; }
        public List<double> ExpectedOutputValues { get; set; }
        public double LearningRate { get; set; }
        public long EpochNo { get; set; }
    }
}
