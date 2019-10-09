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
            string vak;
            int aantal, i;
            double gem, som = 0, hoogst = -1;

            Console.Write("Geef het vak: ");
            vak = Console.ReadLine();
            Console.Write($"Geef het aantal studenten voor {vak}: ");
            aantal = int.Parse(Console.ReadLine());

            string[] namen = new string[aantal];
            double[] cijfers = new double[aantal];

            Console.Write("\n");

            for (i = 0; i < aantal; i++)
            {
                Console.Write($"Geef de naam van de {i + 1}e student: ");
                namen[i] = Console.ReadLine();
            }

            Console.Write("\n");

            for (i = 0; i < aantal; i++)
            {
                Console.Write($"Geef het cijfer van {namen[i]}: ");
                cijfers[i] = double.Parse(Console.ReadLine());
                som += cijfers[i];
                if (hoogst < cijfers[i])
                    hoogst = cijfers[i];
            }

            gem = som / aantal;

            Console.Write($"\nGemiddelde cijfer: {gem}\nHoogste cijfer: {hoogst}\n\n");

            for (i = 0; i < aantal; i++)
                Console.WriteLine($"Student {namen[i]} heeft voor {vak} het cijfer {cijfers[i]}");

            Console.ReadKey();
        }
    }
}
