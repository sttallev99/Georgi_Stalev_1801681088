using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която проверява дали дадена точка О (x, y) е
            вътре в окръжността К ({0,0}, R=5) и едновременно с това извън
            правоъгълника [{-1, 1}, {5, 5}]. Пояснение: правоъгълникът е
            зададен чрез координатите на долния си ляв и горния си десен ъгъл.*/
            int x, y;
            Console.WriteLine("Insert x = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert y = ");
            y = int.Parse(Console.ReadLine());
            if (x <= 6 && y <= 6 && (x * x) + (y * y) <= 25 )
            {
                Console.WriteLine("Inside");

            }
            else
            {
                Console.WriteLine("Outside");
            }
            Console.ReadLine();

        }
    }
}
