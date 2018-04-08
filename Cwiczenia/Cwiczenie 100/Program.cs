using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_100
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = 0;
            var sum = 0;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Enter valid number, please!");
                sum += number;
            }
            while (number != 0);
            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
