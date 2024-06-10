using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("adad aval ra vared konid:");
            a = int.Parse(Console.ReadLine());
            Console.Write("adad dovom ra vared konid:");
            b = int.Parse(Console.ReadLine());
            Console.Write("adad sevom ra vared konid:");
            c = int.Parse(Console.ReadLine());
            if (a == b && b == c)
                Console.Write("mosalas motesavi azla ast");
            else
                Console.Write("mosalas motesavi azla nist");
            Console.ReadKey();
        }
    }
}
