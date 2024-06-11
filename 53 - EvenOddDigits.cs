using System;

namespace problem53
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a=0, b=0,c=1;
            Console.Write("adad:");
            n = int.Parse(Console.ReadLine());
            for (int x = n; x > 0; x /= 10)
            {
                a = x % 10;
                if (a % 2 == 0)
                    b++;
                else
                 
                    c += a;
            }
            Console.WriteLine("tedad zoj:" + b);
            Console.WriteLine("majmoo e fard:" + c);
            Console.ReadKey();
        }
    }
}
