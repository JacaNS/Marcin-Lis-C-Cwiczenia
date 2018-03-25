using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine("Podaj liczbę A");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę B");
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            a = liczba1 % liczba2 == 0 ? true : false;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
