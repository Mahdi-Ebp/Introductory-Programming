using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem70
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a=1,b=1,c=0;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for(int x=1;x<=n;x++)
            {
                for (int y = 1; y <= x; y++)
                    a *= y;
                for (int z = 1; z <= x; z++)
                    b *=a;
                c += b;
                b = 1;
                a = 1;
            }
            Console.Write("hasele ebarat:" + c);
            Console.ReadKey();
        }
    }
}
