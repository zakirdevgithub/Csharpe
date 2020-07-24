using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                int num2 = int.Parse(Console.ReadLine());
                double result = num1 / num2;
                Console.WriteLine("Result: "+result);

            }
            catch (Exception)
            {
                Console.WriteLine("Divided by is Not Possible");
            }
            finally
            {
                Console.WriteLine("Thank you for try this");
            }
        }
    }
}
