using System;

namespace _51._BoxingUnBoxing
{

    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            object obj = number;  //Boxing
            
            Console.WriteLine(obj);
            
            number = (int)(obj); //UnBoxing

            Console.WriteLine(number);
        }
    }
}
