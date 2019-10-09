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
            int[] numbers = new int[20];
            int aantal = 0, kleinste = 151;
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(150);
                Console.WriteLine("Element {0} is {1}", i, numbers[i]);
            }

            foreach (int number in numbers)
            {
                if (kleinste > number)
                {
                    kleinste = number;
                    aantal = 1;
                }
                else if (kleinste == number)
                    aantal++;
            }

            Console.WriteLine("\nKleinste getal is {0}, dit is {1} keer voorgekomen", kleinste, aantal);
            Console.ReadKey();
        }
    }
}
