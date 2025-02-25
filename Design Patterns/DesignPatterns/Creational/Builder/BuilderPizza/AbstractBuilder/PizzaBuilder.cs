namespace DesignPatterns.Builder_Pizza
{
    //Abstract Builder
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;  //backing field
        public Pizza Pizza { get { return pizza; } }    //property

        public void CreateNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
}
