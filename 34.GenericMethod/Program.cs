using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{   
    class Calculation 
    {

        public void Add <T>(T a , T b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            calc.Add(20,30);
            calc.Add("Zakir", "Hossain");
        }
    }
}
