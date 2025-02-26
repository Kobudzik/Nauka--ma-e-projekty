using BuilderPizza.AbstractBuilder;

namespace BuilderPizza.ConcreteBuilders;

public class HawaiianPizzaBuilder : PizzaBuilder
{
    public override void BuildDough() => Pizza.Dough = "cross";
    public override void BuildSauce() => Pizza.Sauce = "mild";
    public override void BuildTopping() => Pizza.Topping = "ham + pineapple";
}
