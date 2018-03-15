using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 3, c = 2, wynik;
            wynik = a % b % c;
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
