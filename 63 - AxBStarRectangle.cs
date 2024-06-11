using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem63
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("sotoon:");
            a = int.Parse(Console.ReadLine());
            Console.Write("satr:");
            b = int.Parse(Console.ReadLine());
            for (int x = 1; x <= a * b; x++)
            {
                Console.Write("*"+"\t");
                if (x % b == 0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
