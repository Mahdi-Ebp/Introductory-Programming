using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem86
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double b,a;
            Console.Write("adad ra vared konid:");
            n = int.Parse(Console.ReadLine());
            a = Math.Sqrt(n);
            b = Math.Truncate(a);
            Console.WriteLine("jazr:"+b);
            if (b==a)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadLine();
        }
    }
}
