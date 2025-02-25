using System;

namespace DesignPatterns.Visitor
{
    //concrete visitor
    public class TaxVisitor : IVisitor
    {
        // This is created so that each item is sent to the
        // right version of visit() which is required by the
        // Visitor interface and defined below
        public TaxVisitor()
        {
        }

        // Calculates total price based on this being taxed
        // as a liquor item
        public double Visit(Liquor liquorItem)
        {
            Console.WriteLine("Liquor Item: Price with Tax");
            return liquorItem.GetPrice() * 1.18;
        }

        // Calculates total price based on this being taxed
        // as a tobacco item
        public double Visit(Tobacco tobaccoItem)
        {
            Console.WriteLine("Tobacco Item: Price with Tax");
            return tobaccoItem.GetPrice() * 1.32;
        }

        // Calculates total price based on this being taxed
        // as a necessity item
        public double Visit(Necessity necessityItem)
        {
            Console.WriteLine("Necessity Item: Price with Tax");
            return necessityItem.GetPrice();
        }
    }
}
