using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem83
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Random r = new Random();
            for(int x=1;x<=10;x++)
            {
                a = r.Next(0, 16);
                Console.ForegroundColor = (ConsoleColor)a;
                Console.Write("*\t");
            }
            Console.ReadLine();
        }
    }
}
