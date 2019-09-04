using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam, leeftijd;

            Console.Write("Hello World!\n\nVoer je naam in: ");
            naam = Console.ReadLine();

            Console.Write("\nVoer je leeftijd in: ");
            leeftijd = Console.ReadLine();

            Console.WriteLine("\nJe naam is " + naam + "\nJe leeftijd is " + leeftijd);
            Console.ReadKey();
        }
    }
}
