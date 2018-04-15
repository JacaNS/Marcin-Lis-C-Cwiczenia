using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 19)
            {
                i++;
                if(i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
