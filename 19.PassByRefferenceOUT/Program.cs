using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRefferenceOUT
{
    class Program
    {
        static void PassByRefference(out int x)
        {
            x = 20;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            //int value = 5; initialize korleo hobe na korleo hobe.
            int value; 
            PassByRefference(out value);
            Console.WriteLine(value);
        }
    }
}
