using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem66
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 10; y >= 1; y--)
                    Console.Write(x * y + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
