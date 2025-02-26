using AbstractFactoryContinents.Carnivores;
using AbstractFactoryContinents.Herbivores;

namespace AbstractFactoryContinents.Factories;

/// <summary>
/// The 'AbstractFactory' abstract class
/// </summary>
public abstract class AbstractContinentFactory
{
    public abstract AbstractHerbivore CreateHerbivore();

    public abstract AbstractCarnivore CreateCarnivore();
}