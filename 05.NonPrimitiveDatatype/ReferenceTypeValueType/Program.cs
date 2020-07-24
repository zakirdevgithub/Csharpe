using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeValueType
{
    public class Person
    {
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = a;
            b++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            string name = "Keya";
            Name(name);
            Console.WriteLine(name);

            Person person = new Person()
            {
                name = "keya"
            };

            ReferenceTypeFunction(person);
            Console.WriteLine(person.name);




        }

        static void Name(string name)
        {
            name = "Zakir";
        }

        static void ReferenceTypeFunction(Person obj)
        {
            obj.name = "Zakir";
        }
    }
}
