using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{

    //func, action- built in delegates
    //func returns
    //action returns void
    //predicate- for linq- delegate returning values


    ///delgates
    delegate int CombineTwoInts(int x, int y);
    delegate double MultiplyNumbers(int a, int b);
    delegate int MyDelegate(int x, int y);
    delegate void MyIntAndString(int i, string s);  //delegate






    class Program
    {
        static void Main(string[] args)
        {


            //NO LAMBDA- no anonomus method- NAMED method
            int Sum(int x, int y)
            {
                return x + y;
            }


            //przypisanie- dwie metody do wywołania
            //MyDelegate d = new MyDelegate(Sum);
            MyDelegate deletaTeSum = Sum;

            int result1 = deletaTeSum.Invoke(12, 15);
            Console.WriteLine("result 1:  " + result1);

            int result2 = deletaTeSum(12, 15);
            Console.WriteLine("result 2:  " + result2);

            
            void Execute()
            {
                //NO LAMBDA- anonomous method
                MultiplyNumbers multiply = delegate (int number1, int number2)
                {
                    return number1 * number2;
                };

                //wykonanie
                Console.WriteLine("Anonomous method result- Execute:  " + multiply(4, 3)+ "  "+ multiply(4, 3).GetType());
            }
            Execute();

            //delegate, anonymous method using lambda, dynamic invoke (slow)
            MyIntAndString lambda = (int a, string b) => { Console.WriteLine("ELO: " + a + b); };
            //parameter is array of objects
            lambda.DynamicInvoke(new object[] { 123, "four five six" });


            //LAMBDA DELEGATES
            //  => GOES TO
            CombineTwoInts adder = (a, b) => { return a + b; };
            Console.WriteLine("lambda delegate:  " + adder(3, 5));

            //LAMBDA DELEGATE
            CombineTwoInts multiplier = (int a, int b) => { return a * b; };
            Console.WriteLine("lambda delegate2:  " + multiplier(3, 5));




            //LAMBDA PREDICATE
            var greaterThan3 = new List<int> { 1, 2, 3, 4, 5, 6 }.Where(x => x > 3);

            foreach (int i in greaterThan3)
                Console.Write("Lambda in anonomoush method: " + i +", ");



           //Mosh lambda DELEGATE
           Func<int, int> square = number => number * number;
           Console.WriteLine(square(5));

            Console.ReadKey();
        }
    }
}
