using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете израз, който да проверява дали третата цифра (от дясно наляво) на дадено цяло число е 7.
            int num;
            Console.Write("Enter your number here : ");
            num = int.Parse(Console.ReadLine());
            int a = num / 100;
            int b = a % 10;
            if (b == 7)
            {
                Console.WriteLine("The third number is 7 indeed");
            }
            else
            {
                Console.WriteLine("The third number is not 7");
            }

        }
    }
}
