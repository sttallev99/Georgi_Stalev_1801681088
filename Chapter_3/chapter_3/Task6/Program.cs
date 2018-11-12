using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която за подадени от потребителя дължина и
            височина на правоъгълник пресмята и отпечатва на конзолата него-
            вите периметър и лице.*/
            double h, a;
            Console.WriteLine("Énter h:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());

            double P, S;
            P = 2 * a + 2 * h;
            Console.WriteLine("P = {0}", P);
            S = a * h;
            Console.WriteLine("S = {0}", S);

        }
    }
}
