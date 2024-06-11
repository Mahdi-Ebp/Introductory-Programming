using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b");
            b = int.Parse(Console.ReadLine());
            for (int c = a + 1; c < b; c++)
            {
                if (c % 3 == 0 || c % 5 == 0)
                    Console.WriteLine(c + "\t");
            }
            Console.ReadLine();

                
        }
    }
}
