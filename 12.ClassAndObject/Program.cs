using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Zakir = new Person();
            Zakir.firstName = "Zakir";
            Zakir.lastName = "Hossain";
            Zakir.age = 25;
            Zakir.Information();

            Person Rakib = new Person()
            {
                firstName = "Rakib Rahman",
                lastName="Talukder",
                age=23
            };

            Rakib.Information();

            Person Shuvo = new Person()
            {   
                firstName="Ashraful Alam",
                lastName="Shuvo",
                age=35,
               
            };
            Shuvo.Information();

            Person Zahid = new Person()
            {
                firstName="Zahid",
                lastName="Hasan",
                age=25
            };
            Zahid.Information();
        }
    }
}
