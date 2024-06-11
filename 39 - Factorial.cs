using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem39
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            Console.Write("x:");
            x = int.Parse(Console.ReadLine());
            z = 1;
            if (x == 0)
                Console.Write("1");
            else
            {
                for (int y = 1; y <= x; y++)
                    z *= y;
                Console.Write(z);
            }
            Console.ReadKey();

        }
    }
}
