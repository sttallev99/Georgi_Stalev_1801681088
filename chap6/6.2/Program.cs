using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n="); int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i%3==0 && i%7==0)
                {
                   break;
                }
                Console.Write(i+" ");
            }
        }
    }
}
