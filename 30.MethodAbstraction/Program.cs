using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAbstraction
{
    class Person
    {
        private void sensitiveInfo()
        {
            Console.WriteLine("This is Sentitive Information so you cant call this method directly");
        }

        public void showSecret()
        {
            sensitiveInfo();
            Console.WriteLine("Sensitive info showed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pr = new Person();
            pr.showSecret();
        }
    }
}
