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
            int getal1, getal2;
            string temp;
            int grootste, kleinste;

            Console.Write("Geef getal 1: ");
            temp = Console.ReadLine();
            getal1 = int.Parse(temp);

            Console.Write("\nGeef getal 2: ");
            temp = Console.ReadLine();
            getal2 = int.Parse(temp);

            if (getal1 > getal2)
            {
                grootste = getal1;
                kleinste = getal2;
            }
            else
            {
                grootste = getal2;
                kleinste = getal1;
            }

            if (grootste != kleinste)
            {
                Console.WriteLine("\n\nGrootste = {0}\nKleinste = {1}", grootste, kleinste);
            }
            else
            {
                Console.WriteLine("\n\nGrootste en kleinste zijn hetzelfde, namelijk {0}", grootste);
            }

            Console.ReadKey();
        }
    }
}
