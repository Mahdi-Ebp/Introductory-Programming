using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem80
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Note from 2024:
             this is one of the shittiest, most fucked up fucking
             implementations of fibonacci series. im gonna keep
             this just to show people how shit i was at doing this shit
             */

            int n, a=1, b=1;
            Console.Write("tedad jomalat:");
            n = int.Parse(Console.ReadLine());
            for (int x = 3; x <= n; x++)
            {
                if (x == 3)
                    Console.Write(a + "\t" + b + "\t");
                a += b;
                Console.Write(a + "\t");
                x++;
                if (x <= n)
                {
                    b += a;
                    Console.Write(b + "\t");
                }
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}
