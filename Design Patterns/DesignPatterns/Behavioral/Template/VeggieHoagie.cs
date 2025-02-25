using System;

namespace DesignPatterns.Template
{
    class VeggieHoagie : Hoagie
    {
        readonly String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        readonly String[] condimentsUsed = { "Oil", "Vinegar" };

        public override void AddCheese()
        {
        }

        public override void AddMeat()
        {
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding the condiments: ");
            foreach (String condiments in condimentsUsed)
                Console.WriteLine(condiments + " ");
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Adding the vegetables: ");
            foreach (String vegetables in veggiesUsed)
                Console.WriteLine(vegetables + " ");
        }

        public void MakeSandwitch()
        {
            CutBun();
        }

        public override bool CustomerWantsMeat()
        {
            return true;
        }

        public override bool CustomerWantsCheese()
        {
            return true;
        }
    }
}
