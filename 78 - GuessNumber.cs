using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace problem78
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Random r = new Random();
            a = r.Next(1, 1001);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 1; ; x++)
            {
                if (x == 1)
                    Console.Write("adad ra vared konid: ");
                c++;
                b = int.Parse(Console.ReadLine());
                if (b > a)
                    Console.Write("adadi koochektar vared konid: ");
                else
                    if (b < a)
                    Console.Write("adadi bozorgtar vared konid: ");
                else
                    if (a == b)
                    break;
            }
            for (; ; )
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("adad vared shode sahih mibashad");
                Console.WriteLine("tedad hads haye shoma:" + c);
                Console.WriteLine("wait for 4 seconds");
                Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("adad vared shode sahih mibashad");
                Console.WriteLine("tedad hads haye shoma:" + c);
                Console.WriteLine("wait for 3 seconds");
                Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("adad vared shode sahih mibashad");
                Console.WriteLine("tedad hads haye shoma:" + c);
                Console.WriteLine("wait 2 seconds");
                Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.WriteLine("adad vared shode sahih mibashad");
                Console.WriteLine("tedad hads haye shoma:" + c);
                Console.WriteLine("wait a second");
                Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("adad vared shode sahih mibashad");
                Console.WriteLine("tedad hads haye shoma:" + c);
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
                break;
            }
        }
    }
}
