using System;

namespace lab1c
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, r, v;
            double p = Math.PI;
            Console.WriteLine("Enter height: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            v = (p * h * Math.Pow(r, 2)) / 3;
            Console.WriteLine("Volume: " + v);
            Console.ReadKey();
        }
    }
}