using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Liczba A ma wartość: 1");
                    break;
                case 4:
                    Console.WriteLine("Liczba A ma wartość: 4");
                    break;
                case 8:
                    Console.WriteLine("Liczba A ma wartość: 8");
                    break;
                case 2:
                    Console.WriteLine("Liczba A ma wartość: 2");
                    break;
                case 3:
                    Console.WriteLine("Liczba A ma wartość: 3");
                    break;
                case 7:
                    Console.WriteLine("Liczba A ma wartość: 7");
                    break;
                default:
                    Console.WriteLine("Zadna z wymienionych");
                    break;
            }
            Console.ReadKey();
        }
    }
}
