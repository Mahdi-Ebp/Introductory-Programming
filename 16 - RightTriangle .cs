using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,m ;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            c = int.Parse(Console.ReadLine());
            m = a;
            if (b > m)
                m = b;
            if (c > m)
                m = c;
            if (m == a && m * m == b * b + c * c)
                Console.Write("yes");
            if (m == b && m * m == a * a + c * c)
                Console.Write("yes");
            if (m == c && m * m == a * a + b * b)
                Console.Write("yes");
            else
                Console.Write("no");
            Console.ReadKey();
        }
    }
}
