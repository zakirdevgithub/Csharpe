using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Person<T>
    {
        private T name;
        private T age;

        public T Name
        {
            set => this.name = value;
            get => this.name;
        }
        public T Age
        {
            set => this.age = value;
            get => this.age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person<string> zakir = new Person<string>();
            zakir.Name = "Zakir Hossain";
            zakir.Age = "25";
            Console.WriteLine(zakir.Name);
            Console.WriteLine(zakir.Age);
        }
    }
}
