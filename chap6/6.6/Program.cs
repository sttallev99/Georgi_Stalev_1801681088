using System;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).
            Console.Write("ВЪВЕДИ N (1<K<N):"); int n = int.Parse(Console.ReadLine());
            Console.Write("ВЪВЕДИ k (1<K<N):"); int k = int.Parse(Console.ReadLine());
            for (int i = n-1; i >0; i--)
            {
                n *= i;
            }
            for (int i = k-1; i > 0; i--)
            {
                k *= i;
            }
            n /= k;
            Console.WriteLine("="+n);
        }

    }
}
