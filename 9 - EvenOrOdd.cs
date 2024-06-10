using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("adad ra vared konid:");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.Write("adad " + a + " zoj ast");
            else
                Console.Write("adad " + a + " fard ast");
            Console.ReadKey();
          
        }
    }
}
