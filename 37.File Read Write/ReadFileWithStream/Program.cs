using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileWithStream
{
    class Program
    {
        static void Main(string[] args)
        {
            using(System.IO.StreamReader obj= new System.IO.StreamReader(@"H:\ASP.NET\File Read Write\Lorem.txt"))
            {
                Console.WriteLine(obj.ReadToEnd());
            }
        }
    }
}
