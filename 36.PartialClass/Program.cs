using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{

    class Program
    {
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(20,10);
            obj.Add();
            obj.Substract();
            obj.multiply();
            obj.Divided();
        }
    }
}
