using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i++ <= 20){
                if (i % 3 == 0)
                {
                    Console.WriteLine("dla i = {0}",i);
                }
            }
            Console.ReadKey();
        }
    }
}
