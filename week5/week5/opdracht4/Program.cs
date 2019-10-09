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
            int[] cijfers = new int[20];
            int zoek, aantal = 0, invoer, i;

            for (i = 0; i < 20; i++)
            {
                Console.Write("Geef een getal (0=stop): ");
                invoer = int.Parse(Console.ReadLine());

                if (invoer == 0)
                    break;

                cijfers[i] = invoer;
            }

            Console.Write("\nGeef de zoekwaarde: ");
            zoek = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDe zoekwaarde is: {zoek}");
            
            for (int i2 = 0; i2 < i; i2++)
            {
                if (zoek == cijfers[i2])
                    aantal++;
            }

            Console.WriteLine($"De zoekwaarde komt {aantal} keer voor");

            Console.ReadKey();
        }
    }
}
