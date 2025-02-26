using AbstractFactoryContinents.Carnivores;
using AbstractFactoryContinents.Herbivores;

namespace AbstractFactoryContinents.Factories;

/// <summary>
/// The 'ConcreteFactory1' class
/// </summary>
public class AfricaFactory : AbstractContinentFactory

{
    public override AbstractHerbivore CreateHerbivore()
    {
        return new Wildebeest();
    }

    public override AbstractCarnivore CreateCarnivore()
    {
        return new Lion();
    }
}