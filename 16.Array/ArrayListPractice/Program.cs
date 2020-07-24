using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        ArrayList myArray = new ArrayList();
            myArray.Add(10);
            myArray.Add(20);
            myArray.Add(30);
            myArray.Add(40);
            myArray.Add(50);
            myArray.Add(60);
            myArray.Add(70);
            myArray.Add(80);
            myArray.Add(90);
            myArray.Add(100);
            myArray.Add("Zakir");
            myArray.Add("Rakib");
            myArray.Add("Zahid");
            myArray.Add("Shovon");
            myArray.Add(7.8);
            myArray.Add(8.8);
            myArray.Add(9.8);
            myArray.Add(12.8);

            int sum = 0;
            double result = 0.0;
            string names = " ";
            foreach(object obj in myArray)
            {
                if (obj is int)
                {
                    sum += (int)obj;
                }
                else if(obj is string)
                {
                    names = names+" "+((string)obj).ToUpper();
                }
                else if(obj is double)
                {
                    result += (double)obj;
                }
               
            }
            Console.WriteLine(sum);
            Console.WriteLine(names);
            Console.WriteLine(result);

            myArray.Remove(100);
            myArray.Remove(90);
            myArray.Remove(80);
            myArray.RemoveAt(4);
            myArray.RemoveAt(5);

            foreach(object obj in myArray)
            {
                Console.WriteLine( obj);
            }
        }
    }
}
