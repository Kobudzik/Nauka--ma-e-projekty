using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Lock
{
    class ThreadSafe
    {
        static bool done;
        static readonly object lockerKonrada = new object();

        static void Main()
        {
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            lock (lockerKonrada)
            {
                if (!done) 
                {
                    Console.WriteLine("Done");
                    done = true; 
                }
            }//release lock
        }
    }
}
