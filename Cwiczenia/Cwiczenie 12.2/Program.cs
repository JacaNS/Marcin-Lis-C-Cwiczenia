using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            for(int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = 10 + (i * 10);
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();
        }
    }
}
