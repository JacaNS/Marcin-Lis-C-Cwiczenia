using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_10._4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest liczbą parzystą", i);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest liczbą nieparzystą", i);
                }
            }

            Console.WriteLine();

            int j = 1;

            while(j++ <= 20)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest liczbą parzystą", j);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest liczbą nieparzystą", j);
                }
            }

            Console.WriteLine();

            int k = 1;
            do
            {
                k++;
                if (k % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest liczbą parzystą", k);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest liczbą nieparzystą", k);
                }
            }
            while (k <= 20) ;
            Console.ReadKey();
        }
    }
}
