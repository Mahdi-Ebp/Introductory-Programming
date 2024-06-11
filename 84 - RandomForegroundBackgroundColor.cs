using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem84
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Random r = new Random();
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {

                    a = r.Next(0, 16);
                    b = r.Next(0, 16);
                    Console.ForegroundColor = (ConsoleColor)a;
                    Console.BackgroundColor = (ConsoleColor)b;
                    Console.Write(x * y + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
