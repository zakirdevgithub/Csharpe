using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> evenNumber = list.FindAll(i => i % 2 == 0);
            evenNumber.ForEach(i =>
            {
                Console.WriteLine(i);
            });
        }
    }
}
