using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    ///deelgaci
    delegate int CombineTwoInts(int x, int y);
    delegate double MultiplyNumbers(int a, int b);
    delegate int MyDelegate(int x, int y);



    class Program
    {
        static void Main(string[] args)
        {


            //NO LAMBDA- no anonomus method- NAMED method
            int Sum(int x, int y)
            {
                return x + y;
            }


            //przypisanie- dwie metody
            //MyDelegate d = new MyDelegate(Sum);
            MyDelegate d = Sum;

            int result1 = d.Invoke(12, 15);
            Console.WriteLine("result 1:  " + result1);

            int result2 = d(12, 15);
            Console.WriteLine("result 2:  " + result2);

            //invoke czy nie- wynik ten sam



            //NO LAMBDA- anonomous method in void
            void Execute()
            {
                // Definicja metody anonimowej przy użyciu delegata
                MultiplyNumbers multiply = delegate (int number1, int number2)
                {
                    return number1 * number2;
                };

                //wykonanie
                Console.WriteLine("Anonomous method result- Execute:  " + multiply(4, 3)+ "  "+ multiply(4, 3).GetType());
            }

            Execute();


            //LAMBDA DELEGATE
            //  => GOES TO
            CombineTwoInts adder = (a, b) => { return a + b; };
            Console.WriteLine("lambda delegate:  " + adder(3, 5));

            //LAMBDA DELEGATE
            CombineTwoInts multiplier = (int a, int b) => { return a * b; };
            Console.WriteLine("lambda delegate2:  " + multiplier(3, 5));


            //LAMBDA IN ANONYMOUS METHOD
            var greaterThan3 = new List<int> { 1, 2, 3, 4, 5, 6 }.Where(x => x > 3);

            foreach (int i in greaterThan3)
                Console.Write("Lambda in anonomoush method: " + i +", ");

           

            Console.ReadKey();
        }
    }
}
