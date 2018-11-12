using System;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int aa = b;
            b = a;
            a = aa;

            Console.WriteLine("{0} , {1}", a, b);
        }
    }
}
