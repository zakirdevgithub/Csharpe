﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class Calculation
    {
        public void Divided()
        {
            Console.WriteLine("{0} / {1} = {2}",this.num1, this.num2,(this.num1/this.num2));
        }
    }
}
