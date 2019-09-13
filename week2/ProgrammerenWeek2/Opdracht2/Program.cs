using System;

namespace Opdracht_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] getallen = new double[3];
            double result;
            string input;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Geef getal {0}: ", i + 1);
                input = Console.ReadLine();
                getallen[i] = int.Parse(input);
            }

            result = (getallen[0] + getallen[1] + getallen[2]) / 3;
            Console.Write("\nGemiddelde: {0}\n", result);
            Console.ReadKey();
        }
    }
}
