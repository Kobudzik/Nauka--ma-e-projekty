using BuilderPizza.Product;

namespace BuilderPizza.AbstractBuilder;

public abstract class PizzaBuilder
{
    public Pizza Pizza { get; protected set; }

    public void CreateNewPizza()
    {
        Pizza = new Pizza();
    }

    public abstract void BuildDough();
    public abstract void BuildSauce();
    public abstract void BuildTopping();
}
