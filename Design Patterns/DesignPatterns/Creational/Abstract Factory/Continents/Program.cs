using AbstractFactoryContinents.Factories;
using System;

namespace AbstractFactoryContinents;

internal static class Program
{
    private static void Main()
    {
        // Create and run the African animal world
        AbstractContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new(africa);
        world.RunFoodChain();

        // Create and run the American animal world
        AbstractContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain();

        // Wait for user input
        Console.ReadKey();
    }
}