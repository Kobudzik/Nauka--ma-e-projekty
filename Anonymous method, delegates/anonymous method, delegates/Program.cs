using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_method__delegates
{
    class Program
    {
        delegate void MyIntAndString(int i, string s);  //delegate


        static void Main(string[] args)
        {
            
            MyIntAndString printThem = delegate (int i, string s) //anonymous method
            {
                Console.WriteLine("{0} - {1}", i, s);
            };

            printThem(123, "four five six");    //anonymous method call





            MyIntAndString contains = delegate (int i, string s) //anonymous method
            {
                Console.WriteLine(s.Contains(i.ToString()));
            };
            
            contains(123, "four five six"); //anonymous method call

            Delegate d = contains;  //dynamic call
            d.DynamicInvoke(new object[] { 123, "four 123 five six" });



            Console.Read();
        }
    }
}
