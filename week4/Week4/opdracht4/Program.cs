using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, temp;
            string sequence = "1, 1";

            for(int i = 0; i < 18; i++)
            {
                temp = b;
                b += a;
                a = temp;
                sequence += string.Format(", {0}", b);
            }

            Console.Write("Sequence: {0}", sequence);
            Console.ReadKey();
        }
    }
}
