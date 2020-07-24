using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected double height;
        
        public Person(string firstName, string lastName, int age, double height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
        }

        public void Display()
        {
            Console.WriteLine("My name is {0} {1}. I am {2} years old and My height is {3}",
                this.firstName,this.lastName,this.age,this.height);
        }
    }

    class Student : Person 
    {
        protected int id;
        public static string schoolName;

        public Student(int id) :base("Zakir","Hossain",25,5.7)
        {
            this.id = id;
        }

        public new void Display()
        {
            Console.WriteLine("My name is {0} {1}. I am {2} years old and My height is {3} ID {4}, Shchool Name {5}",
    this.firstName, this.lastName, this.age, this.height,this.id, Student.schoolName );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student(8024);
            Student.schoolName = "SUST";
            std.Display();
        }
    }
}
