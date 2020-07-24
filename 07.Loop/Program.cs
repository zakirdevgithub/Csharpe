using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }

            int num = 0;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);


            string name = "MD. ZAKIR HOSSAIN JEWEL FROM PABNA MENTAL HOSPITAL";
            foreach (char n in name)
            {
                Console.WriteLine(n);
            }

        }
    }
}
