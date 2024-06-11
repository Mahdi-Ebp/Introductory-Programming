using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                for (int c = a + 2; c < b; c = c + 2)
                    Console.Write(c+"\t");
            }
            else
                for (int c = a + 1; c < b; c = c + 2)
                    Console.Write(c + "\t");
            Console.ReadKey();
        }
    }
}
