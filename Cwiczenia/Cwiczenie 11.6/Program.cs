using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_11._6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 20; i >= 1; i--)
            {
                if (i-- < 20) break;
                Console.Write(i);

            }
            Console.ReadKey();
        }
    }
}
