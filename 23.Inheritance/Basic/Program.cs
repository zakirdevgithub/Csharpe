using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            ElderChild echild = new ElderChild();
            ElderChild obj = new ElderChild("Keya Rahman", "Software Development", 70000);
            obj.Display();

        }
    }
}
