using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    class Person
    {
        public virtual void Display()
        {
            Console.WriteLine("This is From Person Class");
        }
    }
    class Teacher : Person
    {
        public sealed override void Display()
        {
            base.Display();
            Console.WriteLine("This is From Teacher Class");
        }
    }
    //class Student : Teacher
    //{
    //    public override void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("This is From Student Class");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Student std = new Student();
            //std.Display();
        }
    }
}
