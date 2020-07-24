using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
     sealed class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            set => this.firstName = value;
            get => this.firstName;
        }

        public string LastName
        {
            set => this.lastName = value;
            get => this.lastName;
        }
        public int Age
        {
            set => this.age = value;
            get => this.age;
        }

        public  void Display()
        {
            Console.WriteLine("My name is {0} {1} and I am {2} years old!",FirstName,LastName,Age);
        }
    }

//class Student : Person
//{
//    private int id;
//    public int ID
//    {
//        set => this.id = value;
//        get => this.id;
//    }
//    public new void Display()
//    {
//        Console.WriteLine("My name is {0} {1} and I am {2} years old! My id is {3}", FirstName, LastName, Age, ID);
//    }
//}
class Program
    {
        static void Main(string[] args)
        {

            //Student std = new Student();
            //std.FirstName = "Zakir";
            //std.LastName = "Hossain";
            //std.Age = 25;
            //std.ID = 8024;
            //std.Display();
        }
    }
}
