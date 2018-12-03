using System;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to binary is {1}.",
                deci, deci.ToString(deci, 2));
        }
    }
}
