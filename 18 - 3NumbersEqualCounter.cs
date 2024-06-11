using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem18
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
            if (a == b&&b==c)
                    Console.Write("har 3 adad mosavi");
            else
                    if (a == b || a == c || b == c)
                    Console.Write("2 adad mosavi");
                    else
                        if (a != b && b != c)
                    Console.Write("adad ha na mosavi");
            Console.ReadKey();

           }

        }
    }
