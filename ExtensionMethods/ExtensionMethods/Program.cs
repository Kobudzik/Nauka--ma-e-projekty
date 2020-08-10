using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string longString = "This is supposed to be a very, very long string";
            var shortenedString = longString.Shorten(5);
            Console.WriteLine(shortenedString);
            Console.ReadKey();
        }
    }
}
