using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    class Program
    {
        static bool isPriem(int getal)
        {
            bool priem = true;

            for (int i = 2; i < getal && priem; i++)
                if ((getal % i) == 0)
                    priem = false;

            return priem;
        }
        static void Main(string[] args)
        {
            int laatstegetal = -1;
            bool priem;

            while(laatstegetal != 0)
            {
                Console.Write("Geef een getal: ");
                laatstegetal = int.Parse(Console.ReadLine());

                if (laatstegetal <= 0)
                    continue;

                priem = isPriem(laatstegetal);

                if (priem)
                    Console.Write($"Getal {laatstegetal} is een priemgetal\n");
                else
                    Console.Write($"Getal {laatstegetal} is niet een priemgetal\n");
            }

            Console.ReadKey();
        }
    }
}
