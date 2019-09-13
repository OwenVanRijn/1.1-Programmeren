using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstring;
            double input, result, btw;

            Console.Write("Geef een prijs: ");
            inputstring = Console.ReadLine();
            input = double.Parse(inputstring);
            btw = input * 0.21;
            result = btw + input;
            Console.WriteLine("\nInput = {0}\nBtw = {1}\nResult = {2}", input.ToString(), btw.ToString(), result.ToString());
            Console.ReadKey();
        }
    }
}
