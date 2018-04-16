using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tablica = new char[26];
            char k = 'a';
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = k++;
                Console.WriteLine("Tablica[" + i + "] = " + tablica[i]);
            }
            Console.ReadKey();
        }
    }
}
