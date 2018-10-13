using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Neural
{
    [Serializable]
    public class DataLearnDecription
    {
        public int InputQuantity { get; set; }
        public int OutputQuantity { get; set; }
        public List<Size> InputPossibleDimensions { get; set; }
        public List<Size> OutputPossibleDimensions { get; set; }
        public List<MappedValue> MappedInputs { get; set; }
        public List<MappedValue> MappedOutputs { get; set; }
        public int InputDimensionIndex { get; set; }
        public int OutputDimensionIndex { get; set; }

        public DataLearnDecription()
        {
            InputPossibleDimensions = new List<Size>();
            OutputPossibleDimensions = new List<Size>();
            MappedInputs = new List<MappedValue>();
            MappedOutputs = new List<MappedValue>();
        }
        
    }
}
