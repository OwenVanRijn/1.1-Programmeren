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
            int kaart;
            string temp, output;

            Console.Write("Geef een getal tussen 1 en 4: ");
            temp = Console.ReadLine();
            kaart = int.Parse(temp);
            
            switch (kaart)
            {
                case 1:
                    output = "Klaveren";
                    break;
                case 2:
                    output = "Ruiten";
                    break;
                case 3:
                    output = "Harten";
                    break;
                case 4:
                    output = "Schoppen";
                    break;
                default:
                    output = "Getal moet tussen de 1 en 4 liggen";
                    break;
            }

            Console.Write("\n{0}", output);
            Console.ReadKey();
        }
    }
}
