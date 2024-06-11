using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int c = b - 1; c > a; c--)
            
                Console.Write(c + "\t");
            
            Console.ReadKey();
        }
    }
}
