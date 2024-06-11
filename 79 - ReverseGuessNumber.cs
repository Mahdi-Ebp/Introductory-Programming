using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem79
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1001, c, x,d = 0;
            Random r = new Random();
            Console.WriteLine("1 baray adad bozorgtar");
            Console.WriteLine("2 baray adad koochektar");
            Console.WriteLine("3 baray hads dorost");
            for (; ; )
            {
                c = r.Next(a, b);
                Console.WriteLine(c);
                Console.WriteLine("Code mored nazar ra vared konid:");
                x = int.Parse(Console.ReadLine());
                d++;
                if (x == 1)
                    a = c;
                if (x == 2)
                    b = c;
                if (x == 3)
                    break;
            }
            Console.WriteLine("adad mored nazar dorost bood");
            Console.WriteLine("tedad hads ha:"+d);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
