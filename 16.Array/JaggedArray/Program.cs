using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = new int[3][];
            numbers[0] = new int[4];
            numbers[1] = new int[5];
            numbers[2] = new int[3];

            numbers[0][0] = 10;
            numbers[0][1] = 20;
            numbers[0][2] = 30;
            numbers[0][3] = 40;

            numbers[1][0] = 50;
            numbers[1][1] = 60;
            numbers[1][2] = 70;
            numbers[1][3] = 80;
            numbers[1][4] = 90;

            numbers[2][0] = 100;
            numbers[2][1] = 200;
            numbers[2][2] = 300;

            Console.WriteLine("I want to find 90 from numbers jagged array: "+ numbers[1][4]);

            foreach(int[] i in numbers)
            {
                foreach(int j in i)
                {
                    Console.WriteLine(j);
                }
            }

            string[][] names = new string[][]
            {
                new string[]{"abbu","vaiya","apa","keya","zahid","afsin","rubaiya","setu"},
                new string[]{"shovon","limon","rakib"},
                new string[]{"tushar","rasel","mohi","shuvo"}
            };

            Console.WriteLine(names[1][2].ToUpper());
            Console.WriteLine(names.Length);

            for (int i = 0; i < names.Length; i++)
            {
                for(int j=0; j< names[i].Length; j++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Family members: "+names[i][j]);
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Best Friends: "+names[i][j]);
                    }
                    else
                    {
                        Console.WriteLine("Friends: "+names[i][j]);
                    }
                }
            }
        }
    }
}
