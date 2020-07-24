using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizerOrDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zakir = new Person("Zakir", "Hossain", 25);
            zakir.Info();
            Console.ReadKey();
        }
    }
}
