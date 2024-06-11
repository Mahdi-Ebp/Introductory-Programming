using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int c;
            Console.Write("do adad mored nazar khod ra vared karde va sepas ba vared kardan yeki az code haye amaliati amaliat mored nazar ra anjam dahid.    " +
                "Code haye amaliati:   1:+    2:-   3:*   4:/   5:%");
            Console.WriteLine();
            Console.Write("adad aval ra vared konid:");
            a = double.Parse(Console.ReadLine());
            Console.Write("adad dovom ra vared konid:");
            b = double.Parse(Console.ReadLine());
            Console.Write("code amaliati");
            c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:;Console.Write(a + "+" + b + "=");Console.Write(a+b) ; break;
                case 2:Console.Write(a + "-" + b + "=");Console.Write(a - b);break;
                case 3: Console.Write(a + "*" + b + "=");Console.Write(a * b);break;
                case 4: Console.Write(a + "/" + b + "=");Console.Write(a / b);break;
                case 5: Console.Write(a + "%" + b + "=");Console.Write(a % b);break;
                default: Console.Write("Wrong Code"); break;
            }
            Console.WriteLine();
            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
