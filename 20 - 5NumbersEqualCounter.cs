using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b=int.Parse(Console.ReadLine());
            Console.Write("c:");
            c = int.Parse(Console.ReadLine());
            Console.Write("d:");
            d = int.Parse(Console.ReadLine());
            Console.Write("e:");
            e = int.Parse(Console.ReadLine());
            if (a == b && b == c && c == d && d == e)
                Console.Write("hame mosavi");
            else
                if (a == b && b == c && c == d || a == b && b == d && d == e || a == c && c == d && d == e || c == b && b == e && e == d || a == b && b == c && c == e)
                Console.Write("4 adad mosavi");
            else
                if (a == b && b == c && d == e || a == b && c == d && d == e || a == e && b == c && c == d || a == b && b == e && c == d || a == d && d == e && b == c || a == c && b == d && d == e || a == d && b == c && c == e || a == c && c == e && b == d)
                Console.Write("3ta m0savi_2ta mosavi");
            else
                if (a == b && b == c || a == b && b == d || a == b && b == e || a == c && c == d || a == c && c == e || a == d && d == e || b == c && c == d || b == c && c == e || b == d && d == e || c == d && d == e)
                Console.Write("3ta mosavi");
            else
                if (a == b && c == d || a == b && c == e || a == b && d == e || a == c && b == d || a == c && b == e || a == c && d == e || a == d && b == c || a == d && b == e || a == d && c == e || a == e && b == c || a == e && b == d || a == e && c == d || b == c && d == e || b == d && c == e || b == e && c == d)
                Console.Write("2 be 2 mosavi");
            else
                if (a == b || a == c || a == d || a == e || b == c || b == d || b == e || c == d || c == e || d == e)
                Console.Write("2 ta mosavi");
            else
                if (!(a == b || a == c || a == d || a == e || b == c || b == d || b == e || c == d || c == e || d == e))
                Console.Write("hame na mosavi");
            Console.ReadKey();
        }
    }
}
