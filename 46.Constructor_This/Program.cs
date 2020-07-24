using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_This
{
    public class Person
    {
        private string _name;
        private int _age;
        
        public Person()
        {
            Console.WriteLine("My Name is Zakir Hossain");
        }

        public Person(string _name, int _age) : this()
        {
            this._name = _name;
            this._age = _age;
        }

        public void Show()
        {
            Console.WriteLine("My name is {0} and I am {1} years old! ",this._name,this._age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Zakir Hossain",25);

            person.Show();
           
        }
    }
}
