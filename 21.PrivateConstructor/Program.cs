using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        private Person()
        {

        }
        static Person()
        {
            Console.WriteLine("This is Static Constructor");
        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("My name is {0} {1} and I am {2} years old!",firstName,lastName,age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person zakir = new Person("Zakir","Hossain",25);
            zakir.display();
        }
    }
}
