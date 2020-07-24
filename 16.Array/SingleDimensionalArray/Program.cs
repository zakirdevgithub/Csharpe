using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine("Number at index {0} is {1}",i, numbers[i]);
            }

            string[] friends = new string[] {"shovon","rakib","zahid","shuvo","limon","tushar" };

            foreach( string friend in friends)
            {
                Console.WriteLine(friend.ToUpper());
            }

            char[] letters = { 'a','b','c','d','e','f','g','h','i'};

            foreach(char letter in letters)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
