using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem34
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c;
            Console.WriteLine("n:");
            n = int.Parse(Console.ReadLine());
            c = 0;
            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    Console.WriteLine("tedad");
                    c++;
            }
            Console.Write(c);


            Console.ReadKey();
        }
    }
}
