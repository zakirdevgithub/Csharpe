using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Person
    {
        void Display();
        int Add(int a, int b);

    }
    interface Employee
    {
        void Show();
        int Salary(int x);
    }

    interface Student : Person
    {
        void Departments();
    }

    class Zakir : Person,Employee
    {
        public  void Display()
        {
            Console.WriteLine("My name is Zakir");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void Show()
        {
            Console.WriteLine("This is Show Method");
        }

        public int Salary(int x)
        {
            return x;
        }


    }

    class Rakib : Zakir,Person, Employee
    {
         void Person.Display()
        {
            Console.WriteLine("This is Display From Rakib Classs");
        }
        int Person.Add(int a, int b)
        {
            return a + b;
        }
    
        void Employee.Show()
        {
            Console.WriteLine("This is Show Method from Rakib");
        }

        int Employee.Salary(int x)
        {
            return x;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person rakib = new Rakib();
            rakib.Display();
            Employee erakib = new Rakib();
            erakib.Show();


            Person zakir = new Zakir();
            zakir.Display();

            Rakib rkb = new Rakib();
            rkb.Display();
        }
    }
}
