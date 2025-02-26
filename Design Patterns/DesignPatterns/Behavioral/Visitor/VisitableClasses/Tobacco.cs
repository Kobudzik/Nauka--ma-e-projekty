namespace Visitor.VisitableClasses;

public class Tobacco(double item) : IVisitable
{
    private readonly double price = item;

    public double Accept(IVisitor visitor)
    {
        return visitor.Visit(this);
    }

    public double GetPrice()
    {
        return price;
    }
}
