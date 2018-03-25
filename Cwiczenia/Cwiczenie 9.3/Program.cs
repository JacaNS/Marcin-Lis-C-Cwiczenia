using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());

            liczba = liczba >= 0 ? liczba : -liczba;

            Console.WriteLine(liczba);
            Console.ReadKey();
        }
    }
}
