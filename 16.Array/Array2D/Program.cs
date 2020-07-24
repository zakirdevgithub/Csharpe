using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 3];
            matrix1[0, 0] = 10;
            matrix1[0, 1] = 20;
            matrix1[0, 2] = 30;
            matrix1[1, 0] = 40;
            matrix1[1, 1] = 50;
            matrix1[1, 2] = 50;

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine(matrix1[i,j]);
                }
            }

            int[,] matrix2 = new int[3,4] { {1,2,3,4 },{5,6,7,8 },{9,10,11,14 } };

            foreach(int i in matrix2)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
