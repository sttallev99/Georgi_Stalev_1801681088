юusing System;

namespace задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello ";
            string world = "world";
            object a = hello + world;
            string all;
            all = (string)a;
            System.Console.WriteLine(a);
        }
    }
}
