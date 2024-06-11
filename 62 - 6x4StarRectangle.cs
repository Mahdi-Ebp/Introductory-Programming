using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem62
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=1;x<=24;x++)
            {
                Console.Write("*  ");
                if(x%6==0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
