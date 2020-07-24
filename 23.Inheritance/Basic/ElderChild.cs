using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ElderChild :Father
    {
        protected string wifeName;
        protected string job;
        protected int salary;

        public ElderChild():base()
        {

        }

        public ElderChild(string wifeName, string job, int salary):base("Rahman","Brown",2,2)
        {
            this.wifeName = wifeName;
            this.job = job;
            this.salary = salary;

        }

        public override void Display()
        {
            Console.WriteLine("Surname is {0}  Eye Color is {1}  Number of Hand {2}  Number of Leg {3}" +
                " Wife Name {4}  Job Title {5} Salary {6} ",this.surname, this.eyeColor, this.numberOfHand,
                this.numberOfLeg,this.wifeName,this.job,this.salary);

        }
    }
}
