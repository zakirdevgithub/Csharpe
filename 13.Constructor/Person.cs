using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double height;

        public Person()
        {
            Console.WriteLine("This is Default Constructor");
        }
        public Person(string firstName)
        {
            this.firstName = firstName;
        }
        public Person(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person(string firstName,string lastName,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Person(string firstName,string lastName,int age, double height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
        }

        public void Information()
        {
            if(firstName !=null && lastName !=null && age !=0 && height != 0)
            {
                Console.WriteLine("My name is {0} {1}. I am {2} years old and my height is {3}",
                    firstName,lastName,age,height);
            }
            else if(firstName != null && lastName != null && age != 0)
            {
                Console.WriteLine("My name is {0} {1}. I am {2} years old!",
                    firstName, lastName, age);
            }
            else if(firstName != null && lastName != null)
            {
                Console.WriteLine("My name is {0} {1}", firstName, lastName);
            }
            else if(firstName != null)
            {
                Console.WriteLine("My name is {0}", firstName);
            }
            else
            {
                Console.WriteLine("I am Anonymous");


            }
        }
    }
}
