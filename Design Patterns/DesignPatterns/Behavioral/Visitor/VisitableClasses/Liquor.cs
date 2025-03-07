﻿namespace Visitor.VisitableClasses;

public class Liquor(double item) : IVisitable
{
    private readonly double price = item;

    public double Accept(IVisitor visitor) => visitor.Visit(this);

    public double GetPrice() => price;
}
