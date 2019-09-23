using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2;
            string temp, output;

            Console.Write("Geef getal base: ");
            temp = Console.ReadLine();
            getal1 = double.Parse(temp);

            Console.Write("\nGeef getal veelvoud: ");
            temp = Console.ReadLine();
            getal2 = double.Parse(temp);

            if (getal2 % getal1 == 0)
                output = string.Format("{0} is een veelvoud van {1}", getal2, getal1);
            else
                output = string.Format("{0} is niet een veelvoud van {1}", getal2, getal1);

            Console.Write("\n{0}", output);
            Console.ReadKey();
        }
    }
}
