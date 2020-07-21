using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2.Data_sharing
{
    class Program
    {
        bool done;

        static void Main()
        {
            Program tt = new Program();   // Create a common instance
            new Thread(tt.Go).Start();  //start second thread
            tt.Go();        //start in main thread
            Console.Read();
        }

        // Note that Go is now an instance method
        void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done"); 
            }
        }
    }
}