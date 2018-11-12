using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете израз, който изчислява площта на трапец по дадени страни a и b и височина h.
            double h, a, b;
            Console.WriteLine("Énter h:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = double.Parse(Console.ReadLine());

            double S;
            S = ((a + b) * h) / 2;
            Console.WriteLine("S = {0}",S);
            Console.ReadLine();

        }
    }
}
