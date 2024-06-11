using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem68
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            for (int x = a; x <= b; x++)
            {
                c = 0;
                for (int y = 1; y <= x; y++)
                    if (x % y == 0)
                        c++;
                if (c == 2)
                    Console.Write(x + "\t");

            }
            Console.ReadKey();
        }
    }
}
