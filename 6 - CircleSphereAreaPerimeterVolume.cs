using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            a = double.Parse(Console.ReadLine());
            b = a * a * 3.14;
            Console.Write(b);
            Console.Write("     ");
            c = 2 * a * 3.14;
            Console.Write(c);
            Console.Write("     ");
            d = (4 * 3.14 * a * a * a) / 3;
            Console.Write(d);
            Console.Write("     ");
            e = 4 * 3.14 * a * a;
            Console.Write(e);
            Console.ReadKey();
        }
    }
}
