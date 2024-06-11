using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("zel aval:");
            a = int.Parse(Console.ReadLine());
            Console.Write("adad dovom:");
            b = int.Parse(Console.ReadLine());
            Console.Write("adad sevom:");
            c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a == c)
                    Console.Write("motesavi ol azla");
                else
                    if (a == b || a == c || b == c)
                    Console.Write("motesavi ol sagheyn");
                else
                    if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                    Console.Write("ghaem ol zavie");
                else
                    if (!(a == b && b == c))
                    Console.Write("mokhtalef ol azla");
                else
                    if (a == b && c * c == a * a + b * b || a == c && b * b == a * a + c * c || b == c && a * a == b * b + c * c)
                    Console.Write("ghaem ol zavie motesavi ol saghein");
            }
            else
                Console.Write("se zel tashkil mosalas nemidahad");
            Console.ReadKey();
        }
    }
}
