using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class Student
    {
        public static string firstName;
        public static string lastName;
        public static int age;

        static Student()
        {
            Console.WriteLine("This is static constructor");
        }

        public static void Display(string firstName, string lastName, int age)
        {
            Student.firstName = firstName;
            Student.lastName = lastName;
            Student.age = age;
            
        }
        public static void Show()
        {
            Console.WriteLine(Student.firstName);
            Console.WriteLine(Student.lastName);
            Console.WriteLine(Student.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student.Display("Zakir","Hossain",25);
            Student.Show();
        }
    }
}
