using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i >= 0; i--)
            {
                if ((i % 3 == 0) & (i % 2 != 0))
                {
                    Console.WriteLine("Liczby podzielne przez 3 a niepodzielne przez 2 to {0}", i);
                }
            }
            Console.WriteLine
                ();

            int j = 100;
            while(j >= 0)
            {
                j--;
                if ((j % 3 == 0) & (j % 2 != 0))
                {
                    Console.WriteLine("Liczby podzielne przez 3 a niepodzielne przez 2 to {0}", j);
                }
            }

            Console.WriteLine();

            int k = 100;
            do
            {
                k--;
                if ((k % 3 == 0) & (k % 2 != 0))
                {
                    Console.WriteLine("Liczby podzielne przez 3 a niepodzielne przez 2 to {0}", k);
                }
            }
            while (k >= 0);
            Console.ReadKey();
        }
    }
}
