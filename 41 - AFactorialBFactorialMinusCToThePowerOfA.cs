using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem41
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d,e,f,g;
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());
            d = 1;
            if (a == 0)
                d = 1;
            else
            {
                for (int x = 1; x <= a; x++)
                    d *= x;
            }
            e = 1;
            if (b == 0)
                e = 1;
            else
                for (int y = 1; y <= b; y++)
                    e *= y;

            f = c;
            if (a == 0)
                f = 1;
            else
                for (int i = 2; i <= a; i++)
                    f *= c;
            g = d + e - f;
            Console.Write(g);
            Console.ReadKey();
            

        }
    }
}
