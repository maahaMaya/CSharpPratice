using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingPratice_
{
    internal class MainThreadName
    {
        public void Name()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Demo for default thread :- " + Thread.CurrentThread.Name);
        }
    }
}
