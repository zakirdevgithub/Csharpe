using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizerOrDestructor
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine("My name is {0} {1} and I am {2} years old!",firstName,lastName,age);
        }

        ~Person()
        {
            Console.WriteLine("Finalizer or Destructor Calling");
            
        }
    }
}
