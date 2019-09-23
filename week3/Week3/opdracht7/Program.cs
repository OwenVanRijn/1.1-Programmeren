using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht7
{
    class Program
    {
        static double calc_bmi(bool man, double lengte, double gewicht)
        {
            double bmi;

            bmi = gewicht / Math.Pow((lengte / 100), 2);

            return bmi;
        }

        static void Main(string[] args)
        {
            bool man;
            string temp;
            double lengte, gewicht, BMI;

            Console.Write("Geef uw sekse (M/V): ");
            temp = Console.ReadLine();

            man = true;
            if (temp == "V" || temp == "v")
                man = false;

            Console.Write("Geef uw gewicht in kg: ");
            temp = Console.ReadLine();
            gewicht = double.Parse(temp);

            Console.Write("Geef uw lengte in CM: ");
            temp = Console.ReadLine();
            lengte = double.Parse(temp);

            BMI = calc_bmi(man, lengte, gewicht);

            switch (man)
            {
                case true:
                    break;
                case false:
                    break;
            }

            Console.ReadKey();
        }
    }
}
