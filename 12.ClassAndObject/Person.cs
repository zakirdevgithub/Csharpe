using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Information()
        {
            Console.WriteLine("Hi, my name is {0} {1} and I am {2} years old!", firstName,lastName,age) ;
        }
    }
}
