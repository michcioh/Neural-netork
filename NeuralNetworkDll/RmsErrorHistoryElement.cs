using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNet
{
    [Serializable]
    public class RmsErrorHistoryElement
    {
        public long EpochNo { get; set; }
        public double RmsError { get; set; }
    }
}
