using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която приема за вход четирицифрено число във
            формат abcd (например числото 2011) и след това извършва следните
            действия върху него:
            - Пресмята сбора от цифрите на числото (за нашия пример 2+0+1+1
            = 4).
            - Разпечатва на конзолата цифрите в обратен ред: dcba (за нашия
            пример резултатът е 1102).
            - Поставя последната цифра на първо място: dabc (за нашия пример
            резултатът е 1201).
            - Разменя мястото на втората и третата цифра: acbd (за нашия
            пример резултатът е 2101).*/

            int num;
            Console.Write("Enter 4 digit number : ");
            num = int.Parse(Console.ReadLine());
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            Console.WriteLine("The Sum is {0}", a + b + c + d);
            Console.WriteLine("Opposite direction is {0}{1}{2}{3}", a, b, c ,d);
            Console.WriteLine("4th on 1st : {0}{1}{2}{3}", a,d,c,b);
            Console.WriteLine("2nd and 3rd swap : {0}{1}{2}{3} ", d , b , c ,a);
            Console.ReadLine();


        }
    }
}
