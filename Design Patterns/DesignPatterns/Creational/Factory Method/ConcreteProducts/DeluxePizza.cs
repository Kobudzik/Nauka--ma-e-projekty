namespace DesignPatterns.FactoryMethod
{
    public class DeluxePizza : Pizza
    {
        private readonly decimal price = 10.5M;

        public override decimal GetPrice()
        {
            return price;
        }
    }
}
