using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
   partial class Calculation
    {
         public void multiply()
        {
            Console.WriteLine("{0} x {1} = {2}",this.num1,this.num2,(this.num1*this.num2));
        }
    }
}
