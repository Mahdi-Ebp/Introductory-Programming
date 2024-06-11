using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem71
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, b, c = 1, d = 0, e = 1;
            Console.Write("n:");
            n = double.Parse(Console.ReadLine());
            b = n * 2 - 1;
            for (double x = 1; x <= b; x += 2) {
                c = 1 / x;
                if (e % 2 == 0)
                    c = -c;
                d += c;
                e++;
            }
            d *= 4;
            Console.Write("hasel:" + d);
            Console.ReadKey();
        }
    }
}
