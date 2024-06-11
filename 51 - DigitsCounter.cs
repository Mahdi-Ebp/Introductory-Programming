using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem51
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 10, b = 1;
            Console.Write("adad:");
            n = int.Parse(Console.ReadLine());
            if (a > n)
                Console.Write("tedad argham:1");
            else
            {
                for (int x = 1; x <= 9; x++)
                {
                    b = x;
                    if (a > n)
                        break;
                    else
                        a *= 10;
                }
                Console.Write("tedad argham:" + b);
            }
            Console.ReadKey();
        }
    }
}
