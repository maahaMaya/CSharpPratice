using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPratice_.why
{
    internal class SolutionMultiThreading
    {
        public static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1 value  : " + i);
                if (i == 40)
                {
                    Console.WriteLine("Test1 thread is sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test1 thread is wake up");
                }
            }
            Console.WriteLine("Thread1 is execute");
        }

        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 value  : " + i);
            }
            Console.WriteLine("Thread2 is execute");
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 value : " + i);
            }
            Console.WriteLine("Thread3 is execute");
        }
        static void Main(string[] args)
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);

            //T1.Start(); T2.Start(); T3.Start();

            //T1.Start(); T2.Start();

            Console.WriteLine("Main thread is execute");
            T1.Start(); T2.Start(); T3.Start();
        }
    }
}
