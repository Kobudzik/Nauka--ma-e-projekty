using System;
using Visitor.ConcreteVisitors;
using Visitor.VisitableClasses;

namespace Visitor;

static class Program
{
    static void Main()
    {
        TaxVisitor taxCalc = new();
        TaxHolidayVisitor taxHolidayCalc = new();

        Necessity milk = new(3.47);
        Liquor vodka = new(11.99);

        Console.WriteLine("TAX PRICES\n");
        Console.WriteLine(milk.Accept(taxCalc) + "\n");
        Console.WriteLine(vodka.Accept(taxCalc) + "\n");

        Console.WriteLine("TAX HOLIDAY PRICES\n");
        Console.WriteLine(milk.Accept(taxHolidayCalc) + "\n");
        Console.WriteLine(vodka.Accept(taxHolidayCalc) + "\n");

        Console.Read();
    }
}
