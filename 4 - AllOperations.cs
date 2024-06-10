using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, g;
            Console.Write("Adad aval ra vared konid:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Adad dovom ra vared konid:");
            b = double.Parse(Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            g = a % b;
            Console.WriteLine("summation= " + c);
                       
            Console.WriteLine("difference= " + d);
            
            Console.WriteLine("multiply= " + e);
          
            Console.WriteLine("quotient= " + f);
           
            Console.WriteLine("remainder= " + g);
          
            Console.ReadKey();
        }
    }
}
