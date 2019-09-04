using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            string leeftijdinvoer, leeftijduitvoer;
            int leeftijd;

            Console.Write("Hello World!\n\nVoer je leeftijd in: ");
            leeftijdinvoer = Console.ReadLine();

            leeftijd = int.Parse(leeftijdinvoer);

            leeftijduitvoer = leeftijd.ToString();

            leeftijd++;

            Console.Write("\nOrginele waarde: {0}\nGemodificeerde waarde: {1}", leeftijduitvoer, leeftijd);
            Console.ReadKey();

        }
    }
}
