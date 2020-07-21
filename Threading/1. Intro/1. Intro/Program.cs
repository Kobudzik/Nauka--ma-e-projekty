using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
           // Thread t = new Thread(WriteY);          // Kick off a new thread
           // t.Start();                               // running WriteY()
            new Thread(WriteY).Start();

            // Simultaneously, do something on the main thread.
            for (int i = 0; i <= 10000; i++) 
                Console.WriteLine("x" + i);

            Console.Read();
        }

        static void WriteY()
        {
            for (int i = 0; i <= 10000; i++)
                Console.WriteLine("y" + i);
        }
    }
}