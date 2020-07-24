using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            int c = 40;
            Console.WriteLine("20 + 10 ="+ (b + a));
            Console.WriteLine("20 - 10 ="+ (b - a));
            Console.WriteLine("20 * 10 ="+ (b * a));
            Console.WriteLine("20 / 10 ="+ (b / a));
            Console.WriteLine("20 % 10 ="+ (b % a));
            Console.WriteLine("20 > 10 ="+ (b > a));
            Console.WriteLine("20 < 10 ="+ (b < a));
            Console.WriteLine("20 >= 10 ="+ (b >= a));
            Console.WriteLine("20 <= 10 ="+ (b <= a));
            Console.WriteLine("20 != 10 ="+ (b != a));
            Console.WriteLine("10 > 20 and 20 < 40 is "+(a>b && b<c));
            Console.WriteLine("10 > 20 or 20 < 40 is "+(a>b || b<c));

        }
    }
}
