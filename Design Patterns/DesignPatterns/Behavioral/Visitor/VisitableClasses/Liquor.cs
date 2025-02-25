namespace DesignPatterns.Visitor
{
    public class Liquor : IVisitable
    {
        private readonly double price;

        public Liquor(double item)
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
