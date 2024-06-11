using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem46
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b = 1, c = 0;
            Console.Write("tedad adad ha:");
            n = int.Parse(Console.ReadLine());
            for(int x=1;x<=n;x++)
            {
                Console.Write("adad:");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                    b *= a;
                else
                    if (a % 5 == 0)
                    c += a;
            }
            Console.WriteLine("hasel zarb adad bakhsh zoj:"+b);
            Console.WriteLine("hasel jam adad bakhsh pazir bar 5:"+c);
            Console.ReadKey();
        }
    }
}
