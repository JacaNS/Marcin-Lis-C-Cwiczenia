using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            if(a > 0)
            {
                Console.WriteLine("Wartosc bezwzględna wynosi " + a);
            }

            else if(a < 0)
            {
                Console.WriteLine("Wartosc bezwzględna wynosi... " + -a);
            }

            Console.ReadKey();
        }
    }
}
