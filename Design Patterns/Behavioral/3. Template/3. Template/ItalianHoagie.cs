using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Template
{
    public class ItalianHoagie: Hoagie
    {
        String[] meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };
        String[] cheeseUsed = { "Provplone"};
        String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions" ,"Sweet Peppers"};
        String[] condimentsUsed = { "Oil","Vinegar"};


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

        public void makeSandwitch()
        {
            CutBun();
            
        }
    }
}
