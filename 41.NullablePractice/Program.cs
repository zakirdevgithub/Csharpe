using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number = null;
            Console.WriteLine(number);
            float? number2 = null;
            Console.WriteLine(number2);
            char? number3 = null;
            Console.WriteLine(number3);
           
            int? num1 = 897;
            Console.WriteLine(num1);
            int? num2;
            num2 = num1;
            Console.WriteLine(num2);
            double? num3 = num1;
            Console.WriteLine(num3);
            double? num5 = 98.78;
            int? num4 = (int)(num5);
            Console.WriteLine(num4);


            int? tickets = null;
            //int availableTickets;

            //if (tickets == null)
            //{
            //    availableTickets = 0;
            //}
            //else
            //{
            //    availableTickets = (int)tickets;
            //}

            int availableTickets = tickets ?? 0; // Coalescing
            /*tickets jodi null hoy taile available ticket e 0 jabe
             * r jodi ticket e kono value dei jmn tickets=70 taile 
             * availableTickets e 70 jabe */

            Console.WriteLine("Available Tickets: {0}",availableTickets);


        }
    }
}
