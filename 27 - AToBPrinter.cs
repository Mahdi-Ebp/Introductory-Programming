using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            b = int.Parse(Console.ReadLine());
            for (int c = a + 1; c < b; c++)
                Console.WriteLine(c);
            Console.ReadKey();
            
        }
    }
}
