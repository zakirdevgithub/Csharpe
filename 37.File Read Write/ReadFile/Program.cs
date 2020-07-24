using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string readFile = System.IO.File.ReadAllText(@"H:\ASP.NET\File Read Write\Lorem.txt");
            Console.WriteLine(readFile);
        }
    }
}
