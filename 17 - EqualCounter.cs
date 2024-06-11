using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            c = int.Parse(Console.ReadLine());
            if (a == b && b == c)
            Console.WriteLine("har 3 adad ba ham barabar hastand");
            if (a == b&&a!=c || b == c&&b!=a || a == c&&a!=b) 
            Console.WriteLine("2 adad ba ham barabar hastand");
            if (!(a == b || b == c || a==c))
                Console.WriteLine("adad ha ba ham barabar nistand");
            Console.ReadKey();
        }
    }
}
