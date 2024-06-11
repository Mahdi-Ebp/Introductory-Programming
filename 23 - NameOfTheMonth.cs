using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("shomare mah:");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Console.Write("farvardin"); break;
                case 2: Console.Write("ordibehesht"); break;
                case 3: Console.Write("khordad"); break;
                case 4: Console.Write("tir"); break;
                case 5: Console.Write("mordad"); break;
                case 6: Console.Write("shahrivar"); break;
                case 7: Console.Write("mehr"); break;
                case 8: Console.Write("aban"); break;
                case 9: Console.Write("azar"); break;
                case 10: Console.Write("dey"); break;
                case 11: Console.Write("bahman"); break;
                case 12: Console.Write("esfand"); break;
            }
            Console.ReadKey();


        }
    }
}
