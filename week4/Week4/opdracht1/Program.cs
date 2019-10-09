using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0, aantal = 0, laatstegetal;
            double gem = 0;

            Console.Write("Geef een reeks getallen en eindig met 0\n\n");

            do
            {
                Console.Write("Geef een getal: ");
                laatstegetal = int.Parse(Console.ReadLine());

                if (laatstegetal > 0)
                {
                    aantal++;
                    som += laatstegetal;
                }
            } while (laatstegetal != 0);

            if (aantal != 0)
                gem = som / aantal;

            Console.Write("\nSom: {0}\nAantal: {1}\nGem: {2}", som, aantal, gem);
            Console.ReadKey();
        }
    }
}
