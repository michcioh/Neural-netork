using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ModifyBitmap;
using NeuralNet;


namespace NN_Console
{
    class Program
    {
        static readonly bool TAKE_PARAMETERS_FROM_USER = true;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Neural network");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose option:");
                Console.WriteLine("F1 - Create and learn network");
                Console.WriteLine("F2 - Load network");
                //Console.WriteLine("F10 - Run modify bitmap app");
                Console.WriteLine("F12 - Quit app");
                Console.WriteLine();
                Console.Write("Your decision: ");

                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.F1)
                {
                    LearnNetworkOption();
                }
                else if (cki.Key == ConsoleKey.F2)
                {
                    LoadNetworkOption();
                }
                else if (cki.Key == ConsoleKey.F10)
                {
                    WindowModifyBitmap app = new ModifyBitmap.WindowModifyBitmap();
                    app.Show();
                }
                else if (cki.Key == ConsoleKey.F12)
                {
                    System.Environment.Exit(0);
                }

            }
        }

        private static void LoadNetworkOption()
        {
            Console.Clear();

            bool run = true;
            String filename = null;

            while (run)
            {
                bool ok = false;
                while (!ok)
                {
                    Console.Write("Enter name of *.nnc file [back to main menu]: ");
                    filename = Console.ReadLine();

                    if (filename.Length == 0)
                    {
                        run = false;
                        ok = false;
                        break;
                    }

                    FileInfo fi = new FileInfo(filename);
                    ok = fi.Exists;
                    
                    if (!ok)
                    {
                        filename += ".nnc";
                        fi = new FileInfo(filename);
                        ok = fi.Exists;

                        if (!ok)
                        {
                            Console.WriteLine("File not exists.");
                        }
                    }

                    if (!ok)
                    {
                        Console.WriteLine("File not exists.");
                    }
                }

                if (!ok)
                {
                    run = false;
                    break;
                }
                else
                {

                    NeuralNetwork neuralNetwork = NeuralNetwork.LoadNetworkFromFile(filename);

                    if (neuralNetwork == null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Loading network finished with error...");
                        Console.WriteLine();
                    } 
                    else
                    {
                        Console.WriteLine("Network loaded with success from " + filename + " file.");
                        Console.WriteLine();

                        bool inputProvide = true;
                        do {
                            Console.WriteLine("Write input values:");
                            List<double> inputs = new List<double>();
                            int neuronsCount = neuralNetwork.Topology.Layers[0].Neurons.Count;
                            if (neuralNetwork.Topology.IsNetworkUsingBiases) neuronsCount--;

                            for (int neuronNo = 0; neuronNo < neuronsCount; neuronNo++)
                            {
                                ok = false;
                                while (!ok)
                                {
                                    Console.Write("Input no. " + (neuronNo + 1) + ": ");
                                    String str = Console.ReadLine();
                                    Double d = 0.0;
                                    ok = double.TryParse(str, out d);
                                    inputs.Add(d);
                                }

                            }

                            if (neuralNetwork.Topology.IsNetworkUsingBiases) inputs.Add(1);

                            neuralNetwork.PropagateValuesForward(inputs);
                            Console.WriteLine("Network outputs:");
                            Console.WriteLine();

                            Console.WriteLine("Output no.   Output value");

                            List<Neuron> outputNeurons = neuralNetwork.Topology.Layers.Last().Neurons;
                            for (int neuronNo = 0; neuronNo < outputNeurons.Count; neuronNo++)
                            {
                                Console.WriteLine(
                                    String.Format(
                                        " {0,9} {1,13:0.000}%",
                                        neuronNo + 1,
                                        outputNeurons[neuronNo].GetOutputValue() * 100)
                                );
                            }

                            Console.WriteLine();
                            Console.Write("Press F12 to back to menu, other key to provide new input set: ");

                            ConsoleKeyInfo cki = Console.ReadKey();
                            if (cki.Key == ConsoleKey.F12)
                            {
                                inputProvide = false;
                                run = false;
                            }

                            Console.WriteLine();
                            Console.WriteLine();

                        } while (inputProvide);
                    }
                }
            }
        }

        private static void LearnNetworkOption()
        {
            long DEFAULT_MAX_EPOCH_NO = 10000;
            long DEFAULT_COLLECT_SPARSE_HISTORY_EVERY = 1000;
            double DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP = 0.99;

            int inputCount = 2;
            int outputCount = 1;
            List<int> defaultHiddenLayersNeuronsCount = new List<int> { 20, 20 };
            List<int> hiddenLayersNeuronsCount = new List<int>();
            String filename = "data.csv";
            String str = null;
            bool networkUseBias = true;
            NeuralNetwork.ActivationFunction activationFunction = NeuralNetwork.ActivationFunction.NO_FUNCTION;

            double learningRatio = 0.1;
            double momentum = 0.7;
            double minErrorPercentageToStop = DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP;
            long maxEpochNo = 0;
            long writeOnConsoleEveryEpoch = 1000;
            bool randomOrderOfLearningData = true;
            List<LearnSample> learningData = new List<LearnSample>();
            long collectSparseHistoryEvery = 1000;

            bool dataLoopRunning = true;

            List<Layer> layers = new List<Layer>();

            #region Data preparation

            while (dataLoopRunning)
            {
                learningRatio = 0.1;
                //minErrorPercentageToStop = DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP;
                filename = "data.csv";

                Console.Clear();
                Console.WriteLine("Creating and learning Neural Networks");

                bool ok = false;
                while (!ok)
                {
                    Console.Write("Input neurons count: ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : inputCount.ToString();
                    ok = int.TryParse(str, out inputCount);
                    if (ok) ok = (inputCount > 0);
                    if (!ok) Console.WriteLine("This value is not allowed.");
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Hidden layers neurons count, coma sepparated: [20, 20] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    ok = true;

                    if (str.Length > 0)
                    {
                        String[] tab = str.Split(',');

                        for (int i = 0; i < tab.Length; i++)
                        {
                            int val = 0;
                            ok = int.TryParse(tab[i], out val);

                            if (ok) ok = (val > 0);
                            if (!ok) break;

                            hiddenLayersNeuronsCount.Add(val);
                        }
                    }
                    else
                    {
                        hiddenLayersNeuronsCount = defaultHiddenLayersNeuronsCount;
                    }

                    if (!ok) Console.WriteLine("This value is not allowed.");
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Output neurons count: ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : outputCount.ToString();
                    ok = int.TryParse(str, out outputCount);

                    if (ok) ok = (outputCount > 0);
                    if (!ok)
                    {
                        Console.WriteLine("This value is not allowed.");
                    }
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Activation function of neurons Sigmoid/Tanh: [S/t] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    str = str.ToLower();

                    if (str.Length == 0)
                    {
                        str = "s";
                    }

                    ok = (str == "s" || str == "t");

                    if (ok)
                    {
                        activationFunction = (str == "s") ? NeuralNetwork.ActivationFunction.SIGMOID : NeuralNetwork.ActivationFunction.TANH;
                    }
                    else
                    {
                        Console.WriteLine("This value is not allowed.");
                    }
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Using bias? [n/Y] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    str = str.ToLower();

                    if (str.Length == 0)
                    {
                        str = "y";
                    }

                    ok = (str == "n" || str == "y");

                    if (ok)
                    {
                        networkUseBias = (str == "y");
                    }
                    else
                    {
                        Console.WriteLine("This value is not allowed.");
                    }
                }

                Console.WriteLine("What should stops learning?");
                Console.WriteLine("0 - minimum percentage error or maximum number of epochs");
                Console.WriteLine("1 - minimum percentage error");
                Console.WriteLine("2 - maximum number of epochs");
                Console.WriteLine("3 - only F2 key");

                ok = false;
                while (!ok)
                {
                    int choice = 0;

                    Console.Write("Your choice? [3] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    if (str.Length == 0)
                    {
                        choice = 3;
                        ok = true;
                    }
                    else
                    {
                        ok = int.TryParse(str, out choice);
                    }

                    if (ok)
                    {
                        switch (choice)
                        {
                            case 0:

                                ok = false;
                                while (!ok)
                                {
                                    Console.Write("Maximum number of epochs: [" + DEFAULT_MAX_EPOCH_NO + "] ");
                                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                                    if (str.Length > 0)
                                    {
                                        ok = long.TryParse(str, out maxEpochNo);
                                        if (ok) ok = (maxEpochNo > 0);
                                    }
                                    else
                                    {
                                        maxEpochNo = DEFAULT_MAX_EPOCH_NO;
                                        ok = true;
                                    }

                                    if (!ok)
                                    {
                                        Console.WriteLine("This value is not allowed.");
                                    }
                                }

                                ok = false;
                                while (!ok)
                                {
                                    Console.Write("Minimum percentage error: [" + DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP + "] ");
                                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                                    if (str.Length > 0)
                                    {
                                        ok = double.TryParse(str, out minErrorPercentageToStop);
                                        if (ok) ok = (minErrorPercentageToStop > 0);
                                    }
                                    else
                                    {
                                        minErrorPercentageToStop = DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP;
                                        ok = true;
                                    }

                                    if (!ok)
                                    {
                                        Console.WriteLine("This value is not allowed.");
                                    }
                                }

                                break;

                            case 1:

                                ok = false;
                                while (!ok)
                                {
                                    Console.Write("Minimum percentage error: [" + DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP + "] ");
                                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                                    if (str.Length > 0)
                                    {
                                        ok = double.TryParse(str, out minErrorPercentageToStop);
                                        if (ok) ok = (minErrorPercentageToStop > 0);
                                    }
                                    else
                                    {
                                        minErrorPercentageToStop = DEFAULT_MIN_ERR_PERCENTAGE_TO_STOP;
                                        ok = true;
                                    }

                                    if (!ok)
                                    {
                                        Console.WriteLine("This value is not allowed.");
                                    }
                                }

                                maxEpochNo = 0;
                                break;

                            case 2:

                                ok = false;
                                while (!ok)
                                {
                                    Console.Write("Maximum number of epochs: [" + DEFAULT_MAX_EPOCH_NO + "] ");
                                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                                    if (str.Length > 0)
                                    {
                                        ok = long.TryParse(str, out maxEpochNo);
                                        if (ok) ok = (maxEpochNo > 0);
                                    }
                                    else
                                    {
                                        maxEpochNo = DEFAULT_MAX_EPOCH_NO;
                                        ok = true;
                                    }

                                    if (!ok)
                                    {
                                        Console.WriteLine("This value is not allowed.");
                                    }
                                }

                                minErrorPercentageToStop = 0;
                                break;

                            case 3:
                                minErrorPercentageToStop = 0;
                                maxEpochNo = 0;

                                break;

                            default:

                                ok = false;
                                break;
                        }
                    }

                    if (!ok) Console.WriteLine("This value is not allowed.");
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Learning ratio: [" + learningRatio + "] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    str = str.Replace('.', ',');

                    double newLearningRatio = learningRatio;

                    if (str.Length > 0)
                    {
                        ok = double.TryParse(str, out newLearningRatio);
                        if (ok) ok = (newLearningRatio > 0);
                    }
                    else
                    {
                        ok = true;
                    }

                    if (ok)
                    {
                        learningRatio = newLearningRatio;
                    }
                    else
                    {
                        Console.WriteLine("This value is not allowed.");
                    }
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Momentum: [" + momentum + "] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    str = str.Replace('.', ',');

                    double newMomentum = momentum;

                    if (str.Length > 0)
                    {
                        ok = double.TryParse(str, out newMomentum);
                        if (ok) ok = (newMomentum > 0);
                    }
                    else
                    {
                        ok = true;
                    }

                    if (ok)
                    {
                        momentum = newMomentum;
                    }
                    else
                    {
                        Console.WriteLine("This value is not allowed.");
                    }
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("Should the order of the learning data be random? [n/Y] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    str = str.ToLower();

                    if (str.Length == 0)
                    {
                        str = "y";
                    }

                    ok = (str == "n" || str == "y");

                    if (ok)
                    {
                        randomOrderOfLearningData = (str == "y");
                    }
                    else
                    {
                        Console.WriteLine("This value is not allowed.");
                    }
                }

                ok = false;
                while (!ok)
                {
                    Console.Write("File with learning data: [" + filename + "] ");
                    str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                    if (str.Length == 0)
                    {
                        str = filename;
                    }

                    FileInfo fi = new FileInfo(str);
                    ok = fi.Exists;
                    if (!ok)
                    {
                        Console.WriteLine("File not exists.");
                    }
                    else
                    {
                        filename = str;

                        Console.WriteLine("Loading teaching elements from file...");

                        ok = LoadTeachingElements(inputCount, outputCount, out learningData, filename);

                        if (ok)
                        {
                            Console.WriteLine("Teaching elements loaded.");
                            dataLoopRunning = false;
                        }
                        else
                        {
                            Console.Write("Do you want to provide new data [d] or try another file [F]? ");
                            str = TAKE_PARAMETERS_FROM_USER ? Console.ReadLine() : "";

                            str = str.ToLower();

                            if (str.Length == 0)
                            {
                                str = "f";
                            }

                            ok = (str == "d" || str == "f");

                            if (ok)
                            {
                                if (str == "f")
                                {
                                    ok = false;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("This value is not allowed.");
                            }
                        }
                    }
                }
            }

            #endregion

            #region Layers creation
            int layerNo = 0;
            LayerCreationInfo inputLci = new LayerCreationInfo();
            inputLci.HowManyNeuronsPerLayer = inputCount + (networkUseBias ? 1 : 0);
            inputLci.LayerActivationFunction = activationFunction;
            inputLci.LayerNo = layerNo++;
            inputLci.PreviousLayerNeuronsCount = 0;
            layers.Add(new Layer(inputLci, networkUseBias, Layer.LayerType.INPUT, -0.5, +0.5));


            foreach (int hiddenLayerNeurons in hiddenLayersNeuronsCount)
            {
                LayerCreationInfo hiddenLci = new LayerCreationInfo();
                hiddenLci.HowManyNeuronsPerLayer = hiddenLayerNeurons + (networkUseBias ? 1 : 0);
                hiddenLci.LayerActivationFunction = activationFunction;
                hiddenLci.PreviousLayerNeuronsCount = layers.ElementAt(layerNo - 1).Neurons.Count;
                hiddenLci.LayerNo = layerNo++;
                layers.Add(new Layer(hiddenLci, networkUseBias, Layer.LayerType.HIDDEN, -0.5, +0.5));
            }

            LayerCreationInfo outputLci = new LayerCreationInfo();
            outputLci.HowManyNeuronsPerLayer = outputCount;
            outputLci.LayerActivationFunction = activationFunction;
            outputLci.PreviousLayerNeuronsCount = layers.ElementAt(layerNo - 1).Neurons.Count;
            outputLci.LayerNo = layerNo++;
            layers.Add(new Layer(outputLci, networkUseBias, Layer.LayerType.OUTPUT, -0.5, +0.5));

            #endregion

            NeuralNetwork neuralNetwork = new NeuralNetwork(
                new Topology()
                {
                    Layers = layers,
                    IsNetworkUsingBiases = networkUseBias,
                    OutputCount = outputCount
                },
                -0.5,
                +0.5,
                NeuralNetwork.LearningMethod.NOT_LINEAR,
                "NN", 
                collectSparseHistoryEvery
            );

            LearnNetwork(neuralNetwork, networkUseBias, learningData, learningRatio, momentum,
                minErrorPercentageToStop, maxEpochNo, randomOrderOfLearningData, writeOnConsoleEveryEpoch, true);

            String prefix = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            String saveNetworkFilename = prefix + "_Network.nnc";
            String saveErrorsFilename = prefix + "_Errors.csv";
            neuralNetwork.SaveNetworkToFile(saveNetworkFilename);
            // neuralNetwork.SaveErrorsToFile(saveErrorsFilename);

            Console.WriteLine();
            Console.Write("Press any key to go to main menu... ");
            Console.ReadKey();
        }

        private static bool LearnNetwork(NeuralNetwork neuralNetwork, bool networkUseBias, List<LearnSample> learningData, double learningRatio, double momentum,
            double minErrorPercentageToStop, long maxEpochNo, bool randomOrderOfLearningData, long writeOnConsoleEveryEpoch, bool keyEscapeInterrupt)
        {
            List<LearnSample> learningDataToUse = learningData;

            Console.WriteLine();

            if (randomOrderOfLearningData)
            {
                Console.WriteLine("Randomize order of learning data...");
                learningDataToUse = ShuffleList(learningData);
            }

            Console.WriteLine("Starting to learn network (press F2 to stop)...");
            bool doLearningProcess = true;

            Console.WriteLine();
            Console.WriteLine("   Epoch no.     Network error   Network error change");

            try
            {
                List<double> errorList = new List<double>();
                double lastNetworkError = 1;
                long epochNo = 0;
                String stopComment = null;
                bool stopedByKey = false;

                while (doLearningProcess)
                {
                    for (int i = 0; i < learningData.Count; i++)
                    {
                        LearnSample learnSample = learningDataToUse.ElementAt(i);
                        //neuralNetwork.Learn()
                        String outStringErrorMessage = null;
                        neuralNetwork.Learn(learnSample, learningRatio, momentum, out outStringErrorMessage, epochNo, networkUseBias);

                        if (outStringErrorMessage != null)
                        {
                            throw new Exception(outStringErrorMessage);
                        }

                        epochNo++;

                        // TODO: maybe using additional bool variable "isMaxEpochNoSet" will increase performance by comparing bool not doubles?
                        if (maxEpochNo > 0)
                        {
                            if (epochNo >= maxEpochNo)
                            {
                                stopComment = String.Format(
                                    "Learning stopped because of epoch number reached (epochno = {0}).",
                                    epochNo
                                );
                                doLearningProcess = false;
                            }
                        }

                        // TODO: maybe using additional bool variable "isMinErrorSet" will increase performance by comparing bool not doubles?
                        if (minErrorPercentageToStop > 0)
                        {
                            if (neuralNetwork.NetworkError < minErrorPercentageToStop / 100)
                            {
                                stopComment = String.Format(
                                    "Learning stopped because of minimum percentage of network error reached (network error = {0, 4:0.000}%).",
                                    neuralNetwork.NetworkError * 100
                                );
                                doLearningProcess = false;
                            }
                        }

                        if (keyEscapeInterrupt)
                        {
                            if (Console.KeyAvailable)
                            {
                                ConsoleKeyInfo cki = Console.ReadKey();
                                if (cki.Key == ConsoleKey.F2)
                                {
                                    doLearningProcess = false;
                                    stopComment = "Learning stopped by pressing F2 key.";
                                    stopedByKey = true;
                                }
                            }
                        }

                        if (epochNo % writeOnConsoleEveryEpoch == 0 || !doLearningProcess)
                        {

                            Console.WriteLine(
                                String.Format(
                                    (stopedByKey ? " {0, 10}" : " {0,11}") + " {1,16:0.000}% {2,21:0.000} per mille ",
                                    epochNo,
                                    neuralNetwork.NetworkError * 100,
                                    (neuralNetwork.NetworkError - lastNetworkError) * 1000));

                            errorList.Add(neuralNetwork.NetworkError);
                            lastNetworkError = neuralNetwork.NetworkError;

                            if (!doLearningProcess)
                            {
                                if (stopComment != null)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(stopComment);

                                }

                                break;
                            }
                        }
                    }
                }
            }
            catch (NotImplementedException/*FormatException*/ e)
            {
                Console.WriteLine("Error during learning: " + e.Message + ". Learning stopped.");

                return false;
            }

            return true;
        }


        private static bool LoadTeachingElements(int inputCount, int outputCount, out List<LearnSample> LearningData,
            String filename)
        {
            LearningData = new List<LearnSample>();
            bool ret = true;
            try
            {
                StreamReader sr = new StreamReader(filename);

                String line = sr.ReadLine();
                int lineNo = 1;
                while (line != null)
                {
                    if (line.Length > 0)
                    {
                        line = line.Replace('.', ',');

                        String[] tabString = line.Split(';'); // yes, I force delimiter as ';'

                        if (tabString.Length != inputCount + outputCount)
                        {
                            throw new Exception("Difference between input/output count and data length in line " + lineNo +
                                ". Elements in line: " + tabString.Length + ", inputs + outputs: " + (inputCount + outputCount) + ".");
                        }

                        double[] tabDouble = new double[tabString.Length];

                        try
                        {
                            for (int i = 0; i < tabDouble.Length; i++)
                            {
                                tabDouble[i] = double.Parse(tabString[i]);
                            }
                        }
                        catch (Exception)
                        {
                            throw new Exception("Error during parse value to double in line " + lineNo);
                        }

                        double[] inputs = SubArray(tabDouble, 0, inputCount);
                        double[] outputs = SubArray(tabDouble, inputCount, tabDouble.Length - inputCount);

                        // TODO: refactory needed - I should be able to send inputs and outputs in constructor
                        LearnSample teachingElement = new LearnSample(outputs.Length);
                        teachingElement.InputData = inputs.ToList();
                        teachingElement.OutputData = outputs;

                        LearningData.Add(teachingElement);
                    }

                    line = sr.ReadLine();
                    lineNo++;
                }

                sr.Close();
                ret = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on reading file " + filename + ": " + ex.Message);
                ret = false;
            }

            return ret;
        }

        private static T[] SubArray<T>(T[] array, int offset, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }

        private static List<T> ShuffleList<T>(List<T> list)
        {
            Random rng = new Random();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}
