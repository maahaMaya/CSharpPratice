using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPratice_.why
{
    internal class ProblemInSingleThread
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
        }

        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 value  : " + i);
            }
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 value : " + i);
            }
        }
        static void Main(string[] args)
        {
            Test1(); // Single thread execution never goes to the next line until its complete the task even its in sleep or rest mode or delay in task performance
            Test2(); // Runs only when Test1 complete its task
            Test3(); // Runs only when Test2 complete its task
        }
    }
}
