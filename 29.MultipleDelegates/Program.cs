using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDelegates
{
    public delegate void Calculator(int a, int b);
    public delegate string Show(string firstName, string lastName, int age);
    class Calculation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2} ", a, b, (a + b));
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2} ", a, b, (a - b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("{0} x {1} = {2} ", a, b, (a * b));
        }
        public static void Divided(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2} ", a, b, (a / b));
        }

        public static  string Information(string firstName, string lastName, int age)
        {
            string fullInfo = string.Format("My name is {0} {1} and I am {2} years old!", firstName, lastName,  age);
            return fullInfo;
        }
    }
    public delegate void MyInfo();
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void Display()
        {

            string fullNameWithAge = string.Format("My name is {0} {1} and I am {2} years old!", this.firstName, this.lastName, this.age);
            Console.WriteLine(fullNameWithAge);
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(Calculation.Add);
            calc += Calculation.Substract;  //Multicast
            calc += Calculation.Multiply;
            calc += Calculation.Divided;
            calc.Invoke(40, 10);

            Show zakir = new Show(Calculation.Information);
            string zakirInfo=zakir.Invoke("Zakir", "Hossain", 25);
            Console.WriteLine(zakirInfo);

            Person myobj = new Person("Zakir", "Hossain", 25);

            MyInfo newObj = new MyInfo(myobj.Display);
            newObj.Invoke();
      

        }
    }
}
