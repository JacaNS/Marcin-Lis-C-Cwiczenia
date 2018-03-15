using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;
            Console.WriteLine(a ^= b);
            Console.WriteLine(a ^= b);
            Console.ReadKey();
        }
    }
}
