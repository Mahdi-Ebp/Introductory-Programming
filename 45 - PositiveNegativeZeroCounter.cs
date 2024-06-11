using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem45
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a=0, b=0, c=1,d;
            Console.Write("tedad adad ha:");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                Console.Write("adad:");
                d = int.Parse(Console.ReadLine());
                if (d == 0)
                    a++;
                else
                    if (d >= 0)
                    b+=d;
                else
                    if (d < 0)
                    c*=d;
            }
            Console.WriteLine("tedad sefr ha:"+a);
            
            Console.WriteLine("majmoo adad mosbat:"+b);
            
            Console.WriteLine("hasel zarb adad manfi:"+c);

            Console.ReadKey();
        }
    }
}
