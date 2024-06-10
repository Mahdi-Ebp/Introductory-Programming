using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            c = a;
            d = b;
            a = 0 + d;
            b = 0 + c;
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.ReadKey();
        }
    }
}
