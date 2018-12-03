using System;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("пика "); break;
                        case 1: Console.Write("купа "); break;
                        case 2: Console.Write("каро "); break;
                        case 3: Console.Write("спатия "); break;
                    }
                    switch (j)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;

                    }
                }
            }
        }
    }
}
