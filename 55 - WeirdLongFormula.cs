using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 1, b = 0, c = 0, d = 1,f=0,g=1;
            Console.Write("adad:");
            n = int.Parse(Console.ReadLine());
            for(int x=n;x>0;x/=10)
            {
                a = x % 10;
                if (a % 3 == 0)
                    b++;
                for (int y = 1; y <= a; y++)
                     if (a % y == 0)
                        f++;
                if (f == 2)
                    c+=a;
                f = 0;

            }
            for (int z = 1; z <= b; z++)
                d *= z;
            g = d;
            for (int s = 1; s < c; s++)
                g *= d;
            Console.Write("hasel:" + g);
            Console.ReadKey();

        }
    }
}
