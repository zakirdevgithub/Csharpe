using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegator
{
    public delegate void Calculator(int a, int b);
    class Calculation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2} ",a,b,(a+b));
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2} ", a, b, (a - b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("{0} x {1} = {2} ", a, b, (a * b));
        }
        public static void Divided(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2} ", a, b, (a / b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(Calculation.Add);
            calc.Invoke(20, 10);
            Calculator calc2 = new Calculator(Calculation.Substract);
            calc2(20, 10);

            calc = Calculation.Multiply;
            calc.Invoke(5, 6);

            calc2 += Calculation.Divided;
            calc2.Invoke(20, 10);
        }
    }
}
