using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProperties
{
    abstract class Person
    {
        protected string name;
        protected int age;
        public abstract string Name { set; get; }
        public abstract int Age { set; get; }
    }
    class Student : Person
    {
        public override string Name
        {
            set => this.name=value;
            get => this.name;
        }
        public override int Age
        {
            set => this.age = value;
            get => this.age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Zakir Hossain";
            std.Age = 25;
            Console.WriteLine(std.Name);
            Console.WriteLine(std.Age);
        }
    }
}
