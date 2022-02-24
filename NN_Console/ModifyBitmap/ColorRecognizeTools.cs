using NeuralNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ModifyBitmap
{
    class ColorRecognizeTools
    {
        readonly int MAX_LOG = 5000;
        Color colorToRecognize;
        NeuralNetwork neuralNetwork = null;
        public String Log = "";

        List<Color> definedColors = new List<Color>()
        {
           Color.FromArgb(255, 0, 0),
           Color.FromArgb(0, 255, 0),
           Color.FromArgb(0, 0, 255),
           Color.FromArgb(0, 0, 0),
           Color.FromArgb(255, 255, 255),

           Color.FromArgb(255, 255, 0),
           Color.FromArgb(255, 0, 190),
           Color.FromArgb(255, 103, 255),
           Color.FromArgb(152, 76, 0),
           Color.FromArgb(124, 24, 24),

           Color.FromArgb(127, 127, 127),

        };

        /*
        1	255	0	0
        2	0	255	0
        3	0	0	255
        4	0	0	0
        5	255	255	255

        6	255	255	0
        7	255	0	190
        8	255	103	255
        9	152	76	0
        10	124	24	24 */

        public ColorRecognizeTools(String filename = "colors.nnc")
        {
            neuralNetwork = NeuralNetwork.LoadNetworkFromFile(filename);
        }

        public Color RecognizeColorByNN(Color color, ref bool collectDebugInformations)
        {
            List<double> inputs = new List<double>()
            {
                color.R / 255.0,
                color.G / 255.0,
                color.B / 255.0
            };

            if (neuralNetwork.Topology.IsNetworkUsingBiases) inputs.Add(1);
            neuralNetwork.PropagateValuesForward(inputs);
            double[] outputs = neuralNetwork.NetworkOutputs();
            int maxIdx = 0;
            double maxValue = 0;

            for (int outputNo = 0; outputNo < outputs.Length; outputNo++)
            {
                double neuronOutput = outputs[outputNo];

                /*Log += String.Format(
                        "Neuron no. {0,2} has value {1,7:0.000}%\r\n",
                        outputNo,
                        outputs[outputNo] * 100);*/

                if (neuronOutput > maxValue)
                {
                    maxIdx = outputNo;
                    maxValue = neuronOutput;
                }
            }

            if (collectDebugInformations) {
                if (Log.Length < MAX_LOG && maxValue < 0.10)
                {
                    Log += color.R + ";" + color.G + ";" + color.B + ";" + (maxValue * 100) + "\r\n";
                    /*Log += String.Format(
                        "For color {0} maximum value has neuron no {1} with value {2, 0:0.000}%\r\n",
                        color.ToString(),
                        maxIdx,
                        maxValue * 100);*/
                } else if (Log.Length >= MAX_LOG)
                {
                    collectDebugInformations = false;
                }
            }

            return definedColors[maxIdx];
        }

        public bool IsNetworkLoaded()
        {
            return neuralNetwork != null;
        }
    }
}
