using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            if ((number < 5) && (number > 20))
            {
                Console.WriteLine( "My name is IRON MAN");
            }
            else if((number > 5) || (number > 20))
            {
                Console.WriteLine("My name is THOR");
            }
            else
            {
                Console.WriteLine("I am Zakir");
            }

            switch (number)
            {
                case 1: case 2: case 3: case 4:
                    Console.WriteLine("Do Nothing");
                    break;
                case 6:
                    Console.WriteLine("Do Something");
                    break;
                case 10:
                    Console.WriteLine("Do Everything");
                    break;

                default:
                    Console.WriteLine("This is not a Number");
                    break;
            }

            string result = number > 5 ? "YES" : "NO";
            Console.WriteLine(result);

        }
    }
}
