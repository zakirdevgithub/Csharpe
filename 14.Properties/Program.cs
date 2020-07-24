using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zakir = new Person();
            zakir.FirstName = "Zakir";
            zakir.LastName = "Hossain";
            zakir.Age = 25;
            zakir.SetHeight(5.7);
            zakir.Information();

        }
    }
}
