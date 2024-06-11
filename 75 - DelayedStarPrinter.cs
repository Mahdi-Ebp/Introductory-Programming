using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Threading.Thread;

namespace problem75
{
   
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=1;x<=10;x++)
            {
                Console.Write("*\t");
                Sleep(2000);
            }
            Console.ReadKey();
        }
    }
}
