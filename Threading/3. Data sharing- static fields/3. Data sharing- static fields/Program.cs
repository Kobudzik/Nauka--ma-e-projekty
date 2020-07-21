using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Data_sharing__static_fields
{
    class ThreadTest
    {
        static bool done;    // Static fields are shared between all threads

        static void Main()
        {
            new Thread(Go).Start(); //start second thread and task
            Go();   //start in main
            Console.Read();
        }

        static void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
