using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyThread
{
    public class CountingClass
    {
        public static void CountFromClass()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("From Another Class: "+i);
                Thread.Sleep(500);
            }
        }
    }
    class Program
    {
        static void Count1()
        {
            for (int i = 0; i <11; i++)
            {
                Console.WriteLine("From Count 1: "+i);
                Thread.Sleep(500);
            }
        }

        static void Count2()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("From Count 2: " + i);
                Thread.Sleep(500);
            }
        }
        static void Count3()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("From Count 3: " + i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Start");
            ThreadStart ts = new ThreadStart(CountingClass.CountFromClass);
            Thread tsh = new Thread(ts);
            tsh.Start();
            //tsh.Join();
            Thread th1 = new Thread(Count1);
            Thread th2 = new Thread(Count2);
            Thread th3 = new Thread(Count3);
            th1.Start();
            th1.Join();
            th2.Start();
            th2.Join();
            th3.Start();
            th3.Join();
            Console.WriteLine("Main Method End");
        }
    }
}
