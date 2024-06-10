using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.Write("adad aval ra vared konid:");
            a = int.Parse(Console.ReadLine());
            Console.Write("adad dovom ra vared konid:");
            b = int.Parse(Console.ReadLine());
            Console.Write("adad sevom ra vared konid:");
            c = int.Parse(Console.ReadLine());
            if (a <= b)
                d = a;
            else
                d = b;
            if (c <= d)
                e = c;
            else
                e = d;
            Console.Write("koochek tarin adad:"+e);
            Console.ReadKey();

               
        }      
    }
}
