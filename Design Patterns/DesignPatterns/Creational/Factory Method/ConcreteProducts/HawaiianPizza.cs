namespace DesignPatterns.FactoryMethod
{
    public class HawaiianPizza : Pizza
    {
        private readonly decimal price = 11.5M;

        public override decimal GetPrice()
        {
            return price;
        }
    }
}
