using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            DateTime dateTime = new DateTime(1994, 10, 19);
            //Console.WriteLine("My Birthday is: {0}",dateTime);
            //Console.WriteLine("Tomorrow: "+DateTime.Today.AddDays(1));
            //Console.WriteLine("Porshu: " + DateTime.Today.AddDays(2));
            //Console.WriteLine(DateTime.Today.DayOfWeek);
            //Console.WriteLine(DateTime.Today.DayOfYear);
            //Console.WriteLine(DateTime.DaysInMonth(1994,10));
            //Console.WriteLine(DateTime.Now.Minute);

            Console.WriteLine("Enter Your Birth date in yyyy-mm-dd format");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                DateTime now = DateTime.Now;
                TimeSpan dayPassed = now.Subtract(dateTime);
                Console.WriteLine("You passed from your life {0} days",dayPassed.Days);
            }
            
        }
    }
}
