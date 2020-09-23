using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Factory_Method
{
    public class Program
    {
        public static Pizza PizzaFactory(PizzaType pizzaType)   // Factory METHOD- creator
        {
            switch (pizzaType)
            {
                case PizzaType.HamMushroom:
                    return new HamAndMushroomPizza();

                case PizzaType.Deluxe:
                    return new DeluxePizza();

                case PizzaType.Hawaiian:
                    return new HawaiianPizza();

                default:
                    break;
            }

            throw new System.NotSupportedException("The pizza type " + pizzaType.ToString() + " is not recognized.");
        }



        static void Main(string[] args)
        {
            Console.WriteLine(PizzaFactory(PizzaType.Hawaiian).GetPrice().ToString("C2"));    // $11.50
            Console.ReadKey();
        }
    }
}
