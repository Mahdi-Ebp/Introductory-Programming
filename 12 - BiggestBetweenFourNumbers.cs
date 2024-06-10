using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g;
            Console.Write("adad aval ra vared konid:");
            a = int.Parse(Console.ReadLine());
            Console.Write("adad dovom ra vared konid:");
            b = int.Parse(Console.ReadLine());
            Console.Write("adad sevom ra vared konid:");
            c = int.Parse(Console.ReadLine());
            Console.Write("adad chaharom ra vared konid:");
            d = int.Parse(Console.ReadLine());
            if (a >= b)
                e = a;
            else
                e = b;
            if (e >= c)
                f = e;
            else
                f = c;
            if (f >= d)
                g = f;
            else
                g = d;
            Console.Write("bozorg tarin adad:" + g);
            Console.ReadKey();

        }
    }
}
