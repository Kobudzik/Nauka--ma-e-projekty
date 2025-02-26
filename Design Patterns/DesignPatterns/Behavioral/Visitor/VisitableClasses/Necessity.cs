namespace Visitor.VisitableClasses;

public class Necessity(double item) : IVisitable
{
    private readonly double price = item;

    public double Accept(IVisitor visitor) => visitor.Visit(this);

    public double GetPrice() => price;
}
