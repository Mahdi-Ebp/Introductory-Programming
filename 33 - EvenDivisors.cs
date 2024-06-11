using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n:");
            n = int.Parse(Console.ReadLine());
            for (int z = 1; z <= n; z++)
            {
                if (z % 2 != 0 && n % z == 0)
                    Console.WriteLine(z);
            }
            Console.ReadKey();
        }
    }
}