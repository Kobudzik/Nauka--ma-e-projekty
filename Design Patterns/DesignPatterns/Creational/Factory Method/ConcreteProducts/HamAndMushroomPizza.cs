namespace DesignPatterns.FactoryMethod
{
    public class HamAndMushroomPizza : Pizza
    {
        private readonly decimal price = 8.5M;

        public override decimal GetPrice()
        {
            return price;
        }
    }
}
