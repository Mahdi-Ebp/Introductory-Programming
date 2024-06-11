using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem64
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 5; x++)
            {
                for (int y = 1; y <= 5; y++)

                    Console.Write(x * y + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
