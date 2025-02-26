using AbstractFactoryContinents.Herbivores;
using System;

namespace AbstractFactoryContinents.Carnivores;

/// <summary>
/// The 'ProductB2' class
/// </summary>
public class Wolf : AbstractCarnivore
{
    public override void Eat(AbstractHerbivore h)
    {
        // Eat Bison

        Console.WriteLine(GetType().Name +
          " eats " + h.GetType().Name);
    }
}
