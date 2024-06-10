using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = (a + b) * 2;
            Console.Write("perimeter=");
            Console.Write(c);
            d = a * b;
            Console.Write(" area=");
            Console.Write(d);
            Console.ReadKey();
        }
    }
}
