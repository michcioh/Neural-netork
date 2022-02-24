using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    [Serializable]
    public class Neuron
    {
        public List<Input> Inputs { get; set; }
        public List<Input> PreviousInputs { get; set; }
        private double OutputValue { get; set; }
        public bool IsBias { get; set; }
        public double BiasValue { get; set; }
        public int LayerNo { get; set; }
        public NeuralNetwork.ActivationFunction ActivationFunction { get; set; }
        public double Gradient { get; set; }
        public double Error { get; set; }
        public Neuron() { }

        public Neuron (int inputsCount, int layerNo, bool isBias, NeuralNetwork.ActivationFunction activationFunction, double biasValue = -1.0)
        {
            IsBias = isBias;
            BiasValue = biasValue;
            LayerNo = layerNo;
            this.ActivationFunction = activationFunction;

            Inputs = new List<Input>();
            PreviousInputs = new List<Input>();

            for (int inputNo = 0; inputNo < inputsCount; inputNo++)
            {
                Inputs.Add(new Input(inputNo));
                PreviousInputs.Add(new Input(inputNo));
            }

            ResetNeuron();
        }

        public void CountOutput()
        {

            double value = Inputs.Sum(c => c.Value * c.Weight);

            OutputValue = LayerNo == 0? 
                Inputs[0].Value :
                IsBias ?
                    BiasValue : 
                    Calculations.ActivationFunction(value, ActivationFunction);
        }

        public void ResetNeuron()
        {
            int inputsCnt = Inputs.Count;
            Inputs.Clear();
            PreviousInputs.Clear();

            for (int inputNo = 0; inputNo < inputsCnt; inputNo++)
            {
                if (LayerNo == 0)
                {
                    Inputs.Add(new Input() { Value = 0.0, Weight = 1.0, ConnectedWithPreviousLayerNeuronNo = -1 });
                    PreviousInputs.Add(new Input() { Value = 0.0, Weight = 1.0, ConnectedWithPreviousLayerNeuronNo = -1 });
                }
                else
                {
                    double weight = new RandomWeight().GenerateRandomWeight();
                    Inputs.Add(new Input() {
                        Value = IsBias ? BiasValue : 0.0,
                        Weight = weight,
                        ConnectedWithPreviousLayerNeuronNo = inputNo
                    });

                    PreviousInputs.Add(new Input()
                    {
                        Value = IsBias ? BiasValue : 0.0,
                        Weight = weight,
                        ConnectedWithPreviousLayerNeuronNo = inputNo
                    });
                }
            }
        }

        public double GetOutputValue()
        {
            return (IsBias ? 1 : OutputValue);
        }
        
        // not used
        public void SetOutputValue(double outputValue)
        {
            if (!IsBias)
            {
                OutputValue = outputValue;
            }
        }
    }
}
