using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,s;
            Console.WriteLine("a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            b = int.Parse(Console.ReadLine());
            s = a;
            if (b == 0)
                Console.WriteLine("1");
            else
            {
                for (int i = 2; i <= b; i++)
                    s *= a;
                Console.Write(s);
            }
            Console.ReadKey();
            
        }
    }
}
