using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_12._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[100];
            for(int i = 0; i < tab.Length; i++)
            {
                if (i % 10 == 0)
                    tab[i] = 1;
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();
        }
    }
}
