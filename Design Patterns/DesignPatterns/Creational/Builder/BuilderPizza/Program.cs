using BuilderPizza.ConcreteBuilders;
using BuilderPizza.Director;
using System;

namespace BuilderPizza;

static class Program
{
    public static void Main()
    {
        Waiter waiter = new()
        {
            PizzaBuilder = new HawaiianPizzaBuilder()
        };
        Client.BuildAndDisplayPizza(waiter);
        Waiter waiter2 = new();

        waiter.PizzaBuilder = new SpicyPizzaBuilder();
        Client.BuildAndDisplayPizza(waiter);

        Console.ReadKey();
    }
}
