namespace DesignPatterns.Visitor
{
    public class Necessity : IVisitable
    {
        private readonly double price;

        public Necessity(double item)
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
