using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_zest_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definitions
            int a = 5;
            int b = ++a;
            int c = a++;
            int f = 15;
            int g = --f;
            int h = f--;

            //Printing
            Console.WriteLine("{0} {1} {2}", a, b, c);
            Console.WriteLine("{0} {1} {2}", f, g, h);

            Console.ReadKey();

        }
    }
}
