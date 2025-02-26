using AbstractFactoryContinents.Factories;
using System;

namespace AbstractFactoryContinents;

internal static class Program
{
    private static void Main()
    {
        AbstractContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new(africa);
        world.RunFoodChain();

        AbstractContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain();

        Console.ReadKey();
    }
}