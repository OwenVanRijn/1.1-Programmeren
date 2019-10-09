using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0, laatstegetal, aantal = 1;

            Console.Write("Geef een reeks getallen en eindig met 0\n\n");

            do
            {
                Console.Write("Geef een getal: ");
                laatstegetal = int.Parse(Console.ReadLine());

                if (aantal % 5 == 0)
                    som += laatstegetal;

                aantal++;
            } while (laatstegetal != 0);

            Console.Write("\nSom van 5e, 10e, 15e (etc) getallen is: {0}", som);
            Console.ReadKey();
        }
    }
}
