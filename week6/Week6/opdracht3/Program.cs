using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3
{
    class Program
    {
        static bool isSchrikkelJaar(int jaar)
        {
            bool ret = false;

            if ((jaar % 4 == 0 || jaar % 400 == 0) && jaar % 100 != 0)
                ret = true;

            return ret;
        }
        static void Main(string[] args)
        {
            int laatstegetal;
            bool isschrik;

            do
            {
                Console.Write("Geef een getal: ");
                laatstegetal = int.Parse(Console.ReadLine());

                isschrik = isSchrikkelJaar(laatstegetal);

                if (isschrik)
                    Console.WriteLine($"Getal {laatstegetal} is een schrikkeljaar");
                else
                    Console.WriteLine($"Getal {laatstegetal} is niet een schrikkeljaar");
            } while (laatstegetal != 0); //note: 0 gives a printing output while also exiting the loop

            Console.ReadKey();
        }
    }
}
