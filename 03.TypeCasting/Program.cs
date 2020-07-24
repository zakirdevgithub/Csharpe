using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implicit 
            byte num = 245;
            int number = num;
            Console.WriteLine(number);

            //Explicit or Casting

            float myNum = 643.76f;
            int myN = (int)myNum;
            Console.WriteLine(myN);

            //String to others

            //Convert
            string code = "123";
            byte conByte = Convert.ToByte(code);
            Console.WriteLine(conByte);
            short conShort = Convert.ToInt16(code);
            Console.WriteLine(conShort);
            int conInt = Convert.ToInt32(code);
            Console.WriteLine(conInt);
            double conDouble = Convert.ToDouble(code);
            Console.WriteLine(conDouble);
            long conLong = Convert.ToInt64(code);
            Console.WriteLine(conLong);
            decimal conDecimal = Convert.ToDecimal(code);
            Console.WriteLine(conDecimal);
            float conFloat = Convert.ToSingle(code);
            Console.WriteLine(conFloat);

            //Parse
            string chara = "Z";
            char conChar = char.Parse(chara);
            Console.WriteLine(conChar);

            string n = "67";
            int myInt = int.Parse(n);
            Console.WriteLine(myInt);

            //to String

            float pi = 3.1416f;
            string myPi = pi.ToString();
            Console.WriteLine(myPi);


        }
    }
}
