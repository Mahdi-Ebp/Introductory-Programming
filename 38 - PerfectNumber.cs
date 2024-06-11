using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem38
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,z;
            Console.Write("x:");
            x = int.Parse(Console.ReadLine());
            z = 0;
            for (int y = 1; y < x; y++)
                if (x % y == 0)
                    z += y;
            if (z == x)
                Console.Write("yes");
            else
                Console.Write("no");
            Console.ReadKey();
        }
    }
}
