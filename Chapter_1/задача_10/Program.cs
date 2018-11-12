using System;

namespace задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 2,b=-3; a<100 && b<=100; a=a+2,b=b-2)
            {
                Console.Write(a+","+b+",");
            }           
        }
    }
}
