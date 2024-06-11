using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem49
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b=0,c=0;
            Console.Write("tedad adad:");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                Console.Write("adad:");
                a = int.Parse(Console.ReadLine());
                for (int y = 1; y < a; y++)
                    if (a % y == 0)
                        b += y;
                if (a == b)
                    c++;
                b = 0;
            }
            Console.Write("tedad adad tam:" + c);
            Console.ReadKey();
        }
    }
}
