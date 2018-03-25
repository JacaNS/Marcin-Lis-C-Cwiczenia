using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 10;

            switch (liczba)
            {
                case 0:
                    Console.WriteLine("Liczba ma wartość 0");
                    break;
                case 1:
                    Console.WriteLine("Liczba ma wartość 1");
                    break;
                case 2:
                    Console.WriteLine("Liczba ma wartość 2");
                    break;
                case 3:
                    Console.WriteLine("Liczba ma wartość 3");
                    break;
                case 4:
                    Console.WriteLine("Liczba ma wartość 4");
                    break;
                case 5:
                    Console.WriteLine("Liczba ma wartość 5");
                    break;
                case 6:
                    Console.WriteLine("Liczba ma wartość 6");
                    break;
                case 7:
                    Console.WriteLine("Liczba ma wartość 7");
                    break;
                case 8:
                    Console.WriteLine("Liczba ma wartość 1");
                    break;
                case 9:
                    Console.WriteLine("Liczba ma wartość 1");
                    break;
                default:
                    Console.WriteLine("Liczba ma inną wartośc");
                    break;
            }
            Console.ReadKey();
        }
    }
}
