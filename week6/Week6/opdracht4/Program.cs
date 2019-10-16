using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    class Program
    {
        static void OnderzoekTekst(string input, out int aantalPunten, out int aantalKommas, out int aantalPuntKommas)
        {
            aantalPunten = input.Count(x => x == '.');
            aantalKommas = input.Count(x => x == ',');
            aantalPuntKommas = input.Count(x => x == ';');
        }
        static void Main(string[] args)
        {
            int kommas, punten, puntkommas;
            string onderzoeksString;

            Console.Write("Voer een string in: ");
            onderzoeksString = Console.ReadLine();

            OnderzoekTekst(onderzoeksString, out punten, out kommas, out puntkommas);

            Console.WriteLine($"Punten: {punten}\nKommas: {kommas}\nPuntKommas: {puntkommas}");    
            Console.ReadKey();
        }
    }
}
