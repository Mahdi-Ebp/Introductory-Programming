using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g,h,i;
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());

            d = 1;
            for (int x = 1; x <= a; x++)
                d *= x;
            e = 1;
            for (int y = 1; y <= d; y++)
                d *= y;

            f = 1;
            for (int z = 1; z <= b; z++)
                f *= z;

            g = 1;
            for (int o = 1; o <= c; o++)
                g *= o;

            if (g == 0)
                h = 1;
            else
            {
                h = 1;
                for (int n = 1; n < g; n++)
                    h *= f;
            }
            i = e + h;
            Console.Write("hasel:" + i);
            Console.ReadKey();




        }
    }
}
