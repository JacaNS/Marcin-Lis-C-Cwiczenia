using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] tablica = new bool[20];
            for(int i = 0; i < tablica.Length; i++)
            {
                if (i % 2 == 0)
                    tablica[i] = true;
                if (i % 2 != 0)
                    tablica[i] = false;
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();
        }
    }
}
