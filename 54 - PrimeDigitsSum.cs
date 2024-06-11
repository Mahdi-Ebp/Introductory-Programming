using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem54
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c = 1;
            Console.Write("adad:");
            n = int.Parse(Console.ReadLine());
            for (int x = n; x > 0; x /= 10)
            {
                b = 0;
                a = x % 10;
                for (int y = 1; y <= a; y++)
                    if (a % y == 0)
                        b++;
                if (b == 2)
                    c *= a;

            }
            Console.Write("hasel zarb argham aval:" + c);
            Console.ReadLine();
        }
    }
}
