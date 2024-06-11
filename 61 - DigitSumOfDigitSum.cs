using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem61
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a, b = 0, c = 0;
            n = int.Parse(Console.ReadLine());
            for (int x = n; x > 0; x /= 10)
            {
                c = x;
                
                a = c % 10;
                b += a;
                c = b;
                if (x < 10)
                    if (c >= 10)
                    {
                        n = c;
                        x = c;
                        b = 0;
                        x *= 10;
                    }
            }
            Console.Write(c);
            Console.ReadKey();
        }

    }
}
