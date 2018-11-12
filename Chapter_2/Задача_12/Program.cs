using System;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string Surname = Console.ReadLine();
            string age = Console.ReadLine();
            int nAge = int.Parse(age);
            string mySex = Console.ReadLine();
            char rSex = char.Parse(mySex);
            string number = Console.ReadLine();
            int newNumb = int.Parse(number);
            Console.WriteLine("Name : {0}  Surname : {1}  Age : {2}  Sex : {3}  Unicode : {4}", FirstName, Surname, nAge, rSex, newNumb);
        }
    }
}
