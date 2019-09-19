using System;

namespace janitortroubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            double[] values = new double[4];
            for (int i = 0; i < 4; i++)
            {
                values[i] = Double.Parse(input[i]);
            }
            double sp = (values[0] + values[1] + values[2] + values[3])/2d;
            double result = Math.Sqrt((sp-values[0]) * (sp-values[1]) * (sp - values[2]) * (sp-values[3]));
            Console.WriteLine(result);
        }
    }
}
