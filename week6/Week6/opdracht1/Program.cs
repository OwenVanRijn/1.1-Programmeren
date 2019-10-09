using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class Program
    {
        static double BerekenBtw(double prijs)
        {
            double btw;
            btw = prijs * 0.21;
            return btw;
        }
        static void Main(string[] args)
        {
            double prijs, btw;

            Console.Write("Geef een prijs: ");
            prijs = double.Parse(Console.ReadLine());

            btw = BerekenBtw(prijs);

            Console.WriteLine($"\nPrijs: {prijs:0.00}\nBtw: {btw:0.00}\nTotaal: {(prijs + btw):0.00}");
            Console.ReadKey();
        }
    }
}
