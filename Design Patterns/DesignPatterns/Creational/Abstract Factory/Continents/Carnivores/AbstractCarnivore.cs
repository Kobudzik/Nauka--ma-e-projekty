using AbstractFactoryContinents.Herbivores;

namespace AbstractFactoryContinents.Carnivores;

/// <summary>
/// The 'AbstractProductB' abstract class
/// </summary>
public abstract class AbstractCarnivore
{
    public abstract void Eat(AbstractHerbivore h);
}
