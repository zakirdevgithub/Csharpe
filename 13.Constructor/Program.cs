using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person anonymous = new Person();
            anonymous.Information();

            Person adib = new Person("Adib");
            adib.Information();

            Person denis = new Person("Denis", "Panjuta");
            denis.Information();

            Person rakib = new Person("Rakib", "Rahman", 23);
            rakib.Information();

            Person zakir = new Person("Zakir", "Hossain", 25, 5.7);
            zakir.Information();
            
        }
    }
}
