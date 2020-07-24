using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Person
    {
        protected  string name;
        protected int age;
        public abstract void Show(string name, int age);
    }
    class Student : Person
    {
        public override void Show(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Show("Zakir Hossain", 25);
            
        }
    }
}
