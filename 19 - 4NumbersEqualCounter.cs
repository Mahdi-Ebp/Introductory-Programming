using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem19
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
            Console.Write("c:");
            c = int.Parse(Console.ReadLine());
            Console.Write("d:");
            d = int.Parse(Console.ReadLine());
            if (a == b && b == c && c == d)
                Console.Write("hame barabar");
            else
                if (a == b && b == c || a == c && a == d || b == c && b == d || a == b && b == d)
                Console.Write("se adad barabar");
            else
                if (a == b && c == d || a == c && b == d || a == d && b == c)
                Console.Write("2 be 2 mosavi");
            else
                if (a == b || a == c || a == d || b == c || b == d || c == d)
                Console.Write("2 adad mosavi");
            else
                Console.Write("hame na mosavi");
            Console.ReadKey();
        }
    }
}
