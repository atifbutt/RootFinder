using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootFinder
{
    class Program
    {
        delegate double function(double x);

        static void Main(string[] args)
        {
            var result = secant(
                (x) => Math.Cos(x) - 0.99841499,
                0, 1, 10);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static double secant(function f, double a, double b, int i)
        {
            double c = 0;
            for(int j = 0; j <= i; j++)
            {
                c = a - f(a) * (a - b) / (f(a) - f(b));

                b = a;
                a = c;
            }

            return c;
        }
        
    }
}
