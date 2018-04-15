using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Dupa");
                if (i == 8)
                {
                    break;
                }
            }
            Console.ReadKey();
        }        
    }
}
