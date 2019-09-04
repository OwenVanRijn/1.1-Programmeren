using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 200, level = 3, aantalItems = 4, score_nieuw, level_nieuw;

            // het verschil tussen ++var en var++ is dat var++ na de lezing van de var 1 erbij optelt en ++var ervoor
            score_nieuw = score + 1;
            level_nieuw = level + 1;

            Console.WriteLine("Score (oud): {0}, score (nieuw): {1}", score, score_nieuw);
            Console.WriteLine("level (oud): {0}, level (nieuw): {1}", level, level_nieuw);

            aantalItems *= 2;
            aantalItems -= 1;
            Console.WriteLine("aantal items: {0}", aantalItems);

            Console.ReadKey();
        }
    }
}
