using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Builder
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        //Concrete Builder
        public override void BuildDough() { pizza.Dough = "pan baked"; }
        public override void BuildSauce() { pizza.Sauce = "hot"; }
        public override void BuildTopping() { pizza.Topping = "pepparoni+salami"; }
    }
}
