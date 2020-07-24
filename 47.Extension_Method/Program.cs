using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
        }

       
    }
    public static class MyExtensionMethod
    {
        public static bool IsGreaterThan(this int i, int number)
        {
            return i > number;
        }
    }
  
}
