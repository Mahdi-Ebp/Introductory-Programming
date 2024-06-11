using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem56
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 0;
            Console.Write("adad:");
            n = int.Parse(Console.ReadLine());
            if (n < 10)
                for (int y = 1; y <= n; y++)
                    Console.Write("*");
            else
            {
                for (int x = n; x > 0; x /= 10)
                {
                    a = x % 10;
                    b += a;
                    if(x>10)
                    b *= 10;
                }
                for (int y = 1; y <= b; y++)
                    Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
