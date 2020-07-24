using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRefferenceREF
{
    class Program
    {
        static void PassByRefference(ref int x)
        {
            x = 20;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int value = 5;
            PassByRefference(ref value);
            Console.WriteLine(value);

        }
    }
}
