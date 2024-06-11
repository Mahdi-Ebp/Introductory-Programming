using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem58
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            for (int x = 100; x <= 999; x++)
                for (int y = x; y > 0; y /= 10)
                {
                    a = 0;
                    b = 0;
                    c = 0;
                    
                    a = y % 10;
                    y /= 10;
                    
                    b = y % 10;
                    y /= 10;
                    c = y % 10;
                    if (c == a)
                        Console.WriteLine(x);
                    
                }
            Console.ReadKey();
        }
    }
}
