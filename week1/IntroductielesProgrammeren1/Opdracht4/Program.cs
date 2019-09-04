using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teOud;
            int leeftijd;
            string leeftijdinput;

            /*
            antwoord = (5 != 3);
            Console.WriteLine("boolean antwoord: {0}", antwoord);
            */

            Console.Write("\n\nVoer je leeftijd in: ");
            leeftijdinput = Console.ReadLine();

            leeftijd = int.Parse(leeftijdinput);
            teOud = (leeftijd >= 65);

            Console.Write("\nBen je te oud? {0}", teOud);

            Console.ReadKey();
        }
    }
}
