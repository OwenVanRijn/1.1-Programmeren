using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vervangen;
            int uren, leeftijd, storingen;
            string output;

            Console.Write("Aantal werkuren: ");
            uren = int.Parse(Console.ReadLine());

            Console.Write("\nLeeftijd: ");
            leeftijd = int.Parse(Console.ReadLine());

            Console.Write("\nAantal storingen per jaar: ");
            storingen = int.Parse(Console.ReadLine());

            vervangen = (uren >= 10000) || (leeftijd >= 7) || (storingen >= 25);

            if (vervangen)
                output = "Metaaldraaibank moet vervangen worden";
            else
                output = "Metaaldraaibank hoeft niet vervangen te worden";

            Console.WriteLine("\n{0}", output);
            Console.ReadKey();
        }
    }
}
