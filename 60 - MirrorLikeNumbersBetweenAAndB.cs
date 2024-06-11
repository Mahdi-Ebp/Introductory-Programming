using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem60
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, d = 0;
            Console.Write("adad 1 ra vared konid:");
            a = int.Parse(Console.ReadLine());
            Console.Write("adad 2 ra vared konid:");
            b = int.Parse(Console.ReadLine());

            for (int x = b - 1; x > 0; x--)
            {
                c = 0;
                d = 0;
                for (int y = x; y > 0; y /= 10)
                {
                    c = y % 10;
                    d += c;
                    if (y > 10)
                        d *= 10;
                }

                if (d == x && d > a)
                    Console.Write(d + "\t");
            }
            Console.ReadKey();

        }
    }
}
