using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Calculator
    {
        public string firstName;
        public string lastName;
        public string fullName;
        public void Show()
        {
            Console.WriteLine(string.Format("First Name: " +
                "{0} Last Name:{1}\nFull Name:{2}",firstName,lastName,(firstName+" "+lastName)));
        }
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.firstName = "Zakir";
            calculator.lastName = "Hossain";
            calculator.Show();

            int result=calculator.Add(10, 20);
            Console.WriteLine(result);
        }
    }
}
