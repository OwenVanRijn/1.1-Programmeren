using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oprdacht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int i;
            double gem, verschil, som = 0;
            Random rnd = new Random();

            for (i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = rnd.Next(200);
                som += numbers[i];
                Console.WriteLine("Element {0} is {1}", i, numbers[i]);
            }

            gem = som / numbers.Length;

            Console.WriteLine("\nGemiddelde is {0}\n", gem);

            i = 0;

            foreach(int number in numbers)
            {
                verschil = Math.Abs(number - gem);
                Console.WriteLine("Verschil gemiddelde en element {0} is {1}", i, verschil);
                i++;
            }

            Console.ReadKey();
        }
    }
}
