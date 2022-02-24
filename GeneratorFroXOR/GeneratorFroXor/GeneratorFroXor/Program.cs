using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeneratorFroXor
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int min = 1;
            int max = 1000;
            int tryies = 500;
            int div = 1000;

            StreamWriter sw = new StreamWriter("XOR rules 1 - 1000.csv");

            Random random = new Random();

            for (int i = 0; i < tryies; i++)
            {
                double val = random.Next(min, max) / (double)div;

                sw.WriteLine(val + ";" + val + ";1");
            }

            for (int i = 0; i < tryies; i++)
            {
                double val1 = random.Next(min, max) / (double)div;
                double val2 = random.Next(min, max) / (double)div;

                if (val1 == val2)
                {
                    sw.WriteLine(val1 + ";" + val2 + ";1");
                }
                else
                {
                    sw.WriteLine(val1 + ";" + val2 + ";-1");
                }
            }


            sw.Close();
        }
    }
}
