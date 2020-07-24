using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Student
    {
        public static string firstName;
        public static string lastName;
        public static int age;

        static Student()
        {
            firstName = "Zakir";
            lastName = "Hossain";
            age = 25;
            Console.WriteLine("My name is {0} {1} and I am {2} years Old!",firstName,lastName,age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student zakir = new Student();

        }
    }
}
