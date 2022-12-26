using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPratice_.Construcrtor
{
    internal class ConstructorTypes
    {
        public static void Test()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Value of Test : "+i);
            }
        }
        public static void TestWithParameter(object maxObject)
        {
            int max = Convert.ToInt32(maxObject);
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Value of TestWithParameter : " + i);
            }
        }
        static void Main(string[] args)
        {
            /* ThreadStart obj = new ThreadStart(Test); //Explicit done by programmer 
               Thread thread = new Thread(obj);
               thread.Start();
                            //OR
               Thread thread = new Thread(Test); //Implicit done by CLR
               thread.Start(); */

            //ThreadStart obj = new ThreadStart(Test); 
            //ThreadStart obj = Test;
            //ThreadStart obj = delegate { Test(); };
            //ThreadStart obj = () => Test();
            //Thread thread = new Thread(obj);
            //thread.Start();

            //1. Constructor without parameter 
            ThreadStart obj = new ThreadStart(Test);
            Thread thread = new Thread(obj);
            thread.Start();

            //2. Constructor without parameter Object type 
            //ThreadStart obj = new ThreadStart(TestWithParameter); // give erreor 
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(TestWithParameter);
            Thread threadParametre = new Thread(parameterizedThreadStart);
            threadParametre.Start(44);
        }
    }
}
