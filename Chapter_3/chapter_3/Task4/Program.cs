using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете израз, който да проверява дали третият бит на дадено число е 1 или 0.

            int num = 30;
            bool bit3 = (num & 8) != 0;
            Console.WriteLine(bit3);
        }
    }
}
