using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] randomGetallen = new int[4];
            int result = 0, input;
            string inputstring;

            Console.WriteLine("Something went terribly wrong, can you add some numbers for me?\n\nAdd these 4 numbers together:");

            for (int i = 0; i < 4; i++)
            {
                randomGetallen[i] = rnd.Next(101, 10000);
                result += randomGetallen[i];
                Console.WriteLine(randomGetallen[i]);
            }

            Console.Write("\nPlease write your answer here: ");
            inputstring = Console.ReadLine();

            input = int.Parse(inputstring);

            if (input == result)
            {
                Console.WriteLine("\nSeems that worked, thanks for the help!");
            }
            else
            {
                Console.WriteLine("\nHmm, that seems to be wrong");
            }

            Console.WriteLine("\n\nInput: {0}\nResult: {1}", input, result);

            Console.ReadKey();

        }
    }
}
