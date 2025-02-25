using System;

namespace DesignPatterns.Visitor
{
    static class Program
    {
        static void Main()
        {
            TaxVisitor taxCalc = new();
            TaxHolidayVisitor taxHolidayCalc = new();

            Necessity milk = new(3.47);
            Liquor vodka = new(11.99);
            Tobacco cigars = new(19.99);

            Console.WriteLine(milk.Accept(taxCalc) + "\n");
            Console.WriteLine(vodka.Accept(taxCalc) + "\n");
            Console.WriteLine(cigars.Accept(taxCalc) + "\n");

            Console.WriteLine("TAX HOLIDAY PRICES\n");

            Console.WriteLine(milk.Accept(taxHolidayCalc) + "\n");
            Console.WriteLine(vodka.Accept(taxHolidayCalc) + "\n");
            Console.WriteLine(cigars.Accept(taxHolidayCalc) + "\n");

            Console.Read();
        }
    }
}
