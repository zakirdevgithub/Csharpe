using System;

namespace AccessSpecifiers1
{  public class Person
    {
        public string name;
        public int age;
        public double height;
        public void Display()
        {
            Console.WriteLine("Name: {0} Age: {1} Height: {2}", this.name, this.age, this.height);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            
        }
    }
}
