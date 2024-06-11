using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem65
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 5; x >= 1; x--)
            {
                for (int y = 5; y >= 1; y--)
                    Console.Write(x * y + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
