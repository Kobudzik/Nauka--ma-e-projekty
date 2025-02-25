namespace DesignPatterns.Builder_Pizza
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        //Concrete Builder
        public override void BuildDough() { pizza.Dough = "pan baked"; }
        public override void BuildSauce() { pizza.Sauce = "hot"; }
        public override void BuildTopping() { pizza.Topping = "pepparoni+salami"; }
    }
}
