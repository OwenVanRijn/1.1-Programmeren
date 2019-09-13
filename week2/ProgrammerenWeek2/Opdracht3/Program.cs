using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            long hours = 0, minutes = 0, seconds = 0;

            Console.Write("Input seconds: ");
            input = Console.ReadLine();
            seconds = long.Parse(input);

            hours = seconds / 3600;
            seconds -= hours * 3600;
            minutes = seconds / 60;
            seconds -= minutes * 60;

            Console.Write("\n{0:00}:{1:00}:{2:00}\n", hours, minutes, seconds);
            Console.ReadKey();
        }
    }
}
