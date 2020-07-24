using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] numbers = new int[3,2,4] { { {1,2,3,4 },{5,6,7,8 } },
                                      { {10,11,12,13 },{14,15,16,17 } },
                                      { {18,19,20,21 },{22,23,24,25 } } };

            Console.WriteLine("I want to find 16 in this 3D array: "+ numbers[1,1,2]);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
