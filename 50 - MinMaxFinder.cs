using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem50
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, s = +2000000000, b = -2000000000;

            Console.Write("tedad adad:");
            n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                Console.Write("adad:");
                a = int.Parse(Console.ReadLine());

                if (a >= b)
                    b = a;

                if (a <= s)
                    s = a;
            }
            Console.WriteLine("bozorg tarin adad:" + b);
            Console.Write("koochek tarin adad:" + s);
            Console.ReadKey();
        }
    }
}
