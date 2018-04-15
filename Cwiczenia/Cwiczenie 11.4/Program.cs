using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= -100; i--)
            {
                if (i % 4 != 0) continue;
                if (i % 8 == 0) continue;
                if (i % 10 == 0) continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
