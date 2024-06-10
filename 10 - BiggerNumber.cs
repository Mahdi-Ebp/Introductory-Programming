using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("adad aval:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("adad dovom:");
            b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("adad bozorg tar:" + a);
            else
                Console.Write("adad bozorg tar:" + b);
            Console.ReadKey();


        }
    }
}
