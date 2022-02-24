using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNet
{
    public class RandomWeight
    {
        private static Random random = null;
        public static double MinWeight, MaxWeight;

        public RandomWeight(double minWeight, double maxWeight)
        {
            if (random == null)
            {
                random = new Random();
            }

            MinWeight = minWeight;
            MaxWeight = maxWeight;
        }

        public double GenerateRandomWeight()
        {
            double randomValue = 0.0; // avoid 0.0 as weight!

            if (MinWeight == 0.0 && MaxWeight == 0.0)
            {
                throw new Exception("GenerateRandomWeight -> NeuralNetwork.MinWeight = 0.0 and NeuralNetwork.MaxWeight = 0.0!");
            }

            int iterCnt = 0;
            while (randomValue == 0.0)
            {
                int randomInteger = random.Next((int) (MinWeight * 1000), (int) (MaxWeight * 1000));
                randomValue = randomInteger / 1000.0;
                if (iterCnt++ == 100)
                {
                    throw new Exception("GenerateRandomWeight -> too many iterations (> 100)!");
                }
            }

            return randomValue;
        }
    }

    
}
 