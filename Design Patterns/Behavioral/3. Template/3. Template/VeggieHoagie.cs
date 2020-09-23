using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Template
{
    class VeggieHoagie:Hoagie
    { 
        String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        String[] condimentsUsed = { "Oil", "Vinegar" };

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

        public void makeSandwitch()
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

