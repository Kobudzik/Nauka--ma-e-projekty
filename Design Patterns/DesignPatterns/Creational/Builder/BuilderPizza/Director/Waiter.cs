using BuilderPizza.AbstractBuilder;
using BuilderPizza.Product;

namespace BuilderPizza.Director;

public class Waiter
{
    public PizzaBuilder PizzaBuilder { get; set; }

    public Pizza Pizza => PizzaBuilder.Pizza;

    public void ConstructPizza()
    {
        PizzaBuilder.CreateNewPizza();
        PizzaBuilder.BuildDough();
        PizzaBuilder.BuildSauce();
        PizzaBuilder.BuildTopping();
    }
}
