using AbstractFactoryContinents.Carnivores;
using AbstractFactoryContinents.Herbivores;

namespace AbstractFactoryContinents.Factories;

/// <summary>
/// The 'ConcreteFactory2' class
/// </summary>
public class AmericaFactory : AbstractContinentFactory

{
    public override AbstractHerbivore CreateHerbivore()
    {
        return new Bison();
    }

    public override AbstractCarnivore CreateCarnivore()
    {
        return new Wolf();
    }
}