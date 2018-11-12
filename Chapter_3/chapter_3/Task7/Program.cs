using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Силата на гравитационното поле на Луната е приблизително 17% от
            това на Земята. Напишете програма, която да изчислява тежестта на
            човек на Луната по дадената тежест на Земята.*/

            double kilo;
            Console.WriteLine("Enter kg : ");
            kilo = double.Parse(Console.ReadLine());
            double lr;
            lr = kilo - (kilo * 0.17);
            Console.WriteLine("Your kilos on the Moon : {0}", lr);
            Console.ReadLine();

        }
    }
}
