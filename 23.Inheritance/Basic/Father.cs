using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Father
    {
        protected string surname;
        protected string eyeColor;
        protected int numberOfHand;
        protected int numberOfLeg;

        public Father()
        {
            this.surname = "Rahman";
            this.eyeColor = "brown";
            this.numberOfHand = 2;
            this.numberOfLeg = 2;
            Console.WriteLine("Surname is {0}  Eye Color is {1}  Number of Hand {2}  "+
              "Number of Leg {3} ", this.surname, this.eyeColor, this.numberOfHand,
              this.numberOfLeg);
        }
        public Father(string surname,string eyeColor, int numberOfHand, int numberOfLeg)
        {
            this.surname = surname;
            this.eyeColor = eyeColor;
            this.numberOfHand = numberOfHand;
            this.numberOfLeg = numberOfLeg;
        }

        public virtual void Display()
        {
            Console.WriteLine("Surname is {0}  Eye Color is {1}  Number of Hand {2}  "+
                "Number of Leg {3} ", this.surname, this.eyeColor, this.numberOfHand,
                this.numberOfLeg);

        }
    }
}
