using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2, getal3;
            double gemiddelde, som, product, grootste = 0, kleinste = 0;
            string temp;

            Console.Write("Geef getal 1: ");
            temp = Console.ReadLine();
            getal1 = double.Parse(temp);

            Console.Write("\nGeef getal 2: ");
            temp = Console.ReadLine();
            getal2 = double.Parse(temp);

            Console.Write("\nGeef getal 3: ");
            temp = Console.ReadLine();
            getal3 = double.Parse(temp);

            if (getal1 > grootste)
                grootste = getal1;
            if (getal2 > grootste)
                grootste = getal2;
            if (getal3 > grootste)
                grootste = getal3;

            kleinste = grootste;

            if (getal1 < kleinste)
                kleinste = getal1;
            if (getal2 < kleinste)
                kleinste = getal2;
            if (getal3 < kleinste)
                kleinste = getal3;

            gemiddelde = (getal1 + getal2 + getal3) / 3;
            som = getal1 + getal2 + getal3;
            product = getal1 * getal2 * getal3;

            Console.Write("\nGemiddelde = {0}\nSom = {1}\nProduct = {2}\nGrootste = {3}\nKleinste = {4}", gemiddelde, som, product, grootste, kleinste);
            Console.ReadKey();
        }
    }
}
