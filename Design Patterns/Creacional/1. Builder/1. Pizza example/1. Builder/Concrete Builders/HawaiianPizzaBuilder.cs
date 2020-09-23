using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Builder
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        //Concrete Builder
        public override void BuildDough() { pizza.Dough = "cross"; }
        public override void BuildSauce() { pizza.Sauce = "mild"; }
        public override void BuildTopping() { pizza.Topping = "ham + pineapple"; }
    }
}
