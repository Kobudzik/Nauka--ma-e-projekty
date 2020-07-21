using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
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
            MyDelegate d = new MyDelegate(Sum);
            int result1 = d.Invoke(12, 15);
            Console.WriteLine(result1);



            //NO LAMBDA- anonomous method
            void Execute()
            {
                // Definicja metody anonimowej przy użyciu delegata
                MultiplyNumbers multiply = delegate (int number1, int number2)
                {
                    return number1 * number2;
                };
                // Oraz wykonanie
                double result = multiply(4, 3);
            }


            //  => GOES TO
            //LAMBDA DELEGATE
            CombineTwoInts adder = (a, b) => { return a + b; };
            Console.WriteLine(adder(3, 5));

            //LAMBDA DELEGATE
            CombineTwoInts multiplier = (int a, int b) => { return a * b; };
            Console.WriteLine(multiplier(3, 5));


            //LAMBDA IN ANONYMOUS METHOD
            var greaterThan3 = new List<int> { 1, 2, 3, 4, 5, 6 }.Where(x => x > 3);

            foreach (int i in greaterThan3)
                Console.Write("{0} ", i);

           

            Console.ReadKey();
        }
    }
}
