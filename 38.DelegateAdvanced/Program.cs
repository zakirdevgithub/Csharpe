using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> evenNumber = list.FindAll(delegate (int i)
             {
                 return (i % 2 == 0);
            });
            foreach(int number in evenNumber)
            {
                Console.WriteLine(number);
            }

            List<int> oddNumber = list.FindAll(delegate(int i)
            {
                return (i % 2 != 0);
            });
            foreach(int oddNum in oddNumber)
            {
                Console.WriteLine(oddNum);
            }
        }
    }
}
