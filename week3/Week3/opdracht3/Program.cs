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
            int getal1, getal2, getal3;
            string temp, output;

            Console.Write("Geef getal 1: ");
            temp = Console.ReadLine();
            getal1 = int.Parse(temp);

            Console.Write("\nGeef getal 2: ");
            temp = Console.ReadLine();
            getal2 = int.Parse(temp);

            Console.Write("\nGeef getal 3: ");
            temp = Console.ReadLine();
            getal3 = int.Parse(temp);

            if (getal1 > getal3 && getal2 > getal3)
                output = "Getal3 is het kleinste getal";
           
            else
                output = "Getal3 is niet het kleinste getal";

            Console.Write("\n{0}", output);
            Console.ReadKey();
        }
    }
}
