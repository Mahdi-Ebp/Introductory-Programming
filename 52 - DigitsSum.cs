using System;

namespace problem52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t=0;
            Console.Write("adad:");
            n=int.Parse(Console.ReadLine());
            for (int x = n; x > 0; x /= 10)
                t +=x%10;
            Console.Write("majmoo argham:"+t);
            Console.ReadKey();
        }
    }
}
