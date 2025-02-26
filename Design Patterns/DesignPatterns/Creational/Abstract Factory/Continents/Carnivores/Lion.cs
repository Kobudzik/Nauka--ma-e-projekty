using AbstractFactoryContinents.Herbivores;
using System;

namespace AbstractFactoryContinents.Carnivores;

/// <summary>
/// The 'ProductB1' class
/// </summary>
public class Lion : AbstractCarnivore
{
    public override void Eat(AbstractHerbivore h)
    {
        // Eat Wildebeest
        Console.WriteLine(GetType().Name + " eats " + h.GetType().Name);
    }
}
