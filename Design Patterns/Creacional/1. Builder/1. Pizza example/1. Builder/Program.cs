using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Builder
{
    class Program
    {
        public static void Main()
        {
            Waiter waiter = new Waiter();

            waiter.PizzaBuilder = new HawaiianPizzaBuilder();
            Client.BuildAndDisplayPizza(waiter);
            Waiter waiter2 = new Waiter();

            waiter.PizzaBuilder = new SpicyPizzaBuilder();
                Client.BuildAndDisplayPizza(waiter);

            Console.ReadKey();
        }
     }
}

