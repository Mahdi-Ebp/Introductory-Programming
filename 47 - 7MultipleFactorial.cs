using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b=0, c=1;
            Console.Write("tedad adad ha:");
            n = int.Parse(Console.ReadLine());
            for(int x=1;x<=n;x++)
            {
                Console.Write("tedad:");
                a = int.Parse(Console.ReadLine());
                if (a % 7 == 0)
                    b ++;
                
            }
            for (int y = 1; y <= b; y++)
                c *= y;


            Console.Write("javab:" + c);
            Console.ReadKey();
        }
    }
}
