using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class Calculations
    { 
        public static double ActivationFunction(double value, NeuralNetwork.ActivationFunction activationFunction)
        {
            double result = 0.0;

            switch (activationFunction)
            {
                case NeuralNetwork.ActivationFunction.TANH:
                    // someone says: "approximation is correct to 30 decimals", so:
                    if (value < -20.0)
                    {
                        result = -1.0;
                    }
                    else if (value > 20.0)
                    {
                        result = 1.0;
                    }
                    else
                    {
                        result = Math.Tanh(value);
                    }

                    break;

                case NeuralNetwork.ActivationFunction.SIGMOID:
                    result = 1.0 / (1.0 + Math.Exp(-value));
                    break;

                case NeuralNetwork.ActivationFunction.SINUSOID:
                    result = Math.Sin(value);
                    break;

                case NeuralNetwork.ActivationFunction.BINARY_STEP:
                    result = value < 0 ? 0 : 1;
                    break;

                case NeuralNetwork.ActivationFunction.NO_FUNCTION:
                    result = value;
                    break;

                default:
                    throw new Exception("Function " + activationFunction.ToString() + "not implemented in CountOutput!");
            }

            return result;
        }

        public static double Derivative(double x, NeuralNetwork.ActivationFunction activationFunction)
        {
            switch (activationFunction)
            {
                case NeuralNetwork.ActivationFunction.SIGMOID:
                    return DerivativeSigmoid(x);
                case NeuralNetwork.ActivationFunction.TANH:
                    return DerivativeTanh(x);
                default:
                    throw new Exception("Counting derivative for not implemented case");
            }
        }

        public static double DerivativeSigmoid(double x)
        {
            return (1 - x) * x; // derivative of log-sigmoid is y(1-y)
        }

        public static double DerivativeTanh(double x)
        {
            return (1 - x)*(1 + x); // derivative of tanh is (1-y)(1+y)
        }

        public static double RMSError(double[] outputs, double[] expectedOutputs)
        {
            try
            {
                if (outputs.Length != expectedOutputs.Length || outputs.Length == 0)
                {
                    throw new Exception("Outputs and expectedOutputs arrays size not equal or equal 0");
                }

                double sum = 0;
                for (int outputNeuronNo = 0; outputNeuronNo < outputs.Length; outputNeuronNo++)
                {
                    sum += Math.Pow(expectedOutputs[outputNeuronNo] - outputs[outputNeuronNo], 2);
                }

                double error = Math.Sqrt(sum / outputs.Length);

                return error;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static double NetworkError(double[] outputs, double[] expectedOutputs)
        {
            try
            {
                if (outputs.Length != expectedOutputs.Length || outputs.Length == 0)
                {
                    throw new Exception("Outputs and expectedOutputs arrays size not equal or equal 0");
                }

                double error = 0;
                for (int outputNeuronNo = 0; outputNeuronNo < outputs.Length; outputNeuronNo++)
                {
                    error += Math.Pow(expectedOutputs[outputNeuronNo] - outputs[outputNeuronNo], 2) / 2;
                }

                return error;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
