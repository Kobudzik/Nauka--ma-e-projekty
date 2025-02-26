using System;
using Visitor.VisitableClasses;

namespace Visitor.ConcreteVisitors;

public class TaxVisitor : IVisitor
{
    // Calculates total price based on this being taxed as a liquor item
    public double Visit(Liquor liquorItem)
    {
        Console.WriteLine("Liquor Item: Price with Tax");
        return liquorItem.GetPrice() * 1.18;
    }

    // Calculates total price based on this being taxed as a tobacco item
    public double Visit(Tobacco tobaccoItem)
    {
        Console.WriteLine("Tobacco Item: Price with Tax");
        return tobaccoItem.GetPrice() * 1.32;
    }

    // Calculates total price based on this being taxed as a necessity item
    public double Visit(Necessity necessityItem)
    {
        Console.WriteLine("Necessity Item: Price with Tax");
        return necessityItem.GetPrice();
    }
}
