using FactoryMethod.AbstractProduct;
using FactoryMethod.ConcreteProducts;
using System;

namespace FactoryMethod;

public static class Program
{
    public static Pizza PizzaFactory(PizzaType pizzaType)   // Factory METHOD - creator
    {
        switch (pizzaType)
        {
            case PizzaType.HamMushroom:
            return new HamAndMushroomPizza();

            case PizzaType.Deluxe:
            return new DeluxePizza();

            case PizzaType.Hawaiian:
            return new HawaiianPizza();

            default:
            break;
        }

        throw new NotSupportedException("The pizza type " + pizzaType.ToString() + " is not recognized.");
    }

    static void Main()
    {
        Console.WriteLine(PizzaFactory(PizzaType.Hawaiian).GetPrice().ToString("C2")); // $11.50
        Console.ReadKey();
    }
}
