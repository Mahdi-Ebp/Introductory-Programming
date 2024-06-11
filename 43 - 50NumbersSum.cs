using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem43
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,b;
            x = 0;
            for (int y = 1; y <= 50; y++)
            {
                Console.Write("adad ra vared konid:");
                b = int.Parse(Console.ReadLine());
                x += b;
            }
            Console.Write(x);
            Console.ReadKey();
        }
    }
}
