using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
        //private string firstName;
        private string lastName;
        private int age;
        private double height;

       public string FirstName { get; set; }

       public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 20 && value > 12) throw new Exception("You are a Teenager!");
                age = value;
            }
        }

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void Information()
        {
            Console.WriteLine("My name is {0} {1} and I am {2} years old and my height is {3}",
                FirstName,LastName,Age,GetHeight());
        }
    }
}
