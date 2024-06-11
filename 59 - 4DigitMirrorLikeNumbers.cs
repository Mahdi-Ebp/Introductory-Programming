using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem59
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d,s;
            for (int x = 1000; x <= 9999; x++)
            {
                s = x;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                a = s % 10;
                s /= 10;
                b = s % 10;
                s /= 10;
                c = s % 10;
                s /= 10;
                d = s % 10;
                if (a == d && b == c)
                    Console.Write(x + "\t");

            }
            Console.ReadKey();
        }
    }
}
