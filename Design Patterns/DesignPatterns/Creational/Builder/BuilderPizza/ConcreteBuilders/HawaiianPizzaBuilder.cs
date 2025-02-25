namespace DesignPatterns.Builder_Pizza
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        //Concrete Builder
        public override void BuildDough() { pizza.Dough = "cross"; }
        public override void BuildSauce() { pizza.Sauce = "mild"; }
        public override void BuildTopping() { pizza.Topping = "ham + pineapple"; }
    }
}
