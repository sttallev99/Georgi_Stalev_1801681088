using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дадено е число n и позиция p. Напишете поредица от операции, които
            да отпечатат стойността на бита на позиция p от числото n (0 или 1).
            Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0.*/
            int n = 35; // 00100011
            int p = 6;
            int i = 1; // 00000001
            int mask = i << p; 
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
    }
}
