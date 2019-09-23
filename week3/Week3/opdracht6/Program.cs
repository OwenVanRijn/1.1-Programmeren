using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cijfer_string, letter, gehaald;
            int cijfer;

            Console.Write("Geef het cijfer in punten van 1-100: ");
            cijfer_string = Console.ReadLine();
            cijfer = int.Parse(cijfer_string);

            if (cijfer >= 90)
                letter = "A";
            else if (cijfer >= 80)
                letter = "B";
            else if (cijfer >= 70)
                letter = "C";
            else if (cijfer >= 60)
                letter = "D";
            else
                letter = "E";

            gehaald = "niet gehaald";
            if (cijfer >= 70)
                gehaald = "gehaald";

            Console.Write("\nJe hebt het cijfer {0}, dus je hebt het vak {1}.", letter, gehaald);
            Console.ReadKey();
        }
    }
}
