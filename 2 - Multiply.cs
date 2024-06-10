using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = a * b * c ;
            Console.Write(d);
            Console.ReadKey();
        }
    }
}
