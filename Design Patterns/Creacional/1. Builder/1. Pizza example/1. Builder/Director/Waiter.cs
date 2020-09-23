using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Builder
{
    /** "Director, nadrorca" */
    public class Waiter
    {
        private PizzaBuilder _pizzaBuilder; //backing field

        public PizzaBuilder PizzaBuilder    //property
        {
            get { return _pizzaBuilder; }
            set { _pizzaBuilder = value; }
        }

        public Pizza Pizza { get { return _pizzaBuilder.Pizza; } } //property




        public void ConstructPizza()
        {
            _pizzaBuilder.CreateNewPizza();
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}
