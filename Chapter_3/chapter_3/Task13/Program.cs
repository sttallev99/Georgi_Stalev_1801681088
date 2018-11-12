using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която проверява дали дадено число n (1 < n < 100)
            е просто (т.е. се дели без остатък само на себе си и на единица).*/
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int result = Check_Prime(number);
            if (result == 0)
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is  a prime number", number);
            }
            Console.Read();
        }

        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
    }

