using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Numbers 
    {
        number1,
        number2,
        number3,
        number4,
        number5
    }
    class Program
    {
        static void Main(string[] args)
        {
            var num = (int)(Numbers.number3);
            Console.WriteLine(num);

           string num1 = num.ToString();
            Console.WriteLine(num1);

           var num2 = "123";
            var myNum= (Numbers) Numbers.Parse(typeof(Numbers), num2);
            Console.WriteLine((int)myNum);

            Numbers name = (Numbers)Numbers.Parse(typeof(Numbers), "number5");

            string myName = name.ToString();
            Console.WriteLine(myName);

            int myNumber = 90;
            Numbers anotherNumber = (Numbers)myNumber;
            Console.WriteLine(anotherNumber);
           
           

            
        }
    }
}
