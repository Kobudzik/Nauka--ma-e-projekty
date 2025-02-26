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

        waiter.ConstructPizza();
        Console.WriteLine(waiter.Pizza);

        Waiter waiter2 = new();

        waiter.PizzaBuilder = new SpicyPizzaBuilder();
        waiter.ConstructPizza();
        Console.WriteLine(waiter.Pizza);

        Console.ReadKey();
    }
}
