using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете булев израз, който да проверява дали дадено цяло число се
            дели и на 5, и на 7 без остатък.*/
            int num;
            Console.Write("Enter your number here : ");
            num = int.Parse(Console.ReadLine());
            if (num % 35 == 0) 
            {

                bool newBool = true;
                Console.WriteLine(newBool);
            }
            else
            {
                bool newBool = false;
                Console.WriteLine(newBool);
            }
        }
    }
}
