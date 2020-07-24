using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class IndexerPractice
    {
        private int[] myArray = new int[4];

        public int this[int index]
        {
            set => myArray[index] = value;
            get => myArray[index];
        }

        public int this[int index, int i]
        {
            set => myArray[index] = value + i;
            get => myArray[index];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexerPractice obj = new IndexerPractice();
            obj[0] = 10;
            obj[1] = 20;
            obj[2] = 30;
            obj[3] = 40;

            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);

            obj[0, 1] = 100;
            obj[1, 2] = 200;
            obj[2, 3] = 300;
            obj[3, 4] = 400;

            Console.WriteLine(obj[0,1]);
            Console.WriteLine(obj[1,2]);
            Console.WriteLine(obj[2,3]);
            Console.WriteLine(obj[3,4]);


        }
    }
}
