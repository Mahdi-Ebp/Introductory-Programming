using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem69
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
            for (int x = a + 1; x < b; x++)
            {
                for (int y = 1; y < x; y++)
                    if (x % y == 0)
                        c += y;
                if (c == x)
                    Console.WriteLine(x);
                c = 0;
            }
            Console.ReadKey();
        }
    }
}
