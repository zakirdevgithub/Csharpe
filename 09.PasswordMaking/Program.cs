using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for(int i=0; i<passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
               
            }
            string password = new string(buffer);
            Console.WriteLine(password);
        
            
        }
    }
}
