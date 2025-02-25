using System;

namespace DesignPatterns.Template
{
    public class ItalianHoagie : Hoagie
    {
        private readonly String[] meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };
        private readonly String[] cheeseUsed = { "Provplone" };
        private readonly String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        private readonly String[] condimentsUsed = { "Oil", "Vinegar" };

        public override void AddCheese()
        {
            Console.WriteLine("Adding the cheese: ");
            foreach (String cheese in cheeseUsed)
                Console.Write(cheese + " ");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding the condiments: ");
            foreach (String condiments in condimentsUsed)
                Console.Write(condiments + " ");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Adding the meat: ");
            foreach (String meat in meatUsed)
                Console.Write(meat + " ");
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Adding the vegetables: ");
            foreach (String vegetables in veggiesUsed)
                Console.Write(vegetables + " ");
        }

        public void MakeSandwitch()
        {
            CutBun();
        }
    }
}