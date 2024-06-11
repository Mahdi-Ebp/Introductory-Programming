using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem15
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
            if (a + b > c && a + c > b && b + c > a)
                Console.Write("yes");
            else
                Console.Write("no");
            Console.ReadLine();
        }
    }
}
