using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max;
            Console.WriteLine("Input n:");
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Input num:");
                int.TryParse(Console.ReadLine(), out a[i]);
                Console.Write("\n");
            }

            for (i = 0; i < n; i++)
            {
                Console.Write("{0}\t", a[i]);
                Console.WriteLine();
            }

            max = a[0];
            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            for (i = 0; i < n; i++)
            {
                if (a[i] > 0)
                    a[i] = max;
            }

            for (i = 0; i < n; i++)
            {
                Console.Write("{0}\t", a[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
