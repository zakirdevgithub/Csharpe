using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Computer
    {
        public int ram;
        public int hdd;
        public float processor;
        public void display()
        {
            Console.WriteLine(string.Format("RAM= {0} HDD= {1} Processor= {2}", ram,hdd,processor));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            com.ram = 8;
            com.hdd = 1000;
            com.processor = 2.6f;
            com.display();
        }
    }
}
