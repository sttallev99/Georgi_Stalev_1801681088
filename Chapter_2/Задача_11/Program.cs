
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
            

            string a = "\u00a9";

            int maxS = 7;
            int p, q, n;
            for (p = 1; p <= maxS; p++)
            {
                for (q = 1; q <= maxS - p; q++)
                {
                    Console.Write(" ");
                }
                for (n = 1; n <= p; n++)
                {
                    Console.Write("{0} ", a);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
