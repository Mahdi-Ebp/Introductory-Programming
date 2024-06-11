using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace problem76
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a, b, c;
            for (;;)
            {
                a = r.Next(1, 10);
                b = r.Next(100, 1000);
                c = r.Next(10, 100);
                Thread.Sleep(1000);
                Console.WriteLine(a + "\t" + b + "\t" + c);
            }
        }
    }
}
