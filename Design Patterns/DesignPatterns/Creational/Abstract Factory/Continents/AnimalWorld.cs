using AbstractFactoryContinents.Carnivores;
using AbstractFactoryContinents.Factories;
using AbstractFactoryContinents.Herbivores;

namespace AbstractFactoryContinents;

/// <summary>
/// The 'Client' class
/// </summary>
public class AnimalWorld(AbstractContinentFactory factory)
{
    private readonly AbstractHerbivore _herbivore = factory.CreateHerbivore();
    private readonly AbstractCarnivore _carnivore = factory.CreateCarnivore();

    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}