using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            while (i-- >= 1)
            {
                if (i % 3 != 0 & i % 4 != 0)
                    Console.WriteLine(i);
            }

            int j = 100;
            while (j-- >= 1)
            {
                if (j % 3 == 0)
                    continue;
                if (j % 4 == 0)
                    continue;
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}
