using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht7
{
    class Program
    {
        static double calc_bmi(double lengte, double gewicht)
        {
            double bmi;

            bmi = gewicht / Math.Pow((lengte / 100), 2);

            return bmi;
        }

        static void Main(string[] args)
        {
            bool man;
            string temp, output;
            double lengte, gewicht, gezond_gewicht_leftbound, gezond_gewicht_rightbound, BMI, gewichtgezond1, gewichtgezond2;

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

            BMI = calc_bmi(lengte, gewicht); 

            if (man)
            {
                gezond_gewicht_leftbound = 20;
                gezond_gewicht_rightbound = 25;
            }
            else
            {
                gezond_gewicht_leftbound = 19;
                gezond_gewicht_rightbound = 24;
            }

            gewichtgezond1 = gezond_gewicht_leftbound * Math.Pow((lengte / 100), 2);
            gewichtgezond2 = gezond_gewicht_rightbound * Math.Pow((lengte / 100), 2);

            output = String.Format("BMI: {0:00.00}\nGezonde BMI: {1} tot {2}\nGezond gewicht tussen {3} en {4} kg", BMI, gezond_gewicht_leftbound, gezond_gewicht_rightbound, gewichtgezond1, gewichtgezond2);
            Console.WriteLine("\n{0}", output);

            Console.ReadKey();
        }
    }
}
