using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    class Program
    {
        static void PassByValue(int x)
        {
            x = 20;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int value = 5;
            PassByValue(value);
            Console.WriteLine(value);


        }
    }
}
