using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3lera
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;
            Console.WriteLine("Input first num:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second num:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third num:");
            a3 = Convert.ToInt32(Console.ReadLine());

            if ((a1 == a2) || (a1 == a3) || (a2 == a3))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}