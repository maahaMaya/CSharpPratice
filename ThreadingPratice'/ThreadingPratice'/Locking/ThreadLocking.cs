using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPratice_.Locking
{
    internal class ThreadLocking
    {
        public void Dispaly()
        {
            Console.Write("[c# is an ");
            Thread.Sleep(5000);
            Console.WriteLine("OOPs language]");
        }

        public void DispalyWithLock()
        {
            lock (this)
            {
                Console.Write("[c# is an ");
                Thread.Sleep(5000);
                Console.WriteLine("OOPs language]");
            }
        }
        static void Main(string[] args)
        {
            //ThreadLocking threadLocking = new ThreadLocking(); // Single thread
            //threadLocking.Dispaly();
            //threadLocking.Dispaly();
            //threadLocking.Dispaly();

            //Problem
            //ThreadLocking threadLocking = new ThreadLocking(); // Multiple thread
            //Thread t1 = new Thread(threadLocking.Dispaly);
            //Thread t2 = new Thread(threadLocking.Dispaly);
            //Thread t3 = new Thread(threadLocking.Dispaly);
            ////t1.Start();
            ////t1.Start(); t2.Start(); 
            //t1.Start(); t2.Start(); t3.Start();

            //Solution to excute if we need one thread or block of code is excute then TIME sharing is Stop :- LOCK
            ThreadLocking threadLocking = new ThreadLocking(); // Multiple thread
            Thread t1 = new Thread(threadLocking.DispalyWithLock);
            Thread t2 = new Thread(threadLocking.DispalyWithLock);
            Thread t3 = new Thread(threadLocking.DispalyWithLock);
            //t1.Start();
            //t1.Start(); t2.Start(); 
            t1.Start(); t2.Start(); t3.Start();

        }
    }
}
