using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int x = n; x <= 1; x--)
            {
                if (n % x == 0)
                    Console.Write(x + "\t");
            }
            Console.ReadKey();
        }
    }
}
