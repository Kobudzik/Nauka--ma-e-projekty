namespace DesignPatterns.Visitor
{
    public class Tobacco : IVisitable
    {
        private readonly double price;

        public Tobacco(double item)
        {
            price = item;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
