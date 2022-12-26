using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPratice_.Join
{
    internal class JoinOperation
    {
        public static void Test1()
        {
            Console.WriteLine("Thread 1 start execution.");
            for(int i = 0; i < 50; i++)
                Console.WriteLine("test1 is : "+i);
            Console.WriteLine("Thread 1 end execution.");
        }

        public static void Test2()
        {
            Console.WriteLine("Thread 2 start execution.");
            for (int i = 0; i < 50; i++)
                Console.WriteLine("test2 is : " + i);
            Console.WriteLine("Thread 2 end execution.");
        }

        public static void Test3()
        {
            Console.WriteLine("Thread 3 start execution.");
            for (int i = 0; i < 50; i++)
                Console.WriteLine("test3 is : " + i);
            Console.WriteLine("Thread 3 end execution.");
        }
        static void Main(string[] args)
        {
            //Here main thread end execution even reamaining thread not complete the execution 
            //Console.WriteLine("main thread start execution.");
            //Thread t1 = new Thread(Test1);  
            //Thread t2 = new Thread(Test2);
            //Thread t3 = new Thread(Test3);
            //t1.Start(); t2.Start(); t3.Start();
            //Console.WriteLine("main thread end execution.");

            //Solution :- Join without time = waits until the join thread execute
            //Console.WriteLine("main thread start execution.");
            //Thread t1 = new Thread(Test1);
            //Thread t2 = new Thread(Test2);
            //Thread t3 = new Thread(Test3);
            //t1.Start(); t2.Start(); t3.Start();
            //t1.Join();
            //Console.WriteLine("main thread end execution.");

            //Join Operation wait for a time 
            //Solution :- Join without time = waits until the join thread execute
            Console.WriteLine("main thread start execution.");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(1000);
            Console.WriteLine("main thread end execution.");
        }
    }
}
