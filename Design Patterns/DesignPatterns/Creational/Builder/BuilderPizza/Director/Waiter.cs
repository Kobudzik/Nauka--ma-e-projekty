namespace DesignPatterns.Builder_Pizza
{
    /** "Director, nadrorca" */
    public class Waiter
    {
        public PizzaBuilder PizzaBuilder { get; set; }

        public Pizza Pizza { get { return PizzaBuilder.Pizza; } } //property

        public void ConstructPizza()
        {
            PizzaBuilder.CreateNewPizza();
            PizzaBuilder.BuildDough();
            PizzaBuilder.BuildSauce();
            PizzaBuilder.BuildTopping();
        }
    }
}
