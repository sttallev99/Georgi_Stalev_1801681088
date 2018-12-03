using System;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 0, vuvedi = 0;
            Console.Write("input a numbers lenght");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter numbers");
                vuvedi = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = max = vuvedi;
   }
                else
                {
                    if (min > vuvedi) min = vuvedi;
                    if (max < vuvedi) max = vuvedi;
                }
            }
            Console.WriteLine("min - {0} max - {1}",min,max);
        }
    }
}
