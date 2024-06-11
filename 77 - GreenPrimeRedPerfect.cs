using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace problem77
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 0,c=0,d=0;
            Console.Write("enter a number:");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                        a++;
                }
                if (a == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(x + "\t");
                    Console.Beep();
                    c++;
                    Thread.Sleep(500);
                }
                else
                    for (int z = 1; z < x; z++)
                    {
                        if (x % z == 0)
                            b += z;
                    }
                if (b == x)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(x + "\t");
                    d++;
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Thread.Sleep(500);
                }
                else
                   if (a != 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(x + "\t");
                    Thread.Sleep(500);
                }
                b = 0;
                a = 0;
            }
            Console.WriteLine();
            Console.WriteLine("tedad adad aval:"+c);
            Console.WriteLine("tedad adad tam:"+d);
            Console.ReadKey();
        }
    }
}
