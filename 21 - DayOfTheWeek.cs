using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x ;
            Console.Write("rooz:");
            x = int.Parse(Console.ReadLine());
            if (0 < x && x < 8)
                if (x == 1)
                    Console.Write("shanbe");
                else
                        if (x == 2)
                    Console.Write("yekshanbe");
                else
                        if (x == 3)
                    Console.Write("doshanbe");
                else
                        if (x == 4)
                    Console.Write("seshanbe");
                else
                        if (x == 5)
                    Console.Write("chaharshanbe");
                else
                        if (x == 6)
                    Console.Write("panjshanbe");
                else
                        if (x == 7)
                    Console.Write("jome");

                else
                    ;
            else
            Console.Write("lotfan adadi az 1 ta 7 ra entekhab va mojadadan talash konid");
            Console.ReadKey();
        }
    }
}
