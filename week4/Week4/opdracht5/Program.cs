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
            int jaartal;
            string output;

            do
            {
                Console.Write("Geef een jaartal op: ");
                jaartal = int.Parse(Console.ReadLine());

                if (jaartal < 0)
                    output = "Jaartal is kleiner dan 0";
                else if ((jaartal % 400 == 0 || jaartal % 4 == 0) && jaartal % 100 != 0)
                    output = "Jaartal is een schrikkeljaar";
                else
                    output = "Jaartal is niet een schrikkeljaar";

                Console.WriteLine(output);
            } while (jaartal != 0);
        }
    }
}
