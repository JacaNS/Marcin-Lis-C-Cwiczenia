using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Podaj liczbę a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c");
            c = Convert.ToInt32(Console.ReadLine());

            double delta = (b ^ 2 - 4 * a * c);

            double x0 = -b / (2 * a);
            double x1 = -b - Math.Sqrt(delta) / (2 * a);
            double x2 = -b + Math.Sqrt(delta) / (2 * a);


            Console.WriteLine(delta);

            if (delta == 0)
            {
                Console.WriteLine("Równanie ma jedno rowiązanie");
                Console.WriteLine(x1);
            }

            else if(delta < 0)
            {
                Console.WriteLine("Równanie nie ma rozwiązań w zbiorze liczb brzeczywistych");
            }

            else if (delta > 0)
            {
                Console.WriteLine("Równanie ma dwa rozwiązania");
                Console.WriteLine("Pierwsze rozwiązanie " + x1 + " Drugie rozwiązanie " + x2);
            }

            Console.ReadKey();
        }
    }
}
