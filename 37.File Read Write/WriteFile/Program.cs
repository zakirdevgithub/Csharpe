using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your File Name: ");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Enter Your Text:");
            //string input = Console.ReadLine();
            //System.IO.File.WriteAllText(@"H:\ASP.NET\File Read Write\"+fileName+".txt",input);

            Console.WriteLine("Enter Your File Name: ");
            string fileName2 = Console.ReadLine();
            string[] myArray = {"Zakir","Rakib","Shuvo" };
            using(System.IO.StreamWriter obj=new System.IO.StreamWriter(@"H:\ASP.NET\File Read Write\" + fileName2 + ".txt", true))
            {
                foreach( string name in myArray)
                {
                    obj.WriteLine(name);
                }
            }
        }
    }
}
