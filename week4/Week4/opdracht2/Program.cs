using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelijk = 0, laatstegetal, richtgetal;

            Console.Write("Geef een richtgetal: ");
            richtgetal = int.Parse(Console.ReadLine());

            Console.Write("Geef een reeks getallen en eindig met 0\n\n");

            do
            {
                Console.Write("Geef een getal: ");
                laatstegetal = int.Parse(Console.ReadLine());

                if (laatstegetal == richtgetal)
                    gelijk += 1;
            } while (laatstegetal != 0);

            Console.Write("\nAantal ingevoerde getallen die gelijk zijn aan {0}: {1}", richtgetal, gelijk);
            Console.ReadKey();
        }
    }
}
