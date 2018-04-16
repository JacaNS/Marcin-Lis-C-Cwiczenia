using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_12._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            int i = 0;
            while(++i < tab.Length)
            {
                tab[i] = i;
                Console.WriteLine("Tablica [{0}] = {1}", i, tab[i]);
            }
            Console.ReadKey();
        }
    }
}
