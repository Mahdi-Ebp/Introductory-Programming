using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem74
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            for (;;)
            {
                Console.WriteLine("press 0 to exit");
                Console.Write("enter number:");
                a = int.Parse(Console.ReadLine());

                if (a == 0)
                    break;
                if (a % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("even");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("odd");
                    Console.Beep();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("finish...");
            Console.ReadKey();
        }
    }
}
