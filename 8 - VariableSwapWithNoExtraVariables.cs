using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            a = a - b;
            b = a + b;
            a = b - a;
            
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();
        }
    }
}
